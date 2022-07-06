// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public class FieldCouldBeReadOnlyAnalyzer : DiagnosticAnalyzer
    {
        private const string
        SystemCategory = "System"
        ;

        public static readonly DiagnosticDescriptor FieldCouldBeReadOnlyDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25074, 1278, 1347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 1284, 1345);

                    return f_25074_1291_1344(FieldCouldBeReadOnlyDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25074, 1278, 1347);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25074_1291_1344(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 1291, 1344);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25074, 1173, 1358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 1173, 1358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25074, 1370, 5918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 1458, 5907);

                f_25074_1458_5906(context, (compilationContext) =>
                     {
                         HashSet<IFieldSymbol> assignedToFields = new HashSet<IFieldSymbol>();
                         HashSet<IFieldSymbol> mightBecomeReadOnlyFields = new HashSet<IFieldSymbol>();

                         compilationContext.RegisterOperationBlockStartAction(
                             (operationBlockContext) =>
                             {

                                 if (operationBlockContext.OwningSymbol is IMethodSymbol containingMethod)
                                 {
                                     bool inConstructor = containingMethod.MethodKind == MethodKind.Constructor;
                                     ITypeSymbol staticConstructorType = containingMethod.MethodKind == MethodKind.StaticConstructor ? containingMethod.ContainingType : null;

                                     operationBlockContext.RegisterOperationAction(
                                        (operationContext) =>
                                        {
                                            if (operationContext.Operation is IAssignmentOperation assignment)
                                            {
                                                AssignTo(assignment.Target, inConstructor, staticConstructorType, assignedToFields, mightBecomeReadOnlyFields);
                                            }
                                            else if (operationContext.Operation is IIncrementOrDecrementOperation increment)
                                            {
                                                AssignTo(increment.Target, inConstructor, staticConstructorType, assignedToFields, mightBecomeReadOnlyFields);
                                            }
                                            else
                                            {
                                                throw TestExceptionUtilities.UnexpectedValue(operationContext.Operation);
                                            }
                                        },
                                        OperationKind.SimpleAssignment,
                                        OperationKind.CompoundAssignment,
                                        OperationKind.Increment,
                                        OperationKind.Decrement);

                                     operationBlockContext.RegisterOperationAction(
                                         (operationContext) =>
                                         {
                                             IInvocationOperation invocation = (IInvocationOperation)operationContext.Operation;
                                             foreach (IArgumentOperation argument in invocation.Arguments)
                                             {
                                                 if (argument.Parameter.RefKind == RefKind.Out || argument.Parameter.RefKind == RefKind.Ref)
                                                 {
                                                     AssignTo(argument.Value, inConstructor, staticConstructorType, assignedToFields, mightBecomeReadOnlyFields);
                                                 }
                                             }
                                         },
                                         OperationKind.Invocation);
                                 }
                             });

                         compilationContext.RegisterSymbolAction(
                             (symbolContext) =>
                             {
                                 IFieldSymbol field = (IFieldSymbol)symbolContext.Symbol;
                                 if (!field.IsConst && !field.IsReadOnly && !assignedToFields.Contains(field))
                                 {
                                     mightBecomeReadOnlyFields.Add(field);
                                 }
                             },
                             SymbolKind.Field
                             );

                         compilationContext.RegisterCompilationEndAction(
                             (compilationEndContext) =>
                             {
                                 foreach (IFieldSymbol couldBeReadOnlyField in mightBecomeReadOnlyFields)
                                 {
                                     Report(compilationEndContext, couldBeReadOnlyField, FieldCouldBeReadOnlyDescriptor);
                                 }
                             });
                     });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25074, 1370, 5918);

                int
                f_25074_1458_5906(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 1458, 5906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25074, 1370, 5918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 1370, 5918);
            }
        }

        private static void AssignTo(IOperation target, bool inConstructor, ITypeSymbol staticConstructorType, HashSet<IFieldSymbol> assignedToFields, HashSet<IFieldSymbol> mightBecomeReadOnlyFields)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25074, 5930, 7305);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6146, 7294) || true) && (f_25074_6150_6161(target) == OperationKind.FieldReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25074, 6146, 7294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6227, 6302);

                    IFieldReferenceOperation
                    fieldReference = (IFieldReferenceOperation)target
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6320, 6616) || true) && (inConstructor && (DynAbs.Tracing.TraceSender.Expression_True(25074, 6324, 6372) && f_25074_6341_6364(fieldReference) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25074, 6320, 6616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6414, 6597);

                        switch (f_25074_6422_6450(f_25074_6422_6445(fieldReference)))
                        {

                            case OperationKind.InstanceReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25074, 6414, 6597);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6567, 6574);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25074, 6414, 6597);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25074, 6320, 6616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6636, 6684);

                    IFieldSymbol
                    targetField = f_25074_6663_6683(fieldReference)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6704, 6884) || true) && (staticConstructorType != null && (DynAbs.Tracing.TraceSender.Expression_True(25074, 6708, 6761) && f_25074_6741_6761(targetField)) && (DynAbs.Tracing.TraceSender.Expression_True(25074, 6708, 6816) && f_25074_6765_6791(targetField) == staticConstructorType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25074, 6704, 6884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6858, 6865);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25074, 6704, 6884);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6904, 6938);

                    f_25074_6904_6937(
                                    assignedToFields, targetField);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 6956, 7002);

                    f_25074_6956_7001(mightBecomeReadOnlyFields, targetField);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 7022, 7279) || true) && (f_25074_7026_7049(fieldReference) != null && (DynAbs.Tracing.TraceSender.Expression_True(25074, 7026, 7101) && f_25074_7061_7101(f_25074_7061_7089(f_25074_7061_7084(fieldReference)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25074, 7022, 7279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 7143, 7260);

                        f_25074_7143_7259(f_25074_7152_7175(fieldReference), inConstructor, staticConstructorType, assignedToFields, mightBecomeReadOnlyFields);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25074, 7022, 7279);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25074, 6146, 7294);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25074, 5930, 7305);

                Microsoft.CodeAnalysis.OperationKind
                f_25074_6150_6161(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6150, 6161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25074_6341_6364(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6341, 6364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25074_6422_6445(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6422, 6445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25074_6422_6450(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6422, 6450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol
                f_25074_6663_6683(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6663, 6683);
                    return return_v;
                }


                bool
                f_25074_6741_6761(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6741, 6761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_25074_6765_6791(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 6765, 6791);
                    return return_v;
                }


                bool
                f_25074_6904_6937(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IFieldSymbol>
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 6904, 6937);
                    return return_v;
                }


                bool
                f_25074_6956_7001(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IFieldSymbol>
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 6956, 7001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25074_7026_7049(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 7026, 7049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25074_7061_7084(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 7061, 7084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25074_7061_7089(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 7061, 7089);
                    return return_v;
                }


                bool
                f_25074_7061_7101(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 7061, 7101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25074_7152_7175(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25074, 7152, 7175);
                    return return_v;
                }


                int
                f_25074_7143_7259(Microsoft.CodeAnalysis.IOperation
                target, bool
                inConstructor, Microsoft.CodeAnalysis.ITypeSymbol?
                staticConstructorType, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IFieldSymbol>
                assignedToFields, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IFieldSymbol>
                mightBecomeReadOnlyFields)
                {
                    AssignTo(target, inConstructor, staticConstructorType, assignedToFields, mightBecomeReadOnlyFields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 7143, 7259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25074, 5930, 7305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 5930, 7305);
            }
        }

        private void Report(CompilationAnalysisContext context, IFieldSymbol field, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25074, 7317, 7551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 7450, 7540);

                context.ReportDiagnostic(f_25074_7475_7538(descriptor, field.Locations.FirstOrDefault()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25074, 7317, 7551);

                Microsoft.CodeAnalysis.Diagnostic
                f_25074_7475_7538(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 7475, 7538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25074, 7317, 7551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 7317, 7551);
            }
        }

        public FieldCouldBeReadOnlyAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25074, 558, 7558);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25074, 558, 7558);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 558, 7558);
        }


        static FieldCouldBeReadOnlyAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25074, 558, 7558);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 658, 683);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25074, 740, 1059);
            FieldCouldBeReadOnlyDescriptor = f_25074_773_1059("FieldCouldBeReadOnly", "Field Could Be ReadOnly", "Field is never modified and so could be readonly or const.", SystemCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25074, 558, 7558);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25074, 558, 7558);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25074, 558, 7558);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25074_773_1059(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25074, 773, 1059);
            return return_v;
        }

    }
}
