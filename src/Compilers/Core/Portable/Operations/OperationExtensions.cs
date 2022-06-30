// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Operations
{
    public static partial class OperationExtensions
    {
        internal static bool HasErrors(this IOperation operation, Compilation compilation, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 690, 2288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 863, 984) || true) && (operation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 863, 984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 918, 969);

                    throw f_468_924_968(nameof(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 863, 984);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1000, 1125) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 1000, 1125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1057, 1110);

                    throw f_468_1063_1109(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 1000, 1125);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1233, 1322) || true) && (f_468_1237_1253(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 1233, 1322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1295, 1307);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 1233, 1322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1462, 1498);

                var
                model = f_468_1474_1497(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1691, 1874) || true) && (model is null || (DynAbs.Tracing.TraceSender.Expression_False(468, 1695, 1759) || f_468_1712_1728(model) != f_468_1732_1759(f_468_1732_1748(operation))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 1691, 1874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1793, 1859);

                    model = f_468_1801_1858(compilation, f_468_1830_1857(f_468_1830_1846(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 1691, 1874);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 1890, 2135) || true) && (f_468_1894_1926(model))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 1890, 2135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 2107, 2120);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 1890, 2135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 2151, 2277);

                return f_468_2158_2220(model, f_468_2179_2200(f_468_2179_2195(operation)), cancellationToken).Any(d => d.DefaultSeverity == DiagnosticSeverity.Error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 690, 2288);

                System.ArgumentNullException
                f_468_924_968(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 924, 968);
                    return return_v;
                }


                System.ArgumentNullException
                f_468_1063_1109(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 1063, 1109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_468_1237_1253(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1237, 1253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_468_1474_1497(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1474, 1497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_468_1712_1728(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1712, 1728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_468_1732_1748(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1732, 1748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_468_1732_1759(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1732, 1759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_468_1830_1846(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1830, 1846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_468_1830_1857(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1830, 1857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_468_1801_1858(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 1801, 1858);
                    return return_v;
                }


                bool
                f_468_1894_1926(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.IsSpeculativeSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 1894, 1926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_468_2179_2195(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 2179, 2195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_468_2179_2200(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 2179, 2200);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_468_2158_2220(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics((Microsoft.CodeAnalysis.Text.TextSpan?)span, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 2158, 2220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 690, 2288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 690, 2288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<IOperation> Descendants(this IOperation? operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 2553, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 2655, 2705);

                return f_468_2662_2704(operation, includeSelf: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 2553, 2716);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_468_2662_2704(Microsoft.CodeAnalysis.IOperation?
                operation, bool
                includeSelf)
                {
                    var return_v = Descendants(operation, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 2662, 2704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 2553, 2716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 2553, 2716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<IOperation> DescendantsAndSelf(this IOperation? operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 3030, 3199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3139, 3188);

                return f_468_3146_3187(operation, includeSelf: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 3030, 3199);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_468_3146_3187(Microsoft.CodeAnalysis.IOperation?
                operation, bool
                includeSelf)
                {
                    var return_v = Descendants(operation, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 3146, 3187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 3030, 3199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 3030, 3199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<IOperation> Descendants(IOperation? operation, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 3211, 4353);

                var listYield = new List<IOperation>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3327, 3409) || true) && (operation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 3327, 3409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3382, 3394);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 3327, 3409);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3425, 3512) || true) && (includeSelf)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 3425, 3512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3474, 3497);

                    listYield.Add(operation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 3425, 3512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3528, 3589);

                var
                stack = f_468_3540_3588()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3603, 3670);

                stack.Push(((Operation)operation).ChildOperations.GetEnumerator());
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3686, 4313) || true) && (f_468_3693_3704(stack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 3686, 4313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3738, 3765);

                        var
                        iterator = f_468_3753_3764(stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3785, 3879) || true) && (!iterator.MoveNext())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 3785, 3879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3851, 3860);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(468, 3785, 3879);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 3899, 3930);

                        var
                        current = iterator.Current
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4013, 4034);

                        stack.Push(iterator);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4110, 4298) || true) && (current != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 4110, 4298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4171, 4192);

                            listYield.Add(current);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4214, 4279);

                            stack.Push(((Operation)current).ChildOperations.GetEnumerator());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(468, 4110, 4298);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(468, 3686, 4313);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(468, 3686, 4313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(468, 3686, 4313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4329, 4342);

                f_468_4329_4341(
                            stack);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 3211, 4353);

                return listYield;

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operation.Enumerator>
                f_468_3540_3588()
                {
                    var return_v = ArrayBuilder<Operation.Enumerator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 3540, 3588);
                    return return_v;
                }


                bool
                f_468_3693_3704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operation.Enumerator>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 3693, 3704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operation.Enumerator
                f_468_3753_3764(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operation.Enumerator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.Operation.Enumerator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 3753, 3764);
                    return return_v;
                }


                int
                f_468_4329_4341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operation.Enumerator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 4329, 4341);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 3211, 4353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 3211, 4353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ILocalSymbol> GetDeclaredVariables(this IVariableDeclarationGroupOperation declarationGroup)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 4592, 5198);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4738, 4873) || true) && (declarationGroup == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 4738, 4873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4800, 4858);

                    throw f_468_4806_4857(nameof(declarationGroup));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 4738, 4873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4889, 4949);

                var
                arrayBuilder = f_468_4908_4948()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 4963, 5130);
                    foreach (IVariableDeclarationOperation group in f_468_5011_5040_I(f_468_5011_5040(declarationGroup)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 4963, 5130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5074, 5115);

                        f_468_5074_5114(group, arrayBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(468, 4963, 5130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(468, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(468, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5146, 5187);

                return f_468_5153_5186(arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 4592, 5198);

                System.ArgumentNullException
                f_468_4806_4857(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 4806, 4857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                f_468_4908_4948()
                {
                    var return_v = ArrayBuilder<ILocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 4908, 4948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>
                f_468_5011_5040(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 5011, 5040);
                    return return_v;
                }


                int
                f_468_5074_5114(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                declaration, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                arrayBuilder)
                {
                    declaration.GetDeclaredVariables(arrayBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5074, 5114);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>
                f_468_5011_5040_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5011, 5040);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_468_5153_5186(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5153, 5186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 4592, 5198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 4592, 5198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ILocalSymbol> GetDeclaredVariables(this IVariableDeclarationOperation declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 5421, 5885);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5557, 5682) || true) && (declaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 5557, 5682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5614, 5667);

                    throw f_468_5620_5666(nameof(declaration));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 5557, 5682);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5698, 5758);

                var
                arrayBuilder = f_468_5717_5757()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5772, 5819);

                f_468_5772_5818(declaration, arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 5833, 5874);

                return f_468_5840_5873(arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 5421, 5885);

                System.ArgumentNullException
                f_468_5620_5666(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5620, 5666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                f_468_5717_5757()
                {
                    var return_v = ArrayBuilder<ILocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5717, 5757);
                    return return_v;
                }


                int
                f_468_5772_5818(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                declaration, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                arrayBuilder)
                {
                    declaration.GetDeclaredVariables(arrayBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5772, 5818);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_468_5840_5873(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 5840, 5873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 5421, 5885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 5421, 5885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetDeclaredVariables(this IVariableDeclarationOperation declaration, ArrayBuilder<ILocalSymbol> arrayBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 5897, 6185);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 6051, 6174);
                    foreach (var decl in f_468_6072_6095_I(f_468_6072_6095(declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 6051, 6174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 6129, 6159);

                        f_468_6129_6158(arrayBuilder, f_468_6146_6157(decl));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(468, 6051, 6174);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(468, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(468, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 5897, 6185);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
                f_468_6072_6095(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Declarators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 6072, 6095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_468_6146_6157(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 6146, 6157);
                    return return_v;
                }


                int
                f_468_6129_6158(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ILocalSymbol>
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 6129, 6158);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
                f_468_6072_6095_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 6072, 6095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 5897, 6185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 5897, 6185);
            }
        }

        public static IVariableInitializerOperation? GetVariableInitializer(this IVariableDeclaratorOperation declarationOperation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 6561, 7178);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 6709, 6852) || true) && (declarationOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 6709, 6852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 6775, 6837);

                    throw f_468_6781_6836(nameof(declarationOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 6709, 6852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 7028, 7167);

                // LAFHIS
                var x = f_468_7035_7067(declarationOperation);

                if (x == null)
                {
                    DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?>(468, 7035, 7166);
                    DynAbs.Tracing.TraceSender.Conditional_F1(468, 7072, 7139);
                    var y = f_468_7073_7100(declarationOperation);
                    x = (((((y is IVariableDeclarationOperation) &&
                    DynAbs.Tracing.TraceSender.Conditional_F2(468, 7142, 7158)) ||
                    DynAbs.Tracing.TraceSender.Conditional_F3(468, 7161, 7165))) ? f_468_7142_7158((IVariableDeclarationOperation)y) : null);
                }

                

                return x;

                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 6561, 7178);

                System.ArgumentNullException
                f_468_6781_6836(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 6781, 6836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                f_468_7035_7067(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 7035, 7067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_468_7073_7100(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 7073, 7100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                f_468_7142_7158(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 7142, 7158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 6561, 7178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 6561, 7178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? GetArgumentName(this IDynamicInvocationOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 7531, 7896);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 7655, 7790) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 7655, 7790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 7717, 7775);

                    throw f_468_7723_7774(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 7655, 7790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 7806, 7885);

                return f_468_7813_7884(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 7531, 7896);

                System.ArgumentNullException
                f_468_7723_7774(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 7723, 7774);
                    return return_v;
                }


                string?
                f_468_7813_7884(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 7813, 7884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 7531, 7896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 7531, 7896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? GetArgumentName(this IDynamicIndexerAccessOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 8249, 8617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 8376, 8511) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 8376, 8511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 8438, 8496);

                    throw f_468_8444_8495(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 8376, 8511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 8527, 8606);

                return f_468_8534_8605(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 8249, 8617);

                System.ArgumentNullException
                f_468_8444_8495(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 8444, 8495);
                    return return_v;
                }


                string?
                f_468_8534_8605(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 8534, 8605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 8249, 8617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 8249, 8617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? GetArgumentName(this IDynamicObjectCreationOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 8970, 9339);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9098, 9233) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 9098, 9233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9160, 9218);

                    throw f_468_9166_9217(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 9098, 9233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9249, 9328);

                return f_468_9256_9327(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 8970, 9339);

                System.ArgumentNullException
                f_468_9166_9217(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 9166, 9217);
                    return return_v;
                }


                string?
                f_468_9256_9327(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 9256, 9327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 8970, 9339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 8970, 9339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? GetArgumentName(this HasDynamicArgumentsExpression dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 9692, 10291);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9820, 9954) || true) && (dynamicOperation.Arguments.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 9820, 9954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9901, 9939);

                    throw f_468_9907_9938();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 9820, 9954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 9970, 10131) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(468, 9974, 10029) || index >= dynamicOperation.Arguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 9970, 10131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 10063, 10116);

                    throw f_468_10069_10115(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 9970, 10131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 10147, 10198);

                var
                argumentNames = f_468_10167_10197(dynamicOperation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 10212, 10280);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(468, 10219, 10249) || ((argumentNames.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(468, 10252, 10256)) || DynAbs.Tracing.TraceSender.Conditional_F3(468, 10259, 10279))) ? null : argumentNames[index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 9692, 10291);

                System.InvalidOperationException
                f_468_9907_9938()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 9907, 9938);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_468_10069_10115(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 10069, 10115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_468_10167_10197(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 10167, 10197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 9692, 10291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 9692, 10291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RefKind? GetArgumentRefKind(this IDynamicInvocationOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 10835, 11207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 10963, 11098) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 10963, 11098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 11025, 11083);

                    throw f_468_11031_11082(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 10963, 11098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 11114, 11196);

                return f_468_11121_11195(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 10835, 11207);

                System.ArgumentNullException
                f_468_11031_11082(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 11031, 11082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind?
                f_468_11121_11195(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentRefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 11121, 11195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 10835, 11207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 10835, 11207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RefKind? GetArgumentRefKind(this IDynamicIndexerAccessOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 11751, 12126);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 11882, 12017) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 11882, 12017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 11944, 12002);

                    throw f_468_11950_12001(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 11882, 12017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 12033, 12115);

                return f_468_12040_12114(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 11751, 12126);

                System.ArgumentNullException
                f_468_11950_12001(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 11950, 12001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind?
                f_468_12040_12114(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentRefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 12040, 12114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 11751, 12126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 11751, 12126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RefKind? GetArgumentRefKind(this IDynamicObjectCreationOperation dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 12670, 13046);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 12802, 12937) || true) && (dynamicOperation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 12802, 12937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 12864, 12922);

                    throw f_468_12870_12921(nameof(dynamicOperation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 12802, 12937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 12953, 13035);

                return f_468_12960_13034(dynamicOperation, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 12670, 13046);

                System.ArgumentNullException
                f_468_12870_12921(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 12870, 12921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind?
                f_468_12960_13034(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                dynamicOperation, int
                index)
                {
                    var return_v = ((HasDynamicArgumentsExpression)dynamicOperation).GetArgumentRefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 12960, 13034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 12670, 13046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 12670, 13046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RefKind? GetArgumentRefKind(this HasDynamicArgumentsExpression dynamicOperation, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 13058, 14035);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13190, 13324) || true) && (dynamicOperation.Arguments.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 13190, 13324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13271, 13309);

                    throw f_468_13277_13308();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 13190, 13324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13340, 13501) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(468, 13344, 13399) || index >= dynamicOperation.Arguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 13340, 13501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13433, 13486);

                    throw f_468_13439_13485(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 13340, 13501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13517, 13574);

                var
                argumentRefKinds = f_468_13540_13573(dynamicOperation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13588, 13739) || true) && (argumentRefKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 13588, 13739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13712, 13724);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 13588, 13739);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13755, 13977) || true) && (argumentRefKinds.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 13755, 13977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13942, 13962);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 13755, 13977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 13993, 14024);

                return argumentRefKinds[index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 13058, 14035);

                System.InvalidOperationException
                f_468_13277_13308()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 13277, 13308);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_468_13439_13485(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 13439, 13485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_468_13540_13573(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 13540, 13573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 13058, 14035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 13058, 14035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IOperation GetRootOperation(this IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 14300, 14596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 14395, 14427);

                f_468_14395_14426(operation != null);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 14443, 14552) || true) && (f_468_14450_14466(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 14443, 14552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 14508, 14537);

                        operation = f_468_14520_14536(operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(468, 14443, 14552);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(468, 14443, 14552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(468, 14443, 14552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 14568, 14585);

                return operation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 14300, 14596);

                int
                f_468_14395_14426(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 14395, 14426);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_468_14450_14466(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 14450, 14466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_468_14520_14536(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 14520, 14536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 14300, 14596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 14300, 14596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOperation? GetCorrespondingOperation(this IBranchOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 15256, 16670);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15365, 15486) || true) && (operation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 15365, 15486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15420, 15471);

                    throw f_468_15426_15470(nameof(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 15365, 15486);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15502, 15684) || true) && (f_468_15506_15529(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 15502, 15684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15571, 15669);

                    throw f_468_15577_15668(f_468_15607_15667());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 15502, 15684);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15700, 15852) || true) && (f_468_15704_15724(operation) != BranchKind.Break && (DynAbs.Tracing.TraceSender.Expression_True(468, 15704, 15791) && f_468_15748_15768(operation) != BranchKind.Continue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 15700, 15852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15825, 15837);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 15700, 15852);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15868, 15957) || true) && (f_468_15872_15888(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 15868, 15957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15930, 15942);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(468, 15868, 15957);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15989, 16008);

                    for (IOperation
        current = operation
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 15973, 16631) || true) && (f_468_16010_16024(current) != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16034, 16058)
        , current = f_468_16044_16058(current), DynAbs.Tracing.TraceSender.TraceExitCondition(468, 15973, 16631))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 15973, 16631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16092, 16616);

                        switch (current)
                        {

                            case ILoopOperation correspondingLoop when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16187, 16368) || true) && (f_468_16192_16244(f_468_16192_16208(operation), f_468_16216_16243(correspondingLoop)) || (DynAbs.Tracing.TraceSender.Expression_False(468, 16192, 16368) || f_468_16312_16368(f_468_16312_16328(operation), f_468_16336_16367(correspondingLoop)))) && (DynAbs.Tracing.TraceSender.Expression_True(468, 16187, 16368) || true)
                        :
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 16092, 16616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16395, 16420);

                                return correspondingLoop;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(468, 16092, 16616);

                            case ISwitchOperation correspondingSwitch when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16484, 16543) || true) && (f_468_16489_16543(f_468_16489_16505(operation), f_468_16513_16542(correspondingSwitch))) && (DynAbs.Tracing.TraceSender.Expression_True(468, 16484, 16543) || true)
                        :
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(468, 16092, 16616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16570, 16597);

                                return correspondingSwitch;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(468, 16092, 16616);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(468, 1, 659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(468, 1, 659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16647, 16659);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 15256, 16670);

                System.ArgumentNullException
                f_468_15426_15470(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 15426, 15470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_468_15506_15529(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 15506, 15529);
                    return return_v;
                }


                string
                f_468_15607_15667()
                {
                    var return_v = CodeAnalysisResources.OperationMustNotBeControlFlowGraphPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 15607, 15667);
                    return return_v;
                }


                System.InvalidOperationException
                f_468_15577_15668(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 15577, 15668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BranchKind
                f_468_15704_15724(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.BranchKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 15704, 15724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BranchKind
                f_468_15748_15768(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.BranchKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 15748, 15768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_15872_15888(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 15872, 15888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_468_16010_16024(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16010, 16024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_468_16044_16058(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16044, 16058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16192_16208(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16192, 16208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16216_16243(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.ExitLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16216, 16243);
                    return return_v;
                }


                bool
                f_468_16192_16244(Microsoft.CodeAnalysis.ILabelSymbol
                this_param, Microsoft.CodeAnalysis.ILabelSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 16192, 16244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16312_16328(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16312, 16328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16336_16367(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16336, 16367);
                    return return_v;
                }


                bool
                f_468_16312_16368(Microsoft.CodeAnalysis.ILabelSymbol
                this_param, Microsoft.CodeAnalysis.ILabelSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 16312, 16368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16489_16505(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16489, 16505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_468_16513_16542(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.ExitLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16513, 16542);
                    return return_v;
                }


                bool
                f_468_16489_16543(Microsoft.CodeAnalysis.ILabelSymbol
                this_param, Microsoft.CodeAnalysis.ILabelSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(468, 16489, 16543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 15256, 16670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 15256, 16670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConstantValue? GetConstantValue(this IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(468, 16682, 16845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(468, 16781, 16834);

                return f_468_16788_16833(((Operation)operation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(468, 16682, 16845);

                Microsoft.CodeAnalysis.ConstantValue?
                f_468_16788_16833(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OperationConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(468, 16788, 16833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(468, 16682, 16845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 16682, 16845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OperationExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(468, 466, 16852);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(468, 466, 16852);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(468, 466, 16852);
        }

    }
}
