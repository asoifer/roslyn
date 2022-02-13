// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundObjectCreationExpression
    {
        public BoundObjectCreationExpression(SyntaxNode syntax, MethodSymbol constructor, ImmutableArray<BoundExpression> arguments, ImmutableArray<string> argumentNamesOpt,
                                                     ImmutableArray<RefKind> argumentRefKindsOpt, bool expanded, ImmutableArray<int> argsToParamsOpt, BitVector defaultArguments, ConstantValue? constantValueOpt,
                                                     BoundObjectInitializerExpressionBase? initializerExpressionOpt, TypeSymbol type, bool hasErrors = false)
        : this(f_10569_951_957_C(syntax), constructor, ImmutableArray<MethodSymbol>.Empty, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, wasTargetTyped: false, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10569, 410, 1199);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10569, 410, 1199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10569, 410, 1199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10569, 410, 1199);
            }
        }

        public BoundObjectCreationExpression Update(MethodSymbol constructor, ImmutableArray<BoundExpression> arguments, ImmutableArray<string> argumentNamesOpt, ImmutableArray<RefKind> argumentRefKindsOpt, bool expanded,
                                                            ImmutableArray<int> argsToParamsOpt, BitVector defaultArguments, ConstantValue? constantValueOpt, BoundObjectInitializerExpressionBase? initializerExpressionOpt, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10569, 1211, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10569, 1681, 1915);

                return f_10569_1688_1914(this, constructor, ImmutableArray<MethodSymbol>.Empty, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, f_10569_1888_1907(this), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10569, 1211, 1926);

                bool
                f_10569_1888_1907(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.WasTargetTyped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10569, 1888, 1907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10569_1688_1914(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                constructorsGroup, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, bool
                wasTargetTyped, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor, constructorsGroup, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, wasTargetTyped, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10569, 1688, 1914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10569, 1211, 1926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10569, 1211, 1926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundObjectCreationExpression Update(MethodSymbol constructor, ImmutableArray<MethodSymbol> constructorsGroup, ImmutableArray<BoundExpression> arguments,
                                                            ImmutableArray<string> argumentNamesOpt, ImmutableArray<RefKind> argumentRefKindsOpt, bool expanded, ImmutableArray<int> argsToParamsOpt,
                                                            BitVector defaultArguments, ConstantValue? constantValueOpt, BoundObjectInitializerExpressionBase? initializerExpressionOpt, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10569, 1938, 2737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10569, 2509, 2726);

                return f_10569_2516_2725(this, constructor, constructorsGroup, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, f_10569_2699_2718(this), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10569, 1938, 2737);

                bool
                f_10569_2699_2718(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.WasTargetTyped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10569, 2699, 2718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10569_2516_2725(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                constructorsGroup, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, bool
                wasTargetTyped, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor, constructorsGroup, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, wasTargetTyped, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10569, 2516, 2725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10569, 1938, 2737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10569, 1938, 2737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10569_951_957_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10569, 410, 1199);
            return return_v;
        }

    }
}
