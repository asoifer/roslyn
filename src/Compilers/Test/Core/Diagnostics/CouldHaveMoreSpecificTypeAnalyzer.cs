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
    public class SymbolCouldHaveMoreSpecificTypeAnalyzer : DiagnosticAnalyzer
    {
        private const string
        SystemCategory = "System"
        ;

        public static readonly DiagnosticDescriptor LocalCouldHaveMoreSpecificTypeDescriptor;

        public static readonly DiagnosticDescriptor FieldCouldHaveMoreSpecificTypeDescriptor;

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25070, 1764, 1885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 1770, 1883);

                    return f_25070_1777_1882(LocalCouldHaveMoreSpecificTypeDescriptor, FieldCouldHaveMoreSpecificTypeDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25070, 1764, 1885);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25070_1777_1882(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item1, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 1777, 1882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 1659, 1896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 1659, 1896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25070, 1908, 9760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 1996, 9749);

                f_25070_1996_9748(context, (compilationContext) =>
                    {
                        Dictionary<IFieldSymbol, HashSet<INamedTypeSymbol>> fieldsSourceTypes = new Dictionary<IFieldSymbol, HashSet<INamedTypeSymbol>>();

                        compilationContext.RegisterOperationBlockStartAction(
                            (operationBlockContext) =>
                            {
                                if (operationBlockContext.OwningSymbol is IMethodSymbol containingMethod)
                                {
                                    Dictionary<ILocalSymbol, HashSet<INamedTypeSymbol>> localsSourceTypes = new Dictionary<ILocalSymbol, HashSet<INamedTypeSymbol>>();

                                // Track explicit assignments.
                                operationBlockContext.RegisterOperationAction(
                                       (operationContext) =>
                                       {
                                           if (operationContext.Operation is IAssignmentOperation assignment)
                                           {
                                               AssignTo(assignment.Target, localsSourceTypes, fieldsSourceTypes, assignment.Value);
                                           }
                                           else if (operationContext.Operation is IIncrementOrDecrementOperation increment)
                                           {
                                               SyntaxNode syntax = increment.Syntax;
                                               ITypeSymbol type = increment.Type;
                                               var constantValue = ConstantValue.Create(1);
                                               bool isImplicit = increment.IsImplicit;
                                               var value = new LiteralOperation(increment.SemanticModel, syntax, type, constantValue, isImplicit);

                                               AssignTo(increment.Target, localsSourceTypes, fieldsSourceTypes, value);
                                           }
                                           else
                                           {
                                               throw TestExceptionUtilities.UnexpectedValue(operationContext.Operation);
                                           }
                                       },
                                       OperationKind.SimpleAssignment,
                                       OperationKind.CompoundAssignment,
                                       OperationKind.Increment);

                                // Track arguments that match out or ref parameters.
                                operationBlockContext.RegisterOperationAction(
                                        (operationContext) =>
                                        {
                                            IInvocationOperation invocation = (IInvocationOperation)operationContext.Operation;
                                            foreach (IArgumentOperation argument in invocation.Arguments)
                                            {
                                                if (argument.Parameter.RefKind == RefKind.Out || argument.Parameter.RefKind == RefKind.Ref)
                                                {
                                                    AssignTo(argument.Value, localsSourceTypes, fieldsSourceTypes, argument.Parameter.Type);
                                                }
                                            }
                                        },
                                        OperationKind.Invocation);

                                // Track local variable initializations.
                                operationBlockContext.RegisterOperationAction(
                                        (operationContext) =>
                                        {
                                            IVariableInitializerOperation initializer = (IVariableInitializerOperation)operationContext.Operation;
                                        // If the parent is a single variable declaration, just process that one variable. If it's a multi variable
                                        // declaration, process all variables being assigned
                                        if (initializer.Parent is IVariableDeclaratorOperation singleVariableDeclaration)
                                            {
                                                ILocalSymbol local = singleVariableDeclaration.Symbol;
                                                AssignTo(local, local.Type, localsSourceTypes, initializer.Value);
                                            }
                                            else if (initializer.Parent is IVariableDeclarationOperation multiVariableDeclaration)
                                            {
                                                foreach (ILocalSymbol local in multiVariableDeclaration.GetDeclaredVariables())
                                                {
                                                    AssignTo(local, local.Type, localsSourceTypes, initializer.Value);
                                                }
                                            }
                                        },
                                        OperationKind.VariableInitializer);

                                // Report locals that could have more specific types.
                                operationBlockContext.RegisterOperationBlockEndAction(
                                        (operationBlockEndContext) =>
                                        {
                                            foreach (ILocalSymbol local in localsSourceTypes.Keys)
                                            {
                                                if (HasMoreSpecificSourceType(local, local.Type, localsSourceTypes, out var mostSpecificSourceType))
                                                {
                                                    Report(operationBlockEndContext, local, mostSpecificSourceType, LocalCouldHaveMoreSpecificTypeDescriptor);
                                                }
                                            }
                                        });
                                }
                            });

                    // Track field initializations.
                    compilationContext.RegisterOperationAction(
                            (operationContext) =>
                            {
                                IFieldInitializerOperation initializer = (IFieldInitializerOperation)operationContext.Operation;
                                foreach (IFieldSymbol initializedField in initializer.InitializedFields)
                                {
                                    AssignTo(initializedField, initializedField.Type, fieldsSourceTypes, initializer.Value);
                                }
                            },
                            OperationKind.FieldInitializer);

                    // Report fields that could have more specific types.
                    compilationContext.RegisterCompilationEndAction(
                            (compilationEndContext) =>
                            {
                                foreach (IFieldSymbol field in fieldsSourceTypes.Keys)
                                {
                                    if (HasMoreSpecificSourceType(field, field.Type, fieldsSourceTypes, out var mostSpecificSourceType))
                                    {
                                        Report(compilationEndContext, field, mostSpecificSourceType, FieldCouldHaveMoreSpecificTypeDescriptor);
                                    }
                                }
                            });
                    });
                DynAbs.Tracing.TraceSender.TraceExitMethod(25070, 1908, 9760);

                int
                f_25070_1996_9748(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 1996, 9748);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 1908, 9760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 1908, 9760);
            }
        }

        private static bool HasMoreSpecificSourceType<SymbolType>(SymbolType symbol, ITypeSymbol symbolType, Dictionary<SymbolType, HashSet<INamedTypeSymbol>> symbolsSourceTypes, out INamedTypeSymbol commonSourceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 9772, 10421);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol> sourceTypes = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10006, 10343) || true) && (f_25070_10010_10069(symbolsSourceTypes, symbol, out sourceTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10006, 10343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10103, 10146);

                    commonSourceType = f_25070_10122_10145(sourceTypes);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10164, 10328) || true) && (commonSourceType != null && (DynAbs.Tracing.TraceSender.Expression_True(25070, 10168, 10255) && f_25070_10196_10255(commonSourceType, symbolType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10164, 10328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10297, 10309);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10164, 10328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10006, 10343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10359, 10383);

                commonSourceType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10397, 10410);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 9772, 10421);

                bool
                f_25070_10010_10069(System.Collections.Generic.Dictionary<SymbolType, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                this_param, SymbolType
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10010, 10069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_25070_10122_10145(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                types)
                {
                    var return_v = CommonType((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10122, 10145);
                    return return_v;
                }


                bool
                f_25070_10196_10255(Microsoft.CodeAnalysis.INamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.ITypeSymbol
                baseType)
                {
                    var return_v = DerivesFrom(derivedType, (Microsoft.CodeAnalysis.INamedTypeSymbol)baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10196, 10255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 9772, 10421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 9772, 10421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static INamedTypeSymbol CommonType(IEnumerable<INamedTypeSymbol> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 10433, 11172);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10537, 11133);
                    foreach (INamedTypeSymbol type in f_25070_10571_10576_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10537, 11133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10610, 10630);

                        bool
                        success = true
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10648, 11014);
                            foreach (INamedTypeSymbol testType in f_25070_10686_10691_I(types))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10648, 11014);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10733, 10995) || true) && (type != testType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10733, 10995);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10803, 10972) || true) && (!f_25070_10808_10835(testType, type))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 10803, 10972);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 10893, 10909);

                                        success = false;
                                        DynAbs.Tracing.TraceSender.TraceBreak(25070, 10939, 10945);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10803, 10972);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10733, 10995);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10648, 11014);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25070, 1, 367);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25070, 1, 367);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11034, 11118) || true) && (success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11034, 11118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11087, 11099);

                            return type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11034, 11118);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 10537, 11133);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25070, 1, 597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25070, 1, 597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11149, 11161);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 10433, 11172);

                bool
                f_25070_10808_10835(Microsoft.CodeAnalysis.INamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.INamedTypeSymbol
                baseType)
                {
                    var return_v = DerivesFrom(derivedType, baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10808, 10835);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_25070_10686_10691_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10686, 10691);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_25070_10571_10576_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 10571, 10576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 10433, 11172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 10433, 11172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DerivesFrom(INamedTypeSymbol derivedType, INamedTypeSymbol baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 11184, 12280);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11297, 12240) || true) && (f_25070_11301_11321(derivedType) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(25070, 11301, 11385) || f_25070_11343_11363(derivedType) == TypeKind.Structure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11297, 12240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11419, 11475);

                    INamedTypeSymbol
                    derivedBaseType = f_25070_11454_11474(derivedType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11493, 11604);

                    return derivedBaseType != null && (DynAbs.Tracing.TraceSender.Expression_True(25070, 11500, 11603) && (f_25070_11528_11560(derivedBaseType, baseType) || (DynAbs.Tracing.TraceSender.Expression_False(25070, 11528, 11602) || f_25070_11564_11602(derivedBaseType, baseType))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11297, 12240);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11297, 12240);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11640, 12240) || true) && (f_25070_11644_11664(derivedType) == TypeKind.Interface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11640, 12240);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11720, 11838) || true) && (derivedType.Interfaces.Contains(baseType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11720, 11838);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11807, 11819);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11720, 11838);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11858, 12109);
                            foreach (INamedTypeSymbol baseInterface in f_25070_11901_11923_I(f_25070_11901_11923(derivedType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11858, 12109);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 11965, 12090) || true) && (f_25070_11969_12005(baseInterface, baseType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 11965, 12090);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12055, 12067);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11965, 12090);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11858, 12109);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25070, 1, 252);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25070, 1, 252);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12129, 12225);

                        return f_25070_12136_12153(baseType) == TypeKind.Class && (DynAbs.Tracing.TraceSender.Expression_True(25070, 12136, 12224) && f_25070_12175_12195(baseType) == SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11640, 12240);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 11297, 12240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12256, 12269);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 11184, 12280);

                Microsoft.CodeAnalysis.TypeKind
                f_25070_11301_11321(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 11301, 11321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_25070_11343_11363(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 11343, 11363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_25070_11454_11474(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 11454, 11474);
                    return return_v;
                }


                bool
                f_25070_11528_11560(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 11528, 11560);
                    return return_v;
                }


                bool
                f_25070_11564_11602(Microsoft.CodeAnalysis.INamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.INamedTypeSymbol
                baseType)
                {
                    var return_v = DerivesFrom(derivedType, baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 11564, 11602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_25070_11644_11664(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 11644, 11664);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_25070_11901_11923(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Interfaces;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 11901, 11923);
                    return return_v;
                }


                bool
                f_25070_11969_12005(Microsoft.CodeAnalysis.INamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.INamedTypeSymbol
                baseType)
                {
                    var return_v = DerivesFrom(derivedType, baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 11969, 12005);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_25070_11901_11923_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 11901, 11923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_25070_12136_12153(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 12136, 12153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25070_12175_12195(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 12175, 12195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 11184, 12280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 11184, 12280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AssignTo(IOperation target, Dictionary<ILocalSymbol, HashSet<INamedTypeSymbol>> localsSourceTypes, Dictionary<IFieldSymbol, HashSet<INamedTypeSymbol>> fieldsSourceTypes, IOperation sourceValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 12292, 12623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12530, 12612);

                f_25070_12530_12611(target, localsSourceTypes, fieldsSourceTypes, f_25070_12585_12610(sourceValue));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 12292, 12623);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_25070_12585_12610(Microsoft.CodeAnalysis.IOperation
                value)
                {
                    var return_v = OriginalType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 12585, 12610);
                    return return_v;
                }


                int
                f_25070_12530_12611(Microsoft.CodeAnalysis.IOperation
                target, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILocalSymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                localsSourceTypes, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IFieldSymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                fieldsSourceTypes, Microsoft.CodeAnalysis.ITypeSymbol
                sourceType)
                {
                    AssignTo(target, localsSourceTypes, fieldsSourceTypes, sourceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 12530, 12611);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 12292, 12623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 12292, 12623);
            }
        }

        private static void AssignTo(IOperation target, Dictionary<ILocalSymbol, HashSet<INamedTypeSymbol>> localsSourceTypes, Dictionary<IFieldSymbol, HashSet<INamedTypeSymbol>> fieldsSourceTypes, ITypeSymbol sourceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 12635, 13460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12873, 12912);

                OperationKind
                targetKind = f_25070_12900_12911(target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 12926, 13449) || true) && (targetKind == OperationKind.LocalReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 12926, 13449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13006, 13074);

                    ILocalSymbol
                    targetLocal = f_25070_13033_13073(((ILocalReferenceOperation)target))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13092, 13163);

                    f_25070_13092_13162(targetLocal, f_25070_13114_13130(targetLocal), localsSourceTypes, sourceType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 12926, 13449);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 12926, 13449);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13197, 13449) || true) && (targetKind == OperationKind.FieldReference)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 13197, 13449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13277, 13345);

                        IFieldSymbol
                        targetField = f_25070_13304_13344(((IFieldReferenceOperation)target))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13363, 13434);

                        f_25070_13363_13433(targetField, f_25070_13385_13401(targetField), fieldsSourceTypes, sourceType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 13197, 13449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 12926, 13449);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 12635, 13460);

                Microsoft.CodeAnalysis.OperationKind
                f_25070_12900_12911(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 12900, 12911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25070_13033_13073(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 13033, 13073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25070_13114_13130(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 13114, 13130);
                    return return_v;
                }


                int
                f_25070_13092_13162(Microsoft.CodeAnalysis.ILocalSymbol
                target, Microsoft.CodeAnalysis.ITypeSymbol
                targetType, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILocalSymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                sourceTypes, Microsoft.CodeAnalysis.ITypeSymbol
                sourceType)
                {
                    AssignTo(target, targetType, sourceTypes, sourceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 13092, 13162);
                    return 0;
                }


                Microsoft.CodeAnalysis.IFieldSymbol
                f_25070_13304_13344(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 13304, 13344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25070_13385_13401(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 13385, 13401);
                    return return_v;
                }


                int
                f_25070_13363_13433(Microsoft.CodeAnalysis.IFieldSymbol
                target, Microsoft.CodeAnalysis.ITypeSymbol
                targetType, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IFieldSymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                sourceTypes, Microsoft.CodeAnalysis.ITypeSymbol
                sourceType)
                {
                    AssignTo(target, targetType, sourceTypes, sourceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 13363, 13433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 12635, 13460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 12635, 13460);
            }
        }

        private static void AssignTo<SymbolType>(SymbolType target, ITypeSymbol targetType, Dictionary<SymbolType, HashSet<INamedTypeSymbol>> sourceTypes, IOperation sourceValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 13472, 13747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13667, 13736);

                f_25070_13667_13735(target, targetType, sourceTypes, f_25070_13709_13734(sourceValue));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 13472, 13747);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_25070_13709_13734(Microsoft.CodeAnalysis.IOperation
                value)
                {
                    var return_v = OriginalType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 13709, 13734);
                    return return_v;
                }


                int
                f_25070_13667_13735(SymbolType
                target, Microsoft.CodeAnalysis.ITypeSymbol
                targetType, System.Collections.Generic.Dictionary<SymbolType, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                sourceTypes, Microsoft.CodeAnalysis.ITypeSymbol
                sourceType)
                {
                    AssignTo(target, targetType, sourceTypes, sourceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 13667, 13735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 13472, 13747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 13472, 13747);
            }
        }

        private static void AssignTo<SymbolType>(SymbolType target, ITypeSymbol targetType, Dictionary<SymbolType, HashSet<INamedTypeSymbol>> sourceTypes, ITypeSymbol sourceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 13759, 14989);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol> symbolSourceTypes = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 13954, 14978) || true) && (sourceType != null && (DynAbs.Tracing.TraceSender.Expression_True(25070, 13958, 13998) && targetType != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 13954, 14978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14032, 14078);

                    TypeKind
                    targetTypeKind = f_25070_14058_14077(targetType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14096, 14142);

                    TypeKind
                    sourceTypeKind = f_25070_14122_14141(sourceType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14260, 14963) || true) && ((targetTypeKind == sourceTypeKind && (DynAbs.Tracing.TraceSender.Expression_True(25070, 14265, 14375) && (targetTypeKind == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(25070, 14302, 14374) || targetTypeKind == TypeKind.Interface)))) || (DynAbs.Tracing.TraceSender.Expression_False(25070, 14264, 14572) || (targetTypeKind == TypeKind.Class && (DynAbs.Tracing.TraceSender.Expression_True(25070, 14402, 14516) && (sourceTypeKind == TypeKind.Structure || (DynAbs.Tracing.TraceSender.Expression_False(25070, 14439, 14515) || sourceTypeKind == TypeKind.Interface))) && (DynAbs.Tracing.TraceSender.Expression_True(25070, 14402, 14571) && f_25070_14520_14542(targetType) == SpecialType.System_Object))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 14260, 14963);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14614, 14868) || true) && (!f_25070_14619_14677(sourceTypes, target, out symbolSourceTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 14614, 14868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14727, 14779);

                            symbolSourceTypes = f_25070_14747_14778();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14805, 14845);

                            sourceTypes[target] = symbolSourceTypes;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 14614, 14868);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 14892, 14944);

                        f_25070_14892_14943(
                                            symbolSourceTypes, sourceType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 14260, 14963);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 13954, 14978);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 13759, 14989);

                Microsoft.CodeAnalysis.TypeKind
                f_25070_14058_14077(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 14058, 14077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_25070_14122_14141(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 14122, 14141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_25070_14520_14542(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 14520, 14542);
                    return return_v;
                }


                bool
                f_25070_14619_14677(System.Collections.Generic.Dictionary<SymbolType, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>>
                this_param, SymbolType
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 14619, 14677);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_25070_14747_14778()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 14747, 14778);
                    return return_v;
                }


                bool
                f_25070_14892_14943(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.INamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.INamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 14892, 14943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 13759, 14989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 13759, 14989);
            }
        }

        private static ITypeSymbol OriginalType(IOperation value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25070, 15001, 15416);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15083, 15371) || true) && (f_25070_15087_15097(value) == OperationKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 15083, 15371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15159, 15221);

                    IConversionOperation
                    conversion = (IConversionOperation)value
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15239, 15356) || true) && (f_25070_15243_15264(conversion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25070, 15239, 15356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15306, 15337);

                        return f_25070_15313_15336(f_25070_15313_15331(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 15239, 15356);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25070, 15083, 15371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15387, 15405);

                return f_25070_15394_15404(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25070, 15001, 15416);

                Microsoft.CodeAnalysis.OperationKind
                f_25070_15087_15097(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 15087, 15097);
                    return return_v;
                }


                bool
                f_25070_15243_15264(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 15243, 15264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25070_15313_15331(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 15313, 15331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25070_15313_15336(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 15313, 15336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25070_15394_15404(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25070, 15394, 15404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 15001, 15416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 15001, 15416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Report(OperationBlockAnalysisContext context, ILocalSymbol local, ITypeSymbol moreSpecificType, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25070, 15428, 15720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15594, 15709);

                context.ReportDiagnostic(f_25070_15619_15707(descriptor, local.Locations.FirstOrDefault(), local, moreSpecificType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25070, 15428, 15720);

                Microsoft.CodeAnalysis.Diagnostic
                f_25070_15619_15707(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 15619, 15707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 15428, 15720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 15428, 15720);
            }
        }

        private void Report(CompilationAnalysisContext context, IFieldSymbol field, ITypeSymbol moreSpecificType, DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25070, 15732, 16021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 15895, 16010);

                context.ReportDiagnostic(f_25070_15920_16008(descriptor, field.Locations.FirstOrDefault(), field, moreSpecificType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25070, 15732, 16021);

                Microsoft.CodeAnalysis.Diagnostic
                f_25070_15920_16008(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 15920, 16008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25070, 15732, 16021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 15732, 16021);
            }
        }

        public SymbolCouldHaveMoreSpecificTypeAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25070, 594, 16028);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25070, 594, 16028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 594, 16028);
        }


        static SymbolCouldHaveMoreSpecificTypeAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25070, 594, 16028);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 705, 730);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 787, 1145);
            LocalCouldHaveMoreSpecificTypeDescriptor = f_25070_830_1145("LocalCouldHaveMoreSpecificType", "Local Could Have More Specific Type", "Local variable {0} could be declared with more specific type {1}.", SystemCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25070, 1202, 1545);
            FieldCouldHaveMoreSpecificTypeDescriptor = f_25070_1245_1545("FieldCouldHaveMoreSpecificType", "Field Could Have More Specific Type", "Field {0} could be declared with more specific type {1}.", SystemCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25070, 594, 16028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25070, 594, 16028);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25070, 594, 16028);

        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25070_830_1145(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 830, 1145);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25070_1245_1545(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25070, 1245, 1545);
            return return_v;
        }

    }
}
