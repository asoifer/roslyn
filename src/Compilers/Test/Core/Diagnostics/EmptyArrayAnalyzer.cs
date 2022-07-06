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
    public class EmptyArrayAnalyzer : DiagnosticAnalyzer
    {
        private const string
        SystemCategory = "System"
        ;

        internal const string
        ArrayTypeName = "System.Array"
        ;

        internal const string
        ArrayEmptyMethodName = "Empty"
        ;

        private static readonly LocalizableString s_localizableTitle;

        private static readonly LocalizableString s_localizableMessage;

        public static readonly DiagnosticDescriptor UseArrayEmptyDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25073, 1864, 1926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 1870, 1924);

                    return f_25073_1877_1923(UseArrayEmptyDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25073, 1864, 1926);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25073_1877_1923(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 1877, 1923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25073, 1759, 1937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 1759, 1937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25073, 1949, 2172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 2037, 2161);

                f_25073_2037_2160(context, ctx =>
                {
                    RegisterOperationAction(ctx);
                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25073, 1949, 2172);

                int
                f_25073_2037_2160(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 2037, 2160);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25073, 1949, 2172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 1949, 2172);
            }
        }

        internal void Report(OperationAnalysisContext context, SyntaxNode arrayCreationExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25073, 2453, 2687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 2568, 2676);

                context.ReportDiagnostic(f_25073_2593_2674(UseArrayEmptyDescriptor, f_25073_2636_2673(arrayCreationExpression)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25073, 2453, 2687);

                Microsoft.CodeAnalysis.Location
                f_25073_2636_2673(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 2636, 2673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_25073_2593_2674(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 2593, 2674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25073, 2453, 2687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 2453, 2687);
            }
        }

        internal void RegisterOperationAction(CompilationStartAnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25073, 2877, 4441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 2980, 4430);

                f_25073_2980_4429(context, (operationContext) =>
                        {
                            IArrayCreationOperation arrayCreation = (IArrayCreationOperation)operationContext.Operation;

                        // ToDo: Need to suppress analysis of array creation expressions within attribute applications.

                        // Detect array creation expression that have rank 1 and size 0. Such expressions
                        // can be replaced with Array.Empty<T>(), provided that the element type can be a generic type argument.

                        var elementType = (arrayCreation as IArrayTypeSymbol)?.ElementType;
                            if (arrayCreation.DimensionSizes.Length == 1
                                //// Pointer types can't be generic type arguments.
                                && elementType?.TypeKind != TypeKind.Pointer)
                            {
                                Optional<object> arrayLength = arrayCreation.DimensionSizes[0].ConstantValue;
                                if (arrayLength.HasValue &&
                                    arrayLength.Value is int &&
                                    (int)arrayLength.Value == 0)
                                {
                                    Report(operationContext, arrayCreation.Syntax);
                                }
                            }
                        }, OperationKind.ArrayCreation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25073, 2877, 4441);

                int
                f_25073_2980_4429(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, params Microsoft.CodeAnalysis.OperationKind[]
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 2980, 4429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25073, 2877, 4441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 2877, 4441);
            }
        }

        public EmptyArrayAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25073, 539, 4448);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25073, 539, 4448);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 539, 4448);
        }


        static EmptyArrayAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25073, 539, 4448);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 629, 654);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 749, 779);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 949, 979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 1034, 1068);
            s_localizableTitle = "Empty Array"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 1121, 1199);
            s_localizableMessage = "Empty array creation can be replaced with Array.Empty"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25073, 1386, 1645);
            UseArrayEmptyDescriptor = f_25073_1412_1645("EmptyArrayRule", s_localizableTitle, s_localizableMessage, SystemCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25073, 539, 4448);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25073, 539, 4448);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25073, 539, 4448);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25073_1412_1645(string
        id, Microsoft.CodeAnalysis.LocalizableString
        title, Microsoft.CodeAnalysis.LocalizableString
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25073, 1412, 1645);
            return return_v;
        }

    }
}
