// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public class BoxingOperationAnalyzer : DiagnosticAnalyzer
    {
        private const string
        PerformanceCategory = "Performance"
        ;

        private static readonly LocalizableString s_localizableTitle;

        private static readonly LocalizableString s_localizableMessage;

        public static readonly DiagnosticDescriptor BoxingDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25068, 1491, 1546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 1497, 1544);

                    return f_25068_1504_1543(BoxingDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25068, 1491, 1546);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25068_1504_1543(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25068, 1504, 1543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25068, 1386, 1557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25068, 1386, 1557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25068, 1569, 3213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 1657, 3202);

                f_25068_1657_3201(context, (operationContext) =>
                     {
                         IOperation operation = operationContext.Operation;

                         if (operation.Kind == OperationKind.Conversion)
                         {
                             IConversionOperation conversion = (IConversionOperation)operation;
                             if (conversion.Type.IsReferenceType &&
                                 conversion.Operand.Type != null &&
                                 conversion.Operand.Type.IsValueType &&
                                 conversion.OperatorMethod == null)
                             {
                                 Report(operationContext, conversion.Syntax);
                             }
                         }

                     // Calls to instance methods of value types don’t have conversions.
                     if (operation.Kind == OperationKind.Invocation)
                         {
                             IInvocationOperation invocation = (IInvocationOperation)operation;

                             if (invocation.Instance != null &&
                                 invocation.Instance.Type.IsValueType &&
                                 invocation.TargetMethod.ContainingType.IsReferenceType)
                             {
                                 Report(operationContext, invocation.Instance.Syntax);
                             }
                         }
                     }, OperationKind.Conversion, OperationKind.Invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25068, 1569, 3213);

                int
                f_25068_1657_3201(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25068, 1657, 3201);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25068, 1569, 3213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25068, 1569, 3213);
            }
        }

        internal void Report(OperationAnalysisContext context, SyntaxNode boxingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25068, 3459, 3672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 3567, 3661);

                context.ReportDiagnostic(f_25068_3592_3659(BoxingDescriptor, f_25068_3628_3658(boxingExpression)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25068, 3459, 3672);

                Microsoft.CodeAnalysis.Location
                f_25068_3628_3658(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25068, 3628, 3658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25068_3592_3659(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25068, 3592, 3659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25068, 3459, 3672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25068, 3459, 3672);
            }
        }

        public BoxingOperationAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25068, 496, 3679);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25068, 496, 3679);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25068, 496, 3679);
        }


        static BoxingOperationAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25068, 496, 3679);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 658, 693);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 748, 777);
            s_localizableTitle = "Boxing"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 830, 874);
            s_localizableMessage = "Boxing is expensive"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25068, 1019, 1272);
            BoxingDescriptor = f_25068_1038_1272("BoxingRule", s_localizableTitle, s_localizableMessage, PerformanceCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25068, 496, 3679);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25068, 496, 3679);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25068, 496, 3679);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25068_1038_1272(string
        id, Microsoft.CodeAnalysis.LocalizableString
        title, Microsoft.CodeAnalysis.LocalizableString
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25068, 1038, 1272);
            return return_v;
        }

    }
}
