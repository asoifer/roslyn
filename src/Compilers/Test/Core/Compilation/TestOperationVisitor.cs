// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed class TestOperationVisitor : OperationVisitor
    {
        public static readonly TestOperationVisitor Singleton;

        private TestOperationVisitor()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25010, 792, 857);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25010, 792, 857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 792, 857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 792, 857);
            }
        }

        public override void DefaultVisit(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 869, 1026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 949, 1015);

                throw f_25010_955_1014(f_25010_983_1013(f_25010_983_1002(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 869, 1026);

                System.Type
                f_25010_983_1002(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 983, 1002);
                    return return_v;
                }


                string
                f_25010_983_1013(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 983, 1013);
                    return return_v;
                }


                System.NotImplementedException
                f_25010_955_1014(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 955, 1014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 869, 1026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 869, 1026);
            }
        }

        internal override void VisitNoneOperation(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 1038, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1295, 1344);

                f_25010_1295_1343(OperationKind.None, f_25010_1328_1342(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 1038, 1355);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_1328_1342(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 1328, 1342);
                    return return_v;
                }


                int
                f_25010_1295_1343(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 1295, 1343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 1038, 1355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 1038, 1355);
            }
        }

        public override void Visit(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 1367, 2714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1440, 2667) || true) && (operation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 1440, 2667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1495, 1525);

                    var
                    syntax = f_25010_1508_1524(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1543, 1569);

                    var
                    type = f_25010_1554_1568(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1587, 1631);

                    var
                    constantValue = f_25010_1607_1630(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1651, 1674);

                    f_25010_1651_1673(syntax);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1880, 2244) || true) && (syntax is Microsoft.CodeAnalysis.Syntax.SyntaxList)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 1880, 2244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 1976, 2025);

                        f_25010_1976_2024(OperationKind.None, f_25010_2009_2023(operation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2047, 2109);

                        f_25010_2047_2108(LanguageNames.CSharp, f_25010_2082_2107(f_25010_2082_2098(operation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 1880, 2244);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 1880, 2244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2191, 2225);

                        var
                        language = f_25010_2206_2224(operation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 1880, 2244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2264, 2302);

                    var
                    isImplicit = f_25010_2281_2301(operation)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2322, 2452);
                        foreach (IOperation child in f_25010_2351_2369_I(f_25010_2351_2369(operation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 2322, 2452);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2411, 2433);

                            f_25010_2411_2432(child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 2322, 2452);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 131);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2472, 2652) || true) && (f_25010_2476_2499(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 2472, 2652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2549, 2633);

                        f_25010_2549_2632(f_25010_2561_2584(operation), f_25010_2586_2631(f_25010_2586_2609(operation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 2472, 2652);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 1440, 2667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2681, 2703);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(operation), 25010, 2681, 2702);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 1367, 2714);

                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_1508_1524(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 1508, 1524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_1554_1568(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 1554, 1568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object?>
                f_25010_1607_1630(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 1607, 1630);
                    return return_v;
                }


                int
                f_25010_1651_1673(Microsoft.CodeAnalysis.SyntaxNode
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 1651, 1673);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_2009_2023(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2009, 2023);
                    return return_v;
                }


                int
                f_25010_1976_2024(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 1976, 2024);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_2082_2098(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2082, 2098);
                    return return_v;
                }


                string
                f_25010_2082_2107(Microsoft.CodeAnalysis.IOperation?
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2082, 2107);
                    return return_v;
                }


                int
                f_25010_2047_2108(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2047, 2108);
                    return 0;
                }


                string
                f_25010_2206_2224(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2206, 2224);
                    return return_v;
                }


                bool
                f_25010_2281_2301(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2281, 2301);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_2351_2369(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2351, 2369);
                    return return_v;
                }


                int
                f_25010_2411_2432(Microsoft.CodeAnalysis.IOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2411, 2432);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_2351_2369_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2351, 2369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25010_2476_2499(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2476, 2499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25010_2561_2584(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2561, 2584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25010_2586_2609(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2586, 2609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25010_2586_2631(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.ContainingModelOrSelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2586, 2631);
                    return return_v;
                }


                int
                f_25010_2549_2632(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2549, 2632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 1367, 2714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 1367, 2714);
            }
        }

        public override void VisitBlock(IBlockOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 2726, 2987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2809, 2859);

                f_25010_2809_2858(OperationKind.Block, f_25010_2843_2857(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2873, 2903);

                f_25010_2873_2902(f_25010_2885_2901(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 2919, 2976);

                f_25010_2919_2975(f_25010_2934_2954(operation), f_25010_2956_2974(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 2726, 2987);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_2843_2857(Microsoft.CodeAnalysis.Operations.IBlockOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2843, 2857);
                    return return_v;
                }


                int
                f_25010_2809_2858(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2809, 2858);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_2885_2901(Microsoft.CodeAnalysis.Operations.IBlockOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2885, 2901);
                    return return_v;
                }


                int
                f_25010_2873_2902(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2873, 2902);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_2934_2954(Microsoft.CodeAnalysis.Operations.IBlockOperation
                this_param)
                {
                    var return_v = this_param.Operations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2934, 2954);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_2956_2974(Microsoft.CodeAnalysis.Operations.IBlockOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 2956, 2974);
                    return return_v;
                }


                int
                f_25010_2919_2975(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 2919, 2975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 2726, 2987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 2726, 2987);
            }
        }

        public override void VisitVariableDeclarationGroup(IVariableDeclarationGroupOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 2999, 3273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3120, 3189);

                f_25010_3120_3188(OperationKind.VariableDeclarationGroup, f_25010_3173_3187(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3203, 3262);

                f_25010_3203_3261(f_25010_3218_3240(operation), f_25010_3242_3260(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 2999, 3273);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_3173_3187(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3173, 3187);
                    return return_v;
                }


                int
                f_25010_3120_3188(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3120, 3188);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>
                f_25010_3218_3240(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3218, 3240);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_3242_3260(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3242, 3260);
                    return return_v;
                }


                bool
                f_25010_3203_3261(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3203, 3261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 2999, 3273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 2999, 3273);
            }
        }

        public override void VisitVariableDeclarator(IVariableDeclaratorOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 3285, 3844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3394, 3457);

                f_25010_3394_3456(OperationKind.VariableDeclarator, f_25010_3441_3455(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3471, 3504);

                f_25010_3471_3503(f_25010_3486_3502(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3518, 3580);

                IEnumerable<IOperation>
                children = f_25010_3553_3579(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3594, 3634);

                var
                initializer = f_25010_3612_3633(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3650, 3772) || true) && (initializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 3650, 3772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3707, 3757);

                    children = f_25010_3718_3756(children, new[] { initializer });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 3650, 3772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3788, 3833);

                f_25010_3788_3832(children, f_25010_3813_3831(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 3285, 3844);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_3441_3455(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3441, 3455);
                    return return_v;
                }


                int
                f_25010_3394_3456(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3394, 3456);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25010_3486_3502(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3486, 3502);
                    return return_v;
                }


                int
                f_25010_3471_3503(Microsoft.CodeAnalysis.ILocalSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3471, 3503);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_3553_3579(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.IgnoredArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3553, 3579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                f_25010_3612_3633(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3612, 3633);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_3718_3756(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3718, 3756);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_3813_3831(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 3813, 3831);
                    return return_v;
                }


                bool
                f_25010_3788_3832(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3788, 3832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 3285, 3844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 3285, 3844);
            }
        }

        public override void VisitVariableDeclaration(IVariableDeclarationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 3856, 4402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 3967, 4031);

                f_25010_3967_4030(OperationKind.VariableDeclaration, f_25010_4015_4029(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4045, 4138);

                // Lafhis
                var temp = operation.IgnoredDimensions;
                IEnumerable<IOperation>
                children = f_25010_4080_4137(ref temp, f_25010_4115_4136(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4152, 4192);

                var
                initializer = f_25010_4170_4191(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4208, 4330) || true) && (initializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 4208, 4330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4265, 4315);

                    children = f_25010_4276_4314(children, new[] { initializer });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 4208, 4330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4346, 4391);

                f_25010_4346_4390(children, f_25010_4371_4389(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 3856, 4402);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_4015_4029(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4015, 4029);
                    return return_v;
                }


                int
                f_25010_3967_4030(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 3967, 4030);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
                f_25010_4115_4136(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Declarators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4115, 4136);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4080_4137(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4080, 4137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                f_25010_4170_4191(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4170, 4191);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4276_4314(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4276, 4314);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4371_4389(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4371, 4389);
                    return return_v;
                }


                bool
                f_25010_4346_4390(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4346, 4390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 3856, 4402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 3856, 4402);
            }
        }

        public override void VisitSwitch(ISwitchOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 4414, 4755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4499, 4550);

                f_25010_4499_4549(OperationKind.Switch, f_25010_4534_4548(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4564, 4594);

                f_25010_4564_4593(f_25010_4576_4592(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4608, 4644);

                f_25010_4608_4643(f_25010_4623_4642(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4658, 4744);

                f_25010_4658_4743(f_25010_4673_4722(new[] { f_25010_4681_4696(operation) }, f_25010_4706_4721(operation)), f_25010_4724_4742(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 4414, 4755);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_4534_4548(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4534, 4548);
                    return return_v;
                }


                int
                f_25010_4499_4549(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4499, 4549);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_4576_4592(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4576, 4592);
                    return return_v;
                }


                int
                f_25010_4564_4593(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4564, 4593);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_4623_4642(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.ExitLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4623, 4642);
                    return return_v;
                }


                int
                f_25010_4608_4643(Microsoft.CodeAnalysis.ILabelSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4608, 4643);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_4681_4696(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4681, 4696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
                f_25010_4706_4721(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4706, 4721);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4673_4722(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4673, 4722);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4724_4742(Microsoft.CodeAnalysis.Operations.ISwitchOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4724, 4742);
                    return return_v;
                }


                bool
                f_25010_4658_4743(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4658, 4743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 4414, 4755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 4414, 4755);
            }
        }

        public override void VisitSwitchCase(ISwitchCaseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 4767, 5159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4860, 4915);

                f_25010_4860_4914(OperationKind.SwitchCase, f_25010_4899_4913(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4929, 4959);

                f_25010_4929_4958(f_25010_4941_4957(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 4973, 5050);

                // Lafhis
                var temp = operation.Clauses;
                f_25010_4973_5049(f_25010_4988_5028(ref temp, f_25010_5013_5027(operation)), f_25010_5030_5048(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5066, 5148);

                f_25010_5066_5147(f_25010_5080_5122(((SwitchCaseOperation)operation)), hasNonNullParent: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 4767, 5159);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_4899_4913(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4899, 4913);
                    return return_v;
                }


                int
                f_25010_4860_4914(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4860, 4914);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_4941_4957(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 4941, 4957);
                    return return_v;
                }


                int
                f_25010_4929_4958(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4929, 4958);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_5013_5027(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5013, 5027);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_4988_5028(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4988, 5028);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_5030_5048(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5030, 5048);
                    return return_v;
                }


                bool
                f_25010_4973_5049(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 4973, 5049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_5080_5122(Microsoft.CodeAnalysis.Operations.SwitchCaseOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5080, 5122);
                    return return_v;
                }


                int
                f_25010_5066_5147(Microsoft.CodeAnalysis.IOperation?
                root, bool
                hasNonNullParent)
                {
                    VerifySubTree(root, hasNonNullParent: hasNonNullParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5066, 5147);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 4767, 5159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 4767, 5159);
            }
        }

        internal static void VerifySubTree(IOperation root, bool hasNonNullParent = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25010, 5171, 6506);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5278, 6495) || true) && (root != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 5278, 6495);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5328, 5713) || true) && (hasNonNullParent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 5328, 5713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5473, 5501);

                        f_25010_5473_5500(f_25010_5488_5499(root));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5523, 5587);

                        f_25010_5523_5586(root, f_25010_5541_5585(((SwitchCaseOperation)f_25010_5563_5574(root))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 5328, 5713);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 5328, 5713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5669, 5694);

                        f_25010_5669_5693(f_25010_5681_5692(root));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 5328, 5713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5733, 5796);

                    var
                    explicitNodeMap = f_25010_5755_5795()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5816, 6480);
                        foreach (IOperation descendant in f_25010_5850_5875_I(f_25010_5850_5875(root)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 5816, 6480);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 5917, 6409) || true) && (f_25010_5921_5943_M(!descendant.IsImplicit))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 5917, 6409);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6053, 6104);

                                    f_25010_6053_6103(explicitNodeMap, f_25010_6073_6090(descendant), descendant);
                                }
                                catch (ArgumentException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25010, 6157, 6386);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6239, 6359);

                                    f_25010_6239_6358(true, $"Duplicate explicit node for syntax ({f_25010_6297_6322(f_25010_6297_6314(descendant))}): {f_25010_6327_6355(f_25010_6327_6344(descendant))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25010, 6157, 6386);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 5917, 6409);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6433, 6461);

                            f_25010_6433_6460(
                                                Singleton, descendant);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 5816, 6480);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 665);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 665);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 5278, 6495);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25010, 5171, 6506);

                Microsoft.CodeAnalysis.IOperation?
                f_25010_5488_5499(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5488, 5499);
                    return return_v;
                }


                int
                f_25010_5473_5500(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5473, 5500);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_5563_5574(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5563, 5574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_5541_5585(Microsoft.CodeAnalysis.Operations.SwitchCaseOperation?
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5541, 5585);
                    return return_v;
                }


                int
                f_25010_5523_5586(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation?
                actual)
                {
                    Assert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5523, 5586);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_5681_5692(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5681, 5692);
                    return return_v;
                }


                int
                f_25010_5669_5693(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5669, 5693);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                f_25010_5755_5795()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5755, 5795);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_5850_5875(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5850, 5875);
                    return return_v;
                }


                bool
                f_25010_5921_5943_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 5921, 5943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_6073_6090(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6073, 6090);
                    return return_v;
                }


                int
                f_25010_6053_6103(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, Microsoft.CodeAnalysis.IOperation
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6053, 6103);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_6297_6314(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6297, 6314);
                    return return_v;
                }


                int
                f_25010_6297_6322(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6297, 6322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_6327_6344(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6327, 6344);
                    return return_v;
                }


                string
                f_25010_6327_6355(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6327, 6355);
                    return return_v;
                }


                int
                f_25010_6239_6358(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6239, 6358);
                    return 0;
                }


                int
                f_25010_6433_6460(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    this_param.Visit(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6433, 6460);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_5850_5875_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 5850, 5875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 5171, 6506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 5171, 6506);
            }
        }

        public override void VisitSingleValueCaseClause(ISingleValueCaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 6518, 6825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6633, 6669);

                f_25010_6633_6668(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6683, 6738);

                f_25010_6683_6737(CaseKind.SingleValue, f_25010_6718_6736(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6752, 6814);

                f_25010_6752_6813(new[] { f_25010_6775_6790(operation) }, f_25010_6794_6812(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 6518, 6825);

                int
                f_25010_6633_6668(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
                operation)
                {
                    VisitCaseClauseOperation((Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6633, 6668);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CaseKind
                f_25010_6718_6736(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.CaseKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6718, 6736);
                    return return_v;
                }


                int
                f_25010_6683_6737(Microsoft.CodeAnalysis.Operations.CaseKind
                expected, Microsoft.CodeAnalysis.Operations.CaseKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6683, 6737);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_6775_6790(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6775, 6790);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_6794_6812(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6794, 6812);
                    return return_v;
                }


                bool
                f_25010_6752_6813(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6752, 6813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 6518, 6825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 6518, 6825);
            }
        }

        private static void VisitCaseClauseOperation(ICaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25010, 6837, 7038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 6938, 6993);

                f_25010_6938_6992(OperationKind.CaseClause, f_25010_6977_6991(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7007, 7027);

                _ = f_25010_7011_7026(operation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25010, 6837, 7038);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_6977_6991(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 6977, 6991);
                    return return_v;
                }


                int
                f_25010_6938_6992(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 6938, 6992);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol?
                f_25010_7011_7026(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7011, 7026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 6837, 7038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 6837, 7038);
            }
        }

        public override void VisitRelationalCaseClause(IRelationalCaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 7050, 7404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7163, 7199);

                f_25010_7163_7198(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7213, 7267);

                f_25010_7213_7266(CaseKind.Relational, f_25010_7247_7265(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7281, 7315);

                var
                relation = f_25010_7296_7314(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7331, 7393);

                f_25010_7331_7392(new[] { f_25010_7354_7369(operation) }, f_25010_7373_7391(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 7050, 7404);

                int
                f_25010_7163_7198(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
                operation)
                {
                    VisitCaseClauseOperation((Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7163, 7198);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CaseKind
                f_25010_7247_7265(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.CaseKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7247, 7265);
                    return return_v;
                }


                int
                f_25010_7213_7266(Microsoft.CodeAnalysis.Operations.CaseKind
                expected, Microsoft.CodeAnalysis.Operations.CaseKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7213, 7266);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_7296_7314(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7296, 7314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_7354_7369(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7354, 7369);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_7373_7391(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7373, 7391);
                    return return_v;
                }


                bool
                f_25010_7331_7392(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7331, 7392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 7050, 7404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 7050, 7404);
            }
        }

        public override void VisitDefaultCaseClause(IDefaultCaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 7416, 7682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7523, 7559);

                f_25010_7523_7558(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7573, 7624);

                f_25010_7573_7623(CaseKind.Default, f_25010_7604_7622(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7638, 7671);

                f_25010_7638_7670(f_25010_7651_7669(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 7416, 7682);

                int
                f_25010_7523_7558(Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation
                operation)
                {
                    VisitCaseClauseOperation((Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7523, 7558);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CaseKind
                f_25010_7604_7622(Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.CaseKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7604, 7622);
                    return return_v;
                }


                int
                f_25010_7573_7623(Microsoft.CodeAnalysis.Operations.CaseKind
                expected, Microsoft.CodeAnalysis.Operations.CaseKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7573, 7623);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_7651_7669(Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 7651, 7669);
                    return return_v;
                }


                int
                f_25010_7638_7670(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7638, 7670);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 7416, 7682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 7416, 7682);
            }
        }

        private static void VisitLocals(ImmutableArray<ILocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25010, 7694, 7897);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7787, 7886);
                    foreach (var local in f_25010_7809_7815_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 7787, 7886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 7849, 7871);

                        f_25010_7849_7870(local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 7787, 7886);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 100);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25010, 7694, 7897);

                int
                f_25010_7849_7870(Microsoft.CodeAnalysis.ILocalSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7849, 7870);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_7809_7815_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 7809, 7815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 7694, 7897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 7694, 7897);
            }
        }

        public override void VisitWhileLoop(IWhileLoopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 7909, 9130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8000, 8021);

                f_25010_8000_8020(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8035, 8084);

                f_25010_8035_8083(LoopKind.While, f_25010_8064_8082(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8100, 8146);

                var
                conditionIsTop = f_25010_8121_8145(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8160, 8210);

                var
                conditionIsUntil = f_25010_8183_8209(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8226, 8259);

                IEnumerable<IOperation>
                children
                = default(IEnumerable<IOperation>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8275, 9058) || true) && (conditionIsTop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8275, 9058);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8327, 8650) || true) && (f_25010_8331_8357(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8327, 8650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8407, 8492);

                        children = new[] { f_25010_8426_8445(operation), f_25010_8447_8461(operation), f_25010_8463_8489(operation) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8327, 8650);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8327, 8650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8574, 8631);

                        children = new[] { f_25010_8593_8612(operation), f_25010_8614_8628(operation) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8327, 8650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8275, 9058);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8275, 9058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8716, 8756);

                    f_25010_8716_8755(f_25010_8728_8754(operation));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8776, 9043) || true) && (f_25010_8780_8799(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8776, 9043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8849, 8906);

                        children = new[] { f_25010_8868_8882(operation), f_25010_8884_8903(operation) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8776, 9043);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 8776, 9043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 8988, 9024);

                        children = new[] { f_25010_9007_9021(operation) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8776, 9043);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 8275, 9058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9074, 9119);

                f_25010_9074_9118(children, f_25010_9099_9117(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 7909, 9130);

                int
                f_25010_8000_8020(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                operation)
                {
                    VisitLoop((Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 8000, 8020);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.LoopKind
                f_25010_8064_8082(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8064, 8082);
                    return return_v;
                }


                int
                f_25010_8035_8083(Microsoft.CodeAnalysis.Operations.LoopKind
                expected, Microsoft.CodeAnalysis.Operations.LoopKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 8035, 8083);
                    return 0;
                }


                bool
                f_25010_8121_8145(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.ConditionIsTop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8121, 8145);
                    return return_v;
                }


                bool
                f_25010_8183_8209(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.ConditionIsUntil;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8183, 8209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_8331_8357(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8331, 8357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_8426_8445(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8426, 8445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_8447_8461(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8447, 8461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_8463_8489(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8463, 8489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_8593_8612(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8593, 8612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_8614_8628(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8614, 8628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_8728_8754(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.IgnoredCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8728, 8754);
                    return return_v;
                }


                int
                f_25010_8716_8755(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 8716, 8755);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_8780_8799(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8780, 8799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_8868_8882(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8868, 8882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_8884_8903(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 8884, 8903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_9007_9021(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9007, 9021);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_9099_9117(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9099, 9117);
                    return return_v;
                }


                bool
                f_25010_9074_9118(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9074, 9118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 7909, 9130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 7909, 9130);
            }
        }

        public override void VisitForLoop(IForLoopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 9142, 9836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9229, 9250);

                f_25010_9229_9249(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9264, 9311);

                f_25010_9264_9310(LoopKind.For, f_25010_9291_9309(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9325, 9355);

                f_25010_9325_9354(f_25010_9337_9353(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9369, 9408);

                f_25010_9369_9407(f_25010_9381_9406(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9424, 9476);

                IEnumerable<IOperation>
                children = f_25010_9459_9475(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9492, 9630) || true) && (f_25010_9496_9515(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 9492, 9630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9557, 9615);

                    children = f_25010_9568_9614(children, new[] { f_25010_9592_9611(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 9492, 9630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9646, 9699);

                children = f_25010_9657_9698(children, new[] { f_25010_9681_9695(operation) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9713, 9764);

                children = f_25010_9724_9763(children, f_25010_9740_9762(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9780, 9825);

                f_25010_9780_9824(children, f_25010_9805_9823(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 9142, 9836);

                int
                f_25010_9229_9249(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                operation)
                {
                    VisitLoop((Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9229, 9249);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.LoopKind
                f_25010_9291_9309(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9291, 9309);
                    return return_v;
                }


                int
                f_25010_9264_9310(Microsoft.CodeAnalysis.Operations.LoopKind
                expected, Microsoft.CodeAnalysis.Operations.LoopKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9264, 9310);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_9337_9353(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9337, 9353);
                    return return_v;
                }


                int
                f_25010_9325_9354(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9325, 9354);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_9381_9406(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.ConditionLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9381, 9406);
                    return return_v;
                }


                int
                f_25010_9369_9407(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9369, 9407);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_9459_9475(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Before;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9459, 9475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_9496_9515(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9496, 9515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_9592_9611(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9592, 9611);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_9568_9614(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9568, 9614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_9681_9695(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9681, 9695);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_9657_9698(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9657, 9698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_9740_9762(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.AtLoopBottom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9740, 9762);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_9724_9763(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9724, 9763);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_9805_9823(Microsoft.CodeAnalysis.Operations.IForLoopOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 9805, 9823);
                    return return_v;
                }


                bool
                f_25010_9780_9824(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9780, 9824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 9142, 9836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 9142, 9836);
            }
        }

        public override void VisitForToLoop(IForToLoopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 9848, 10850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9939, 9960);

                f_25010_9939_9959(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 9974, 10023);

                f_25010_9974_10022(LoopKind.ForTo, f_25010_10003_10021(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10037, 10061);

                _ = f_25010_10041_10060(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10075, 10191);

                (ILocalSymbol loopObject, ForToLoopOperationUserDefinedInfo userDefinedInfo) = f_25010_10154_10190(((ForToLoopOperation)operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10207, 10517) || true) && (userDefinedInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 10207, 10517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10268, 10308);

                    f_25010_10268_10307(userDefinedInfo.Addition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10326, 10369);

                    f_25010_10326_10368(userDefinedInfo.Subtraction);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10387, 10434);

                    f_25010_10387_10433(userDefinedInfo.LessThanOrEqual);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10452, 10502);

                    f_25010_10452_10501(userDefinedInfo.GreaterThanOrEqual);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 10207, 10517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10533, 10566);

                IEnumerable<IOperation>
                children
                = default(IEnumerable<IOperation>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10580, 10714);

                children = new[] { f_25010_10599_10628(operation), f_25010_10630_10652(operation), f_25010_10654_10674(operation), f_25010_10676_10695(operation), f_25010_10697_10711(operation) };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10728, 10780);

                children = f_25010_10739_10779(children, f_25010_10755_10778(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10794, 10839);

                f_25010_10794_10838(children, f_25010_10819_10837(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 9848, 10850);

                int
                f_25010_9939_9959(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                operation)
                {
                    VisitLoop((Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9939, 9959);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.LoopKind
                f_25010_10003_10021(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10003, 10021);
                    return return_v;
                }


                int
                f_25010_9974_10022(Microsoft.CodeAnalysis.Operations.LoopKind
                expected, Microsoft.CodeAnalysis.Operations.LoopKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 9974, 10022);
                    return 0;
                }


                bool
                f_25010_10041_10060(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10041, 10060);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.ILocalSymbol LoopObject, Microsoft.CodeAnalysis.Operations.ForToLoopOperationUserDefinedInfo UserDefinedInfo)
                f_25010_10154_10190(Microsoft.CodeAnalysis.Operations.ForToLoopOperation
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10154, 10190);
                    return return_v;
                }


                int
                f_25010_10268_10307(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                root)
                {
                    VerifySubTree((Microsoft.CodeAnalysis.IOperation)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10268, 10307);
                    return 0;
                }


                int
                f_25010_10326_10368(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                root)
                {
                    VerifySubTree((Microsoft.CodeAnalysis.IOperation)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10326, 10368);
                    return 0;
                }


                int
                f_25010_10387_10433(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    VerifySubTree(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10387, 10433);
                    return 0;
                }


                int
                f_25010_10452_10501(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    VerifySubTree(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10452, 10501);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_10599_10628(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopControlVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10599, 10628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_10630_10652(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.InitialValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10630, 10652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_10654_10674(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.LimitValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10654, 10674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_10676_10695(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.StepValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10676, 10695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_10697_10711(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10697, 10711);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_10755_10778(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.NextVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10755, 10778);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_10739_10779(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10739, 10779);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_10819_10837(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 10819, 10837);
                    return return_v;
                }


                bool
                f_25010_10794_10838(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10794, 10838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 9848, 10850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 9848, 10850);
            }
        }

        public override void VisitForEachLoop(IForEachLoopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 10862, 11998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10957, 10978);

                f_25010_10957_10977(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 10992, 11043);

                f_25010_10992_11042(LoopKind.ForEach, f_25010_11023_11041(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11059, 11204);

                IEnumerable<IOperation>
                children = f_25010_11094_11203(new[] { f_25010_11102_11122(operation), f_25010_11124_11153(operation), f_25010_11155_11169(operation) }, f_25010_11179_11202(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11218, 11263);

                f_25010_11218_11262(children, f_25010_11243_11261(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11277, 11348);

                ForEachLoopOperationInfo
                info = f_25010_11309_11347(((ForEachLoopOperation)operation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11362, 11640) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 11362, 11640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11412, 11456);

                    f_25010_11412_11455(info.GetEnumeratorArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11474, 11513);

                    f_25010_11474_11512(info.MoveNextArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11531, 11569);

                    f_25010_11531_11568(info.CurrentArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11587, 11625);

                    f_25010_11587_11624(info.DisposeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 11362, 11640);
                }

                void visitArguments(ImmutableArray<IArgumentOperation> arguments)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 11656, 11987);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11754, 11972) || true) && (arguments != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 11754, 11972);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11817, 11953);
                                foreach (IArgumentOperation arg in f_25010_11852_11861_I(arguments))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 11817, 11953);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 11911, 11930);

                                    f_25010_11911_11929(arg);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 11817, 11953);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 137);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 137);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 11754, 11972);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 11656, 11987);

                        int
                        f_25010_11911_11929(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                        root)
                        {
                            VerifySubTree((Microsoft.CodeAnalysis.IOperation)root);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11911, 11929);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                        f_25010_11852_11861_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11852, 11861);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 11656, 11987);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 11656, 11987);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 10862, 11998);

                int
                f_25010_10957_10977(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                operation)
                {
                    VisitLoop((Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10957, 10977);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.LoopKind
                f_25010_11023_11041(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11023, 11041);
                    return return_v;
                }


                int
                f_25010_10992_11042(Microsoft.CodeAnalysis.Operations.LoopKind
                expected, Microsoft.CodeAnalysis.Operations.LoopKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 10992, 11042);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_11102_11122(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.Collection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11102, 11122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_11124_11153(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.LoopControlVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11124, 11153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_11155_11169(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11155, 11169);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_11179_11202(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.NextVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11179, 11202);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_11094_11203(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11094, 11203);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_11243_11261(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11243, 11261);
                    return return_v;
                }


                bool
                f_25010_11218_11262(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11218, 11262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.ForEachLoopOperationInfo?
                f_25010_11309_11347(Microsoft.CodeAnalysis.Operations.ForEachLoopOperation
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 11309, 11347);
                    return return_v;
                }


                int
                f_25010_11412_11455(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments)
                {
                    visitArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11412, 11455);
                    return 0;
                }


                int
                f_25010_11474_11512(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments)
                {
                    visitArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11474, 11512);
                    return 0;
                }


                int
                f_25010_11531_11568(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments)
                {
                    visitArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11531, 11568);
                    return 0;
                }


                int
                f_25010_11587_11624(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments)
                {
                    visitArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 11587, 11624);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 10862, 11998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 10862, 11998);
            }
        }

        private static void VisitLoop(ILoopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25010, 12010, 12298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12090, 12139);

                f_25010_12090_12138(OperationKind.Loop, f_25010_12123_12137(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12153, 12183);

                f_25010_12153_12182(f_25010_12165_12181(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12197, 12237);

                f_25010_12197_12236(f_25010_12212_12235(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12251, 12287);

                f_25010_12251_12286(f_25010_12266_12285(operation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25010, 12010, 12298);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_12123_12137(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12123, 12137);
                    return return_v;
                }


                int
                f_25010_12090_12138(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12090, 12138);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_12165_12181(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12165, 12181);
                    return return_v;
                }


                int
                f_25010_12153_12182(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12153, 12182);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_12212_12235(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12212, 12235);
                    return return_v;
                }


                int
                f_25010_12197_12236(Microsoft.CodeAnalysis.ILabelSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12197, 12236);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_12266_12285(Microsoft.CodeAnalysis.Operations.ILoopOperation
                this_param)
                {
                    var return_v = this_param.ExitLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12266, 12285);
                    return return_v;
                }


                int
                f_25010_12251_12286(Microsoft.CodeAnalysis.ILabelSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12251, 12286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 12010, 12298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 12010, 12298);
            }
        }

        public override void VisitLabeled(ILabeledOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 12310, 12763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12397, 12449);

                f_25010_12397_12448(OperationKind.Labeled, f_25010_12433_12447(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12463, 12495);

                f_25010_12463_12494(f_25010_12478_12493(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12511, 12752) || true) && (f_25010_12515_12534(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 12511, 12752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12576, 12609);

                    f_25010_12576_12608(f_25010_12589_12607(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 12511, 12752);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 12511, 12752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12675, 12737);

                    f_25010_12675_12736(f_25010_12687_12706(operation), f_25010_12708_12735(f_25010_12708_12726(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 12511, 12752);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 12310, 12763);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_12433_12447(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12433, 12447);
                    return return_v;
                }


                int
                f_25010_12397_12448(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12397, 12448);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_12478_12493(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12478, 12493);
                    return return_v;
                }


                int
                f_25010_12463_12494(Microsoft.CodeAnalysis.ILabelSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12463, 12494);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_12515_12534(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12515, 12534);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_12589_12607(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12589, 12607);
                    return return_v;
                }


                int
                f_25010_12576_12608(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12576, 12608);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_12687_12706(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12687, 12706);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_12708_12726(Microsoft.CodeAnalysis.Operations.ILabeledOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12708, 12726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_12708_12735(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12708, 12735);
                    return return_v;
                }


                int
                f_25010_12675_12736(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12675, 12736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 12310, 12763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 12310, 12763);
            }
        }

        public override void VisitBranch(IBranchOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 12775, 13338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12860, 12911);

                f_25010_12860_12910(OperationKind.Branch, f_25010_12895_12909(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12925, 12958);

                f_25010_12925_12957(f_25010_12940_12956(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 12974, 13278);

                switch (f_25010_12982_13002(operation))
                {

                    case BranchKind.Break:
                    case BranchKind.Continue:
                    case BranchKind.GoTo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 12974, 13278);
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 13162, 13168);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 12974, 13278);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 12974, 13278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13216, 13235);

                        f_25010_13216_13234(true);
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 13257, 13263);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 12974, 13278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13294, 13327);

                f_25010_13294_13326(f_25010_13307_13325(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 12775, 13338);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_12895_12909(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12895, 12909);
                    return return_v;
                }


                int
                f_25010_12860_12910(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12860, 12910);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_12940_12956(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12940, 12956);
                    return return_v;
                }


                int
                f_25010_12925_12957(Microsoft.CodeAnalysis.ILabelSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 12925, 12957);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.BranchKind
                f_25010_12982_13002(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.BranchKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 12982, 13002);
                    return return_v;
                }


                int
                f_25010_13216_13234(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13216, 13234);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_13307_13325(Microsoft.CodeAnalysis.Operations.IBranchOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13307, 13325);
                    return return_v;
                }


                int
                f_25010_13294_13326(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13294, 13326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 12775, 13338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 12775, 13338);
            }
        }

        public override void VisitEmpty(IEmptyOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 13350, 13541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13433, 13483);

                f_25010_13433_13482(OperationKind.Empty, f_25010_13467_13481(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13497, 13530);

                f_25010_13497_13529(f_25010_13510_13528(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 13350, 13541);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_13467_13481(Microsoft.CodeAnalysis.Operations.IEmptyOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13467, 13481);
                    return return_v;
                }


                int
                f_25010_13433_13482(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13433, 13482);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_13510_13528(Microsoft.CodeAnalysis.Operations.IEmptyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13510, 13528);
                    return return_v;
                }


                int
                f_25010_13497_13529(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13497, 13529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 13350, 13541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 13350, 13541);
            }
        }

        public override void VisitReturn(IReturnOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 13553, 14106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13638, 13755);

                f_25010_13638_13754(f_25010_13654_13668(operation), new[] { OperationKind.Return, OperationKind.YieldReturn, OperationKind.YieldBreak });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13769, 14095) || true) && (f_25010_13773_13796(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 13769, 14095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13838, 13897);

                    f_25010_13838_13896(OperationKind.YieldReturn, f_25010_13881_13895(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 13915, 13948);

                    f_25010_13915_13947(f_25010_13928_13946(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 13769, 14095);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 13769, 14095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14014, 14080);

                    f_25010_14014_14079(f_25010_14026_14049(operation), f_25010_14051_14078(f_25010_14051_14069(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 13769, 14095);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 13553, 14106);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_13654_13668(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13654, 13668);
                    return return_v;
                }


                int
                f_25010_13638_13754(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind[]
                collection)
                {
                    Assert.Contains(expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.OperationKind>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13638, 13754);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_13773_13796(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.ReturnedValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13773, 13796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_13881_13895(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13881, 13895);
                    return return_v;
                }


                int
                f_25010_13838_13896(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13838, 13896);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_13928_13946(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 13928, 13946);
                    return return_v;
                }


                int
                f_25010_13915_13947(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 13915, 13947);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_14026_14049(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.ReturnedValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14026, 14049);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_14051_14069(Microsoft.CodeAnalysis.Operations.IReturnOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14051, 14069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_14051_14078(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14051, 14078);
                    return return_v;
                }


                int
                f_25010_14014_14079(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14014, 14079);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 13553, 14106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 13553, 14106);
            }
        }

        public override void VisitLock(ILockOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 14118, 14357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14199, 14248);

                f_25010_14199_14247(OperationKind.Lock, f_25010_14232_14246(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14262, 14346);

                f_25010_14262_14345(new[] { f_25010_14285_14306(operation), f_25010_14308_14322(operation) }, f_25010_14326_14344(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 14118, 14357);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_14232_14246(Microsoft.CodeAnalysis.Operations.ILockOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14232, 14246);
                    return return_v;
                }


                int
                f_25010_14199_14247(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14199, 14247);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_14285_14306(Microsoft.CodeAnalysis.Operations.ILockOperation
                this_param)
                {
                    var return_v = this_param.LockedValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14285, 14306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_14308_14322(Microsoft.CodeAnalysis.Operations.ILockOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14308, 14322);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_14326_14344(Microsoft.CodeAnalysis.Operations.ILockOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14326, 14344);
                    return return_v;
                }


                bool
                f_25010_14262_14345(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14262, 14345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 14118, 14357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 14118, 14357);
            }
        }

        public override void VisitTry(ITryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 14369, 14888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14448, 14496);

                f_25010_14448_14495(OperationKind.Try, f_25010_14480_14494(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14510, 14570);

                IEnumerable<IOperation>
                children = new[] { f_25010_14553_14567(operation) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14584, 14608);

                _ = f_25010_14588_14607(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14622, 14668);

                children = f_25010_14633_14667(children, f_25010_14649_14666(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14682, 14816) || true) && (f_25010_14686_14703(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 14682, 14816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14745, 14801);

                    children = f_25010_14756_14800(children, new[] { f_25010_14780_14797(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 14682, 14816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14832, 14877);

                f_25010_14832_14876(children, f_25010_14857_14875(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 14369, 14888);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_14480_14494(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14480, 14494);
                    return return_v;
                }


                int
                f_25010_14448_14495(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14448, 14495);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_14553_14567(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14553, 14567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol?
                f_25010_14588_14607(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.ExitLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14588, 14607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>
                f_25010_14649_14666(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Catches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14649, 14666);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_14633_14667(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14633, 14667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_14686_14703(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14686, 14703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_14780_14797(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14780, 14797);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_14756_14800(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IBlockOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14756, 14800);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_14857_14875(Microsoft.CodeAnalysis.Operations.ITryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 14857, 14875);
                    return return_v;
                }


                bool
                f_25010_14832_14876(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14832, 14876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 14369, 14888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 14369, 14888);
            }
        }

        public override void VisitCatchClause(ICatchClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 14900, 15718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 14995, 15051);

                f_25010_14995_15050(OperationKind.CatchClause, f_25010_15035_15049(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15065, 15109);

                var
                exceptionType = f_25010_15085_15108(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15123, 15153);

                f_25010_15123_15152(f_25010_15135_15151(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15169, 15230);

                IEnumerable<IOperation>
                children = f_25010_15204_15229()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15244, 15428) || true) && (f_25010_15248_15290(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 15244, 15428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15332, 15413);

                    children = f_25010_15343_15412(children, new[] { f_25010_15367_15409(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 15244, 15428);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15444, 15576) || true) && (f_25010_15448_15464(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 15444, 15576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15506, 15561);

                    children = f_25010_15517_15560(children, new[] { f_25010_15541_15557(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 15444, 15576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15592, 15648);

                children = f_25010_15603_15647(children, new[] { f_25010_15627_15644(operation) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15662, 15707);

                f_25010_15662_15706(children, f_25010_15687_15705(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 14900, 15718);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_15035_15049(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15035, 15049);
                    return return_v;
                }


                int
                f_25010_14995_15050(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 14995, 15050);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_15085_15108(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.ExceptionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15085, 15108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_15135_15151(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15135, 15151);
                    return return_v;
                }


                int
                f_25010_15123_15152(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15123, 15152);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation[]
                f_25010_15204_15229()
                {
                    var return_v = Array.Empty<IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15204, 15229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_15248_15290(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.ExceptionDeclarationOrExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15248, 15290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_15367_15409(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.ExceptionDeclarationOrExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15367, 15409);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_15343_15412(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15343, 15412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_15448_15464(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15448, 15464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_15541_15557(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15541, 15557);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_15517_15560(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15517, 15560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_15627_15644(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Handler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15627, 15644);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_15603_15647(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IBlockOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15603, 15647);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_15687_15705(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15687, 15705);
                    return return_v;
                }


                bool
                f_25010_15662_15706(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15662, 15706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 14900, 15718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 14900, 15718);
            }
        }

        public override void VisitUsing(IUsingOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 15730, 16565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15813, 15863);

                f_25010_15813_15862(OperationKind.Using, f_25010_15847_15861(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15877, 15907);

                f_25010_15877_15906(f_25010_15889_15905(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 15921, 16003);

                f_25010_15921_16002(new[] { f_25010_15944_15963(operation), f_25010_15965_15979(operation) }, f_25010_15983_16001(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16017, 16094);

                f_25010_16017_16093(OperationKind.VariableDeclaration, f_25010_16068_16092(f_25010_16068_16087(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16108, 16184);

                f_25010_16108_16183(OperationKind.VariableDeclarator, f_25010_16158_16182(f_25010_16158_16177(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16200, 16258);

                _ = ((UsingOperation)operation).DisposeInfo.DisposeMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16272, 16347);

                var
                disposeArgs = ((UsingOperation)operation).DisposeInfo.DisposeArguments
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16361, 16554) || true) && (f_25010_16365_16394_M(!disposeArgs.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 16361, 16554);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16428, 16539);
                        foreach (var arg in f_25010_16448_16459_I(disposeArgs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 16428, 16539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16501, 16520);

                            f_25010_16501_16519(arg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 16428, 16539);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 16361, 16554);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 15730, 16565);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_15847_15861(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15847, 15861);
                    return return_v;
                }


                int
                f_25010_15813_15862(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15813, 15862);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_15889_15905(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15889, 15905);
                    return return_v;
                }


                int
                f_25010_15877_15906(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15877, 15906);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_15944_15963(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Resources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15944, 15963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_15965_15979(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15965, 15979);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_15983_16001(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 15983, 16001);
                    return return_v;
                }


                bool
                f_25010_15921_16002(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 15921, 16002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_16068_16087(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Resources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16068, 16087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_16068_16092(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16068, 16092);
                    return return_v;
                }


                int
                f_25010_16017_16093(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16017, 16093);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_16158_16177(Microsoft.CodeAnalysis.Operations.IUsingOperation
                this_param)
                {
                    var return_v = this_param.Resources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16158, 16177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_16158_16182(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16158, 16182);
                    return return_v;
                }


                int
                f_25010_16108_16183(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16108, 16183);
                    return 0;
                }


                bool
                f_25010_16365_16394_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16365, 16394);
                    return return_v;
                }


                int
                f_25010_16501_16519(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                root)
                {
                    VerifySubTree((Microsoft.CodeAnalysis.IOperation)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16501, 16519);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_16448_16459_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16448, 16459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 15730, 16565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 15730, 16565);
            }
        }

        internal override void VisitFixed(IFixedOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 16635, 16920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16720, 16769);

                f_25010_16720_16768(OperationKind.None, f_25010_16753_16767(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16783, 16813);

                f_25010_16783_16812(f_25010_16795_16811(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 16827, 16909);

                f_25010_16827_16908(new[] { f_25010_16850_16869(operation), f_25010_16871_16885(operation) }, f_25010_16889_16907(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 16635, 16920);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_16753_16767(Microsoft.CodeAnalysis.Operations.IFixedOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16753, 16767);
                    return return_v;
                }


                int
                f_25010_16720_16768(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16720, 16768);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_16795_16811(Microsoft.CodeAnalysis.Operations.IFixedOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16795, 16811);
                    return return_v;
                }


                int
                f_25010_16783_16812(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16783, 16812);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                f_25010_16850_16869(Microsoft.CodeAnalysis.Operations.IFixedOperation
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16850, 16869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_16871_16885(Microsoft.CodeAnalysis.Operations.IFixedOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16871, 16885);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_16889_16907(Microsoft.CodeAnalysis.Operations.IFixedOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 16889, 16907);
                    return return_v;
                }


                bool
                f_25010_16827_16908(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 16827, 16908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 16635, 16920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 16635, 16920);
            }
        }

        internal override void VisitAggregateQuery(IAggregateQueryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 16932, 17194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17035, 17084);

                f_25010_17035_17083(OperationKind.None, f_25010_17068_17082(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17098, 17183);

                f_25010_17098_17182(new[] { f_25010_17121_17136(operation), f_25010_17138_17159(operation) }, f_25010_17163_17181(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 16932, 17194);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_17068_17082(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17068, 17082);
                    return return_v;
                }


                int
                f_25010_17035_17083(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17035, 17083);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17121_17136(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
                this_param)
                {
                    var return_v = this_param.Group;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17121, 17136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17138_17159(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
                this_param)
                {
                    var return_v = this_param.Aggregation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17138, 17159);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_17163_17181(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17163, 17181);
                    return return_v;
                }


                bool
                f_25010_17098_17182(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17098, 17182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 16932, 17194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 16932, 17194);
            }
        }

        public override void VisitExpressionStatement(IExpressionStatementOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 17206, 17468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17317, 17381);

                f_25010_17317_17380(OperationKind.ExpressionStatement, f_25010_17365_17379(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17395, 17457);

                f_25010_17395_17456(f_25010_17407_17426(operation), f_25010_17428_17455(f_25010_17428_17446(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 17206, 17468);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_17365_17379(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17365, 17379);
                    return return_v;
                }


                int
                f_25010_17317_17380(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17317, 17380);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17407_17426(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17407, 17426);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_17428_17446(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17428, 17446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17428_17455(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17428, 17455);
                    return return_v;
                }


                int
                f_25010_17395_17456(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17395, 17456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 17206, 17468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 17206, 17468);
            }
        }

        internal override void VisitWithStatement(IWithStatementOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 17480, 17733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17581, 17630);

                f_25010_17581_17629(OperationKind.None, f_25010_17614_17628(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17644, 17722);

                f_25010_17644_17721(new[] { f_25010_17667_17682(operation), f_25010_17684_17698(operation) }, f_25010_17702_17720(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 17480, 17733);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_17614_17628(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17614, 17628);
                    return return_v;
                }


                int
                f_25010_17581_17629(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17581, 17629);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17667_17682(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17667, 17682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_17684_17698(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17684, 17698);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_17702_17720(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17702, 17720);
                    return return_v;
                }


                bool
                f_25010_17644_17721(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17644, 17721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 17480, 17733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 17480, 17733);
            }
        }

        public override void VisitStop(IStopOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 17745, 17933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17826, 17875);

                f_25010_17826_17874(OperationKind.Stop, f_25010_17859_17873(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 17889, 17922);

                f_25010_17889_17921(f_25010_17902_17920(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 17745, 17933);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_17859_17873(Microsoft.CodeAnalysis.Operations.IStopOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17859, 17873);
                    return return_v;
                }


                int
                f_25010_17826_17874(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17826, 17874);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_17902_17920(Microsoft.CodeAnalysis.Operations.IStopOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 17902, 17920);
                    return return_v;
                }


                int
                f_25010_17889_17921(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 17889, 17921);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 17745, 17933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 17745, 17933);
            }
        }

        public override void VisitEnd(IEndOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 17945, 18130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18024, 18072);

                f_25010_18024_18071(OperationKind.End, f_25010_18056_18070(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18086, 18119);

                f_25010_18086_18118(f_25010_18099_18117(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 17945, 18130);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_18056_18070(Microsoft.CodeAnalysis.Operations.IEndOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18056, 18070);
                    return return_v;
                }


                int
                f_25010_18024_18071(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18024, 18071);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_18099_18117(Microsoft.CodeAnalysis.Operations.IEndOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18099, 18117);
                    return return_v;
                }


                int
                f_25010_18086_18118(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18086, 18118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 17945, 18130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 17945, 18130);
            }
        }

        public override void VisitInvocation(IInvocationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 18142, 19237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18235, 18290);

                f_25010_18235_18289(OperationKind.Invocation, f_25010_18274_18288(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18304, 18343);

                f_25010_18304_18342(f_25010_18319_18341(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18357, 18393);

                var
                isVirtual = f_25010_18373_18392(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18409, 18442);

                IEnumerable<IOperation>
                children
                = default(IEnumerable<IOperation>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18456, 18700) || true) && (f_25010_18460_18478(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 18456, 18700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18520, 18588);

                    children = f_25010_18531_18587(new[] { f_25010_18539_18557(operation) }, f_25010_18567_18586(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 18456, 18700);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 18456, 18700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18654, 18685);

                    children = f_25010_18665_18684(operation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 18456, 18700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18716, 18761);

                f_25010_18716_18760(children, f_25010_18741_18759(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 18955, 19226) || true) && (f_25010_18959_18990(f_25010_18959_18981(operation)) && (DynAbs.Tracing.TraceSender.Expression_True(25010, 18959, 19060) && f_25010_19011_19029(operation) is IInstanceReferenceOperation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 18955, 19226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19094, 19211);

                    f_25010_19094_19210(f_25010_19107_19136(f_25010_19107_19125(operation)), $"Implicit {nameof(IInstanceReferenceOperation)} on {f_25010_19191_19207(operation)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 18955, 19226);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 18142, 19237);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_18274_18288(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18274, 18288);
                    return return_v;
                }


                int
                f_25010_18235_18289(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18235, 18289);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_18319_18341(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18319, 18341);
                    return return_v;
                }


                int
                f_25010_18304_18342(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18304, 18342);
                    return 0;
                }


                bool
                f_25010_18373_18392(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18373, 18392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_18460_18478(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18460, 18478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_18539_18557(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18539, 18557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_18567_18586(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18567, 18586);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_18531_18587(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18531, 18587);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_18665_18684(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18665, 18684);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_18741_18759(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18741, 18759);
                    return return_v;
                }


                bool
                f_25010_18716_18760(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 18716, 18760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_18959_18981(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18959, 18981);
                    return return_v;
                }


                bool
                f_25010_18959_18990(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 18959, 18990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_19011_19029(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19011, 19029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_19107_19125(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19107, 19125);
                    return return_v;
                }


                bool
                f_25010_19107_19136(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19107, 19136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_19191_19207(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19191, 19207);
                    return return_v;
                }


                int
                f_25010_19094_19210(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19094, 19210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 18142, 19237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 18142, 19237);
            }
        }

        public override void VisitArgument(IArgumentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 19249, 20063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19338, 19391);

                f_25010_19338_19390(OperationKind.Argument, f_25010_19375_19389(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19405, 19530);

                f_25010_19405_19529(f_25010_19421_19443(operation), new[] { ArgumentKind.DefaultValue, ArgumentKind.Explicit, ArgumentKind.ParamArray });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19544, 19580);

                var
                parameter = f_25010_19560_19579(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19596, 19654);

                f_25010_19596_19653(f_25010_19608_19623(operation), f_25010_19625_19652(f_25010_19625_19643(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19668, 19710);

                var
                inConversion = f_25010_19687_19709(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19724, 19768);

                var
                outConversion = f_25010_19744_19767(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19784, 20052) || true) && (f_25010_19788_19810(operation) == ArgumentKind.DefaultValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 19784, 20052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 19873, 20037);

                    f_25010_19873_20036(f_25010_19885_19931(f_25010_19885_19908(operation), n => n.IsImplicit), $"Explicit node in default argument value ({f_25010_19977_20001(f_25010_19977_19993(operation))}): {f_25010_20006_20033(f_25010_20006_20022(operation))}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 19784, 20052);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 19249, 20063);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_19375_19389(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19375, 19389);
                    return return_v;
                }


                int
                f_25010_19338_19390(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19338, 19390);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.ArgumentKind
                f_25010_19421_19443(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.ArgumentKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19421, 19443);
                    return return_v;
                }


                int
                f_25010_19405_19529(Microsoft.CodeAnalysis.Operations.ArgumentKind
                expected, Microsoft.CodeAnalysis.Operations.ArgumentKind[]
                collection)
                {
                    Assert.Contains(expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.ArgumentKind>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19405, 19529);
                    return 0;
                }


                Microsoft.CodeAnalysis.IParameterSymbol?
                f_25010_19560_19579(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19560, 19579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_19608_19623(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19608, 19623);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_19625_19643(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19625, 19643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_19625_19652(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19625, 19652);
                    return return_v;
                }


                int
                f_25010_19596_19653(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19596, 19653);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_19687_19709(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.InConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19687, 19709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_19744_19767(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.OutConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19744, 19767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.ArgumentKind
                f_25010_19788_19810(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.ArgumentKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19788, 19810);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_19885_19908(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                operation)
                {
                    var return_v = operation.Descendants();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19885, 19908);
                    return return_v;
                }


                bool
                f_25010_19885_19931(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source, System.Func<Microsoft.CodeAnalysis.IOperation, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.IOperation>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19885, 19931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_19977_19993(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19977, 19993);
                    return return_v;
                }


                int
                f_25010_19977_20001(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 19977, 20001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_20006_20022(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20006, 20022);
                    return return_v;
                }


                string
                f_25010_20006_20033(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20006, 20033);
                    return return_v;
                }


                int
                f_25010_19873_20036(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 19873, 20036);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 19249, 20063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 19249, 20063);
            }
        }

        public override void VisitOmittedArgument(IOmittedArgumentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 20075, 20296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20178, 20238);

                f_25010_20178_20237(OperationKind.OmittedArgument, f_25010_20222_20236(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20252, 20285);

                f_25010_20252_20284(f_25010_20265_20283(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 20075, 20296);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_20222_20236(Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20222, 20236);
                    return return_v;
                }


                int
                f_25010_20178_20237(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20178, 20237);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_20265_20283(Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20265, 20283);
                    return return_v;
                }


                int
                f_25010_20252_20284(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20252, 20284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 20075, 20296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 20075, 20296);
            }
        }

        public override void VisitArrayElementReference(IArrayElementReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 20308, 20611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20423, 20489);

                f_25010_20423_20488(OperationKind.ArrayElementReference, f_25010_20473_20487(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20503, 20600);

                f_25010_20503_20599(f_25010_20518_20578(new[] { f_25010_20526_20550(operation) }, f_25010_20560_20577(operation)), f_25010_20580_20598(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 20308, 20611);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_20473_20487(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20473, 20487);
                    return return_v;
                }


                int
                f_25010_20423_20488(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20423, 20488);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_20526_20550(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
                this_param)
                {
                    var return_v = this_param.ArrayReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20526, 20550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_20560_20577(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20560, 20577);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_20518_20578(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20518, 20578);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_20580_20598(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20580, 20598);
                    return return_v;
                }


                bool
                f_25010_20503_20599(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20503, 20599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 20308, 20611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 20308, 20611);
            }
        }

        internal override void VisitPointerIndirectionReference(IPointerIndirectionReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 20623, 20886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20752, 20801);

                f_25010_20752_20800(OperationKind.None, f_25010_20785_20799(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20815, 20875);

                f_25010_20815_20874(f_25010_20827_20844(operation), f_25010_20846_20873(f_25010_20846_20864(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 20623, 20886);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_20785_20799(Microsoft.CodeAnalysis.Operations.IPointerIndirectionReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20785, 20799);
                    return return_v;
                }


                int
                f_25010_20752_20800(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20752, 20800);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_20827_20844(Microsoft.CodeAnalysis.Operations.IPointerIndirectionReferenceOperation
                this_param)
                {
                    var return_v = this_param.Pointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20827, 20844);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_20846_20864(Microsoft.CodeAnalysis.Operations.IPointerIndirectionReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 20846, 20864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_20846_20873(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20846, 20873);
                    return return_v;
                }


                int
                f_25010_20815_20874(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20815, 20874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 20623, 20886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 20623, 20886);
            }
        }

        public override void VisitLocalReference(ILocalReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 20898, 21220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 20999, 21058);

                f_25010_20999_21057(OperationKind.LocalReference, f_25010_21042_21056(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21072, 21104);

                f_25010_21072_21103(f_25010_21087_21102(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21118, 21162);

                var
                isDeclaration = f_25010_21138_21161(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21176, 21209);

                f_25010_21176_21208(f_25010_21189_21207(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 20898, 21220);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_21042_21056(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21042, 21056);
                    return return_v;
                }


                int
                f_25010_20999_21057(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 20999, 21057);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25010_21087_21102(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21087, 21102);
                    return return_v;
                }


                int
                f_25010_21072_21103(Microsoft.CodeAnalysis.ILocalSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21072, 21103);
                    return 0;
                }


                bool
                f_25010_21138_21161(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.IsDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21138, 21161);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_21189_21207(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21189, 21207);
                    return return_v;
                }


                int
                f_25010_21176_21208(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21176, 21208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 20898, 21220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 20898, 21220);
            }
        }

        public override void VisitParameterReference(IParameterReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 21232, 21512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21341, 21404);

                f_25010_21341_21403(OperationKind.ParameterReference, f_25010_21388_21402(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21418, 21454);

                f_25010_21418_21453(f_25010_21433_21452(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21468, 21501);

                f_25010_21468_21500(f_25010_21481_21499(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 21232, 21512);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_21388_21402(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21388, 21402);
                    return return_v;
                }


                int
                f_25010_21341_21403(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21341, 21403);
                    return 0;
                }


                Microsoft.CodeAnalysis.IParameterSymbol
                f_25010_21433_21452(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21433, 21452);
                    return return_v;
                }


                int
                f_25010_21418_21453(Microsoft.CodeAnalysis.IParameterSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21418, 21453);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_21481_21499(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21481, 21499);
                    return return_v;
                }


                int
                f_25010_21468_21500(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21468, 21500);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 21232, 21512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 21232, 21512);
            }
        }

        public override void VisitInstanceReference(IInstanceReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 21524, 21809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21631, 21693);

                f_25010_21631_21692(OperationKind.InstanceReference, f_25010_21677_21691(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21707, 21740);

                f_25010_21707_21739(f_25010_21720_21738(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21754, 21798);

                var
                referenceKind = f_25010_21774_21797(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 21524, 21809);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_21677_21691(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21677, 21691);
                    return return_v;
                }


                int
                f_25010_21631_21692(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21631, 21692);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_21720_21738(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21720, 21738);
                    return return_v;
                }


                int
                f_25010_21707_21739(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21707, 21739);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                f_25010_21774_21797(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.ReferenceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 21774, 21797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 21524, 21809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 21524, 21809);
            }
        }

        private void VisitMemberReference(IMemberReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 21821, 21986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 21916, 21975);

                f_25010_21916_21974(this, operation, f_25010_21948_21973());
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 21821, 21986);

                Microsoft.CodeAnalysis.IOperation[]
                f_25010_21948_21973()
                {
                    var return_v = Array.Empty<IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21948, 21973);
                    return return_v;
                }


                int
                f_25010_21916_21974(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                operation, Microsoft.CodeAnalysis.IOperation[]
                additionalChildren)
                {
                    this_param.VisitMemberReference(operation, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)additionalChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 21916, 21974);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 21821, 21986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 21821, 21986);
            }
        }

        private void VisitMemberReference(IMemberReferenceOperation operation, IEnumerable<IOperation> additionalChildren)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 21998, 23036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22137, 22170);

                f_25010_22137_22169(f_25010_22152_22168(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22186, 22219);

                IEnumerable<IOperation>
                children
                = default(IEnumerable<IOperation>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22235, 22964) || true) && (f_25010_22239_22257(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 22235, 22964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22299, 22366);

                    children = f_25010_22310_22365(new[] { f_25010_22318_22336(operation) }, additionalChildren);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22572, 22853) || true) && (f_25010_22576_22601(f_25010_22576_22592(operation)) && (DynAbs.Tracing.TraceSender.Expression_True(25010, 22576, 22675) && f_25010_22626_22644(operation) is IInstanceReferenceOperation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 22572, 22853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22717, 22834);

                        f_25010_22717_22833(f_25010_22730_22759(f_25010_22730_22748(operation)), $"Implicit {nameof(IInstanceReferenceOperation)} on {f_25010_22814_22830(operation)}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 22572, 22853);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 22235, 22964);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 22235, 22964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22919, 22949);

                    children = additionalChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 22235, 22964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 22980, 23025);

                f_25010_22980_23024(children, f_25010_23005_23023(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 21998, 23036);

                Microsoft.CodeAnalysis.ISymbol
                f_25010_22152_22168(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22152, 22168);
                    return return_v;
                }


                int
                f_25010_22137_22169(Microsoft.CodeAnalysis.ISymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 22137, 22169);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_22239_22257(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22239, 22257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_22318_22336(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22318, 22336);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_22310_22365(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 22310, 22365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_22576_22592(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22576, 22592);
                    return return_v;
                }


                bool
                f_25010_22576_22601(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22576, 22601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_22626_22644(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22626, 22644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_22730_22748(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22730, 22748);
                    return return_v;
                }


                bool
                f_25010_22730_22759(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22730, 22759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_22814_22830(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 22814, 22830);
                    return return_v;
                }


                int
                f_25010_22717_22833(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 22717, 22833);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_23005_23023(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23005, 23023);
                    return return_v;
                }


                bool
                f_25010_22980_23024(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 22980, 23024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 21998, 23036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 21998, 23036);
            }
        }

        public override void VisitFieldReference(IFieldReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 23048, 23386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23149, 23208);

                f_25010_23149_23207(OperationKind.FieldReference, f_25010_23192_23206(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23222, 23254);

                f_25010_23222_23253(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23270, 23317);

                f_25010_23270_23316(f_25010_23282_23298(operation), f_25010_23300_23315(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23331, 23375);

                var
                isDeclaration = f_25010_23351_23374(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 23048, 23386);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_23192_23206(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23192, 23206);
                    return return_v;
                }


                int
                f_25010_23149_23207(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23149, 23207);
                    return 0;
                }


                int
                f_25010_23222_23253(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                operation)
                {
                    this_param.VisitMemberReference((Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23222, 23253);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_23282_23298(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23282, 23298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol
                f_25010_23300_23315(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23300, 23315);
                    return return_v;
                }


                int
                f_25010_23270_23316(Microsoft.CodeAnalysis.ISymbol
                expected, Microsoft.CodeAnalysis.IFieldSymbol
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23270, 23316);
                    return 0;
                }


                bool
                f_25010_23351_23374(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
                this_param)
                {
                    var return_v = this_param.IsDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23351, 23374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 23048, 23386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 23048, 23386);
            }
        }

        public override void VisitMethodReference(IMethodReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 23398, 23732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23501, 23561);

                f_25010_23501_23560(OperationKind.MethodReference, f_25010_23545_23559(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23575, 23607);

                f_25010_23575_23606(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23623, 23671);

                f_25010_23623_23670(f_25010_23635_23651(operation), f_25010_23653_23669(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23685, 23721);

                var
                isVirtual = f_25010_23701_23720(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 23398, 23732);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_23545_23559(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23545, 23559);
                    return return_v;
                }


                int
                f_25010_23501_23560(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23501, 23560);
                    return 0;
                }


                int
                f_25010_23575_23606(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                operation)
                {
                    this_param.VisitMemberReference((Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23575, 23606);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_23635_23651(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23635, 23651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_23653_23669(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23653, 23669);
                    return return_v;
                }


                int
                f_25010_23623_23670(Microsoft.CodeAnalysis.ISymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23623, 23670);
                    return 0;
                }


                bool
                f_25010_23701_23720(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23701, 23720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 23398, 23732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 23398, 23732);
            }
        }

        public override void VisitPropertyReference(IPropertyReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 23744, 24057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23851, 23913);

                f_25010_23851_23912(OperationKind.PropertyReference, f_25010_23897_23911(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23927, 23980);

                f_25010_23927_23979(this, operation, f_25010_23959_23978(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 23996, 24046);

                f_25010_23996_24045(f_25010_24008_24024(operation), f_25010_24026_24044(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 23744, 24057);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_23897_23911(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23897, 23911);
                    return return_v;
                }


                int
                f_25010_23851_23912(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23851, 23912);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_23959_23978(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 23959, 23978);
                    return return_v;
                }


                int
                f_25010_23927_23979(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                operation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                additionalChildren)
                {
                    this_param.VisitMemberReference((Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)additionalChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23927, 23979);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_24008_24024(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24008, 24024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_25010_24026_24044(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Property;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24026, 24044);
                    return return_v;
                }


                int
                f_25010_23996_24045(Microsoft.CodeAnalysis.ISymbol
                expected, Microsoft.CodeAnalysis.IPropertySymbol
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 23996, 24045);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 23744, 24057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 23744, 24057);
            }
        }

        public override void VisitEventReference(IEventReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 24069, 24349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24170, 24229);

                f_25010_24170_24228(OperationKind.EventReference, f_25010_24213_24227(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24243, 24275);

                f_25010_24243_24274(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24291, 24338);

                f_25010_24291_24337(f_25010_24303_24319(operation), f_25010_24321_24336(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 24069, 24349);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_24213_24227(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24213, 24227);
                    return return_v;
                }


                int
                f_25010_24170_24228(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24170, 24228);
                    return 0;
                }


                int
                f_25010_24243_24274(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
                operation)
                {
                    this_param.VisitMemberReference((Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24243, 24274);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_24303_24319(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24303, 24319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IEventSymbol
                f_25010_24321_24336(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
                this_param)
                {
                    var return_v = this_param.Event;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24321, 24336);
                    return return_v;
                }


                int
                f_25010_24291_24337(Microsoft.CodeAnalysis.ISymbol
                expected, Microsoft.CodeAnalysis.IEventSymbol
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24291, 24337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 24069, 24349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 24069, 24349);
            }
        }

        public override void VisitEventAssignment(IEventAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 24361, 24684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24464, 24524);

                f_25010_24464_24523(OperationKind.EventAssignment, f_25010_24508_24522(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24538, 24564);

                var
                adds = f_25010_24549_24563(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24578, 24673);

                f_25010_24578_24672(new[] { f_25010_24601_24625(operation), f_25010_24627_24649(operation) }, f_25010_24653_24671(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 24361, 24684);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_24508_24522(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24508, 24522);
                    return return_v;
                }


                int
                f_25010_24464_24523(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24464, 24523);
                    return 0;
                }


                bool
                f_25010_24549_24563(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Adds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24549, 24563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_24601_24625(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
                this_param)
                {
                    var return_v = this_param.EventReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24601, 24625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_24627_24649(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
                this_param)
                {
                    var return_v = this_param.HandlerValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24627, 24649);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_24653_24671(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24653, 24671);
                    return return_v;
                }


                bool
                f_25010_24578_24672(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24578, 24672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 24361, 24684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 24361, 24684);
            }
        }

        public override void VisitConditionalAccess(IConditionalAccessOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 24696, 25024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24803, 24865);

                f_25010_24803_24864(OperationKind.ConditionalAccess, f_25010_24849_24863(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24879, 24910);

                f_25010_24879_24909(f_25010_24894_24908(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 24924, 25013);

                f_25010_24924_25012(new[] { f_25010_24947_24966(operation), f_25010_24968_24989(operation) }, f_25010_24993_25011(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 24696, 25024);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_24849_24863(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24849, 24863);
                    return return_v;
                }


                int
                f_25010_24803_24864(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24803, 24864);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_24894_24908(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24894, 24908);
                    return return_v;
                }


                int
                f_25010_24879_24909(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24879, 24909);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_24947_24966(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24947, 24966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_24968_24989(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24968, 24989);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_24993_25011(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 24993, 25011);
                    return return_v;
                }


                bool
                f_25010_24924_25012(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 24924, 25012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 24696, 25024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 24696, 25024);
            }
        }

        public override void VisitConditionalAccessInstance(IConditionalAccessInstanceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 25036, 25287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25159, 25229);

                f_25010_25159_25228(OperationKind.ConditionalAccessInstance, f_25010_25213_25227(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25243, 25276);

                f_25010_25243_25275(f_25010_25256_25274(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 25036, 25287);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_25213_25227(Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25213, 25227);
                    return return_v;
                }


                int
                f_25010_25159_25228(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25159, 25228);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_25256_25274(Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25256, 25274);
                    return return_v;
                }


                int
                f_25010_25243_25275(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25243, 25275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 25036, 25287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 25036, 25287);
            }
        }

        internal override void VisitPlaceholder(IPlaceholderOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 25299, 25503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25396, 25445);

                f_25010_25396_25444(OperationKind.None, f_25010_25429_25443(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25459, 25492);

                f_25010_25459_25491(f_25010_25472_25490(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 25299, 25503);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_25429_25443(Microsoft.CodeAnalysis.Operations.IPlaceholderOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25429, 25443);
                    return return_v;
                }


                int
                f_25010_25396_25444(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25396, 25444);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_25472_25490(Microsoft.CodeAnalysis.Operations.IPlaceholderOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25472, 25490);
                    return return_v;
                }


                int
                f_25010_25459_25491(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25459, 25491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 25299, 25503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 25299, 25503);
            }
        }

        public override void VisitUnaryOperator(IUnaryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 25515, 26035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25606, 25664);

                f_25010_25606_25663(OperationKind.UnaryOperator, f_25010_25648_25662(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25678, 25728);

                f_25010_25678_25727(OperationKind.Unary, f_25010_25712_25726(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25742, 25788);

                var
                operatorMethod = f_25010_25763_25787(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25802, 25850);

                var
                unaryOperationKind = f_25010_25827_25849(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25864, 25898);

                var
                isLifted = f_25010_25879_25897(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25912, 25948);

                var
                isChecked = f_25010_25928_25947(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 25964, 26024);

                f_25010_25964_26023(f_25010_25976_25993(operation), f_25010_25995_26022(f_25010_25995_26013(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 25515, 26035);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_25648_25662(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25648, 25662);
                    return return_v;
                }


                int
                f_25010_25606_25663(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25606, 25663);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_25712_25726(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25712, 25726);
                    return return_v;
                }


                int
                f_25010_25678_25727(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25678, 25727);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_25763_25787(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25763, 25787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.UnaryOperatorKind
                f_25010_25827_25849(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25827, 25849);
                    return return_v;
                }


                bool
                f_25010_25879_25897(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.IsLifted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25879, 25897);
                    return return_v;
                }


                bool
                f_25010_25928_25947(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25928, 25947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_25976_25993(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25976, 25993);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_25995_26013(Microsoft.CodeAnalysis.Operations.IUnaryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 25995, 26013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_25995_26022(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25995, 26022);
                    return return_v;
                }


                int
                f_25010_25964_26023(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 25964, 26023);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 25515, 26035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 25515, 26035);
            }
        }

        public override void VisitBinaryOperator(IBinaryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 26047, 26751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26140, 26199);

                f_25010_26140_26198(OperationKind.BinaryOperator, f_25010_26183_26197(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26213, 26264);

                f_25010_26213_26263(OperationKind.Binary, f_25010_26248_26262(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26278, 26324);

                var
                operatorMethod = f_25010_26299_26323(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26338, 26413);

                var
                unaryOperatorMethod = f_25010_26364_26412(((BinaryOperation)operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26427, 26476);

                var
                binaryOperationKind = f_25010_26453_26475(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26490, 26524);

                var
                isLifted = f_25010_26505_26523(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26538, 26574);

                var
                isChecked = f_25010_26554_26573(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26588, 26632);

                var
                isCompareText = f_25010_26608_26631(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26648, 26740);

                f_25010_26648_26739(new[] { f_25010_26671_26692(operation), f_25010_26694_26716(operation) }, f_25010_26720_26738(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 26047, 26751);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_26183_26197(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26183, 26197);
                    return return_v;
                }


                int
                f_25010_26140_26198(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 26140, 26198);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_26248_26262(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26248, 26262);
                    return return_v;
                }


                int
                f_25010_26213_26263(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 26213, 26263);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_26299_26323(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26299, 26323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_26364_26412(Microsoft.CodeAnalysis.Operations.BinaryOperation
                this_param)
                {
                    var return_v = this_param.UnaryOperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26364, 26412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_26453_26475(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26453, 26475);
                    return return_v;
                }


                bool
                f_25010_26505_26523(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.IsLifted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26505, 26523);
                    return return_v;
                }


                bool
                f_25010_26554_26573(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26554, 26573);
                    return return_v;
                }


                bool
                f_25010_26608_26631(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.IsCompareText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26608, 26631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_26671_26692(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26671, 26692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_26694_26716(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26694, 26716);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_26720_26738(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26720, 26738);
                    return return_v;
                }


                bool
                f_25010_26648_26739(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 26648, 26739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 26047, 26751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 26047, 26751);
            }
        }

        public override void VisitTupleBinaryOperator(ITupleBinaryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 26763, 27182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26866, 26930);

                f_25010_26866_26929(OperationKind.TupleBinaryOperator, f_25010_26914_26928(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 26944, 27000);

                f_25010_26944_26999(OperationKind.TupleBinary, f_25010_26984_26998(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27014, 27063);

                var
                binaryOperationKind = f_25010_27040_27062(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27079, 27171);

                f_25010_27079_27170(new[] { f_25010_27102_27123(operation), f_25010_27125_27147(operation) }, f_25010_27151_27169(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 26763, 27182);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_26914_26928(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26914, 26928);
                    return return_v;
                }


                int
                f_25010_26866_26929(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 26866, 26929);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_26984_26998(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 26984, 26998);
                    return return_v;
                }


                int
                f_25010_26944_26999(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 26944, 26999);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_27040_27062(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27040, 27062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_27102_27123(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27102, 27123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_27125_27147(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27125, 27147);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_27151_27169(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27151, 27169);
                    return return_v;
                }


                bool
                f_25010_27079_27170(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 27079, 27170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 26763, 27182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 26763, 27182);
            }
        }

        public override void VisitConversion(IConversionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 27194, 28464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27287, 27342);

                f_25010_27287_27341(OperationKind.Conversion, f_25010_27326_27340(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27356, 27402);

                var
                operatorMethod = f_25010_27377_27401(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27416, 27454);

                var
                conversion = f_25010_27433_27453(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27468, 27504);

                var
                isChecked = f_25010_27484_27503(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27518, 27554);

                var
                isTryCast = f_25010_27534_27553(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27570, 28377);

                switch (f_25010_27578_27596(operation))
                {

                    case LanguageNames.CSharp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 27570, 28377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27678, 27764);

                        CSharp.Conversion
                        csharpConversion = f_25010_27715_27763(operation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27786, 27885);

                        f_25010_27786_27884(() => VisualBasic.VisualBasicExtensions.GetConversion(operation));
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 27907, 27913);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 27570, 28377);

                    case LanguageNames.VisualBasic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 27570, 28377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 27984, 28090);

                        VisualBasic.Conversion
                        visualBasicConversion = f_25010_28031_28089(operation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28112, 28201);

                        f_25010_28112_28200(() => CSharp.CSharpExtensions.GetConversion(operation));
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 28223, 28229);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 27570, 28377);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 27570, 28377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28277, 28334);

                        f_25010_28277_28333($"Language {f_25010_28300_28318(operation)} is unknown!");
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 28356, 28362);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 27570, 28377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28393, 28453);

                f_25010_28393_28452(f_25010_28405_28422(operation), f_25010_28424_28451(f_25010_28424_28442(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 27194, 28464);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_27326_27340(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27326, 27340);
                    return return_v;
                }


                int
                f_25010_27287_27341(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 27287, 27341);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_27377_27401(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27377, 27401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_27433_27453(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27433, 27453);
                    return return_v;
                }


                bool
                f_25010_27484_27503(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27484, 27503);
                    return return_v;
                }


                bool
                f_25010_27534_27553(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.IsTryCast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27534, 27553);
                    return return_v;
                }


                string
                f_25010_27578_27596(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 27578, 27596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_25010_27715_27763(Microsoft.CodeAnalysis.Operations.IConversionOperation
                conversionExpression)
                {
                    var return_v = CSharp.CSharpExtensions.GetConversion(conversionExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 27715, 27763);
                    return return_v;
                }


                System.ArgumentException
                f_25010_27786_27884(System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 27786, 27884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.Conversion
                f_25010_28031_28089(Microsoft.CodeAnalysis.Operations.IConversionOperation
                conversionExpression)
                {
                    var return_v = VisualBasic.VisualBasicExtensions.GetConversion(conversionExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28031, 28089);
                    return return_v;
                }


                System.ArgumentException
                f_25010_28112_28200(System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28112, 28200);
                    return return_v;
                }


                string
                f_25010_28300_28318(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28300, 28318);
                    return return_v;
                }


                int
                f_25010_28277_28333(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28277, 28333);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28405_28422(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28405, 28422);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_28424_28442(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28424, 28442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28424_28451(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28424, 28451);
                    return return_v;
                }


                int
                f_25010_28393_28452(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28393, 28452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 27194, 28464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 27194, 28464);
            }
        }

        public override void VisitConditional(IConditionalOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 28476, 29036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28571, 28627);

                f_25010_28571_28626(OperationKind.Conditional, f_25010_28611_28625(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28641, 28670);

                bool
                isRef = f_25010_28654_28669(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28686, 29025) || true) && (f_25010_28690_28709(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 28686, 29025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28751, 28858);

                    f_25010_28751_28857(new[] { f_25010_28774_28793(operation), f_25010_28795_28813(operation), f_25010_28815_28834(operation) }, f_25010_28838_28856(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 28686, 29025);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 28686, 29025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 28924, 29010);

                    f_25010_28924_29009(new[] { f_25010_28947_28966(operation), f_25010_28968_28986(operation) }, f_25010_28990_29008(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 28686, 29025);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 28476, 29036);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_28611_28625(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28611, 28625);
                    return return_v;
                }


                int
                f_25010_28571_28626(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28571, 28626);
                    return 0;
                }


                bool
                f_25010_28654_28669(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28654, 28669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_28690_28709(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28690, 28709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28774_28793(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28774, 28793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28795_28813(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28795, 28813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28815_28834(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28815, 28834);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_28838_28856(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28838, 28856);
                    return return_v;
                }


                bool
                f_25010_28751_28857(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28751, 28857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28947_28966(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28947, 28966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_28968_28986(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28968, 28986);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_28990_29008(Microsoft.CodeAnalysis.Operations.IConditionalOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 28990, 29008);
                    return return_v;
                }


                bool
                f_25010_28924_29009(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 28924, 29009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 28476, 29036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 28476, 29036);
            }
        }

        public override void VisitCoalesce(ICoalesceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 29048, 29359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29137, 29190);

                f_25010_29137_29189(OperationKind.Coalesce, f_25010_29174_29188(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29204, 29286);

                f_25010_29204_29285(new[] { f_25010_29227_29242(operation), f_25010_29244_29262(operation) }, f_25010_29266_29284(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29300, 29348);

                var
                valueConversion = f_25010_29322_29347(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 29048, 29359);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_29174_29188(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29174, 29188);
                    return return_v;
                }


                int
                f_25010_29137_29189(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29137, 29189);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29227_29242(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29227, 29242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29244_29262(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
                this_param)
                {
                    var return_v = this_param.WhenNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29244, 29262);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_29266_29284(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29266, 29284);
                    return return_v;
                }


                bool
                f_25010_29204_29285(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29204, 29285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_29322_29347(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
                this_param)
                {
                    var return_v = this_param.ValueConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29322, 29347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 29048, 29359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 29048, 29359);
            }
        }

        public override void VisitCoalesceAssignment(ICoalesceAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 29371, 29648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29480, 29543);

                f_25010_29480_29542(OperationKind.CoalesceAssignment, f_25010_29527_29541(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29557, 29637);

                f_25010_29557_29636(new[] { f_25010_29580_29596(operation), f_25010_29598_29613(operation) }, f_25010_29617_29635(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 29371, 29648);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_29527_29541(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29527, 29541);
                    return return_v;
                }


                int
                f_25010_29480_29542(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29480, 29542);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29580_29596(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29580, 29596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29598_29613(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29598, 29613);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_29617_29635(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29617, 29635);
                    return return_v;
                }


                bool
                f_25010_29557_29636(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29557, 29636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 29371, 29648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 29371, 29648);
            }
        }

        public override void VisitIsType(IIsTypeOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 29660, 29989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29745, 29796);

                f_25010_29745_29795(OperationKind.IsType, f_25010_29780_29794(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29810, 29848);

                f_25010_29810_29847(f_25010_29825_29846(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29862, 29899);

                bool
                isNegated = f_25010_29879_29898(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 29913, 29978);

                f_25010_29913_29977(f_25010_29925_29947(operation), f_25010_29949_29976(f_25010_29949_29967(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 29660, 29989);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_29780_29794(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29780, 29794);
                    return return_v;
                }


                int
                f_25010_29745_29795(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29745, 29795);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_29825_29846(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29825, 29846);
                    return return_v;
                }


                int
                f_25010_29810_29847(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29810, 29847);
                    return 0;
                }


                bool
                f_25010_29879_29898(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
                this_param)
                {
                    var return_v = this_param.IsNegated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29879, 29898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29925_29947(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
                this_param)
                {
                    var return_v = this_param.ValueOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29925, 29947);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_29949_29967(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 29949, 29967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_29949_29976(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29949, 29976);
                    return return_v;
                }


                int
                f_25010_29913_29977(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 29913, 29977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 29660, 29989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 29660, 29989);
            }
        }

        public override void VisitSizeOf(ISizeOfOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 30001, 30247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30086, 30137);

                f_25010_30086_30136(OperationKind.SizeOf, f_25010_30121_30135(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30151, 30189);

                f_25010_30151_30188(f_25010_30166_30187(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30203, 30236);

                f_25010_30203_30235(f_25010_30216_30234(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 30001, 30247);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_30121_30135(Microsoft.CodeAnalysis.Operations.ISizeOfOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30121, 30135);
                    return return_v;
                }


                int
                f_25010_30086_30136(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30086, 30136);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_30166_30187(Microsoft.CodeAnalysis.Operations.ISizeOfOperation
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30166, 30187);
                    return return_v;
                }


                int
                f_25010_30151_30188(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30151, 30188);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_30216_30234(Microsoft.CodeAnalysis.Operations.ISizeOfOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30216, 30234);
                    return return_v;
                }


                int
                f_25010_30203_30235(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30203, 30235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 30001, 30247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 30001, 30247);
            }
        }

        public override void VisitTypeOf(ITypeOfOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 30259, 30505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30344, 30395);

                f_25010_30344_30394(OperationKind.TypeOf, f_25010_30379_30393(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30409, 30447);

                f_25010_30409_30446(f_25010_30424_30445(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30461, 30494);

                f_25010_30461_30493(f_25010_30474_30492(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 30259, 30505);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_30379_30393(Microsoft.CodeAnalysis.Operations.ITypeOfOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30379, 30393);
                    return return_v;
                }


                int
                f_25010_30344_30394(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30344, 30394);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_30424_30445(Microsoft.CodeAnalysis.Operations.ITypeOfOperation
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30424, 30445);
                    return return_v;
                }


                int
                f_25010_30409_30446(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30409, 30446);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_30474_30492(Microsoft.CodeAnalysis.Operations.ITypeOfOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30474, 30492);
                    return return_v;
                }


                int
                f_25010_30461_30493(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30461, 30493);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 30259, 30505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 30259, 30505);
            }
        }

        public override void VisitAnonymousFunction(IAnonymousFunctionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 30517, 30815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30624, 30686);

                f_25010_30624_30685(OperationKind.AnonymousFunction, f_25010_30670_30684(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30700, 30733);

                f_25010_30700_30732(f_25010_30715_30731(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30747, 30804);

                f_25010_30747_30803(f_25010_30759_30773(operation), f_25010_30775_30802(f_25010_30775_30793(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 30517, 30815);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_30670_30684(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30670, 30684);
                    return return_v;
                }


                int
                f_25010_30624_30685(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30624, 30685);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_30715_30731(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30715, 30731);
                    return return_v;
                }


                int
                f_25010_30700_30732(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30700, 30732);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_30759_30773(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30759, 30773);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_30775_30793(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30775, 30793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_30775_30802(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30775, 30802);
                    return return_v;
                }


                int
                f_25010_30747_30803(Microsoft.CodeAnalysis.Operations.IBlockOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30747, 30803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 30517, 30815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 30517, 30815);
            }
        }

        public override void VisitFlowAnonymousFunction(IFlowAnonymousFunctionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 30827, 31113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 30942, 31008);

                f_25010_30942_31007(OperationKind.FlowAnonymousFunction, f_25010_30992_31006(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31022, 31055);

                f_25010_31022_31054(f_25010_31037_31053(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31069, 31102);

                f_25010_31069_31101(f_25010_31082_31100(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 30827, 31113);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_30992_31006(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 30992, 31006);
                    return return_v;
                }


                int
                f_25010_30942_31007(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 30942, 31007);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_31037_31053(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31037, 31053);
                    return return_v;
                }


                int
                f_25010_31022_31054(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31022, 31054);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_31082_31100(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31082, 31100);
                    return return_v;
                }


                int
                f_25010_31069_31101(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31069, 31101);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 30827, 31113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 30827, 31113);
            }
        }

        public override void VisitLocalFunction(ILocalFunctionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 31125, 32025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31224, 31282);

                f_25010_31224_31281(OperationKind.LocalFunction, f_25010_31266_31280(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31296, 31329);

                f_25010_31296_31328(f_25010_31311_31327(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31345, 32014) || true) && (f_25010_31349_31363(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 31345, 32014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31405, 31458);

                    var
                    children = f_25010_31420_31457(f_25010_31420_31438(operation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31476, 31517);

                    f_25010_31476_31516(f_25010_31488_31502(operation), children[0]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31535, 31847) || true) && (f_25010_31539_31560(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 31535, 31847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31610, 31658);

                        f_25010_31610_31657(f_25010_31622_31643(operation), children[1]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31680, 31713);

                        f_25010_31680_31712(2, children.Length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 31535, 31847);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 31535, 31847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31795, 31828);

                        f_25010_31795_31827(1, children.Length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 31535, 31847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 31345, 32014);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 31345, 32014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31913, 31948);

                    f_25010_31913_31947(f_25010_31925_31946(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 31966, 31999);

                    f_25010_31966_31998(f_25010_31979_31997(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 31345, 32014);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 31125, 32025);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_31266_31280(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31266, 31280);
                    return return_v;
                }


                int
                f_25010_31224_31281(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31224, 31281);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_25010_31311_31327(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31311, 31327);
                    return return_v;
                }


                int
                f_25010_31296_31328(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31296, 31328);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_31349_31363(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31349, 31363);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_31420_31438(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31420, 31438);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_31420_31457(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31420, 31457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_31488_31502(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31488, 31502);
                    return return_v;
                }


                int
                f_25010_31476_31516(Microsoft.CodeAnalysis.Operations.IBlockOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31476, 31516);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_31539_31560(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.IgnoredBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31539, 31560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_31622_31643(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.IgnoredBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31622, 31643);
                    return return_v;
                }


                int
                f_25010_31610_31657(Microsoft.CodeAnalysis.Operations.IBlockOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31610, 31657);
                    return 0;
                }


                int
                f_25010_31680_31712(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31680, 31712);
                    return 0;
                }


                int
                f_25010_31795_31827(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31795, 31827);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_31925_31946(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.IgnoredBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31925, 31946);
                    return return_v;
                }


                int
                f_25010_31913_31947(Microsoft.CodeAnalysis.Operations.IBlockOperation?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31913, 31947);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_31979_31997(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 31979, 31997);
                    return return_v;
                }


                int
                f_25010_31966_31998(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 31966, 31998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 31125, 32025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 31125, 32025);
            }
        }

        public override void VisitLiteral(ILiteralOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 32037, 32234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32124, 32176);

                f_25010_32124_32175(OperationKind.Literal, f_25010_32160_32174(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32190, 32223);

                f_25010_32190_32222(f_25010_32203_32221(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 32037, 32234);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_32160_32174(Microsoft.CodeAnalysis.Operations.ILiteralOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32160, 32174);
                    return return_v;
                }


                int
                f_25010_32124_32175(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32124, 32175);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_32203_32221(Microsoft.CodeAnalysis.Operations.ILiteralOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32203, 32221);
                    return return_v;
                }


                int
                f_25010_32190_32222(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32190, 32222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 32037, 32234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 32037, 32234);
            }
        }

        public override void VisitAwait(IAwaitOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 32246, 32466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32329, 32379);

                f_25010_32329_32378(OperationKind.Await, f_25010_32363_32377(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32393, 32455);

                f_25010_32393_32454(f_25010_32405_32424(operation), f_25010_32426_32453(f_25010_32426_32444(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 32246, 32466);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_32363_32377(Microsoft.CodeAnalysis.Operations.IAwaitOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32363, 32377);
                    return return_v;
                }


                int
                f_25010_32329_32378(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32329, 32378);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_32405_32424(Microsoft.CodeAnalysis.Operations.IAwaitOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32405, 32424);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_32426_32444(Microsoft.CodeAnalysis.Operations.IAwaitOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32426, 32444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_32426_32453(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32426, 32453);
                    return return_v;
                }


                int
                f_25010_32393_32454(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32393, 32454);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 32246, 32466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 32246, 32466);
            }
        }

        public override void VisitNameOf(INameOfOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 32478, 32700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32563, 32614);

                f_25010_32563_32613(OperationKind.NameOf, f_25010_32598_32612(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32628, 32689);

                f_25010_32628_32688(f_25010_32640_32658(operation), f_25010_32660_32687(f_25010_32660_32678(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 32478, 32700);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_32598_32612(Microsoft.CodeAnalysis.Operations.INameOfOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32598, 32612);
                    return return_v;
                }


                int
                f_25010_32563_32613(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32563, 32613);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_32640_32658(Microsoft.CodeAnalysis.Operations.INameOfOperation
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32640, 32658);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_32660_32678(Microsoft.CodeAnalysis.Operations.INameOfOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32660, 32678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_32660_32687(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32660, 32687);
                    return return_v;
                }


                int
                f_25010_32628_32688(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32628, 32688);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 32478, 32700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 32478, 32700);
            }
        }

        public override void VisitThrow(IThrowOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 32712, 33111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32795, 32845);

                f_25010_32795_32844(OperationKind.Throw, f_25010_32829_32843(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32859, 33100) || true) && (f_25010_32863_32882(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 32859, 33100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 32924, 32957);

                    f_25010_32924_32956(f_25010_32937_32955(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 32859, 33100);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 32859, 33100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33023, 33085);

                    f_25010_33023_33084(f_25010_33035_33054(operation), f_25010_33056_33083(f_25010_33056_33074(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 32859, 33100);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 32712, 33111);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_32829_32843(Microsoft.CodeAnalysis.Operations.IThrowOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32829, 32843);
                    return return_v;
                }


                int
                f_25010_32795_32844(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32795, 32844);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_32863_32882(Microsoft.CodeAnalysis.Operations.IThrowOperation
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32863, 32882);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_32937_32955(Microsoft.CodeAnalysis.Operations.IThrowOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 32937, 32955);
                    return return_v;
                }


                int
                f_25010_32924_32956(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 32924, 32956);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_33035_33054(Microsoft.CodeAnalysis.Operations.IThrowOperation
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33035, 33054);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_33056_33074(Microsoft.CodeAnalysis.Operations.IThrowOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33056, 33074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_33056_33083(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33056, 33083);
                    return return_v;
                }


                int
                f_25010_33023_33084(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33023, 33084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 32712, 33111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 32712, 33111);
            }
        }

        public override void VisitAddressOf(IAddressOfOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 33123, 33355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33214, 33268);

                f_25010_33214_33267(OperationKind.AddressOf, f_25010_33252_33266(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33282, 33344);

                f_25010_33282_33343(f_25010_33294_33313(operation), f_25010_33315_33342(f_25010_33315_33333(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 33123, 33355);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_33252_33266(Microsoft.CodeAnalysis.Operations.IAddressOfOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33252, 33266);
                    return return_v;
                }


                int
                f_25010_33214_33267(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33214, 33267);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_33294_33313(Microsoft.CodeAnalysis.Operations.IAddressOfOperation
                this_param)
                {
                    var return_v = this_param.Reference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33294, 33313);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_33315_33333(Microsoft.CodeAnalysis.Operations.IAddressOfOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33315, 33333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_33315_33342(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33315, 33342);
                    return return_v;
                }


                int
                f_25010_33282_33343(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33282, 33343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 33123, 33355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 33123, 33355);
            }
        }

        public override void VisitObjectCreation(IObjectCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 33367, 34245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33468, 33527);

                f_25010_33468_33526(OperationKind.ObjectCreation, f_25010_33511_33525(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33541, 33581);

                var
                constructor = f_25010_33559_33580(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33700, 33946) || true) && (f_25010_33704_33731_M(!f_25010_33705_33719(operation).IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 33700, 33946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33765, 33793);

                    f_25010_33765_33792(constructor);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33813, 33931) || true) && (constructor == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 33813, 33931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33878, 33912);

                        f_25010_33878_33911(f_25010_33891_33910(operation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 33813, 33931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 33700, 33946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 33962, 34017);

                IEnumerable<IOperation>
                children = f_25010_33997_34016(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34031, 34173) || true) && (f_25010_34035_34056(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 34031, 34173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34098, 34158);

                    children = f_25010_34109_34157(children, new[] { f_25010_34133_34154(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 34031, 34173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34189, 34234);

                f_25010_34189_34233(children, f_25010_34214_34232(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 33367, 34245);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_33511_33525(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33511, 33525);
                    return return_v;
                }


                int
                f_25010_33468_33526(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33468, 33526);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_33559_33580(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33559, 33580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_33705_33719(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33705, 33719);
                    return return_v;
                }


                bool
                f_25010_33704_33731_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33704, 33731);
                    return return_v;
                }


                int
                f_25010_33765_33792(Microsoft.CodeAnalysis.IMethodSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33765, 33792);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_33891_33910(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33891, 33910);
                    return return_v;
                }


                int
                f_25010_33878_33911(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 33878, 33911);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_33997_34016(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 33997, 34016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_25010_34035_34056(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34035, 34056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_34133_34154(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34133, 34154);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_34109_34157(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34109, 34157);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_34214_34232(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34214, 34232);
                    return return_v;
                }


                bool
                f_25010_34189_34233(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34189, 34233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 33367, 34245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 33367, 34245);
            }
        }

        public override void VisitAnonymousObjectCreation(IAnonymousObjectCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 34257, 35100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34376, 34444);

                f_25010_34376_34443(OperationKind.AnonymousObjectCreation, f_25010_34428_34442(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34458, 34517);

                f_25010_34458_34516(f_25010_34473_34495(operation), f_25010_34497_34515(operation));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34531, 35089);
                    foreach (var initializer in f_25010_34559_34581_I(f_25010_34559_34581(operation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 34531, 35089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34615, 34678);

                        var
                        simpleAssignment = (ISimpleAssignmentOperation)initializer
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34696, 34773);

                        var
                        propertyReference = (IPropertyReferenceOperation)f_25010_34749_34772(simpleAssignment)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34791, 34833);

                        f_25010_34791_34832(f_25010_34804_34831(propertyReference));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34851, 34930);

                        f_25010_34851_34929(OperationKind.InstanceReference, f_25010_34897_34928(f_25010_34897_34923(propertyReference)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 34948, 35074);

                        f_25010_34948_35073(InstanceReferenceKind.ImplicitReceiver, f_25010_35001_35072(((IInstanceReferenceOperation)f_25010_35031_35057(propertyReference))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 34531, 35089);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 559);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 34257, 35100);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_34428_34442(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34428, 34442);
                    return return_v;
                }


                int
                f_25010_34376_34443(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34376, 34443);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_34473_34495(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34473, 34495);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_34497_34515(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34497, 34515);
                    return return_v;
                }


                int
                f_25010_34458_34516(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34458, 34516);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_34559_34581(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34559, 34581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_34749_34772(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34749, 34772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_34804_34831(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34804, 34831);
                    return return_v;
                }


                int
                f_25010_34791_34832(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34791, 34832);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_34897_34923(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34897, 34923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_34897_34928(Microsoft.CodeAnalysis.IOperation?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 34897, 34928);
                    return return_v;
                }


                int
                f_25010_34851_34929(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34851, 34929);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_35031_35057(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35031, 35057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                f_25010_35001_35072(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.ReferenceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35001, 35072);
                    return return_v;
                }


                int
                f_25010_34948_35073(Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                expected, Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34948, 35073);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_34559_34581_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 34559, 34581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 34257, 35100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 34257, 35100);
            }
        }

        public override void VisitDynamicObjectCreation(IDynamicObjectCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 35112, 35592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35227, 35293);

                f_25010_35227_35292(OperationKind.DynamicObjectCreation, f_25010_35277_35291(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35309, 35364);

                IEnumerable<IOperation>
                children = f_25010_35344_35363(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35378, 35520) || true) && (f_25010_35382_35403(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 35378, 35520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35445, 35505);

                    children = f_25010_35456_35504(children, new[] { f_25010_35480_35501(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 35378, 35520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35536, 35581);

                f_25010_35536_35580(children, f_25010_35561_35579(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 35112, 35592);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_35277_35291(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35277, 35291);
                    return return_v;
                }


                int
                f_25010_35227_35292(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35227, 35292);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_35344_35363(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35344, 35363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_25010_35382_35403(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35382, 35403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_35480_35501(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35480, 35501);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_35456_35504(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35456, 35504);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_35561_35579(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35561, 35579);
                    return return_v;
                }


                bool
                f_25010_35536_35580(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35536, 35580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 35112, 35592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 35112, 35592);
            }
        }

        public override void VisitDynamicInvocation(IDynamicInvocationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 35604, 35892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35711, 35773);

                f_25010_35711_35772(OperationKind.DynamicInvocation, f_25010_35757_35771(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 35787, 35881);

                f_25010_35787_35880(f_25010_35802_35859(new[] { f_25010_35810_35829(operation) }, f_25010_35839_35858(operation)), f_25010_35861_35879(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 35604, 35892);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_35757_35771(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35757, 35771);
                    return return_v;
                }


                int
                f_25010_35711_35772(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35711, 35772);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_35810_35829(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35810, 35829);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_35839_35858(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35839, 35858);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_35802_35859(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35802, 35859);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_35861_35879(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 35861, 35879);
                    return return_v;
                }


                bool
                f_25010_35787_35880(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 35787, 35880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 35604, 35892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 35604, 35892);
            }
        }

        public override void VisitDynamicIndexerAccess(IDynamicIndexerAccessOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 35904, 36201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36017, 36082);

                f_25010_36017_36081(OperationKind.DynamicIndexerAccess, f_25010_36066_36080(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36096, 36190);

                f_25010_36096_36189(f_25010_36111_36168(new[] { f_25010_36119_36138(operation) }, f_25010_36148_36167(operation)), f_25010_36170_36188(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 35904, 36201);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_36066_36080(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36066, 36080);
                    return return_v;
                }


                int
                f_25010_36017_36081(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36017, 36081);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_36119_36138(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36119, 36138);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_36148_36167(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36148, 36167);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_36111_36168(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36111, 36168);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_36170_36188(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36170, 36188);
                    return return_v;
                }


                bool
                f_25010_36096_36189(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36096, 36189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 35904, 36201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 35904, 36201);
            }
        }

        public override void VisitObjectOrCollectionInitializer(IObjectOrCollectionInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 36213, 36502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36344, 36418);

                f_25010_36344_36417(OperationKind.ObjectOrCollectionInitializer, f_25010_36402_36416(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36432, 36491);

                f_25010_36432_36490(f_25010_36447_36469(operation), f_25010_36471_36489(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 36213, 36502);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_36402_36416(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36402, 36416);
                    return return_v;
                }


                int
                f_25010_36344_36417(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36344, 36417);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_36447_36469(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36447, 36469);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_36471_36489(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36471, 36489);
                    return return_v;
                }


                int
                f_25010_36432_36490(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36432, 36490);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 36213, 36502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 36213, 36502);
            }
        }

        public override void VisitMemberInitializer(IMemberInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 36514, 36805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36621, 36683);

                f_25010_36621_36682(OperationKind.MemberInitializer, f_25010_36667_36681(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36697, 36794);

                f_25010_36697_36793(new[] { f_25010_36720_36747(operation), f_25010_36749_36770(operation) }, f_25010_36774_36792(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 36514, 36805);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_36667_36681(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36667, 36681);
                    return return_v;
                }


                int
                f_25010_36621_36682(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36621, 36682);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_36720_36747(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
                this_param)
                {
                    var return_v = this_param.InitializedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36720, 36747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_36749_36770(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36749, 36770);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_36774_36792(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36774, 36792);
                    return return_v;
                }


                bool
                f_25010_36697_36793(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36697, 36793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 36514, 36805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 36514, 36805);
            }
        }

        private void VisitSymbolInitializer(ISymbolInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 36817, 37029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36916, 36946);

                f_25010_36916_36945(f_25010_36928_36944(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 36960, 37018);

                f_25010_36960_37017(f_25010_36972_36987(operation), f_25010_36989_37016(f_25010_36989_37007(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 36817, 37029);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_36928_36944(Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36928, 36944);
                    return return_v;
                }


                int
                f_25010_36916_36945(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36916, 36945);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_36972_36987(Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36972, 36987);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_36989_37007(Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 36989, 37007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_36989_37016(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36989, 37016);
                    return return_v;
                }


                int
                f_25010_36960_37017(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 36960, 37017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 36817, 37029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 36817, 37029);
            }
        }

        public override void VisitFieldInitializer(IFieldInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 37041, 37400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37146, 37207);

                f_25010_37146_37206(OperationKind.FieldInitializer, f_25010_37191_37205(operation));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37221, 37341);
                    foreach (var field in f_25010_37243_37270_I(f_25010_37243_37270(operation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 37221, 37341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37304, 37326);

                        f_25010_37304_37325(field);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 37221, 37341);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37355, 37389);

                f_25010_37355_37388(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 37041, 37400);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_37191_37205(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37191, 37205);
                    return return_v;
                }


                int
                f_25010_37146_37206(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37146, 37206);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
                f_25010_37243_37270(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
                this_param)
                {
                    var return_v = this_param.InitializedFields;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37243, 37270);
                    return return_v;
                }


                int
                f_25010_37304_37325(Microsoft.CodeAnalysis.IFieldSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37304, 37325);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
                f_25010_37243_37270_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37243, 37270);
                    return return_v;
                }


                int
                f_25010_37355_37388(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
                operation)
                {
                    this_param.VisitSymbolInitializer((Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37355, 37388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 37041, 37400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 37041, 37400);
            }
        }

        public override void VisitVariableInitializer(IVariableInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 37412, 37691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37523, 37587);

                f_25010_37523_37586(OperationKind.VariableInitializer, f_25010_37571_37585(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37601, 37632);

                f_25010_37601_37631(f_25010_37614_37630(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37646, 37680);

                f_25010_37646_37679(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 37412, 37691);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_37571_37585(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37571, 37585);
                    return return_v;
                }


                int
                f_25010_37523_37586(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37523, 37586);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_37614_37630(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37614, 37630);
                    return return_v;
                }


                int
                f_25010_37601_37631(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37601, 37631);
                    return 0;
                }


                int
                f_25010_37646_37679(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation
                operation)
                {
                    this_param.VisitSymbolInitializer((Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37646, 37679);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 37412, 37691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 37412, 37691);
            }
        }

        public override void VisitPropertyInitializer(IPropertyInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 37703, 38081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37814, 37878);

                f_25010_37814_37877(OperationKind.PropertyInitializer, f_25010_37862_37876(operation));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37892, 38022);
                    foreach (var property in f_25010_37917_37948_I(f_25010_37917_37948(operation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 37892, 38022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 37982, 38007);

                        f_25010_37982_38006(property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 37892, 38022);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38036, 38070);

                f_25010_38036_38069(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 37703, 38081);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_37862_37876(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37862, 37876);
                    return return_v;
                }


                int
                f_25010_37814_37877(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37814, 37877);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_25010_37917_37948(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
                this_param)
                {
                    var return_v = this_param.InitializedProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 37917, 37948);
                    return return_v;
                }


                int
                f_25010_37982_38006(Microsoft.CodeAnalysis.IPropertySymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37982, 38006);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_25010_37917_37948_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 37917, 37948);
                    return return_v;
                }


                int
                f_25010_38036_38069(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
                operation)
                {
                    this_param.VisitSymbolInitializer((Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38036, 38069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 37703, 38081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 37703, 38081);
            }
        }

        public override void VisitParameterInitializer(IParameterInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 38093, 38380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38206, 38271);

                f_25010_38206_38270(OperationKind.ParameterInitializer, f_25010_38255_38269(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38285, 38321);

                f_25010_38285_38320(f_25010_38300_38319(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38335, 38369);

                f_25010_38335_38368(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 38093, 38380);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_38255_38269(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38255, 38269);
                    return return_v;
                }


                int
                f_25010_38206_38270(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38206, 38270);
                    return 0;
                }


                Microsoft.CodeAnalysis.IParameterSymbol
                f_25010_38300_38319(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38300, 38319);
                    return return_v;
                }


                int
                f_25010_38285_38320(Microsoft.CodeAnalysis.IParameterSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38285, 38320);
                    return 0;
                }


                int
                f_25010_38335_38368(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                operation)
                {
                    this_param.VisitSymbolInitializer((Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38335, 38368);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 38093, 38380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 38093, 38380);
            }
        }

        public override void VisitArrayCreation(IArrayCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 38392, 38853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38491, 38549);

                f_25010_38491_38548(OperationKind.ArrayCreation, f_25010_38533_38547(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38565, 38625);

                IEnumerable<IOperation>
                children = f_25010_38600_38624(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38639, 38781) || true) && (f_25010_38643_38664(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 38639, 38781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38706, 38766);

                    children = f_25010_38717_38765(children, new[] { f_25010_38741_38762(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 38639, 38781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38797, 38842);

                f_25010_38797_38841(children, f_25010_38822_38840(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 38392, 38853);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_38533_38547(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38533, 38547);
                    return return_v;
                }


                int
                f_25010_38491_38548(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38491, 38548);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_38600_38624(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
                this_param)
                {
                    var return_v = this_param.DimensionSizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38600, 38624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation?
                f_25010_38643_38664(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38643, 38664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
                f_25010_38741_38762(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38741, 38762);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_38717_38765(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38717, 38765);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_38822_38840(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 38822, 38840);
                    return return_v;
                }


                bool
                f_25010_38797_38841(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38797, 38841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 38392, 38853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 38392, 38853);
            }
        }

        public override void VisitArrayInitializer(IArrayInitializerOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 38865, 39158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 38970, 39031);

                f_25010_38970_39030(OperationKind.ArrayInitializer, f_25010_39015_39029(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39045, 39073);

                f_25010_39045_39072(f_25010_39057_39071(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39087, 39147);

                f_25010_39087_39146(f_25010_39102_39125(operation), f_25010_39127_39145(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 38865, 39158);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_39015_39029(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39015, 39029);
                    return return_v;
                }


                int
                f_25010_38970_39030(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 38970, 39030);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_39057_39071(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39057, 39071);
                    return return_v;
                }


                int
                f_25010_39045_39072(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39045, 39072);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_39102_39125(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
                this_param)
                {
                    var return_v = this_param.ElementValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39102, 39125);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_39127_39145(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39127, 39145);
                    return return_v;
                }


                int
                f_25010_39087_39146(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39087, 39146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 38865, 39158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 38865, 39158);
            }
        }

        private void VisitAssignment(IAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 39170, 39346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39255, 39335);

                f_25010_39255_39334(new[] { f_25010_39278_39294(operation), f_25010_39296_39311(operation) }, f_25010_39315_39333(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 39170, 39346);

                Microsoft.CodeAnalysis.IOperation
                f_25010_39278_39294(Microsoft.CodeAnalysis.Operations.IAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39278, 39294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_39296_39311(Microsoft.CodeAnalysis.Operations.IAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39296, 39311);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_39315_39333(Microsoft.CodeAnalysis.Operations.IAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39315, 39333);
                    return return_v;
                }


                bool
                f_25010_39255_39334(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39255, 39334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 39170, 39346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 39170, 39346);
            }
        }

        public override void VisitSimpleAssignment(ISimpleAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 39358, 39619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39463, 39524);

                f_25010_39463_39523(OperationKind.SimpleAssignment, f_25010_39508_39522(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39538, 39567);

                bool
                isRef = f_25010_39551_39566(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39581, 39608);

                f_25010_39581_39607(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 39358, 39619);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_39508_39522(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39508, 39522);
                    return return_v;
                }


                int
                f_25010_39463_39523(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39463, 39523);
                    return 0;
                }


                bool
                f_25010_39551_39566(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39551, 39566);
                    return return_v;
                }


                int
                f_25010_39581_39607(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                operation)
                {
                    this_param.VisitAssignment((Microsoft.CodeAnalysis.Operations.IAssignmentOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39581, 39607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 39358, 39619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 39358, 39619);
            }
        }

        public override void VisitCompoundAssignment(ICompoundAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 39631, 41294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39740, 39803);

                f_25010_39740_39802(OperationKind.CompoundAssignment, f_25010_39787_39801(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39817, 39863);

                var
                operatorMethod = f_25010_39838_39862(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39877, 39926);

                var
                binaryOperationKind = f_25010_39903_39925(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39940, 39982);

                var
                inConversion = f_25010_39959_39981(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 39996, 40040);

                var
                outConversion = f_25010_40016_40039(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40056, 41142) || true) && (f_25010_40060_40085(f_25010_40060_40076(operation)) == LanguageNames.CSharp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 40056, 41142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40143, 40266);

                    f_25010_40143_40265("compoundAssignment", () => VisualBasic.VisualBasicExtensions.GetInConversion(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40284, 40408);

                    f_25010_40284_40407("compoundAssignment", () => VisualBasic.VisualBasicExtensions.GetOutConversion(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40426, 40504);

                    var
                    inConversionInternal = f_25010_40453_40503(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40522, 40602);

                    var
                    outConversionInternal = f_25010_40550_40601(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 40056, 41142);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 40056, 41142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40668, 40781);

                    f_25010_40668_40780("compoundAssignment", () => CSharp.CSharpExtensions.GetInConversion(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40799, 40913);

                    f_25010_40799_40912("compoundAssignment", () => CSharp.CSharpExtensions.GetOutConversion(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 40931, 41019);

                    var
                    inConversionInternal = f_25010_40958_41018(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41037, 41127);

                    var
                    outConversionInternal = f_25010_41065_41126(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 40056, 41142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41158, 41192);

                var
                isLifted = f_25010_41173_41191(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41206, 41242);

                var
                isChecked = f_25010_41222_41241(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41256, 41283);

                f_25010_41256_41282(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 39631, 41294);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_39787_39801(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39787, 39801);
                    return return_v;
                }


                int
                f_25010_39740_39802(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 39740, 39802);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_39838_39862(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39838, 39862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_39903_39925(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39903, 39925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_39959_39981(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.InConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 39959, 39981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_25010_40016_40039(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.OutConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 40016, 40039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_40060_40076(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 40060, 40076);
                    return return_v;
                }


                string
                f_25010_40060_40085(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 40060, 40085);
                    return return_v;
                }


                System.ArgumentException
                f_25010_40143_40265(string
                paramName, System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(paramName, testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40143, 40265);
                    return return_v;
                }


                System.ArgumentException
                f_25010_40284_40407(string
                paramName, System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(paramName, testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40284, 40407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_25010_40453_40503(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                compoundAssignment)
                {
                    var return_v = CSharp.CSharpExtensions.GetInConversion(compoundAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40453, 40503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_25010_40550_40601(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                compoundAssignment)
                {
                    var return_v = CSharp.CSharpExtensions.GetOutConversion(compoundAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40550, 40601);
                    return return_v;
                }


                System.ArgumentException
                f_25010_40668_40780(string
                paramName, System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(paramName, testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40668, 40780);
                    return return_v;
                }


                System.ArgumentException
                f_25010_40799_40912(string
                paramName, System.Func<object>
                testCode)
                {
                    var return_v = Assert.Throws<ArgumentException>(paramName, testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40799, 40912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.Conversion
                f_25010_40958_41018(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                compoundAssignment)
                {
                    var return_v = VisualBasic.VisualBasicExtensions.GetInConversion(compoundAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 40958, 41018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.Conversion
                f_25010_41065_41126(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                compoundAssignment)
                {
                    var return_v = VisualBasic.VisualBasicExtensions.GetOutConversion(compoundAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41065, 41126);
                    return return_v;
                }


                bool
                f_25010_41173_41191(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.IsLifted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41173, 41191);
                    return return_v;
                }


                bool
                f_25010_41222_41241(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41222, 41241);
                    return return_v;
                }


                int
                f_25010_41256_41282(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                operation)
                {
                    this_param.VisitAssignment((Microsoft.CodeAnalysis.Operations.IAssignmentOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41256, 41282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 39631, 41294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 39631, 41294);
            }
        }

        public override void VisitIncrementOrDecrement(IIncrementOrDecrementOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 41306, 41805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41419, 41511);

                f_25010_41419_41510(f_25010_41435_41449(operation), new[] { OperationKind.Increment, OperationKind.Decrement });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41525, 41571);

                var
                operatorMethod = f_25010_41546_41570(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41585, 41621);

                var
                isPostFix = f_25010_41601_41620(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41635, 41669);

                var
                isLifted = f_25010_41650_41668(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41683, 41719);

                var
                isChecked = f_25010_41699_41718(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41735, 41794);

                f_25010_41735_41793(f_25010_41747_41763(operation), f_25010_41765_41792(f_25010_41765_41783(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 41306, 41805);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_41435_41449(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41435, 41449);
                    return return_v;
                }


                int
                f_25010_41419_41510(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind[]
                collection)
                {
                    Assert.Contains(expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.OperationKind>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41419, 41510);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_41546_41570(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41546, 41570);
                    return return_v;
                }


                bool
                f_25010_41601_41620(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.IsPostfix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41601, 41620);
                    return return_v;
                }


                bool
                f_25010_41650_41668(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.IsLifted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41650, 41668);
                    return return_v;
                }


                bool
                f_25010_41699_41718(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.IsChecked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41699, 41718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_41747_41763(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41747, 41763);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_41765_41783(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41765, 41783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_41765_41792(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41765, 41792);
                    return return_v;
                }


                int
                f_25010_41735_41793(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41735, 41793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 41306, 41805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 41306, 41805);
            }
        }

        public override void VisitParenthesized(IParenthesizedOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 41817, 42059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41916, 41974);

                f_25010_41916_41973(OperationKind.Parenthesized, f_25010_41958_41972(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 41988, 42048);

                f_25010_41988_42047(f_25010_42000_42017(operation), f_25010_42019_42046(f_25010_42019_42037(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 41817, 42059);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_41958_41972(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 41958, 41972);
                    return return_v;
                }


                int
                f_25010_41916_41973(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41916, 41973);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_42000_42017(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42000, 42017);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_42019_42037(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42019, 42037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_42019_42046(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42019, 42046);
                    return return_v;
                }


                int
                f_25010_41988_42047(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 41988, 42047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 41817, 42059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 41817, 42059);
            }
        }

        public override void VisitDynamicMemberReference(IDynamicMemberReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 42071, 42770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42188, 42255);

                f_25010_42188_42254(OperationKind.DynamicMemberReference, f_25010_42239_42253(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42269, 42306);

                f_25010_42269_42305(f_25010_42284_42304(operation));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42322, 42442);
                    foreach (var typeArg in f_25010_42346_42369_I(f_25010_42346_42369(operation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 42322, 42442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42403, 42427);

                        f_25010_42403_42426(typeArg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 42322, 42442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42458, 42504);

                var
                containingType = f_25010_42479_42503(operation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42520, 42759) || true) && (f_25010_42524_42542(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 42520, 42759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42584, 42617);

                    f_25010_42584_42616(f_25010_42597_42615(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 42520, 42759);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 42520, 42759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42683, 42744);

                    f_25010_42683_42743(f_25010_42695_42713(operation), f_25010_42715_42742(f_25010_42715_42733(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 42520, 42759);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 42071, 42770);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_42239_42253(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42239, 42253);
                    return return_v;
                }


                int
                f_25010_42188_42254(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42188, 42254);
                    return 0;
                }


                string
                f_25010_42284_42304(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.MemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42284, 42304);
                    return return_v;
                }


                int
                f_25010_42269_42305(string
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42269, 42305);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_25010_42346_42369(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42346, 42369);
                    return return_v;
                }


                int
                f_25010_42403_42426(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42403, 42426);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_25010_42346_42369_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42346, 42369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_42479_42503(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42479, 42503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_42524_42542(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42524, 42542);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_42597_42615(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42597, 42615);
                    return return_v;
                }


                int
                f_25010_42584_42616(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42584, 42616);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_42695_42713(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42695, 42713);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_42715_42733(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42715, 42733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_42715_42742(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42715, 42742);
                    return return_v;
                }


                int
                f_25010_42683_42743(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42683, 42743);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 42071, 42770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 42071, 42770);
            }
        }

        public override void VisitDefaultValue(IDefaultValueOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 42782, 42994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42879, 42936);

                f_25010_42879_42935(OperationKind.DefaultValue, f_25010_42920_42934(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 42950, 42983);

                f_25010_42950_42982(f_25010_42963_42981(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 42782, 42994);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_42920_42934(Microsoft.CodeAnalysis.Operations.IDefaultValueOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42920, 42934);
                    return return_v;
                }


                int
                f_25010_42879_42935(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42879, 42935);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_42963_42981(Microsoft.CodeAnalysis.Operations.IDefaultValueOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 42963, 42981);
                    return return_v;
                }


                int
                f_25010_42950_42982(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 42950, 42982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 42782, 42994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 42782, 42994);
            }
        }

        public override void VisitTypeParameterObjectCreation(ITypeParameterObjectCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 43006, 43475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43133, 43205);

                f_25010_43133_43204(OperationKind.TypeParameterObjectCreation, f_25010_43189_43203(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43219, 43464) || true) && (f_25010_43223_43244(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 43219, 43464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43286, 43319);

                    f_25010_43286_43318(f_25010_43299_43317(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 43219, 43464);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 43219, 43464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43385, 43449);

                    f_25010_43385_43448(f_25010_43397_43418(operation), f_25010_43420_43447(f_25010_43420_43438(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 43219, 43464);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 43006, 43475);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_43189_43203(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43189, 43203);
                    return return_v;
                }


                int
                f_25010_43133_43204(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43133, 43204);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_25010_43223_43244(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43223, 43244);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_43299_43317(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43299, 43317);
                    return return_v;
                }


                int
                f_25010_43286_43318(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43286, 43318);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_43397_43418(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43397, 43418);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_43420_43438(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43420, 43438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_43420_43447(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43420, 43447);
                    return return_v;
                }


                int
                f_25010_43385_43448(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43385, 43448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 43006, 43475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 43006, 43475);
            }
        }

        internal override void VisitNoPiaObjectCreation(INoPiaObjectCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 43487, 43919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43600, 43649);

                f_25010_43600_43648(OperationKind.None, f_25010_43633_43647(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43663, 43908) || true) && (f_25010_43667_43688(operation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 43663, 43908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43730, 43763);

                    f_25010_43730_43762(f_25010_43743_43761(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 43663, 43908);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 43663, 43908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 43829, 43893);

                    f_25010_43829_43892(f_25010_43841_43862(operation), f_25010_43864_43891(f_25010_43864_43882(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 43663, 43908);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 43487, 43919);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_43633_43647(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43633, 43647);
                    return return_v;
                }


                int
                f_25010_43600_43648(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43600, 43648);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
                f_25010_43667_43688(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43667, 43688);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_43743_43761(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43743, 43761);
                    return return_v;
                }


                int
                f_25010_43730_43762(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43730, 43762);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_43841_43862(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43841, 43862);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_43864_43882(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 43864, 43882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_43864_43891(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43864, 43891);
                    return return_v;
                }


                int
                f_25010_43829_43892(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 43829, 43892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 43487, 43919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 43487, 43919);
            }
        }

        public override void VisitInvalid(IInvalidOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 43931, 44081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44018, 44070);

                f_25010_44018_44069(OperationKind.Invalid, f_25010_44054_44068(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 43931, 44081);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_44054_44068(Microsoft.CodeAnalysis.Operations.IInvalidOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44054, 44068);
                    return return_v;
                }


                int
                f_25010_44018_44069(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44018, 44069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 43931, 44081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 43931, 44081);
            }
        }

        public override void VisitTuple(ITupleOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 44093, 44360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44176, 44226);

                f_25010_44176_44225(OperationKind.Tuple, f_25010_44210_44224(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44240, 44280);

                var
                naturalType = f_25010_44258_44279(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44294, 44349);

                f_25010_44294_44348(f_25010_44309_44327(operation), f_25010_44329_44347(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 44093, 44360);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_44210_44224(Microsoft.CodeAnalysis.Operations.ITupleOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44210, 44224);
                    return return_v;
                }


                int
                f_25010_44176_44225(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44176, 44225);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_44258_44279(Microsoft.CodeAnalysis.Operations.ITupleOperation
                this_param)
                {
                    var return_v = this_param.NaturalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44258, 44279);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_44309_44327(Microsoft.CodeAnalysis.Operations.ITupleOperation
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44309, 44327);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_44329_44347(Microsoft.CodeAnalysis.Operations.ITupleOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44329, 44347);
                    return return_v;
                }


                int
                f_25010_44294_44348(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44294, 44348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 44093, 44360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 44093, 44360);
            }
        }

        public override void VisitInterpolatedString(IInterpolatedStringOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 44372, 44621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44481, 44544);

                f_25010_44481_44543(OperationKind.InterpolatedString, f_25010_44528_44542(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44558, 44610);

                f_25010_44558_44609(f_25010_44573_44588(operation), f_25010_44590_44608(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 44372, 44621);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_44528_44542(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44528, 44542);
                    return return_v;
                }


                int
                f_25010_44481_44543(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44481, 44543);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>
                f_25010_44573_44588(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation
                this_param)
                {
                    var return_v = this_param.Parts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44573, 44588);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_44590_44608(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44590, 44608);
                    return return_v;
                }


                bool
                f_25010_44558_44609(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44558, 44609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 44372, 44621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 44372, 44621);
            }
        }

        public override void VisitInterpolatedStringText(IInterpolatedStringTextOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 44633, 44970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44750, 44817);

                f_25010_44750_44816(OperationKind.InterpolatedStringText, f_25010_44801_44815(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44831, 44888);

                f_25010_44831_44887(OperationKind.Literal, f_25010_44867_44886(f_25010_44867_44881(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 44902, 44959);

                f_25010_44902_44958(f_25010_44914_44928(operation), f_25010_44930_44957(f_25010_44930_44948(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 44633, 44970);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_44801_44815(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44801, 44815);
                    return return_v;
                }


                int
                f_25010_44750_44816(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44750, 44816);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_44867_44881(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44867, 44881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_44867_44886(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44867, 44886);
                    return return_v;
                }


                int
                f_25010_44831_44887(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44831, 44887);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_44914_44928(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44914, 44928);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_44930_44948(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 44930, 44948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_44930_44957(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44930, 44957);
                    return return_v;
                }


                int
                f_25010_44902_44958(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 44902, 44958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 44633, 44970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 44633, 44970);
            }
        }

        public override void VisitInterpolation(IInterpolationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 44982, 45686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45081, 45139);

                f_25010_45081_45138(OperationKind.Interpolation, f_25010_45123_45137(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45153, 45219);

                IEnumerable<IOperation>
                children = new[] { f_25010_45196_45216(operation) }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45233, 45371) || true) && (f_25010_45237_45256(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 45233, 45371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45298, 45356);

                    children = f_25010_45309_45355(children, new[] { f_25010_45333_45352(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 45233, 45371);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45387, 45614) || true) && (f_25010_45391_45413(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 45387, 45614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45455, 45520);

                    f_25010_45455_45519(OperationKind.Literal, f_25010_45491_45518(f_25010_45491_45513(operation)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45538, 45599);

                    children = f_25010_45549_45598(children, new[] { f_25010_45573_45595(operation) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 45387, 45614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45630, 45675);

                f_25010_45630_45674(children, f_25010_45655_45673(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 44982, 45686);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_45123_45137(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45123, 45137);
                    return return_v;
                }


                int
                f_25010_45081_45138(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45081, 45138);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_45196_45216(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45196, 45216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_45237_45256(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45237, 45256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_45333_45352(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45333, 45352);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_45309_45355(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45309, 45355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_45391_45413(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45391, 45413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_45491_45513(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45491, 45513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_45491_45518(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45491, 45518);
                    return return_v;
                }


                int
                f_25010_45455_45519(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45455, 45519);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_45573_45595(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45573, 45595);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_45549_45598(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, Microsoft.CodeAnalysis.IOperation[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45549, 45598);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_45655_45673(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45655, 45673);
                    return return_v;
                }


                bool
                f_25010_45630_45674(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45630, 45674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 44982, 45686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 44982, 45686);
            }
        }

        private void VisitPatternCommon(IPatternOperation pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 45698, 45976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45781, 45815);

                f_25010_45781_45814(f_25010_45796_45813(pattern));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45829, 45866);

                f_25010_45829_45865(f_25010_45844_45864(pattern));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45880, 45906);

                f_25010_45880_45905(f_25010_45892_45904(pattern));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 45920, 45965);

                f_25010_45920_45964(pattern.ConstantValue.HasValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 45698, 45976);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_45796_45813(Microsoft.CodeAnalysis.Operations.IPatternOperation
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45796, 45813);
                    return return_v;
                }


                int
                f_25010_45781_45814(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45781, 45814);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_45844_45864(Microsoft.CodeAnalysis.Operations.IPatternOperation
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45844, 45864);
                    return return_v;
                }


                int
                f_25010_45829_45865(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45829, 45865);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_45892_45904(Microsoft.CodeAnalysis.Operations.IPatternOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 45892, 45904);
                    return return_v;
                }


                int
                f_25010_45880_45905(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45880, 45905);
                    return 0;
                }


                int
                f_25010_45920_45964(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 45920, 45964);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 45698, 45976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 45698, 45976);
            }
        }

        public override void VisitConstantPattern(IConstantPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 45988, 46278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 46091, 46151);

                f_25010_46091_46150(OperationKind.ConstantPattern, f_25010_46135_46149(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 46165, 46195);

                f_25010_46165_46194(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 46209, 46267);

                f_25010_46209_46266(f_25010_46221_46236(operation), f_25010_46238_46265(f_25010_46238_46256(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 45988, 46278);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_46135_46149(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 46135, 46149);
                    return return_v;
                }


                int
                f_25010_46091_46150(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46091, 46150);
                    return 0;
                }


                int
                f_25010_46165_46194(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46165, 46194);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_46221_46236(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 46221, 46236);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_46238_46256(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 46238, 46256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_46238_46265(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46238, 46265);
                    return return_v;
                }


                int
                f_25010_46209_46266(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46209, 46266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 45988, 46278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 45988, 46278);
            }
        }

        public override void VisitRelationalPattern(IRelationalPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 46290, 47177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 46397, 46459);

                f_25010_46397_46458(OperationKind.RelationalPattern, f_25010_46443_46457(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 46473, 47050);

                f_25010_46473_47049(f_25010_46485_46507(operation) is Operations.BinaryOperatorKind.LessThan or
                                                                  Operations.BinaryOperatorKind.LessThanOrEqual or
                                                                  Operations.BinaryOperatorKind.GreaterThan or
                                                                  Operations.BinaryOperatorKind.GreaterThanOrEqual or
                                                                  Operations.BinaryOperatorKind.Equals or // Error cases
                                                                  Operations.BinaryOperatorKind.NotEquals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47064, 47094);

                f_25010_47064_47093(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47108, 47166);

                f_25010_47108_47165(f_25010_47120_47135(operation), f_25010_47137_47164(f_25010_47137_47155(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 46290, 47177);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_46443_46457(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 46443, 46457);
                    return return_v;
                }


                int
                f_25010_46397_46458(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46397, 46458);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_46485_46507(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 46485, 46507);
                    return return_v;
                }


                int
                f_25010_46473_47049(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 46473, 47049);
                    return 0;
                }


                int
                f_25010_47064_47093(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47064, 47093);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_47120_47135(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47120, 47135);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_47137_47155(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47137, 47155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_47137_47164(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47137, 47164);
                    return return_v;
                }


                int
                f_25010_47108_47165(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47108, 47165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 46290, 47177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 46290, 47177);
            }
        }

        public override void VisitBinaryPattern(IBinaryPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 47189, 47788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47288, 47346);

                f_25010_47288_47345(OperationKind.BinaryPattern, f_25010_47330_47344(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47360, 47390);

                f_25010_47360_47389(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47404, 47547);

                f_25010_47404_47546(f_25010_47416_47438(operation) switch
                {
                    Operations.BinaryOperatorKind.Or when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47448, 47488) && DynAbs.Tracing.TraceSender.Expression_True(25010, 47448, 47488))
=> true,
                    Operations.BinaryOperatorKind.And when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47490, 47531) && DynAbs.Tracing.TraceSender.Expression_True(25010, 47490, 47531))
           => true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47533, 47543) && DynAbs.Tracing.TraceSender.Expression_True(25010, 47533, 47543))
           => false
                });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47561, 47605);

                var
                children = f_25010_47576_47604(f_25010_47576_47594(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47619, 47652);

                f_25010_47619_47651(2, f_25010_47635_47650(children));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47666, 47714);

                f_25010_47666_47713(f_25010_47678_47699(operation), children[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47728, 47777);

                f_25010_47728_47776(f_25010_47740_47762(operation), children[1]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 47189, 47788);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_47330_47344(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47330, 47344);
                    return return_v;
                }


                int
                f_25010_47288_47345(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47288, 47345);
                    return 0;
                }


                int
                f_25010_47360_47389(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47360, 47389);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25010_47416_47438(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47416, 47438);
                    return return_v;
                }


                int
                f_25010_47404_47546(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47404, 47546);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_47576_47594(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47576, 47594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation[]
                f_25010_47576_47604(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47576, 47604);
                    return return_v;
                }


                int
                f_25010_47635_47650(Microsoft.CodeAnalysis.IOperation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47635, 47650);
                    return return_v;
                }


                int
                f_25010_47619_47651(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47619, 47651);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_47678_47699(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                this_param)
                {
                    var return_v = this_param.LeftPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47678, 47699);
                    return return_v;
                }


                int
                f_25010_47666_47713(Microsoft.CodeAnalysis.Operations.IPatternOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47666, 47713);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_47740_47762(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
                this_param)
                {
                    var return_v = this_param.RightPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47740, 47762);
                    return return_v;
                }


                int
                f_25010_47728_47776(Microsoft.CodeAnalysis.Operations.IPatternOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47728, 47776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 47189, 47788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 47189, 47788);
            }
        }

        public override void VisitNegatedPattern(INegatedPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 47800, 48089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47901, 47960);

                f_25010_47901_47959(OperationKind.NegatedPattern, f_25010_47944_47958(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 47974, 48004);

                f_25010_47974_48003(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48018, 48078);

                f_25010_48018_48077(f_25010_48030_48047(operation), f_25010_48049_48076(f_25010_48049_48067(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 47800, 48089);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_47944_47958(Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 47944, 47958);
                    return return_v;
                }


                int
                f_25010_47901_47959(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47901, 47959);
                    return 0;
                }


                int
                f_25010_47974_48003(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 47974, 48003);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_48030_48047(Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48030, 48047);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_48049_48067(Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48049, 48067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_48049_48076(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48049, 48076);
                    return return_v;
                }


                int
                f_25010_48018_48077(Microsoft.CodeAnalysis.Operations.IPatternOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48018, 48077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 47800, 48089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 47800, 48089);
            }
        }

        public override void VisitTypePattern(ITypePatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 48101, 48406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48196, 48252);

                f_25010_48196_48251(OperationKind.TypePattern, f_25010_48236_48250(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48266, 48304);

                f_25010_48266_48303(f_25010_48281_48302(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48318, 48348);

                f_25010_48318_48347(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48362, 48395);

                f_25010_48362_48394(f_25010_48375_48393(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 48101, 48406);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_48236_48250(Microsoft.CodeAnalysis.Operations.ITypePatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48236, 48250);
                    return return_v;
                }


                int
                f_25010_48196_48251(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48196, 48251);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_48281_48302(Microsoft.CodeAnalysis.Operations.ITypePatternOperation
                this_param)
                {
                    var return_v = this_param.MatchedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48281, 48302);
                    return return_v;
                }


                int
                f_25010_48266_48303(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48266, 48303);
                    return 0;
                }


                int
                f_25010_48318_48347(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.ITypePatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48318, 48347);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_48375_48393(Microsoft.CodeAnalysis.Operations.ITypePatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48375, 48393);
                    return return_v;
                }


                int
                f_25010_48362_48394(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48362, 48394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 48101, 48406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 48101, 48406);
            }
        }

        public override void VisitDeclarationPattern(IDeclarationPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 48418, 49923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48527, 48590);

                f_25010_48527_48589(OperationKind.DeclarationPattern, f_25010_48574_48588(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48604, 48634);

                f_25010_48604_48633(this, operation);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48648, 49166) || true) && (f_25010_48652_48705(f_25010_48652_48668(operation), CSharp.SyntaxKind.VarPattern) || (DynAbs.Tracing.TraceSender.Expression_False(25010, 48652, 48871) || f_25010_48803_48871(f_25010_48803_48819(operation), CSharp.SyntaxKind.SingleVariableDesignation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 48648, 49166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48905, 48940);

                    f_25010_48905_48939(f_25010_48917_48938(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 48958, 48993);

                    f_25010_48958_48992(f_25010_48970_48991(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 48648, 49166);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 48648, 49166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49059, 49095);

                    f_25010_49059_49094(f_25010_49072_49093(operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49113, 49151);

                    f_25010_49113_49150(f_25010_49128_49149(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 48648, 49166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49205, 49588);

                var
                designation =
                (DynAbs.Tracing.TraceSender.Conditional_F1(25010, 49240, 49298) || ((f_25010_49240_49256(operation) is CSharp.Syntax.DeclarationPatternSyntax && DynAbs.Tracing.TraceSender.Conditional_F2(25010, 49301, 49371)) || DynAbs.Tracing.TraceSender.Conditional_F3(25010, 49391, 49587))) ? f_25010_49301_49371(((CSharp.Syntax.DeclarationPatternSyntax)f_25010_49342_49358(operation))) : ((DynAbs.Tracing.TraceSender.Conditional_F1(25010, 49392, 49442) || ((f_25010_49392_49408(operation) is CSharp.Syntax.VarPatternSyntax && DynAbs.Tracing.TraceSender.Conditional_F2(25010, 49445, 49507)) || DynAbs.Tracing.TraceSender.Conditional_F3(25010, 49527, 49586))) ? f_25010_49445_49507(((CSharp.Syntax.VarPatternSyntax)f_25010_49478_49494(operation))) : f_25010_49527_49543(operation) as CSharp.Syntax.VariableDesignationSyntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49602, 49863) || true) && (f_25010_49606_49669(designation, CSharp.SyntaxKind.SingleVariableDesignation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 49602, 49863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49703, 49744);

                    f_25010_49703_49743(f_25010_49718_49742(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 49602, 49863);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 49602, 49863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49810, 49848);

                    f_25010_49810_49847(f_25010_49822_49846(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 49602, 49863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 49879, 49912);

                f_25010_49879_49911(f_25010_49892_49910(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 48418, 49923);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_48574_48588(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48574, 48588);
                    return return_v;
                }


                int
                f_25010_48527_48589(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48527, 48589);
                    return 0;
                }


                int
                f_25010_48604_48633(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48604, 48633);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_48652_48668(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48652, 48668);
                    return return_v;
                }


                bool
                f_25010_48652_48705(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48652, 48705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_48803_48819(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48803, 48819);
                    return return_v;
                }


                bool
                f_25010_48803_48871(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48803, 48871);
                    return return_v;
                }


                bool
                f_25010_48917_48938(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.MatchesNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48917, 48938);
                    return return_v;
                }


                int
                f_25010_48905_48939(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48905, 48939);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_48970_48991(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.MatchedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 48970, 48991);
                    return return_v;
                }


                int
                f_25010_48958_48992(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 48958, 48992);
                    return 0;
                }


                bool
                f_25010_49072_49093(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.MatchesNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49072, 49093);
                    return return_v;
                }


                int
                f_25010_49059_49094(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49059, 49094);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_49128_49149(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.MatchedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49128, 49149);
                    return return_v;
                }


                int
                f_25010_49113_49150(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49113, 49150);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_49240_49256(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49240, 49256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_49342_49358(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49342, 49358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_25010_49301_49371(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49301, 49371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_49392_49408(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49392, 49408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_49478_49494(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49478, 49494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_25010_49445_49507(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49445, 49507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_49527_49543(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49527, 49543);
                    return return_v;
                }


                bool
                f_25010_49606_49669(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49606, 49669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25010_49718_49742(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.DeclaredSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49718, 49742);
                    return return_v;
                }


                int
                f_25010_49703_49743(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49703, 49743);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25010_49822_49846(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.DeclaredSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49822, 49846);
                    return return_v;
                }


                int
                f_25010_49810_49847(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49810, 49847);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_49892_49910(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 49892, 49910);
                    return return_v;
                }


                int
                f_25010_49879_49911(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 49879, 49911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 48418, 49923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 48418, 49923);
            }
        }

        public override void VisitRecursivePattern(IRecursivePatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 49935, 51854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50040, 50101);

                f_25010_50040_50100(OperationKind.RecursivePattern, f_25010_50085_50099(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50115, 50145);

                f_25010_50115_50144(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50159, 50197);

                f_25010_50159_50196(f_25010_50174_50195(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50211, 50991);

                switch (f_25010_50219_50246(operation))
                {

                    case IErrorTypeSymbol error:
                    case null: // OK: indicates deconstruction of a tuple, or an error case
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 50211, 50991);
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 50419, 50425);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 50211, 50991);

                    case IMethodSymbol method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 50211, 50991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50567, 50608);

                        f_25010_50567_50607("Deconstruct", f_25010_50595_50606(method));
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 50630, 50636);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 50211, 50991);

                    case ITypeSymbol type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 50211, 50991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50767, 50801);

                        f_25010_50767_50800("ITuple", f_25010_50790_50799(type));
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 50823, 50829);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 50211, 50991);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 50211, 50991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 50877, 50948);

                        f_25010_50877_50947(false, $"Unexpected symbol {f_25010_50917_50944(operation)}");
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 50970, 50976);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 50211, 50991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51007, 51160);

                var
                designation = (DynAbs.Tracing.TraceSender.Conditional_F1(25010, 51025, 51081) || ((f_25010_51025_51041(operation) is CSharp.Syntax.RecursivePatternSyntax && DynAbs.Tracing.TraceSender.Conditional_F2(25010, 51084, 51152)) || DynAbs.Tracing.TraceSender.Conditional_F3(25010, 51155, 51159))) ? f_25010_51084_51152(((CSharp.Syntax.RecursivePatternSyntax)f_25010_51123_51139(operation))) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51174, 51435) || true) && (f_25010_51178_51241(designation, CSharp.SyntaxKind.SingleVariableDesignation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 51174, 51435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51275, 51316);

                    f_25010_51275_51315(f_25010_51290_51314(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 51174, 51435);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 51174, 51435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51382, 51420);

                    f_25010_51382_51419(f_25010_51394_51418(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 51174, 51435);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51451, 51604);
                    foreach (var subpat in f_25010_51474_51503_I(f_25010_51474_51503(operation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 51451, 51604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51537, 51589);

                        f_25010_51537_51588(subpat is IPropertySubpatternOperation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 51451, 51604);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51620, 51710);

                var temp = operation.DeconstructionSubpatterns;
                IEnumerable<IOperation>
                children = f_25010_51655_51709(ref temp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51724, 51782);

                children = f_25010_51735_51781(children, f_25010_51751_51780(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51798, 51843);

                f_25010_51798_51842(children, f_25010_51823_51841(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 49935, 51854);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_50085_50099(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50085, 50099);
                    return return_v;
                }


                int
                f_25010_50040_50100(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50040, 50100);
                    return 0;
                }


                int
                f_25010_50115_50144(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50115, 50144);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_50174_50195(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.MatchedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50174, 50195);
                    return return_v;
                }


                int
                f_25010_50159_50196(Microsoft.CodeAnalysis.ITypeSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50159, 50196);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25010_50219_50246(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.DeconstructSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50219, 50246);
                    return return_v;
                }


                string
                f_25010_50595_50606(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50595, 50606);
                    return return_v;
                }


                int
                f_25010_50567_50607(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50567, 50607);
                    return 0;
                }


                string
                f_25010_50790_50799(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50790, 50799);
                    return return_v;
                }


                int
                f_25010_50767_50800(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50767, 50800);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_50917_50944(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.DeconstructSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 50917, 50944);
                    return return_v;
                }


                int
                f_25010_50877_50947(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 50877, 50947);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_51025_51041(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51025, 51041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25010_51123_51139(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51123, 51139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_25010_51084_51152(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51084, 51152);
                    return return_v;
                }


                bool
                f_25010_51178_51241(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51178, 51241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25010_51290_51314(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.DeclaredSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51290, 51314);
                    return return_v;
                }


                int
                f_25010_51275_51315(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51275, 51315);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25010_51394_51418(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.DeclaredSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51394, 51418);
                    return return_v;
                }


                int
                f_25010_51382_51419(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51382, 51419);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
                f_25010_51474_51503(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.PropertySubpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51474, 51503);
                    return return_v;
                }


                int
                f_25010_51537_51588(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51537, 51588);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
                f_25010_51474_51503_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51474, 51503);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_51655_51709(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPatternOperation>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51655, 51709);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
                f_25010_51751_51780(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.PropertySubpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51751, 51780);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_51735_51781(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51735, 51781);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_51823_51841(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51823, 51841);
                    return return_v;
                }


                bool
                f_25010_51798_51842(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51798, 51842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 49935, 51854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 49935, 51854);
            }
        }

        public override void VisitPropertySubpattern(IPropertySubpatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 51866, 52747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 51975, 52009);

                f_25010_51975_52008(f_25010_51990_52007(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52023, 52095);

                var
                children = new IOperation[] { f_25010_52057_52073(operation), f_25010_52075_52092(operation) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52109, 52154);

                f_25010_52109_52153(children, f_25010_52134_52152(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52170, 52276) || true) && (f_25010_52174_52195(f_25010_52174_52190(operation)) == OperationKind.Invalid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 52170, 52276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52254, 52261);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 52170, 52276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52292, 52351);

                f_25010_52292_52350(f_25010_52304_52320(operation) is IMemberReferenceOperation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52365, 52422);

                var
                member = (IMemberReferenceOperation)f_25010_52405_52421(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52436, 52736);

                switch (f_25010_52444_52457(member))
                {

                    case IFieldSymbol field:
                    case IPropertySymbol prop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 52436, 52736);
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 52581, 52587);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 52436, 52736);

                    case var symbol:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 52436, 52736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52643, 52693);

                        f_25010_52643_52692(false, $"Unexpected symbol {symbol}");
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 52715, 52721);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 52436, 52736);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 51866, 52747);

                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_51990_52007(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 51990, 52007);
                    return return_v;
                }


                int
                f_25010_51975_52008(Microsoft.CodeAnalysis.Operations.IPatternOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 51975, 52008);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_52057_52073(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52057, 52073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_52075_52092(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52075, 52092);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_52134_52152(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52134, 52152);
                    return return_v;
                }


                bool
                f_25010_52109_52153(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52109, 52153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_52174_52190(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52174, 52190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_52174_52195(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52174, 52195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_52304_52320(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52304, 52320);
                    return return_v;
                }


                int
                f_25010_52292_52350(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52292, 52350);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_52405_52421(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52405, 52421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25010_52444_52457(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52444, 52457);
                    return return_v;
                }


                int
                f_25010_52643_52692(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52643, 52692);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 51866, 52747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 51866, 52747);
            }
        }

        public override void VisitSwitchExpression(ISwitchExpressionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 52759, 53235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52864, 52895);

                f_25010_52864_52894(f_25010_52879_52893(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52909, 52956);

                f_25010_52909_52955(operation.ConstantValue.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 52970, 53031);

                f_25010_52970_53030(OperationKind.SwitchExpression, f_25010_53015_53029(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53045, 53077);

                f_25010_53045_53076(f_25010_53060_53075(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53091, 53165);

                var temp = operation.Arms;
                var
                children = f_25010_53106_53164(f_25010_53106_53139(ref temp), f_25010_53148_53163(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53179, 53224);

                f_25010_53179_53223(children, f_25010_53204_53222(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 52759, 53235);

                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_52879_52893(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 52879, 52893);
                    return return_v;
                }


                int
                f_25010_52864_52894(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52864, 52894);
                    return 0;
                }


                int
                f_25010_52909_52955(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52909, 52955);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_53015_53029(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53015, 53029);
                    return return_v;
                }


                int
                f_25010_52970_53030(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 52970, 53030);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53060_53075(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53060, 53075);
                    return return_v;
                }


                int
                f_25010_53045_53076(Microsoft.CodeAnalysis.IOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53045, 53076);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_53106_53139(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53106, 53139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53148_53163(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53148, 53163);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_53106_53164(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source, Microsoft.CodeAnalysis.IOperation
                element)
                {
                    var return_v = source.Prepend<Microsoft.CodeAnalysis.IOperation>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53106, 53164);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_53204_53222(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53204, 53222);
                    return return_v;
                }


                bool
                f_25010_53179_53223(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53179, 53223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 52759, 53235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 52759, 53235);
            }
        }

        public override void VisitSwitchExpressionArm(ISwitchExpressionArmOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 53247, 53887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53358, 53386);

                f_25010_53358_53385(f_25010_53370_53384(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53400, 53447);

                f_25010_53400_53446(operation.ConstantValue.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53461, 53495);

                f_25010_53461_53494(f_25010_53476_53493(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53509, 53529);

                _ = f_25010_53513_53528(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53543, 53575);

                f_25010_53543_53574(f_25010_53558_53573(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53589, 53619);

                f_25010_53589_53618(f_25010_53601_53617(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53633, 53817);

                var
                children = (DynAbs.Tracing.TraceSender.Conditional_F1(25010, 53648, 53671) || ((f_25010_53648_53663(operation) == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(25010, 53691, 53735)) || DynAbs.Tracing.TraceSender.Conditional_F3(25010, 53755, 53816))) ? new[] { f_25010_53699_53716(operation), f_25010_53718_53733(operation) }
                : new[] { f_25010_53763_53780(operation), f_25010_53782_53797(operation), f_25010_53799_53814(operation) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53831, 53876);

                f_25010_53831_53875(children, f_25010_53856_53874(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 53247, 53887);

                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_53370_53384(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53370, 53384);
                    return return_v;
                }


                int
                f_25010_53358_53385(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53358, 53385);
                    return 0;
                }


                int
                f_25010_53400_53446(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53400, 53446);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_53476_53493(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53476, 53493);
                    return return_v;
                }


                int
                f_25010_53461_53494(Microsoft.CodeAnalysis.Operations.IPatternOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53461, 53494);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_53513_53528(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Guard;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53513, 53528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53558_53573(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53558, 53573);
                    return return_v;
                }


                int
                f_25010_53543_53574(Microsoft.CodeAnalysis.IOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53543, 53574);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_53601_53617(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53601, 53617);
                    return return_v;
                }


                int
                f_25010_53589_53618(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53589, 53618);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_53648_53663(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Guard;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53648, 53663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_53699_53716(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53699, 53716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53718_53733(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53718, 53733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_53763_53780(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53763, 53780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53782_53797(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Guard;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53782, 53797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_53799_53814(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53799, 53814);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_53856_53874(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 53856, 53874);
                    return return_v;
                }


                bool
                f_25010_53831_53875(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53831, 53875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 53247, 53887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 53247, 53887);
            }
        }

        public override void VisitIsPattern(IIsPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 53899, 54150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 53990, 54044);

                f_25010_53990_54043(OperationKind.IsPattern, f_25010_54028_54042(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54058, 54139);

                f_25010_54058_54138(new[] { f_25010_54081_54096(operation), f_25010_54098_54115(operation) }, f_25010_54119_54137(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 53899, 54150);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_54028_54042(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54028, 54042);
                    return return_v;
                }


                int
                f_25010_53990_54043(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 53990, 54043);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_54081_54096(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54081, 54096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_54098_54115(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54098, 54115);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_54119_54137(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54119, 54137);
                    return return_v;
                }


                bool
                f_25010_54058_54138(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54058, 54138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 53899, 54150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 53899, 54150);
            }
        }

        public override void VisitPatternCaseClause(IPatternCaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 54162, 54764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54269, 54305);

                f_25010_54269_54304(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54319, 54370);

                f_25010_54319_54369(CaseKind.Pattern, f_25010_54350_54368(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54384, 54454);

                f_25010_54384_54453(f_25010_54396_54435(((ICaseClauseOperation)operation)), f_25010_54437_54452(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54470, 54753) || true) && (f_25010_54474_54489(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 54470, 54753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54531, 54612);

                    f_25010_54531_54611(new[] { f_25010_54554_54571(operation), f_25010_54573_54588(operation) }, f_25010_54592_54610(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 54470, 54753);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 54470, 54753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54678, 54738);

                    f_25010_54678_54737(f_25010_54690_54707(operation), f_25010_54709_54736(f_25010_54709_54727(operation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 54470, 54753);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 54162, 54764);

                int
                f_25010_54269_54304(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                operation)
                {
                    VisitCaseClauseOperation((Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54269, 54304);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CaseKind
                f_25010_54350_54368(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.CaseKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54350, 54368);
                    return return_v;
                }


                int
                f_25010_54319_54369(Microsoft.CodeAnalysis.Operations.CaseKind
                expected, Microsoft.CodeAnalysis.Operations.CaseKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54319, 54369);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILabelSymbol?
                f_25010_54396_54435(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54396, 54435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_25010_54437_54452(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54437, 54452);
                    return return_v;
                }


                int
                f_25010_54384_54453(Microsoft.CodeAnalysis.ILabelSymbol?
                expected, Microsoft.CodeAnalysis.ILabelSymbol
                actual)
                {
                    Assert.Same((object?)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54384, 54453);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_54474_54489(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Guard;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54474, 54489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_54554_54571(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54554, 54571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_54573_54588(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Guard;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54573, 54588);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_54592_54610(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54592, 54610);
                    return return_v;
                }


                bool
                f_25010_54531_54611(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54531, 54611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IPatternOperation
                f_25010_54690_54707(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54690, 54707);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_54709_54727(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54709, 54727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_54709_54736(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54709, 54736);
                    return return_v;
                }


                int
                f_25010_54678_54737(Microsoft.CodeAnalysis.Operations.IPatternOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54678, 54737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 54162, 54764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 54162, 54764);
            }
        }

        public override void VisitTranslatedQuery(ITranslatedQueryOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 54776, 55026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54879, 54939);

                f_25010_54879_54938(OperationKind.TranslatedQuery, f_25010_54923_54937(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 54953, 55015);

                f_25010_54953_55014(f_25010_54965_54984(operation), f_25010_54986_55013(f_25010_54986_55004(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 54776, 55026);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_54923_54937(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54923, 54937);
                    return return_v;
                }


                int
                f_25010_54879_54938(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54879, 54938);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_54965_54984(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54965, 54984);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_54986_55004(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 54986, 55004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_54986_55013(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54986, 55013);
                    return return_v;
                }


                int
                f_25010_54953_55014(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 54953, 55014);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 54776, 55026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 54776, 55026);
            }
        }

        public override void VisitDeclarationExpression(IDeclarationExpressionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 55038, 55307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55153, 55219);

                f_25010_55153_55218(OperationKind.DeclarationExpression, f_25010_55203_55217(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55233, 55296);

                f_25010_55233_55295(f_25010_55245_55265(operation), f_25010_55267_55294(f_25010_55267_55285(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 55038, 55307);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_55203_55217(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55203, 55217);
                    return return_v;
                }


                int
                f_25010_55153_55218(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55153, 55218);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_55245_55265(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55245, 55265);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_55267_55285(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55267, 55285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_55267_55294(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55267, 55294);
                    return return_v;
                }


                int
                f_25010_55233_55295(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55233, 55295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 55038, 55307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 55038, 55307);
            }
        }

        public override void VisitDeconstructionAssignment(IDeconstructionAssignmentOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 55319, 55561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55440, 55509);

                f_25010_55440_55508(OperationKind.DeconstructionAssignment, f_25010_55493_55507(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55523, 55550);

                f_25010_55523_55549(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 55319, 55561);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_55493_55507(Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55493, 55507);
                    return return_v;
                }


                int
                f_25010_55440_55508(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55440, 55508);
                    return 0;
                }


                int
                f_25010_55523_55549(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation
                operation)
                {
                    this_param.VisitAssignment((Microsoft.CodeAnalysis.Operations.IAssignmentOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55523, 55549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 55319, 55561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 55319, 55561);
            }
        }

        public override void VisitDelegateCreation(IDelegateCreationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 55573, 55823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55678, 55739);

                f_25010_55678_55738(OperationKind.DelegateCreation, f_25010_55723_55737(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55753, 55812);

                f_25010_55753_55811(f_25010_55765_55781(operation), f_25010_55783_55810(f_25010_55783_55801(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 55573, 55823);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_55723_55737(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55723, 55737);
                    return return_v;
                }


                int
                f_25010_55678_55738(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55678, 55738);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_55765_55781(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55765, 55781);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_55783_55801(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55783, 55801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_55783_55810(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55783, 55810);
                    return return_v;
                }


                int
                f_25010_55753_55811(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55753, 55811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 55573, 55823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 55573, 55823);
            }
        }

        public override void VisitRaiseEvent(IRaiseEventOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 55835, 56118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55928, 55983);

                f_25010_55928_55982(OperationKind.RaiseEvent, f_25010_55967_55981(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 55997, 56107);

                f_25010_55997_56106(f_25010_56012_56085(new IOperation[] { f_25010_56031_56055(operation) }, f_25010_56065_56084(operation)), f_25010_56087_56105(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 55835, 56118);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_55967_55981(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 55967, 55981);
                    return return_v;
                }


                int
                f_25010_55928_55982(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55928, 55982);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
                f_25010_56031_56055(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
                this_param)
                {
                    var return_v = this_param.EventReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56031, 56055);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_56065_56084(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56065, 56084);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_56012_56085(Microsoft.CodeAnalysis.IOperation[]
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56012, 56085);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_56087_56105(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56087, 56105);
                    return return_v;
                }


                bool
                f_25010_55997_56106(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 55997, 56106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 55835, 56118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 55835, 56118);
            }
        }

        public override void VisitRangeCaseClause(IRangeCaseClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 56130, 56450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56233, 56269);

                f_25010_56233_56268(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56283, 56332);

                f_25010_56283_56331(CaseKind.Range, f_25010_56312_56330(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56346, 56439);

                f_25010_56346_56438(new[] { f_25010_56369_56391(operation), f_25010_56393_56415(operation) }, f_25010_56419_56437(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 56130, 56450);

                int
                f_25010_56233_56268(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
                operation)
                {
                    VisitCaseClauseOperation((Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56233, 56268);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CaseKind
                f_25010_56312_56330(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.CaseKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56312, 56330);
                    return return_v;
                }


                int
                f_25010_56283_56331(Microsoft.CodeAnalysis.Operations.CaseKind
                expected, Microsoft.CodeAnalysis.Operations.CaseKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56283, 56331);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_56369_56391(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.MinimumValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56369, 56391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_56393_56415(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.MaximumValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56393, 56415);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_56419_56437(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56419, 56437);
                    return return_v;
                }


                bool
                f_25010_56346_56438(Microsoft.CodeAnalysis.IOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56346, 56438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 56130, 56450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 56130, 56450);
            }
        }

        public override void VisitConstructorBodyOperation(IConstructorBodyOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 56462, 57331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56574, 56643);

                f_25010_56574_56642(OperationKind.ConstructorBodyOperation, f_25010_56627_56641(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56657, 56717);

                f_25010_56657_56716(OperationKind.ConstructorBody, f_25010_56701_56715(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56731, 56761);

                f_25010_56731_56760(f_25010_56743_56759(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56777, 56830);

                var
                builder = f_25010_56791_56829()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56846, 56963) || true) && (f_25010_56850_56871(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 56846, 56963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56913, 56948);

                    f_25010_56913_56947(builder, f_25010_56925_56946(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 56846, 56963);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 56979, 57092) || true) && (f_25010_56983_57002(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 56979, 57092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57044, 57077);

                    f_25010_57044_57076(builder, f_25010_57056_57075(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 56979, 57092);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57108, 57231) || true) && (f_25010_57112_57136(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 57108, 57231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57178, 57216);

                    f_25010_57178_57215(builder, f_25010_57190_57214(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 57108, 57231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57247, 57291);

                f_25010_57247_57290(builder, f_25010_57271_57289(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57305, 57320);

                f_25010_57305_57319(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 56462, 57331);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_56627_56641(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56627, 56641);
                    return return_v;
                }


                int
                f_25010_56574_56642(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56574, 56642);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_56701_56715(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56701, 56715);
                    return return_v;
                }


                int
                f_25010_56657_56716(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56657, 56716);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25010_56743_56759(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56743, 56759);
                    return return_v;
                }


                int
                f_25010_56731_56760(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals)
                {
                    VisitLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56731, 56760);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                f_25010_56791_56829()
                {
                    var return_v = ArrayBuilder<IOperation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56791, 56829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_56850_56871(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56850, 56871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_56925_56946(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56925, 56946);
                    return return_v;
                }


                int
                f_25010_56913_56947(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 56913, 56947);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_56983_57002(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 56983, 57002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_57056_57075(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57056, 57075);
                    return return_v;
                }


                int
                f_25010_57044_57076(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.Operations.IBlockOperation
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.IOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57044, 57076);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_57112_57136(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57112, 57136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_57190_57214(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57190, 57214);
                    return return_v;
                }


                int
                f_25010_57178_57215(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.Operations.IBlockOperation
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.IOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57178, 57215);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_57271_57289(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57271, 57289);
                    return return_v;
                }


                bool
                f_25010_57247_57290(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57247, 57290);
                    return return_v;
                }


                int
                f_25010_57305_57319(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57305, 57319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 56462, 57331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 56462, 57331);
            }
        }

        public override void VisitMethodBodyOperation(IMethodBodyOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 57343, 58288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57445, 57509);

                f_25010_57445_57508(OperationKind.MethodBodyOperation, f_25010_57493_57507(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57523, 57578);

                f_25010_57523_57577(OperationKind.MethodBody, f_25010_57562_57576(operation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57594, 58277) || true) && (f_25010_57598_57617(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 57594, 58277);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57659, 57992) || true) && (f_25010_57663_57687(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 57659, 57992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57737, 57829);

                        f_25010_57737_57828(new[] { f_25010_57760_57779(operation), f_25010_57781_57805(operation) }, f_25010_57809_57827(operation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 57659, 57992);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 57659, 57992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 57911, 57973);

                        f_25010_57911_57972(f_25010_57923_57942(operation), f_25010_57944_57971(f_25010_57944_57962(operation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 57659, 57992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 57594, 58277);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 57594, 58277);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58026, 58277) || true) && (f_25010_58030_58054(operation) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 58026, 58277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58096, 58163);

                        f_25010_58096_58162(f_25010_58108_58132(operation), f_25010_58134_58161(f_25010_58134_58152(operation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 58026, 58277);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 58026, 58277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58229, 58262);

                        f_25010_58229_58261(f_25010_58242_58260(operation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 58026, 58277);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 57594, 58277);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 57343, 58288);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_57493_57507(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57493, 57507);
                    return return_v;
                }


                int
                f_25010_57445_57508(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57445, 57508);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_57562_57576(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57562, 57576);
                    return return_v;
                }


                int
                f_25010_57523_57577(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57523, 57577);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_57598_57617(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57598, 57617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_57663_57687(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57663, 57687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_57760_57779(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57760, 57779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_57781_57805(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57781, 57805);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_57809_57827(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57809, 57827);
                    return return_v;
                }


                bool
                f_25010_57737_57828(Microsoft.CodeAnalysis.Operations.IBlockOperation[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57737, 57828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_57923_57942(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57923, 57942);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_57944_57962(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 57944, 57962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_57944_57971(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57944, 57971);
                    return return_v;
                }


                int
                f_25010_57911_57972(Microsoft.CodeAnalysis.Operations.IBlockOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 57911, 57972);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation?
                f_25010_58030_58054(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58030, 58054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IBlockOperation
                f_25010_58108_58132(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58108, 58132);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_58134_58152(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58134, 58152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_58134_58161(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58134, 58161);
                    return return_v;
                }


                int
                f_25010_58096_58162(Microsoft.CodeAnalysis.Operations.IBlockOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58096, 58162);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_58242_58260(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58242, 58260);
                    return return_v;
                }


                int
                f_25010_58229_58261(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58229, 58261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 57343, 58288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 57343, 58288);
            }
        }

        public override void VisitDiscardOperation(IDiscardOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 58300, 58629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58396, 58448);

                f_25010_58396_58447(OperationKind.Discard, f_25010_58432_58446(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58462, 58495);

                f_25010_58462_58494(f_25010_58475_58493(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58511, 58555);

                var
                discardSymbol = f_25010_58531_58554(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58569, 58618);

                f_25010_58569_58617(f_25010_58582_58596(operation), f_25010_58598_58616(discardSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 58300, 58629);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_58432_58446(Microsoft.CodeAnalysis.Operations.IDiscardOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58432, 58446);
                    return return_v;
                }


                int
                f_25010_58396_58447(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58396, 58447);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_58475_58493(Microsoft.CodeAnalysis.Operations.IDiscardOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58475, 58493);
                    return return_v;
                }


                int
                f_25010_58462_58494(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58462, 58494);
                    return 0;
                }


                Microsoft.CodeAnalysis.IDiscardSymbol
                f_25010_58531_58554(Microsoft.CodeAnalysis.Operations.IDiscardOperation
                this_param)
                {
                    var return_v = this_param.DiscardSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58531, 58554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_58582_58596(Microsoft.CodeAnalysis.Operations.IDiscardOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58582, 58596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_25010_58598_58616(Microsoft.CodeAnalysis.IDiscardSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58598, 58616);
                    return return_v;
                }


                int
                f_25010_58569_58617(Microsoft.CodeAnalysis.ITypeSymbol?
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58569, 58617);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 58300, 58629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 58300, 58629);
            }
        }

        public override void VisitDiscardPattern(IDiscardPatternOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 58641, 58903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58742, 58801);

                f_25010_58742_58800(OperationKind.DiscardPattern, f_25010_58785_58799(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58815, 58845);

                f_25010_58815_58844(this, operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 58859, 58892);

                f_25010_58859_58891(f_25010_58872_58890(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 58641, 58903);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_58785_58799(Microsoft.CodeAnalysis.Operations.IDiscardPatternOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58785, 58799);
                    return return_v;
                }


                int
                f_25010_58742_58800(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58742, 58800);
                    return 0;
                }


                int
                f_25010_58815_58844(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                this_param, Microsoft.CodeAnalysis.Operations.IDiscardPatternOperation
                pattern)
                {
                    this_param.VisitPatternCommon((Microsoft.CodeAnalysis.Operations.IPatternOperation)pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58815, 58844);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_58872_58890(Microsoft.CodeAnalysis.Operations.IDiscardPatternOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 58872, 58890);
                    return return_v;
                }


                int
                f_25010_58859_58891(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 58859, 58891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 58641, 58903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 58641, 58903);
            }
        }

        public override void VisitFlowCapture(IFlowCaptureOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 58915, 60368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 59010, 59066);

                f_25010_59010_59065(OperationKind.FlowCapture, f_25010_59050_59064(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 59080, 59114);

                f_25010_59080_59113(f_25010_59092_59112(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 59128, 59186);

                f_25010_59128_59185(f_25010_59140_59155(operation), f_25010_59157_59184(f_25010_59157_59175(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 59202, 60357);

                switch (f_25010_59210_59230(f_25010_59210_59225(operation)))
                {

                    case OperationKind.Invalid:
                    case OperationKind.None:
                    case OperationKind.AnonymousFunction:
                    case OperationKind.FlowCaptureReference:
                    case OperationKind.DefaultValue:
                    case OperationKind.FlowAnonymousFunction: // must be an error case like in Microsoft.CodeAnalysis.CSharp.UnitTests.ConditionalOperatorTests.TestBothUntyped unit-test
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 59202, 60357);
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 59701, 59707);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 59202, 60357);

                    case OperationKind.OmittedArgument:
                    case OperationKind.DeclarationExpression:
                    case OperationKind.Discard:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 59202, 60357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 59888, 59976);

                        f_25010_59888_59975(true, $"A {f_25010_59912_59932(f_25010_59912_59927(operation))} node should not be spilled or captured.");
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 59998, 60004);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 59202, 60357);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 59202, 60357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60114, 60314) || true) && (f_25010_60118_60157_M(!f_25010_60119_60134(operation).ConstantValue.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(25010, 60118, 60204) || f_25010_60161_60176(operation).ConstantValue.Value != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 60114, 60314);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60254, 60291);

                            f_25010_60254_60290(f_25010_60269_60289(f_25010_60269_60284(operation)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 60114, 60314);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(25010, 60336, 60342);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 59202, 60357);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 58915, 60368);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_59050_59064(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59050, 59064);
                    return return_v;
                }


                int
                f_25010_59010_59065(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 59010, 59065);
                    return 0;
                }


                bool
                f_25010_59092_59112(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59092, 59112);
                    return return_v;
                }


                int
                f_25010_59080_59113(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 59080, 59113);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_59140_59155(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59140, 59155);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_59157_59175(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59157, 59175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_59157_59184(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 59157, 59184);
                    return return_v;
                }


                int
                f_25010_59128_59185(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 59128, 59185);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_59210_59225(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59210, 59225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_59210_59230(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59210, 59230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_59912_59927(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59912, 59927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25010_59912_59932(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 59912, 59932);
                    return return_v;
                }


                int
                f_25010_59888_59975(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 59888, 59975);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_60119_60134(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60119, 60134);
                    return return_v;
                }


                bool
                f_25010_60118_60157_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60118, 60157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_60161_60176(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60161, 60176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_60269_60284(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60269, 60284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_60269_60289(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60269, 60289);
                    return return_v;
                }


                int
                f_25010_60254_60290(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60254, 60290);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 58915, 60368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 58915, 60368);
            }
        }

        public override void VisitFlowCaptureReference(IFlowCaptureReferenceOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 60380, 60664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60493, 60558);

                f_25010_60493_60557(OperationKind.FlowCaptureReference, f_25010_60542_60556(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60572, 60606);

                f_25010_60572_60605(f_25010_60584_60604(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60620, 60653);

                f_25010_60620_60652(f_25010_60633_60651(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 60380, 60664);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_60542_60556(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60542, 60556);
                    return return_v;
                }


                int
                f_25010_60493_60557(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60493, 60557);
                    return 0;
                }


                bool
                f_25010_60584_60604(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60584, 60604);
                    return return_v;
                }


                int
                f_25010_60572_60605(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60572, 60605);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_60633_60651(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60633, 60651);
                    return return_v;
                }


                int
                f_25010_60620_60652(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60620, 60652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 60380, 60664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 60380, 60664);
            }
        }

        public override void VisitIsNull(IIsNullOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 60676, 60945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60761, 60812);

                f_25010_60761_60811(OperationKind.IsNull, f_25010_60796_60810(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60826, 60860);

                f_25010_60826_60859(f_25010_60838_60858(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 60874, 60934);

                f_25010_60874_60933(f_25010_60886_60903(operation), f_25010_60905_60932(f_25010_60905_60923(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 60676, 60945);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_60796_60810(Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60796, 60810);
                    return return_v;
                }


                int
                f_25010_60761_60811(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60761, 60811);
                    return 0;
                }


                bool
                f_25010_60838_60858(Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60838, 60858);
                    return return_v;
                }


                int
                f_25010_60826_60859(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60826, 60859);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_60886_60903(Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60886, 60903);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_60905_60923(Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 60905, 60923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_60905_60932(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60905, 60932);
                    return return_v;
                }


                int
                f_25010_60874_60933(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 60874, 60933);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 60676, 60945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 60676, 60945);
            }
        }

        public override void VisitCaughtException(ICaughtExceptionOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 60957, 61226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61060, 61120);

                f_25010_61060_61119(OperationKind.CaughtException, f_25010_61104_61118(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61134, 61168);

                f_25010_61134_61167(f_25010_61146_61166(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61182, 61215);

                f_25010_61182_61214(f_25010_61195_61213(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 60957, 61226);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_61104_61118(Microsoft.CodeAnalysis.FlowAnalysis.ICaughtExceptionOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61104, 61118);
                    return return_v;
                }


                int
                f_25010_61060_61119(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61060, 61119);
                    return 0;
                }


                bool
                f_25010_61146_61166(Microsoft.CodeAnalysis.FlowAnalysis.ICaughtExceptionOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61146, 61166);
                    return return_v;
                }


                int
                f_25010_61134_61167(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61134, 61167);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_61195_61213(Microsoft.CodeAnalysis.FlowAnalysis.ICaughtExceptionOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61195, 61213);
                    return return_v;
                }


                int
                f_25010_61182_61214(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61182, 61214);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 60957, 61226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 60957, 61226);
            }
        }

        public override void VisitStaticLocalInitializationSemaphore(IStaticLocalInitializationSemaphoreOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 61238, 61662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61379, 61458);

                f_25010_61379_61457(OperationKind.StaticLocalInitializationSemaphore, f_25010_61442_61456(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61472, 61506);

                f_25010_61472_61505(f_25010_61484_61504(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61520, 61553);

                f_25010_61520_61552(f_25010_61533_61551(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61567, 61599);

                f_25010_61567_61598(f_25010_61582_61597(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61613, 61651);

                f_25010_61613_61650(f_25010_61625_61649(f_25010_61625_61640(operation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 61238, 61662);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_61442_61456(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61442, 61456);
                    return return_v;
                }


                int
                f_25010_61379_61457(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61379, 61457);
                    return 0;
                }


                bool
                f_25010_61484_61504(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61484, 61504);
                    return return_v;
                }


                int
                f_25010_61472_61505(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61472, 61505);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_61533_61551(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61533, 61551);
                    return return_v;
                }


                int
                f_25010_61520_61552(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61520, 61552);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25010_61582_61597(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61582, 61597);
                    return return_v;
                }


                int
                f_25010_61567_61598(Microsoft.CodeAnalysis.ILocalSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61567, 61598);
                    return 0;
                }


                Microsoft.CodeAnalysis.ILocalSymbol
                f_25010_61625_61640(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
                this_param)
                {
                    var return_v = this_param.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61625, 61640);
                    return return_v;
                }


                bool
                f_25010_61625_61649(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61625, 61649);
                    return return_v;
                }


                int
                f_25010_61613_61650(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61613, 61650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 61238, 61662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 61238, 61662);
            }
        }

        public override void VisitRangeOperation(IRangeOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 61674, 62285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61766, 61816);

                f_25010_61766_61815(OperationKind.Range, f_25010_61800_61814(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61832, 61885);

                IOperation[]
                children = f_25010_61856_61884(f_25010_61856_61874(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61901, 61915);

                int
                index = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61931, 62067) || true) && (f_25010_61935_61956(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 61931, 62067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 61998, 62052);

                    f_25010_61998_62051(f_25010_62010_62031(operation), children[index++]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 61931, 62067);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62083, 62221) || true) && (f_25010_62087_62109(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 62083, 62221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62151, 62206);

                    f_25010_62151_62205(f_25010_62163_62185(operation), children[index++]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 62083, 62221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62237, 62274);

                f_25010_62237_62273(index, f_25010_62257_62272(children));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 61674, 62285);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_61800_61814(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61800, 61814);
                    return return_v;
                }


                int
                f_25010_61766_61815(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61766, 61815);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_61856_61874(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61856, 61874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation[]
                f_25010_61856_61884(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61856, 61884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_61935_61956(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 61935, 61956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_62010_62031(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62010, 62031);
                    return return_v;
                }


                int
                f_25010_61998_62051(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 61998, 62051);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25010_62087_62109(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62087, 62109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_62163_62185(Microsoft.CodeAnalysis.Operations.IRangeOperation
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62163, 62185);
                    return return_v;
                }


                int
                f_25010_62151_62205(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    Assert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62151, 62205);
                    return 0;
                }


                int
                f_25010_62257_62272(Microsoft.CodeAnalysis.IOperation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62257, 62272);
                    return return_v;
                }


                int
                f_25010_62237_62273(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62237, 62273);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 61674, 62285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 61674, 62285);
            }
        }

        public override void VisitReDim(IReDimOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 62297, 62557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62380, 62430);

                f_25010_62380_62429(OperationKind.ReDim, f_25010_62414_62428(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62444, 62498);

                f_25010_62444_62497(f_25010_62459_62476(operation), f_25010_62478_62496(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62512, 62546);

                var
                preserve = f_25010_62527_62545(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 62297, 62557);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_62414_62428(Microsoft.CodeAnalysis.Operations.IReDimOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62414, 62428);
                    return return_v;
                }


                int
                f_25010_62380_62429(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62380, 62429);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IReDimClauseOperation>
                f_25010_62459_62476(Microsoft.CodeAnalysis.Operations.IReDimOperation
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62459, 62476);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_62478_62496(Microsoft.CodeAnalysis.Operations.IReDimOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62478, 62496);
                    return return_v;
                }


                bool
                f_25010_62444_62497(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IReDimClauseOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62444, 62497);
                    return return_v;
                }


                bool
                f_25010_62527_62545(Microsoft.CodeAnalysis.Operations.IReDimOperation
                this_param)
                {
                    var return_v = this_param.Preserve;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62527, 62545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 62297, 62557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 62297, 62557);
            }
        }

        public override void VisitReDimClause(IReDimClauseOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 62569, 62876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62664, 62720);

                f_25010_62664_62719(OperationKind.ReDimClause, f_25010_62704_62718(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62734, 62865);

                f_25010_62734_62864(f_25010_62749_62843(f_25010_62749_62810(f_25010_62792_62809(operation)), f_25010_62818_62842(operation)), f_25010_62845_62863(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 62569, 62876);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_62704_62718(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62704, 62718);
                    return return_v;
                }


                int
                f_25010_62664_62719(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62664, 62719);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_62792_62809(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62792, 62809);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_62749_62810(Microsoft.CodeAnalysis.IOperation
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62749, 62810);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25010_62818_62842(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
                this_param)
                {
                    var return_v = this_param.DimensionSizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62818, 62842);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_62749_62843(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62749, 62843);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_62845_62863(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 62845, 62863);
                    return return_v;
                }


                bool
                f_25010_62734_62864(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62734, 62864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 62569, 62876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 62569, 62876);
            }
        }

        public override void VisitUsingDeclaration(IUsingDeclarationOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 62888, 63810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 62993, 63036);

                f_25010_62993_63035(f_25010_63008_63034(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63050, 63157);

                f_25010_63050_63156(f_25010_63065_63135(f_25010_63108_63134(operation)), f_25010_63137_63155(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63171, 63222);

                f_25010_63171_63221(f_25010_63183_63220(f_25010_63183_63209(operation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63236, 63264);

                f_25010_63236_63263(f_25010_63248_63262(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63278, 63325);

                f_25010_63278_63324(operation.ConstantValue.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63339, 63368);

                _ = f_25010_63343_63367(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63382, 63407);

                _ = f_25010_63386_63406(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63423, 63492);

                _ = ((UsingDeclarationOperation)operation).DisposeInfo.DisposeMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63506, 63592);

                var
                disposeArgs = ((UsingDeclarationOperation)operation).DisposeInfo.DisposeArguments
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63606, 63799) || true) && (f_25010_63610_63639_M(!disposeArgs.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 63606, 63799);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63673, 63784);
                        foreach (var arg in f_25010_63693_63704_I(disposeArgs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25010, 63673, 63784);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63746, 63765);

                            f_25010_63746_63764(arg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 63673, 63784);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25010, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25010, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25010, 63606, 63799);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 62888, 63810);

                Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                f_25010_63008_63034(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.DeclarationGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63008, 63034);
                    return return_v;
                }


                int
                f_25010_62993_63035(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 62993, 63035);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                f_25010_63108_63134(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.DeclarationGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63108, 63134);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation>
                f_25010_63065_63135(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63065, 63135);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_63137_63155(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63137, 63155);
                    return return_v;
                }


                bool
                f_25010_63050_63156(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63050, 63156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                f_25010_63183_63209(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.DeclarationGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63183, 63209);
                    return return_v;
                }


                bool
                f_25010_63183_63220(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63183, 63220);
                    return return_v;
                }


                int
                f_25010_63171_63221(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63171, 63221);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25010_63248_63262(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63248, 63262);
                    return return_v;
                }


                int
                f_25010_63236_63263(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63236, 63263);
                    return 0;
                }


                int
                f_25010_63278_63324(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63278, 63324);
                    return 0;
                }


                bool
                f_25010_63343_63367(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.IsAsynchronous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63343, 63367);
                    return return_v;
                }


                bool
                f_25010_63386_63406(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63386, 63406);
                    return return_v;
                }


                bool
                f_25010_63610_63639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63610, 63639);
                    return return_v;
                }


                int
                f_25010_63746_63764(Microsoft.CodeAnalysis.Operations.IArgumentOperation
                root)
                {
                    VerifySubTree((Microsoft.CodeAnalysis.IOperation)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63746, 63764);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_25010_63693_63704_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63693, 63704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 62888, 63810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 62888, 63810);
            }
        }

        public override void VisitWith(IWithOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25010, 63822, 64203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63903, 63952);

                f_25010_63903_63951(OperationKind.With, f_25010_63936_63950(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 63966, 63992);

                _ = f_25010_63970_63991(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 64006, 64133);

                IEnumerable<IOperation>
                children = f_25010_64041_64132(f_25010_64041_64102(f_25010_64084_64101(operation)), f_25010_64110_64131(operation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 64147, 64192);

                f_25010_64147_64191(children, f_25010_64172_64190(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25010, 63822, 64203);

                Microsoft.CodeAnalysis.OperationKind
                f_25010_63936_63950(Microsoft.CodeAnalysis.Operations.IWithOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63936, 63950);
                    return return_v;
                }


                int
                f_25010_63903_63951(Microsoft.CodeAnalysis.OperationKind
                expected, Microsoft.CodeAnalysis.OperationKind
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 63903, 63951);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25010_63970_63991(Microsoft.CodeAnalysis.Operations.IWithOperation
                this_param)
                {
                    var return_v = this_param.CloneMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 63970, 63991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25010_64084_64101(Microsoft.CodeAnalysis.Operations.IWithOperation
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 64084, 64101);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_64041_64102(Microsoft.CodeAnalysis.IOperation
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 64041, 64102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                f_25010_64110_64131(Microsoft.CodeAnalysis.Operations.IWithOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 64110, 64131);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_64041_64132(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source, Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
                value)
                {
                    var return_v = source.Concat<Microsoft.CodeAnalysis.IOperation>((Microsoft.CodeAnalysis.IOperation)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 64041, 64132);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25010_64172_64190(Microsoft.CodeAnalysis.Operations.IWithOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25010, 64172, 64190);
                    return return_v;
                }


                bool
                f_25010_64147_64191(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                actual)
                {
                    var return_v = AssertEx.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 64147, 64191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25010, 63822, 64203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 63822, 64203);
            }
        }

        static TestOperationVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25010, 621, 64210);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25010, 741, 779);
            Singleton = f_25010_753_779(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25010, 621, 64210);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25010, 621, 64210);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25010, 621, 64210);

        static Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
        f_25010_753_779()
        {
            var return_v = new Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25010, 753, 779);
            return return_v;
        }

    }
}
