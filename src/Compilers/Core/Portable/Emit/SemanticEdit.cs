// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.Emit
{

    public struct SemanticEdit : IEquatable<SemanticEdit>
    {

        public SemanticEditKind Kind { get; }

        public ISymbol? OldSymbol { get; }

        public ISymbol? NewSymbol { get; }

        public Func<SyntaxNode, SyntaxNode?>? SyntaxMap { get; }

        public bool PreserveLocalVariables { get; }

        public SemanticEdit(SemanticEditKind kind, ISymbol? oldSymbol, ISymbol? newSymbol, Func<SyntaxNode, SyntaxNode?>? syntaxMap = null, bool preserveLocalVariables = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(296, 3464, 4403);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 3657, 3813) || true) && (oldSymbol == null && (DynAbs.Tracing.TraceSender.Expression_True(296, 3661, 3713) && kind != SemanticEditKind.Insert))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(296, 3657, 3813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 3747, 3798);

                    throw f_296_3753_3797(nameof(oldSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(296, 3657, 3813);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 3829, 3985) || true) && (newSymbol == null && (DynAbs.Tracing.TraceSender.Expression_True(296, 3833, 3885) && kind != SemanticEditKind.Delete))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(296, 3829, 3985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 3919, 3970);

                    throw f_296_3925_3969(nameof(newSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(296, 3829, 3985);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4001, 4169) || true) && (kind <= SemanticEditKind.None || (DynAbs.Tracing.TraceSender.Expression_False(296, 4005, 4068) || kind > SemanticEditKind.Delete))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(296, 4001, 4169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4102, 4154);

                    throw f_296_4108_4153(nameof(kind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(296, 4001, 4169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4185, 4202);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4216, 4243);

                this.OldSymbol = oldSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4257, 4284);

                this.NewSymbol = newSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4298, 4351);

                this.PreserveLocalVariables = preserveLocalVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4365, 4392);

                this.SyntaxMap = syntaxMap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(296, 3464, 4403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(296, 3464, 4403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 3464, 4403);
            }
        }

        internal static SemanticEdit Create(SemanticEditKind kind, ISymbolInternal oldSymbol, ISymbolInternal newSymbol, Func<SyntaxNode, SyntaxNode>? syntaxMap = null, bool preserveLocalVariables = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(296, 4415, 4763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4637, 4752);

                return f_296_4644_4751(kind, f_296_4667_4690_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(oldSymbol, 296, 4667, 4690)?.GetISymbol()), f_296_4692_4715_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(newSymbol, 296, 4692, 4715)?.GetISymbol()), syntaxMap, preserveLocalVariables);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(296, 4415, 4763);

                Microsoft.CodeAnalysis.ISymbol?
                f_296_4667_4690_I(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4667, 4690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_296_4692_4715_I(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4692, 4715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.SemanticEdit
                f_296_4644_4751(Microsoft.CodeAnalysis.Emit.SemanticEditKind
                kind, Microsoft.CodeAnalysis.ISymbol?
                oldSymbol, Microsoft.CodeAnalysis.ISymbol?
                newSymbol, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>?
                syntaxMap, bool
                preserveLocalVariables)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.SemanticEdit(kind, oldSymbol, newSymbol, syntaxMap, preserveLocalVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4644, 4751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(296, 4415, 4763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 4415, 4763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(296, 4775, 4951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 4833, 4940);

                return f_296_4840_4939(OldSymbol, f_296_4884_4938(NewSymbol, Kind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(296, 4775, 4951);

                int
                f_296_4884_4938(Microsoft.CodeAnalysis.ISymbol?
                newKeyPart, Microsoft.CodeAnalysis.Emit.SemanticEditKind
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4884, 4938);
                    return return_v;
                }


                int
                f_296_4840_4939(Microsoft.CodeAnalysis.ISymbol?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4840, 4939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(296, 4775, 4951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 4775, 4951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(296, 4963, 5095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 5028, 5084);

                return obj is SemanticEdit && (DynAbs.Tracing.TraceSender.Expression_True(296, 5035, 5083) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(296, 4963, 5095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(296, 4963, 5095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 4963, 5095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SemanticEdit other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(296, 5107, 5436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(296, 5170, 5425);

                return this.Kind == other.Kind
                && (DynAbs.Tracing.TraceSender.Expression_True(296, 5177, 5312) && ((DynAbs.Tracing.TraceSender.Conditional_F1(296, 5222, 5244) || ((this.OldSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(296, 5247, 5270)) || DynAbs.Tracing.TraceSender.Conditional_F3(296, 5273, 5311))) ? other.OldSymbol == null : f_296_5273_5311(this.OldSymbol, other.OldSymbol))
                ) && (DynAbs.Tracing.TraceSender.Expression_True(296, 5177, 5424) && ((DynAbs.Tracing.TraceSender.Conditional_F1(296, 5334, 5356) || ((this.NewSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(296, 5359, 5382)) || DynAbs.Tracing.TraceSender.Conditional_F3(296, 5385, 5423))) ? other.NewSymbol == null : f_296_5385_5423(this.NewSymbol, other.NewSymbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(296, 5107, 5436);

                bool
                f_296_5273_5311(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.ISymbol?
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 5273, 5311);
                    return return_v;
                }


                bool
                f_296_5385_5423(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.ISymbol?
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 5385, 5423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(296, 5107, 5436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 5107, 5436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SemanticEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(296, 528, 5443);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(296, 528, 5443);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(296, 528, 5443);
        }

        static System.ArgumentNullException
        f_296_3753_3797(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 3753, 3797);
            return return_v;
        }


        static System.ArgumentNullException
        f_296_3925_3969(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 3925, 3969);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_296_4108_4153(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(296, 4108, 4153);
            return return_v;
        }

    }
}
