// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ForEachLoopBinder : LoopBinder
    {
        private const string
        GetEnumeratorMethodName = WellKnownMemberNames.GetEnumeratorMethodName
        ;

        private const string
        CurrentPropertyName = WellKnownMemberNames.CurrentPropertyName
        ;

        private const string
        MoveNextMethodName = WellKnownMemberNames.MoveNextMethodName
        ;

        private const string
        GetAsyncEnumeratorMethodName = WellKnownMemberNames.GetAsyncEnumeratorMethodName
        ;

        private const string
        MoveNextAsyncMethodName = WellKnownMemberNames.MoveNextAsyncMethodName
        ;

        private readonly CommonForEachStatementSyntax _syntax;

        private SourceLocalSymbol IterationVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 1634, 1783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1670, 1768);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 1677, 1724) || (((f_10340_1678_1692(_syntax) == SyntaxKind.ForEachStatement) && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 1727, 1760)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 1763, 1767))) ? (SourceLocalSymbol)f_10340_1746_1757(this)[0] : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 1634, 1783);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10340_1678_1692(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 1678, 1692);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10340_1746_1757(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 1746, 1757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 1566, 1794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 1566, 1794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 1840, 1874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1843, 1874);
                    return f_10340_1843_1863(_syntax) != default; DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 1840, 1874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 1840, 1874);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 1840, 1874);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ForEachLoopBinder(Binder enclosing, CommonForEachStatementSyntax syntax)
        : base(f_10340_1987_1996_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10340, 1887, 2093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1548, 1555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2022, 2051);

                f_10340_2022_2050(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2065, 2082);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10340, 1887, 2093);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 1887, 2093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 1887, 2093);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 2105, 3526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2190, 3515);

                switch (f_10340_2198_2212(_syntax))
                {

                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 2190, 3515);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2336, 2389);

                            var
                            syntax = (ForEachVariableStatementSyntax)_syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2415, 2468);

                            var
                            locals = f_10340_2428_2467()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2494, 2723);

                            f_10340_2494_2722(this, f_10340_2556_2571(syntax), LocalDeclarationKind.ForEachIterationVariable, locals, syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2749, 2784);

                            return f_10340_2756_2783(locals);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 2190, 3515);

                    case SyntaxKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 2190, 3515);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2907, 2952);

                            var
                            syntax = (ForEachStatementSyntax)_syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 2978, 3285);

                            var
                            iterationVariable = f_10340_3002_3284(f_10340_3081_3110(this), this, f_10340_3176_3187(syntax), f_10340_3218_3235(syntax), f_10340_3266_3283(syntax))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 3311, 3372);

                            return f_10340_3318_3371(iterationVariable);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 2190, 3515);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 2190, 3515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 3443, 3500);

                        throw f_10340_3449_3499(f_10340_3484_3498(_syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 2190, 3515);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 2105, 3526);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_2198_2212(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 2198, 2212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10340_2428_2467()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 2428, 2467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_2556_2571(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 2556, 2571);
                    return return_v;
                }


                int
                f_10340_2494_2722(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                deconstructionStatement)
                {
                    this_param.CollectLocalsFromDeconstruction(declaration, kind, locals, (Microsoft.CodeAnalysis.SyntaxNode)deconstructionStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 2494, 2722);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10340_2756_2783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 2756, 2783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10340_3081_3110(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 3081, 3110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10340_3176_3187(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 3176, 3187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10340_3218_3235(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 3218, 3235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_3266_3283(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 3266, 3283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10340_3002_3284(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMethod, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                collection)
                {
                    var return_v = SourceLocalSymbol.MakeForeachLocal((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)containingMethod, binder, typeSyntax, identifierToken, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 3002, 3284);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10340_3318_3371(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 3318, 3371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_3484_3498(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 3484, 3498);
                    return return_v;
                }


                System.Exception
                f_10340_3449_3499(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 3449, 3499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 2105, 3526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 2105, 3526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CollectLocalsFromDeconstruction(
                    ExpressionSyntax declaration,
                    LocalDeclarationKind kind,
                    ArrayBuilder<LocalSymbol> locals,
                    SyntaxNode deconstructionStatement,
                    Binder enclosingBinderOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 3538, 5172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 3835, 5161);

                switch (f_10340_3843_3861(declaration))
                {

                    case SyntaxKind.TupleExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 3835, 5161);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 3976, 4023);

                            var
                            tuple = (TupleExpressionSyntax)declaration
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 4049, 4276);
                                foreach (var arg in f_10340_4069_4084_I(f_10340_4069_4084(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 4049, 4276);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 4142, 4249);

                                    f_10340_4142_4248(this, f_10340_4174_4188(arg), kind, locals, deconstructionStatement, enclosingBinderOpt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 4049, 4276);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10340, 1, 228);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10340, 1, 228);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 4302, 4308);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 3835, 5161);

                    case SyntaxKind.DeclarationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 3835, 5161);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 4436, 4505);

                            var
                            declarationExpression = (DeclarationExpressionSyntax)declaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 4531, 4744);

                            f_10340_4531_4743(this, f_10340_4593_4626(declarationExpression), f_10340_4628_4654(declarationExpression), kind, locals, deconstructionStatement, enclosingBinderOpt);
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 4772, 4778);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 3835, 5161);

                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 3835, 5161);
                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 4872, 4878);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 3835, 5161);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 3835, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 5042, 5118);

                        f_10340_5042_5117(this, locals, declaration);
                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 5140, 5146);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 3835, 5161);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 3538, 5172);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_3843_3861(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 3843, 3861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10340_4069_4084(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 4069, 4084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_4174_4188(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 4174, 4188);
                    return return_v;
                }


                int
                f_10340_4142_4248(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.SyntaxNode
                deconstructionStatement, Microsoft.CodeAnalysis.CSharp.Binder?
                enclosingBinderOpt)
                {
                    this_param.CollectLocalsFromDeconstruction(declaration, kind, locals, deconstructionStatement, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 4142, 4248);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10340_4069_4084_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 4069, 4084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10340_4593_4626(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 4593, 4626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10340_4628_4654(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 4628, 4654);
                    return return_v;
                }


                int
                f_10340_4531_4743(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.SyntaxNode
                deconstructionStatement, Microsoft.CodeAnalysis.CSharp.Binder?
                enclosingBinderOpt)
                {
                    this_param.CollectLocalsFromDeconstruction(designation, closestTypeSyntax, kind, locals, deconstructionStatement, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 4531, 4743);
                    return 0;
                }


                int
                f_10340_5042_5117(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 5042, 5117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 3538, 5172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 3538, 5172);
            }
        }

        internal void CollectLocalsFromDeconstruction(
                    VariableDesignationSyntax designation,
                    TypeSyntax closestTypeSyntax,
                    LocalDeclarationKind kind,
                    ArrayBuilder<LocalSymbol> locals,
                    SyntaxNode deconstructionStatement,
                    Binder enclosingBinderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 5184, 7266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 5526, 7255);

                switch (f_10340_5534_5552(designation))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 5526, 7255);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 5677, 5735);

                            var
                            single = (SingleVariableDesignationSyntax)designation
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 5761, 6453);

                            SourceLocalSymbol
                            localSymbol = f_10340_5793_6452(f_10340_5905_5934(this), this, enclosingBinderOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder>(10340, 6080, 6106) ?? this), closestTypeSyntax, f_10340_6265_6282(single), kind, deconstructionStatement)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 6479, 6503);

                            f_10340_6479_6502(locals, localSymbol);
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 6529, 6535);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 5526, 7255);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 5526, 7255);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 6674, 6738);

                            var
                            tuple = (ParenthesizedVariableDesignationSyntax)designation
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 6764, 6995);
                                foreach (var d in f_10340_6782_6797_I(f_10340_6782_6797(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 6764, 6995);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 6855, 6968);

                                    f_10340_6855_6967(this, d, closestTypeSyntax, kind, locals, deconstructionStatement, enclosingBinderOpt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 6764, 6995);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10340, 1, 232);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10340, 1, 232);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 7021, 7027);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 5526, 7255);

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 5526, 7255);
                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 7125, 7131);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 5526, 7255);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 5526, 7255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 7179, 7240);

                        throw f_10340_7185_7239(f_10340_7220_7238(designation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 5526, 7255);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 5184, 7266);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_5534_5552(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 5534, 5552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10340_5905_5934(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 5905, 5934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10340_6265_6282(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 6265, 6282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10340_5793_6452(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                deconstruction)
                {
                    var return_v = SourceLocalSymbol.MakeDeconstructionLocal(containingSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, nodeBinder, closestTypeSyntax, identifierToken, kind, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 5793, 6452);
                    return return_v;
                }


                int
                f_10340_6479_6502(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 6479, 6502);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10340_6782_6797(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 6782, 6797);
                    return return_v;
                }


                int
                f_10340_6855_6967(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.SyntaxNode
                deconstructionStatement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinderOpt)
                {
                    this_param.CollectLocalsFromDeconstruction(designation, closestTypeSyntax, kind, locals, deconstructionStatement, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 6855, 6967);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10340_6782_6797_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 6782, 6797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_7220_7238(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 7220, 7238);
                    return return_v;
                }


                System.Exception
                f_10340_7185_7239(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 7185, 7239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 5184, 7266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 5184, 7266);
            }
        }

        internal override BoundStatement BindForEachParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 7398, 7644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 7522, 7605);

                BoundForEachStatement
                result = f_10340_7553_7604(this, diagnostics, originalBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 7619, 7633);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 7398, 7644);

                Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                f_10340_7553_7604(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = this_param.BindForEachPartsWorker(diagnostics, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 7553, 7604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 7398, 7644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 7398, 7644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindForEachDeconstruction(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 7852, 9719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8057, 8196);

                BoundExpression
                collectionExpr = f_10340_8090_8195(f_10340_8090_8134(originalBinder, f_10340_8115_8133(_syntax)), f_10340_8163_8181(_syntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8212, 8262);

                var
                builder = f_10340_8226_8261()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8276, 8309);

                TypeWithAnnotations
                inferredType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8323, 8452);

                bool
                hasErrors = !f_10340_8341_8451(this, ref builder, ref collectionExpr, diagnostics, out inferredType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8468, 8548);

                ExpressionSyntax
                variables = f_10340_8497_8547(((ForEachVariableStatementSyntax)_syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8715, 8862);

                var
                valuePlaceholder = f_10340_8738_8861(f_10340_8775_8793(_syntax), f_10340_8795_8815(this), inferredType.Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(10340, 8817, 8860) ?? f_10340_8838_8860(this, "var")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8878, 8925);

                DeclarationExpressionSyntax
                declaration = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8939, 8974);

                ExpressionSyntax
                expression = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 8988, 9631);

                BoundDeconstructionAssignmentOperator
                deconstruction = f_10340_9043_9630(this, variables, variables, right: f_10340_9263_9281(_syntax), diagnostics: diagnostics, rightPlaceholder: valuePlaceholder, declaration: ref declaration, expression: ref expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 9647, 9708);

                return f_10340_9654_9707(_syntax, deconstruction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 7852, 9719);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_8115_8133(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 8115, 8133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10340_8090_8134(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8090, 8134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_8163_8181(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 8163, 8181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10340_8090_8195(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8090, 8195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_8226_8261()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8226, 8261);
                    return return_v;
                }


                bool
                f_10340_8341_8451(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                inferredType)
                {
                    var return_v = this_param.GetEnumeratorInfoAndInferCollectionElementType(ref builder, ref collectionExpr, diagnostics, out inferredType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8341, 8451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_8497_8547(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 8497, 8547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_8775_8793(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 8775, 8793);
                    return return_v;
                }


                uint
                f_10340_8795_8815(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 8795, 8815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_8838_8860(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8838, 8860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10340_8738_8861(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 8738, 8861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_9263_9281(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 9263, 9281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10340_9043_9630(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                deconstruction, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                rightPlaceholder, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                expression)
                {
                    var return_v = this_param.BindDeconstruction((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)deconstruction, left, right: right, diagnostics: diagnostics, rightPlaceholder: rightPlaceholder, declaration: ref declaration, expression: ref expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 9043, 9630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10340_9654_9707(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                expression)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 9654, 9707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 7852, 9719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 7852, 9719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundForEachStatement BindForEachPartsWorker(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 9731, 30174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 9930, 10069);

                BoundExpression
                collectionExpr = f_10340_9963_10068(f_10340_9963_10007(originalBinder, f_10340_9988_10006(_syntax)), f_10340_10036_10054(_syntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10085, 10135);

                var
                builder = f_10340_10099_10134()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10149, 10182);

                TypeWithAnnotations
                inferredType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10196, 10325);

                bool
                hasErrors = !f_10340_10214_10324(this, ref builder, ref collectionExpr, diagnostics, out inferredType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10460, 10494);

                hasErrors |= builder.IsIncomplete;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10510, 10546);

                BoundAwaitableInfo
                awaitInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10560, 10629);

                MethodSymbol
                getEnumeratorMethod = f_10340_10595_10628_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder.GetEnumeratorInfo, 10340, 10595, 10628)?.Method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10643, 11607) || true) && (getEnumeratorMethod != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 10643, 11607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10708, 10811);

                    f_10340_10708_10810(originalBinder, collectionExpr, getEnumeratorMethod, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10831, 11592) || true) && (f_10340_10835_10872(getEnumeratorMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 10835, 10886) && !hasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 10831, 11592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 10928, 11049);

                        var
                        messageId = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 10944, 10951) || ((f_10340_10944_10951() && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 10954, 11002)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 11005, 11048))) ? MessageID.IDS_FeatureExtensionGetAsyncEnumerator : MessageID.IDS_FeatureExtensionGetEnumerator
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11071, 11254);

                        hasErrors |= !f_10340_11085_11253(messageId, diagnostics, f_10340_11184_11195(), f_10340_11222_11252(collectionExpr.Syntax));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11278, 11573) || true) && (f_10340_11282_11319(getEnumeratorMethod) is { IsDefault: false } refKinds && (DynAbs.Tracing.TraceSender.Expression_True(10340, 11282, 11382) && refKinds[0] == RefKind.Ref))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 11278, 11573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11432, 11507);

                            f_10340_11432_11506(diagnostics, ErrorCode.ERR_RefLvalueExpected, collectionExpr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11533, 11550);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 11278, 11573);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 10831, 11592);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 10643, 11607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11621, 12582) || true) && (f_10340_11625_11632())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 11621, 12582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11666, 11696);

                    var
                    expr = f_10340_11677_11695(_syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11714, 11810);

                    f_10340_11714_11809(this, expr, _syntax.AwaitKeyword.GetLocation(), diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 11855, 12070);

                    var
                    placeholder = f_10340_11873_12069(expr, valEscape: f_10340_11925_11945(this), ((DynAbs.Tracing.TraceSender.Conditional_F1(10340, 11970, 11998) || ((builder.MoveNextInfo != null && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 12001, 12039)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 12042, 12046))) ? f_10340_12001_12039(f_10340_12001_12028(builder.MoveNextInfo)) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10340, 11969, 12068) ?? f_10340_12051_12068(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12088, 12161);

                    awaitInfo = f_10340_12100_12160(this, placeholder, expr, diagnostics, ref hasErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12208, 12567) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10340, 12212, 12331) && (f_10340_12227_12246(awaitInfo) == null || (DynAbs.Tracing.TraceSender.Expression_False(10340, 12227, 12330) || f_10340_12258_12300(f_10340_12258_12288(f_10340_12258_12277(awaitInfo))) != SpecialType.System_Boolean))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 12208, 12567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12373, 12509);

                        f_10340_12373_12508(diagnostics, ErrorCode.ERR_BadGetAsyncEnumerator, f_10340_12426_12439(expr), f_10340_12441_12486(getEnumeratorMethod), getEnumeratorMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12531, 12548);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 12208, 12567);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 11621, 12582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12598, 12640);

                TypeWithAnnotations
                iterationVariableType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12654, 12701);

                BoundTypeExpression
                boundIterationVariableType
                = default(BoundTypeExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12715, 12745);

                bool
                hasNameConflicts = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12759, 12810);

                BoundForEachDeconstructStep
                deconstructStep = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12824, 12872);

                BoundExpression
                iterationErrorExpression = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12886, 12961);

                uint
                collectionEscape = f_10340_12910_12960(collectionExpr, f_10340_12939_12959(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 12975, 20153);

                switch (f_10340_12983_12997(_syntax))
                {

                    case SyntaxKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 12975, 20153);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13113, 13156);

                            var
                            node = (ForEachStatementSyntax)_syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13357, 13463);

                            hasNameConflicts = f_10340_13376_13462(originalBinder, f_10340_13431_13448(), diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13658, 13707);

                            TypeSyntax
                            typeSyntax = f_10340_13682_13706(f_10340_13682_13691(node), out _)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13735, 13746);

                            bool
                            isVar
                            = default(bool);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13772, 13790);

                            AliasSymbol
                            alias
                            = default(AliasSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13816, 13915);

                            TypeWithAnnotations
                            declType = f_10340_13847_13914(this, typeSyntax, diagnostics, out isVar, out alias)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 13943, 14282) || true) && (isVar)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 13943, 14282);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14010, 14110);

                                declType = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 14021, 14041) || ((inferredType.HasType && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 14044, 14056)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 14059, 14109))) ? inferredType : TypeWithAnnotations.Create(f_10340_14086_14108(this, "var"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 13943, 14282);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 13943, 14282);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14224, 14255);

                                f_10340_14224_14254(declType.HasType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 13943, 14282);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14310, 14343);

                            iterationVariableType = declType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14369, 14464);

                            boundIterationVariableType = f_10340_14398_14463(typeSyntax, alias, iterationVariableType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14492, 14541);

                            SourceLocalSymbol
                            local = f_10340_14518_14540(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14567, 14606);

                            f_10340_14567_14605(local, declType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14632, 14669);

                            f_10340_14632_14668(local, collectionEscape);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 14697, 15289) || true) && (f_10340_14701_14714(local) != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 14697, 15289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15003, 15040);

                                f_10340_15003_15039(                            // The ref-escape of a ref-returning property is decided
                                                                                // by the value escape of its receiver, in this case the
                                                                                // collection
                                                            local, collectionEscape);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15072, 15262) || true) && (f_10340_15076_15148(this, f_10340_15113_15134(local), diagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15072, 15262);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15214, 15231);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15072, 15262);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 14697, 15289);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15317, 16690) || true) && (!hasErrors)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15317, 16690);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15389, 15423);

                                BindValueKind
                                requiredCurrentKind
                                = default(BindValueKind);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15453, 16257);

                                switch (f_10340_15461_15474(local))
                                {

                                    case RefKind.None:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15453, 16257);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15596, 15639);

                                        requiredCurrentKind = BindValueKind.RValue;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 15677, 15683);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15453, 16257);

                                    case RefKind.Ref:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15453, 16257);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15772, 15852);

                                        requiredCurrentKind = BindValueKind.Assignable | BindValueKind.RefersToLocation;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 15890, 15896);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15453, 16257);

                                    case RefKind.RefReadOnly:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15453, 16257);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 15993, 16046);

                                        requiredCurrentKind = BindValueKind.RefersToLocation;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 16084, 16090);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15453, 16257);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 15453, 16257);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 16170, 16226);

                                        throw f_10340_16176_16225(f_10340_16211_16224(local));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15453, 16257);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 16289, 16663);

                                hasErrors |= !f_10340_16303_16662(this, builder.CurrentPropertyGetter, callSyntaxOpt: null, collectionExpr.Syntax, requiredCurrentKind, checkingReceiver: false, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 15317, 16690);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 16718, 16724);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 12975, 20153);

                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 12975, 20153);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 16855, 16906);

                            var
                            node = (ForEachVariableStatementSyntax)_syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 16932, 17045);

                            iterationVariableType = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 16956, 16976) || ((inferredType.HasType && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 16979, 16991)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 16994, 17044))) ? inferredType : TypeWithAnnotations.Create(f_10340_17021_17043(this, "var"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17073, 17103);

                            var
                            variables = f_10340_17089_17102(node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17129, 19802) || true) && (f_10340_17133_17165(variables))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 17129, 19802);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17223, 17373);

                                var
                                valuePlaceholder = f_10340_17246_17372(f_10340_17246_17348(f_10340_17283_17301(_syntax), collectionEscape, iterationVariableType.Type))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17403, 17450);

                                DeclarationExpressionSyntax
                                declaration = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17480, 17515);

                                ExpressionSyntax
                                expression = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 17545, 18384);

                                BoundDeconstructionAssignmentOperator
                                deconstruction = f_10340_17600_18383(this, variables, variables, right: f_10340_17904_17922(_syntax), diagnostics: diagnostics, rightPlaceholder: valuePlaceholder, declaration: ref declaration, expression: ref expression)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 18416, 18749) || true) && (expression != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 18416, 18749);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 18594, 18667);

                                    f_10340_18594_18666(diagnostics, ErrorCode.ERR_MustDeclareForeachIteration, variables);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 18701, 18718);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 18416, 18749);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 18781, 18900);

                                deconstructStep = f_10340_18799_18899(f_10340_18799_18875(variables, deconstruction, valuePlaceholder));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 17129, 19802);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 17129, 19802);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19118, 19196);

                                iterationErrorExpression = f_10340_19145_19195(this, f_10340_19160_19173(node), f_10340_19175_19194());

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19226, 19507) || true) && (f_10340_19230_19259(iterationErrorExpression) == BoundKind.DiscardExpression)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 19226, 19507);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19356, 19476);

                                    iterationErrorExpression = f_10340_19383_19475(((BoundDiscardExpression)iterationErrorExpression), this, diagnosticsOpt: null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 19226, 19507);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19537, 19554);

                                hasErrors = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19586, 19775) || true) && (f_10340_19590_19605_M(!node.HasErrors))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 19586, 19775);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19671, 19744);

                                    f_10340_19671_19743(diagnostics, ErrorCode.ERR_MustDeclareForeachIteration, variables);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 19586, 19775);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 17129, 19802);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 19830, 19978);

                            boundIterationVariableType = f_10340_19859_19977(f_10340_19859_19953(variables, aliasOpt: null, typeWithAnnotations: iterationVariableType));
                            DynAbs.Tracing.TraceSender.TraceBreak(10340, 20004, 20010);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 12975, 20153);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 12975, 20153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 20081, 20138);

                        throw f_10340_20087_20137(f_10340_20122_20136(_syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 12975, 20153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 20169, 20268);

                BoundStatement
                body = f_10340_20191_20267(originalBinder, f_10340_20236_20253(_syntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 20631, 20692);

                ImmutableArray<LocalSymbol>
                iterationVariables = f_10340_20680_20691(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 20708, 21002);

                f_10340_20708_21001(hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10340, 20721, 20768) || f_10340_20751_20768(_syntax)) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 20721, 20892) || iterationVariables.All(local => local.DeclarationKind == LocalDeclarationKind.ForEachIterationVariable)), "Should not have iteration variables that are not ForEachIterationVariable in valid code");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 21018, 21124);

                hasErrors = hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10340, 21030, 21079) || f_10340_21043_21079(boundIterationVariableType)) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 21030, 21123) || f_10340_21083_21123(iterationVariableType.Type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 21279, 21963) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 21279, 21963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 21326, 21948);

                    return f_10340_21333_21947(_syntax, enumeratorInfoOpt: null, elementConversion: default, boundIterationVariableType, iterationVariables, iterationErrorExpression, collectionExpr, deconstructStep, awaitInfo, body, f_10340_21813_21835(), f_10340_21858_21873(this), f_10340_21896_21914(this), hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 21279, 21963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 21979, 22009);

                hasErrors |= hasNameConflicts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22025, 22069);

                var
                foreachKeyword = f_10340_22046_22068(_syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22083, 22185);

                f_10340_22083_22184(this, diagnostics, getEnumeratorMethod, foreachKeyword, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22199, 22332);

                f_10340_22199_22331(diagnostics, getEnumeratorMethod, foreachKeyword.GetLocation(), isDelegateConversion: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22697, 22807);

                f_10340_22697_22806(this, diagnostics, f_10340_22738_22765(builder.MoveNextInfo), foreachKeyword, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22821, 22933);

                f_10340_22821_22932(this, diagnostics, builder.CurrentPropertyGetter, foreachKeyword, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 22947, 23076);

                f_10340_22947_23075(this, diagnostics, f_10340_22988_23034(builder.CurrentPropertyGetter), foreachKeyword, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23306, 23356);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23370, 23531);

                Conversion
                elementConversion = f_10340_23401_23530(f_10340_23401_23417(this), inferredType.Type, iterationVariableType.Type, ref useSiteDiagnostics, forCast: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23547, 24603) || true) && (f_10340_23551_23577_M(!elementConversion.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 23547, 24603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23611, 23722);

                    ImmutableArray<MethodSymbol>
                    originalUserDefinedConversions = elementConversion.OriginalUserDefinedConversions
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23740, 24379) || true) && (originalUserDefinedConversions.Length > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 23740, 24379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 23827, 24012);

                        f_10340_23827_24011(diagnostics, ErrorCode.ERR_AmbigUDConv, foreachKeyword.GetLocation(), originalUserDefinedConversions[0], originalUserDefinedConversions[1], inferredType.Type, iterationVariableType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 23740, 24379);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 23740, 24379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 24094, 24219);

                        SymbolDistinguisher
                        distinguisher = f_10340_24130_24218(f_10340_24154_24170(this), inferredType.Type, iterationVariableType.Type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 24241, 24360);

                        f_10340_24241_24359(diagnostics, ErrorCode.ERR_NoExplicitConv, foreachKeyword.GetLocation(), f_10340_24317_24336(distinguisher), f_10340_24338_24358(distinguisher));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 23740, 24379);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 24397, 24414);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 23547, 24603);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 23547, 24603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 24480, 24588);

                    f_10340_24480_24587(this, diagnostics, elementConversion, f_10340_24540_24562(_syntax), hasBaseReceiver: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 23547, 24603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 24871, 25016);

                builder.CollectionConversion = f_10340_24902_25015(f_10340_24902_24918(this), collectionExpr, builder.CollectionType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25030, 25189);

                builder.CurrentConversion = f_10340_25058_25188(f_10340_25058_25074(this), f_10340_25102_25142(builder.CurrentPropertyGetter), builder.ElementType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25205, 25267);

                TypeSymbol
                getEnumeratorType = f_10340_25236_25266(getEnumeratorMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25378, 25649);

                builder.EnumeratorConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 25409, 25438) || ((f_10340_25409_25438(getEnumeratorType) && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 25458, 25477)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 25497, 25648))) ? Conversion.Identity : f_10340_25497_25648(f_10340_25497_25513(this), getEnumeratorType, f_10340_25560_25623(this, SpecialType.System_Object, diagnostics, _syntax), ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25665, 25905) || true) && (f_10340_25669_25705(getEnumeratorType) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 25669, 25752) && (f_10340_25710_25730() || (DynAbs.Tracing.TraceSender.Expression_False(10340, 25710, 25751) || f_10340_25734_25751(this)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 25665, 25905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25786, 25890);

                    f_10340_25786_25889(diagnostics, ErrorCode.ERR_BadSpecialByRefIterator, foreachKeyword.GetLocation(), getEnumeratorType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 25665, 25905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 25921, 25995);

                f_10340_25921_25994(
                            diagnostics, _syntax.ForEachKeyword.GetLocation(), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 26603, 26654);

                f_10340_26603_26653(builder.CollectionConversion.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 26668, 27003);

                f_10340_26668_27002(builder.CurrentConversion.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10340, 26681, 26818) || (f_10340_26736_26784(builder.ElementType) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 26736, 26817) && f_10340_26788_26817(f_10340_26788_26807(collectionExpr))))) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 26681, 27001) || (f_10340_26840_26876(builder.ElementType) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 26840, 26967) && f_10340_26880_26967(f_10340_26880_26944(builder.ElementType).Single())) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 26840, 27000) && f_10340_26971_27000(f_10340_26971_26990(collectionExpr))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 27017, 27345);

                f_10340_27017_27344(builder.EnumeratorConversion.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10340, 27030, 27172) || f_10340_27087_27154(f_10340_27087_27145(f_10340_27087_27103(this), SpecialType.System_Object)) == TypeKind.Error) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 27030, 27228) || !f_10340_27194_27228(useSiteDiagnostics)), "Conversions to object succeed unless there's a problem with the object type or the source type");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 27469, 27639);

                f_10340_27469_27638((object)builder.CollectionConversion.Method == null, "Conversion from collection expression to collection type should not be user-defined");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 27653, 27817);

                f_10340_27653_27816((object)builder.CurrentConversion.Method == null, "Conversion from Current property type to element type should not be user-defined");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 27831, 28003);

                f_10340_27831_28002((object)builder.EnumeratorConversion.Method == null, "Conversion from GetEnumerator return type to System.Object should not be user-defined");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 28221, 28634);

                BoundConversion
                convertedCollectionExpression = f_10340_28269_28633(collectionExpr.Syntax, collectionExpr, builder.CollectionConversion, @checked: f_10340_28437_28459(), explicitCastInCode: false, conversionGroupOpt: null, ConstantValue.NotAvailable, builder.CollectionType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 28650, 28799) || true) && (builder.NeedsDisposal && (DynAbs.Tracing.TraceSender.Expression_True(10340, 28654, 28686) && f_10340_28679_28686()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 28650, 28799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 28720, 28784);

                    hasErrors |= f_10340_28733_28783(this, ref builder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 28650, 28799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 28815, 29609);

                f_10340_28815_29608(hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10340, 28846, 28915) || builder.CollectionConversion.IsIdentity) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 28846, 29213) || (builder.CollectionConversion.IsImplicit && (DynAbs.Tracing.TraceSender.Expression_True(10340, 28937, 29212) && (f_10340_28999_29036(builder.CollectionType) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 28999, 29138) || f_10340_29059_29138(f_10340_29074_29115(builder.CollectionType), f_10340_29117_29124(), f_10340_29126_29137())) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 28999, 29211) || f_10340_29161_29211(f_10340_29161_29193(builder.GetEnumeratorInfo))))))) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 28846, 29607) ||                // For compat behavior, we can enumerate over System.String even if it's not IEnumerable. That will
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    // result in an explicit reference conversion in the bound nodes, but that conversion won't be emitted.
                                (builder.CollectionConversion.Kind == ConversionKind.ExplicitReference && (DynAbs.Tracing.TraceSender.Expression_True(10340, 29473, 29606) && f_10340_29546_29577(f_10340_29546_29565(collectionExpr)) == SpecialType.System_String))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 29625, 30163);

                return f_10340_29632_30162(_syntax, builder.Build(this.Flags), elementConversion, boundIterationVariableType, iterationVariables, iterationErrorExpression, convertedCollectionExpression, deconstructStep, awaitInfo, body, f_10340_30040_30062(), f_10340_30081_30096(this), f_10340_30115_30133(this), hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 9731, 30174);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_9988_10006(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 9988, 10006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10340_9963_10007(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 9963, 10007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_10036_10054(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 10036, 10054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10340_9963_10068(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 9963, 10068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_10099_10134()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 10099, 10134);
                    return return_v;
                }


                bool
                f_10340_10214_10324(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                inferredType)
                {
                    var return_v = this_param.GetEnumeratorInfoAndInferCollectionElementType(ref builder, ref collectionExpr, diagnostics, out inferredType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 10214, 10324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10340_10595_10628_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 10595, 10628);
                    return return_v;
                }


                bool
                f_10340_10708_10810(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckImplicitThisCopyInReadOnlyMember(receiver, method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 10708, 10810);
                    return return_v;
                }


                bool
                f_10340_10835_10872(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 10835, 10872);
                    return return_v;
                }


                bool
                f_10340_10944_10951()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 10944, 10951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_11184_11195()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11184, 11195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_11222_11252(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11222, 11252);
                    return return_v;
                }


                bool
                f_10340_11085_11253(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.Compilation)compilation, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 11085, 11253);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10340_11282_11319(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11282, 11319);
                    return return_v;
                }


                int
                f_10340_11432_11506(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 11432, 11506);
                    return 0;
                }


                bool
                f_10340_11625_11632()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11625, 11632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_11677_11695(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11677, 11695);
                    return return_v;
                }


                int
                f_10340_11714_11809(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    this_param.ReportBadAwaitDiagnostics((Microsoft.CodeAnalysis.SyntaxNode)node, location, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 11714, 11809);
                    return 0;
                }


                uint
                f_10340_11925_11945(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 11925, 11945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_12001_12028(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12001, 12028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_12001_12039(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12001, 12039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_12051_12068(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 12051, 12068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10340_11873_12069(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, valEscape: valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 11873, 12069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10340_12100_12160(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindAwaitInfo(placeholder, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 12100, 12160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10340_12227_12246(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12227, 12246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_12258_12277(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12258, 12277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_12258_12288(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12258, 12288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_12258_12300(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12258, 12300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_12426_12439(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12426, 12439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10340_12441_12486(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12441, 12486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_12373_12508(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 12373, 12508);
                    return return_v;
                }


                uint
                f_10340_12939_12959(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 12939, 12959);
                    return return_v;
                }


                uint
                f_10340_12910_12960(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 12910, 12960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_12983_12997(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 12983, 12997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10340_13431_13448()
                {
                    var return_v = IterationVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 13431, 13448);
                    return return_v;
                }


                bool
                f_10340_13376_13462(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 13376, 13462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10340_13682_13691(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 13682, 13691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10340_13682_13706(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 13682, 13706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10340_13847_13914(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias)
                {
                    var return_v = this_param.BindTypeOrVarKeyword(syntax, diagnostics, out isVar, out alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 13847, 13914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_14086_14108(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 14086, 14108);
                    return return_v;
                }


                int
                f_10340_14224_14254(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 14224, 14254);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10340_14398_14463(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt, typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 14398, 14463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10340_14518_14540(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.IterationVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 14518, 14540);
                    return return_v;
                }


                int
                f_10340_14567_14605(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newType)
                {
                    this_param.SetTypeWithAnnotations(newType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 14567, 14605);
                    return 0;
                }


                int
                f_10340_14632_14668(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, uint
                value)
                {
                    this_param.SetValEscape(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 14632, 14668);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10340_14701_14714(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 14701, 14714);
                    return return_v;
                }


                int
                f_10340_15003_15039(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, uint
                value)
                {
                    this_param.SetRefEscape(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 15003, 15039);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10340_15113_15134(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.IdentifierToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 15113, 15134);
                    return return_v;
                }


                bool
                f_10340_15076_15148(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckRefLocalInAsyncOrIteratorMethod(identifierToken, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 15076, 15148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10340_15461_15474(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 15461, 15474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10340_16211_16224(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 16211, 16224);
                    return return_v;
                }


                System.Exception
                f_10340_16176_16225(Microsoft.CodeAnalysis.RefKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 16176, 16225);
                    return return_v;
                }


                bool
                f_10340_16303_16662(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                callSyntaxOpt, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckMethodReturnValueKind(methodSymbol, callSyntaxOpt: callSyntaxOpt, node, valueKind, checkingReceiver: checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 16303, 16662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_17021_17043(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 17021, 17043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_17089_17102(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 17089, 17102);
                    return return_v;
                }


                bool
                f_10340_17133_17165(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = node.IsDeconstructionLeft();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 17133, 17165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_17283_17301(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 17283, 17301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10340_17246_17348(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 17246, 17348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10340_17246_17372(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 17246, 17372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_17904_17922(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 17904, 17922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10340_17600_18383(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                deconstruction, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                rightPlaceholder, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                expression)
                {
                    var return_v = this_param.BindDeconstruction((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)deconstruction, left, right: right, diagnostics: diagnostics, rightPlaceholder: rightPlaceholder, declaration: ref declaration, expression: ref expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 17600, 18383);
                    return return_v;
                }


                int
                f_10340_18594_18666(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 18594, 18666);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
                f_10340_18799_18875(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                deconstructionAssignment, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                targetPlaceholder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep((Microsoft.CodeAnalysis.SyntaxNode)syntax, deconstructionAssignment, targetPlaceholder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 18799, 18875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
                f_10340_18799_18899(Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 18799, 18899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_19160_19173(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 19160, 19173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10340_19175_19194()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19175, 19194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10340_19145_19195(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19145, 19195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10340_19230_19259(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 19230, 19259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10340_19383_19475(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                binder, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference((Microsoft.CodeAnalysis.CSharp.Binder)binder, diagnosticsOpt: diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19383, 19475);
                    return return_v;
                }


                bool
                f_10340_19590_19605_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 19590, 19605);
                    return return_v;
                }


                int
                f_10340_19671_19743(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19671, 19743);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10340_19859_19953(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt: aliasOpt, typeWithAnnotations: typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19859, 19953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10340_19859_19977(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 19859, 19977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10340_20122_20136(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 20122, 20136);
                    return return_v;
                }


                System.Exception
                f_10340_20087_20137(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 20087, 20137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10340_20236_20253(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 20236, 20253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10340_20191_20267(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 20191, 20267);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10340_20680_20691(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 20680, 20691);
                    return return_v;
                }


                bool
                f_10340_20751_20768(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 20751, 20768);
                    return return_v;
                }


                int
                f_10340_20708_21001(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 20708, 21001);
                    return 0;
                }


                bool
                f_10340_21043_21079(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 21043, 21079);
                    return return_v;
                }


                bool
                f_10340_21083_21123(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 21083, 21123);
                    return return_v;
                }


                bool
                f_10340_21813_21835()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 21813, 21835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10340_21858_21873(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 21858, 21873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10340_21896_21914(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 21896, 21914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                f_10340_21333_21947(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo?
                enumeratorInfoOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                elementConversion, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                iterationVariableType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                iterationVariables, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                iterationErrorExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep?
                deconstructionOpt, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                awaitOpt, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundForEachStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, enumeratorInfoOpt: enumeratorInfoOpt, elementConversion: elementConversion, iterationVariableType, iterationVariables, iterationErrorExpressionOpt, expression, deconstructionOpt, awaitOpt, body, @checked, breakLabel, continueLabel, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 21333, 21947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10340_22046_22068(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.ForEachKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 22046, 22068);
                    return return_v;
                }


                int
                f_10340_22083_22184(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol, Microsoft.CodeAnalysis.SyntaxToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 22083, 22184);
                    return 0;
                }


                int
                f_10340_22199_22331(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.Location
                location, bool
                isDelegateConversion)
                {
                    ReportDiagnosticsIfUnmanagedCallersOnly(diagnostics, symbol, location, isDelegateConversion: isDelegateConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 22199, 22331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_22738_22765(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 22738, 22765);
                    return return_v;
                }


                int
                f_10340_22697_22806(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 22697, 22806);
                    return 0;
                }


                int
                f_10340_22821_22932(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 22821, 22932);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_22988_23034(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 22988, 23034);
                    return return_v;
                }


                int
                f_10340_22947_23075(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 22947, 23075);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_23401_23417(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 23401, 23417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_23401_23530(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 23401, 23530);
                    return return_v;
                }


                bool
                f_10340_23551_23577_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 23551, 23577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_23827_24011(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 23827, 24011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_24154_24170(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 24154, 24170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                f_10340_24130_24218(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol0, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol1)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol0, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 24130, 24218);
                    return return_v;
                }


                System.IFormattable
                f_10340_24317_24336(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 24317, 24336);
                    return return_v;
                }


                System.IFormattable
                f_10340_24338_24358(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.Second;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 24338, 24358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_24241_24359(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 24241, 24359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10340_24540_24562(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.ForEachKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 24540, 24562);
                    return return_v;
                }


                int
                f_10340_24480_24587(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.SyntaxToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, conversion, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 24480, 24587);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_24902_24918(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 24902, 24918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_24902_25015(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 24902, 25015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_25058_25074(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25058, 25074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_25102_25142(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25102, 25142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_25058_25188(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25058, 25188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_25236_25266(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25236, 25266);
                    return return_v;
                }


                bool
                f_10340_25409_25438(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25409, 25438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_25497_25513(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25497, 25513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_25560_25623(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25560, 25623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_25497_25648(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25497, 25648);
                    return return_v;
                }


                bool
                f_10340_25669_25705(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25669, 25705);
                    return return_v;
                }


                bool
                f_10340_25710_25730()
                {
                    var return_v = IsDirectlyInIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 25710, 25730);
                    return return_v;
                }


                bool
                f_10340_25734_25751(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.IsInAsyncMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25734, 25751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_25786_25889(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25786, 25889);
                    return return_v;
                }


                bool
                f_10340_25921_25994(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 25921, 25994);
                    return return_v;
                }


                int
                f_10340_26603_26653(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26603, 26653);
                    return 0;
                }


                bool
                f_10340_26736_26784(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26736, 26784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_26788_26807(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 26788, 26807);
                    return return_v;
                }


                bool
                f_10340_26788_26817(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26788, 26817);
                    return return_v;
                }


                bool
                f_10340_26840_26876(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26840, 26876);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10340_26880_26944(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeArgumentsNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26880, 26944);
                    return return_v;
                }


                bool
                f_10340_26880_26967(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26880, 26967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_26971_26990(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 26971, 26990);
                    return return_v;
                }


                bool
                f_10340_26971_27000(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26971, 27000);
                    return return_v;
                }


                int
                f_10340_26668_27002(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 26668, 27002);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_27087_27103(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 27087, 27103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_27087_27145(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27087, 27145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10340_27087_27154(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 27087, 27154);
                    return return_v;
                }


                bool
                f_10340_27194_27228(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27194, 27228);
                    return return_v;
                }


                int
                f_10340_27017_27344(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27017, 27344);
                    return 0;
                }


                int
                f_10340_27469_27638(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27469, 27638);
                    return 0;
                }


                int
                f_10340_27653_27816(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27653, 27816);
                    return 0;
                }


                int
                f_10340_27831_28002(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 27831, 28002);
                    return 0;
                }


                bool
                f_10340_28437_28459()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 28437, 28459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10340_28269_28633(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 28269, 28633);
                    return return_v;
                }


                bool
                f_10340_28679_28686()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 28679, 28686);
                    return return_v;
                }


                bool
                f_10340_28733_28783(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAwaitDisposeAsyncInfo(ref builder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 28733, 28783);
                    return return_v;
                }


                bool
                f_10340_28999_29036(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsIEnumerable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 28999, 29036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_29074_29115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29074, 29115);
                    return return_v;
                }


                bool
                f_10340_29117_29124()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29117, 29124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_29126_29137()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29126, 29137);
                    return return_v;
                }


                bool
                f_10340_29059_29138(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = IsIEnumerableT(type, isAsync, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 29059, 29138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_29161_29193(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29161, 29193);
                    return return_v;
                }


                bool
                f_10340_29161_29211(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29161, 29211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_29546_29565(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29546, 29565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_29546_29577(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 29546, 29577);
                    return return_v;
                }


                int
                f_10340_28815_29608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 28815, 29608);
                    return 0;
                }


                bool
                f_10340_30040_30062()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30040, 30062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10340_30081_30096(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30081, 30096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10340_30115_30133(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30115, 30133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                f_10340_29632_30162(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                enumeratorInfoOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                elementConversion, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                iterationVariableType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                iterationVariables, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                iterationErrorExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundConversion
                expression, Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep?
                deconstructionOpt, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                awaitOpt, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundForEachStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, enumeratorInfoOpt, elementConversion, iterationVariableType, iterationVariables, iterationErrorExpressionOpt, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, deconstructionOpt, awaitOpt, body, @checked, breakLabel, continueLabel, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 29632, 30162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 9731, 30174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 9731, 30174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetAwaitDisposeAsyncInfo(ref ForEachEnumeratorInfo.Builder builder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 30186, 31017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30318, 30553);

                var
                awaitableType = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 30338, 30372) || ((builder.PatternDisposeInfo is null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 30392, 30488)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 30508, 30552))) ? f_10340_30392_30488(this, WellKnownType.System_Threading_Tasks_ValueTask, diagnostics, this._syntax) : f_10340_30508_30552(f_10340_30508_30541(builder.PatternDisposeInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30569, 30592);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30606, 30636);

                var
                expr = f_10340_30617_30635(_syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30650, 30746);

                f_10340_30650_30745(this, expr, _syntax.AwaitKeyword.GetLocation(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30762, 30869);

                var
                placeholder = f_10340_30780_30868(expr, valEscape: f_10340_30832_30852(this), awaitableType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30883, 30975);

                builder.DisposeAwaitableInfo = f_10340_30914_30974(this, placeholder, expr, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 30989, 31006);

                return hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 30186, 31017);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_30392_30488(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetWellKnownType(type, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 30392, 30488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_30508_30541(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30508, 30541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_30508_30552(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30508, 30552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_30617_30635(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30617, 30635);
                    return return_v;
                }


                int
                f_10340_30650_30745(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    this_param.ReportBadAwaitDiagnostics((Microsoft.CodeAnalysis.SyntaxNode)node, location, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 30650, 30745);
                    return 0;
                }


                uint
                f_10340_30832_30852(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 30832, 30852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10340_30780_30868(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, valEscape: valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 30780, 30868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10340_30914_30974(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindAwaitInfo(placeholder, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 30914, 30974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 30186, 31017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 30186, 31017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations InferCollectionElementType(DiagnosticBag diagnostics, ExpressionSyntax collectionSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 31029, 31628);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations inferredType = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31243, 31372);

                BoundExpression
                collectionExpr = f_10340_31276_31371(f_10340_31276_31308(this, collectionSyntax), collectionSyntax, diagnostics, BindValueKind.RValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31388, 31438);

                var
                builder = f_10340_31402_31437()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31452, 31583);

                f_10340_31452_31582(this, ref builder, ref collectionExpr, diagnostics, out inferredType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31597, 31617);

                return inferredType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 31029, 31628);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10340_31276_31308(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 31276, 31308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10340_31276_31371(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 31276, 31371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_31402_31437()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 31402, 31437);
                    return return_v;
                }


                bool
                f_10340_31452_31582(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                inferredType)
                {
                    var return_v = this_param.GetEnumeratorInfoAndInferCollectionElementType(ref builder, ref collectionExpr, diagnostics, out inferredType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 31452, 31582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 31029, 31628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 31029, 31628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetEnumeratorInfoAndInferCollectionElementType(ref ForEachEnumeratorInfo.Builder builder, ref BoundExpression collectionExpr, DiagnosticBag diagnostics, out TypeWithAnnotations inferredType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 31640, 33256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31868, 31947);

                bool
                gotInfo = f_10340_31883_31946(this, ref builder, ref collectionExpr, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 31963, 33214) || true) && (!gotInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 31963, 33214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 32009, 32032);

                    inferredType = default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 31963, 33214);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 31963, 33214);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 32066, 33214) || true) && (f_10340_32070_32101(collectionExpr))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 32066, 33214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 32211, 32281);

                        inferredType = TypeWithAnnotations.Create(DynamicTypeSymbol.Instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 32066, 33214);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 32066, 33214);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 32315, 33214) || true) && (f_10340_32319_32350(f_10340_32319_32338(collectionExpr)) == SpecialType.System_String && (DynAbs.Tracing.TraceSender.Expression_True(10340, 32319, 32463) && f_10340_32383_32417(builder.CollectionType) == SpecialType.System_Collections_IEnumerable))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 32315, 33214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 32964, 33083);

                            inferredType = TypeWithAnnotations.Create(f_10340_33006_33081(this, SpecialType.System_Char, diagnostics, collectionExpr.Syntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 32315, 33214);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 32315, 33214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33149, 33199);

                            inferredType = builder.ElementTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 32315, 33214);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 32066, 33214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 31963, 33214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33230, 33245);

                return gotInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 31640, 33256);

                bool
                f_10340_31883_31946(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEnumeratorInfo(ref builder, ref collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 31883, 31946);
                    return return_v;
                }


                bool
                f_10340_32070_32101(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 32070, 32101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_32319_32338(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 32319, 32338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_32319_32350(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 32319, 32350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_32383_32417(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 32383, 32417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_33006_33081(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 33006, 33081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 31640, 33256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 31640, 33256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression UnwrapCollectionExpressionIfNullable(BoundExpression collectionExpr, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 33268, 35078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33412, 33464);

                TypeSymbol
                collectionExprType = f_10340_33444_33463(collectionExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33690, 35029) || true) && ((object)collectionExprType != null && (DynAbs.Tracing.TraceSender.Expression_True(10340, 33694, 33767) && f_10340_33732_33767(collectionExprType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 33690, 35029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33801, 33847);

                    SyntaxNode
                    exprSyntax = collectionExpr.Syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 33867, 34005);

                    MethodSymbol
                    nullableValueGetter = (MethodSymbol)f_10340_33916_34004(this, SpecialMember.System_Nullable_T_get_Value, diagnostics, exprSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 34023, 35014) || true) && ((object)nullableValueGetter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 34023, 35014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 34104, 34192);

                        nullableValueGetter = f_10340_34126_34191(nullableValueGetter, collectionExprType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 34321, 34504);

                        return f_10340_34328_34503(syntax: exprSyntax, receiverOpt: collectionExpr, method: nullableValueGetter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 34023, 35014);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 34023, 35014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 34586, 34948);

                        return new BoundBadExpression(
                                                exprSyntax,
                                                LookupResultKind.Empty,
                                                ImmutableArray<Symbol>.Empty,
                        f_10340_34783_34820(collectionExpr),
                        f_10340_34847_34893(collectionExprType))
                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10340, 34593, 34947) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 34023, 35014);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 33690, 35029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 35045, 35067);

                return collectionExpr;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 33268, 35078);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_33444_33463(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 33444, 33463);
                    return return_v;
                }


                bool
                f_10340_33732_33767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 33732, 33767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_33916_34004(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 33916, 34004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_34126_34191(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 34126, 34191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10340_34328_34503(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = BoundCall.Synthesized(syntax: syntax, receiverOpt: receiverOpt, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 34328, 34503);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_34783_34820(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 34783, 34820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_34847_34893(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 34847, 34893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 33268, 35078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 33268, 35078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetEnumeratorInfo(ref ForEachEnumeratorInfo.Builder builder, ref BoundExpression collectionExpr, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 36524, 38339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 36685, 36708);

                bool
                isAsync = f_10340_36700_36707()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 36722, 36748);

                builder.IsAsync = isAsync;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 36764, 36862);

                EnumeratorResult
                found = f_10340_36789_36861(this, ref builder, ref collectionExpr, isAsync, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 36876, 37097);

                switch (found)
                {

                    case EnumeratorResult.Succeeded:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 36876, 37097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 36977, 36989);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 36876, 37097);

                    case EnumeratorResult.FailedAndReported:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 36876, 37097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37069, 37082);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 36876, 37097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37113, 37165);

                TypeSymbol
                collectionExprType = f_10340_37145_37164(collectionExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37179, 37318) || true) && (f_10340_37183_37228(f_10340_37204_37227(collectionExprType)) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 37183, 37256) && f_10340_37232_37256(collectionExpr)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 37179, 37318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37290, 37303);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 37179, 37318);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37334, 37432) || true) && (f_10340_37338_37370(collectionExprType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 37334, 37432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37404, 37417);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 37334, 37432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37533, 37590);

                var
                ignoredBuilder = f_10340_37554_37589()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37604, 37657);

                var
                ignoredDiagnostics = f_10340_37629_37656()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37671, 37807);

                bool
                wrongAsync = f_10340_37689_37776(this, ref ignoredBuilder, ref collectionExpr, !isAsync, ignoredDiagnostics) == EnumeratorResult.Succeeded
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37821, 37847);

                f_10340_37821_37846(ignoredDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 37863, 38126);

                var
                errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 37879, 37889) || ((wrongAsync
                && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 37909, 38017)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 38037, 38125))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10340, 37910, 37917) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 37920, 37969)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 37972, 38016))) ? ErrorCode.ERR_AwaitForEachMissingMemberWrongAsync : ErrorCode.ERR_ForEachMissingMemberWrongAsync)
                : ((DynAbs.Tracing.TraceSender.Conditional_F1(10340, 38038, 38045) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 38048, 38087)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 38090, 38124))) ? ErrorCode.ERR_AwaitForEachMissingMember : ErrorCode.ERR_ForEachMissingMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 38142, 38301);

                f_10340_38142_38300(
                            diagnostics, errorCode, f_10340_38169_38196(f_10340_38169_38187(_syntax)), collectionExprType, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 38235, 38242) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 38245, 38273)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 38276, 38299))) ? GetAsyncEnumeratorMethodName : GetEnumeratorMethodName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 38315, 38328);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 36524, 38339);

                bool
                f_10340_36700_36707()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 36700, 36707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder.EnumeratorResult
                f_10340_36789_36861(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEnumeratorInfo(ref builder, ref collectionExpr, isAsync, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 36789, 36861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_37145_37164(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 37145, 37164);
                    return return_v;
                }


                string
                f_10340_37204_37227(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 37204, 37227);
                    return return_v;
                }


                bool
                f_10340_37183_37228(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37183, 37228);
                    return return_v;
                }


                bool
                f_10340_37232_37256(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 37232, 37256);
                    return return_v;
                }


                bool
                f_10340_37338_37370(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37338, 37370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_37554_37589()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37554, 37589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10340_37629_37656()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37629, 37656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder.EnumeratorResult
                f_10340_37689_37776(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEnumeratorInfo(ref builder, ref collectionExpr, isAsync, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37689, 37776);
                    return return_v;
                }


                int
                f_10340_37821_37846(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 37821, 37846);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_38169_38187(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 38169, 38187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_38169_38196(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 38169, 38196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_38142_38300(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 38142, 38300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 36524, 38339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 36524, 38339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum EnumeratorResult
        {
            Succeeded,
            FailedNotReported,
            FailedAndReported
        }

        private EnumeratorResult GetEnumeratorInfo(ref ForEachEnumeratorInfo.Builder builder, ref BoundExpression collectionExpr, bool isAsync, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 38501, 45435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 38688, 38740);

                TypeSymbol
                collectionExprType = f_10340_38720_38739(collectionExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 38756, 39384) || true) && (collectionExprType is null)
                ) // There's no way to enumerate something without a type.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 38756, 39384);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 38877, 39204) || true) && (!f_10340_38882_38943(this, collectionExpr, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 38877, 39204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39080, 39185);

                        f_10340_39080_39184(                    // Anything else with a null type is a method group or anonymous function
                                            diagnostics, ErrorCode.ERR_AnonMethGrpInForEach, f_10340_39132_39159(f_10340_39132_39150(_syntax)), f_10340_39161_39183(collectionExpr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 38877, 39204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39327, 39369);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 38756, 39384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39400, 39825) || true) && (f_10340_39404_39429(collectionExpr) == LookupResultKind.NotAValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 39400, 39825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39671, 39713);

                    f_10340_39671_39712(f_10340_39684_39711(collectionExpr));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39768, 39810);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 39400, 39825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39841, 40097) || true) && (f_10340_39845_39868(collectionExprType) == SymbolKind.DynamicType && (DynAbs.Tracing.TraceSender.Expression_True(10340, 39845, 39905) && f_10340_39898_39905()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 39841, 40097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 39939, 40022);

                    f_10340_39939_40021(diagnostics, ErrorCode.ERR_BadDynamicAwaitForEach, f_10340_39993_40020(f_10340_39993_40011(_syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40040, 40082);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 39841, 40097);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40227, 40695) || true) && (f_10340_40231_40254(collectionExprType) == SymbolKind.ArrayType || (DynAbs.Tracing.TraceSender.Expression_False(10340, 40231, 40331) || f_10340_40282_40305(collectionExprType) == SymbolKind.DynamicType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 40227, 40695);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40365, 40533) || true) && (f_10340_40369_40430(this, collectionExpr, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 40365, 40533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40472, 40514);

                        return EnumeratorResult.FailedAndReported;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 40365, 40533);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40551, 40628);

                    builder = f_10340_40561_40627(this, builder, diagnostics, collectionExprType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40646, 40680);

                    return EnumeratorResult.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 40227, 40695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40711, 40807);

                var
                unwrappedCollectionExpr = f_10340_40741_40806(this, collectionExpr, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40821, 40884);

                var
                unwrappedCollectionExprType = f_10340_40855_40883(unwrappedCollectionExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 40900, 41443) || true) && (f_10340_40904_41020(this, ref builder, unwrappedCollectionExpr, isAsync, viaExtensionMethod: false, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 40900, 41443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41054, 41095);

                    collectionExpr = unwrappedCollectionExpr;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41113, 41281) || true) && (f_10340_41117_41178(this, collectionExpr, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 41113, 41281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41220, 41262);

                        return EnumeratorResult.FailedAndReported;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 41113, 41281);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41299, 41428);

                    return f_10340_41306_41427(ref builder, unwrappedCollectionExpr, isAsync, viaExtensionMethod: false, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 40900, 41443);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41459, 41953) || true) && (!isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10340, 41463, 41517) && f_10340_41475_41517(unwrappedCollectionExprType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 41459, 41953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41551, 41592);

                    collectionExpr = unwrappedCollectionExpr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41743, 41878);

                    f_10340_41743_41877(                // This indicates a problem with the special IEnumerable type - it should have satisfied the GetEnumerator pattern.
                                    diagnostics, ErrorCode.ERR_ForEachMissingMember, f_10340_41795_41822(f_10340_41795_41813(_syntax)), unwrappedCollectionExprType, GetEnumeratorMethodName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41896, 41938);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 41459, 41953);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 41967, 42488) || true) && (isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10340, 41971, 42029) && f_10340_41982_42029(this, unwrappedCollectionExprType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 41967, 42488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42063, 42104);

                    collectionExpr = unwrappedCollectionExpr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42268, 42413);

                    f_10340_42268_42412(                // This indicates a problem with the well-known IAsyncEnumerable type - it should have satisfied the GetAsyncEnumerator pattern.
                                    diagnostics, ErrorCode.ERR_AwaitForEachMissingMember, f_10340_42325_42352(f_10340_42325_42343(_syntax)), unwrappedCollectionExprType, GetAsyncEnumeratorMethodName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42431, 42473);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 41967, 42488);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42504, 42806) || true) && (f_10340_42508_42627(this, ref builder, unwrappedCollectionExpr, isAsync, diagnostics, unwrappedCollectionExprType) is not EnumeratorResult.FailedNotReported and var result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 42504, 42806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42718, 42759);

                    collectionExpr = unwrappedCollectionExpr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 42777, 42791);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 42504, 42806);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43246, 43687) || true) && (!isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10340, 43250, 43321) && f_10340_43262_43292(collectionExprType) == SpecialType.System_String))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 43246, 43687);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43355, 43523) || true) && (f_10340_43359_43420(this, collectionExpr, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 43355, 43523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43462, 43504);

                        return EnumeratorResult.FailedAndReported;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 43355, 43523);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43543, 43620);

                    builder = f_10340_43553_43619(this, builder, diagnostics, collectionExprType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43638, 43672);

                    return EnumeratorResult.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 43246, 43687);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43703, 43981) || true) && (f_10340_43707_43813(this, ref builder, collectionExpr, isAsync, viaExtensionMethod: true, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 43703, 43981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43847, 43966);

                    return f_10340_43854_43965(ref builder, collectionExpr, isAsync, viaExtensionMethod: true, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 43703, 43981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 43997, 44039);

                return EnumeratorResult.FailedNotReported;

                EnumeratorResult createPatternBasedEnumeratorResult(ref ForEachEnumeratorInfo.Builder builder, BoundExpression collectionExpr, bool isAsync, bool viaExtensionMethod, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 44055, 45424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44280, 44336);

                        f_10340_44280_44335((object)builder.GetEnumeratorInfo != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44356, 44456);

                        f_10340_44356_44455(!(viaExtensionMethod && (DynAbs.Tracing.TraceSender.Expression_True(10340, 44371, 44453) && f_10340_44393_44425(builder.GetEnumeratorInfo).Parameters.IsDefaultOrEmpty)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44476, 44638);

                        builder.CollectionType = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 44501, 44519) || ((viaExtensionMethod
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 44543, 44594)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 44618, 44637))) ? f_10340_44543_44594(f_10340_44543_44586(f_10340_44543_44575(builder.GetEnumeratorInfo))[0]) : f_10340_44618_44637(collectionExpr);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44658, 45065) || true) && (f_10340_44662_44720(this, ref builder, isAsync, diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 44658, 45065);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44762, 44884);

                            builder.ElementTypeWithAnnotations = f_10340_44799_44883(((PropertySymbol)f_10340_44816_44862(builder.CurrentPropertyGetter)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 44908, 44988);

                            f_10340_44908_44987(this, ref builder, collectionExpr, isAsync, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45012, 45046);

                            return EnumeratorResult.Succeeded;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 44658, 45065);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45085, 45153);

                        MethodSymbol
                        getEnumeratorMethod = f_10340_45120_45152(builder.GetEnumeratorInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45171, 45349);

                        f_10340_45171_45348(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 45187, 45194) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 45197, 45232)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 45235, 45265))) ? ErrorCode.ERR_BadGetAsyncEnumerator : ErrorCode.ERR_BadGetEnumerator, f_10340_45267_45294(f_10340_45267_45285(_syntax)), f_10340_45296_45326(getEnumeratorMethod), getEnumeratorMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45367, 45409);

                        return EnumeratorResult.FailedAndReported;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 44055, 45424);

                        int
                        f_10340_44280_44335(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 44280, 44335);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10340_44393_44425(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44393, 44425);
                            return return_v;
                        }


                        int
                        f_10340_44356_44455(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 44356, 44455);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10340_44543_44575(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44543, 44575);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10340_44543_44586(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44543, 44586);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10340_44543_44594(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44543, 44594);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10340_44618_44637(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44618, 44637);
                            return return_v;
                        }


                        bool
                        f_10340_44662_44720(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                        this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                        builder, bool
                        isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.SatisfiesForEachPattern(ref builder, isAsync, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 44662, 44720);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10340_44816_44862(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.AssociatedSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44816, 44862);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10340_44799_44883(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 44799, 44883);
                            return return_v;
                        }


                        int
                        f_10340_44908_44987(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                        this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expr, bool
                        isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            this_param.GetDisposalInfoForEnumerator(ref builder, expr, isAsync, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 44908, 44987);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10340_45120_45152(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 45120, 45152);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_10340_45267_45285(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 45267, 45285);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10340_45267_45294(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 45267, 45294);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10340_45296_45326(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 45296, 45326);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10340_45171_45348(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 45171, 45348);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 44055, 45424);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 44055, 45424);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 38501, 45435);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_38720_38739(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 38720, 38739);
                    return return_v;
                }


                bool
                f_10340_38882_38943(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConstantNullCollectionExpr(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 38882, 38943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_39132_39150(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39132, 39150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_39132_39159(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39132, 39159);
                    return return_v;
                }


                object
                f_10340_39161_39183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39161, 39183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_39080_39184(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 39080, 39184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10340_39404_39429(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39404, 39429);
                    return return_v;
                }


                bool
                f_10340_39684_39711(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39684, 39711);
                    return return_v;
                }


                int
                f_10340_39671_39712(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 39671, 39712);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10340_39845_39868(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39845, 39868);
                    return return_v;
                }


                bool
                f_10340_39898_39905()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39898, 39905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_39993_40011(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39993, 40011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_39993_40020(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 39993, 40020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_39939_40021(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 39939, 40021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10340_40231_40254(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 40231, 40254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10340_40282_40305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 40282, 40305);
                    return return_v;
                }


                bool
                f_10340_40369_40430(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConstantNullCollectionExpr(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 40369, 40430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_40561_40627(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                collectionExprType)
                {
                    var return_v = this_param.GetDefaultEnumeratorInfo(builder, diagnostics, collectionExprType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 40561, 40627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10340_40741_40806(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.UnwrapCollectionExpressionIfNullable(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 40741, 40806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_40855_40883(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 40855, 40883);
                    return return_v;
                }


                bool
                f_10340_40904_41020(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, bool
                viaExtensionMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SatisfiesGetEnumeratorPattern(ref builder, collectionExpr, isAsync, viaExtensionMethod: viaExtensionMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 40904, 41020);
                    return return_v;
                }


                bool
                f_10340_41117_41178(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConstantNullCollectionExpr(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 41117, 41178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder.EnumeratorResult
                f_10340_41306_41427(ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, bool
                viaExtensionMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = createPatternBasedEnumeratorResult(ref builder, collectionExpr, isAsync, viaExtensionMethod: viaExtensionMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 41306, 41427);
                    return return_v;
                }


                bool
                f_10340_41475_41517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = IsIEnumerable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 41475, 41517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_41795_41813(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 41795, 41813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_41795_41822(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 41795, 41822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_41743_41877(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 41743, 41877);
                    return return_v;
                }


                bool
                f_10340_41982_42029(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.IsIAsyncEnumerable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 41982, 42029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_42325_42343(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 42325, 42343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_42325_42352(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 42325, 42352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_42268_42412(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 42268, 42412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder.EnumeratorResult
                f_10340_42508_42627(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                unwrappedCollectionExprType)
                {
                    var return_v = this_param.SatisfiesIEnumerableInterfaces(ref builder, collectionExpr, isAsync, diagnostics, unwrappedCollectionExprType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 42508, 42627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_43262_43292(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 43262, 43292);
                    return return_v;
                }


                bool
                f_10340_43359_43420(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConstantNullCollectionExpr(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 43359, 43420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                f_10340_43553_43619(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                collectionExprType)
                {
                    var return_v = this_param.GetDefaultEnumeratorInfo(builder, diagnostics, collectionExprType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 43553, 43619);
                    return return_v;
                }


                bool
                f_10340_43707_43813(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, bool
                viaExtensionMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SatisfiesGetEnumeratorPattern(ref builder, collectionExpr, isAsync, viaExtensionMethod: viaExtensionMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 43707, 43813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder.EnumeratorResult
                f_10340_43854_43965(ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, bool
                isAsync, bool
                viaExtensionMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = createPatternBasedEnumeratorResult(ref builder, collectionExpr, isAsync, viaExtensionMethod: viaExtensionMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 43854, 43965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 38501, 45435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 38501, 45435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EnumeratorResult SatisfiesIEnumerableInterfaces(ref ForEachEnumeratorInfo.Builder builder, BoundExpression collectionExpr, bool isAsync, DiagnosticBag diagnostics, TypeSymbol unwrappedCollectionExprType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 45447, 53627);
                bool foundMultipleGenericIEnumerableInterfaces = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45683, 45927) || true) && (!f_10340_45688_45836(this, ref builder, unwrappedCollectionExprType, isAsync, diagnostics, out foundMultipleGenericIEnumerableInterfaces))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 45683, 45927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45870, 45912);

                    return EnumeratorResult.FailedNotReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 45683, 45927);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 45943, 46099) || true) && (f_10340_45947_46008(this, collectionExpr, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 45943, 46099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46042, 46084);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 45943, 46099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46115, 46173);

                CSharpSyntaxNode
                errorLocationSyntax = f_10340_46154_46172(_syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46189, 46763) || true) && (foundMultipleGenericIEnumerableInterfaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 46189, 46763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46268, 46688);

                    f_10340_46268_46687(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 46284, 46291) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 46294, 46329)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 46332, 46362))) ? ErrorCode.ERR_MultipleIAsyncEnumOfT : ErrorCode.ERR_MultipleIEnumOfT, f_10340_46364_46392(errorLocationSyntax), unwrappedCollectionExprType, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 46444, 46451) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 46479, 46573)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 46601, 46686))) ? f_10340_46479_46573(f_10340_46479_46495(this), WellKnownType.System_Collections_Generic_IAsyncEnumerable_T) : f_10340_46601_46686(f_10340_46601_46617(this), SpecialType.System_Collections_Generic_IEnumerable_T));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46706, 46748);

                    return EnumeratorResult.FailedAndReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 46189, 46763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46779, 46832);

                f_10340_46779_46831((object)builder.CollectionType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46848, 46921);

                NamedTypeSymbol
                collectionType = (NamedTypeSymbol)builder.CollectionType
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 46935, 53367) || true) && (f_10340_46939_46967(collectionType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 46935, 53367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47079, 47189);

                    builder.ElementTypeWithAnnotations = collectionType.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Single();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47209, 47242);

                    MethodSymbol
                    getEnumeratorMethod
                    = default(MethodSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47260, 48834) || true) && (isAsync)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 47260, 48834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47313, 47381);

                        f_10340_47313_47380(f_10340_47326_47379(this, f_10340_47345_47378(collectionType)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47405, 47647);

                        getEnumeratorMethod = (MethodSymbol)f_10340_47441_47646(f_10340_47464_47475(), WellKnownMember.System_Collections_Generic_IAsyncEnumerable_T__GetAsyncEnumerator, diagnostics, f_10340_47598_47626(errorLocationSyntax), isOptional: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47801, 47868);

                        f_10340_47801_47867(getEnumeratorMethod is null or { ParameterCount: 1 });

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 47923, 48433) || true) && (getEnumeratorMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10340, 47927, 48003) && f_10340_47958_48003_M(!f_10340_47959_47989(getEnumeratorMethod)[0].IsOptional)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 47923, 48433);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48197, 48342);

                            f_10340_48197_48341(                        // This indicates a problem with the well-known IAsyncEnumerable type - it should have an optional cancellation token.
                                                    diagnostics, ErrorCode.ERR_AwaitForEachMissingMember, f_10340_48254_48281(f_10340_48254_48272(_syntax)), unwrappedCollectionExprType, GetAsyncEnumeratorMethodName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48368, 48410);

                            return EnumeratorResult.FailedAndReported;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 47923, 48433);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 47260, 48834);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 47260, 48834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48515, 48631);

                        f_10340_48515_48630(f_10340_48528_48573(f_10340_48528_48561(collectionType)) == SpecialType.System_Collections_Generic_IEnumerable_T);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48653, 48815);

                        getEnumeratorMethod = (MethodSymbol)f_10340_48689_48814(this, SpecialMember.System_Collections_Generic_IEnumerable_T__GetEnumerator, diagnostics, errorLocationSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 47260, 48834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48854, 48889);

                    MethodSymbol
                    moveNextMethod = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48907, 51536) || true) && ((object)getEnumeratorMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 48907, 51536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 48988, 49076);

                        MethodSymbol
                        specificGetEnumeratorMethod = f_10340_49031_49075(getEnumeratorMethod, collectionType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 49098, 49165);

                        TypeSymbol
                        enumeratorType = f_10340_49126_49164(specificGetEnumeratorMethod)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 49293, 49977);

                        builder.GetEnumeratorInfo = f_10340_49321_49976(this, specificGetEnumeratorMethod, extensionReceiverOpt: null, expanded: false, collectionExpr.Syntax, diagnostics, assertMissingParametersAreOptional: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50001, 50036);

                        MethodSymbol
                        currentPropertyGetter
                        = default(MethodSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50058, 51283) || true) && (isAsync)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 50058, 51283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50119, 50265);

                            f_10340_50119_50264(f_10340_50132_50263(f_10340_50132_50165(enumeratorType), f_10340_50173_50262(f_10340_50173_50184(), WellKnownType.System_Collections_Generic_IAsyncEnumerator_T)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50293, 50541);

                            MethodSymbol
                            moveNextAsync = (MethodSymbol)f_10340_50336_50540(f_10340_50359_50370(), WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__MoveNextAsync, diagnostics, f_10340_50492_50520(errorLocationSyntax), isOptional: false)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50569, 50760) || true) && ((object)moveNextAsync != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 50569, 50760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50660, 50733);

                                moveNextMethod = f_10340_50677_50732(moveNextAsync, enumeratorType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 50569, 50760);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 50788, 51000);

                            currentPropertyGetter = (MethodSymbol)f_10340_50826_50999(f_10340_50849_50860(), WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__get_Current, diagnostics, f_10340_50951_50979(errorLocationSyntax), isOptional: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 50058, 51283);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 50058, 51283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51098, 51260);

                            currentPropertyGetter = (MethodSymbol)f_10340_51136_51259(this, SpecialMember.System_Collections_Generic_IEnumerator_T__get_Current, diagnostics, errorLocationSyntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 50058, 51283);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51307, 51517) || true) && ((object)currentPropertyGetter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 51307, 51517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51398, 51494);

                            builder.CurrentPropertyGetter = f_10340_51430_51493(currentPropertyGetter, enumeratorType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 51307, 51517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 48907, 51536);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51556, 51868) || true) && (!isAsync)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 51556, 51868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51707, 51849);

                        moveNextMethod = (MethodSymbol)f_10340_51738_51848(this, SpecialMember.System_Collections_IEnumerator__MoveNext, diagnostics, errorLocationSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 51556, 51868);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 51999, 52174) || true) && (moveNextMethod is not null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 51999, 52174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52071, 52155);

                        builder.MoveNextInfo = f_10340_52094_52154(moveNextMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 51999, 52174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 46935, 53367);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 46935, 53367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52316, 52403);

                    f_10340_52316_52402(f_10340_52329_52355(collectionType) == SpecialType.System_Collections_IEnumerable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52423, 52584);

                    builder.GetEnumeratorInfo = f_10340_52451_52583(this, SpecialMember.System_Collections_IEnumerable__GetEnumerator, errorLocationSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52602, 52762);

                    builder.CurrentPropertyGetter = (MethodSymbol)f_10340_52648_52761(this, SpecialMember.System_Collections_IEnumerator__get_Current, diagnostics, errorLocationSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52780, 52931);

                    builder.MoveNextInfo = f_10340_52803_52930(this, SpecialMember.System_Collections_IEnumerator__MoveNext, errorLocationSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 52949, 53150);

                    builder.ElementTypeWithAnnotations = f_10340_52986_53042_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder.CurrentPropertyGetter, 10340, 52986, 53042)?.ReturnTypeWithAnnotations) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10340, 52986, 53149) ?? TypeWithAnnotations.Create(f_10340_53073_53148(this, SpecialType.System_Object, diagnostics, errorLocationSyntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 53170, 53352);

                    f_10340_53170_53351((object)builder.GetEnumeratorInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(10340, 53183, 53350) || f_10340_53249_53304(f_10340_53249_53292(f_10340_53249_53281(builder.GetEnumeratorInfo))) == SpecialType.System_Collections_IEnumerator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 46935, 53367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 53539, 53568);

                builder.NeedsDisposal = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 53582, 53616);

                return EnumeratorResult.Succeeded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 45447, 53627);

                bool
                f_10340_45688_45836(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, ref Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo.Builder
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isAsync, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                foundMultiple)
                {
                    var return_v = this_param.AllInterfacesContainsIEnumerable(ref builder, type, isAsync, diagnostics, out foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 45688, 45836);
                    return return_v;
                }


                bool
                f_10340_45947_46008(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConstantNullCollectionExpr(collectionExpr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 45947, 46008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_46154_46172(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 46154, 46172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_46364_46392(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 46364, 46392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_46479_46495(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 46479, 46495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_46479_46573(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 46479, 46573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_46601_46617(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 46601, 46617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_46601_46686(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 46601, 46686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_46268_46687(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 46268, 46687);
                    return return_v;
                }


                int
                f_10340_46779_46831(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 46779, 46831);
                    return 0;
                }


                bool
                f_10340_46939_46967(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 46939, 46967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_47345_47378(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 47345, 47378);
                    return return_v;
                }


                bool
                f_10340_47326_47379(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsIAsyncEnumerable((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 47326, 47379);
                    return return_v;
                }


                int
                f_10340_47313_47380(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 47313, 47380);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_47464_47475()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 47464, 47475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_47598_47626(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 47598, 47626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_47441_47646(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                isOptional)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, location, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 47441, 47646);
                    return return_v;
                }


                int
                f_10340_47801_47867(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 47801, 47867);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_47959_47989(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 47959, 47989);
                    return return_v;
                }


                bool
                f_10340_47958_48003_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 47958, 48003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_48254_48272(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 48254, 48272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_48254_48281(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 48254, 48281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_48197_48341(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 48197, 48341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_48528_48561(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 48528, 48561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_48528_48573(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 48528, 48573);
                    return return_v;
                }


                int
                f_10340_48515_48630(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 48515, 48630);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_48689_48814(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 48689, 48814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_49031_49075(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 49031, 49075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_49126_49164(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 49126, 49164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_49321_49976(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                extensionReceiverOpt, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                assertMissingParametersAreOptional)
                {
                    var return_v = this_param.BindDefaultArguments(method, extensionReceiverOpt: extensionReceiverOpt, expanded: expanded, syntax, diagnostics, assertMissingParametersAreOptional: assertMissingParametersAreOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 49321, 49976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_50132_50165(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50132, 50165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_50173_50184()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50173, 50184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_50173_50262(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50173, 50262);
                    return return_v;
                }


                bool
                f_10340_50132_50263(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50132, 50263);
                    return return_v;
                }


                int
                f_10340_50119_50264(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50119, 50264);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_50359_50370()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50359, 50370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_50492_50520(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50492, 50520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_50336_50540(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                isOptional)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, location, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50336, 50540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_50677_50732(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50677, 50732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_50849_50860()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50849, 50860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_50951_50979(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 50951, 50979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_50826_50999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                isOptional)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, location, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 50826, 50999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_51136_51259(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 51136, 51259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_51430_51493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 51430, 51493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_51738_51848(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 51738, 51848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_52094_52154(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = MethodArgumentInfo.CreateParameterlessMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 52094, 52154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_52329_52355(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 52329, 52355);
                    return return_v;
                }


                int
                f_10340_52316_52402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 52316, 52402);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_52451_52583(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetParameterlessSpecialTypeMemberInfo(member, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 52451, 52583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_52648_52761(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 52648, 52761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_52803_52930(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetParameterlessSpecialTypeMemberInfo(member, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 52803, 52930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                f_10340_52986_53042_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 52986, 53042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_53073_53148(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 53073, 53148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_53249_53281(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 53249, 53281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_53249_53292(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 53249, 53292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_53249_53304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 53249, 53304);
                    return return_v;
                }


                int
                f_10340_53170_53351(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 53170, 53351);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 45447, 53627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 45447, 53627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReportConstantNullCollectionExpr(BoundExpression collectionExpr, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 53639, 54113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 53768, 54075) || true) && (f_10340_53772_53800(collectionExpr) is { IsNull: true })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 53768, 54075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 53957, 54030);

                    f_10340_53957_54029(                // Spec seems to refer to null literals, but Dev10 reports anything known to be null.
                                    diagnostics, ErrorCode.ERR_NullNotValid, f_10340_54001_54028(f_10340_54001_54019(_syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 54048, 54060);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 53768, 54075);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 54089, 54102);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 53639, 54113);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10340_53772_53800(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 53772, 53800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_54001_54019(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 54001, 54019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_54001_54028(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 54001, 54028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_53957_54029(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 53957, 54029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 53639, 54113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 53639, 54113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetDisposalInfoForEnumerator(ref ForEachEnumeratorInfo.Builder builder, BoundExpression expr, bool isAsync, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 54125, 57346);
                Microsoft.CodeAnalysis.BitVector defaultArguments = default(Microsoft.CodeAnalysis.BitVector);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 54725, 54797);

                TypeSymbol
                enumeratorType = f_10340_54753_54796(f_10340_54753_54785(builder.GetEnumeratorInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 54811, 54861);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 54942, 57274) || true) && ((f_10340_54947_54971_M(!enumeratorType.IsSealed) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 54947, 54983) && !isAsync)) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 54946, 55299) || f_10340_55005_55288(f_10340_55005_55021(this), enumeratorType, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 55094, 55101) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 55104, 55176)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 55179, 55242))) ? f_10340_55104_55176(f_10340_55104_55120(this), WellKnownType.System_IAsyncDisposable) : f_10340_55179_55242(f_10340_55179_55195(this), SpecialType.System_IDisposable), ref useSiteDiagnostics).IsImplicit))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 54942, 57274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 55333, 55362);

                    builder.NeedsDisposal = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 54942, 57274);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 54942, 57274);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 55396, 57274) || true) && (f_10340_55400_55468(f_10340_55400_55411(), MessageID.IDS_FeatureUsingDeclarations) && (DynAbs.Tracing.TraceSender.Expression_True(10340, 55400, 55534) && (f_10340_55494_55522(enumeratorType) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 55494, 55533) || isAsync))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 55396, 57274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 55790, 55836);

                        var
                        patternDisposeDiags = f_10340_55816_55835()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 55854, 55930);

                        var
                        receiver = f_10340_55869_55929(_syntax, enumeratorType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 55948, 56054);

                        MethodSymbol
                        disposeMethod = f_10340_55977_56053(this, receiver, _syntax, isAsync, patternDisposeDiags)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56072, 57214) || true) && (disposeMethod is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 56072, 57214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56141, 56188);

                            f_10340_56141_56187(f_10340_56154_56186_M(!disposeMethod.IsExtensionMethod));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56210, 56273);

                            f_10340_56210_56272(disposeMethod.ParameterRefKinds.IsDefaultOrEmpty);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56297, 56387);

                            var
                            argsBuilder = f_10340_56315_56386(f_10340_56357_56385(disposeMethod))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56409, 56457);

                            var
                            argsToParams = default(ImmutableArray<int>)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56479, 56530);

                            bool
                            expanded = f_10340_56495_56529(disposeMethod)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 56554, 56977);

                            f_10340_56554_56976(this, _syntax, f_10340_56635_56659(disposeMethod), argsBuilder, argumentRefKindsBuilder: null, ref argsToParams, out defaultArguments, expanded, enableCallerInfo: true, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57001, 57030);

                            builder.NeedsDisposal = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57052, 57195);

                            builder.PatternDisposeInfo = f_10340_57081_57194(disposeMethod, f_10340_57119_57151(argsBuilder), argsToParams, defaultArguments, expanded);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 56072, 57214);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57232, 57259);

                        f_10340_57232_57258(patternDisposeDiags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 55396, 57274);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 54942, 57274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57290, 57335);

                f_10340_57290_57334(
                            diagnostics, _syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 54125, 57346);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_54753_54785(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 54753, 54785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_54753_54796(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 54753, 54796);
                    return return_v;
                }


                bool
                f_10340_54947_54971_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 54947, 54971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_55005_55021(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 55005, 55021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_55104_55120(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 55104, 55120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_55104_55176(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55104, 55176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_55179_55195(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 55179, 55195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_55179_55242(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55179, 55242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_55005_55288(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55005, 55288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_55400_55411()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 55400, 55411);
                    return return_v;
                }


                bool
                f_10340_55400_55468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55400, 55468);
                    return return_v;
                }


                bool
                f_10340_55494_55522(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 55494, 55522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10340_55816_55835()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55816, 55835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDisposableValuePlaceholder
                f_10340_55869_55929(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDisposableValuePlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55869, 55929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_55977_56053(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDisposableValuePlaceholder
                expr, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntaxNode, bool
                hasAwait, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryFindDisposePatternMethod((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, hasAwait, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 55977, 56053);
                    return return_v;
                }


                bool
                f_10340_56154_56186_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 56154, 56186);
                    return return_v;
                }


                int
                f_10340_56141_56187(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 56141, 56187);
                    return 0;
                }


                int
                f_10340_56210_56272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 56210, 56272);
                    return 0;
                }


                int
                f_10340_56357_56385(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 56357, 56385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_56315_56386(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 56315, 56386);
                    return return_v;
                }


                bool
                f_10340_56495_56529(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.HasParamsParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 56495, 56529);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_56635_56659(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 56635, 56659);
                    return return_v;
                }


                int
                f_10340_56554_56976(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argumentsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>?
                argumentRefKindsBuilder, ref System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, out Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, bool
                enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindDefaultArguments((Microsoft.CodeAnalysis.SyntaxNode)node, parameters, argumentsBuilder, argumentRefKindsBuilder: argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 56554, 56976);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_57119_57151(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57119, 57151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_57081_57194(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                Method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                Arguments, System.Collections.Immutable.ImmutableArray<int>
                ArgsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                DefaultArguments, bool
                Expanded)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo(Method, Arguments, ArgsToParamsOpt, DefaultArguments, Expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57081, 57194);
                    return return_v;
                }


                int
                f_10340_57232_57258(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57232, 57258);
                    return 0;
                }


                bool
                f_10340_57290_57334(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57290, 57334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 54125, 57346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 54125, 57346);
            }
        }

        private ForEachEnumeratorInfo.Builder GetDefaultEnumeratorInfo(ForEachEnumeratorInfo.Builder builder, DiagnosticBag diagnostics, TypeSymbol collectionExprType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 57358, 59810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57647, 57753);

                builder.CollectionType = f_10340_57672_57752(this, SpecialType.System_Collections_IEnumerable, diagnostics, _syntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57769, 58590) || true) && (f_10340_57773_57803(collectionExprType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 57769, 58590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 57864, 58211);

                    builder.ElementTypeWithAnnotations = TypeWithAnnotations.Create((DynAbs.Tracing.TraceSender.Conditional_F1(10340, 57950, 58052) || (((((DynAbs.Tracing.TraceSender.Conditional_F1(10340, 57952, 57987) || (((_syntax is ForEachStatementSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 57990, 58034)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 58037, 58042))) ? f_10340_57990_58034(f_10340_57990_58028(((ForEachStatementSyntax)_syntax))) : false) == true) && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 58080, 58118)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 58146, 58209))) ? (TypeSymbol)DynamicTypeSymbol.Instance : f_10340_58146_58209(this, SpecialType.System_Object, diagnostics, _syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 57769, 58590);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 57769, 58590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 58277, 58575);

                    builder.ElementTypeWithAnnotations = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 58314, 58373) || ((f_10340_58314_58344(collectionExprType) == SpecialType.System_String && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 58397, 58486)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 58510, 58574))) ? TypeWithAnnotations.Create(f_10340_58424_58485(this, SpecialType.System_Char, diagnostics, _syntax)) : f_10340_58510_58574(((ArrayTypeSymbol)collectionExprType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 57769, 58590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 58836, 58985);

                builder.GetEnumeratorInfo = f_10340_58864_58984(this, SpecialMember.System_Collections_IEnumerable__GetEnumerator, _syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 58999, 59147);

                builder.CurrentPropertyGetter = (MethodSymbol)f_10340_59045_59146(this, SpecialMember.System_Collections_IEnumerator__get_Current, diagnostics, _syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 59161, 59300);

                builder.MoveNextInfo = f_10340_59184_59299(this, SpecialMember.System_Collections_IEnumerator__MoveNext, _syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 59316, 59569);

                f_10340_59316_59568((object)builder.GetEnumeratorInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(10340, 59329, 59567) || f_10340_59391_59567(f_10340_59409_59452(f_10340_59409_59441(builder.GetEnumeratorInfo)), f_10340_59454_59529(f_10340_59454_59470(this), SpecialType.System_Collections_IEnumerator), TypeCompareKind.ConsiderEverything2)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 59741, 59770);

                builder.NeedsDisposal = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 59784, 59799);

                return builder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 57358, 59810);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_57672_57752(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57672, 57752);
                    return return_v;
                }


                bool
                f_10340_57773_57803(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 57773, 57803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10340_57990_58028(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 57990, 58028);
                    return return_v;
                }


                bool
                f_10340_57990_58034(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 57990, 58034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_58146_58209(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 58146, 58209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_58314_58344(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 58314, 58344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_58424_58485(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 58424, 58485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10340_58510_58574(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 58510, 58574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_58864_58984(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetParameterlessSpecialTypeMemberInfo(member, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 58864, 58984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_59045_59146(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 59045, 59146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_59184_59299(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetParameterlessSpecialTypeMemberInfo(member, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 59184, 59299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_59409_59441(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 59409, 59441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_59409_59452(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 59409, 59452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_59454_59470(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 59454, 59470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_59454_59529(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 59454, 59529);
                    return return_v;
                }


                bool
                f_10340_59391_59567(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 59391, 59567);
                    return return_v;
                }


                int
                f_10340_59316_59568(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 59316, 59568);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 57358, 59810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 57358, 59810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SatisfiesGetEnumeratorPattern(ref ForEachEnumeratorInfo.Builder builder, BoundExpression collectionExpr, bool isAsync, bool viaExtensionMethod, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 60715, 61672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 60923, 61008);

                string
                methodName = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 60943, 60950) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 60953, 60981)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 60984, 61007))) ? GetAsyncEnumeratorMethodName : GetEnumeratorMethodName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61022, 61059);

                MethodArgumentInfo
                getEnumeratorInfo
                = default(MethodArgumentInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61073, 61544) || true) && (viaExtensionMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 61073, 61544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61129, 61227);

                    getEnumeratorInfo = f_10340_61149_61226(this, collectionExpr, methodName, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 61073, 61544);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 61073, 61544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61293, 61339);

                    var
                    lookupResult = f_10340_61312_61338()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61357, 61491);

                    getEnumeratorInfo = f_10340_61377_61490(this, f_10340_61402_61421(collectionExpr), methodName, lookupResult, warningsOnly: true, diagnostics, isAsync);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61509, 61529);

                    f_10340_61509_61528(lookupResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 61073, 61544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61560, 61606);

                builder.GetEnumeratorInfo = getEnumeratorInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 61620, 61661);

                return (object)getEnumeratorInfo != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 60715, 61672);

                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_61149_61226(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                collectionExpr, string
                methodName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FindForEachPatternMethodViaExtension(collectionExpr, methodName, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 61149, 61226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10340_61312_61338()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 61312, 61338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_61402_61421(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 61402, 61421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_61377_61490(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                patternType, string
                methodName, Microsoft.CodeAnalysis.CSharp.LookupResult
                lookupResult, bool
                warningsOnly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isAsync)
                {
                    var return_v = this_param.FindForEachPatternMethod(patternType, methodName, lookupResult, warningsOnly: warningsOnly, diagnostics, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 61377, 61490);
                    return return_v;
                }


                int
                f_10340_61509_61528(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 61509, 61528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 60715, 61672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 60715, 61672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodArgumentInfo FindForEachPatternMethod(TypeSymbol patternType, string methodName, LookupResult lookupResult, bool warningsOnly, DiagnosticBag diagnostics, bool isAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 62354, 65094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 62560, 62595);

                f_10340_62560_62594(f_10340_62573_62593(lookupResult));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 62776, 62826);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 62840, 63209);

                f_10340_62840_63208(this, lookupResult, patternType, methodName, arity: 0, basesBeingResolved: null, options: LookupOptions.Default, originalBinder: this, diagnose: false, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63225, 63281);

                f_10340_63225_63280(
                            diagnostics, f_10340_63241_63259(_syntax), useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63297, 63510) || true) && (f_10340_63301_63328_M(!lookupResult.IsMultiViable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 63297, 63510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63362, 63465);

                    f_10340_63362_63464(this, lookupResult, patternType, methodName, warningsOnly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63483, 63495);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 63297, 63510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63526, 63613);

                ArrayBuilder<MethodSymbol>
                candidateMethods = f_10340_63572_63612()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63629, 64852);
                    foreach (Symbol member in f_10340_63655_63675_I(f_10340_63655_63675(lookupResult)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 63629, 64852);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63709, 64035) || true) && (f_10340_63713_63724(member) != SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 63709, 64035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63787, 63811);

                            f_10340_63787_63810(candidateMethods);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63835, 63982) || true) && (warningsOnly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 63835, 63982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 63901, 63959);

                                f_10340_63901_63958(this, diagnostics, patternType, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 63835, 63982);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 64004, 64016);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 63709, 64035);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 64055, 64098);

                        MethodSymbol
                        method = (MethodSymbol)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 64692, 64837) || true) && (f_10340_64696_64717(method) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10340, 64696, 64733) || isAsync))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 64692, 64837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 64775, 64818);

                            f_10340_64775_64817(candidateMethods, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 64692, 64837);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 63629, 64852);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10340, 1, 1224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10340, 1, 1224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 64868, 65008);

                MethodArgumentInfo
                patternInfo = f_10340_64901_65007(this, patternType, candidateMethods, warningsOnly, diagnostics, isAsync)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65024, 65048);

                f_10340_65024_65047(
                            candidateMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65064, 65083);

                return patternInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 62354, 65094);

                bool
                f_10340_62573_62593(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 62573, 62593);
                    return return_v;
                }


                int
                f_10340_62560_62594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 62560, 62594);
                    return 0;
                }


                int
                f_10340_62840_63208(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInType(result, type, name, arity: arity, basesBeingResolved: basesBeingResolved, options: options, originalBinder: (Microsoft.CodeAnalysis.CSharp.Binder)originalBinder, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 62840, 63208);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_63241_63259(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 63241, 63259);
                    return return_v;
                }


                bool
                f_10340_63225_63280(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63225, 63280);
                    return return_v;
                }


                bool
                f_10340_63301_63328_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 63301, 63328);
                    return return_v;
                }


                int
                f_10340_63362_63464(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                lookupResult, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, string
                memberName, bool
                warningsOnly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportPatternMemberLookupDiagnostics(lookupResult, patternType, memberName, warningsOnly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63362, 63464);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10340_63572_63612()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63572, 63612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10340_63655_63675(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 63655, 63675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10340_63713_63724(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 63713, 63724);
                    return return_v;
                }


                int
                f_10340_63787_63810(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63787, 63810);
                    return 0;
                }


                int
                f_10340_63901_63958(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                enumeratorType, Microsoft.CodeAnalysis.CSharp.Symbol
                patternMemberCandidate)
                {
                    this_param.ReportEnumerableWarning(diagnostics, enumeratorType, patternMemberCandidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63901, 63958);
                    return 0;
                }


                int
                f_10340_64696_64717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 64696, 64717);
                    return return_v;
                }


                int
                f_10340_64775_64817(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 64775, 64817);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10340_63655_63675_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 63655, 63675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_64901_65007(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                candidateMethods, bool
                warningsOnly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isAsync)
                {
                    var return_v = this_param.PerformForEachPatternOverloadResolution(patternType, candidateMethods, warningsOnly, diagnostics, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 64901, 65007);
                    return return_v;
                }


                int
                f_10340_65024_65047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 65024, 65047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 62354, 65094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 62354, 65094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodArgumentInfo PerformForEachPatternOverloadResolution(TypeSymbol patternType, ArrayBuilder<MethodSymbol> candidateMethods, bool warningsOnly, DiagnosticBag diagnostics, bool isAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 65313, 69225);
                Microsoft.CodeAnalysis.BitVector defaultArguments = default(Microsoft.CodeAnalysis.BitVector);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65533, 65589);

                var
                analyzedArguments = f_10340_65557_65588()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65603, 65671);

                var
                typeArguments = f_10340_65623_65670()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65685, 65769);

                var
                overloadResolutionResult = f_10340_65716_65768()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65785, 65835);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 65998, 66077);

                var
                dummyReceiver = f_10340_66018_66076(f_10340_66044_66062(_syntax), patternType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66091, 66443);

                f_10340_66091_66442(f_10340_66091_66114(this), methods: candidateMethods, typeArguments: typeArguments, receiver: dummyReceiver, arguments: analyzedArguments, result: overloadResolutionResult, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66457, 66513);

                f_10340_66457_66512(diagnostics, f_10340_66473_66491(_syntax), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66529, 66556);

                MethodSymbol
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66570, 66601);

                MethodArgumentInfo
                info = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66617, 69064) || true) && (f_10340_66621_66655(overloadResolutionResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 66617, 69064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66689, 66742);

                    result = overloadResolutionResult.ValidResult.Member;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66762, 68595) || true) && (f_10340_66766_66781(result) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 66766, 66837) || f_10340_66785_66813(result) != Accessibility.Public))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 66762, 68595);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66879, 67224) || true) && (warningsOnly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 66879, 67224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 66945, 67040);

                            MessageID
                            patternName = (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 66969, 66976) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 66979, 67012)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 67015, 67039))) ? MessageID.IDS_FeatureAsyncStreams : MessageID.IDS_Collection
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67066, 67201);

                            f_10340_67066_67200(diagnostics, ErrorCode.WRN_PatternNotPublicOrNotInstance, f_10340_67127_67154(f_10340_67127_67145(_syntax)), patternType, f_10340_67169_67191(patternName), result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 66879, 67224);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67246, 67260);

                        result = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 66762, 68595);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 66762, 68595);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67302, 68595) || true) && (f_10340_67306_67348(result, f_10340_67329_67347(_syntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 67302, 68595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67668, 67682);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 67302, 68595);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 67302, 68595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67764, 67843);

                            var
                            argsToParams = overloadResolutionResult.ValidResult.Result.ArgsToParamsOpt
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 67865, 67978);

                            var
                            expanded = overloadResolutionResult.ValidResult.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 68000, 68429);

                            f_10340_68000_68428(this, _syntax, f_10340_68081_68098(result), analyzedArguments.Arguments, analyzedArguments.RefKinds, ref argsToParams, out defaultArguments, expanded, enableCallerInfo: true, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 68453, 68576);

                            info = f_10340_68460_68575(result, f_10340_68491_68532(analyzedArguments.Arguments), argsToParams, defaultArguments, expanded);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 67302, 68595);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 66762, 68595);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 66617, 69064);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 66617, 69064);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 68629, 69064) || true) && (f_10340_68633_68683(overloadResolutionResult) is var applicableMembers && (DynAbs.Tracing.TraceSender.Expression_True(10340, 68633, 68740) && applicableMembers.Length > 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 68629, 69064);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 68774, 69049) || true) && (warningsOnly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 68774, 69049);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 68832, 69030);

                            f_10340_68832_69029(diagnostics, ErrorCode.WRN_PatternIsAmbiguous, f_10340_68882_68909(f_10340_68882_68900(_syntax)), patternType, f_10340_68924_68959(MessageID.IDS_Collection), applicableMembers[0], applicableMembers[1]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 68774, 69049);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 68629, 69064);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 66617, 69064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69080, 69112);

                f_10340_69080_69111(
                            overloadResolutionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69126, 69151);

                f_10340_69126_69150(analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69165, 69186);

                f_10340_69165_69185(typeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69202, 69214);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 65313, 69225);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10340_65557_65588()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 65557, 65588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10340_65623_65670()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 65623, 65670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10340_65716_65768()
                {
                    var return_v = OverloadResolutionResult<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 65716, 65768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_66044_66062(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66044, 66062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                f_10340_66018_66076(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 66018, 66076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution
                f_10340_66091_66114(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.OverloadResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66091, 66114);
                    return return_v;
                }


                int
                f_10340_66091_66442(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.MethodInvocationOverloadResolution(methods: methods, typeArguments: typeArguments, receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, arguments: arguments, result: result, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 66091, 66442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_66473_66491(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66473, 66491);
                    return return_v;
                }


                bool
                f_10340_66457_66512(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 66457, 66512);
                    return return_v;
                }


                bool
                f_10340_66621_66655(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66621, 66655);
                    return return_v;
                }


                bool
                f_10340_66766_66781(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66766, 66781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10340_66785_66813(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 66785, 66813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_67127_67145(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 67127, 67145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_67127_67154(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 67127, 67154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10340_67169_67191(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 67169, 67191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_67066_67200(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 67066, 67200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10340_67329_67347(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 67329, 67347);
                    return return_v;
                }


                bool
                f_10340_67306_67348(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 67306, 67348);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_68081_68098(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 68081, 68098);
                    return return_v;
                }


                int
                f_10340_68000_68428(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argumentsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsBuilder, ref System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, out Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, bool
                enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindDefaultArguments((Microsoft.CodeAnalysis.SyntaxNode)node, parameters, argumentsBuilder, argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68000, 68428);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_68491_68532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68491, 68532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_68460_68575(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                Method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                Arguments, System.Collections.Immutable.ImmutableArray<int>
                ArgsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                DefaultArguments, bool
                Expanded)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo(Method, Arguments, ArgsToParamsOpt, DefaultArguments, Expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68460, 68575);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10340_68633_68683(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.GetAllApplicableMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68633, 68683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_68882_68900(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 68882, 68900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_68882_68909(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 68882, 68909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10340_68924_68959(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68924, 68959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_68832_69029(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 68832, 69029);
                    return return_v;
                }


                int
                f_10340_69080_69111(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69080, 69111);
                    return 0;
                }


                int
                f_10340_69126_69150(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69126, 69150);
                    return 0;
                }


                int
                f_10340_69165_69185(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69165, 69185);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 65313, 69225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 65313, 69225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodArgumentInfo FindForEachPatternMethodViaExtension(BoundExpression collectionExpr, string methodName, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 69237, 73301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69403, 69459);

                var
                analyzedArguments = f_10340_69427_69458()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69475, 69851);

                var
                methodGroupResolutionResult = f_10340_69509_69850(this, f_10340_69552_69570(_syntax), methodName, analyzedArguments, collectionExpr, typeArgumentsWithAnnotations: default, isMethodGroupConversion: false, returnRefKind: default, returnType: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69867, 69929);

                f_10340_69867_69928(
                            diagnostics, methodGroupResolutionResult.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 69945, 70029);

                var
                overloadResolutionResult = methodGroupResolutionResult.OverloadResolutionResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70043, 73174) || true) && (f_10340_70047_70082_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(overloadResolutionResult, 10340, 70047, 70082)?.Succeeded) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10340, 70047, 70091) ?? false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 70043, 73174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70125, 70182);

                    var
                    result = overloadResolutionResult.ValidResult.Member
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70202, 70703) || true) && (f_10340_70206_70248(result, f_10340_70229_70247(_syntax)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 70202, 70703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70568, 70603);

                        methodGroupResolutionResult.Free();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70625, 70650);

                        f_10340_70625_70649(analyzedArguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70672, 70684);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 70202, 70703);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70723, 70773);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70791, 70935);

                    var
                    collectionConversion = f_10340_70818_70934(f_10340_70818_70834(this), collectionExpr, f_10340_70884_70909(f_10340_70884_70901(result)[0]), ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 70953, 70998);

                    f_10340_70953_70997(diagnostics, _syntax, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 71156, 71565);

                    collectionExpr = f_10340_71173_71564(collectionExpr.Syntax, collectionExpr, collectionConversion, @checked: f_10340_71349_71371(), explicitCastInCode: false, conversionGroupOpt: null, ConstantValue.NotAvailable, f_10340_71538_71563(f_10340_71538_71555(result)[0]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 71585, 71892);

                    var
                    info = f_10340_71596_71891(this, result, collectionExpr, expanded: overloadResolutionResult.ValidResult.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm, collectionExpr.Syntax, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 71910, 71945);

                    methodGroupResolutionResult.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 71963, 71988);

                    f_10340_71963_71987(analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 72006, 72018);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 70043, 73174);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 70043, 73174);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 72052, 73174) || true) && (f_10340_72056_72107_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(overloadResolutionResult, 10340, 72056, 72107)?.GetAllApplicableMembers()) is { } applicableMembers && (DynAbs.Tracing.TraceSender.Expression_True(10340, 72056, 72164) && applicableMembers.Length > 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 72052, 73174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 72198, 72400);

                        f_10340_72198_72399(diagnostics, ErrorCode.WRN_PatternIsAmbiguous, f_10340_72248_72275(f_10340_72248_72266(_syntax)), f_10340_72277_72296(collectionExpr), f_10340_72298_72333(MessageID.IDS_Collection), applicableMembers[0], applicableMembers[1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 72052, 73174);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 72052, 73174);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 72434, 73174) || true) && (overloadResolutionResult != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 72434, 73174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 72504, 73159);

                            f_10340_72504_73158(overloadResolutionResult, binder: this, location: f_10340_72614_72641(f_10340_72614_72632(_syntax)), nodeOpt: f_10340_72673_72691(_syntax), diagnostics: diagnostics, name: methodName, receiver: null, invokedExpression: f_10340_72856_72874(_syntax), arguments: methodGroupResolutionResult.AnalyzedArguments, memberGroup: f_10340_72989_73050(f_10340_72989_73036(methodGroupResolutionResult.MethodGroup)), typeContainingConstructor: null, delegateTypeBeingInvoked: null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 72434, 73174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 72052, 73174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 70043, 73174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 73190, 73225);

                methodGroupResolutionResult.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 73239, 73264);

                f_10340_73239_73263(analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 73278, 73290);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 69237, 73301);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10340_69427_69458()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69427, 69458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_69552_69570(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 69552, 69570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10340_69509_69850(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = this_param.BindExtensionMethod((Microsoft.CodeAnalysis.SyntaxNode)expression, methodName, analyzedArguments, left, typeArgumentsWithAnnotations: typeArgumentsWithAnnotations, isMethodGroupConversion: isMethodGroupConversion, returnRefKind: returnRefKind, returnType: returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69509, 69850);
                    return return_v;
                }


                int
                f_10340_69867_69928(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 69867, 69928);
                    return 0;
                }


                bool?
                f_10340_70047_70082_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 70047, 70082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10340_70229_70247(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 70229, 70247);
                    return return_v;
                }


                bool
                f_10340_70206_70248(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 70206, 70248);
                    return return_v;
                }


                int
                f_10340_70625_70649(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 70625, 70649);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_70818_70834(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 70818, 70834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_70884_70901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 70884, 70901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_70884_70909(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 70884, 70909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_70818_70934(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 70818, 70934);
                    return return_v;
                }


                bool
                f_10340_70953_70997(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 70953, 70997);
                    return return_v;
                }


                bool
                f_10340_71349_71371()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 71349, 71371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_71538_71555(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 71538, 71555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_71538_71563(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 71538, 71563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10340_71173_71564(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 71173, 71564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_71596_71891(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                extensionReceiverOpt, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDefaultArguments(method, extensionReceiverOpt, expanded: expanded, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 71596, 71891);
                    return return_v;
                }


                int
                f_10340_71963_71987(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 71963, 71987);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>?
                f_10340_72056_72107_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 72056, 72107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_72248_72266(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72248, 72266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_72248_72275(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72248, 72275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10340_72277_72296(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72277, 72296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10340_72298_72333(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 72298, 72333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_72198_72399(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 72198, 72399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_72614_72632(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72614, 72632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_72614_72641(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72614, 72641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_72673_72691(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72673, 72691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_72856_72874(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72856, 72874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10340_72989_73036(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 72989, 73036);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10340_72989_73050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 72989, 73050);
                    return return_v;
                }


                int
                f_10340_72504_73158(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                binder, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                invokedExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                memberGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructor, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked)
                {
                    this_param.ReportDiagnostics<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(binder: (Microsoft.CodeAnalysis.CSharp.Binder)binder, location: location, nodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)nodeOpt, diagnostics: diagnostics, name: name, receiver: receiver, invokedExpression: (Microsoft.CodeAnalysis.SyntaxNode)invokedExpression, arguments: arguments, memberGroup: memberGroup, typeContainingConstructor: typeContainingConstructor, delegateTypeBeingInvoked: delegateTypeBeingInvoked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 72504, 73158);
                    return 0;
                }


                int
                f_10340_73239_73263(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 73239, 73263);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 69237, 73301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 69237, 73301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SatisfiesForEachPattern(ref ForEachEnumeratorInfo.Builder builder, bool isAsync, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 74146, 79062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 74291, 74354);

                f_10340_74291_74353((object)f_10340_74312_74344(builder.GetEnumeratorInfo) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 74370, 74438);

                MethodSymbol
                getEnumeratorMethod = f_10340_74405_74437(builder.GetEnumeratorInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 74452, 74511);

                TypeSymbol
                enumeratorType = f_10340_74480_74510(getEnumeratorMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 74527, 75252);

                switch (f_10340_74535_74558(enumeratorType))
                {

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                    case TypeKind.TypeParameter: // Not specifically mentioned in the spec, but consistent with Dev10.
                    case TypeKind.Dynamic: // Not specifically mentioned in the spec, but consistent with Dev10.
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 74527, 75252);
                        DynAbs.Tracing.TraceSender.TraceBreak(10340, 74941, 74947);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 74527, 75252);

                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 74527, 75252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 75108, 75174);

                        throw f_10340_75114_75173(f_10340_75149_75172(enumeratorType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 74527, 75252);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 74527, 75252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 75224, 75237);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 74527, 75252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 75337, 75392);

                LookupResult
                lookupResult = f_10340_75365_75391()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 75803, 75853);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 75871, 76342);

                    f_10340_75871_76341(this, lookupResult, enumeratorType, CurrentPropertyName, arity: 0, basesBeingResolved: null, options: LookupOptions.Default, originalBinder: this, diagnose: false, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76362, 76418);

                    f_10340_76362_76417(
                                    diagnostics, f_10340_76378_76396(_syntax), useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76436, 76462);

                    useSiteDiagnostics = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76482, 76745) || true) && (f_10340_76486_76514_M(!lookupResult.IsSingleViable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 76482, 76745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76556, 76691);

                        f_10340_76556_76690(this, lookupResult, enumeratorType, CurrentPropertyName, warningsOnly: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76713, 76726);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 76482, 76745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76859, 76916);

                    Symbol
                    lookupSymbol = f_10340_76881_76915(lookupResult)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76934, 76977);

                    f_10340_76934_76976((object)lookupSymbol != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 76997, 77202) || true) && (f_10340_77001_77022(lookupSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 77001, 77084) || f_10340_77026_77060(lookupSymbol) != Accessibility.Public) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 77001, 77128) || f_10340_77088_77105(lookupSymbol) != SymbolKind.Property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 76997, 77202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77170, 77183);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 76997, 77202);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77299, 77405);

                    MethodSymbol
                    currentPropertyGetterCandidate = f_10340_77345_77404(((PropertySymbol)lookupSymbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77425, 78062) || true) && ((object)currentPropertyGetterCandidate == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 77425, 78062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77517, 77530);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 77425, 78062);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 77425, 78062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77612, 77706);

                        bool
                        isAccessible = f_10340_77632_77705(this, currentPropertyGetterCandidate, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77728, 77784);

                        f_10340_77728_77783(diagnostics, f_10340_77744_77762(_syntax), useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 77808, 78043) || true) && (!isAccessible)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 77808, 78043);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78007, 78020);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 77808, 78043);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 77425, 78062);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78082, 78145);

                    builder.CurrentPropertyGetter = currentPropertyGetterCandidate;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78165, 78186);

                    f_10340_78165_78185(
                                    lookupResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78237, 78478);

                    MethodArgumentInfo
                    moveNextMethodCandidate = f_10340_78282_78477(this, enumeratorType, (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 78344, 78351) || ((isAsync && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 78354, 78377)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 78380, 78398))) ? MoveNextAsyncMethodName : MoveNextMethodName, lookupResult, warningsOnly: false, diagnostics, isAsync)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78498, 78848) || true) && ((object)moveNextMethodCandidate == null || (DynAbs.Tracing.TraceSender.Expression_False(10340, 78502, 78605) || f_10340_78566_78605(f_10340_78566_78596(moveNextMethodCandidate))) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 78502, 78685) || f_10340_78609_78661(f_10340_78609_78639(moveNextMethodCandidate)) != Accessibility.Public) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 78502, 78774) || f_10340_78710_78774(this, f_10340_78734_78764(moveNextMethodCandidate), isAsync)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 78498, 78848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78816, 78829);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 78498, 78848);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78868, 78915);

                    builder.MoveNextInfo = moveNextMethodCandidate;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 78935, 78947);

                    return true;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10340, 78976, 79051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79016, 79036);

                    f_10340_79016_79035(lookupResult);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10340, 78976, 79051);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 74146, 79062);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_74312_74344(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 74312, 74344);
                    return return_v;
                }


                int
                f_10340_74291_74353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 74291, 74353);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_74405_74437(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 74405, 74437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_74480_74510(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 74480, 74510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10340_74535_74558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 74535, 74558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10340_75149_75172(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 75149, 75172);
                    return return_v;
                }


                System.Exception
                f_10340_75114_75173(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 75114, 75173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10340_75365_75391()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 75365, 75391);
                    return return_v;
                }


                int
                f_10340_75871_76341(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInType(result, type, name, arity: arity, basesBeingResolved: basesBeingResolved, options: options, originalBinder: (Microsoft.CodeAnalysis.CSharp.Binder)originalBinder, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 75871, 76341);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_76378_76396(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 76378, 76396);
                    return return_v;
                }


                bool
                f_10340_76362_76417(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 76362, 76417);
                    return return_v;
                }


                bool
                f_10340_76486_76514_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 76486, 76514);
                    return return_v;
                }


                int
                f_10340_76556_76690(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                lookupResult, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, string
                memberName, bool
                warningsOnly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportPatternMemberLookupDiagnostics(lookupResult, patternType, memberName, warningsOnly: warningsOnly, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 76556, 76690);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_76881_76915(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.SingleSymbolOrDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 76881, 76915);
                    return return_v;
                }


                int
                f_10340_76934_76976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 76934, 76976);
                    return 0;
                }


                bool
                f_10340_77001_77022(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 77001, 77022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10340_77026_77060(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 77026, 77060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10340_77088_77105(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 77088, 77105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10340_77345_77404(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = ((PropertySymbol)property).GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 77345, 77404);
                    return return_v;
                }


                bool
                f_10340_77632_77705(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 77632, 77705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_77744_77762(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 77744, 77762);
                    return return_v;
                }


                bool
                f_10340_77728_77783(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 77728, 77783);
                    return return_v;
                }


                int
                f_10340_78165_78185(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 78165, 78185);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_78282_78477(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, string
                methodName, Microsoft.CodeAnalysis.CSharp.LookupResult
                lookupResult, bool
                warningsOnly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isAsync)
                {
                    var return_v = this_param.FindForEachPatternMethod(patternType, methodName, lookupResult, warningsOnly: warningsOnly, diagnostics, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 78282, 78477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_78566_78596(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 78566, 78596);
                    return return_v;
                }


                bool
                f_10340_78566_78605(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 78566, 78605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_78609_78639(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 78609, 78639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10340_78609_78661(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 78609, 78661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_78734_78764(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 78734, 78764);
                    return return_v;
                }


                bool
                f_10340_78710_78774(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                moveNextMethodCandidate, bool
                isAsync)
                {
                    var return_v = this_param.IsInvalidMoveNextMethod(moveNextMethodCandidate, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 78710, 78774);
                    return return_v;
                }


                int
                f_10340_79016_79035(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 79016, 79035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 74146, 79062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 74146, 79062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsInvalidMoveNextMethod(MethodSymbol moveNextMethodCandidate, bool isAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 79074, 79638);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79187, 79369) || true) && (isAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 79187, 79369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79341, 79354);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 79187, 79369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79524, 79627);

                return f_10340_79531_79596(f_10340_79531_79584(f_10340_79531_79573(moveNextMethodCandidate))) != SpecialType.System_Boolean;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 79074, 79638);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10340_79531_79573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 79531, 79573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_79531_79584(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 79531, 79584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_79531_79596(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 79531, 79596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 79074, 79638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 79074, 79638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportEnumerableWarning(DiagnosticBag diagnostics, TypeSymbol enumeratorType, Symbol patternMemberCandidate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 79650, 80218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79796, 79846);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79860, 80135) || true) && (f_10340_79864_79929(this, patternMemberCandidate, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 79860, 80135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 79963, 80120);

                    f_10340_79963_80119(diagnostics, ErrorCode.WRN_PatternBadSignature, f_10340_80014_80041(f_10340_80014_80032(_syntax)), enumeratorType, f_10340_80059_80094(MessageID.IDS_Collection), patternMemberCandidate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 79860, 80135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 80151, 80207);

                f_10340_80151_80206(
                            diagnostics, f_10340_80167_80185(_syntax), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 79650, 80218);

                bool
                f_10340_79864_79929(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible(symbol, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 79864, 79929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_80014_80032(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80014, 80032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_80014_80041(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80014, 80041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10340_80059_80094(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 80059, 80094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_79963_80119(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 79963, 80119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_80167_80185(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80167, 80185);
                    return return_v;
                }


                bool
                f_10340_80151_80206(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 80151, 80206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 79650, 80218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 79650, 80218);
            }
        }

        private static bool IsIEnumerable(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10340, 80230, 80641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 80305, 80630);

                switch (f_10340_80313_80362(((TypeSymbol)f_10340_80326_80349(type))))
                {

                    case SpecialType.System_Collections_IEnumerable:
                    case SpecialType.System_Collections_Generic_IEnumerable_T:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 80305, 80630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 80542, 80554);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 80305, 80630);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 80305, 80630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 80602, 80615);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 80305, 80630);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10340, 80230, 80641);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_80326_80349(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80326, 80349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_80313_80362(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80313, 80362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 80230, 80641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 80230, 80641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsIAsyncEnumerable(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 80653, 80866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 80726, 80855);

                return f_10340_80733_80854(f_10340_80733_80756(type), f_10340_80764_80853(f_10340_80764_80775(), WellKnownType.System_Collections_Generic_IAsyncEnumerable_T));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 80653, 80866);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10340_80733_80756(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80733, 80756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_80764_80775()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 80764, 80775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_80764_80853(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 80764, 80853);
                    return return_v;
                }


                bool
                f_10340_80733_80854(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 80733, 80854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 80653, 80866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 80653, 80866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AllInterfacesContainsIEnumerable(
                    ref ForEachEnumeratorInfo.Builder builder,
                    TypeSymbol type,
                    bool isAsync,
                    DiagnosticBag diagnostics,
                    out bool foundMultiple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 81565, 83148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 81826, 81876);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 81890, 82020);

                NamedTypeSymbol
                implementedIEnumerable = f_10340_81931_82019(type, isAsync, f_10340_81964_81975(), ref useSiteDiagnostics, out foundMultiple)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82110, 82941) || true) && (((object)implementedIEnumerable == null) || (DynAbs.Tracing.TraceSender.Expression_False(10340, 82114, 82224) || !f_10340_82159_82224(this, implementedIEnumerable, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 82110, 82941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82258, 82288);

                    implementedIEnumerable = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82308, 82926) || true) && (!isAsync)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 82308, 82926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82362, 82466);

                        var
                        implementedNonGeneric = f_10340_82390_82465(f_10340_82390_82406(this), SpecialType.System_Collections_IEnumerable)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82488, 82907) || true) && ((object)implementedNonGeneric != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 82488, 82907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82579, 82701);

                            var
                            conversion = f_10340_82596_82700(f_10340_82596_82612(this), type, implementedNonGeneric, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82727, 82884) || true) && (conversion.IsImplicit)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 82727, 82884);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82810, 82857);

                                implementedIEnumerable = implementedNonGeneric;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 82727, 82884);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 82488, 82907);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 82308, 82926);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 82110, 82941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 82957, 83013);

                f_10340_82957_83012(
                            diagnostics, f_10340_82973_82991(_syntax), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83029, 83077);

                builder.CollectionType = implementedIEnumerable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83091, 83137);

                return (object)implementedIEnumerable != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 81565, 83148);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_81964_81975()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 81964, 81975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_81931_82019(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, out bool
                foundMultiple)
                {
                    var return_v = GetIEnumerableOfT(type, isAsync, compilation, ref useSiteDiagnostics, out foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 81931, 82019);
                    return return_v;
                }


                bool
                f_10340_82159_82224(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 82159, 82224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10340_82390_82406(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 82390, 82406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_82390_82465(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 82390, 82465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10340_82596_82612(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 82596, 82612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10340_82596_82700(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 82596, 82700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_82973_82991(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 82973, 82991);
                    return return_v;
                }


                bool
                f_10340_82957_83012(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 82957, 83012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 81565, 83148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 81565, 83148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol GetIEnumerableOfT(TypeSymbol type, bool isAsync, CSharpCompilation compilation, ref HashSet<DiagnosticInfo> useSiteDiagnostics, out bool foundMultiple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10340, 83160, 84300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83368, 83414);

                NamedTypeSymbol
                implementedIEnumerable = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83428, 83450);

                foundMultiple = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83466, 84243) || true) && (f_10340_83470_83483(type) == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 83466, 84243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83543, 83589);

                    var
                    typeParameter = (TypeParameterSymbol)type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83607, 83877);

                    var
                    allInterfaces = f_10340_83627_83753(f_10340_83627_83683(typeParameter, ref useSiteDiagnostics), ref useSiteDiagnostics).Concat(f_10340_83783_83875(typeParameter, ref useSiteDiagnostics))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 83895, 83998);

                    f_10340_83895_83997(allInterfaces, isAsync, compilation, ref @implementedIEnumerable, ref foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 83466, 84243);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 83466, 84243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84064, 84228);

                    f_10340_84064_84227(f_10340_84082_84156(type, ref useSiteDiagnostics), isAsync, compilation, ref @implementedIEnumerable, ref foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 83466, 84243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84259, 84289);

                return implementedIEnumerable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10340, 83160, 84300);

                Microsoft.CodeAnalysis.TypeKind
                f_10340_83470_83483(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 83470, 83483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_83627_83683(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 83627, 83683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10340_83627_83753(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 83627, 83753);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10340_83783_83875(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 83783, 83875);
                    return return_v;
                }


                int
                f_10340_83895_83997(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                result, ref bool
                foundMultiple)
                {
                    GetIEnumerableOfT(interfaces, isAsync, compilation, ref result, ref foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 83895, 83997);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10340_84082_84156(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84082, 84156);
                    return return_v;
                }


                int
                f_10340_84064_84227(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                result, ref bool
                foundMultiple)
                {
                    GetIEnumerableOfT(interfaces, isAsync, compilation, ref result, ref foundMultiple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84064, 84227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 83160, 84300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 83160, 84300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetIEnumerableOfT(ImmutableArray<NamedTypeSymbol> interfaces, bool isAsync, CSharpCompilation compilation, ref NamedTypeSymbol result, ref bool foundMultiple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10340, 84312, 85335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84515, 84588) || true) && (foundMultiple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 84515, 84588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84566, 84573);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 84515, 84588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84604, 84707);

                interfaces = f_10340_84617_84706(interfaces, VarianceKind.In);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84723, 85324);
                    foreach (NamedTypeSymbol @interface in f_10340_84762_84772_I(interfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 84723, 85324);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84806, 85309) || true) && (f_10340_84810_84877(f_10340_84825_84854(@interface), isAsync, compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 84806, 85309);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 84919, 85290) || true) && ((object)result == null || (DynAbs.Tracing.TraceSender.Expression_False(10340, 84923, 85045) || f_10340_84974_85045(@interface, result, TypeCompareKind.IgnoreTupleNames)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 84919, 85290);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85095, 85115);

                                result = @interface;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 84919, 85290);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 84919, 85290);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85213, 85234);

                                foundMultiple = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85260, 85267);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 84919, 85290);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 84806, 85309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 84723, 85324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10340, 1, 602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10340, 1, 602);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10340, 84312, 85335);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10340_84617_84706(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = MethodTypeInferrer.ModuloReferenceTypeNullabilityDifferences(interfaces, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84617, 84706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_84825_84854(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 84825, 84854);
                    return return_v;
                }


                bool
                f_10340_84810_84877(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = IsIEnumerableT((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, isAsync, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84810, 84877);
                    return return_v;
                }


                bool
                f_10340_84974_85045(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84974, 85045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10340_84762_84772_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 84762, 84772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 84312, 85335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 84312, 85335);
            }
        }

        internal static bool IsIEnumerableT(TypeSymbol type, bool isAsync, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10340, 85347, 85796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85469, 85785) || true) && (isAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 85469, 85785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85514, 85624);

                    return f_10340_85521_85623(type, f_10340_85533_85622(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 85469, 85785);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 85469, 85785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 85690, 85770);

                    return f_10340_85697_85713(type) == SpecialType.System_Collections_Generic_IEnumerable_T;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 85469, 85785);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10340, 85347, 85796);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10340_85533_85622(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 85533, 85622);
                    return return_v;
                }


                bool
                f_10340_85521_85623(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 85521, 85623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10340_85697_85713(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 85697, 85713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 85347, 85796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 85347, 85796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportPatternMemberLookupDiagnostics(LookupResult lookupResult, TypeSymbol patternType, string memberName, bool warningsOnly, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 86409, 87940);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 86599, 87929) || true) && (f_10340_86603_86629(f_10340_86603_86623(lookupResult)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 86599, 87929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 86663, 87731) || true) && (warningsOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 86663, 87731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 86721, 86801);

                        f_10340_86721_86800(this, diagnostics, patternType, f_10340_86771_86799(f_10340_86771_86791(lookupResult)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 86663, 87731);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 86663, 87731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 86883, 86904);

                        f_10340_86883_86903(lookupResult);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 86928, 86978);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87000, 87440);

                        f_10340_87000_87439(this, lookupResult, patternType, memberName, arity: 0, basesBeingResolved: null, options: LookupOptions.Default, originalBinder: this, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87464, 87520);

                        f_10340_87464_87519(
                                            diagnostics, f_10340_87480_87498(_syntax), useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87544, 87712) || true) && (f_10340_87548_87566(lookupResult) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 87544, 87712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87624, 87689);

                            f_10340_87624_87688(diagnostics, f_10340_87640_87658(lookupResult), f_10340_87660_87687(f_10340_87660_87678(_syntax)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 87544, 87712);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 86663, 87731);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 86599, 87929);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 86599, 87929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87765, 87929) || true) && (!warningsOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 87765, 87929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 87816, 87914);

                        f_10340_87816_87913(diagnostics, ErrorCode.ERR_NoSuchMember, f_10340_87860_87887(f_10340_87860_87878(_syntax)), patternType, memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 87765, 87929);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 86599, 87929);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 86409, 87940);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10340_86603_86623(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 86603, 86623);
                    return return_v;
                }


                bool
                f_10340_86603_86629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 86603, 86629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10340_86771_86791(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 86771, 86791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_86771_86799(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.First();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 86771, 86799);
                    return return_v;
                }


                int
                f_10340_86721_86800(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                enumeratorType, Microsoft.CodeAnalysis.CSharp.Symbol
                patternMemberCandidate)
                {
                    this_param.ReportEnumerableWarning(diagnostics, enumeratorType, patternMemberCandidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 86721, 86800);
                    return 0;
                }


                int
                f_10340_86883_86903(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 86883, 86903);
                    return 0;
                }


                int
                f_10340_87000_87439(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInType(result, type, name, arity: arity, basesBeingResolved: basesBeingResolved, options: options, originalBinder: (Microsoft.CodeAnalysis.CSharp.Binder)originalBinder, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 87000, 87439);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_87480_87498(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87480, 87498);
                    return return_v;
                }


                bool
                f_10340_87464_87519(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 87464, 87519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10340_87548_87566(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87548, 87566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10340_87640_87658(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87640, 87658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_87660_87678(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87660, 87678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_87660_87687(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87660, 87687);
                    return return_v;
                }


                int
                f_10340_87624_87688(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 87624, 87688);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10340_87860_87878(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87860, 87878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10340_87860_87887(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 87860, 87887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10340_87816_87913(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 87816, 87913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 86409, 87940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 86409, 87940);
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 87952, 88238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88076, 88174) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 88076, 88174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88140, 88159);

                    return f_10340_88147_88158(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 88076, 88174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88190, 88227);

                throw f_10340_88196_88226();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 87952, 88238);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10340_88147_88158(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 88147, 88158);
                    return return_v;
                }


                System.Exception
                f_10340_88196_88226()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 88196, 88226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 87952, 88238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 87952, 88238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 88250, 88444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88396, 88433);

                throw f_10340_88402_88432();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 88250, 88444);

                System.Exception
                f_10340_88402_88432()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 88402, 88432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 88250, 88444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 88250, 88444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 88525, 88591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88561, 88576);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 88525, 88591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 88456, 88602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 88456, 88602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private MethodArgumentInfo GetParameterlessSpecialTypeMemberInfo(SpecialMember member, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 88614, 89103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88771, 88856);

                var
                resolvedMember = (MethodSymbol)f_10340_88806_88855(this, member, diagnostics, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88870, 88932);

                f_10340_88870_88931(resolvedMember is null or { ParameterCount: 0 });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 88946, 89092);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10340, 88953, 88979) || ((resolvedMember is not null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10340, 89003, 89063)) || DynAbs.Tracing.TraceSender.Conditional_F3(10340, 89087, 89091))) ? f_10340_89003_89063(resolvedMember) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 88614, 89103);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10340_88806_88855(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetSpecialTypeMember(member, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 88806, 88855);
                    return return_v;
                }


                int
                f_10340_88870_88931(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 88870, 88931);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_89003_89063(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = MethodArgumentInfo.CreateParameterlessMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89003, 89063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 88614, 89103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 88614, 89103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodArgumentInfo BindDefaultArguments(MethodSymbol method, BoundExpression extensionReceiverOpt, bool expanded, SyntaxNode syntax, DiagnosticBag diagnostics, bool assertMissingParametersAreOptional = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10340, 89228, 90554);
                Microsoft.CodeAnalysis.BitVector defaultArguments = default(Microsoft.CodeAnalysis.BitVector);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89468, 89541);

                f_10340_89468_89540((extensionReceiverOpt != null) == f_10340_89515_89539(method));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89557, 89696) || true) && (f_10340_89561_89582(method) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 89557, 89696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89621, 89681);

                    return f_10340_89628_89680(method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 89557, 89696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89712, 89795);

                var
                argsBuilder = f_10340_89730_89794(f_10340_89772_89793(method))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89811, 89926) || true) && (f_10340_89815_89839(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10340, 89811, 89926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89873, 89911);

                    f_10340_89873_89910(argsBuilder, extensionReceiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10340, 89811, 89926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89942, 89985);

                ImmutableArray<int>
                argsToParams = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 89999, 90413);

                f_10340_89999_90412(this, syntax, f_10340_90063_90080(method), argsBuilder, argumentRefKindsBuilder: null, ref argsToParams, defaultArguments: out defaultArguments, expanded, enableCallerInfo: true, diagnostics, assertMissingParametersAreOptional);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 90429, 90543);

                return f_10340_90436_90542(method, f_10340_90467_90499(argsBuilder), argsToParams, defaultArguments, expanded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10340, 89228, 90554);

                bool
                f_10340_89515_89539(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 89515, 89539);
                    return return_v;
                }


                int
                f_10340_89468_89540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89468, 89540);
                    return 0;
                }


                int
                f_10340_89561_89582(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 89561, 89582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_89628_89680(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = MethodArgumentInfo.CreateParameterlessMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89628, 89680);
                    return return_v;
                }


                int
                f_10340_89772_89793(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 89772, 89793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_89730_89794(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89730, 89794);
                    return return_v;
                }


                bool
                f_10340_89815_89839(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 89815, 89839);
                    return return_v;
                }


                int
                f_10340_89873_89910(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89873, 89910);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10340_90063_90080(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 90063, 90080);
                    return return_v;
                }


                int
                f_10340_89999_90412(Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argumentsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>?
                argumentRefKindsBuilder, ref System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, out Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, bool
                enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                assertMissingParametersAreOptional)
                {
                    this_param.BindDefaultArguments(node, parameters, argumentsBuilder, argumentRefKindsBuilder: argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics, assertMissingParametersAreOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 89999, 90412);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10340_90467_90499(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 90467, 90499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10340_90436_90542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                Method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                Arguments, System.Collections.Immutable.ImmutableArray<int>
                ArgsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                DefaultArguments, bool
                Expanded)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo(Method, Arguments, ArgsToParamsOpt, DefaultArguments, Expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 90436, 90542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10340, 89228, 90554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 89228, 90554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ForEachLoopBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10340, 927, 90561);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1017, 1087);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1119, 1181);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1213, 1273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1307, 1387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10340, 1419, 1489);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10340, 927, 90561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10340, 927, 90561);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10340, 927, 90561);

        Microsoft.CodeAnalysis.SyntaxToken
        f_10340_1843_1863(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
        this_param)
        {
            var return_v = this_param.AwaitKeyword;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10340, 1843, 1863);
            return return_v;
        }


        int
        f_10340_2022_2050(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10340, 2022, 2050);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10340_1987_1996_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10340, 1887, 2093);
            return return_v;
        }

    }
}
