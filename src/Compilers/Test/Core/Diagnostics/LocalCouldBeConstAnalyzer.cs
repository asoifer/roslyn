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
    public class LocalCouldBeConstAnalyzer : DiagnosticAnalyzer
    {
        private const string
        SystemCategory = "System"
        ;

        public static readonly DiagnosticDescriptor LocalCouldBeConstDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25075, 1272, 1338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 1278, 1336);

                    return f_25075_1285_1335(LocalCouldBeConstDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25075, 1272, 1338);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25075_1285_1335(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 1285, 1335);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25075, 1167, 1349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 1167, 1349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25075, 1361, 6010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 1449, 5999);

                f_25075_1449_5998(context, (operationBlockContext) =>
                    {

                        if (operationBlockContext.OwningSymbol is IMethodSymbol containingMethod)
                        {
                            HashSet<ILocalSymbol> mightBecomeConstLocals = new HashSet<ILocalSymbol>();
                            HashSet<ILocalSymbol> assignedToLocals = new HashSet<ILocalSymbol>();

                            operationBlockContext.RegisterOperationAction(
                               (operationContext) =>
                               {
                                   if (operationContext.Operation is IAssignmentOperation assignment)
                                   {
                                       AssignTo(assignment.Target, assignedToLocals, mightBecomeConstLocals);
                                   }
                                   else if (operationContext.Operation is IIncrementOrDecrementOperation increment)
                                   {
                                       AssignTo(increment.Target, assignedToLocals, mightBecomeConstLocals);
                                   }
                                   else
                                   {
                                       throw TestExceptionUtilities.UnexpectedValue(operationContext.Operation);
                                   }
                               },
                               OperationKind.SimpleAssignment,
                               OperationKind.CompoundAssignment,
                               OperationKind.Increment);

                            operationBlockContext.RegisterOperationAction(
                                (operationContext) =>
                                {
                                    IInvocationOperation invocation = (IInvocationOperation)operationContext.Operation;
                                    foreach (IArgumentOperation argument in invocation.Arguments)
                                    {
                                        if (argument.Parameter.RefKind == RefKind.Out || argument.Parameter.RefKind == RefKind.Ref)
                                        {
                                            AssignTo(argument.Value, assignedToLocals, mightBecomeConstLocals);
                                        }
                                    }
                                },
                                OperationKind.Invocation);

                            operationBlockContext.RegisterOperationAction(
                                (operationContext) =>
                                {
                                    IVariableDeclarationGroupOperation declaration = (IVariableDeclarationGroupOperation)operationContext.Operation;
                                    foreach (IVariableDeclaratorOperation variable in declaration.Declarations.SelectMany(decl => decl.Declarators))
                                    {
                                        ILocalSymbol local = variable.Symbol;
                                        if (!local.IsConst && !assignedToLocals.Contains(local))
                                        {
                                            var localType = local.Type;
                                            if ((!localType.IsReferenceType || localType.SpecialType == SpecialType.System_String) && localType.SpecialType != SpecialType.None)
                                            {
                                                IVariableInitializerOperation initializer = variable.GetVariableInitializer();
                                                if (initializer != null && initializer.Value.ConstantValue.HasValue)
                                                {
                                                    mightBecomeConstLocals.Add(local);
                                                }
                                            }
                                        }
                                    }
                                },
                                OperationKind.VariableDeclarationGroup);

                            operationBlockContext.RegisterOperationBlockEndAction(
                                (operationBlockEndContext) =>
                                {
                                    foreach (ILocalSymbol couldBeConstLocal in mightBecomeConstLocals)
                                    {
                                        Report(operationBlockEndContext, couldBeConstLocal, LocalCouldBeConstDescriptor);
                                    }
                                });
                        }
                    });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25075, 1361, 6010);

                int
                f_25075_1449_5998(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 1449, 5998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25075, 1361, 6010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 1361, 6010);
            }
        }

        private static void AssignTo(IOperation target, HashSet<ILocalSymbol> assignedToLocals, HashSet<ILocalSymbol> mightBecomeConstLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25075, 6022, 6894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6180, 6883) || true) && (f_25075_6184_6195(target) == OperationKind.LocalReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25075, 6180, 6883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6261, 6329);

                    ILocalSymbol
                    targetLocal = f_25075_6288_6328(((ILocalReferenceOperation)target))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6349, 6383);

                    f_25075_6349_6382(
                                    assignedToLocals, targetLocal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6401, 6444);

                    f_25075_6401_6443(mightBecomeConstLocals, targetLocal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25075, 6180, 6883);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25075, 6180, 6883);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6478, 6883) || true) && (f_25075_6482_6493(target) == OperationKind.FieldReference)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25075, 6478, 6883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6559, 6634);

                        IFieldReferenceOperation
                        fieldReference = (IFieldReferenceOperation)target
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6652, 6868) || true) && (f_25075_6656_6679(fieldReference) != null && (DynAbs.Tracing.TraceSender.Expression_True(25075, 6656, 6731) && f_25075_6691_6731(f_25075_6691_6719(f_25075_6691_6714(fieldReference)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25075, 6652, 6868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 6773, 6849);

                            f_25075_6773_6848(f_25075_6782_6805(fieldReference), assignedToLocals, mightBecomeConstLocals);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25075, 6652, 6868);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25075, 6478, 6883);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25075, 6180, 6883);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25075, 6022, 6894);

                Microsoft.CodeAnalysis.OperationKind
                f_25075_6184_6195(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6184, 6195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25075_6288_6328(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6288, 6328);
                    return return_v;
                }


                bool
                f_25075_6349_6382(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ILocalSymbol>
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 6349, 6382);
                    return return_v;
                }


                bool
                f_25075_6401_6443(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ILocalSymbol>
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 6401, 6443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25075_6482_6493(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6482, 6493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25075_6656_6679(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6656, 6679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25075_6691_6714(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6691, 6714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25075_6691_6719(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6691, 6719);
                    return return_v;
                }


                bool
                f_25075_6691_6731(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6691, 6731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25075_6782_6805(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25075, 6782, 6805);
                    return return_v;
                }


                int
                f_25075_6773_6848(Microsoft.CodeAnalysis.IOperation
                target, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ILocalSymbol>
                assignedToLocals, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ILocalSymbol>
                mightBecomeConstLocals)
                {
                    AssignTo(target, assignedToLocals, mightBecomeConstLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 6773, 6848);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25075, 6022, 6894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 6022, 6894);
            }
        }

        private void Report(OperationBlockAnalysisContext context, ILocalSymbol local, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25075, 6906, 7143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 7042, 7132);

                context.ReportDiagnostic(f_25075_7067_7130(descriptor, local.Locations.FirstOrDefault()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25075, 6906, 7143);

                Microsoft.CodeAnalysis.Diagnostic
                f_25075_7067_7130(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 7067, 7130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25075, 6906, 7143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 6906, 7143);
            }
        }

        public LocalCouldBeConstAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25075, 564, 7150);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25075, 564, 7150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 564, 7150);
        }


        static LocalCouldBeConstAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25075, 564, 7150);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 661, 686);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25075, 743, 1053);
            LocalCouldBeConstDescriptor = f_25075_773_1053("LocalCouldBeReadOnly", "Local Could Be Const", "Local variable is never modified and so could be const.", SystemCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25075, 564, 7150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25075, 564, 7150);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25075, 564, 7150);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25075_773_1053(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25075, 773, 1053);
            return return_v;
        }

    }
}
