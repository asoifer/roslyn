// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.CSharp.Binder;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {        /// <summary>
             /// Emits address as in &amp; 
             /// 
             /// May introduce a temp which it will return. (otherwise returns null)
             /// </summary>
        private LocalDefinition EmitAddress(BoundExpression expression, AddressKind addressKind)
        {
            switch (expression.Kind)
            {
                case BoundKind.RefValueOperator:
                    EmitRefValueAddress((BoundRefValueOperator)expression);
                    break;

                case BoundKind.Local:
                    return EmitLocalAddress((BoundLocal)expression, addressKind);

                case BoundKind.Dup:
                    Debug.Assert(((BoundDup)expression).RefKind != RefKind.None, "taking address of a stack value?");
                    return EmitDupAddress((BoundDup)expression, addressKind);

                case BoundKind.ConditionalReceiver:
                    // do nothing receiver ref must be already pushed
                    Debug.Assert(!expression.Type.IsReferenceType);
                    Debug.Assert(!expression.Type.IsValueType || expression.Type.IsNullableType());
                    break;

                case BoundKind.ComplexConditionalReceiver:
                    EmitComplexConditionalReceiverAddress((BoundComplexConditionalReceiver)expression);
                    break;

                case BoundKind.Parameter:
                    return EmitParameterAddress((BoundParameter)expression, addressKind);

                case BoundKind.FieldAccess:
                    return EmitFieldAddress((BoundFieldAccess)expression, addressKind);

                case BoundKind.ArrayAccess:
                    if (!HasHome(expression, addressKind))
                    {
                        goto default;
                    }

                    EmitArrayElementAddress((BoundArrayAccess)expression, addressKind);
                    break;

                case BoundKind.ThisReference:
                    Debug.Assert(expression.Type.IsValueType || IsAnyReadOnly(addressKind), "'this' is readonly in classes");

                    if (expression.Type.IsValueType)
                    {

                        if (!HasHome(expression, addressKind))
                        {
                            // a readonly method is calling a non-readonly method, therefore we need to copy 'this'
                            goto default;
                        }

                        _builder.EmitLoadArgumentOpcode(0);
                    }
                    else
                    {
                        _builder.EmitLoadArgumentAddrOpcode(0);
                    }

                    break;

                case BoundKind.PreviousSubmissionReference:
                    // script references are lowered to a this reference and a field access
                    throw ExceptionUtilities.UnexpectedValue(expression.Kind);

                case BoundKind.BaseReference:
                    Debug.Assert(false, "base is always a reference type, why one may need a reference to it?");
                    break;

                case BoundKind.PassByCopy:
                    return EmitPassByCopyAddress((BoundPassByCopy)expression, addressKind);

                case BoundKind.Sequence:
                    return EmitSequenceAddress((BoundSequence)expression, addressKind);

                case BoundKind.PointerIndirectionOperator:
                    // The address of a dereferenced address is that address.
                    BoundExpression operand = ((BoundPointerIndirectionOperator)expression).Operand;
                    Debug.Assert(operand.Type.IsPointerType());
                    EmitExpression(operand, used: true);
                    break;

                case BoundKind.PseudoVariable:
                    EmitPseudoVariableAddress((BoundPseudoVariable)expression);
                    break;

                case BoundKind.Call:
                    var call = (BoundCall)expression;
                    var methodRefKind = call.Method.RefKind;

                    if (methodRefKind == RefKind.Ref ||
                        (IsAnyReadOnly(addressKind) && methodRefKind == RefKind.RefReadOnly))
                    {
                        EmitCallExpression(call, UseKind.UsedAsAddress);
                        break;
                    }

                    goto default;

                case BoundKind.FunctionPointerInvocation:
                    var funcPtrInvocation = (BoundFunctionPointerInvocation)expression;
                    var funcPtrRefKind = funcPtrInvocation.FunctionPointer.Signature.RefKind;
                    if (funcPtrRefKind == RefKind.Ref ||
                        (IsAnyReadOnly(addressKind) && funcPtrRefKind == RefKind.RefReadOnly))
                    {
                        EmitCalli(funcPtrInvocation, UseKind.UsedAsAddress);
                        break;
                    }

                    goto default;

                case BoundKind.DefaultExpression:
                    var type = expression.Type;

                    var temp = this.AllocateTemp(type, expression.Syntax);
                    _builder.EmitLocalAddress(temp);                  //  ldloca temp
                    _builder.EmitOpCode(ILOpCode.Dup);                //  dup
                    _builder.EmitOpCode(ILOpCode.Initobj);            //  initobj  <type>
                    EmitSymbolToken(type, expression.Syntax);
                    return temp;

                case BoundKind.ConditionalOperator:
                    if (!HasHome(expression, addressKind))
                    {
                        goto default;
                    }

                    EmitConditionalOperatorAddress((BoundConditionalOperator)expression, addressKind);
                    break;

                case BoundKind.AssignmentOperator:
                    var assignment = (BoundAssignmentOperator)expression;
                    if (!assignment.IsRef || !HasHome(assignment, addressKind))
                    {
                        goto default;
                    }
                    else
                    {
                        EmitAssignmentExpression(assignment, UseKind.UsedAsAddress);
                        break;
                    }

                case BoundKind.ThrowExpression:
                    // emit value or address is the same here.
                    EmitExpression(expression, used: true);
                    return null;

                default:
                    Debug.Assert(!HasHome(expression, addressKind));
                    return EmitAddressOfTempClone(expression);
            }

            return null;
        }

        private LocalDefinition EmitPassByCopyAddress(BoundPassByCopy passByCopyExpr, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 7526, 8224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 7882, 8151) || true) && (f_10961_7886_7911(passByCopyExpr) is BoundSequence sequence)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 7882, 8151);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 7971, 8136) || true) && (f_10961_7975_8017(this, sequence, f_10961_8002_8016(sequence)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 7971, 8136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8067, 8117);

                        return f_10961_8074_8116(this, sequence, addressKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 7971, 8136);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 7882, 8151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8167, 8213);

                return f_10961_8174_8212(this, passByCopyExpr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 7526, 8224);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_7886_7911(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 7886, 7911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_8002_8016(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 8002, 8016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10961_7975_8017(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                topSequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.DigForValueLocal(topSequence, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 7975, 8017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_8074_8116(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitSequenceAddress(sequence, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8074, 8116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_8174_8212(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                expression)
                {
                    var return_v = this_param.EmitAddressOfTempClone((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8174, 8212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 7526, 8224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 7526, 8224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitConditionalOperatorAddress(BoundConditionalOperator expr, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 8622, 9490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8746, 8839);

                f_10961_8746_8838(f_10961_8759_8777(expr) == null, "Constant value should have been emitted directly");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8855, 8894);

                object
                consequenceLabel = f_10961_8881_8893()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8908, 8940);

                object
                doneLabel = f_10961_8927_8939()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 8956, 9022);

                f_10961_8956_9021(this, f_10961_8971_8985(expr), ref consequenceLabel, sense: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9036, 9098);

                f_10961_9036_9097(this, f_10961_9054_9096(this, f_10961_9066_9082(expr), addressKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9114, 9158);

                f_10961_9114_9157(
                            _builder, ILOpCode.Br, doneLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9279, 9304);

                f_10961_9279_9303(
                            // If we get to consequenceLabel, we should not have Alternative on stack, adjust for that.
                            _builder, -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9320, 9357);

                f_10961_9320_9356(
                            _builder, consequenceLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9371, 9433);

                f_10961_9371_9432(this, f_10961_9389_9431(this, f_10961_9401_9417(expr), addressKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9449, 9479);

                f_10961_9449_9478(
                            _builder, doneLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 8622, 9490);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10961_8759_8777(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 8759, 8777);
                    return return_v;
                }


                int
                f_10961_8746_8838(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8746, 8838);
                    return 0;
                }


                object
                f_10961_8881_8893()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8881, 8893);
                    return return_v;
                }


                object
                f_10961_8927_8939()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8927, 8939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_8971_8985(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 8971, 8985);
                    return return_v;
                }


                int
                f_10961_8956_9021(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranch(condition, ref dest, sense: sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 8956, 9021);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_9066_9082(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9066, 9082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_9054_9096(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9054, 9096);
                    return return_v;
                }


                int
                f_10961_9036_9097(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9036, 9097);
                    return 0;
                }


                int
                f_10961_9114_9157(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9114, 9157);
                    return 0;
                }


                int
                f_10961_9279_9303(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9279, 9303);
                    return 0;
                }


                int
                f_10961_9320_9356(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9320, 9356);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_9401_9417(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9401, 9417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_9389_9431(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9389, 9431);
                    return return_v;
                }


                int
                f_10961_9371_9432(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9371, 9432);
                    return 0;
                }


                int
                f_10961_9449_9478(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9449, 9478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 8622, 9490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 8622, 9490);
            }
        }

        private void EmitComplexConditionalReceiverAddress(BoundComplexConditionalReceiver expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 9502, 10612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9621, 9668);

                f_10961_9621_9667(f_10961_9634_9666_M(!f_10961_9635_9650(expression).IsReferenceType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9682, 9725);

                f_10961_9682_9724(f_10961_9695_9723_M(!f_10961_9696_9711(expression).IsValueType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9741, 9776);

                var
                receiverType = f_10961_9760_9775(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9792, 9830);

                var
                whenValueTypeLabel = f_10961_9817_9829()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9844, 9873);

                var
                doneLabel = f_10961_9860_9872()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9889, 9940);

                f_10961_9889_9939(this, receiverType, true, expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 9954, 9995);

                f_10961_9954_9994(this, receiverType, expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10009, 10066);

                f_10961_10009_10065(_builder, ILOpCode.Brtrue, whenValueTypeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10082, 10169);

                var
                receiverTemp = f_10961_10101_10168(this, f_10961_10113_10145(expression), AddressKind.ReadOnly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10183, 10218);

                f_10961_10183_10217(receiverTemp == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10232, 10276);

                f_10961_10232_10275(_builder, ILOpCode.Br, doneLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10290, 10315);

                f_10961_10290_10314(_builder, -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10331, 10370);

                f_10961_10331_10369(
                            _builder, whenValueTypeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10484, 10555);

                f_10961_10484_10554(this, f_10961_10500_10528(expression), AddressKind.Constrained);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10571, 10601);

                f_10961_10571_10600(
                            _builder, doneLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 9502, 10612);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_9635_9650(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9635, 9650);
                    return return_v;
                }


                bool
                f_10961_9634_9666_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9634, 9666);
                    return return_v;
                }


                int
                f_10961_9621_9667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9621, 9667);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_9696_9711(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9696, 9711);
                    return return_v;
                }


                bool
                f_10961_9695_9723_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9695, 9723);
                    return return_v;
                }


                int
                f_10961_9682_9724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9682, 9724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_9760_9775(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 9760, 9775);
                    return return_v;
                }


                object
                f_10961_9817_9829()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9817, 9829);
                    return return_v;
                }


                object
                f_10961_9860_9872()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9860, 9872);
                    return return_v;
                }


                int
                f_10961_9889_9939(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitInitObj(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9889, 9939);
                    return 0;
                }


                int
                f_10961_9954_9994(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 9954, 9994);
                    return 0;
                }


                int
                f_10961_10009_10065(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10009, 10065);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_10113_10145(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ReferenceTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 10113, 10145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_10101_10168(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10101, 10168);
                    return return_v;
                }


                int
                f_10961_10183_10217(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10183, 10217);
                    return 0;
                }


                int
                f_10961_10232_10275(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10232, 10275);
                    return 0;
                }


                int
                f_10961_10290_10314(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10290, 10314);
                    return 0;
                }


                int
                f_10961_10331_10369(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10331, 10369);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_10500_10528(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ValueTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 10500, 10528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_10484_10554(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10484, 10554);
                    return return_v;
                }


                int
                f_10961_10571_10600(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10571, 10600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 9502, 10612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 9502, 10612);
            }
        }

        private LocalDefinition EmitLocalAddress(BoundLocal localAccess, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 10752, 11683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10866, 10902);

                var
                local = f_10961_10878_10901(localAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10918, 11048) || true) && (!f_10961_10923_10956(this, localAccess, addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 10918, 11048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 10990, 11033);

                    return f_10961_10997_11032(this, localAccess);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 10918, 11048);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11064, 11644) || true) && (f_10961_11068_11087(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 11064, 11644);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11121, 11514) || true) && (f_10961_11125_11138(local) != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 11121, 11514);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 11121, 11514);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 11121, 11514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11439, 11495);

                        throw f_10961_11445_11494(f_10961_11480_11493(local));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 11121, 11514);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 11064, 11644);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 11064, 11644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11580, 11629);

                    f_10961_11580_11628(_builder, f_10961_11606_11627(this, localAccess));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 11064, 11644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11660, 11672);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 10752, 11683);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10961_10878_10901(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 10878, 10901);
                    return return_v;
                }


                bool
                f_10961_10923_10956(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10923, 10956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_10997_11032(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.EmitAddressOfTempClone((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 10997, 11032);
                    return return_v;
                }


                bool
                f_10961_11068_11087(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11068, 11087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10961_11125_11138(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 11125, 11138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10961_11480_11493(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 11480, 11493);
                    return return_v;
                }


                System.Exception
                f_10961_11445_11494(Microsoft.CodeAnalysis.RefKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11445, 11494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_11606_11627(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                localExpression)
                {
                    var return_v = this_param.GetLocal(localExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11606, 11627);
                    return return_v;
                }


                int
                f_10961_11580_11628(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalAddress(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11580, 11628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 10752, 11683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 10752, 11683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition EmitDupAddress(BoundDup dup, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 11823, 12126);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11925, 12039) || true) && (!f_10961_11930_11955(this, dup, addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 11925, 12039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 11989, 12024);

                    return f_10961_11996_12023(this, dup);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 11925, 12039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12055, 12089);

                f_10961_12055_12088(
                            _builder, ILOpCode.Dup);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12103, 12115);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 11823, 12126);

                bool
                f_10961_11930_11955(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDup
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11930, 11955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_11996_12023(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDup
                expression)
                {
                    var return_v = this_param.EmitAddressOfTempClone((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 11996, 12023);
                    return return_v;
                }


                int
                f_10961_12055_12088(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12055, 12088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 11823, 12126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 11823, 12126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitPseudoVariableAddress(BoundPseudoVariable expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 12138, 12322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12233, 12311);

                f_10961_12233_12310(this, f_10961_12248_12297(f_10961_12248_12274(expression), expression), used: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 12138, 12322);

                Microsoft.CodeAnalysis.CSharp.PseudoVariableExpressions
                f_10961_12248_12274(Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable
                this_param)
                {
                    var return_v = this_param.EmitExpressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 12248, 12274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_12248_12297(Microsoft.CodeAnalysis.CSharp.PseudoVariableExpressions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable
                variable)
                {
                    var return_v = this_param.GetAddress(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12248, 12297);
                    return return_v;
                }


                int
                f_10961_12233_12310(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12233, 12310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 12138, 12322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 12138, 12322);
            }
        }

        private void EmitRefValueAddress(BoundRefValueOperator refValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 12334, 12709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12543, 12582);

                f_10961_12543_12581(this, f_10961_12558_12574(refValue), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12596, 12636);

                f_10961_12596_12635(_builder, ILOpCode.Refanyval);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 12650, 12698);

                f_10961_12650_12697(this, f_10961_12666_12679(refValue), refValue.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 12334, 12709);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_12558_12574(Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 12558, 12574);
                    return return_v;
                }


                int
                f_10961_12543_12581(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12543, 12581);
                    return 0;
                }


                int
                f_10961_12596_12635(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12596, 12635);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_12666_12679(Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 12666, 12679);
                    return return_v;
                }


                int
                f_10961_12650_12697(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 12650, 12697);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 12334, 12709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 12334, 12709);
            }
        }

        private LocalDefinition EmitAddressOfTempClone(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 13011, 13355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13110, 13143);

                f_10961_13110_13142(this, expression, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13157, 13223);

                var
                value = f_10961_13169_13222(this, f_10961_13187_13202(expression), expression.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13237, 13268);

                f_10961_13237_13267(_builder, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13282, 13315);

                f_10961_13282_13314(_builder, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13331, 13344);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 13011, 13355);

                int
                f_10961_13110_13142(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13110, 13142);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_13187_13202(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 13187, 13202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_13169_13222(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13169, 13222);
                    return return_v;
                }


                int
                f_10961_13237_13267(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13237, 13267);
                    return 0;
                }


                int
                f_10961_13282_13314(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalAddress(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13282, 13314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 13011, 13355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 13011, 13355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition EmitSequenceAddress(BoundSequence sequence, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 13495, 13841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13612, 13644);

                f_10961_13612_13643(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13658, 13684);

                f_10961_13658_13683(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13698, 13752);

                var
                result = f_10961_13711_13751(this, f_10961_13723_13737(sequence), addressKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13766, 13800);

                f_10961_13766_13799(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13816, 13830);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 13495, 13841);

                int
                f_10961_13612_13643(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.DefineAndRecordLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13612, 13643);
                    return 0;
                }


                int
                f_10961_13658_13683(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.EmitSideEffects(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13658, 13683);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_13723_13737(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 13723, 13737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_13711_13751(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13711, 13751);
                    return return_v;
                }


                int
                f_10961_13766_13799(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.CloseScopeAndKeepLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 13766, 13799);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 13495, 13841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 13495, 13841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalSymbol DigForValueLocal(BoundSequence topSequence, BoundExpression value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 13853, 15007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 13964, 14968);

                switch (f_10961_13972_13982(value))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 13964, 14968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14059, 14089);

                        var
                        local = (BoundLocal)value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14111, 14142);

                        var
                        symbol = f_10961_14124_14141(local)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14164, 14290) || true) && (topSequence.Locals.Contains(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 14164, 14290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14253, 14267);

                            return symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 14164, 14290);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10961, 14312, 14318);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 13964, 14968);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 13964, 14968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14384, 14451);

                        return f_10961_14391_14450(this, topSequence, f_10961_14421_14449(((BoundSequence)value)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 13964, 14968);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 13964, 14968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14520, 14562);

                        var
                        fieldAccess = (BoundFieldAccess)value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14584, 14925) || true) && (f_10961_14588_14621_M(!f_10961_14589_14612(fieldAccess).IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 14584, 14925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14671, 14710);

                            var
                            receiver = f_10961_14686_14709(fieldAccess)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14736, 14902) || true) && (f_10961_14740_14770_M(!f_10961_14741_14754(receiver).IsReferenceType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 14736, 14902);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14828, 14875);

                                return f_10961_14835_14874(this, topSequence, receiver);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 14736, 14902);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 14584, 14925);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10961, 14947, 14953);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 13964, 14968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 14984, 14996);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 13853, 15007);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10961_13972_13982(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 13972, 13982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10961_14124_14141(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14124, 14141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_14421_14449(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14421, 14449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10961_14391_14450(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                topSequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.DigForValueLocal(topSequence, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 14391, 14450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10961_14589_14612(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14589, 14612);
                    return return_v;
                }


                bool
                f_10961_14588_14621_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14588, 14621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10961_14686_14709(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14686, 14709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_14741_14754(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14741, 14754);
                    return return_v;
                }


                bool
                f_10961_14740_14770_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 14740, 14770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10961_14835_14874(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                topSequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.DigForValueLocal(topSequence, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 14835, 14874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 13853, 15007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 13853, 15007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitArrayIndices(ImmutableArray<BoundExpression> indices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 15019, 15367);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15123, 15128);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15114, 15356) || true) && (i < indices.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15150, 15153)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 15114, 15356))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 15114, 15356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15187, 15222);

                        BoundExpression
                        index = indices[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15240, 15274);

                        f_10961_15240_15273(this, index, used: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15292, 15341);

                        f_10961_15292_15340(this, f_10961_15311_15339(f_10961_15311_15321(index)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10961, 1, 243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10961, 1, 243);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 15019, 15367);

                int
                f_10961_15240_15273(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15240, 15273);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_15311_15321(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15311, 15321);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10961_15311_15339(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15311, 15339);
                    return return_v;
                }


                int
                f_10961_15292_15340(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.Cci.PrimitiveTypeCode
                tc)
                {
                    this_param.TreatLongsAsNative(tc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15292, 15340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 15019, 15367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 15019, 15367);
            }
        }

        private void EmitArrayElementAddress(BoundArrayAccess arrayAccess, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 15379, 16297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15495, 15546);

                f_10961_15495_15545(this, f_10961_15510_15532(arrayAccess), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15560, 15598);

                f_10961_15560_15597(this, f_10961_15577_15596(arrayAccess));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15614, 15756) || true) && (f_10961_15618_15668(this, arrayAccess, addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 15614, 15756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15702, 15741);

                    f_10961_15702_15740(_builder, ILOpCode.Readonly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 15614, 15756);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15772, 16286) || true) && (f_10961_15776_15832(((ArrayTypeSymbol)f_10961_15794_15821(f_10961_15794_15816(arrayAccess)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 15772, 16286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15866, 15904);

                    f_10961_15866_15903(_builder, ILOpCode.Ldelema);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15922, 15957);

                    var
                    elementType = f_10961_15940_15956(arrayAccess)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 15975, 16024);

                    f_10961_15975_16023(this, elementType, arrayAccess.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 15772, 16286);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 15772, 16286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16090, 16271);

                    f_10961_16090_16270(_builder, f_10961_16123_16186(_module, f_10961_16158_16185(f_10961_16158_16180(arrayAccess))), arrayAccess.Syntax, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 15772, 16286);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 15379, 16297);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_15510_15532(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15510, 15532);
                    return return_v;
                }


                int
                f_10961_15495_15545(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15495, 15545);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10961_15577_15596(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15577, 15596);
                    return return_v;
                }


                int
                f_10961_15560_15597(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    this_param.EmitArrayIndices(indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15560, 15597);
                    return 0;
                }


                bool
                f_10961_15618_15668(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                arrayAccess, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.ShouldEmitReadOnlyPrefix(arrayAccess, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15618, 15668);
                    return return_v;
                }


                int
                f_10961_15702_15740(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15702, 15740);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_15794_15816(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15794, 15816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_15794_15821(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15794, 15821);
                    return return_v;
                }


                bool
                f_10961_15776_15832(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15776, 15832);
                    return return_v;
                }


                int
                f_10961_15866_15903(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15866, 15903);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_15940_15956(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 15940, 15956);
                    return return_v;
                }


                int
                f_10961_15975_16023(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 15975, 16023);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10961_16158_16180(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16158, 16180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_16158_16185(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16158, 16185);
                    return return_v;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10961_16123_16186(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 16123, 16186);
                    return return_v;
                }


                int
                f_10961_16090_16270(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayElementAddress(arrayType, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 16090, 16270);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 15379, 16297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 15379, 16297);
            }
        }

        private bool ShouldEmitReadOnlyPrefix(BoundArrayAccess arrayAccess, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 16309, 16895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16426, 16679) || true) && (addressKind == AddressKind.Constrained)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 16426, 16679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16502, 16634);

                    f_10961_16502_16633(f_10961_16515_16540(f_10961_16515_16531(arrayAccess)) == TypeKind.TypeParameter, "constrained call should only be used with type parameter types");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16652, 16664);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 16426, 16679);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16695, 16788) || true) && (!f_10961_16700_16726(addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 16695, 16788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16760, 16773);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 16695, 16788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 16847, 16884);

                return f_10961_16854_16883_M(!f_10961_16855_16871(arrayAccess).IsValueType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 16309, 16895);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_16515_16531(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16515, 16531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10961_16515_16540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16515, 16540);
                    return return_v;
                }


                int
                f_10961_16502_16633(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 16502, 16633);
                    return 0;
                }


                bool
                f_10961_16700_16726(Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = IsAnyReadOnly(addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 16700, 16726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10961_16855_16871(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16855, 16871);
                    return return_v;
                }


                bool
                f_10961_16854_16883_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 16854, 16883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 16309, 16895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 16309, 16895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition EmitFieldAddress(BoundFieldAccess fieldAccess, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 17035, 17743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17155, 17199);

                FieldSymbol
                field = f_10961_17175_17198(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17215, 17732) || true) && (!f_10961_17220_17253(this, fieldAccess, addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 17215, 17732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17366, 17409);

                    return f_10961_17373_17408(this, fieldAccess);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 17215, 17732);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 17215, 17732);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17443, 17732) || true) && (f_10961_17447_17479(f_10961_17447_17470(fieldAccess)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 17443, 17732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17513, 17563);

                        f_10961_17513_17562(this, field, fieldAccess.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17581, 17593);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 17443, 17732);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 17443, 17732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17659, 17717);

                        return f_10961_17666_17716(this, fieldAccess, addressKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 17443, 17732);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 17215, 17732);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 17035, 17743);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10961_17175_17198(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 17175, 17198);
                    return return_v;
                }


                bool
                f_10961_17220_17253(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17220, 17253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_17373_17408(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expression)
                {
                    var return_v = this_param.EmitAddressOfTempClone((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17373, 17408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10961_17447_17470(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 17447, 17470);
                    return return_v;
                }


                bool
                f_10961_17447_17479(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 17447, 17479);
                    return return_v;
                }


                int
                f_10961_17513_17562(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitStaticFieldAddress(field, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17513, 17562);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_17666_17716(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitInstanceFieldAddress(fieldAccess, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17666, 17716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 17035, 17743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 17035, 17743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitStaticFieldAddress(FieldSymbol field, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 17755, 17955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17857, 17895);

                f_10961_17857_17894(_builder, ILOpCode.Ldsflda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 17909, 17944);

                f_10961_17909_17943(this, field, syntaxNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 17755, 17955);

                int
                f_10961_17857_17894(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17857, 17894);
                    return 0;
                }


                int
                f_10961_17909_17943(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 17909, 17943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 17755, 17955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 17755, 17955);
            }
        }

        private bool HasHome(BoundExpression expression, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 18291, 18383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18294, 18383);
                return f_10961_18294_18383(expression, addressKind, _method, f_10961_18343_18368(this), _stackLocals); DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 18291, 18383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 18291, 18383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 18291, 18383);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10961_18343_18368(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
            this_param)
            {
                var return_v = this_param.IsPeVerifyCompatEnabled();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18343, 18368);
                return return_v;
            }


            bool
            f_10961_18294_18383(Microsoft.CodeAnalysis.CSharp.BoundExpression
            expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
            addressKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, bool
            peVerifyCompatEnabled, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
            stackLocalsOpt)
            {
                var return_v = Binder.HasHome(expression, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18294, 18383);
                return return_v;
            }

        }

        private LocalDefinition EmitParameterAddress(BoundParameter parameter, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 18396, 19124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18516, 18576);

                ParameterSymbol
                parameterSymbol = f_10961_18550_18575(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18592, 18781) || true) && (!f_10961_18597_18628(this, parameter, addressKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 18592, 18781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18725, 18766);

                    return f_10961_18732_18765(this, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 18592, 18781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18797, 18833);

                int
                slot = f_10961_18808_18832(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18847, 19085) || true) && (f_10961_18851_18874(parameterSymbol) == RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 18847, 19085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 18924, 18966);

                    f_10961_18924_18965(_builder, slot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 18847, 19085);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 18847, 19085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 19032, 19070);

                    f_10961_19032_19069(_builder, slot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 18847, 19085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 19101, 19113);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 18396, 19124);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10961_18550_18575(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 18550, 18575);
                    return return_v;
                }


                bool
                f_10961_18597_18628(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18597, 18628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_18732_18765(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                expression)
                {
                    var return_v = this_param.EmitAddressOfTempClone((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18732, 18765);
                    return return_v;
                }


                int
                f_10961_18808_18832(Microsoft.CodeAnalysis.CSharp.BoundParameter
                parameter)
                {
                    var return_v = ParameterSlot(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18808, 18832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10961_18851_18874(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 18851, 18874);
                    return return_v;
                }


                int
                f_10961_18924_18965(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                argNumber)
                {
                    this_param.EmitLoadArgumentAddrOpcode(argNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 18924, 18965);
                    return 0;
                }


                int
                f_10961_19032_19069(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                argNumber)
                {
                    this_param.EmitLoadArgumentOpcode(argNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 19032, 19069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 18396, 19124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 18396, 19124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition EmitReceiverRef(BoundExpression receiver, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 19731, 21486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 19846, 19879);

                var
                receiverType = f_10961_19865_19878(receiver)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 19893, 20047) || true) && (f_10961_19897_19931(receiverType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 19893, 20047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 19965, 20002);

                    f_10961_19965_20001(this, receiver, used: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 20020, 20032);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 19893, 20047);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 20063, 21358) || true) && (f_10961_20067_20088(receiverType) == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 20063, 21358);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 20774, 21343) || true) && (addressKind == AddressKind.Constrained)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 20774, 21343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 20858, 20900);

                        return f_10961_20865_20899(this, receiver, addressKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 20774, 21343);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 20774, 21343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 20982, 21019);

                        f_10961_20982_21018(this, receiver, used: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21127, 21290) || true) && (f_10961_21131_21144(receiver) != BoundKind.ConditionalReceiver)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 21127, 21290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21227, 21267);

                            f_10961_21227_21266(this, f_10961_21235_21248(receiver), receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 21127, 21290);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21312, 21324);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 20774, 21343);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 20063, 21358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21374, 21419);

                f_10961_21374_21418(f_10961_21387_21417(receiverType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21433, 21475);

                return f_10961_21440_21474(this, receiver, addressKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 19731, 21486);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_19865_19878(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 19865, 19878);
                    return return_v;
                }


                bool
                f_10961_19897_19931(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 19897, 19931);
                    return return_v;
                }


                int
                f_10961_19965_20001(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 19965, 20001);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10961_20067_20088(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 20067, 20088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_20865_20899(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 20865, 20899);
                    return return_v;
                }


                int
                f_10961_20982_21018(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 20982, 21018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10961_21131_21144(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 21131, 21144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10961_21235_21248(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 21235, 21248);
                    return return_v;
                }


                int
                f_10961_21227_21266(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 21227, 21266);
                    return 0;
                }


                bool
                f_10961_21387_21417(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 21387, 21417);
                    return return_v;
                }


                int
                f_10961_21374_21418(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 21374, 21418);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_21440_21474(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 21440, 21474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 19731, 21486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 19731, 21486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition EmitInstanceFieldAddress(BoundFieldAccess fieldAccess, AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10961, 21626, 23837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 21754, 21790);

                var
                field = f_10961_21766_21789(fieldAccess)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22065, 22198);

                var
                tempOpt = f_10961_22079_22197(this, f_10961_22095_22118(fieldAccess), (DynAbs.Tracing.TraceSender.Conditional_F1(10961, 22120, 22158) || ((addressKind == AddressKind.Constrained && DynAbs.Tracing.TraceSender.Conditional_F2(10961, 22161, 22182)) || DynAbs.Tracing.TraceSender.Conditional_F3(10961, 22185, 22196))) ? AddressKind.Writeable : addressKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22214, 22251);

                f_10961_22214_22250(
                            _builder, ILOpCode.Ldflda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22265, 22308);

                f_10961_22265_22307(this, field, fieldAccess.Syntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22782, 23795) || true) && (f_10961_22786_22809(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 22782, 23795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22843, 22898);

                    var
                    fixedImpl = f_10961_22859_22897(field, _module)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 22916, 22968);

                    var
                    fixedElementField = f_10961_22940_22967(fixedImpl)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 23568, 23780) || true) && ((object)fixedElementField != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10961, 23568, 23780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 23647, 23684);

                        f_10961_23647_23683(_builder, ILOpCode.Ldflda);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 23706, 23761);

                        f_10961_23706_23760(this, fixedElementField, fieldAccess.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 23568, 23780);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10961, 22782, 23795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10961, 23811, 23826);

                return tempOpt;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10961, 21626, 23837);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10961_21766_21789(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 21766, 21789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10961_22095_22118(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 22095, 22118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10961_22079_22197(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 22079, 22197);
                    return return_v;
                }


                int
                f_10961_22214_22250(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 22214, 22250);
                    return 0;
                }


                int
                f_10961_22265_22307(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 22265, 22307);
                    return 0;
                }


                bool
                f_10961_22786_22809(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 22786, 22809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10961_22859_22897(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                emitModule)
                {
                    var return_v = this_param.FixedImplementationType(emitModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 22859, 22897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10961_22940_22967(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.FixedElementField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10961, 22940, 22967);
                    return return_v;
                }


                int
                f_10961_23647_23683(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 23647, 23683);
                    return 0;
                }


                int
                f_10961_23706_23760(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10961, 23706, 23760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10961, 21626, 23837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10961, 21626, 23837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
