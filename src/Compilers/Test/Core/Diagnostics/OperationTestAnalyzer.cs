// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.UnitTests.Diagnostics
{
    public class BadStuffTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor InvalidExpressionDescriptor;

        public static readonly DiagnosticDescriptor InvalidStatementDescriptor;

        public static readonly DiagnosticDescriptor IsInvalidDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 1844, 1959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 1850, 1957);

                    return f_25076_1857_1956(InvalidExpressionDescriptor, InvalidStatementDescriptor, IsInvalidDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 1844, 1959);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_1857_1956(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item3)
                    {
                        var return_v = ImmutableArray.Create(item1, item2, item3);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 1857, 1956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 1739, 1970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 1739, 1970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 1982, 3366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 2070, 2812);

                f_25076_2070_2811(context, (operationContext) =>
                     {
                         var invalidOperation = (IInvalidOperation)operationContext.Operation;
                         if (invalidOperation.Type == null)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(InvalidStatementDescriptor, operationContext.Operation.Syntax.GetLocation()));
                         }
                         else
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(InvalidExpressionDescriptor, operationContext.Operation.Syntax.GetLocation()));
                         }
                     }, OperationKind.Invalid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 2828, 3355);

                f_25076_2828_3354(
                            context, (operationContext) =>
                                 {
                                     if (operationContext.Operation.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                                     {
                                         operationContext.ReportDiagnostic(Diagnostic.Create(IsInvalidDescriptor, operationContext.Operation.Syntax.GetLocation()));
                                     }
                                 }, OperationKind.Invocation, OperationKind.Invalid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 1982, 3366);

                int
                f_25076_2070_2811(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 2070, 2811);
                    return 0;
                }


                int
                f_25076_2828_3354(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 2828, 3354);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 1982, 3366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 1982, 3366);
            }
        }

        public BadStuffTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 708, 3373);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 708, 3373);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 708, 3373);
        }


        static BadStuffTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 708, 3373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 823, 1093);
            InvalidExpressionDescriptor = f_25076_853_1093("InvalidExpression", "Invalid Expression", "Invalid expression found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 1150, 1416);
            InvalidStatementDescriptor = f_25076_1179_1416("InvalidStatement", "Invalid Statement", "Invalid statement found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 1473, 1726);
            IsInvalidDescriptor = f_25076_1495_1726("IsInvalid", "Is Invalid", "Operation found that is invalid.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 708, 3373);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 708, 3373);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 708, 3373);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_853_1093(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 853, 1093);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_1179_1416(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 1179, 1416);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_1495_1726(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 1495, 1726);
            return return_v;
        }

    }
    public class OwningSymbolTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor ExpressionDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 3956, 4015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 3962, 4013);

                    return f_25076_3969_4012(ExpressionDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 3956, 4015);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_3969_4012(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 3969, 4012);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 3851, 4026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 3851, 4026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 4038, 5080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 4126, 5069);

                f_25076_4126_5068(context, (operationBlockContext) =>
                    {
                        if (operationBlockContext.Compilation.Language != "Stumble")
                        {
                            operationBlockContext.RegisterOperationAction(
                                 (operationContext) =>
                                 {
                                     if (operationContext.ContainingSymbol.Name.StartsWith("Funky") && operationContext.Compilation.Language != "Mumble")
                                     {
                                         operationContext.ReportDiagnostic(Diagnostic.Create(ExpressionDescriptor, operationContext.Operation.Syntax.GetLocation()));
                                     }
                                 },
                                 OperationKind.LocalReference,
                                 OperationKind.Literal);
                        }
                    });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 4038, 5080);

                int
                f_25076_4126_5068(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 4126, 5068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 4038, 5080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 4038, 5080);
            }
        }

        public OwningSymbolTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 3479, 5087);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 3479, 5087);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 3479, 5087);
        }


        static OwningSymbolTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 3479, 5087);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 3598, 3838);
            ExpressionDescriptor = f_25076_3621_3838("Expression", "Expression", "Expression found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 3479, 5087);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 3479, 5087);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 3479, 5087);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_3621_3838(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 3621, 3838);
            return return_v;
        }

    }
    public class BigForTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor BigForDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 5911, 5966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 5917, 5964);

                    return f_25076_5924_5963(BigForDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 5911, 5966);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_5924_5963(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 5924, 5963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 5806, 5977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 5806, 5977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 5989, 6158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6077, 6147);

                f_25076_6077_6146(context, AnalyzeOperation, OperationKind.Loop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 5989, 6158);

                int
                f_25076_6077_6146(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 6077, 6146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 5989, 6158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 5989, 6158);
            }
        }

        private void AnalyzeOperation(OperationAnalysisContext operationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 6170, 11594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6267, 6332);

                ILoopOperation
                loop = (ILoopOperation)operationContext.Operation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6346, 11583) || true) && (f_25076_6350_6363(loop) == LoopKind.For)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 6346, 11583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6413, 6465);

                    IForLoopOperation
                    forLoop = (IForLoopOperation)loop
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6483, 6527);

                    IOperation
                    forCondition = f_25076_6509_6526(forLoop)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6547, 11568) || true) && (f_25076_6551_6568(forCondition) == OperationKind.Binary)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 6547, 11568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6634, 6694);

                        IBinaryOperation
                        condition = (IBinaryOperation)forCondition
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6716, 6765);

                        IOperation
                        conditionLeft = f_25076_6743_6764(condition)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6787, 6838);

                        IOperation
                        conditionRight = f_25076_6815_6837(condition)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 6862, 11549) || true) && (conditionRight.ConstantValue.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(25076, 6866, 6991) && f_25076_6932_6963(f_25076_6932_6951(conditionRight)) == SpecialType.System_Int32) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 6866, 7070) && f_25076_7020_7038(conditionLeft) == OperationKind.LocalReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 6862, 11549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7214, 7270);

                            int
                            testValue = (int)conditionRight.ConstantValue.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7296, 7372);

                            ILocalSymbol
                            testVariable = f_25076_7324_7371(((ILocalReferenceOperation)conditionLeft))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7400, 11526) || true) && (forLoop.Before.Length == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 7400, 11526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7488, 7525);

                                IOperation
                                setup = f_25076_7507_7521(forLoop)[0]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7555, 11499) || true) && (f_25076_7559_7569(setup) == OperationKind.ExpressionStatement && (DynAbs.Tracing.TraceSender.Expression_True(25076, 7559, 7697) && f_25076_7610_7663(f_25076_7610_7658(((IExpressionStatementOperation)setup))) == OperationKind.SimpleAssignment))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 7555, 11499);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7763, 7885);

                                    ISimpleAssignmentOperation
                                    setupAssignment = (ISimpleAssignmentOperation)f_25076_7836_7884(((IExpressionStatementOperation)setup))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 7919, 11468) || true) && (f_25076_7923_7950(f_25076_7923_7945(setupAssignment)) == OperationKind.LocalReference && (DynAbs.Tracing.TraceSender.Expression_True(25076, 7923, 8095) && f_25076_8023_8079(((ILocalReferenceOperation)f_25076_8050_8072(setupAssignment))) == testVariable) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 7923, 8180) && f_25076_8136_8157(setupAssignment).ConstantValue.HasValue) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 7923, 8287) && f_25076_8221_8259(f_25076_8221_8247(f_25076_8221_8242(setupAssignment))) == SpecialType.System_Int32))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 7919, 11468);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 8483, 8549);

                                        int
                                        initialValue = (int)f_25076_8507_8528(setupAssignment).ConstantValue.Value
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 8589, 11433) || true) && (forLoop.AtLoopBottom.Length == 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 8589, 11433);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 8707, 8752);

                                            IOperation
                                            advance = f_25076_8728_8748(forLoop)[0]
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 8794, 11394) || true) && (f_25076_8798_8810(advance) == OperationKind.ExpressionStatement)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 8794, 11394);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 8937, 9019);

                                                IOperation
                                                advanceExpression = f_25076_8968_9018(((IExpressionStatementOperation)advance))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9067, 9104);

                                                Optional<object>
                                                advanceIncrementOpt
                                                = default(Optional<object>);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9150, 9191);

                                                BinaryOperatorKind?
                                                advanceOperationCode
                                                = default(BinaryOperatorKind?);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9237, 9346);

                                                f_25076_9237_9345(this, testVariable, advanceExpression, out advanceOperationCode, out advanceIncrementOpt);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9394, 11351) || true) && (advanceIncrementOpt.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(25076, 9398, 9459) && f_25076_9430_9459(advanceOperationCode)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 9394, 11351);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9557, 9609);

                                                    var
                                                    incrementValue = (int)advanceIncrementOpt.Value
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9659, 10010) || true) && (f_25076_9663_9689(advanceOperationCode) == BinaryOperatorKind.Subtract)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 9659, 10010);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9826, 9872);

                                                        advanceOperationCode = BinaryOperatorKind.Add;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 9926, 9959);

                                                        incrementValue = -incrementValue;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 9659, 10010);
                                                    }

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 10062, 11304) || true) && (f_25076_10066_10092(advanceOperationCode) == BinaryOperatorKind.Add && (DynAbs.Tracing.TraceSender.Expression_True(25076, 10066, 10194) && incrementValue != 0) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 10066, 10771) && (f_25076_10252_10274(condition) == BinaryOperatorKind.LessThan || (DynAbs.Tracing.TraceSender.Expression_False(25076, 10252, 10423) || f_25076_10363_10385(condition) == BinaryOperatorKind.LessThanOrEqual) || (DynAbs.Tracing.TraceSender.Expression_False(25076, 10252, 10535) || f_25076_10481_10503(condition) == BinaryOperatorKind.NotEquals) || (DynAbs.Tracing.TraceSender.Expression_False(25076, 10252, 10649) || f_25076_10593_10615(condition) == BinaryOperatorKind.GreaterThan) || (DynAbs.Tracing.TraceSender.Expression_False(25076, 10252, 10770) || f_25076_10707_10729(condition) == BinaryOperatorKind.GreaterThanOrEqual))))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 10062, 11304);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 10877, 10942);

                                                        int
                                                        iterationCount = (testValue - initialValue) / incrementValue
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 10996, 11253) || true) && (iterationCount >= 1000000)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 10996, 11253);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 11139, 11198);

                                                            f_25076_11139_11197(this, operationContext, f_25076_11164_11178(forLoop), BigForDescriptor);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 10996, 11253);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 10062, 11304);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 9394, 11351);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 8794, 11394);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 8589, 11433);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 7919, 11468);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 7555, 11499);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 7400, 11526);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 6862, 11549);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 6547, 11568);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 6346, 11583);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 6170, 11594);

                Microsoft.CodeAnalysis.Operations.LoopKind
                f_25076_6350_6363(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.LoopKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6350, 6363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25076_6509_6526(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6509, 6526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_6551_6568(Microsoft.CodeAnalysis.IOperation?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6551, 6568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_6743_6764(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6743, 6764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_6815_6837(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6815, 6837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_6932_6951(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6932, 6951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_6932_6963(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 6932, 6963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_7020_7038(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7020, 7038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_7324_7371(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7324, 7371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25076_7507_7521(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Before;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7507, 7521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_7559_7569(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7559, 7569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_7610_7658(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7610, 7658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_7610_7663(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7610, 7663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_7836_7884(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7836, 7884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_7923_7945(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7923, 7945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_7923_7950(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 7923, 7950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_8050_8072(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8050, 8072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_8023_8079(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8023, 8079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_8136_8157(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8136, 8157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_8221_8242(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8221, 8242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_8221_8247(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8221, 8247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_8221_8259(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8221, 8259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_8507_8528(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8507, 8528);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25076_8728_8748(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.AtLoopBottom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8728, 8748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_8798_8810(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8798, 8810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_8968_9018(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 8968, 9018);
                    return return_v;
                }


                int
                f_25076_9237_9345(Microsoft.CodeAnalysis.UnitTests.Diagnostics.BigForTestAnalyzer
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                testVariable, Microsoft.CodeAnalysis.IOperation
                advanceExpression, out Microsoft.CodeAnalysis.Operations.BinaryOperatorKind?
                advanceOperationCode, out Microsoft.CodeAnalysis.Optional<object>
                advanceIncrementOpt)
                {
                    this_param.GetOperationKindAndValue(testVariable, advanceExpression, out advanceOperationCode, out advanceIncrementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 9237, 9345);
                    return 0;
                }


                bool
                f_25076_9430_9459(Microsoft.CodeAnalysis.Operations.BinaryOperatorKind?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 9430, 9459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_9663_9689(Microsoft.CodeAnalysis.Operations.BinaryOperatorKind?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 9663, 9689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10066_10092(Microsoft.CodeAnalysis.Operations.BinaryOperatorKind?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10066, 10092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10252_10274(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10252, 10274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10363_10385(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10363, 10385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10481_10503(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10481, 10503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10593_10615(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10593, 10615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_10707_10729(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 10707, 10729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25076_11164_11178(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 11164, 11178);
                    return return_v;
                }


                int
                f_25076_11139_11197(Microsoft.CodeAnalysis.UnitTests.Diagnostics.BigForTestAnalyzer
                this_param, Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext
                context, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor)
                {
                    this_param.Report(context, syntax, descriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 11139, 11197);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 6170, 11594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 6170, 11594);
            }
        }

        private void GetOperationKindAndValue(
                    ILocalSymbol testVariable, IOperation advanceExpression,
                    out BinaryOperatorKind? advanceOperationCode, out Optional<object> advanceIncrementOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 11606, 15153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 11840, 11867);

                advanceIncrementOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 11881, 11909);

                advanceOperationCode = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 11925, 15142) || true) && (f_25076_11929_11951(advanceExpression) == OperationKind.SimpleAssignment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 11925, 15142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 12019, 12112);

                    ISimpleAssignmentOperation
                    advanceAssignment = (ISimpleAssignmentOperation)advanceExpression
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 12132, 13520) || true) && (f_25076_12136_12165(f_25076_12136_12160(advanceAssignment)) == OperationKind.LocalReference && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12136, 12296) && f_25076_12222_12280(((ILocalReferenceOperation)f_25076_12249_12273(advanceAssignment))) == testVariable) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12136, 12373) && f_25076_12321_12349(f_25076_12321_12344(advanceAssignment)) == OperationKind.Binary) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12136, 12466) && f_25076_12398_12438(f_25076_12398_12426(f_25076_12398_12421(advanceAssignment))) == SpecialType.System_Int32))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 12132, 13520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 12624, 12702);

                        IBinaryOperation
                        advanceOperation = (IBinaryOperation)f_25076_12678_12701(advanceAssignment)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 12724, 13501) || true) && (f_25076_12728_12759(advanceOperation) == null && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12728, 12861) && f_25076_12796_12829(f_25076_12796_12824(advanceOperation)) == OperationKind.LocalReference) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12728, 12968) && f_25076_12890_12952(((ILocalReferenceOperation)f_25076_12917_12945(advanceOperation))) == testVariable) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12728, 13049) && f_25076_12997_13026(advanceOperation).ConstantValue.HasValue) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 12728, 13152) && f_25076_13078_13124(f_25076_13078_13112(f_25076_13078_13107(advanceOperation))) == SpecialType.System_Int32))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 12724, 13501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 13333, 13399);

                            advanceIncrementOpt = f_25076_13355_13398(f_25076_13355_13384(advanceOperation));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 13425, 13478);

                            advanceOperationCode = f_25076_13448_13477(advanceOperation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 12724, 13501);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 12132, 13520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 11925, 15142);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 11925, 15142);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 13554, 15142) || true) && (f_25076_13558_13580(advanceExpression) == OperationKind.CompoundAssignment)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 13554, 15142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 13650, 13747);

                        ICompoundAssignmentOperation
                        advanceAssignment = (ICompoundAssignmentOperation)advanceExpression
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 13767, 14419) || true) && (f_25076_13771_13800(f_25076_13771_13795(advanceAssignment)) == OperationKind.LocalReference && (DynAbs.Tracing.TraceSender.Expression_True(25076, 13771, 13931) && f_25076_13857_13915(((ILocalReferenceOperation)f_25076_13884_13908(advanceAssignment))) == testVariable) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 13771, 14002) && f_25076_13956_13979(advanceAssignment).ConstantValue.HasValue) && (DynAbs.Tracing.TraceSender.Expression_True(25076, 13771, 14095) && f_25076_14027_14067(f_25076_14027_14055(f_25076_14027_14050(advanceAssignment))) == SpecialType.System_Int32))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 13767, 14419);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14264, 14324);

                            advanceIncrementOpt = f_25076_14286_14323(f_25076_14286_14309(advanceAssignment));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14346, 14400);

                            advanceOperationCode = f_25076_14369_14399(advanceAssignment);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 13767, 14419);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 13554, 15142);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 13554, 15142);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14453, 15142) || true) && (f_25076_14457_14479(advanceExpression) == OperationKind.Increment)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 14453, 15142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14540, 14641);

                            IIncrementOrDecrementOperation
                            advanceAssignment = (IIncrementOrDecrementOperation)advanceExpression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14661, 15127) || true) && (f_25076_14665_14694(f_25076_14665_14689(advanceAssignment)) == OperationKind.LocalReference && (DynAbs.Tracing.TraceSender.Expression_True(25076, 14665, 14825) && f_25076_14751_14809(((ILocalReferenceOperation)f_25076_14778_14802(advanceAssignment))) == testVariable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 14661, 15127);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 14994, 15040);

                                advanceIncrementOpt = f_25076_15016_15039(1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 15062, 15108);

                                advanceOperationCode = BinaryOperatorKind.Add;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 14661, 15127);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 14453, 15142);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 13554, 15142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 11925, 15142);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 11606, 15153);

                Microsoft.CodeAnalysis.OperationKind
                f_25076_11929_11951(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 11929, 11951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12136_12160(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12136, 12160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_12136_12165(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12136, 12165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12249_12273(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12249, 12273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_12222_12280(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12222, 12280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12321_12344(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12321, 12344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_12321_12349(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12321, 12349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12398_12421(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12398, 12421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_12398_12426(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12398, 12426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_12398_12438(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12398, 12438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12678_12701(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12678, 12701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25076_12728_12759(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12728, 12759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12796_12824(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12796, 12824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_12796_12829(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12796, 12829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12917_12945(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12917, 12945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_12890_12952(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12890, 12952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_12997_13026(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 12997, 13026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_13078_13107(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13078, 13107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_13078_13112(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13078, 13112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_13078_13124(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13078, 13124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_13355_13384(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13355, 13384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object?>
                f_25076_13355_13398(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13355, 13398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_13448_13477(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13448, 13477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_13558_13580(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13558, 13580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_13771_13795(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13771, 13795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_13771_13800(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13771, 13800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_13884_13908(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13884, 13908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_13857_13915(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13857, 13915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_13956_13979(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 13956, 13979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_14027_14050(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14027, 14050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_14027_14055(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14027, 14055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_14027_14067(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14027, 14067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_14286_14309(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14286, 14309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object?>
                f_25076_14286_14323(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14286, 14323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25076_14369_14399(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14369, 14399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_14457_14479(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14457, 14479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_14665_14689(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14665, 14689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25076_14665_14694(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14665, 14694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25076_14778_14802(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14778, 14802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25076_14751_14809(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 14751, 14809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object>
                f_25076_15016_15039(int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Optional<object>((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 15016, 15039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 11606, 15153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 11606, 15153);
            }
        }

        private static int Abs(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 15165, 15268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 15223, 15257);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(25076, 15230, 15239) || ((value < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(25076, 15242, 15248)) || DynAbs.Tracing.TraceSender.Conditional_F3(25076, 15251, 15256))) ? -value : value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 15165, 15268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 15165, 15268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 15165, 15268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 15280, 15499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 15410, 15488);

                context.ReportDiagnostic(f_25076_15435_15486(descriptor, f_25076_15465_15485(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 15280, 15499);

                Microsoft.CodeAnalysis.Location
                f_25076_15465_15485(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 15465, 15485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_15435_15486(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 15435, 15486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 15280, 15499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 15280, 15499);
            }
        }

        public BigForTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 5167, 15506);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 5167, 15506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 5167, 15506);
        }


        static BigForTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 5167, 15506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 5324, 5359);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 5416, 5692);
            BigForDescriptor = f_25076_5435_5692("BigForRule", "Big For Loop", "For loop iterates more than one million times", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 5167, 15506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 5167, 15506);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 5167, 15506);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_5435_5692(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 5435, 5692);
            return return_v;
        }

    }
    public class SwitchTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor SparseSwitchDescriptor;

        public static readonly DiagnosticDescriptor NoDefaultSwitchDescriptor;

        public static readonly DiagnosticDescriptor OnlyDefaultSwitchDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 17020, 17274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 17056, 17259);

                    return f_25076_17063_17258(SparseSwitchDescriptor, NoDefaultSwitchDescriptor, OnlyDefaultSwitchDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 17020, 17274);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_17063_17258(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item3)
                    {
                        var return_v = ImmutableArray.Create(item1, item2, item3);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 17063, 17258);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 16915, 17285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 16915, 17285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 17297, 25839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 17385, 25828);

                f_25076_17385_25827(context, (operationContext) =>
                     {
                         ISwitchOperation switchOperation = (ISwitchOperation)operationContext.Operation;
                         long minCaseValue = long.MaxValue;
                         long maxCaseValue = long.MinValue;
                         long caseValueCount = 0;
                         bool hasDefault = false;
                         bool hasNonDefault = false;
                         foreach (ISwitchCaseOperation switchCase in switchOperation.Cases)
                         {
                             foreach (ICaseClauseOperation clause in switchCase.Clauses)
                             {
                                 switch (clause.CaseKind)
                                 {
                                     case CaseKind.SingleValue:
                                         {
                                             hasNonDefault = true;
                                             ISingleValueCaseClauseOperation singleValueClause = (ISingleValueCaseClauseOperation)clause;
                                             IOperation singleValueExpression = singleValueClause.Value;
                                             if (singleValueExpression != null &&
                                                 singleValueExpression.ConstantValue.HasValue &&
                                                 singleValueExpression.Type.SpecialType == SpecialType.System_Int32)
                                             {
                                                 int singleValue = (int)singleValueExpression.ConstantValue.Value;
                                                 caseValueCount += IncludeClause(singleValue, singleValue, ref minCaseValue, ref maxCaseValue);
                                             }
                                             else
                                             {
                                                 return;
                                             }

                                             break;
                                         }
                                     case CaseKind.Range:
                                         {
                                             hasNonDefault = true;
                                             IRangeCaseClauseOperation rangeClause = (IRangeCaseClauseOperation)clause;
                                             IOperation rangeMinExpression = rangeClause.MinimumValue;
                                             IOperation rangeMaxExpression = rangeClause.MaximumValue;
                                             if (rangeMinExpression != null &&
                                                 rangeMinExpression.ConstantValue.HasValue &&
                                                 rangeMinExpression.Type.SpecialType == SpecialType.System_Int32 &&
                                                 rangeMaxExpression != null &&
                                                 rangeMaxExpression.ConstantValue.HasValue &&
                                                 rangeMaxExpression.Type.SpecialType == SpecialType.System_Int32)
                                             {
                                                 int rangeMinValue = (int)rangeMinExpression.ConstantValue.Value;
                                                 int rangeMaxValue = (int)rangeMaxExpression.ConstantValue.Value;
                                                 caseValueCount += IncludeClause(rangeMinValue, rangeMaxValue, ref minCaseValue, ref maxCaseValue);
                                             }
                                             else
                                             {
                                                 return;
                                             }

                                             break;
                                         }
                                     case CaseKind.Relational:
                                         {
                                             hasNonDefault = true;
                                             IRelationalCaseClauseOperation relationalClause = (IRelationalCaseClauseOperation)clause;
                                             IOperation relationalValueExpression = relationalClause.Value;
                                             if (relationalValueExpression != null &&
                                                 relationalValueExpression.ConstantValue.HasValue &&
                                                 relationalValueExpression.Type.SpecialType == SpecialType.System_Int32)
                                             {
                                                 int rangeMinValue = int.MaxValue;
                                                 int rangeMaxValue = int.MinValue;
                                                 int relationalValue = (int)relationalValueExpression.ConstantValue.Value;
                                                 switch (relationalClause.Relation)
                                                 {
                                                     case BinaryOperatorKind.Equals:
                                                         rangeMinValue = relationalValue;
                                                         rangeMaxValue = relationalValue;
                                                         break;
                                                     case BinaryOperatorKind.NotEquals:
                                                         return;
                                                     case BinaryOperatorKind.LessThan:
                                                         rangeMinValue = int.MinValue;
                                                         rangeMaxValue = relationalValue - 1;
                                                         break;
                                                     case BinaryOperatorKind.LessThanOrEqual:
                                                         rangeMinValue = int.MinValue;
                                                         rangeMaxValue = relationalValue;
                                                         break;
                                                     case BinaryOperatorKind.GreaterThanOrEqual:
                                                         rangeMinValue = relationalValue;
                                                         rangeMaxValue = int.MaxValue;
                                                         break;
                                                     case BinaryOperatorKind.GreaterThan:
                                                         rangeMinValue = relationalValue + 1;
                                                         rangeMaxValue = int.MaxValue;
                                                         break;
                                                 }

                                                 caseValueCount += IncludeClause(rangeMinValue, rangeMaxValue, ref minCaseValue, ref maxCaseValue);
                                             }
                                             else
                                             {
                                                 return;
                                             }

                                             break;
                                         }
                                     case CaseKind.Default:
                                         {
                                             hasDefault = true;
                                             break;
                                         }
                                 }
                             }
                         }

                         long span = maxCaseValue - minCaseValue + 1;
                         if (caseValueCount == 0 && !hasDefault ||
                             caseValueCount != 0 && span / caseValueCount > 100)
                         {
                             Report(operationContext, switchOperation.Value.Syntax, SparseSwitchDescriptor);
                         }
                         if (!hasDefault)
                         {
                             Report(operationContext, switchOperation.Value.Syntax, NoDefaultSwitchDescriptor);
                         }
                         if (hasDefault && !hasNonDefault)
                         {
                             Report(operationContext, switchOperation.Value.Syntax, OnlyDefaultSwitchDescriptor);
                         }
                     }, OperationKind.Switch);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 17297, 25839);

                int
                f_25076_17385_25827(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 17385, 25827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 17297, 25839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 17297, 25839);
            }
        }

        private static int IncludeClause(int clauseMinValue, int clauseMaxValue, ref long minCaseValue, ref long maxCaseValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 25851, 26304);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 25994, 26106) || true) && (clauseMinValue < minCaseValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 25994, 26106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26061, 26091);

                    minCaseValue = clauseMinValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 25994, 26106);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26122, 26234) || true) && (clauseMaxValue > maxCaseValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 26122, 26234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26189, 26219);

                    maxCaseValue = clauseMaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 26122, 26234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26250, 26293);

                return clauseMaxValue - clauseMinValue + 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 25851, 26304);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 25851, 26304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 25851, 26304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 26316, 26535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26446, 26524);

                context.ReportDiagnostic(f_25076_26471_26522(descriptor, f_25076_26501_26521(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 26316, 26535);

                Microsoft.CodeAnalysis.Location
                f_25076_26501_26521(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 26501, 26521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_26471_26522(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 26471, 26522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 26316, 26535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 26316, 26535);
            }
        }

        public SwitchTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 15584, 26542);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 15584, 26542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 15584, 26542);
        }


        static SwitchTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 15584, 26542);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 15741, 15776);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 15833, 16117);
            SparseSwitchDescriptor = f_25076_15858_16117("SparseSwitchRule", "Sparse switch", "Switch has less than one percent density", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 16174, 16454);
            NoDefaultSwitchDescriptor = f_25076_16202_16454("NoDefaultSwitchRule", "No default switch", "Switch has no default case", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 16511, 16801);
            OnlyDefaultSwitchDescriptor = f_25076_16541_16801("OnlyDefaultSwitchRule", "Only default switch", "Switch only has a default case", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 15584, 26542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 15584, 26542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 15584, 26542);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_15858_16117(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 15858, 16117);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_16202_16454(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 16202, 16454);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_16541_16801(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 16541, 16801);
            return return_v;
        }

    }
    public class InvocationTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor BigParamArrayArgumentsDescriptor;

        public static readonly DiagnosticDescriptor OutOfNumericalOrderArgumentsDescriptor;

        public static readonly DiagnosticDescriptor UseDefaultArgumentDescriptor;

        public static readonly DiagnosticDescriptor InvalidArgumentDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 28453, 28802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 28489, 28787);

                    return f_25076_28496_28786(BigParamArrayArgumentsDescriptor, OutOfNumericalOrderArgumentsDescriptor, UseDefaultArgumentDescriptor, InvalidArgumentDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 28453, 28802);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_28496_28786(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item3, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item4)
                    {
                        var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 28496, 28786);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 28348, 28813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 28348, 28813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 28825, 31235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 28913, 31224);

                f_25076_28913_31223(context, (operationContext) =>
                     {
                         IInvocationOperation invocation = (IInvocationOperation)operationContext.Operation;
                         long priorArgumentValue = long.MinValue;
                         foreach (IArgumentOperation argument in invocation.Arguments)
                         {
                             if (argument.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(InvalidArgumentDescriptor, argument.Syntax.GetLocation()));
                                 return;
                             }

                             if (argument.ArgumentKind == ArgumentKind.DefaultValue)
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(UseDefaultArgumentDescriptor, invocation.Syntax.GetLocation(), argument.Parameter.Name));
                             }

                             TestAscendingArgument(operationContext, argument.Value, ref priorArgumentValue);

                             if (argument.ArgumentKind == ArgumentKind.ParamArray)
                             {
                                 if (argument.Value is IArrayCreationOperation arrayArgument)
                                 {
                                     var initializer = arrayArgument.Initializer;
                                     if (initializer != null)
                                     {
                                         if (initializer.ElementValues.Length > 10)
                                         {
                                             Report(operationContext, invocation.Syntax, BigParamArrayArgumentsDescriptor);
                                         }

                                         foreach (IOperation element in initializer.ElementValues)
                                         {
                                             TestAscendingArgument(operationContext, element, ref priorArgumentValue);
                                         }
                                     }
                                 }
                             }
                         }
                     }, OperationKind.Invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 28825, 31235);

                int
                f_25076_28913_31223(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 28913, 31223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 28825, 31235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 28825, 31235);
            }
        }

        private static void TestAscendingArgument(OperationAnalysisContext operationContext, IOperation argument, ref long priorArgumentValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 31247, 31924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31406, 31462);

                Optional<object>
                argumentValue = f_25076_31439_31461(argument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31476, 31913) || true) && (argumentValue.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(25076, 31480, 31559) && f_25076_31506_31531(f_25076_31506_31519(argument)) == SpecialType.System_Int32))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 31476, 31913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31593, 31640);

                    int
                    integerArgument = (int)argumentValue.Value
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31658, 31841) || true) && (integerArgument < priorArgumentValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 31658, 31841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31740, 31822);

                        f_25076_31740_31821(operationContext, f_25076_31765_31780(argument), OutOfNumericalOrderArgumentsDescriptor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 31658, 31841);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 31861, 31898);

                    priorArgumentValue = integerArgument;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 31476, 31913);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 31247, 31924);

                Microsoft.CodeAnalysis.Optional<object?>
                f_25076_31439_31461(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 31439, 31461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25076_31506_31519(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 31506, 31519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25076_31506_31531(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 31506, 31531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25076_31765_31780(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 31765, 31780);
                    return return_v;
                }


                int
                f_25076_31740_31821(Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext
                context, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor)
                {
                    Report(context, syntax, descriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 31740, 31821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 31247, 31924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 31247, 31924);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 31936, 32162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 32073, 32151);

                context.ReportDiagnostic(f_25076_32098_32149(descriptor, f_25076_32128_32148(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 31936, 32162);

                Microsoft.CodeAnalysis.Location
                f_25076_32128_32148(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 32128, 32148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_32098_32149(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 32098, 32149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 31936, 32162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 31936, 32162);
            }
        }

        public InvocationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 26624, 32169);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 26624, 32169);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 26624, 32169);
        }


        static InvocationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 26624, 32169);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26785, 26820);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 26877, 27169);
            BigParamArrayArgumentsDescriptor = f_25076_26912_27169("BigParamarrayRule", "Big Paramarray", "Paramarray has more than 10 elements", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 27226, 27545);
            OutOfNumericalOrderArgumentsDescriptor = f_25076_27267_27545("OutOfOrderArgumentsRule", "Out of order arguments", "Argument values are not in increasing order", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 27602, 27897);
            UseDefaultArgumentDescriptor = f_25076_27633_27897("UseDefaultArgument", "Use default argument", "Invocation uses default argument {0}", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 27954, 28234);
            InvalidArgumentDescriptor = f_25076_27982_28234("InvalidArgument", "Invalid argument", "Invocation has invalid argument", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 26624, 32169);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 26624, 32169);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 26624, 32169);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_26912_27169(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 26912, 27169);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_27267_27545(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 27267, 27545);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_27633_27897(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 27633, 27897);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_27982_28234(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 27982, 28234);
            return return_v;
        }

    }
    public class SeventeenTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor SeventeenDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 33012, 33070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 33018, 33068);

                    return f_25076_33025_33067(SeventeenDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 33012, 33070);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_33025_33067(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 33025, 33067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 32907, 33081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 32907, 33081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 33093, 33831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 33181, 33820);

                f_25076_33181_33819(context, (operationContext) =>
                     {
                         ILiteralOperation literal = (ILiteralOperation)operationContext.Operation;
                         if (literal.Type.SpecialType == SpecialType.System_Int32 &&
                             literal.ConstantValue.HasValue &&
                             (int)literal.ConstantValue.Value == 17)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(SeventeenDescriptor, literal.Syntax.GetLocation()));
                         }
                     }, OperationKind.Literal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 33093, 33831);

                int
                f_25076_33181_33819(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 33181, 33819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 33093, 33831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 33093, 33831);
            }
        }

        public SeventeenTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 32276, 33838);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 32276, 33838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 32276, 33838);
        }


        static SeventeenTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 32276, 33838);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 32436, 32471);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 32528, 32793);
            SeventeenDescriptor = f_25076_32550_32793("SeventeenRule", "Seventeen", "Seventeen is a recognized value", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 32276, 33838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 32276, 33838);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 32276, 33838);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_32550_32793(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 32550, 32793);
            return return_v;
        }

    }
    public class NullArgumentTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor NullArgumentsDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 34667, 34729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 34673, 34727);

                    return f_25076_34680_34726(NullArgumentsDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 34667, 34729);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_34680_34726(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 34680, 34726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 34562, 34740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 34562, 34740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 34752, 35345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 34840, 35334);

                f_25076_34840_35333(context, (operationContext) =>
                     {
                         var argument = (IArgumentOperation)operationContext.Operation;
                         if (argument.Value.ConstantValue.HasValue && argument.Value.ConstantValue.Value == null)
                         {
                             Report(operationContext, argument.Syntax, NullArgumentsDescriptor);
                         }
                     }, OperationKind.Argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 34752, 35345);

                int
                f_25076_34840_35333(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 34840, 35333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 34752, 35345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 34752, 35345);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 35357, 35583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 35494, 35572);

                context.ReportDiagnostic(f_25076_35519_35570(descriptor, f_25076_35549_35569(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 35357, 35583);

                Microsoft.CodeAnalysis.Location
                f_25076_35549_35569(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 35549, 35569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_35519_35570(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 35519, 35570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 35357, 35583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 35357, 35583);
            }
        }

        public NullArgumentTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 33919, 35590);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 33919, 35590);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 33919, 35590);
        }


        static NullArgumentTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 33919, 35590);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 34082, 34117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 34174, 34448);
            NullArgumentsDescriptor = f_25076_34200_34448("NullArgumentRule", "Null Argument", "Value of the argument is null", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 33919, 35590);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 33919, 35590);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 33919, 35590);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_34200_34448(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 34200, 34448);
            return return_v;
        }

    }
    public class MemberInitializerTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor DoNotUseFieldInitializerDescriptor;

        public static readonly DiagnosticDescriptor DoNotUsePropertyInitializerDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 36880, 36992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 36886, 36990);

                    return f_25076_36893_36989(DoNotUseFieldInitializerDescriptor, DoNotUsePropertyInitializerDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 36880, 36992);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_36893_36989(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 36893, 36989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 36775, 37003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 36775, 37003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 37015, 37590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 37103, 37579);

                f_25076_37103_37578(context, (operationContext) =>
                     {
                         var initializer = operationContext.Operation;
                         Report(operationContext, initializer.Syntax, initializer.Kind == OperationKind.FieldReference ? DoNotUseFieldInitializerDescriptor : DoNotUsePropertyInitializerDescriptor);
                     }, OperationKind.FieldReference, OperationKind.PropertyReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 37015, 37590);

                int
                f_25076_37103_37578(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 37103, 37578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 37015, 37590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 37015, 37590);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 37602, 37828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 37739, 37817);

                context.ReportDiagnostic(f_25076_37764_37815(descriptor, f_25076_37794_37814(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 37602, 37828);

                Microsoft.CodeAnalysis.Location
                f_25076_37794_37814(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 37794, 37814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_37764_37815(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 37764, 37815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 37602, 37828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 37602, 37828);
            }
        }

        public MemberInitializerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 35680, 37835);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 35680, 37835);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 35680, 37835);
        }


        static MemberInitializerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 35680, 37835);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 35848, 35883);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 35940, 36266);
            DoNotUseFieldInitializerDescriptor = f_25076_35977_36266("DoNotUseFieldInitializer", "Do Not Use Field Initializer", "a field initializer is used for object creation", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 36323, 36661);
            DoNotUsePropertyInitializerDescriptor = f_25076_36363_36661("DoNotUsePropertyInitializer", "Do Not Use Property Initializer", "A property initializer is used for object creation", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 35680, 37835);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 35680, 37835);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 35680, 37835);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_35977_36266(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 35977, 36266);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_36363_36661(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 36363, 36661);
            return return_v;
        }

    }
    public class AssignmentTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor DoNotUseMemberAssignmentDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 38616, 38689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 38622, 38687);

                    return f_25076_38629_38686(DoNotUseMemberAssignmentDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 38616, 38689);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_38629_38686(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 38629, 38686);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 38511, 38700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 38511, 38700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 38712, 39415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 38800, 39404);

                f_25076_38800_39403(context, (operationContext) =>
                     {
                         var assignment = (ISimpleAssignmentOperation)operationContext.Operation;
                         var kind = assignment.Target.Kind;
                         if (kind == OperationKind.FieldReference ||
                             kind == OperationKind.PropertyReference)
                         {
                             Report(operationContext, assignment.Syntax, DoNotUseMemberAssignmentDescriptor);
                         }
                     }, OperationKind.SimpleAssignment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 38712, 39415);

                int
                f_25076_38800_39403(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 38800, 39403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 38712, 39415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 38712, 39415);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 39427, 39653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 39564, 39642);

                context.ReportDiagnostic(f_25076_39589_39640(descriptor, f_25076_39619_39639(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 39427, 39653);

                Microsoft.CodeAnalysis.Location
                f_25076_39619_39639(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 39619, 39639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_39589_39640(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 39589, 39640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 39427, 39653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 39427, 39653);
            }
        }

        public AssignmentTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 37928, 39660);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 37928, 39660);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 37928, 39660);
        }


        static AssignmentTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 37928, 39660);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 38089, 38124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 38181, 38498);
            DoNotUseMemberAssignmentDescriptor = f_25076_38218_38498("DoNotUseMemberAssignment", "Do Not Use Member Assignment", "Do not assign values to object members", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 37928, 39660);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 37928, 39660);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 37928, 39660);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_38218_38498(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 38218, 38498);
            return return_v;
        }

    }
    public class ArrayInitializerTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        Maintainability = nameof(Maintainability)
        ;

        public static readonly DiagnosticDescriptor DoNotUseLargeListOfArrayInitializersDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 40611, 40696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 40617, 40694);

                    return f_25076_40624_40693(DoNotUseLargeListOfArrayInitializersDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 40611, 40696);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_40624_40693(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 40624, 40693);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 40506, 40707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 40506, 40707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 40719, 41310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 40807, 41299);

                f_25076_40807_41298(context, (operationContext) =>
                     {
                         var initializer = (IArrayInitializerOperation)operationContext.Operation;
                         if (initializer.ElementValues.Length > 5)
                         {
                             Report(operationContext, initializer.Syntax, DoNotUseLargeListOfArrayInitializersDescriptor);
                         }
                     }, OperationKind.ArrayInitializer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 40719, 41310);

                int
                f_25076_40807_41298(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 40807, 41298);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 40719, 41310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 40719, 41310);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 41322, 41548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 41459, 41537);

                context.ReportDiagnostic(f_25076_41484_41535(descriptor, f_25076_41514_41534(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 41322, 41548);

                Microsoft.CodeAnalysis.Location
                f_25076_41514_41534(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 41514, 41534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_41484_41535(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 41484, 41535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 41322, 41548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 41322, 41548);
            }
        }

        public ArrayInitializerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 39749, 41555);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 39749, 41555);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 39749, 41555);
        }


        static ArrayInitializerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 39749, 41555);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 39920, 39961);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 40018, 40392);
            DoNotUseLargeListOfArrayInitializersDescriptor = f_25076_40067_40392("DoNotUseLongListToInitializeArray", "Do not use long list to initialize array", "a list of more than 5 elements is used for an array initialization", Maintainability, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 39749, 41555);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 39749, 41555);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 39749, 41555);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_40067_40392(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 40067, 40392);
            return return_v;
        }

    }
    public class VariableDeclarationTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        Maintainability = nameof(Maintainability)
        ;

        public static readonly DiagnosticDescriptor TooManyLocalVarDeclarationsDescriptor;

        public static readonly DiagnosticDescriptor LocalVarInitializedDeclarationDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 42907, 43025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 42913, 43023);

                    return f_25076_42920_43022(TooManyLocalVarDeclarationsDescriptor, LocalVarInitializedDeclarationDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 42907, 43025);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_42920_43022(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 42920, 43022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 42802, 43036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 42802, 43036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 43048, 44290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 43136, 44279);

                f_25076_43136_44278(context, (operationContext) =>
                     {
                         var declarationStatement = (IVariableDeclarationGroupOperation)operationContext.Operation;
                         if (declarationStatement.GetDeclaredVariables().Count() > 3)
                         {
                             Report(operationContext, declarationStatement.Syntax, TooManyLocalVarDeclarationsDescriptor);
                         }

                         foreach (var decl in declarationStatement.Declarations.SelectMany(multiDecl => multiDecl.Declarators))
                         {
                             var initializer = decl.GetVariableInitializer();
                             if (initializer != null && !initializer.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                             {
                                 Report(operationContext, decl.Symbol.DeclaringSyntaxReferences.Single().GetSyntax(), LocalVarInitializedDeclarationDescriptor);
                             }
                         }
                     }, OperationKind.VariableDeclarationGroup);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 43048, 44290);

                int
                f_25076_43136_44278(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 43136, 44278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 43048, 44290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 43048, 44290);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 44302, 44528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 44439, 44517);

                context.ReportDiagnostic(f_25076_44464_44515(descriptor, f_25076_44494_44514(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 44302, 44528);

                Microsoft.CodeAnalysis.Location
                f_25076_44494_44514(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 44494, 44514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_44464_44515(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 44464, 44515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 44302, 44528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 44302, 44528);
            }
        }

        public VariableDeclarationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 41656, 44535);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 41656, 44535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 41656, 44535);
        }


        static VariableDeclarationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 41656, 44535);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 41830, 41871);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 41928, 42289);
            TooManyLocalVarDeclarationsDescriptor = f_25076_41968_42289("TooManyLocalVarDeclarations", "Too many local variable declarations", "A declaration statement shouldn't have more than 3 variable declarations", Maintainability, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 42346, 42688);
            LocalVarInitializedDeclarationDescriptor = f_25076_42389_42688("LocalVarInitializedDeclaration", "Local var initialized at declaration", "A local variable is initialized at declaration.", Maintainability, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 41656, 44535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 41656, 44535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 41656, 44535);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_41968_42289(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 41968, 42289);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_42389_42688(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 42389, 42688);
            return return_v;
        }

    }
    public class CaseTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        Maintainability = nameof(Maintainability)
        ;

        public static readonly DiagnosticDescriptor HasDefaultCaseDescriptor;

        public static readonly DiagnosticDescriptor MultipleCaseClausesDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 45728, 45822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 45734, 45820);

                    return f_25076_45741_45819(HasDefaultCaseDescriptor, MultipleCaseClausesDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 45728, 45822);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_45741_45819(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 45741, 45819);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 45623, 45833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 45623, 45833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 45845, 47225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 45933, 47214);

                f_25076_45933_47213(context, (operationContext) =>
                     {
                         switch (operationContext.Operation.Kind)
                         {
                             case OperationKind.CaseClause:
                                 var caseClause = (ICaseClauseOperation)operationContext.Operation;
                                 if (caseClause.CaseKind == CaseKind.Default)
                                 {
                                     Report(operationContext, caseClause.Syntax, HasDefaultCaseDescriptor);
                                 }
                                 break;
                             case OperationKind.SwitchCase:
                                 var switchSection = (ISwitchCaseOperation)operationContext.Operation;
                                 if (!switchSection.HasErrors(operationContext.Compilation, operationContext.CancellationToken) && switchSection.Clauses.Length > 1)
                                 {
                                     Report(operationContext, switchSection.Syntax, MultipleCaseClausesDescriptor);
                                 }
                                 break;
                         }
                     }, OperationKind.SwitchCase, OperationKind.CaseClause);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 45845, 47225);

                int
                f_25076_45933_47213(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 45933, 47213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 45845, 47225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 45845, 47225);
            }
        }

        private static void Report(OperationAnalysisContext context, SyntaxNode syntax, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 47237, 47463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 47374, 47452);

                context.ReportDiagnostic(f_25076_47399_47450(descriptor, f_25076_47429_47449(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 47237, 47463);

                Microsoft.CodeAnalysis.Location
                f_25076_47429_47449(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 47429, 47449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25076_47399_47450(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 47399, 47450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 47237, 47463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 47237, 47463);
            }
        }

        public CaseTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 44616, 47470);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 44616, 47470);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 44616, 47470);
        }


        static CaseTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 44616, 47470);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 44775, 44816);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 44873, 45152);
            HasDefaultCaseDescriptor = f_25076_44900_45152("HasDefaultCase", "Has Default Case", "A default case clause is encountered", Maintainability, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 45209, 45509);
            MultipleCaseClausesDescriptor = f_25076_45241_45509("MultipleCaseClauses", "Multiple Case Clauses", "A switch section has multiple case clauses", Maintainability, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 44616, 47470);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 44616, 47470);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 44616, 47470);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_44900_45152(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 44900, 45152);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_45241_45509(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 45241, 45509);
            return return_v;
        }

    }
    public class ExplicitVsImplicitInstanceAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor ImplicitInstanceDescriptor;

        public static readonly DiagnosticDescriptor ExplicitInstanceDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 48387, 48467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 48390, 48467);
                    return f_25076_48390_48467(ImplicitInstanceDescriptor, ExplicitInstanceDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 48387, 48467);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 48387, 48467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 48387, 48467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 48480, 49149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 48568, 49138);

                f_25076_48568_49137(context, (operationContext) =>
                     {
                         IInstanceReferenceOperation instanceReference = (IInstanceReferenceOperation)operationContext.Operation;
                         operationContext.ReportDiagnostic(Diagnostic.Create(instanceReference.IsImplicit ? ImplicitInstanceDescriptor : ExplicitInstanceDescriptor,
                                                                             instanceReference.Syntax.GetLocation()));
                     }, OperationKind.InstanceReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 48480, 49149);

                int
                f_25076_48568_49137(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 48568, 49137);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 48480, 49149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 48480, 49149);
            }
        }

        public ExplicitVsImplicitInstanceAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 47575, 49156);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 47575, 49156);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 47575, 49156);
        }


        static ExplicitVsImplicitInstanceAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 47575, 49156);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 47704, 47970);
            ImplicitInstanceDescriptor = f_25076_47733_47970("ImplicitInstance", "Implicit Instance", "Implicit instance found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 48027, 48293);
            ExplicitInstanceDescriptor = f_25076_48056_48293("ExplicitInstance", "Explicit Instance", "Explicit instance found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 47575, 49156);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 47575, 49156);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 47575, 49156);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_47733_47970(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 47733, 47970);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_48056_48293(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 48056, 48293);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_48390_48467(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 48390, 48467);
            return return_v;
        }

    }
    public class MemberReferenceAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor EventReferenceDescriptor;

        public static readonly DiagnosticDescriptor InvalidEventDescriptor;

        public static readonly DiagnosticDescriptor HandlerAddedDescriptor;

        public static readonly DiagnosticDescriptor HandlerRemovedDescriptor;

        public static readonly DiagnosticDescriptor PropertyReferenceDescriptor;

        public static readonly DiagnosticDescriptor FieldReferenceDescriptor;

        public static readonly DiagnosticDescriptor MethodBindingDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 51622, 51941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 51638, 51941);
                    return f_25076_51638_51941(EventReferenceDescriptor, HandlerAddedDescriptor, HandlerRemovedDescriptor, PropertyReferenceDescriptor, FieldReferenceDescriptor, MethodBindingDescriptor, InvalidEventDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 51622, 51941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 51622, 51941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 51622, 51941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 51954, 54233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 52042, 52355);

                f_25076_52042_52354(context, (operationContext) =>
                     {
                         operationContext.ReportDiagnostic(Diagnostic.Create(EventReferenceDescriptor, operationContext.Operation.Syntax.GetLocation()));
                     }, OperationKind.EventReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 52371, 53229);

                f_25076_52371_53228(
                            context, (operationContext) =>
                                 {
                                     IEventAssignmentOperation eventAssignment = (IEventAssignmentOperation)operationContext.Operation;
                                     operationContext.ReportDiagnostic(Diagnostic.Create(eventAssignment.Adds ? HandlerAddedDescriptor : HandlerRemovedDescriptor, operationContext.Operation.Syntax.GetLocation()));

                                     if (eventAssignment.EventReference.Kind == OperationKind.Invalid || eventAssignment.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                                     {
                                         operationContext.ReportDiagnostic(Diagnostic.Create(InvalidEventDescriptor, eventAssignment.Syntax.GetLocation()));
                                     }
                                 }, OperationKind.EventAssignment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 53245, 53564);

                f_25076_53245_53563(
                            context, (operationContext) =>
                                 {
                                     operationContext.ReportDiagnostic(Diagnostic.Create(PropertyReferenceDescriptor, operationContext.Operation.Syntax.GetLocation()));
                                 }, OperationKind.PropertyReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 53580, 53893);

                f_25076_53580_53892(
                            context, (operationContext) =>
                                 {
                                     operationContext.ReportDiagnostic(Diagnostic.Create(FieldReferenceDescriptor, operationContext.Operation.Syntax.GetLocation()));
                                 }, OperationKind.FieldReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 53909, 54222);

                f_25076_53909_54221(
                            context, (operationContext) =>
                                 {
                                     operationContext.ReportDiagnostic(Diagnostic.Create(MethodBindingDescriptor, operationContext.Operation.Syntax.GetLocation()));
                                 }, OperationKind.MethodReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 51954, 54233);

                int
                f_25076_52042_52354(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 52042, 52354);
                    return 0;
                }


                int
                f_25076_52371_53228(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 52371, 53228);
                    return 0;
                }


                int
                f_25076_53245_53563(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 53245, 53563);
                    return 0;
                }


                int
                f_25076_53580_53892(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 53580, 53892);
                    return 0;
                }


                int
                f_25076_53909_54221(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 53909, 54221);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 51954, 54233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 51954, 54233);
            }
        }

        public MemberReferenceAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 49237, 54240);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 49237, 54240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 49237, 54240);
        }


        static MemberReferenceAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 49237, 54240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 49355, 49613);
            EventReferenceDescriptor = f_25076_49382_49613("EventReference", "Event Reference", "Event reference found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 49670, 49953);
            InvalidEventDescriptor = f_25076_49695_49953("InvalidEvent", "Invalid Event", "A EventAssignmentExpression with invalid event found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 50010, 50260);
            HandlerAddedDescriptor = f_25076_50035_50260("HandlerAdded", "Handler Added", "Event handler added.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 50317, 50575);
            HandlerRemovedDescriptor = f_25076_50344_50575("HandlerRemoved", "Handler Removed", "Event handler removed.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 50632, 50902);
            PropertyReferenceDescriptor = f_25076_50662_50902("PropertyReference", "Property Reference", "Property reference found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 50959, 51217);
            FieldReferenceDescriptor = f_25076_50986_51217("FieldReference", "Field Reference", "Field reference found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 51274, 51528);
            MethodBindingDescriptor = f_25076_51300_51528("MethodBinding", "Method Binding", "Method binding found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 49237, 54240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 49237, 54240);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 49237, 54240);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_49382_49613(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 49382, 49613);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_49695_49953(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 49695, 49953);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_50035_50260(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 50035, 50260);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_50344_50575(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 50344, 50575);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_50662_50902(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 50662, 50902);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_50986_51217(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 50986, 51217);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_51300_51528(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 51300, 51528);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_51638_51941(params Microsoft.CodeAnalysis.DiagnosticDescriptor[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 51638, 51941);
            return return_v;
        }

    }
    public class ParamsArrayTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor LongParamsDescriptor;

        public static readonly DiagnosticDescriptor InvalidConstructorDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 55154, 55230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 55157, 55230);
                    return f_25076_55157_55230(LongParamsDescriptor, InvalidConstructorDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 55154, 55230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 55154, 55230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 55154, 55230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 55243, 57796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 55331, 56434);

                f_25076_55331_56433(context, (operationContext) =>
                     {
                         IInvocationOperation invocation = (IInvocationOperation)operationContext.Operation;

                         foreach (IArgumentOperation argument in invocation.Arguments)
                         {
                             if (argument.Parameter.IsParams)
                             {
                                 if (argument.Value is IArrayCreationOperation arrayValue)
                                 {
                                     Optional<object> dimensionSize = arrayValue.DimensionSizes[0].ConstantValue;
                                     if (dimensionSize.HasValue && IntegralValue(dimensionSize.Value) > 3)
                                     {
                                         operationContext.ReportDiagnostic(Diagnostic.Create(LongParamsDescriptor, argument.Value.Syntax.GetLocation()));
                                     }
                                 }
                             }
                         }
                     }, OperationKind.Invocation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 56450, 57785);

                f_25076_56450_57784(
                            context, (operationContext) =>
                                {
                                    IObjectCreationOperation creation = (IObjectCreationOperation)operationContext.Operation;

                                    if (creation.Constructor == null)
                                    {
                                        operationContext.ReportDiagnostic(Diagnostic.Create(InvalidConstructorDescriptor, creation.Syntax.GetLocation()));
                                    }

                                    foreach (IArgumentOperation argument in creation.Arguments)
                                    {
                                        if (argument.Parameter.IsParams)
                                        {
                                            if (argument.Value is IArrayCreationOperation arrayValue)
                                            {
                                                Optional<object> dimensionSize = arrayValue.DimensionSizes[0].ConstantValue;
                                                if (dimensionSize.HasValue && IntegralValue(dimensionSize.Value) > 3)
                                                {
                                                    operationContext.ReportDiagnostic(Diagnostic.Create(LongParamsDescriptor, argument.Value.Syntax.GetLocation()));
                                                }
                                            }
                                        }
                                    }
                                }, OperationKind.ObjectCreation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 55243, 57796);

                int
                f_25076_55331_56433(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 55331, 56433);
                    return 0;
                }


                int
                f_25076_56450_57784(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 56450, 57784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 55243, 57796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 55243, 57796);
            }
        }

        private static long IntegralValue(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25076, 57808, 58085);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 57880, 57957) || true) && (value is long v)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 57880, 57957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 57933, 57942);

                    return v;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 57880, 57957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 57973, 58049) || true) && (value is int i)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 57973, 58049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 58025, 58034);

                    return i;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 57973, 58049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 58065, 58074);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25076, 57808, 58085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 57808, 58085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 57808, 58085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ParamsArrayTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 54346, 58092);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 54346, 58092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 54346, 58092);
        }


        static ParamsArrayTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 54346, 58092);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 54464, 54735);
            LongParamsDescriptor = f_25076_54487_54735("LongParams", "Long Params", "Params array argument has more than 3 elements.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 54792, 55060);
            InvalidConstructorDescriptor = f_25076_54823_55060("InvalidConstructor", "Invalid Constructor", "Invalid Constructor.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 54346, 58092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 54346, 58092);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 54346, 58092);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_54487_54735(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 54487, 54735);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_54823_55060(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 54823, 55060);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_55157_55230(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 55157, 55230);
            return return_v;
        }

    }
    public class EqualsValueTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor EqualsValueDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 58663, 58710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 58666, 58710);
                    return f_25076_58666_58710(EqualsValueDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 58663, 58710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 58663, 58710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 58663, 58710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 58723, 59937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 58811, 59360);

                f_25076_58811_59359(context, (operationContext) =>
                     {
                         IFieldInitializerOperation equalsValue = (IFieldInitializerOperation)operationContext.Operation;
                         if (equalsValue.InitializedFields[0].Name.StartsWith("F"))
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(EqualsValueDescriptor, equalsValue.Syntax.GetLocation()));
                         }
                     }, OperationKind.FieldInitializer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 59376, 59926);

                f_25076_59376_59925(
                            context, (operationContext) =>
                                 {
                                     IParameterInitializerOperation equalsValue = (IParameterInitializerOperation)operationContext.Operation;
                                     if (equalsValue.Parameter.Name.StartsWith("F"))
                                     {
                                         operationContext.ReportDiagnostic(Diagnostic.Create(EqualsValueDescriptor, equalsValue.Syntax.GetLocation()));
                                     }
                                 }, OperationKind.ParameterInitializer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 58723, 59937);

                int
                f_25076_58811_59359(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 58811, 59359);
                    return 0;
                }


                int
                f_25076_59376_59925(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 59376, 59925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 58723, 59937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 58723, 59937);
            }
        }

        public EqualsValueTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 58205, 59944);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 58205, 59944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 58205, 59944);
        }


        static EqualsValueTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 58205, 59944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 58323, 58569);
            EqualsValueDescriptor = f_25076_58347_58569("EqualsValue", "Equals Value", "Equals value found.", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 58205, 59944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 58205, 59944);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 58205, 59944);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_58347_58569(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 58347, 58569);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_58666_58710(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 58666, 58710);
            return return_v;
        }

    }
    public class NoneOperationTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor NoneOperationDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 60676, 60738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 60682, 60736);

                    return f_25076_60689_60735(NoneOperationDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 60676, 60738);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_60689_60735(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 60689, 60735);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 60571, 60749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 60571, 60749);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 60761, 61272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 60849, 61261);

                f_25076_60849_61260(context, (operationContext) =>
                     {
                         operationContext.ReportDiagnostic(Diagnostic.Create(NoneOperationDescriptor, operationContext.Operation.Syntax.GetLocation()));
                     }, OperationKind.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 60761, 61272);

                int
                f_25076_60849_61260(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 60849, 61260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 60761, 61272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 60761, 61272);
            }
        }

        public NoneOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 60020, 61279);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 60020, 61279);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 60020, 61279);
        }


        static NoneOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 60020, 61279);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 60117, 60152);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 60274, 60558);
            NoneOperationDescriptor = f_25076_60300_60558("NoneOperation", "None operation found", "An IOperation of None kind is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 60020, 61279);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 60020, 61279);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 60020, 61279);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_60300_60558(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 60300, 60558);
            return return_v;
        }

    }
    public class AddressOfTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor AddressOfDescriptor;

        public static readonly DiagnosticDescriptor InvalidAddressOfReferenceDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 62228, 62323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 62244, 62323);
                    return f_25076_62244_62323(AddressOfDescriptor, InvalidAddressOfReferenceDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 62228, 62323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 62228, 62323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 62228, 62323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 62336, 63228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 62424, 63217);

                f_25076_62424_63216(context, (operationContext) =>
                     {
                         var addressOfOperation = (IAddressOfOperation)operationContext.Operation;
                         operationContext.ReportDiagnostic(Diagnostic.Create(AddressOfDescriptor, addressOfOperation.Syntax.GetLocation()));

                         if (addressOfOperation.Reference.Kind == OperationKind.Invalid && addressOfOperation.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(InvalidAddressOfReferenceDescriptor, addressOfOperation.Reference.Syntax.GetLocation()));
                         }
                     }, OperationKind.AddressOf);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 62336, 63228);

                int
                f_25076_62424_63216(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 62424, 63216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 62336, 63228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 62336, 63228);
            }
        }

        public AddressOfTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 61287, 63235);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 61287, 63235);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 61287, 63235);
        }


        static AddressOfTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 61287, 63235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 61380, 61415);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 61472, 61755);
            AddressOfDescriptor = f_25076_61494_61755("AddressOfOperation", "AddressOf operation found", "An AddressOf operation found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 61812, 62134);
            InvalidAddressOfReferenceDescriptor = f_25076_61850_62134("InvalidAddressOfReference", "Invalid AddressOf reference found", "An invalid AddressOf reference found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 61287, 63235);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 61287, 63235);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 61287, 63235);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_61494_61755(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 61494, 61755);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_61850_62134(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 61850, 62134);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_62244_62323(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 62244, 62323);
            return return_v;
        }

    }
    public class LambdaTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor LambdaExpressionDescriptor;

        public static readonly DiagnosticDescriptor TooManyStatementsInLambdaExpressionDescriptor;

        public static readonly DiagnosticDescriptor NoneOperationInLambdaExpressionDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 64758, 64983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 64774, 64983);
                    return f_25076_64774_64983(LambdaExpressionDescriptor, TooManyStatementsInLambdaExpressionDescriptor, NoneOperationInLambdaExpressionDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 64758, 64983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 64758, 64983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 64758, 64983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 64996, 66664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 65084, 66653);

                f_25076_65084_66652(context, (operationContext) =>
                     {
                         var lambdaExpression = (IAnonymousFunctionOperation)operationContext.Operation;
                         operationContext.ReportDiagnostic(Diagnostic.Create(LambdaExpressionDescriptor, operationContext.Operation.Syntax.GetLocation()));
                         var block = lambdaExpression.Body;
                     // TODO: Can this possibly be null? Remove check if not.
                     if (block == null)
                         {
                             return;
                         }
                         if (block.Operations.Length > 3)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(TooManyStatementsInLambdaExpressionDescriptor, operationContext.Operation.Syntax.GetLocation()));
                         }
                         bool flag = false;
                         foreach (var statement in block.Operations)
                         {
                             if (statement.Kind == OperationKind.None)
                             {
                                 flag = true;
                                 break;
                             }
                         }
                         if (flag)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(NoneOperationInLambdaExpressionDescriptor, operationContext.Operation.Syntax.GetLocation()));
                         }
                     }, OperationKind.AnonymousFunction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 64996, 66664);

                int
                f_25076_65084_66652(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 65084, 66652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 64996, 66664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 64996, 66664);
            }
        }

        public LambdaTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 63323, 66671);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 63323, 66671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 63323, 66671);
        }


        static LambdaTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 63323, 66671);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 63413, 63448);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 63505, 63791);
            LambdaExpressionDescriptor = f_25076_63534_63791("LambdaExpression", "Lambda expression found", "A Lambda expression is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 63848, 64208);
            TooManyStatementsInLambdaExpressionDescriptor = f_25076_63896_64208("TooManyStatementsInLambdaExpression", "Too many statements in a Lambda expression", "More than 3 statements in a Lambda expression", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 64317, 64664);
            NoneOperationInLambdaExpressionDescriptor = f_25076_64361_64664("NoneOperationInLambdaExpression", "None Operation found in Lambda expression", "None Operation is found Lambda expression", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 63323, 66671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 63323, 66671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 63323, 66671);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_63534_63791(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 63534, 63791);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_63896_64208(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 63896, 64208);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_64361_64664(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 64361, 64664);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_64774_64983(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item3)
        {
            var return_v = ImmutableArray.Create(item1, item2, item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 64774, 64983);
            return return_v;
        }

    }
    public class StaticMemberTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor StaticMemberDescriptor;

        public static readonly DiagnosticDescriptor StaticMemberWithInstanceDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 67748, 67934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 67784, 67919);

                    return f_25076_67791_67918(StaticMemberDescriptor, StaticMemberWithInstanceDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 67748, 67934);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_67791_67918(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 67791, 67918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 67643, 67945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 67643, 67945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 67957, 70640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 68045, 70629);

                f_25076_68045_70628(context, (operationContext) =>
                     {
                         var operation = operationContext.Operation;
                         ISymbol memberSymbol;
                         IOperation receiver;
                         switch (operation.Kind)
                         {
                             case OperationKind.FieldReference:
                                 memberSymbol = ((IFieldReferenceOperation)operation).Field;
                                 receiver = ((IFieldReferenceOperation)operation).Instance;
                                 break;
                             case OperationKind.PropertyReference:
                                 memberSymbol = ((IPropertyReferenceOperation)operation).Property;
                                 receiver = ((IPropertyReferenceOperation)operation).Instance;
                                 break;
                             case OperationKind.EventReference:
                                 memberSymbol = ((IEventReferenceOperation)operation).Event;
                                 receiver = ((IEventReferenceOperation)operation).Instance;
                                 break;
                             case OperationKind.MethodReference:
                                 memberSymbol = ((IMethodReferenceOperation)operation).Method;
                                 receiver = ((IMethodReferenceOperation)operation).Instance;
                                 break;
                             case OperationKind.Invocation:
                                 memberSymbol = ((IInvocationOperation)operation).TargetMethod;
                                 receiver = ((IInvocationOperation)operation).Instance;
                                 break;
                             default:
                                 throw new ArgumentException();
                         }
                         if (memberSymbol.IsStatic)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(StaticMemberDescriptor, operation.Syntax.GetLocation()));

                             if (receiver != null)
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(StaticMemberWithInstanceDescriptor, operation.Syntax.GetLocation()));
                             }
                         }
                     }, OperationKind.FieldReference, OperationKind.PropertyReference, OperationKind.EventReference, OperationKind.MethodReference, OperationKind.Invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 67957, 70640);

                int
                f_25076_68045_70628(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 68045, 70628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 67957, 70640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 67957, 70640);
            }
        }

        public StaticMemberTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 66679, 70647);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 66679, 70647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 66679, 70647);
        }


        static StaticMemberTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 66679, 70647);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 66775, 66810);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 66867, 67158);
            StaticMemberDescriptor = f_25076_66892_67158("StaticMember", "Static member found", "A static member reference expression is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 67280, 67630);
            StaticMemberWithInstanceDescriptor = f_25076_67317_67630("StaticMemberWithInstance", "Static member with non null Instance found", "A static member reference with non null Instance is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 66679, 70647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 66679, 70647);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 66679, 70647);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_66892_67158(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 66892, 67158);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_67317_67630(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 67317, 67630);
            return return_v;
        }

    }
    public class LabelOperationsTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor LabelDescriptor;

        public static readonly DiagnosticDescriptor GotoDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 71376, 71433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 71379, 71433);
                    return f_25076_71379_71433(LabelDescriptor, GotoDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 71376, 71433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 71376, 71433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 71376, 71433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 71446, 72745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 71534, 72046);

                f_25076_71534_72045(context, (operationContext) =>
                    {
                        ILabelSymbol label = ((ILabeledOperation)operationContext.Operation).Label;
                        if (label.Name == "Wilma" || label.Name == "Betty")
                        {
                            operationContext.ReportDiagnostic(Diagnostic.Create(LabelDescriptor, operationContext.Operation.Syntax.GetLocation()));
                        }
                    }, OperationKind.Labeled);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 72062, 72734);

                f_25076_72062_72733(
                            context, (operationContext) =>
                                {
                                    IBranchOperation branch = (IBranchOperation)operationContext.Operation;
                                    if (branch.BranchKind == BranchKind.GoTo)
                                    {
                                        ILabelSymbol label = branch.Target;
                                        if (label.Name == "Wilma" || label.Name == "Betty")
                                        {
                                            operationContext.ReportDiagnostic(Diagnostic.Create(GotoDescriptor, branch.Syntax.GetLocation()));
                                        }
                                    }
                                }, OperationKind.Branch);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 71446, 72745);

                int
                f_25076_71534_72045(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 71534, 72045);
                    return 0;
                }


                int
                f_25076_72062_72733(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 72062, 72733);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 71446, 72745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 71446, 72745);
            }
        }

        public LabelOperationsTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 70655, 72752);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 70655, 72752);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 70655, 72752);
        }


        static LabelOperationsTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 70655, 72752);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 70777, 71006);
            LabelDescriptor = f_25076_70795_71006("Label", "Label found", "A label was was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 71063, 71282);
            GotoDescriptor = f_25076_71080_71282("Goto", "Goto found", "A goto was was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 70655, 72752);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 70655, 72752);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 70655, 72752);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_70795_71006(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 70795, 71006);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_71080_71282(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 71080, 71282);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_71379_71433(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 71379, 71433);
            return return_v;
        }

    }
    public class UnaryAndBinaryOperationsTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor OperatorAddMethodDescriptor;

        public static readonly DiagnosticDescriptor OperatorMinusMethodDescriptor;

        public static readonly DiagnosticDescriptor DoubleMultiplyDescriptor;

        public static readonly DiagnosticDescriptor BooleanNotDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 74254, 74386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 74257, 74386);
                    return f_25076_74257_74386(OperatorAddMethodDescriptor, OperatorMinusMethodDescriptor, DoubleMultiplyDescriptor, BooleanNotDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 74254, 74386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 74254, 74386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 74254, 74386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 74399, 76499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 74487, 75384);

                f_25076_74487_75383(context, (operationContext) =>
                    {
                        IBinaryOperation binary = (IBinaryOperation)operationContext.Operation;
                        if (binary.OperatorKind == BinaryOperatorKind.Add && binary.OperatorMethod != null && binary.OperatorMethod.Name.Contains("Addition"))
                        {
                            operationContext.ReportDiagnostic(Diagnostic.Create(OperatorAddMethodDescriptor, binary.Syntax.GetLocation()));
                        }

                        if (binary.OperatorKind == BinaryOperatorKind.Multiply && binary.Type.SpecialType == SpecialType.System_Double)
                        {
                            operationContext.ReportDiagnostic(Diagnostic.Create(DoubleMultiplyDescriptor, binary.Syntax.GetLocation()));
                        }
                    }, OperationKind.Binary);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 75400, 76488);

                f_25076_75400_76487(
                            context, (operationContext) =>
                                {
                                    IUnaryOperation unary = (IUnaryOperation)operationContext.Operation;
                                    if (unary.OperatorKind == UnaryOperatorKind.Minus && unary.OperatorMethod != null && unary.OperatorMethod.Name.Contains("UnaryNegation"))
                                    {
                                        operationContext.ReportDiagnostic(Diagnostic.Create(OperatorMinusMethodDescriptor, unary.Syntax.GetLocation()));
                                    }

                                    if (unary.OperatorKind == UnaryOperatorKind.Not)
                                    {
                                        operationContext.ReportDiagnostic(Diagnostic.Create(BooleanNotDescriptor, unary.Syntax.GetLocation()));
                                    }

                                    if (unary.OperatorKind == UnaryOperatorKind.BitwiseNegation)
                                    {
                                        operationContext.ReportDiagnostic(Diagnostic.Create(BooleanNotDescriptor, unary.Syntax.GetLocation()));
                                    }
                                }, OperationKind.Unary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 74399, 76499);

                int
                f_25076_74487_75383(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 74487, 75383);
                    return 0;
                }


                int
                f_25076_75400_76487(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 75400, 76487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 74399, 76499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 74399, 76499);
            }
        }

        public UnaryAndBinaryOperationsTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 72760, 76506);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 72760, 76506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 72760, 76506);
        }


        static UnaryAndBinaryOperationsTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 72760, 76506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 72891, 73175);
            OperatorAddMethodDescriptor = f_25076_72921_73175("OperatorAddMethod", "Operator Add method found", "An operator Add method was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 73232, 73524);
            OperatorMinusMethodDescriptor = f_25076_73264_73524("OperatorMinusMethod", "Operator Minus method found", "An operator Minus method was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 73581, 73850);
            DoubleMultiplyDescriptor = f_25076_73608_73850("DoubleMultiply", "Double multiply found", "A double multiply was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 73907, 74160);
            BooleanNotDescriptor = f_25076_73930_74160("BooleanNot", "Boolean not found", "A boolean not was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 72760, 76506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 72760, 76506);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 72760, 76506);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_72921_73175(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 72921, 73175);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_73264_73524(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 73264, 73524);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_73608_73850(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 73608, 73850);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_73930_74160(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 73930, 74160);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_74257_74386(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item3, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item4)
        {
            var return_v = ImmutableArray.Create(item1, item2, item3, item4);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 74257, 74386);
            return return_v;
        }

    }
    public class BinaryOperatorVBTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor BinaryUserDefinedOperatorDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 77064, 77125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 77067, 77125);
                    return f_25076_77067_77125(BinaryUserDefinedOperatorDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 77064, 77125);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 77064, 77125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 77064, 77125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 77138, 77842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 77226, 77831);

                f_25076_77226_77830(context, (operationContext) =>
                    {
                        var binary = (IBinaryOperation)operationContext.Operation;
                        if (binary.OperatorMethod != null)
                        {
                            operationContext.ReportDiagnostic(
                                Diagnostic.Create(BinaryUserDefinedOperatorDescriptor,
                                    binary.Syntax.GetLocation(),
                                    binary.OperatorKind.ToString()));
                        }
                    }, OperationKind.Binary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 77138, 77842);

                int
                f_25076_77226_77830(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 77226, 77830);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 77138, 77842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 77138, 77842);
            }
        }

        public BinaryOperatorVBTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 76514, 77849);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 76514, 77849);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 76514, 77849);
        }


        static BinaryOperatorVBTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 76514, 77849);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 76637, 76957);
            BinaryUserDefinedOperatorDescriptor = f_25076_76675_76957("BinaryUserDefinedOperator", "Binary user defined operator found", "A Binary user defined operator {0} is found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 76514, 77849);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 76514, 77849);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 76514, 77849);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_76675_76957(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 76675, 76957);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_77067_77125(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 77067, 77125);
            return return_v;
        }

    }
    public class OperatorPropertyPullerTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor BinaryOperatorDescriptor;

        public static readonly DiagnosticDescriptor UnaryOperatorDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 78686, 78761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 78689, 78761);
                    return f_25076_78689_78761(BinaryOperatorDescriptor, UnaryOperatorDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 78686, 78761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 78686, 78761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 78686, 78761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 78774, 81706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 78862, 80585);

                f_25076_78862_80584(context, (operationContext) =>
                    {
                        var binary = (IBinaryOperation)operationContext.Operation;
                        var left = binary.LeftOperand;
                        var right = binary.RightOperand;
                        if (!left.HasErrors(operationContext.Compilation, operationContext.CancellationToken) &&
                            !right.HasErrors(operationContext.Compilation, operationContext.CancellationToken) &&
                            binary.OperatorMethod == null)
                        {
                            if (left.Kind == OperationKind.LocalReference)
                            {
                                var leftLocal = ((ILocalReferenceOperation)left).Local;
                                if (leftLocal.Name == "x")
                                {
                                    if (right.Kind == OperationKind.Literal)
                                    {
                                        var rightValue = right.ConstantValue;
                                        if (rightValue.HasValue && rightValue.Value is int && (int)rightValue.Value == 10)
                                        {
                                            operationContext.ReportDiagnostic(
                                                Diagnostic.Create(BinaryOperatorDescriptor,
                                                binary.Syntax.GetLocation(),
                                                binary.OperatorKind.ToString()));
                                        }
                                    }
                                }
                            }
                        }
                    }, OperationKind.Binary);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 80601, 81695);

                f_25076_80601_81694(
                            context, (operationContext) =>
                                {
                                    var unary = (IUnaryOperation)operationContext.Operation;
                                    var operand = unary.Operand;
                                    if (operand.Kind == OperationKind.LocalReference)
                                    {
                                        var operandLocal = ((ILocalReferenceOperation)operand).Local;
                                        if (operandLocal.Name == "x")
                                        {
                                            if (!operand.HasErrors(operationContext.Compilation, operationContext.CancellationToken) && unary.OperatorMethod == null)
                                            {
                                                operationContext.ReportDiagnostic(
                                                    Diagnostic.Create(UnaryOperatorDescriptor,
                                                        unary.Syntax.GetLocation(),
                                                        unary.OperatorKind.ToString()));
                                            }
                                        }
                                    }
                                }, OperationKind.Unary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 78774, 81706);

                int
                f_25076_78862_80584(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 78862, 80584);
                    return 0;
                }


                int
                f_25076_80601_81694(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 80601, 81694);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 78774, 81706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 78774, 81706);
            }
        }

        public OperatorPropertyPullerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 77857, 81713);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 77857, 81713);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 77857, 81713);
        }


        static OperatorPropertyPullerTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 77857, 81713);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 77986, 78259);
            BinaryOperatorDescriptor = f_25076_78013_78259("BinaryOperator", "Binary operator found", "A Binary operator {0} was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 78316, 78579);
            UnaryOperatorDescriptor = f_25076_78342_78579("UnaryOperator", "Unary operator found", "A Unary operator {0} was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 77857, 81713);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 77857, 81713);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 77857, 81713);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_78013_78259(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 78013, 78259);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_78342_78579(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 78342, 78579);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_78689_78761(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 78689, 78761);
            return return_v;
        }

    }
    public class NullOperationSyntaxTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor NullOperationSyntaxDescriptor;

        public static readonly DiagnosticDescriptor ParamsArrayOperationDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 82933, 83033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 82939, 83031);

                    return f_25076_82946_83030(NullOperationSyntaxDescriptor, ParamsArrayOperationDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 82933, 83033);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_82946_83030(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 82946, 83030);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 82828, 83044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 82828, 83044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 83054, 84190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 83142, 84179);

                f_25076_83142_84178(context, (operationContext) =>
                    {
                        var nullList = new List<IOperation>();
                        var paramsList = new List<IOperation>();
                        var collector = new Walker(nullList, paramsList);
                        collector.Visit(operationContext.Operation);

                        foreach (var nullSyntaxOperation in nullList)
                        {
                            operationContext.ReportDiagnostic(
                                Diagnostic.Create(NullOperationSyntaxDescriptor, null));
                        }
                        foreach (var paramsarrayArgumentOperation in paramsList)
                        {
                            operationContext.ReportDiagnostic(
                                Diagnostic.Create(ParamsArrayOperationDescriptor,
                                                  paramsarrayArgumentOperation.Syntax.GetLocation()));
                        }
                    }, OperationKind.Invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 83054, 84190);

                int
                f_25076_83142_84178(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 83142, 84178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 83054, 84190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 83054, 84190);
            }
        }
        private sealed class Walker : OperationWalker
        {
            private readonly List<IOperation> _nullList;

            private readonly List<IOperation> _paramsList;

            public Walker(List<IOperation> nullList, List<IOperation> paramsList)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 84549, 84730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84463, 84472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84521, 84532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84651, 84672);

                    _nullList = nullList;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84690, 84715);

                    _paramsList = paramsList;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 84549, 84730);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 84549, 84730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 84549, 84730);
                }
            }

            public override void Visit(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 84746, 85416);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84827, 85361) || true) && (operation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 84827, 85361);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84890, 85016) || true) && (f_25076_84894_84910(operation) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 84890, 85016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 84968, 84993);

                            f_25076_84968_84992(_nullList, operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 84890, 85016);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85038, 85342) || true) && (f_25076_85042_85056(operation) == OperationKind.Argument)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 85038, 85342);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85132, 85319) || true) && (f_25076_85136_85180(((IArgumentOperation)operation)) == ArgumentKind.ParamArray)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25076, 85132, 85319);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85265, 85292);

                                f_25076_85265_85291(_paramsList, operation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 85132, 85319);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 85038, 85342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25076, 84827, 85361);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85379, 85401);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(operation), 25076, 85379, 85400);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 84746, 85416);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_25076_84894_84910(Microsoft.CodeAnalysis.IOperation
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 84894, 84910);
                        return return_v;
                    }


                    int
                    f_25076_84968_84992(System.Collections.Generic.List<Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 84968, 84992);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.OperationKind
                    f_25076_85042_85056(Microsoft.CodeAnalysis.IOperation
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 85042, 85056);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Operations.ArgumentKind
                    f_25076_85136_85180(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                    this_param)
                    {
                        var return_v = this_param.ArgumentKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25076, 85136, 85180);
                        return return_v;
                    }


                    int
                    f_25076_85265_85291(System.Collections.Generic.List<Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 85265, 85291);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 84746, 85416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 84746, 85416);
                }
            }

            static Walker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 84359, 85427);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 84359, 85427);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 84359, 85427);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 84359, 85427);
        }

        public NullOperationSyntaxTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 81721, 85434);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 81721, 85434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 81721, 85434);
        }


        static NullOperationSyntaxTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 81721, 85434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 81824, 81859);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 81981, 82306);
            NullOperationSyntaxDescriptor = f_25076_82013_82306("NullOperationSyntax", "null operation Syntax found", "An IOperation with Syntax property of value null is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 82522, 82815);
            ParamsArrayOperationDescriptor = f_25076_82555_82815("ParamsArray", "Params array argument found", "A params array argument is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 81721, 85434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 81721, 85434);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 81721, 85434);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_82013_82306(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 82013, 82306);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_82555_82815(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 82555, 82815);
            return return_v;
        }

    }
    public class InvalidOperatorExpressionTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor InvalidBinaryDescriptor;

        public static readonly DiagnosticDescriptor InvalidUnaryDescriptor;

        public static readonly DiagnosticDescriptor InvalidIncrementDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 87094, 87425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 87097, 87425);
                    return f_25076_87097_87425(InvalidBinaryDescriptor, InvalidUnaryDescriptor, InvalidIncrementDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 87094, 87425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 87094, 87425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 87094, 87425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 87438, 89288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 87526, 89277);

                f_25076_87526_89276(context, (operationContext) =>
                     {
                         var operation = operationContext.Operation;
                         if (operation.Kind == OperationKind.Binary)
                         {
                             var binary = (IBinaryOperation)operation;
                             if (binary.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(InvalidBinaryDescriptor, binary.Syntax.GetLocation()));
                             }
                         }
                         else if (operation.Kind == OperationKind.Unary)
                         {
                             var unary = (IUnaryOperation)operation;
                             if (unary.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(InvalidUnaryDescriptor, unary.Syntax.GetLocation()));
                             }
                         }
                         else if (operation.Kind == OperationKind.Increment)
                         {
                             var inc = (IIncrementOrDecrementOperation)operation;
                             if (inc.HasErrors(operationContext.Compilation))
                             {
                                 operationContext.ReportDiagnostic(Diagnostic.Create(InvalidIncrementDescriptor, inc.Syntax.GetLocation()));
                             }
                         }
                     }, OperationKind.Binary, OperationKind.Unary, OperationKind.Increment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 87438, 89288);

                int
                f_25076_87526_89276(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 87526, 89276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 87438, 89288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 87438, 89288);
            }
        }

        public InvalidOperatorExpressionTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 85442, 89295);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 85442, 89295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 85442, 89295);
        }


        static InvalidOperatorExpressionTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 85442, 89295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85551, 85586);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 85643, 86020);
            InvalidBinaryDescriptor = f_25076_85669_86020("InvalidBinary", "Invalid binary expression operation with BinaryOperationKind.Invalid", "An Invalid binary expression operation with BinaryOperationKind.Invalid is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 86077, 86448);
            InvalidUnaryDescriptor = f_25076_86102_86448("InvalidUnary", "Invalid unary expression operation with UnaryOperationKind.Invalid", "An Invalid unary expression operation with UnaryOperationKind.Invalid is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 86505, 87000);
            InvalidIncrementDescriptor = f_25076_86534_87000("InvalidIncrement", "Invalid increment expression operation with ICompoundAssignmentExpression.BinaryOperationKind == BinaryOperationKind.Invalid", "An Invalid increment expression operation with ICompoundAssignmentExpression.BinaryOperationKind == BinaryOperationKind.Invalid is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 85442, 89295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 85442, 89295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 85442, 89295);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_85669_86020(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 85669, 86020);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_86102_86448(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 86102, 86448);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_86534_87000(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 86534, 87000);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_87097_87425(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item3)
        {
            var return_v = ImmutableArray.Create(item1, item2, item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 87097, 87425);
            return return_v;
        }

    }
    public class ConditionalAccessOperationTestAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor ConditionalAccessOperationDescriptor;

        public static readonly DiagnosticDescriptor ConditionalAccessInstanceOperationDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 90267, 90388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 90273, 90386);

                    return f_25076_90280_90385(ConditionalAccessOperationDescriptor, ConditionalAccessInstanceOperationDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 90267, 90388);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_90280_90385(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 90280, 90385);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 90162, 90399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 90162, 90399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 90411, 92144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 90499, 91101);

                f_25076_90499_91100(context, (operationContext) =>
                     {
                         IConditionalAccessOperation conditionalAccess = (IConditionalAccessOperation)operationContext.Operation;
                         if (conditionalAccess.WhenNotNull != null && conditionalAccess.Operation != null)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(ConditionalAccessOperationDescriptor, conditionalAccess.Syntax.GetLocation()));
                         }
                     }, OperationKind.ConditionalAccess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 91117, 91611);

                f_25076_91117_91610(
                            context, (operationContext) =>
                                 {
                                     IConditionalAccessInstanceOperation conditionalAccessInstance = (IConditionalAccessInstanceOperation)operationContext.Operation;
                                     operationContext.ReportDiagnostic(Diagnostic.Create(ConditionalAccessInstanceOperationDescriptor, conditionalAccessInstance.Syntax.GetLocation()));
                                 }, OperationKind.ConditionalAccessInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 90411, 92144);

                int
                f_25076_90499_91100(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 90499, 91100);
                    return 0;
                }


                int
                f_25076_91117_91610(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 91117, 91610);
                    return 0;
                }


                // https://github.com/dotnet/roslyn/issues/21294
                //context.RegisterOperationAction(
                //    (operationContext) =>
                //    {
                //        IPlaceholderExpression placeholder = (IPlaceholderExpression)operationContext.Operation;
                //        operationContext.ReportDiagnostic(Diagnostic.Create(ConditionalAccessInstanceOperationDescriptor, placeholder.Syntax.GetLocation()));
                //    },
                //    OperationKind.PlaceholderExpression);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 90411, 92144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 90411, 92144);
            }
        }

        public ConditionalAccessOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 89303, 92151);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 89303, 92151);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 89303, 92151);
        }


        static ConditionalAccessOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 89303, 92151);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 89436, 89747);
            ConditionalAccessOperationDescriptor = f_25076_89475_89747("ConditionalAccessOperation", "Conditional access operation found", "Conditional access operation was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 89804, 90149);
            ConditionalAccessInstanceOperationDescriptor = f_25076_89851_90149("ConditionalAccessInstanceOperation", "Conditional access instance operation found", "Conditional access instance operation was found", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 89303, 92151);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 89303, 92151);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 89303, 92151);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_89475_89747(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 89475, 89747);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_89851_90149(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 89851, 90149);
            return return_v;
        }

    }
    public class ConversionExpressionCSharpTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor InvalidConversionExpressionDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 92795, 92871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 92801, 92869);

                    return f_25076_92808_92868(InvalidConversionExpressionDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 92795, 92871);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_92808_92868(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 92808, 92868);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 92690, 92882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 92690, 92882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 92894, 93554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 92982, 93543);

                f_25076_92982_93542(context, (operationContext) =>
                     {
                         var conversion = (IConversionOperation)operationContext.Operation;
                         if (conversion.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(InvalidConversionExpressionDescriptor, conversion.Syntax.GetLocation()));
                         }
                     }, OperationKind.Conversion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 92894, 93554);

                int
                f_25076_92982_93542(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 92982, 93542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 92894, 93554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 92894, 93554);
            }
        }

        public ConversionExpressionCSharpTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 92159, 93561);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 92159, 93561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 92159, 93561);
        }


        static ConversionExpressionCSharpTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 92159, 93561);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 92269, 92304);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 92361, 92677);
            InvalidConversionExpressionDescriptor = f_25076_92401_92677("InvalidConversionExpression", "Invalid conversion expression", "Invalid conversion expression.", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 92159, 93561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 92159, 93561);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 92159, 93561);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_92401_92677(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 92401, 92677);
            return return_v;
        }

    }
    public class ForLoopConditionCrashVBTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor ForLoopConditionCrashDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 94223, 94293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 94229, 94291);

                    return f_25076_94236_94290(ForLoopConditionCrashDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 94223, 94293);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_94236_94290(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 94236, 94290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 94118, 94304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 94118, 94304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 94316, 95307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 94404, 95296);

                f_25076_94404_95295(context, (operationContext) =>
                     {
                         ILoopOperation loop = (ILoopOperation)operationContext.Operation;
                         if (loop.LoopKind == LoopKind.ForTo)
                         {
                             var forLoop = (IForToLoopOperation)loop;
                             var forCondition = forLoop.LimitValue;

                             if (forCondition.HasErrors(operationContext.Compilation, operationContext.CancellationToken))
                             {
                             // Generate a warning to prove we didn't crash
                             operationContext.ReportDiagnostic(Diagnostic.Create(ForLoopConditionCrashDescriptor, forLoop.LimitValue.Syntax.GetLocation()));
                             }
                         }
                     }, OperationKind.Loop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 94316, 95307);

                int
                f_25076_94404_95295(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 94404, 95295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 94316, 95307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 94316, 95307);
            }
        }

        public ForLoopConditionCrashVBTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 93569, 95314);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 93569, 95314);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 93569, 95314);
        }


        static ForLoopConditionCrashVBTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 93569, 95314);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 93676, 93711);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 93768, 94105);
            ForLoopConditionCrashDescriptor = f_25076_93802_94105("ForLoopConditionCrash", "Ensure ForLoopCondition property doesn't crash", "Ensure ForLoopCondition property doesn't crash", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 93569, 95314);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 93569, 95314);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 93569, 95314);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_93802_94105(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 93802, 94105);
            return return_v;
        }

    }
    public class TrueFalseUnaryOperationTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor UnaryTrueDescriptor;

        public static readonly DiagnosticDescriptor UnaryFalseDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 96257, 96324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 96260, 96324);
                    return f_25076_96260_96324(UnaryTrueDescriptor, UnaryFalseDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 96257, 96324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 96257, 96324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 96257, 96324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 96337, 97173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 96425, 97162);

                f_25076_96425_97161(context, (operationContext) =>
                     {
                         var unary = (IUnaryOperation)operationContext.Operation;
                         if (unary.OperatorKind == UnaryOperatorKind.True)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(UnaryTrueDescriptor, unary.Syntax.GetLocation()));
                         }
                         else if (unary.OperatorKind == UnaryOperatorKind.False)
                         {
                             operationContext.ReportDiagnostic(Diagnostic.Create(UnaryFalseDescriptor, unary.Syntax.GetLocation()));
                         }
                     }, OperationKind.Unary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 96337, 97173);

                int
                f_25076_96425_97161(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 96425, 97161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 96337, 97173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 96337, 97173);
            }
        }

        public TrueFalseUnaryOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 95322, 97180);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 95322, 97180);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 95322, 97180);
        }


        static TrueFalseUnaryOperationTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 95322, 97180);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 95429, 95464);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 95521, 95805);
            UnaryTrueDescriptor = f_25076_95543_95805("UnaryTrue", "An unary True operation is found", "A unary True operation is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 95862, 96150);
            UnaryFalseDescriptor = f_25076_95885_96150("UnaryFalse", "An unary False operation is found", "A unary False operation is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 95322, 97180);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 95322, 97180);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 95322, 97180);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_95543_95805(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 95543, 95805);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_95885_96150(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 95885, 96150);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_96260_96324(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
        item2)
        {
            var return_v = ImmutableArray.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 96260, 96324);
            return return_v;
        }

    }
    public class AssignmentOperationSyntaxTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor AssignmentOperationDescriptor;

        public static readonly DiagnosticDescriptor AssignmentSyntaxDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 98162, 98258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 98168, 98256);

                    return f_25076_98175_98255(AssignmentOperationDescriptor, AssignmentSyntaxDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 98162, 98258);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_98175_98255(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 98175, 98255);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 98057, 98269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 98057, 98269);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 98281, 99029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 98369, 98689);

                f_25076_98369_98688(context, (operationContext) =>
                     {
                         operationContext.ReportDiagnostic(Diagnostic.Create(AssignmentOperationDescriptor, operationContext.Operation.Syntax.GetLocation()));
                     }, OperationKind.SimpleAssignment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 98705, 99018);

                f_25076_98705_99017(
                            context, (syntaxContext) =>
                                 {

                                     syntaxContext.ReportDiagnostic(Diagnostic.Create(AssignmentSyntaxDescriptor, syntaxContext.Node.GetLocation()));
                                 }, CSharp.SyntaxKind.SimpleAssignmentExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 98281, 99029);

                int
                f_25076_98369_98688(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 98369, 98688);
                    return 0;
                }


                int
                f_25076_98705_99017(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<Microsoft.CodeAnalysis.CSharp.SyntaxKind>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 98705, 99017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 98281, 99029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 98281, 99029);
            }
        }

        public AssignmentOperationSyntaxTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 97188, 99036);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 97188, 99036);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 97188, 99036);
        }


        static AssignmentOperationSyntaxTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 97188, 99036);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 97297, 97332);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 97389, 97694);
            AssignmentOperationDescriptor = f_25076_97421_97694("AssignmentOperation", "An assignment operation is found", "An assignment operation is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 97751, 98044);
            AssignmentSyntaxDescriptor = f_25076_97780_98044("AssignmentSyntax", "An assignment syntax is found", "An assignment syntax is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 97188, 99036);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 97188, 99036);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 97188, 99036);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_97421_97694(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 97421, 97694);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_97780_98044(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 97780, 98044);
            return return_v;
        }

    }
    public class LiteralTestAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor LiteralDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 99611, 99667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 99617, 99665);

                    return f_25076_99624_99664(LiteralDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 99611, 99667);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25076_99624_99664(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 99624, 99664);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 99506, 99678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 99506, 99678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 99690, 100179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 99778, 100168);

                f_25076_99778_100167(context, (operationContext) =>
                     {
                         var literal = (ILiteralOperation)operationContext.Operation;
                         operationContext.ReportDiagnostic(Diagnostic.Create(LiteralDescriptor, literal.Syntax.GetLocation(), literal.Syntax.ToString()));
                     }, OperationKind.Literal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 99690, 100179);

                int
                f_25076_99778_100167(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 99778, 100167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 99690, 100179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 99690, 100179);
            }
        }

        public LiteralTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 99044, 100186);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 99044, 100186);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 99044, 100186);
        }


        static LiteralTestAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 99044, 100186);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 99135, 99170);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 99227, 99493);
            LiteralDescriptor = f_25076_99247_99493("Literal", "A literal is found", "A literal of value {0} is found", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 99044, 100186);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 99044, 100186);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 99044, 100186);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_99247_99493(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 99247, 99493);
            return return_v;
        }

    }
    public class AnalysisContextAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor OperationActionDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 100888, 100939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 100891, 100939);
                    return f_25076_100891_100939(OperationActionDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 100888, 100939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 100888, 100939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 100888, 100939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 100952, 101404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 101040, 101393);

                f_25076_101040_101392(context, (operationContext) =>
                    {
                        operationContext.ReportDiagnostic(
                            Diagnostic.Create(OperationActionDescriptor, operationContext.Operation.Syntax.GetLocation(), "Operation", "Analysis"));
                    }, OperationKind.Literal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 100952, 101404);

                int
                f_25076_101040_101392(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 101040, 101392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 100952, 101404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 100952, 101404);
            }
        }

        public AnalysisContextAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 100283, 101411);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 100283, 101411);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 100283, 101411);
        }


        static AnalysisContextAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 100283, 101411);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 100378, 100413);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 100470, 100781);
            OperationActionDescriptor = f_25076_100498_100781("AnalysisContext", "An operation related action is invoked", "An {0} action is invoked in {1} context.", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 100283, 101411);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 100283, 101411);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 100283, 101411);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_100498_100781(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 100498, 100781);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_100891_100939(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 100891, 100939);
            return return_v;
        }

    }
    public class CompilationStartAnalysisContextAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor OperationActionDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 102161, 102212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 102164, 102212);
                    return f_25076_102164_102212(OperationActionDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 102161, 102212);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 102161, 102212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 102161, 102212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 102225, 102912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 102313, 102901);

                f_25076_102313_102900(context, (compilationStartContext) =>
                    {
                        compilationStartContext.RegisterOperationAction(
                            (operationContext) =>
                            {
                                operationContext.ReportDiagnostic(
                                    Diagnostic.Create(OperationActionDescriptor, operationContext.Operation.Syntax.GetLocation(), "Operation", "CompilationStart within Analysis"));
                            },
                            OperationKind.Literal);
                    });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 102225, 102912);

                int
                f_25076_102313_102900(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 102313, 102900);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 102225, 102912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 102225, 102912);
            }
        }

        public CompilationStartAnalysisContextAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 101524, 102919);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 101524, 102919);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 101524, 102919);
        }


        static CompilationStartAnalysisContextAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 101524, 102919);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 101635, 101670);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 101727, 102054);
            OperationActionDescriptor = f_25076_101755_102054("CompilationStartAnalysisContext", "An operation related action is invoked", "An {0} action is invoked in {1} context.", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 101524, 102919);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 101524, 102919);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 101524, 102919);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_101755_102054(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 101755, 102054);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_102164_102212(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 102164, 102212);
            return return_v;
        }

    }
    public class SemanticModelAnalyzer : DiagnosticAnalyzer
    {
        private const string
        ReliabilityCategory = "Reliability"
        ;

        public static readonly DiagnosticDescriptor GetOperationDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 103601, 103649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 103604, 103649);
                    return f_25076_103604_103649(GetOperationDescriptor); DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 103601, 103649);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 103601, 103649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 103601, 103649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25076, 103662, 104846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 103750, 104282);

                f_25076_103750_104281(context, (syntaxContext) =>
                    {
                        var node = syntaxContext.Node;
                        var model = syntaxContext.SemanticModel;
                        if (model.GetOperation(node) != null)
                        {
                            syntaxContext.ReportDiagnostic(Diagnostic.Create(GetOperationDescriptor, node.GetLocation()));
                        }
                    }, Microsoft.CodeAnalysis.CSharp.SyntaxKind.NumericLiteralExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 104298, 104835);

                f_25076_104298_104834(
                            context, (syntaxContext) =>
                                {
                                    var node = syntaxContext.Node;
                                    var model = syntaxContext.SemanticModel;
                                    if (model.GetOperation(node) != null)
                                    {
                                        syntaxContext.ReportDiagnostic(Diagnostic.Create(GetOperationDescriptor, node.GetLocation()));
                                    }
                                }, Microsoft.CodeAnalysis.VisualBasic.SyntaxKind.NumericLiteralExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25076, 103662, 104846);

                int
                f_25076_103750_104281(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<Microsoft.CodeAnalysis.CSharp.SyntaxKind>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 103750, 104281);
                    return 0;
                }


                int
                f_25076_104298_104834(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, params Microsoft.CodeAnalysis.VisualBasic.SyntaxKind[]
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<Microsoft.CodeAnalysis.VisualBasic.SyntaxKind>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 104298, 104834);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25076, 103662, 104846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 103662, 104846);
            }
        }

        public SemanticModelAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25076, 102997, 104853);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25076, 102997, 104853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 102997, 104853);
        }


        static SemanticModelAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25076, 102997, 104853);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 103090, 103125);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25076, 103182, 103494);
            GetOperationDescriptor = f_25076_103207_103494("GetOperation", "An IOperation is returned by SemanticModel", "An IOperation is returned by SemanticModel.", ReliabilityCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25076, 102997, 104853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25076, 102997, 104853);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25076, 102997, 104853);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25076_103207_103494(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 103207, 103494);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
        f_25076_103604_103649(Microsoft.CodeAnalysis.DiagnosticDescriptor
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25076, 103604, 103649);
            return return_v;
        }

    }
}
