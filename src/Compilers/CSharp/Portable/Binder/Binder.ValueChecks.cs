// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal const uint
        ExternalScope = 0
        ;

        internal const uint
        TopLevelScope = 1
        ;

        private const int
        ValueKindInsignificantBits = 2
        ;

        private const BindValueKind
        ValueKindSignificantBitsMask = unchecked((BindValueKind)~((1 << ValueKindInsignificantBits) - 1))
        ;

        /// <summary>
        /// Expression capabilities and requirements.
        /// </summary>
        [Flags]
        internal enum BindValueKind : ushort
        {
            ///////////////////
            // All expressions can be classified according to the following 4 capabilities:
            //

            /// <summary>
            /// Expression can be an RHS of an assignment operation.
            /// </summary>
            /// <remarks>
            /// The following are rvalues: values, variables, null literals, properties
            /// and indexers with getters, events. 
            /// 
            /// The following are not rvalues:
            /// namespaces, types, method groups, anonymous functions.
            /// </remarks>
            RValue = 1 << ValueKindInsignificantBits,

            /// <summary>
            /// Expression can be the LHS of a simple assignment operation.
            /// Example: 
            ///   property with a setter
            /// </summary>
            Assignable = 2 << ValueKindInsignificantBits,

            /// <summary>
            /// Expression represents a location. Often referred as a "variable"
            /// Examples:
            ///  local variable, parameter, field
            /// </summary>
            RefersToLocation = 4 << ValueKindInsignificantBits,

            /// <summary>
            /// Expression can be the LHS of a ref-assign operation.
            /// Example:
            ///  ref local, ref parameter, out parameter
            /// </summary>
            RefAssignable = 8 << ValueKindInsignificantBits,

            ///////////////////
            // The rest are just combinations of the above.
            //

            /// <summary>
            /// Expression is the RHS of an assignment operation
            /// and may be a method group.
            /// Basically an RValue, but could be treated differently for the purpose of error reporting
            /// </summary>
            RValueOrMethodGroup = RValue + 1,

            /// <summary>
            /// Expression can be an LHS of a compound assignment
            /// operation (such as +=).
            /// </summary>
            CompoundAssignment = RValue | Assignable,

            /// <summary>
            /// Expression can be the operand of an increment or decrement operation.
            /// Same as CompoundAssignment, the distinction is really just for error reporting.
            /// </summary>
            IncrementDecrement = CompoundAssignment + 1,

            /// <summary>
            /// Expression is a r/o reference.
            /// </summary>
            ReadonlyRef = RefersToLocation | RValue,

            /// <summary>
            /// Expression can be the operand of an address-of operation (&amp;).
            /// Same as ReadonlyRef. The difference is just for error reporting.
            /// </summary>
            AddressOf = ReadonlyRef + 1,

            /// <summary>
            /// Expression is the receiver of a fixed buffer field access
            /// Same as ReadonlyRef. The difference is just for error reporting.
            /// </summary>
            FixedReceiver = ReadonlyRef + 2,

            /// <summary>
            /// Expression is passed as a ref or out parameter or assigned to a byref variable.
            /// </summary>
            RefOrOut = RefersToLocation | RValue | Assignable,

            /// <summary>
            /// Expression is returned by an ordinary r/w reference.
            /// Same as RefOrOut. The difference is just for error reporting.
            /// </summary>
            RefReturn = RefOrOut + 1,
        }

        private static bool RequiresRValueOnly(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 5904, 6067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 5987, 6056);

                return (kind & ValueKindSignificantBitsMask) == BindValueKind.RValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 5904, 6067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 5904, 6067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 5904, 6067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresAssignmentOnly(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6079, 6250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6166, 6239);

                return (kind & ValueKindSignificantBitsMask) == BindValueKind.Assignable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6079, 6250);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6079, 6250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6079, 6250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresVariable(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6262, 6387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6343, 6376);

                return !f_10292_6351_6375(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6262, 6387);

                bool
                f_10292_6351_6375(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRValueOnly(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 6351, 6375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6262, 6387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6262, 6387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresReferenceToLocation(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6399, 6554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6491, 6543);

                return (kind & BindValueKind.RefersToLocation) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6399, 6554);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6399, 6554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6399, 6554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresAssignableVariable(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6566, 6714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6657, 6703);

                return (kind & BindValueKind.Assignable) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6566, 6714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6566, 6714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6566, 6714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresRefAssignableVariable(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6726, 6880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6820, 6869);

                return (kind & BindValueKind.RefAssignable) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6726, 6880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6726, 6880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6726, 6880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresRefOrOut(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 6892, 7049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 6973, 7038);

                return (kind & BindValueKind.RefOrOut) == BindValueKind.RefOrOut;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 6892, 7049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 6892, 7049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 6892, 7049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundIndexerAccess BindIndexerDefaultArguments(BoundIndexerAccess indexerAccess, BindValueKind valueKind, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 7081, 10156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7246, 7344);

                var
                useSetAccessor = valueKind == BindValueKind.Assignable && (DynAbs.Tracing.TraceSender.Expression_True(10292, 7267, 7343) && f_10292_7308_7343_M(!f_10292_7309_7330(indexerAccess).ReturnsByRef))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7358, 7547);

                var
                accessorForDefaultArguments = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 7392, 7406) || ((useSetAccessor
                && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 7426, 7476)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 7496, 7546))) ? f_10292_7426_7476(f_10292_7426_7447(indexerAccess)) : f_10292_7496_7546(f_10292_7496_7517(indexerAccess))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7561, 10108) || true) && (accessorForDefaultArguments is not null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 7561, 10108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7638, 7747);

                    var
                    argumentsBuilder = f_10292_7661_7746(f_10292_7703_7745(accessorForDefaultArguments))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7765, 7816);

                    f_10292_7765_7815(argumentsBuilder, f_10292_7791_7814(indexerAccess));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7836, 7878);

                    ArrayBuilder<RefKind>?
                    refKindsBuilderOpt
                    = default(ArrayBuilder<RefKind>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7896, 8304) || true) && (f_10292_7900_7951_M(!indexerAccess.ArgumentRefKindsOpt.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 7896, 8304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 7993, 8092);

                        refKindsBuilderOpt = f_10292_8014_8091(f_10292_8048_8090(accessorForDefaultArguments));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8114, 8177);

                        f_10292_8114_8176(refKindsBuilderOpt, f_10292_8142_8175(indexerAccess));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 7896, 8304);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 7896, 8304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8259, 8285);

                        refKindsBuilderOpt = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 7896, 8304);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8322, 8371);

                    var
                    argsToParams = f_10292_8341_8370(indexerAccess)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8629, 8685);

                    var
                    parameters = f_10292_8646_8684(accessorForDefaultArguments)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8703, 8838) || true) && (useSetAccessor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 8703, 8838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8763, 8819);

                        parameters = parameters.RemoveAt(parameters.Length - 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 8703, 8838);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8858, 8895);

                    BitVector
                    defaultArguments = default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 8913, 8988);

                    f_10292_8913_8987(parameters.Length == f_10292_8947_8968(indexerAccess).Parameters.Length);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 9248, 9550) || true) && (indexerAccess.OriginalIndexersOpt.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 9248, 9550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 9337, 9531);

                        f_10292_9337_9530(this, indexerAccess.Syntax, parameters, argumentsBuilder, refKindsBuilderOpt, ref argsToParams, out defaultArguments, f_10292_9470_9492(indexerAccess), enableCallerInfo: true, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 9248, 9550);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 9570, 10046);

                    indexerAccess = f_10292_9586_10045(indexerAccess, f_10292_9629_9654(indexerAccess), f_10292_9677_9698(indexerAccess), f_10292_9721_9758(argumentsBuilder), f_10292_9781_9811(indexerAccess), f_10292_9834_9873_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(refKindsBuilderOpt, 10292, 9834, 9873)?.ToImmutableOrNull()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>?>(10292, 9834, 9884) ?? default), f_10292_9907_9929(indexerAccess), argsToParams, defaultArguments, f_10292_10026_10044(indexerAccess));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 10066, 10093);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(refKindsBuilderOpt, 10292, 10066, 10092)?.Free(), 10292, 10085, 10092);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 7561, 10108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 10124, 10145);

                return indexerAccess;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 7081, 10156);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_7309_7330(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7309, 7330);
                    return return_v;
                }


                bool
                f_10292_7308_7343_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7308, 7343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_7426_7447(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7426, 7447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10292_7426_7476(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 7426, 7476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_7496_7517(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7496, 7517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10292_7496_7546(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 7496, 7546);
                    return return_v;
                }


                int
                f_10292_7703_7745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7703, 7745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_7661_7746(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 7661, 7746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_7791_7814(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7791, 7814);
                    return return_v;
                }


                int
                f_10292_7765_7815(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 7765, 7815);
                    return 0;
                }


                bool
                f_10292_7900_7951_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 7900, 7951);
                    return return_v;
                }


                int
                f_10292_8048_8090(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 8048, 8090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10292_8014_8091(int
                capacity)
                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 8014, 8091);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_8142_8175(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 8142, 8175);
                    return return_v;
                }


                int
                f_10292_8114_8176(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 8114, 8176);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_8341_8370(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 8341, 8370);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_8646_8684(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 8646, 8684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_8947_8968(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 8947, 8968);
                    return return_v;
                }


                int
                f_10292_8913_8987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 8913, 8987);
                    return 0;
                }


                bool
                f_10292_9470_9492(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 9470, 9492);
                    return return_v;
                }


                int
                f_10292_9337_9530(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
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
                    this_param.BindDefaultArguments(node, parameters, argumentsBuilder, argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 9337, 9530);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_9629_9654(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 9629, 9654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_9677_9698(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 9677, 9698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_9721_9758(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 9721, 9758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10292_9781_9811(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 9781, 9811);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>?
                f_10292_9834_9873_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 9834, 9873);
                    return return_v;
                }


                bool
                f_10292_9907_9929(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 9907, 9929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_10026_10044(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 10026, 10044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                f_10292_9586_10045(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                indexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 9586, 10045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 7081, 10156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 7081, 10156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression CheckValue(BoundExpression expr, BindValueKind valueKind, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 10685, 16584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 10818, 12386);

                switch (f_10292_10826_10835(expr))
                {

                    case BoundKind.PropertyGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 10920, 11043);

                        expr = f_10292_10927_11042(this, expr, mustHaveAllOptionalParameters: false, diagnostics: diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11065, 11256) || true) && (expr is BoundIndexerAccess indexerAccess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 11065, 11256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11159, 11233);

                            expr = f_10292_11166_11232(this, indexerAccess, valueKind, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 11065, 11256);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 11278, 11284);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11347, 11442);

                        f_10292_11347_11441(f_10292_11360_11378(expr.Syntax) != SyntaxKind.Argument || (DynAbs.Tracing.TraceSender.Expression_False(10292, 11360, 11440) || valueKind == BindValueKind.RefOrOut));
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 11464, 11470);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);

                    case BoundKind.OutVariablePendingInference:
                    case BoundKind.OutDeconstructVarPendingInference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11622, 11672);

                        f_10292_11622_11671(valueKind == BindValueKind.RefOrOut);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11694, 11706);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11781, 11910);

                        f_10292_11781_11909(valueKind == BindValueKind.Assignable || (DynAbs.Tracing.TraceSender.Expression_False(10292, 11794, 11870) || valueKind == BindValueKind.RefOrOut) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 11794, 11908) || f_10292_11874_11908(diagnostics)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 11932, 11944);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12015, 12100);

                        expr = f_10292_12022_12099(this, expr, valueKind, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 12122, 12128);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);

                    case BoundKind.UnconvertedObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 10818, 12386);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12221, 12343) || true) && (valueKind == BindValueKind.RValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 12221, 12343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12308, 12320);

                            return expr;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 12221, 12343);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 12365, 12371);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 10818, 12386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12402, 12435);

                bool
                hasResolutionErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12860, 16014) || true) && (f_10292_12864_12873(expr) == BoundKind.MethodGroup && (DynAbs.Tracing.TraceSender.Expression_True(10292, 12864, 12948) && valueKind != BindValueKind.RValueOrMethodGroup))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 12860, 16014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 12982, 13023);

                    var
                    methodGroup = (BoundMethodGroup)expr
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13041, 13091);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13109, 13264);

                    var
                    resolution = f_10292_13126_13263(this, methodGroup, analyzedArguments: null, isMethodGroupConversion: false, useSiteDiagnostics: ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13282, 13331);

                    f_10292_13282_13330(diagnostics, expr.Syntax, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13349, 13375);

                    Symbol
                    otherSymbol = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13393, 13453);

                    bool
                    resolvedToMethodGroup = resolution.MethodGroup != null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13471, 13540) || true) && (f_10292_13475_13493_M(!expr.HasAnyErrors))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 13471, 13540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13495, 13540);

                        f_10292_13495_13539(diagnostics, resolution.Diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 13471, 13540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13581, 13627);

                    hasResolutionErrors = resolution.HasAnyErrors;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13645, 13766) || true) && (hasResolutionErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 13645, 13766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13710, 13747);

                        otherSymbol = resolution.OtherSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 13645, 13766);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 13784, 13802);

                    resolution.Free();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 14314, 15999) || true) && (!resolvedToMethodGroup)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 14314, 15999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 14382, 14446);

                        f_10292_14382_14445(f_10292_14395_14417(methodGroup) != LookupResultKind.Viable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 14468, 14507);

                        var
                        receiver = f_10292_14483_14506(methodGroup)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 14529, 15539) || true) && ((object)otherSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10292, 14533, 14613) && f_10292_14564_14578_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiver, 10292, 14564, 14578)?.Kind) == BoundKind.TypeOrValueExpression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 14529, 15539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 15089, 15135);

                            f_10292_15089_15134(f_10292_15102_15125(methodGroup) != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 15261, 15316);

                            var
                            typeOrValue = (BoundTypeOrValueExpression)receiver
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 15342, 15492);

                            receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 15353, 15391) || ((f_10292_15353_15391(otherSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 15423, 15455)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 15487, 15491))) ? typeOrValue.Data.ValueExpression
                            : null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 14529, 15539);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 15561, 15980);

                        return f_10292_15568_15979(expr.Syntax, f_10292_15655_15677(methodGroup), (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 15704, 15731) || (((object)otherSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 15734, 15762)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 15765, 15799))) ? ImmutableArray<Symbol>.Empty : f_10292_15765_15799(otherSymbol), (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 15826, 15842) || ((receiver == null && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 15845, 15882)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 15885, 15916))) ? ImmutableArray<BoundExpression>.Empty : f_10292_15885_15916(receiver), f_10292_15943_15978(this, otherSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 14314, 15999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 12860, 16014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16030, 16302) || true) && (!hasResolutionErrors && (DynAbs.Tracing.TraceSender.Expression_True(10292, 16034, 16153) && f_10292_16058_16153(this, expr.Syntax, expr, valueKind, checkingReceiver: false, diagnostics: diagnostics)) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 16034, 16241) || f_10292_16174_16191(expr) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 16174, 16241) && valueKind == BindValueKind.RValueOrMethodGroup)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 16030, 16302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16275, 16287);

                    return expr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 16030, 16302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16318, 16516);

                var
                resultKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 16335, 16420) || (((valueKind == BindValueKind.RValue || (DynAbs.Tracing.TraceSender.Expression_False(10292, 16336, 16419) || valueKind == BindValueKind.RValueOrMethodGroup)) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 16440, 16466)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 16486, 16515))) ? LookupResultKind.NotAValue : LookupResultKind.NotAVariable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16532, 16573);

                return f_10292_16539_16572(this, expr, resultKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 10685, 16584);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_10826_10835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 10826, 10835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_10927_11042(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                propertyGroup, bool
                mustHaveAllOptionalParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIndexedPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundPropertyGroup)propertyGroup, mustHaveAllOptionalParameters: mustHaveAllOptionalParameters, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 10927, 11042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                f_10292_11166_11232(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                indexerAccess, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIndexerDefaultArguments(indexerAccess, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11166, 11232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10292_11360_11378(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11360, 11378);
                    return return_v;
                }


                int
                f_10292_11347_11441(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11347, 11441);
                    return 0;
                }


                int
                f_10292_11622_11671(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11622, 11671);
                    return 0;
                }


                bool
                f_10292_11874_11908(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyResolvedErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11874, 11908);
                    return return_v;
                }


                int
                f_10292_11781_11909(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 11781, 11909);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                f_10292_12022_12099(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                indexerAccess, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIndexerDefaultArguments((Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess)indexerAccess, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 12022, 12099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_12864_12873(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 12864, 12873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10292_13126_13263(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                isMethodGroupConversion, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments: analyzedArguments, isMethodGroupConversion: isMethodGroupConversion, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 13126, 13263);
                    return return_v;
                }


                bool
                f_10292_13282_13330(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 13282, 13330);
                    return return_v;
                }


                bool
                f_10292_13475_13493_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 13475, 13493);
                    return return_v;
                }


                int
                f_10292_13495_13539(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 13495, 13539);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10292_14395_14417(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 14395, 14417);
                    return return_v;
                }


                int
                f_10292_14382_14445(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 14382, 14445);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_14483_14506(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 14483, 14506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10292_14564_14578_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 14564, 14578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10292_15102_15125(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 15102, 15125);
                    return return_v;
                }


                int
                f_10292_15089_15134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15089, 15134);
                    return 0;
                }


                bool
                f_10292_15353_15391(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15353, 15391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10292_15655_15677(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 15655, 15677);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10292_15765_15799(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15765, 15799);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_15885_15916(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15885, 15916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_15943_15978(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbolOpt)
                {
                    var return_v = this_param.GetNonMethodMemberType(symbolOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15943, 15978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10292_15568_15979(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 15568, 15979);
                    return return_v;
                }


                bool
                f_10292_16058_16153(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 16058, 16153);
                    return return_v;
                }


                bool
                f_10292_16174_16191(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 16174, 16191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_16539_16572(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = this_param.ToBadExpression(expr, resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 16539, 16572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 10685, 16584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 10685, 16584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsTypeOrValueExpression(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 16596, 17036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16693, 17025);

                switch (f_10292_16701_16717_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(expression, 10292, 16701, 16717)?.Kind))
                {

                    case BoundKind.TypeOrValueExpression:
                    case BoundKind.QueryClause when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16833, 16914) || true) && (f_10292_16838_16879(f_10292_16838_16874(((BoundQueryClause)expression))) == BoundKind.TypeOrValueExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 16833, 16914) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 16693, 17025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16937, 16949);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 16693, 17025);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 16693, 17025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 16997, 17010);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 16693, 17025);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 16596, 17036);

                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10292_16701_16717_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 16701, 16717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_16838_16874(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 16838, 16874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_16838_16879(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 16838, 16879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 16596, 17036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 16596, 17036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CheckValueKind(SyntaxNode node, BoundExpression expr, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 17832, 31001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 17999, 18087);

                f_10292_17999_18086(!checkingReceiver || (DynAbs.Tracing.TraceSender.Expression_False(10292, 18012, 18054) || f_10292_18033_18054(f_10292_18033_18042(expr))) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 18012, 18085) || f_10292_18058_18085(f_10292_18058_18067(expr))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18103, 18186) || true) && (f_10292_18107_18124(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 18103, 18186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18158, 18171);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 18103, 18186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18202, 19529);

                switch (f_10292_18210_18219(expr))
                {

                    case BoundKind.PropertyAccess:
                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 18202, 19529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18470, 18554);

                        return f_10292_18477_18553(this, node, expr, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 18202, 19529);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 18202, 19529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18644, 18711);

                        var
                        patternIndexer = ((BoundIndexOrRangePatternIndexerAccess)expr)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 18733, 19251) || true) && (f_10292_18737_18770(f_10292_18737_18765(patternIndexer)) == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 18733, 19251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19144, 19228);

                            return f_10292_19151_19227(this, node, expr, valueKind, checkingReceiver, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 18733, 19251);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19273, 19342);

                        f_10292_19273_19341(f_10292_19286_19319(f_10292_19286_19314(patternIndexer)) == SymbolKind.Method);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 19364, 19370);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 18202, 19529);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 18202, 19529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19439, 19514);

                        return f_10292_19446_19513(this, expr, valueKind, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 18202, 19529);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19601, 19733) || true) && (f_10292_19605_19634(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 19601, 19733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19668, 19718);

                    return f_10292_19675_19717(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 19601, 19733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19848, 20083) || true) && ((f_10292_19853_19871(expr) != null) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 19852, 19943) || (f_10292_19885_19915(f_10292_19885_19894(expr)) == SpecialType.System_Void)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 19848, 20083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 19977, 20037);

                    f_10292_19977_20036(diagnostics, f_10292_19996_20029(valueKind), node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20055, 20068);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 19848, 20083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20099, 30769);

                switch (f_10292_20107_20116(expr))
                {

                    case BoundKind.NamespaceExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20207, 20247);

                        var
                        ns = (BoundNamespaceExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20269, 20417);

                        f_10292_20269_20416(diagnostics, ErrorCode.ERR_BadSKknown, node, f_10292_20320_20338(ns), f_10292_20340_20377(MessageID.IDS_SK_NAMESPACE), f_10292_20379_20415(MessageID.IDS_SK_VARIABLE));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20439, 20452);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.TypeExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20524, 20561);

                        var
                        type = (BoundTypeExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20583, 20717);

                        f_10292_20583_20716(diagnostics, ErrorCode.ERR_BadSKknown, node, f_10292_20634_20643(type), f_10292_20645_20677(MessageID.IDS_SK_TYPE), f_10292_20679_20715(MessageID.IDS_SK_VARIABLE));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20739, 20752);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.Lambda:
                    case BoundKind.UnboundLambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 20923, 20983);

                        f_10292_20923_20982(diagnostics, f_10292_20942_20975(valueKind), node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21005, 21018);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.UnconvertedAddressOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21104, 21171);

                        var
                        unconvertedAddressOf = (BoundUnconvertedAddressOfOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21193, 21355);

                        f_10292_21193_21354(diagnostics, f_10292_21212_21265(valueKind), node, f_10292_21273_21306(f_10292_21273_21301(unconvertedAddressOf)), f_10292_21308_21353(MessageID.IDS_AddressOfMethodGroup));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21377, 21390);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.MethodGroup when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21437, 21478) || true) && (valueKind == BindValueKind.AddressOf) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 21437, 21478) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21695, 21707);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21880, 21921);

                        var
                        methodGroup = (BoundMethodGroup)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 21943, 22079);

                        f_10292_21943_22078(diagnostics, f_10292_21962_22015(valueKind), node, f_10292_22023_22039(methodGroup), f_10292_22041_22077(MessageID.IDS_MethodGroup));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22101, 22114);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22253, 22293);

                        var
                        queryref = (BoundRangeVariable)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22315, 22407);

                        f_10292_22315_22406(diagnostics, f_10292_22334_22364(valueKind), node, f_10292_22372_22405(f_10292_22372_22400(queryref)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22429, 22442);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22510, 22549);

                        var
                        conversion = (BoundConversion)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22661, 22884) || true) && (f_10292_22665_22690(conversion) == ConversionKind.Unboxing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 22661, 22884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22767, 22822);

                            f_10292_22767_22821(diagnostics, ErrorCode.ERR_UnboxNotLValue, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 22848, 22861);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 22661, 22884);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 22906, 22912);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23110, 23346) || true) && (f_10292_23114_23154(valueKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 23110, 23346);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23212, 23276);

                                f_10292_23212_23275(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23306, 23319);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 23110, 23346);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23374, 23415);

                            var
                            boundAccess = (BoundArrayAccess)expr
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23441, 23996) || true) && (boundAccess.Indices.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10292, 23445, 23749) && f_10292_23509_23749(f_10292_23561_23588(f_10292_23561_23580(boundAccess)[0]), f_10292_23623_23679(f_10292_23623_23634(), WellKnownType.System_Range), TypeCompareKind.ConsiderEverything)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 23441, 23996);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23866, 23926);

                                f_10292_23866_23925(diagnostics, f_10292_23885_23918(valueKind), node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 23956, 23969);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 23441, 23996);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 24022, 24034);

                            return true;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.PointerIndirectionOperator:
                    // The undocumented __refvalue(tr, T) expression results in a variable of type T.
                    case BoundKind.RefValueOperator:
                    // dynamic expressions are readwrite, and can even be passed by ref (which is implemented via a temp)
                    case BoundKind.DynamicMemberAccess:
                    case BoundKind.DynamicIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 24609, 24845) || true) && (f_10292_24613_24653(valueKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 24609, 24845);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 24711, 24775);

                                f_10292_24711_24774(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 24805, 24818);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 24609, 24845);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 24931, 24943);

                            return true;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25071, 25307) || true) && (f_10292_25075_25115(valueKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 25071, 25307);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25173, 25237);

                                f_10292_25173_25236(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25267, 25280);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 25071, 25307);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25335, 25395);

                            var
                            receiver = f_10292_25350_25394(((BoundPointerElementAccess)expr))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25421, 25696) || true) && (receiver is BoundFieldAccess fieldAccess && (DynAbs.Tracing.TraceSender.Expression_True(10292, 25425, 25510) && f_10292_25469_25510(f_10292_25469_25492(fieldAccess))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 25421, 25696);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25568, 25669);

                                return f_10292_25575_25668(this, node, f_10292_25596_25619(fieldAccess), valueKind, checkingReceiver: true, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 25421, 25696);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25724, 25736);

                            return true;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25826, 25863);

                        var
                        parameter = (BoundParameter)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 25885, 25975);

                        return f_10292_25892_25974(this, node, parameter, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 26038, 26067);

                        var
                        local = (BoundLocal)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 26089, 26171);

                        return f_10292_26096_26170(this, node, local, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 26297, 26517) || true) && (f_10292_26301_26341(valueKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 26297, 26517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 26391, 26455);

                            f_10292_26391_26454(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 26481, 26494);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 26297, 26517);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 27414, 27476);

                        var
                        isValueType = f_10292_27432_27475(f_10292_27432_27463(((BoundThisReference)expr)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 27498, 28032) || true) && (!isValueType || (DynAbs.Tracing.TraceSender.Expression_False(10292, 27502, 27845) || (f_10292_27519_27556(valueKind) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 27519, 27773) &&                        // LAFHIS
                                                                                                                                                                                                                                                                                                                                  //(this.ContainingMemberOrLambda as MethodSymbol)?.IsEffectivelyReadOnly == true
                                                (f_10292_27727_27756(this) is MethodSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 27519, 27844) && f_10292_27777_27844(((MethodSymbol)f_10292_27792_27821(this)))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 27498, 28032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 27895, 27970);

                            f_10292_27895_27969(diagnostics, f_10292_27914_27956(valueKind, isValueType), node, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 27996, 28009);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 27498, 28032);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28056, 28068);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.ImplicitReceiver:
                    case BoundKind.ObjectOrCollectionValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28210, 28266);

                        f_10292_28210_28265(!f_10292_28224_28264(valueKind));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28288, 28300);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28362, 28389);

                        var
                        call = (BoundCall)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28411, 28491);

                        return f_10292_28418_28490(this, call, node, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28574, 28860);

                        return f_10292_28581_28859(this, f_10292_28608_28672(f_10292_28608_28662(((BoundFunctionPointerInvocation)expr))), expr.Syntax, node, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 28950, 29015);

                        var
                        patternIndexer = (BoundIndexOrRangePatternIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 29226, 29526);

                        return f_10292_29233_29525(this, f_10292_29300_29328(patternIndexer), patternIndexer.Syntax, node, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 29603, 29652);

                        var
                        conditional = (BoundConditionalOperator)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 29741, 30172) || true) && (f_10292_29745_29762(conditional) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 29745, 30087) && (f_10292_29792_29925(this, f_10292_29807_29830(conditional).Syntax, f_10292_29839_29862(conditional), valueKind, checkingReceiver: false, diagnostics: diagnostics) &
                        f_10292_29953_30086(this, f_10292_29968_29991(conditional).Syntax, f_10292_30000_30023(conditional), valueKind, checkingReceiver: false, diagnostics: diagnostics))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 29741, 30172);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30137, 30149);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 29741, 30172);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 30249, 30255);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30351, 30392);

                            var
                            fieldAccess = (BoundFieldAccess)expr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30418, 30506);

                            return f_10292_30425_30505(this, node, fieldAccess, valueKind, checkingReceiver, diagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 20099, 30769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30605, 30652);

                        var
                        assignment = (BoundAssignmentOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30674, 30754);

                        return f_10292_30681_30753(this, node, assignment, valueKind, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 20099, 30769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30903, 30963);

                f_10292_30903_30962(diagnostics, f_10292_30922_30955(valueKind), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 30977, 30990);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 17832, 31001);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_18033_18042(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18033, 18042);
                    return return_v;
                }


                bool
                f_10292_18033_18054(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18033, 18054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_18058_18067(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18058, 18067);
                    return return_v;
                }


                bool
                f_10292_18058_18085(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 18058, 18085);
                    return return_v;
                }


                int
                f_10292_17999_18086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 17999, 18086);
                    return 0;
                }


                bool
                f_10292_18107_18124(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18107, 18124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_18210_18219(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18210, 18219);
                    return return_v;
                }


                bool
                f_10292_18477_18553(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckPropertyValueKind(node, expr, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 18477, 18553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_18737_18765(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18737, 18765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_18737_18770(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 18737, 18770);
                    return return_v;
                }


                bool
                f_10292_19151_19227(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckPropertyValueKind(node, expr, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19151, 19227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_19286_19314(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 19286, 19314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_19286_19319(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 19286, 19319);
                    return return_v;
                }


                int
                f_10292_19273_19341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19273, 19341);
                    return 0;
                }


                bool
                f_10292_19446_19513(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundEvent, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckEventValueKind((Microsoft.CodeAnalysis.CSharp.BoundEventAccess)boundEvent, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19446, 19513);
                    return return_v;
                }


                bool
                f_10292_19605_19634(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRValueOnly(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19605, 19634);
                    return return_v;
                }


                bool
                f_10292_19675_19717(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckNotNamespaceOrType(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19675, 19717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10292_19853_19871(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 19853, 19871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_19885_19894(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 19885, 19894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10292_19885_19915(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19885, 19915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_19996_20029(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19996, 20029);
                    return return_v;
                }


                int
                f_10292_19977_20036(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 19977, 20036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_20107_20116(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 20107, 20116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10292_20320_20338(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                this_param)
                {
                    var return_v = this_param.NamespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 20320, 20338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_20340_20377(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20340, 20377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_20379_20415(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20379, 20415);
                    return return_v;
                }


                int
                f_10292_20269_20416(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20269, 20416);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_20634_20643(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 20634, 20643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_20645_20677(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20645, 20677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_20679_20715(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20679, 20715);
                    return return_v;
                }


                int
                f_10292_20583_20716(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20583, 20716);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_20942_20975(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20942, 20975);
                    return return_v;
                }


                int
                f_10292_20923_20982(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 20923, 20982);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_21212_21265(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = GetMethodGroupOrFunctionPointerLvalueError(valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 21212, 21265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10292_21273_21301(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 21273, 21301);
                    return return_v;
                }


                string
                f_10292_21273_21306(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 21273, 21306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_21308_21353(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 21308, 21353);
                    return return_v;
                }


                int
                f_10292_21193_21354(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 21193, 21354);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_21962_22015(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = GetMethodGroupOrFunctionPointerLvalueError(valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 21962, 22015);
                    return return_v;
                }


                string
                f_10292_22023_22039(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 22023, 22039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_22041_22077(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 22041, 22077);
                    return return_v;
                }


                int
                f_10292_21943_22078(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 21943, 22078);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_22334_22364(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetRangeLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 22334, 22364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10292_22372_22400(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 22372, 22400);
                    return return_v;
                }


                string
                f_10292_22372_22405(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 22372, 22405);
                    return return_v;
                }


                int
                f_10292_22315_22406(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 22315, 22406);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10292_22665_22690(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 22665, 22690);
                    return return_v;
                }


                int
                f_10292_22767_22821(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 22767, 22821);
                    return 0;
                }


                bool
                f_10292_23114_23154(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23114, 23154);
                    return return_v;
                }


                int
                f_10292_23212_23275(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23212, 23275);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_23561_23580(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 23561, 23580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_23561_23588(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 23561, 23588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10292_23623_23634()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 23623, 23634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_23623_23679(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23623, 23679);
                    return return_v;
                }


                bool
                f_10292_23509_23749(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23509, 23749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_23885_23918(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23885, 23918);
                    return return_v;
                }


                int
                f_10292_23866_23925(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 23866, 23925);
                    return 0;
                }


                bool
                f_10292_24613_24653(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 24613, 24653);
                    return return_v;
                }


                int
                f_10292_24711_24774(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 24711, 24774);
                    return 0;
                }


                bool
                f_10292_25075_25115(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 25075, 25115);
                    return return_v;
                }


                int
                f_10292_25173_25236(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 25173, 25236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_25350_25394(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 25350, 25394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_25469_25492(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 25469, 25492);
                    return return_v;
                }


                bool
                f_10292_25469_25510(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 25469, 25510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_25596_25619(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 25596, 25619);
                    return return_v;
                }


                bool
                f_10292_25575_25668(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver: checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 25575, 25668);
                    return return_v;
                }


                bool
                f_10292_25892_25974(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundParameter
                parameter, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckParameterValueKind(node, parameter, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 25892, 25974);
                    return return_v;
                }


                bool
                f_10292_26096_26170(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundLocal
                local, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckLocalValueKind(node, local, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 26096, 26170);
                    return return_v;
                }


                bool
                f_10292_26301_26341(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 26301, 26341);
                    return return_v;
                }


                int
                f_10292_26391_26454(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 26391, 26454);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_27432_27463(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 27432, 27463);
                    return return_v;
                }


                bool
                f_10292_27432_27475(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 27432, 27475);
                    return return_v;
                }


                bool
                f_10292_27519_27556(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 27519, 27556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10292_27727_27756(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 27727, 27756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_27792_27821(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 27792, 27821);
                    return return_v;
                }


                bool
                f_10292_27777_27844(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsEffectivelyReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 27777, 27844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_27914_27956(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                isValueType)
                {
                    var return_v = GetThisLvalueError(kind, isValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 27914, 27956);
                    return return_v;
                }


                int
                f_10292_27895_27969(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 27895, 27969);
                    return 0;
                }


                bool
                f_10292_28224_28264(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 28224, 28264);
                    return return_v;
                }


                int
                f_10292_28210_28265(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 28210, 28265);
                    return 0;
                }


                bool
                f_10292_28418_28490(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                call, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckCallValueKind(call, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 28418, 28490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10292_28608_28662(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 28608, 28662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10292_28608_28672(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 28608, 28672);
                    return return_v;
                }


                bool
                f_10292_28581_28859(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                callSyntaxOpt, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckMethodReturnValueKind((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, callSyntaxOpt, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 28581, 28859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_29300_29328(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 29300, 29328);
                    return return_v;
                }


                bool
                f_10292_29233_29525(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                callSyntaxOpt, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckMethodReturnValueKind((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, callSyntaxOpt, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 29233, 29525);
                    return return_v;
                }


                bool
                f_10292_29745_29762(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 29745, 29762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_29807_29830(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 29807, 29830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_29839_29862(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 29839, 29862);
                    return return_v;
                }


                bool
                f_10292_29792_29925(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 29792, 29925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_29968_29991(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 29968, 29991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_30000_30023(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 30000, 30023);
                    return return_v;
                }


                bool
                f_10292_29953_30086(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 29953, 30086);
                    return return_v;
                }


                bool
                f_10292_30425_30505(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckFieldValueKind(node, fieldAccess, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 30425, 30505);
                    return return_v;
                }


                bool
                f_10292_30681_30753(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignment, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckSimpleAssignmentValueKind(node, assignment, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 30681, 30753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_30922_30955(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 30922, 30955);
                    return return_v;
                }


                int
                f_10292_30903_30962(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 30903, 30962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 17832, 31001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 17832, 31001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckNotNamespaceOrType(BoundExpression expr, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 31013, 31754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31130, 31743);

                switch (f_10292_31138_31147(expr))
                {

                    case BoundKind.NamespaceExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 31130, 31743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31238, 31423);

                        f_10292_31238_31422(diagnostics, ErrorCode.ERR_BadSKknown, expr.Syntax, f_10292_31296_31344(((BoundNamespaceExpression)expr)), f_10292_31346_31383(MessageID.IDS_SK_NAMESPACE), f_10292_31385_31421(MessageID.IDS_SK_VARIABLE));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31445, 31458);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 31130, 31743);

                    case BoundKind.TypeExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 31130, 31743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31528, 31633);

                        f_10292_31528_31632(diagnostics, ErrorCode.ERR_BadSKunknown, expr.Syntax, f_10292_31588_31597(expr), f_10292_31599_31631(MessageID.IDS_SK_TYPE));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31655, 31668);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 31130, 31743);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 31130, 31743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 31716, 31728);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 31130, 31743);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 31013, 31754);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_31138_31147(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 31138, 31147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10292_31296_31344(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                this_param)
                {
                    var return_v = this_param.NamespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 31296, 31344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_31346_31383(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 31346, 31383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_31385_31421(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 31385, 31421);
                    return return_v;
                }


                int
                f_10292_31238_31422(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 31238, 31422);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_31588_31597(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 31588, 31597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_31599_31631(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 31599, 31631);
                    return return_v;
                }


                int
                f_10292_31528_31632(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 31528, 31632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 31013, 31754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 31013, 31754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckLocalValueKind(SyntaxNode node, BoundLocal local, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 31766, 33633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32149, 32193);

                LocalSymbol
                localSymbol = f_10292_32175_32192(local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32207, 33594) || true) && (f_10292_32211_32248(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 32207, 33594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32282, 32492) || true) && (f_10292_32286_32338(f_10292_32286_32316(this), localSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 32282, 32492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32380, 32473);

                        f_10292_32380_32472(diagnostics, ErrorCode.WRN_AssignmentToLockOrDispose, f_10292_32437_32458(local.Syntax), localSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 32282, 32492);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32684, 33009) || true) && (f_10292_32688_32707(localSymbol) == RefKind.RefReadOnly || (DynAbs.Tracing.TraceSender.Expression_False(10292, 32688, 32827) || (f_10292_32756_32775(localSymbol) == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10292, 32756, 32826) && f_10292_32795_32826_M(!localSymbol.IsWritableVariable)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 32684, 33009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32869, 32955);

                        f_10292_32869_32954(node, localSymbol, valueKind, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 32977, 32990);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 32684, 33009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 32207, 33594);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 32207, 33594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33043, 33594) || true) && (f_10292_33047_33087(valueKind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 33043, 33594);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33121, 33579) || true) && (f_10292_33125_33144(localSymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 33121, 33579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33202, 33285);

                            f_10292_33202_33284(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, f_10292_33257_33270(node), localSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33307, 33320);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 33121, 33579);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 33121, 33579);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33362, 33579) || true) && (f_10292_33366_33397_M(!localSymbol.IsWritableVariable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 33362, 33579);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33439, 33525);

                                f_10292_33439_33524(node, localSymbol, valueKind, checkingReceiver, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33547, 33560);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 33362, 33579);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 33121, 33579);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 33043, 33594);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 32207, 33594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33610, 33622);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 31766, 33633);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10292_32175_32192(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32175, 32192);
                    return return_v;
                }


                bool
                f_10292_32211_32248(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 32211, 32248);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10292_32286_32316(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LockedOrDisposedVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32286, 32316);
                    return return_v;
                }


                bool
                f_10292_32286_32338(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 32286, 32338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10292_32437_32458(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32437, 32458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10292_32380_32472(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 32380, 32472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_32688_32707(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32688, 32707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_32756_32775(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32756, 32775);
                    return return_v;
                }


                bool
                f_10292_32795_32826_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 32795, 32826);
                    return return_v;
                }


                int
                f_10292_32869_32954(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadonlyLocalError(node, local, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 32869, 32954);
                    return 0;
                }


                bool
                f_10292_33047_33087(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 33047, 33087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_33125_33144(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 33125, 33144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10292_33257_33270(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 33257, 33270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10292_33202_33284(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 33202, 33284);
                    return return_v;
                }


                bool
                f_10292_33366_33397_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 33366, 33397);
                    return return_v;
                }


                int
                f_10292_33439_33524(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadonlyLocalError(node, local, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 33439, 33524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 31766, 33633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 31766, 33633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckLocalRefEscape(SyntaxNode node, BoundLocal local, uint escapeTo, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 33645, 35203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 33809, 33853);

                LocalSymbol
                localSymbol = f_10292_33835_33852(local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34024, 34127) || true) && (f_10292_34028_34054(localSymbol) <= escapeTo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34024, 34127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34100, 34112);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34024, 34127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34143, 35084) || true) && (escapeTo == Binder.ExternalScope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34143, 35084);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34213, 34684) || true) && (f_10292_34217_34236(localSymbol) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34213, 34684);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34294, 34630) || true) && (checkingReceiver)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34294, 34630);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34364, 34441);

                            f_10292_34364_34440(diagnostics, ErrorCode.ERR_RefReturnLocal2, local.Syntax, localSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34294, 34630);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34294, 34630);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34539, 34607);

                            f_10292_34539_34606(diagnostics, ErrorCode.ERR_RefReturnLocal, node, localSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34294, 34630);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34652, 34665);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34213, 34684);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34704, 35038) || true) && (checkingReceiver)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34704, 35038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34766, 34856);

                        f_10292_34766_34855(diagnostics, ErrorCode.ERR_RefReturnNonreturnableLocal2, local.Syntax, localSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34704, 35038);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 34704, 35038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 34938, 35019);

                        f_10292_34938_35018(diagnostics, ErrorCode.ERR_RefReturnNonreturnableLocal, node, localSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34704, 35038);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35056, 35069);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 34143, 35084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35100, 35165);

                f_10292_35100_35164(diagnostics, ErrorCode.ERR_EscapeLocal, node, localSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35179, 35192);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 33645, 35203);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10292_33835_33852(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 33835, 33852);
                    return return_v;
                }


                uint
                f_10292_34028_34054(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefEscapeScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 34028, 34054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_34217_34236(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 34217, 34236);
                    return return_v;
                }


                int
                f_10292_34364_34440(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 34364, 34440);
                    return 0;
                }


                int
                f_10292_34539_34606(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 34539, 34606);
                    return 0;
                }


                int
                f_10292_34766_34855(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 34766, 34855);
                    return 0;
                }


                int
                f_10292_34938_35018(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 34938, 35018);
                    return 0;
                }


                int
                f_10292_35100_35164(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 35100, 35164);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 33645, 35203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 33645, 35203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckParameterValueKind(SyntaxNode node, BoundParameter parameter, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 35215, 36698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35394, 35454);

                ParameterSymbol
                parameterSymbol = f_10292_35428_35453(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35600, 36097) || true) && (f_10292_35604_35627(parameterSymbol) == RefKind.In && (DynAbs.Tracing.TraceSender.Expression_True(10292, 35604, 35682) && f_10292_35645_35682(valueKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 35600, 36097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35716, 35801);

                    f_10292_35716_35800(parameterSymbol, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35819, 35832);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 35600, 36097);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 35600, 36097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35866, 36097) || true) && (f_10292_35870_35893(parameterSymbol) == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10292, 35870, 35953) && f_10292_35913_35953(valueKind)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 35866, 36097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 35987, 36051);

                        f_10292_35987_36050(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 36069, 36082);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 35866, 36097);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 35600, 36097);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 36113, 36659) || true) && (f_10292_36117_36173(f_10292_36117_36147(this), parameterSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 36113, 36659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 36538, 36644);

                    f_10292_36538_36643(                // Consider: It would be more conventional to pass "symbol" rather than "symbol.Name".
                                                        // The issue is that the error SymbolDisplayFormat doesn't display parameter
                                                        // names - only their types - which works great in signatures, but not at all
                                                        // at the top level.
                                    diagnostics, ErrorCode.WRN_AssignmentToLockOrDispose, f_10292_36595_36620(parameter.Syntax), f_10292_36622_36642(parameterSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 36113, 36659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 36675, 36687);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 35215, 36698);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10292_35428_35453(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 35428, 35453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_35604_35627(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 35604, 35627);
                    return return_v;
                }


                bool
                f_10292_35645_35682(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 35645, 35682);
                    return return_v;
                }


                int
                f_10292_35716_35800(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadOnlyError((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 35716, 35800);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_35870_35893(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 35870, 35893);
                    return return_v;
                }


                bool
                f_10292_35913_35953(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 35913, 35953);
                    return return_v;
                }


                int
                f_10292_35987_36050(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 35987, 36050);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10292_36117_36147(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LockedOrDisposedVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 36117, 36147);
                    return return_v;
                }


                bool
                f_10292_36117_36173(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 36117, 36173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10292_36595_36620(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 36595, 36620);
                    return return_v;
                }


                string
                f_10292_36622_36642(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 36622, 36642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10292_36538_36643(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 36538, 36643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 35215, 36698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 35215, 36698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckParameterRefEscape(SyntaxNode node, BoundParameter parameter, uint escapeTo, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 36710, 37741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 36886, 36946);

                ParameterSymbol
                parameterSymbol = f_10292_36920_36945(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37151, 37648) || true) && (escapeTo == Binder.ExternalScope && (DynAbs.Tracing.TraceSender.Expression_True(10292, 37155, 37230) && f_10292_37191_37214(parameterSymbol) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 37151, 37648);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37264, 37602) || true) && (checkingReceiver)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 37264, 37602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37326, 37420);

                        f_10292_37326_37419(diagnostics, ErrorCode.ERR_RefReturnParameter2, parameter.Syntax, f_10292_37398_37418(parameterSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 37264, 37602);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 37264, 37602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37502, 37583);

                        f_10292_37502_37582(diagnostics, ErrorCode.ERR_RefReturnParameter, node, f_10292_37561_37581(parameterSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 37264, 37602);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37620, 37633);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 37151, 37648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37718, 37730);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 36710, 37741);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10292_36920_36945(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 36920, 36945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_37191_37214(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 37191, 37214);
                    return return_v;
                }


                string
                f_10292_37398_37418(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 37398, 37418);
                    return return_v;
                }


                int
                f_10292_37326_37419(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 37326, 37419);
                    return 0;
                }


                string
                f_10292_37561_37581(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 37561, 37581);
                    return return_v;
                }


                int
                f_10292_37502_37582(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 37502, 37582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 36710, 37741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 36710, 37741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckFieldValueKind(SyntaxNode node, BoundFieldAccess fieldAccess, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 37753, 41890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37932, 37974);

                var
                fieldSymbol = f_10292_37950_37973(fieldAccess)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 37988, 38029);

                var
                fieldIsStatic = f_10292_38008_38028(fieldSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 38045, 40734) || true) && (f_10292_38049_38086(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 38045, 40734);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 38598, 40510) || true) && (f_10292_38602_38624(fieldSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 38598, 40510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 38666, 38696);

                        var
                        canModifyReadonly = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 38720, 38770);

                        Symbol
                        containing = f_10292_38740_38769(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 38792, 40247) || true) && ((object)containing != null && (DynAbs.Tracing.TraceSender.Expression_True(10292, 38796, 38887) && fieldIsStatic == f_10292_38868_38887(containing)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 38796, 38990) && (fieldIsStatic || (DynAbs.Tracing.TraceSender.Expression_False(10292, 38917, 38989) || f_10292_38934_38962(f_10292_38934_38957(fieldAccess)) == BoundKind.ThisReference))) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 38796, 39484) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 39020, 39052) || ((f_10292_39020_39052(f_10292_39020_39031()) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 39084, 39193)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 39336, 39483))) ? f_10292_39084_39193(f_10292_39102_39128(fieldSymbol), f_10292_39130_39155(containing), TypeCompareKind.ConsiderEverything2) : f_10292_39336_39483(f_10292_39354_39399(f_10292_39354_39380(fieldSymbol)), f_10292_39401_39445(f_10292_39401_39426(containing)), TypeCompareKind.ConsiderEverything2))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 38792, 40247);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 39534, 40224) || true) && (f_10292_39538_39553(containing) == SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 39534, 40224);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 39632, 39689);

                                MethodSymbol
                                containingMethod = (MethodSymbol)containing
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 39719, 39820);

                                MethodKind
                                desiredMethodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 39750, 39763) || ((fieldIsStatic && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 39766, 39794)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 39797, 39819))) ? MethodKind.StaticConstructor : MethodKind.Constructor
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 39850, 40017);

                                canModifyReadonly = (f_10292_39871_39898(containingMethod) == desiredMethodKind) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 39870, 40016) || f_10292_39957_40016(f_10292_39992_40015(fieldAccess)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 39534, 40224);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 39534, 40224);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40075, 40224) || true) && (f_10292_40079_40094(containing) == SymbolKind.Field)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 40075, 40224);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40172, 40197);

                                    canModifyReadonly = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 40075, 40224);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 39534, 40224);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 38792, 40247);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40271, 40491) || true) && (!canModifyReadonly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 40271, 40491);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40343, 40429);

                            f_10292_40343_40428(fieldSymbol, node, valueKind, checkingReceiver, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40455, 40468);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 40271, 40491);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 38598, 40510);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40530, 40719) || true) && (f_10292_40534_40563(fieldSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 40530, 40719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40605, 40665);

                        f_10292_40605_40664(diagnostics, f_10292_40624_40657(valueKind), node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40687, 40700);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 40530, 40719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 38045, 40734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40750, 40938) || true) && (f_10292_40754_40794(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 40750, 40938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40828, 40892);

                    f_10292_40828_40891(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 40910, 40923);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 40750, 40938);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41055, 41179) || true) && (fieldIsStatic || (DynAbs.Tracing.TraceSender.Expression_False(10292, 41059, 41118) || f_10292_41076_41118(f_10292_41076_41102(fieldSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 41055, 41179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41152, 41164);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 41055, 41179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41251, 41345);

                return f_10292_41258_41344(this, node, f_10292_41296_41319(fieldAccess), valueKind, diagnostics);

                bool isAssignedFromInitOnlySetterOnThis(BoundExpression receiver)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 41361, 41879);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41560, 41671) || true) && (!(receiver is BoundThisReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 41560, 41671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41639, 41652);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 41560, 41671);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41691, 41819) || true) && (!(f_10292_41697_41721() is MethodSymbol method))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 41691, 41819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41787, 41800);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 41691, 41819);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 41839, 41864);

                        return f_10292_41846_41863(method);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 41361, 41879);

                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10292_41697_41721()
                        {
                            var return_v = ContainingMemberOrLambda;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 41697, 41721);
                            return return_v;
                        }


                        bool
                        f_10292_41846_41863(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsInitOnly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 41846, 41863);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 41361, 41879);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 41361, 41879);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 37753, 41890);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_37950_37973(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 37950, 37973);
                    return return_v;
                }


                bool
                f_10292_38008_38028(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38008, 38028);
                    return return_v;
                }


                bool
                f_10292_38049_38086(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 38049, 38086);
                    return return_v;
                }


                bool
                f_10292_38602_38624(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38602, 38624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10292_38740_38769(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38740, 38769);
                    return return_v;
                }


                bool
                f_10292_38868_38887(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38868, 38887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_38934_38957(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38934, 38957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_38934_38962(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 38934, 38962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10292_39020_39031()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39020, 39031);
                    return return_v;
                }


                bool
                f_10292_39020_39052(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.FeatureStrictEnabled
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39020, 39052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39102_39128(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39102, 39128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39130_39155(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39130, 39155);
                    return return_v;
                }


                bool
                f_10292_39084_39193(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 39084, 39193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39354_39380(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39354, 39380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39354_39399(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39354, 39399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39401_39426(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39401, 39426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_39401_39445(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39401, 39445);
                    return return_v;
                }


                bool
                f_10292_39336_39483(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 39336, 39483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_39538_39553(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39538, 39553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10292_39871_39898(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39871, 39898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_39992_40015(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 39992, 40015);
                    return return_v;
                }


                bool
                f_10292_39957_40016(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = isAssignedFromInitOnlySetterOnThis(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 39957, 40016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_40079_40094(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 40079, 40094);
                    return return_v;
                }


                int
                f_10292_40343_40428(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadOnlyFieldError(field, node, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 40343, 40428);
                    return 0;
                }


                bool
                f_10292_40534_40563(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 40534, 40563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_40624_40657(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 40624, 40657);
                    return return_v;
                }


                int
                f_10292_40605_40664(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 40605, 40664);
                    return 0;
                }


                bool
                f_10292_40754_40794(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 40754, 40794);
                    return return_v;
                }


                int
                f_10292_40828_40891(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 40828, 40891);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_41076_41102(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 41076, 41102);
                    return return_v;
                }


                bool
                f_10292_41076_41118(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 41076, 41118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_41296_41319(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 41296, 41319);
                    return return_v;
                }


                bool
                f_10292_41258_41344(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckIsValidReceiverForVariable(node, receiver, kind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 41258, 41344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 37753, 41890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 37753, 41890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckSimpleAssignmentValueKind(SyntaxNode node, BoundAssignmentOperator assignment, BindValueKind valueKind, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 41902, 42401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42124, 42287) || true) && (f_10292_42128_42144(assignment))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 42124, 42287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42178, 42272);

                    return f_10292_42185_42271(this, node, f_10292_42206_42221(assignment), valueKind, checkingReceiver: false, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 42124, 42287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42303, 42363);

                f_10292_42303_42362(diagnostics, f_10292_42322_42355(valueKind), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42377, 42390);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 41902, 42401);

                bool
                f_10292_42128_42144(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42128, 42144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_42206_42221(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42206, 42221);
                    return return_v;
                }


                bool
                f_10292_42185_42271(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver: checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 42185, 42271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_42322_42355(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 42322, 42355);
                    return return_v;
                }


                int
                f_10292_42303_42362(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 42303, 42362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 41902, 42401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 41902, 42401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckFieldRefEscape(SyntaxNode node, BoundFieldAccess fieldAccess, uint escapeFrom, uint escapeTo, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 42413, 43070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42583, 42625);

                var
                fieldSymbol = f_10292_42601_42624(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42731, 42862) || true) && (f_10292_42735_42755(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 42735, 42801) || f_10292_42759_42801(f_10292_42759_42785(fieldSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 42731, 42862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42835, 42847);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 42731, 42862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 42934, 43059);

                return f_10292_42941_43058(node, f_10292_42962_42985(fieldAccess), escapeFrom, escapeTo, checkingReceiver: true, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 42413, 43070);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_42601_42624(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42601, 42624);
                    return return_v;
                }


                bool
                f_10292_42735_42755(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42735, 42755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_42759_42785(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42759, 42785);
                    return return_v;
                }


                bool
                f_10292_42759_42801(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42759, 42801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_42962_42985(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 42962, 42985);
                    return return_v;
                }


                bool
                f_10292_42941_43058(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 42941, 43058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 42413, 43070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 42413, 43070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckFieldLikeEventRefEscape(SyntaxNode node, BoundEventAccess eventAccess, uint escapeFrom, uint escapeTo, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 43082, 43761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 43261, 43303);

                var
                eventSymbol = f_10292_43279_43302(eventAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 43422, 43553) || true) && (f_10292_43426_43446(eventSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 43426, 43492) || f_10292_43450_43492(f_10292_43450_43476(eventSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 43422, 43553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 43526, 43538);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 43422, 43553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 43625, 43750);

                return f_10292_43632_43749(node, f_10292_43653_43676(eventAccess), escapeFrom, escapeTo, checkingReceiver: true, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 43082, 43761);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10292_43279_43302(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 43279, 43302);
                    return return_v;
                }


                bool
                f_10292_43426_43446(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 43426, 43446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_43450_43476(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 43450, 43476);
                    return return_v;
                }


                bool
                f_10292_43450_43492(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 43450, 43492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_43653_43676(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 43653, 43676);
                    return return_v;
                }


                bool
                f_10292_43632_43749(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 43632, 43749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 43082, 43761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 43082, 43761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckEventValueKind(BoundEventAccess boundEvent, BindValueKind valueKind, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 43773, 47239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 44346, 44396);

                BoundExpression
                receiver = f_10292_44373_44395(boundEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 44410, 44460);

                SyntaxNode
                eventSyntax = f_10292_44435_44459(boundEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 44502, 44551);

                EventSymbol
                eventSymbol = f_10292_44528_44550(boundEvent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 44567, 47228) || true) && (valueKind == BindValueKind.CompoundAssignment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 44567, 47228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 44942, 45249) || true) && (f_10292_44946_45009(eventSymbol, diagnostics, eventSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 44942, 45249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45217, 45230);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 44942, 45249);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45269, 45332);

                    f_10292_45269_45331(!f_10292_45283_45330(receiver, eventSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45350, 45362);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 44567, 47228);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 44567, 47228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45428, 47181) || true) && (f_10292_45432_45459_M(!boundEvent.IsUsableAsField))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 45428, 47181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45659, 45736);

                        f_10292_45659_45735(diagnostics, f_10292_45678_45721(this, eventSymbol), eventSyntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45758, 45771);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 45428, 47181);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 45428, 47181);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45813, 47181) || true) && (f_10292_45817_45880(eventSymbol, diagnostics, eventSyntax))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 45813, 47181);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 45922, 46106) || true) && (!f_10292_45927_46020(this, eventSyntax, receiver, BindValueKind.Assignable, diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 45922, 46106);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46070, 46083);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 45922, 46106);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 45813, 47181);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 45813, 47181);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46148, 47181) || true) && (f_10292_46152_46179(valueKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 46148, 47181);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46221, 47162) || true) && (f_10292_46225_46258(eventSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 46225, 46299) && valueKind != BindValueKind.Assignable))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 46221, 47162);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46564, 46696);

                                    ErrorCode
                                    errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 46586, 46621) || ((valueKind == BindValueKind.RefOrOut && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 46624, 46659)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 46662, 46695))) ? ErrorCode.ERR_WinRtEventPassedByRef : f_10292_46662_46695(valueKind)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46722, 46778);

                                    f_10292_46722_46777(diagnostics, errorCode, eventSyntax, eventSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46806, 46819);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 46221, 47162);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 46221, 47162);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 46869, 47162) || true) && (f_10292_46873_46936(receiver, f_10292_46908_46935(eventSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 46873, 47076) && !f_10292_46998_47076(this, eventSyntax, receiver, valueKind, diagnostics)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 46869, 47162);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 47126, 47139);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 46869, 47162);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 46221, 47162);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 46148, 47181);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 45813, 47181);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 45428, 47181);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 47201, 47213);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 44567, 47228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 43773, 47239);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_44373_44395(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 44373, 44395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10292_44435_44459(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                expr)
                {
                    var return_v = GetEventName(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 44435, 44459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10292_44528_44550(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 44528, 44550);
                    return return_v;
                }


                bool
                f_10292_44946_45009(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 44946, 45009);
                    return return_v;
                }


                bool
                f_10292_45283_45330(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = RequiresVariableReceiver(receiver, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45283, 45330);
                    return return_v;
                }


                int
                f_10292_45269_45331(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45269, 45331);
                    return 0;
                }


                bool
                f_10292_45432_45459_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 45432, 45459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10292_45678_45721(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                eventSymbol)
                {
                    var return_v = this_param.GetBadEventUsageDiagnosticInfo(eventSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45678, 45721);
                    return return_v;
                }


                int
                f_10292_45659_45735(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, info, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45659, 45735);
                    return 0;
                }


                bool
                f_10292_45817_45880(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45817, 45880);
                    return return_v;
                }


                bool
                f_10292_45927_46020(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckIsValidReceiverForVariable(node, receiver, kind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 45927, 46020);
                    return return_v;
                }


                bool
                f_10292_46152_46179(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 46152, 46179);
                    return return_v;
                }


                bool
                f_10292_46225_46258(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 46225, 46258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_46662_46695(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 46662, 46695);
                    return return_v;
                }


                int
                f_10292_46722_46777(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 46722, 46777);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10292_46908_46935(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 46908, 46935);
                    return return_v;
                }


                bool
                f_10292_46873_46936(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                symbol)
                {
                    var return_v = RequiresVariableReceiver(receiver, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 46873, 46936);
                    return return_v;
                }


                bool
                f_10292_46998_47076(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckIsValidReceiverForVariable(node, receiver, kind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 46998, 47076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 43773, 47239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 43773, 47239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckIsValidReceiverForVariable(SyntaxNode node, BoundExpression receiver, BindValueKind kind, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 47251, 47666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 47410, 47441);

                f_10292_47410_47440(receiver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 47455, 47655);

                return f_10292_47462_47513(Flags, BinderFlags.ObjectInitializerMember) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 47462, 47578) && f_10292_47517_47530(receiver) == BoundKind.ObjectOrCollectionValuePlaceholder) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 47462, 47654) || f_10292_47599_47654(this, node, receiver, kind, true, diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 47251, 47666);

                int
                f_10292_47410_47440(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 47410, 47440);
                    return 0;
                }


                bool
                f_10292_47462_47513(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 47462, 47513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_47517_47530(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 47517, 47530);
                    return return_v;
                }


                bool
                f_10292_47599_47654(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node, expr, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 47599, 47654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 47251, 47666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 47251, 47666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresVariableReceiver(BoundExpression receiver, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 48496, 48873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 48629, 48862);

                return f_10292_48636_48669(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 48636, 48721) && f_10292_48690_48701(symbol) != SymbolKind.Event
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 48636, 48758) && receiver != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 48636, 48807) && !f_10292_48781_48807(f_10292_48781_48794(receiver), null)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 48636, 48861) && f_10292_48828_48853(f_10292_48828_48841(receiver)) == true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 48496, 48873);

                bool
                f_10292_48636_48669(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 48636, 48669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_48690_48701(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 48690, 48701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_48781_48794(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 48781, 48794);
                    return return_v;
                }


                bool
                f_10292_48781_48807(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 48781, 48807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_48828_48841(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 48828, 48841);
                    return return_v;
                }


                bool
                f_10292_48828_48853(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 48828, 48853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 48496, 48873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 48496, 48873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckCallValueKind(BoundCall call, SyntaxNode node, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 49038, 49141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 49041, 49141);
                return f_10292_49041_49141(this, f_10292_49068_49079(call), call.Syntax, node, valueKind, checkingReceiver, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 49038, 49141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 49038, 49141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 49038, 49141);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10292_49068_49079(Microsoft.CodeAnalysis.CSharp.BoundCall
            this_param)
            {
                var return_v = this_param.Method;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 49068, 49079);
                return return_v;
            }


            bool
            f_10292_49041_49141(Microsoft.CodeAnalysis.CSharp.Binder
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
            callSyntaxOpt, Microsoft.CodeAnalysis.SyntaxNode
            node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
            valueKind, bool
            checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.CheckMethodReturnValueKind(methodSymbol, callSyntaxOpt, node, valueKind, checkingReceiver, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 49041, 49141);
                return return_v;
            }

        }

        protected bool CheckMethodReturnValueKind(
                    MethodSymbol methodSymbol,
                    SyntaxNode callSyntaxOpt,
                    SyntaxNode node,
                    BindValueKind valueKind,
                    bool checkingReceiver,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 49154, 50900);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 49841, 50389) || true) && (f_10292_49845_49872(valueKind) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 49845, 49912) && f_10292_49876_49896(methodSymbol) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 49841, 50389);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 49946, 50341) || true) && (checkingReceiver)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 49946, 50341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50101, 50180);

                        f_10292_50101_50179(diagnostics, ErrorCode.ERR_ReturnNotLValue, callSyntaxOpt, methodSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 49946, 50341);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 49946, 50341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50262, 50322);

                        f_10292_50262_50321(diagnostics, f_10292_50281_50314(valueKind), node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 49946, 50341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50361, 50374);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 49841, 50389);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50405, 50655) || true) && (f_10292_50409_50446(valueKind) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 50409, 50493) && f_10292_50450_50470(methodSymbol) == RefKind.RefReadOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 50405, 50655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50527, 50609);

                    f_10292_50527_50608(methodSymbol, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50627, 50640);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 50405, 50655);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50671, 50859) || true) && (f_10292_50675_50715(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 50671, 50859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50749, 50813);

                    f_10292_50749_50812(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50831, 50844);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 50671, 50859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 50875, 50887);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 49154, 50900);

                bool
                f_10292_49845_49872(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 49845, 49872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_49876_49896(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 49876, 49896);
                    return return_v;
                }


                int
                f_10292_50101_50179(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50101, 50179);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_50281_50314(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50281, 50314);
                    return return_v;
                }


                int
                f_10292_50262_50321(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50262, 50321);
                    return 0;
                }


                bool
                f_10292_50409_50446(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50409, 50446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_50450_50470(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 50450, 50470);
                    return return_v;
                }


                int
                f_10292_50527_50608(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadOnlyError((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50527, 50608);
                    return 0;
                }


                bool
                f_10292_50675_50715(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50675, 50715);
                    return return_v;
                }


                int
                f_10292_50749_50812(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 50749, 50812);
                    return 0;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 49154, 50900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 49154, 50900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckPropertyValueKind(SyntaxNode node, BoundExpression expr, BindValueKind valueKind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 50912, 59912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51388, 51413);

                BoundExpression
                receiver
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51427, 51453);

                SyntaxNode
                propertySyntax
                = default(SyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51467, 51546);

                var
                propertySymbol = f_10292_51488_51545(expr, out receiver, out propertySyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51562, 51607);

                f_10292_51562_51606((object)propertySymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51621, 51658);

                f_10292_51621_51657(propertySyntax != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51674, 52688) || true) && ((f_10292_51679_51717(valueKind) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 51679, 51737) || checkingReceiver)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 51678, 51797) && f_10292_51759_51781(propertySymbol) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 51674, 52688);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 51831, 52640) || true) && (checkingReceiver)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 51831, 52640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52239, 52296);

                        f_10292_52239_52295(propertySymbol.TypeWithAnnotations.HasType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52318, 52397);

                        f_10292_52318_52396(diagnostics, ErrorCode.ERR_ReturnNotLValue, expr.Syntax, propertySymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 51831, 52640);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 51831, 52640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52479, 52621);

                        f_10292_52479_52620(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 52498, 52533) || ((valueKind == BindValueKind.RefOrOut && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 52536, 52561)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 52564, 52597))) ? ErrorCode.ERR_RefProperty : f_10292_52564_52597(valueKind), node, propertySymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 51831, 52640);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52660, 52673);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 51674, 52688);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52704, 52958) || true) && (f_10292_52708_52745(valueKind) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 52708, 52794) && f_10292_52749_52771(propertySymbol) == RefKind.RefReadOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 52704, 52958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52828, 52912);

                    f_10292_52828_52911(propertySymbol, node, valueKind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52930, 52943);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 52704, 52958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 52974, 53072);

                var
                requiresSet = f_10292_52992_53029(valueKind) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 52992, 53071) && f_10292_53033_53055(propertySymbol) == RefKind.None)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53086, 56354) || true) && (requiresSet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53086, 56354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53135, 53195);

                    var
                    setMethod = f_10292_53151_53194(propertySymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53215, 56339) || true) && (setMethod is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53215, 56339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53278, 53325);

                        var
                        containing = f_10292_53295_53324(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53347, 53611) || true) && (!f_10292_53352_53426(receiver, propertySymbol, containing))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53347, 53611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53476, 53549);

                            f_10292_53476_53548(diagnostics, ErrorCode.ERR_AssgReadonlyProp, node, propertySymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53575, 53588);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53347, 53611);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53215, 56339);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53215, 56339);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53693, 54384) || true) && (f_10292_53697_53717(setMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53693, 54384);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53767, 54005) || true) && (!f_10292_53772_53802(receiver))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 53767, 54005);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53860, 53935);

                                f_10292_53860_53934(diagnostics, ErrorCode.ERR_AssignmentInitOnly, node, propertySymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 53965, 53978);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53767, 54005);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54033, 54361) || true) && (f_10292_54037_54067(setMethod) != f_10292_54071_54087(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 54033, 54361);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54252, 54334);

                                f_10292_54252_54333(node, MessageID.IDS_FeatureInitOnlySetters, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 54033, 54361);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53693, 54384);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54408, 54468);

                        var
                        accessThroughType = f_10292_54432_54467(this, receiver)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54490, 54518);

                        bool
                        failedThroughTypeCheck
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54540, 54590);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54612, 54732);

                        bool
                        isAccessible = f_10292_54632_54731(this, setMethod, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54754, 54796);

                        f_10292_54754_54795(diagnostics, node, useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54820, 55364) || true) && (!isAccessible)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 54820, 55364);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54887, 55302) || true) && (failedThroughTypeCheck)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 54887, 55302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 54971, 55086);

                                f_10292_54971_55085(diagnostics, ErrorCode.ERR_BadProtectedAccess, node, propertySymbol, accessThroughType, f_10292_55065_55084(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 54887, 55302);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 54887, 55302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55200, 55275);

                                f_10292_55200_55274(diagnostics, ErrorCode.ERR_InaccessibleSetter, node, propertySymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 54887, 55302);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55328, 55341);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 54820, 55364);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55388, 55489);

                        f_10292_55388_55488(this, diagnostics, setMethod, node, f_10292_55446_55460_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiver, 10292, 55446, 55460)?.Kind) == BoundKind.BaseReference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55513, 55614);

                        var
                        setValueKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 55532, 55563) || ((f_10292_55532_55563(setMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 55566, 55586)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 55589, 55613))) ? BindValueKind.RValue : BindValueKind.Assignable
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55636, 55850) || true) && (f_10292_55640_55685(receiver, setMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 55640, 55764) && !f_10292_55690_55764(this, node, receiver, setValueKind, diagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 55636, 55850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55814, 55827);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 55636, 55850);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 55874, 56221) || true) && (f_10292_55878_55949(this, node, receiver, setMethod, diagnostics, propertySymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 55878, 56135) || (!f_10292_55980_56066(f_10292_55994_56026(setMethod), f_10292_56028_56065(propertySymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 55979, 56134) && f_10292_56070_56134(setMethod, diagnostics, propertySyntax)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 55874, 56221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56185, 56198);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 55874, 56221);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56245, 56320);

                        f_10292_56245_56319(this, node, receiver, setMethod, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53215, 56339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 53086, 56354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56370, 56465);

                var
                requiresGet = !f_10292_56389_56422(valueKind) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 56388, 56464) || f_10292_56426_56448(propertySymbol) != RefKind.None)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56479, 58548) || true) && (requiresGet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 56479, 58548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56528, 56588);

                    var
                    getMethod = f_10292_56544_56587(propertySymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56608, 58533) || true) && ((object)getMethod == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 56608, 58533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56679, 56752);

                        f_10292_56679_56751(diagnostics, ErrorCode.ERR_PropertyLacksGet, node, propertySymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56774, 56787);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 56608, 58533);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 56608, 58533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56869, 56929);

                        var
                        accessThroughType = f_10292_56893_56928(this, receiver)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 56951, 56979);

                        bool
                        failedThroughTypeCheck
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57001, 57051);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57073, 57193);

                        bool
                        isAccessible = f_10292_57093_57192(this, getMethod, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57215, 57257);

                        f_10292_57215_57256(diagnostics, node, useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57281, 57825) || true) && (!isAccessible)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 57281, 57825);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57348, 57763) || true) && (failedThroughTypeCheck)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 57348, 57763);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57432, 57547);

                                f_10292_57432_57546(diagnostics, ErrorCode.ERR_BadProtectedAccess, node, propertySymbol, accessThroughType, f_10292_57526_57545(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 57348, 57763);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 57348, 57763);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57661, 57736);

                                f_10292_57661_57735(diagnostics, ErrorCode.ERR_InaccessibleGetter, node, propertySymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 57348, 57763);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57789, 57802);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 57281, 57825);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57849, 57921);

                        f_10292_57849_57920(this, receiver, getMethod, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 57943, 58044);

                        f_10292_57943_58043(this, diagnostics, getMethod, node, f_10292_58001_58015_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiver, 10292, 58001, 58015)?.Kind) == BoundKind.BaseReference);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58068, 58415) || true) && (f_10292_58072_58143(this, node, receiver, getMethod, diagnostics, propertySymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 58072, 58329) || (!f_10292_58174_58260(f_10292_58188_58220(getMethod), f_10292_58222_58259(propertySymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 58173, 58328) && f_10292_58264_58328(getMethod, diagnostics, propertySyntax)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 58068, 58415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58379, 58392);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 58068, 58415);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58439, 58514);

                        f_10292_58439_58513(this, node, receiver, getMethod, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 56608, 58533);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 56479, 58548);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58564, 58752) || true) && (f_10292_58568_58608(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 58564, 58752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58642, 58706);

                    f_10292_58642_58705(diagnostics, ErrorCode.ERR_RefLocalOrParamExpected, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58724, 58737);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 58564, 58752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 58768, 58780);

                return true;

                bool isAllowedInitOnlySet(BoundExpression receiver)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 58796, 59901);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59001, 59162) || true) && (receiver is BoundObjectOrCollectionValuePlaceholder placeholder)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 59001, 59162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59110, 59143);

                            return f_10292_59117_59142(placeholder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 59001, 59162);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59236, 59381) || true) && (!(receiver is BoundThisReference || (DynAbs.Tracing.TraceSender.Expression_False(10292, 59242, 59306) || receiver is BoundBaseReference)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 59236, 59381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59349, 59362);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 59236, 59381);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59401, 59449);

                        var
                        containingMember = f_10292_59424_59448()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59467, 59587) || true) && (!(containingMember is MethodSymbol method))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 59467, 59587);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59555, 59568);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 59467, 59587);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59607, 59853) || true) && (f_10292_59611_59628(method) == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10292, 59611, 59675) || f_10292_59658_59675(method)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 59607, 59853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59822, 59834);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 59607, 59853);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 59873, 59886);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 58796, 59901);

                        bool
                        f_10292_59117_59142(Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                        this_param)
                        {
                            var return_v = this_param.IsNewInstance;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 59117, 59142);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10292_59424_59448()
                        {
                            var return_v = ContainingMemberOrLambda;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 59424, 59448);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10292_59611_59628(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 59611, 59628);
                            return return_v;
                        }


                        bool
                        f_10292_59658_59675(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsInitOnly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 59658, 59675);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 58796, 59901);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 58796, 59901);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 50912, 59912);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_51488_51545(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.SyntaxNode
                propertySyntax)
                {
                    var return_v = GetPropertySymbol(expr, out receiver, out propertySyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 51488, 51545);
                    return return_v;
                }


                int
                f_10292_51562_51606(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 51562, 51606);
                    return 0;
                }


                int
                f_10292_51621_51657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 51621, 51657);
                    return 0;
                }


                bool
                f_10292_51679_51717(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresReferenceToLocation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 51679, 51717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_51759_51781(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 51759, 51781);
                    return return_v;
                }


                int
                f_10292_52239_52295(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52239, 52295);
                    return 0;
                }


                int
                f_10292_52318_52396(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52318, 52396);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_52564_52597(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52564, 52597);
                    return return_v;
                }


                int
                f_10292_52479_52620(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52479, 52620);
                    return 0;
                }


                bool
                f_10292_52708_52745(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52708, 52745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_52749_52771(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 52749, 52771);
                    return return_v;
                }


                int
                f_10292_52828_52911(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportReadOnlyError((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, kind, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52828, 52911);
                    return 0;
                }


                bool
                f_10292_52992_53029(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 52992, 53029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_53033_53055(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 53033, 53055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10292_53151_53194(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 53151, 53194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10292_53295_53324(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 53295, 53324);
                    return return_v;
                }


                bool
                f_10292_53352_53426(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertySymbol, Microsoft.CodeAnalysis.CSharp.Symbol?
                fromMember)
                {
                    var return_v = AccessingAutoPropertyFromConstructor(receiver, propertySymbol, fromMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 53352, 53426);
                    return return_v;
                }


                int
                f_10292_53476_53548(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 53476, 53548);
                    return 0;
                }


                bool
                f_10292_53697_53717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 53697, 53717);
                    return return_v;
                }


                bool
                f_10292_53772_53802(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = isAllowedInitOnlySet(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 53772, 53802);
                    return return_v;
                }


                int
                f_10292_53860_53934(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 53860, 53934);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10292_54037_54067(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 54037, 54067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10292_54071_54087(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 54071, 54087);
                    return return_v;
                }


                bool
                f_10292_54252_54333(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability(syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 54252, 54333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_54432_54467(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.GetAccessThroughType(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 54432, 54467);
                    return return_v;
                }


                bool
                f_10292_54632_54731(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 54632, 54731);
                    return return_v;
                }


                bool
                f_10292_54754_54795(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 54754, 54795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10292_55065_55084(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 55065, 55084);
                    return return_v;
                }


                int
                f_10292_54971_55085(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 54971, 55085);
                    return 0;
                }


                int
                f_10292_55200_55274(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55200, 55274);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10292_55446_55460_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 55446, 55460);
                    return return_v;
                }


                int
                f_10292_55388_55488(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55388, 55488);
                    return 0;
                }


                bool
                f_10292_55532_55563(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsEffectivelyReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 55532, 55563);
                    return return_v;
                }


                bool
                f_10292_55640_55685(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = RequiresVariableReceiver(receiver, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55640, 55685);
                    return return_v;
                }


                bool
                f_10292_55690_55764(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckIsValidReceiverForVariable(node, receiver, kind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55690, 55764);
                    return return_v;
                }


                bool
                f_10292_55878_55949(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyOrEventSymbolOpt)
                {
                    var return_v = this_param.IsBadBaseAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)member, diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEventSymbolOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55878, 55949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10292_55994_56026(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55994, 56026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10292_56028_56065(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56028, 56065);
                    return return_v;
                }


                bool
                f_10292_55980_56066(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 55980, 56066);
                    return return_v;
                }


                bool
                f_10292_56070_56134(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56070, 56134);
                    return return_v;
                }


                int
                f_10292_56245_56319(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckRuntimeSupportForSymbolAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56245, 56319);
                    return 0;
                }


                bool
                f_10292_56389_56422(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignmentOnly(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56389, 56422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_56426_56448(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 56426, 56448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10292_56544_56587(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56544, 56587);
                    return return_v;
                }


                int
                f_10292_56679_56751(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56679, 56751);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_56893_56928(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.GetAccessThroughType(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 56893, 56928);
                    return return_v;
                }


                bool
                f_10292_57093_57192(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57093, 57192);
                    return return_v;
                }


                bool
                f_10292_57215_57256(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57215, 57256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10292_57526_57545(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 57526, 57545);
                    return return_v;
                }


                int
                f_10292_57432_57546(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57432, 57546);
                    return 0;
                }


                int
                f_10292_57661_57735(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57661, 57735);
                    return 0;
                }


                bool
                f_10292_57849_57920(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckImplicitThisCopyInReadOnlyMember(receiver, method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57849, 57920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10292_58001_58015_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 58001, 58015);
                    return return_v;
                }


                int
                f_10292_57943_58043(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 57943, 58043);
                    return 0;
                }


                bool
                f_10292_58072_58143(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyOrEventSymbolOpt)
                {
                    var return_v = this_param.IsBadBaseAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)member, diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEventSymbolOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58072, 58143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10292_58188_58220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58188, 58220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10292_58222_58259(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58222, 58259);
                    return return_v;
                }


                bool
                f_10292_58174_58260(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58174, 58260);
                    return return_v;
                }


                bool
                f_10292_58264_58328(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58264, 58328);
                    return return_v;
                }


                int
                f_10292_58439_58513(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckRuntimeSupportForSymbolAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58439, 58513);
                    return 0;
                }


                bool
                f_10292_58568_58608(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58568, 58608);
                    return return_v;
                }


                int
                f_10292_58642_58705(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 58642, 58705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 50912, 59912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 50912, 59912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsBadBaseAccess(SyntaxNode node, BoundExpression receiverOpt, Symbol member, DiagnosticBag diagnostics,
                                             Symbol propertyOrEventSymbolOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 59924, 60549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60143, 60192);

                f_10292_60143_60191(f_10292_60156_60167(member) != SymbolKind.Property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60206, 60252);

                f_10292_60206_60251(f_10292_60219_60230(member) != SymbolKind.Event);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60268, 60509) || true) && (f_10292_60272_60289_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiverOpt, 10292, 60272, 60289)?.Kind) == BoundKind.BaseReference && (DynAbs.Tracing.TraceSender.Expression_True(10292, 60272, 60337) && f_10292_60320_60337(member)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 60268, 60509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60371, 60464);

                    f_10292_60371_60463(diagnostics, ErrorCode.ERR_AbstractBaseCall, node, propertyOrEventSymbolOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10292, 60428, 60462) ?? member));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60482, 60494);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 60268, 60509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 60525, 60538);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 59924, 60549);

                Microsoft.CodeAnalysis.SymbolKind
                f_10292_60156_60167(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 60156, 60167);
                    return return_v;
                }


                int
                f_10292_60143_60191(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 60143, 60191);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_60219_60230(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 60219, 60230);
                    return return_v;
                }


                int
                f_10292_60206_60251(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 60206, 60251);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10292_60272_60289_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 60272, 60289);
                    return return_v;
                }


                bool
                f_10292_60320_60337(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 60320, 60337);
                    return return_v;
                }


                int
                f_10292_60371_60463(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 60371, 60463);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 59924, 60549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 59924, 60549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Computes the scope to which the given invocation can escape
        /// NOTE: the escape scope for ref and val escapes is the same for invocations except for trivial cases (ordinary type returned by val) 
        ///       where escape is known otherwise. Therefore we do not vave two ref/val variants of this.
        ///       
        /// NOTE: we need scopeOfTheContainingExpression as some expressions such as optional <c>in</c> parameters or <c>ref dynamic</c> behave as 
        ///       local variables declared at the scope of the invocation.
        /// </summary>
        internal static uint GetInvocationEscapeScope(
            Symbol symbol,
            BoundExpression receiverOpt,
            ImmutableArray<ParameterSymbol> parameters,
            ImmutableArray<BoundExpression> argsOpt,
            ImmutableArray<RefKind> argRefKindsOpt,
            ImmutableArray<int> argsToParamsOpt,
            uint scopeOfTheContainingExpression,
            bool isRefEscape
        )
        {
            // SPEC: (also applies to the CheckInvocationEscape counterpart)
            //
            //            An lvalue resulting from a ref-returning method invocation e1.M(e2, ...) is ref-safe - to - escape the smallest of the following scopes:
            //•	The entire enclosing method
            //•	the ref-safe-to-escape of all ref/out/in argument expressions(excluding the receiver)
            //•	the safe-to - escape of all argument expressions(including the receiver)
            //
            //            An rvalue resulting from a method invocation e1.M(e2, ...) is safe - to - escape from the smallest of the following scopes:
            //•	The entire enclosing method
            //•	the safe-to-escape of all argument expressions(including the receiver)
            //

            if (!symbol.RequiresInstanceReceiver())
            {
                // ignore receiver when symbol is static
                receiverOpt = null;
            }

            //by default it is safe to escape
            uint escapeScope = Binder.ExternalScope;

            ArrayBuilder<bool> inParametersMatchedWithArgs = null;

            if (!argsOpt.IsDefault)
            {
moreArguments:
                for (var argIndex = 0; argIndex < argsOpt.Length; argIndex++)
                {
                    var argument = argsOpt[argIndex];
                    if (argument.Kind == BoundKind.ArgListOperator)
                    {
                        Debug.Assert(argIndex == argsOpt.Length - 1, "vararg must be the last");
                        var argList = (BoundArgListOperator)argument;

                        // unwrap varargs and process as more arguments
                        argsOpt = argList.Arguments;
                        // ref kinds of varargs are not interesting here. 
                        // __refvalue is not ref-returnable, so ref varargs can't come back from a call
                        argRefKindsOpt = default;
                        parameters = ImmutableArray<ParameterSymbol>.Empty;
                        argsToParamsOpt = default;

                        goto moreArguments;
                    }

                    RefKind effectiveRefKind = GetEffectiveRefKindAndMarkMatchedInParameter(argIndex, argRefKindsOpt, parameters, argsToParamsOpt, ref inParametersMatchedWithArgs);

                    // ref escape scope is the narrowest of 
                    // - ref escape of all byref arguments
                    // - val escape of all byval arguments  (ref-like values can be unwrapped into refs, so treat val escape of values as possible ref escape of the result)
                    //
                    // val escape scope is the narrowest of 
                    // - val escape of all byval arguments  (refs cannot be wrapped into values, so their ref escape is irrelevant, only use val escapes)

                    var argEscape = effectiveRefKind != RefKind.None && isRefEscape ?
                                        GetRefEscape(argument, scopeOfTheContainingExpression) :
                                        GetValEscape(argument, scopeOfTheContainingExpression);

                    escapeScope = Math.Max(escapeScope, argEscape);

                    if (escapeScope >= scopeOfTheContainingExpression)
                    {
                        // no longer needed
                        inParametersMatchedWithArgs?.Free();

                        // can't get any worse
                        return escapeScope;
                    }
                }
            }

            // handle omitted optional "in" parameters if there are any
            ParameterSymbol unmatchedInParameter = TryGetunmatchedInParameterAndFreeMatchedArgs(parameters, ref inParametersMatchedWithArgs);

            // unmatched "in" parameter is the same as a literal, its ref escape is scopeOfTheContainingExpression  (can't get any worse)
            //                                                    its val escape is ExternalScope                   (does not affect overall result)
            if (unmatchedInParameter != null && isRefEscape)
            {
                return scopeOfTheContainingExpression;
            }

            // check receiver if ref-like
            // LAFHIS
            if (receiverOpt != null && !receiverOpt.Type.Equals(null) && receiverOpt.Type.IsRefLikeType)
            {
                escapeScope = Math.Max(escapeScope, GetValEscape(receiverOpt, scopeOfTheContainingExpression));
            }

            return escapeScope;
        }

        /// <summary>
        /// Validates whether given invocation can allow its results to escape from <paramref name="escapeFrom"/> level to <paramref name="escapeTo"/> level.
        /// The result indicates whether the escape is possible. 
        /// Additionally, the method emits diagnostics (possibly more than one, recursively) that would help identify the cause for the failure.
        /// 
        /// NOTE: we need scopeOfTheContainingExpression as some expressions such as optional <c>in</c> parameters or <c>ref dynamic</c> behave as 
        ///       local variables declared at the scope of the invocation.
        /// </summary>
        private static bool CheckInvocationEscape(
            SyntaxNode syntax,
            Symbol symbol,
            BoundExpression receiverOpt,
            ImmutableArray<ParameterSymbol> parameters,
            ImmutableArray<BoundExpression> argsOpt,
            ImmutableArray<RefKind> argRefKindsOpt,
            ImmutableArray<int> argsToParamsOpt,
            bool checkingReceiver,
            uint escapeFrom,
            uint escapeTo,
            DiagnosticBag diagnostics,
            bool isRefEscape
        )
        {
            // SPEC: 
            //            In a method invocation, the following constraints apply:
            //•	If there is a ref or out argument to a ref struct type (including the receiver), with safe-to-escape E1, then
            //  o no ref or out argument(excluding the receiver and arguments of ref-like types) may have a narrower ref-safe-to-escape than E1; and
            //  o   no argument(including the receiver) may have a narrower safe-to-escape than E1.

            if (!symbol.RequiresInstanceReceiver())
            {
                // ignore receiver when symbol is static
                receiverOpt = null;
            }

            ArrayBuilder<bool> inParametersMatchedWithArgs = null;

            if (!argsOpt.IsDefault)
            {

moreArguments:
                for (var argIndex = 0; argIndex < argsOpt.Length; argIndex++)
                {
                    var argument = argsOpt[argIndex];
                    if (argument.Kind == BoundKind.ArgListOperator)
                    {
                        Debug.Assert(argIndex == argsOpt.Length - 1, "vararg must be the last");
                        var argList = (BoundArgListOperator)argument;

                        // unwrap varargs and process as more arguments
                        argsOpt = argList.Arguments;
                        // ref kinds of varargs are not interesting here. 
                        // __refvalue is not ref-returnable, so ref varargs can't come back from a call
                        argRefKindsOpt = default;
                        parameters = ImmutableArray<ParameterSymbol>.Empty;
                        argsToParamsOpt = default;

                        goto moreArguments;
                    }

                    RefKind effectiveRefKind = GetEffectiveRefKindAndMarkMatchedInParameter(argIndex, argRefKindsOpt, parameters, argsToParamsOpt, ref inParametersMatchedWithArgs);

                    // ref escape scope is the narrowest of 
                    // - ref escape of all byref arguments
                    // - val escape of all byval arguments  (ref-like values can be unwrapped into refs, so treat val escape of values as possible ref escape of the result)
                    //
                    // val escape scope is the narrowest of 
                    // - val escape of all byval arguments  (refs cannot be wrapped into values, so their ref escape is irrelevant, only use val escapes)
                    var valid = effectiveRefKind != RefKind.None && isRefEscape ?
                                        CheckRefEscape(argument.Syntax, argument, escapeFrom, escapeTo, false, diagnostics) :
                                        CheckValEscape(argument.Syntax, argument, escapeFrom, escapeTo, false, diagnostics);

                    if (!valid)
                    {
                        // no longer needed
                        inParametersMatchedWithArgs?.Free();

                        ErrorCode errorCode = GetStandardCallEscapeError(checkingReceiver);

                        string parameterName;
                        if (parameters.Length > 0)
                        {
                            var paramIndex = argsToParamsOpt.IsDefault ? argIndex : argsToParamsOpt[argIndex];
                            parameterName = parameters[paramIndex].Name;

                            if (string.IsNullOrEmpty(parameterName))
                            {
                                parameterName = paramIndex.ToString();
                            }
                        }
                        else
                        {
                            parameterName = "__arglist";
                        }

                        Error(diagnostics, errorCode, syntax, symbol, parameterName);
                        return false;
                    }
                }
            }

            // handle omitted optional "in" parameters if there are any
            ParameterSymbol unmatchedInParameter = TryGetunmatchedInParameterAndFreeMatchedArgs(parameters, ref inParametersMatchedWithArgs);

            // unmatched "in" parameter is the same as a literal, its ref escape is scopeOfTheContainingExpression  (can't get any worse)
            //                                                    its val escape is ExternalScope                   (does not affect overall result)
            if (unmatchedInParameter != null && isRefEscape)
            {
                var parameterName = unmatchedInParameter.Name;
                if (string.IsNullOrEmpty(parameterName))
                {
                    parameterName = unmatchedInParameter.Ordinal.ToString();
                }
                Error(diagnostics, GetStandardCallEscapeError(checkingReceiver), syntax, symbol, parameterName);
                return false;
            }

            // check receiver if ref-like
            if (receiverOpt?.Type?.IsRefLikeType == true)
            {
                return CheckValEscape(receiverOpt.Syntax, receiverOpt, escapeFrom, escapeTo, false, diagnostics);
            }

            return true;
        }

        /// <summary>
        /// Validates whether the invocation is valid per no-mixing rules.
        /// Returns <see langword="false"/> when it is not valid and produces diagnostics (possibly more than one recursively) that helps to figure the reason.
        /// </summary>
        private static bool CheckInvocationArgMixing(
            SyntaxNode syntax,
            Symbol symbol,
            BoundExpression receiverOpt,
            ImmutableArray<ParameterSymbol> parameters,
            ImmutableArray<BoundExpression> argsOpt,
            ImmutableArray<int> argsToParamsOpt,
            uint scopeOfTheContainingExpression,
            DiagnosticBag diagnostics)
        {
            // SPEC:
            // In a method invocation, the following constraints apply:
            // - If there is a ref or out argument of a ref struct type (including the receiver), with safe-to-escape E1, then
            // - no argument (including the receiver) may have a narrower safe-to-escape than E1.

            if (!symbol.RequiresInstanceReceiver())
            {
                // ignore receiver when symbol is static
                receiverOpt = null;
            }

            // widest possible escape via writeable ref-like receiver or ref/out argument.
            uint escapeTo = scopeOfTheContainingExpression;

            // collect all writeable ref-like arguments, including receiver
            var receiverType = receiverOpt?.Type;
            if (receiverType?.IsRefLikeType == true && !isReceiverRefReadOnly(symbol))
            {
                escapeTo = GetValEscape(receiverOpt, scopeOfTheContainingExpression);
            }

            if (!argsOpt.IsDefault)
            {
                BoundArgListOperator argList = null;
                for (var argIndex = 0; argIndex < argsOpt.Length; argIndex++)
                {
                    var argument = argsOpt[argIndex];
                    if (argument.Kind == BoundKind.ArgListOperator)
                    {
                        Debug.Assert(argIndex == argsOpt.Length - 1, "vararg must be the last");
                        argList = (BoundArgListOperator)argument;
                        break;
                    }

                    var paramIndex = argsToParamsOpt.IsDefault ? argIndex : argsToParamsOpt[argIndex];
                    if (parameters[paramIndex].RefKind.IsWritableReference() && argument.Type?.IsRefLikeType == true)
                    {
                        escapeTo = Math.Min(escapeTo, GetValEscape(argument, scopeOfTheContainingExpression));
                    }
                }

                if (argList != null)
                {
                    var argListArgs = argList.Arguments;
                    var argListRefKindsOpt = argList.ArgumentRefKindsOpt;

                    for (var argIndex = 0; argIndex < argListArgs.Length; argIndex++)
                    {
                        var argument = argListArgs[argIndex];
                        var refKind = argListRefKindsOpt.IsDefault ? RefKind.None : argListRefKindsOpt[argIndex];
                        if (refKind.IsWritableReference() && argument.Type?.IsRefLikeType == true)
                        {
                            escapeTo = Math.Min(escapeTo, GetValEscape(argument, scopeOfTheContainingExpression));
                        }
                    }
                }
            }

            if (escapeTo == scopeOfTheContainingExpression)
            {
                // cannot fail. common case.
                return true;
            }

            if (!argsOpt.IsDefault)
            {
moreArguments:
                for (var argIndex = 0; argIndex < argsOpt.Length; argIndex++)
                {
                    // check val escape of all arguments
                    var argument = argsOpt[argIndex];
                    if (argument.Kind == BoundKind.ArgListOperator)
                    {
                        Debug.Assert(argIndex == argsOpt.Length - 1, "vararg must be the last");
                        var argList = (BoundArgListOperator)argument;

                        // unwrap varargs and process as more arguments
                        argsOpt = argList.Arguments;
                        parameters = ImmutableArray<ParameterSymbol>.Empty;
                        argsToParamsOpt = default;

                        goto moreArguments;
                    }

                    var valid = CheckValEscape(argument.Syntax, argument, scopeOfTheContainingExpression, escapeTo, false, diagnostics);

                    if (!valid)
                    {
                        string parameterName;
                        if (parameters.Length > 0)
                        {
                            var paramIndex = argsToParamsOpt.IsDefault ? argIndex : argsToParamsOpt[argIndex];
                            parameterName = parameters[paramIndex].Name;
                        }
                        else
                        {
                            parameterName = "__arglist";
                        }

                        Error(diagnostics, ErrorCode.ERR_CallArgMixing, syntax, symbol, parameterName);
                        return false;
                    }
                }
            }

            //NB: we do not care about unmatched "in" parameters here. 
            //    They have "outer" val escape, so cannot be worse than escapeTo.

            // check val escape of receiver if ref-like
            if (receiverOpt?.Type?.IsRefLikeType == true)
            {
                return CheckValEscape(receiverOpt.Syntax, receiverOpt, scopeOfTheContainingExpression, escapeTo, false, diagnostics);
            }

            return true;

            static bool isReceiverRefReadOnly(Symbol methodOrPropertySymbol) => methodOrPropertySymbol switch
            {
                MethodSymbol m => m.IsEffectivelyReadOnly,
                // TODO: val escape checks should be skipped for property accesses when
                // we can determine the only accessors being called are readonly.
                // For now we are pessimistic and check escape if any accessor is non-readonly.
                // Tracking in https://github.com/dotnet/roslyn/issues/35606
                PropertySymbol p => p.GetMethod?.IsEffectivelyReadOnly != false && p.SetMethod?.IsEffectivelyReadOnly != false,
                _ => throw ExceptionUtilities.UnexpectedValue(methodOrPropertySymbol)
            };
        }

        private static RefKind GetEffectiveRefKindAndMarkMatchedInParameter(
                    int argIndex,
                    ImmutableArray<RefKind> argRefKindsOpt,
                    ImmutableArray<ParameterSymbol> parameters,
                    ImmutableArray<int> argsToParamsOpt,
                    ref ArrayBuilder<bool> inParametersMatchedWithArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 80109, 81227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80454, 80544);

                var
                effectiveRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 80477, 80501) || ((argRefKindsOpt.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 80504, 80516)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 80519, 80543))) ? RefKind.None : argRefKindsOpt[argIndex]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80558, 81176) || true) && ((effectiveRefKind == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10292, 80563, 80629) || effectiveRefKind == RefKind.In)) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 80562, 80662) && argIndex < parameters.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 80558, 81176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80696, 80778);

                    var
                    paramIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 80713, 80738) || ((argsToParamsOpt.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 80741, 80749)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 80752, 80777))) ? argIndex : argsToParamsOpt[argIndex]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80798, 81161) || true) && (f_10292_80802_80832(parameters[paramIndex]) == RefKind.In)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 80798, 81161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80888, 80918);

                        effectiveRefKind = RefKind.In;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 80940, 81073);

                        inParametersMatchedWithArgs = inParametersMatchedWithArgs ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>>(10292, 80970, 81072) ?? f_10292_81001_81072(parameters.Length, fillWithValue: false));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81095, 81142);

                        inParametersMatchedWithArgs[paramIndex] = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 80798, 81161);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 80558, 81176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81192, 81216);

                return effectiveRefKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 80109, 81227);

                Microsoft.CodeAnalysis.RefKind
                f_10292_80802_80832(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 80802, 80832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_10292_81001_81072(int
                capacity, bool
                fillWithValue)
                {
                    var return_v = ArrayBuilder<bool>.GetInstance(capacity, fillWithValue: fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 81001, 81072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 80109, 81227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 80109, 81227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ParameterSymbol TryGetunmatchedInParameterAndFreeMatchedArgs(ImmutableArray<ParameterSymbol> parameters, ref ArrayBuilder<bool> inParametersMatchedWithArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 81584, 82760);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81816, 82493) || true) && (f_10292_81820_81841_M(!parameters.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 81816, 82493);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81892, 81897);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81883, 82474) || true) && (i < parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81922, 81925)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 81883, 82474))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 81883, 82474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 81975, 82005);

                                var
                                parameter = parameters[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82031, 82144) || true) && (f_10292_82035_82053(parameter))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 82031, 82144);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10292, 82111, 82117);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 82031, 82144);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82172, 82451) || true) && (f_10292_82176_82193(parameter) == RefKind.In && (DynAbs.Tracing.TraceSender.Expression_True(10292, 82176, 82279) && f_10292_82240_82271_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(inParametersMatchedWithArgs, 10292, 82240, 82271)?[i]) != true) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 82176, 82349) && f_10292_82312_82340(f_10292_82312_82326(parameter)) == false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 82172, 82451);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82407, 82424);

                                    return parameter;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 82172, 82451);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 592);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 592);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 81816, 82493);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82513, 82525);

                    return null;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10292, 82554, 82749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82594, 82630);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(inParametersMatchedWithArgs, 10292, 82594, 82629)?.Free(), 10292, 82622, 82629);
                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(inParametersMatchedWithArgs, 10292, 82594, 82629)?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 82622, 82629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82699, 82734);

                    inParametersMatchedWithArgs = null;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10292, 82554, 82749);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 81584, 82760);

                bool
                f_10292_81820_81841_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 81820, 81841);
                    return return_v;
                }


                bool
                f_10292_82035_82053(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 82035, 82053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_82176_82193(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 82176, 82193);
                    return return_v;
                }


                bool?
                f_10292_82240_82271_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 82240, 82271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_82312_82326(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 82312, 82326);
                    return return_v;
                }


                bool
                f_10292_82312_82340(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 82312, 82340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 81584, 82760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 81584, 82760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetStandardCallEscapeError(bool checkingReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 82772, 82961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 82871, 82950);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 82878, 82894) || ((checkingReceiver && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 82897, 82922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 82925, 82949))) ? ErrorCode.ERR_EscapeCall2 : ErrorCode.ERR_EscapeCall;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 82772, 82961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 82772, 82961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 82772, 82961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportReadonlyLocalError(SyntaxNode node, LocalSymbol local, BindValueKind kind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 82973, 84268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83148, 83184);

                f_10292_83148_83183((object)local != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83198, 83241);

                f_10292_83198_83240(kind != BindValueKind.RValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83257, 83273);

                MessageID
                cause
                = default(MessageID);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83287, 83772) || true) && (f_10292_83291_83306(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83287, 83772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83340, 83375);

                    cause = MessageID.IDS_FOREACHLOCAL;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83287, 83772);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83287, 83772);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83409, 83772) || true) && (f_10292_83413_83426(local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83409, 83772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83460, 83493);

                        cause = MessageID.IDS_USINGLOCAL;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83409, 83772);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83409, 83772);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83527, 83772) || true) && (f_10292_83531_83544(local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83527, 83772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83578, 83611);

                            cause = MessageID.IDS_FIXEDLOCAL;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83527, 83772);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 83527, 83772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83677, 83732);

                            f_10292_83677_83731(diagnostics, f_10292_83696_83724(kind), node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83750, 83757);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83527, 83772);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83409, 83772);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 83287, 83772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 83788, 84073);

                ErrorCode[]
                ReadOnlyLocalErrors =
                            {
                ErrorCode.ERR_RefReadonlyLocalCause,
                ErrorCode.ERR_AssgReadonlyLocalCause,

                ErrorCode.ERR_RefReadonlyLocal2Cause,
                ErrorCode.ERR_AssgReadonlyLocal2Cause
            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84089, 84163);

                int
                index = ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 84102, 84118) || ((checkingReceiver && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 84121, 84122)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 84125, 84126))) ? 2 : 0) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 84131, 84153) || ((f_10292_84131_84153(kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 84156, 84157)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 84160, 84161))) ? 0 : 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84179, 84257);

                f_10292_84179_84256(diagnostics, ReadOnlyLocalErrors[index], node, local, f_10292_84239_84255(cause));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 82973, 84268);

                int
                f_10292_83148_83183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 83148, 83183);
                    return 0;
                }


                int
                f_10292_83198_83240(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 83198, 83240);
                    return 0;
                }


                bool
                f_10292_83291_83306(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsForEach;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 83291, 83306);
                    return return_v;
                }


                bool
                f_10292_83413_83426(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsUsing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 83413, 83426);
                    return return_v;
                }


                bool
                f_10292_83531_83544(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsFixed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 83531, 83544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_83696_83724(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = GetStandardLvalueError(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 83696, 83724);
                    return return_v;
                }


                int
                f_10292_83677_83731(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 83677, 83731);
                    return 0;
                }


                bool
                f_10292_84131_84153(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefOrOut(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 84131, 84153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_84239_84255(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 84239, 84255);
                    return return_v;
                }


                int
                f_10292_84179_84256(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 84179, 84256);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 82973, 84268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 82973, 84268);
            }
        }

        private static ErrorCode GetThisLvalueError(BindValueKind kind, bool isValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 84280, 85471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84386, 85256);

                switch (kind)
                {

                    case BindValueKind.CompoundAssignment:
                    case BindValueKind.Assignable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84540, 84579);

                        return ErrorCode.ERR_AssgReadonlyLocal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);

                    case BindValueKind.RefOrOut:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84649, 84687);

                        return ErrorCode.ERR_RefReadonlyLocal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);

                    case BindValueKind.AddressOf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84758, 84793);

                        return ErrorCode.ERR_InvalidAddrOp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);

                    case BindValueKind.IncrementDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 84873, 84966);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 84880, 84891) || ((isValueType && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 84894, 84925)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 84928, 84965))) ? ErrorCode.ERR_AssgReadonlyLocal : ErrorCode.ERR_IncrementLvalueExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);

                    case BindValueKind.RefReturn:
                    case BindValueKind.ReadonlyRef:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85086, 85121);

                        return ErrorCode.ERR_RefReturnThis;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);

                    case BindValueKind.RefAssignable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 84386, 85256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85196, 85241);

                        return ErrorCode.ERR_RefLocalOrParamExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 84386, 85256);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85272, 85397) || true) && (f_10292_85276_85309(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 85272, 85397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85343, 85382);

                    return ErrorCode.ERR_RefLvalueExpected;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 85272, 85397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85413, 85460);

                throw f_10292_85419_85459(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 84280, 85471);

                bool
                f_10292_85276_85309(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresReferenceToLocation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 85276, 85309);
                    return return_v;
                }


                System.Exception
                f_10292_85419_85459(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 85419, 85459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 84280, 85471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 84280, 85471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetRangeLvalueError(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 85483, 86457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85572, 86235);

                switch (kind)
                {

                    case BindValueKind.Assignable:
                    case BindValueKind.CompoundAssignment:
                    case BindValueKind.IncrementDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 85572, 86235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85782, 85830);

                        return ErrorCode.ERR_QueryRangeVariableReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 85572, 86235);

                    case BindValueKind.AddressOf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 85572, 86235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 85901, 85936);

                        return ErrorCode.ERR_InvalidAddrOp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 85572, 86235);

                    case BindValueKind.RefReturn:
                    case BindValueKind.ReadonlyRef:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 85572, 86235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86056, 86100);

                        return ErrorCode.ERR_RefReturnRangeVariable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 85572, 86235);

                    case BindValueKind.RefAssignable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 85572, 86235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86175, 86220);

                        return ErrorCode.ERR_RefLocalOrParamExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 85572, 86235);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86251, 86383) || true) && (f_10292_86255_86288(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86251, 86383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86322, 86368);

                    return ErrorCode.ERR_QueryOutRefRangeVariable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86251, 86383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86399, 86446);

                throw f_10292_86405_86445(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 85483, 86457);

                bool
                f_10292_86255_86288(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresReferenceToLocation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 86255, 86288);
                    return return_v;
                }


                System.Exception
                f_10292_86405_86445(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 86405, 86445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 85483, 86457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 85483, 86457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetMethodGroupOrFunctionPointerLvalueError(BindValueKind valueKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 86469, 86859);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86586, 86720) || true) && (f_10292_86590_86628(valueKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86586, 86720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86662, 86705);

                    return ErrorCode.ERR_RefReadonlyLocalCause;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86586, 86720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86804, 86848);

                return ErrorCode.ERR_AssgReadonlyLocalCause;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 86469, 86859);

                bool
                f_10292_86590_86628(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresReferenceToLocation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 86590, 86628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 86469, 86859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 86469, 86859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetStandardLvalueError(BindValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 86871, 88016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 86963, 87801);

                switch (kind)
                {

                    case BindValueKind.CompoundAssignment:
                    case BindValueKind.Assignable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87117, 87157);

                        return ErrorCode.ERR_AssgLvalueExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);

                    case BindValueKind.AddressOf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87228, 87263);

                        return ErrorCode.ERR_InvalidAddrOp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);

                    case BindValueKind.IncrementDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87343, 87388);

                        return ErrorCode.ERR_IncrementLvalueExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);

                    case BindValueKind.FixedReceiver:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87463, 87501);

                        return ErrorCode.ERR_FixedNeedsLvalue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);

                    case BindValueKind.RefReturn:
                    case BindValueKind.ReadonlyRef:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87621, 87666);

                        return ErrorCode.ERR_RefReturnLvalueExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);

                    case BindValueKind.RefAssignable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 86963, 87801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87741, 87786);

                        return ErrorCode.ERR_RefLocalOrParamExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 86963, 87801);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87817, 87942) || true) && (f_10292_87821_87854(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 87817, 87942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87888, 87927);

                    return ErrorCode.ERR_RefLvalueExpected;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 87817, 87942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 87958, 88005);

                throw f_10292_87964_88004(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 86871, 88016);

                bool
                f_10292_87821_87854(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresReferenceToLocation(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 87821, 87854);
                    return return_v;
                }


                System.Exception
                f_10292_87964_88004(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 87964, 88004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 86871, 88016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 86871, 88016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetStandardRValueRefEscapeError(uint escapeTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 88028, 88314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88124, 88254) || true) && (escapeTo == Binder.ExternalScope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 88124, 88254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88194, 88239);

                    return ErrorCode.ERR_RefReturnLvalueExpected;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 88124, 88254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88270, 88303);

                return ErrorCode.ERR_EscapeOther;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 88028, 88314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 88028, 88314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 88028, 88314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportReadOnlyFieldError(FieldSymbol field, SyntaxNode node, BindValueKind kind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 88326, 90115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88501, 88537);

                f_10292_88501_88536((object)field != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88551, 88598);

                f_10292_88551_88597(f_10292_88564_88596(kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88612, 88653);

                f_10292_88612_88652(f_10292_88625_88635(field) != (object)null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88862, 89025) || true) && (kind == BindValueKind.AddressOf)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 88862, 89025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 88931, 88985);

                    f_10292_88931_88984(diagnostics, ErrorCode.ERR_InvalidAddrOp, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 89003, 89010);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 88862, 89025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 89041, 89697);

                ErrorCode[]
                ReadOnlyErrors =
                            {
                ErrorCode.ERR_RefReturnReadonly,
                ErrorCode.ERR_RefReadonly,
                ErrorCode.ERR_AssgReadonly,
                ErrorCode.ERR_RefReturnReadonlyStatic,
                ErrorCode.ERR_RefReadonlyStatic,
                ErrorCode.ERR_AssgReadonlyStatic,
                ErrorCode.ERR_RefReturnReadonly2,
                ErrorCode.ERR_RefReadonly2,
                ErrorCode.ERR_AssgReadonly2,
                ErrorCode.ERR_RefReturnReadonlyStatic2,
                ErrorCode.ERR_RefReadonlyStatic2,
                ErrorCode.ERR_AssgReadonlyStatic2
            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 89711, 89852);

                int
                index = ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 89724, 89740) || ((checkingReceiver && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 89743, 89744)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 89747, 89748))) ? 6 : 0) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 89753, 89767) || ((f_10292_89753_89767(field) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 89770, 89771)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 89774, 89775))) ? 3 : 0) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 89780, 89811) || ((kind == BindValueKind.RefReturn && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 89814, 89815)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 89818, 89850))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 89819, 89841) || ((f_10292_89819_89841(kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 89844, 89845)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 89848, 89849))) ? 1 : 2))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 89866, 90104) || true) && (checkingReceiver)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 89866, 90104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 89920, 89975);

                    f_10292_89920_89974(diagnostics, ReadOnlyErrors[index], node, field);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 89866, 90104);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 89866, 90104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90041, 90089);

                    f_10292_90041_90088(diagnostics, ReadOnlyErrors[index], node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 89866, 90104);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 88326, 90115);

                int
                f_10292_88501_88536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 88501, 88536);
                    return 0;
                }


                bool
                f_10292_88564_88596(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 88564, 88596);
                    return return_v;
                }


                int
                f_10292_88551_88597(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 88551, 88597);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_88625_88635(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 88625, 88635);
                    return return_v;
                }


                int
                f_10292_88612_88652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 88612, 88652);
                    return 0;
                }


                int
                f_10292_88931_88984(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 88931, 88984);
                    return 0;
                }


                bool
                f_10292_89753_89767(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 89753, 89767);
                    return return_v;
                }


                bool
                f_10292_89819_89841(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefOrOut(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 89819, 89841);
                    return return_v;
                }


                int
                f_10292_89920_89974(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 89920, 89974);
                    return 0;
                }


                int
                f_10292_90041_90088(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90041, 90088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 88326, 90115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 88326, 90115);
            }
        }

        private static void ReportReadOnlyError(Symbol symbol, SyntaxNode node, BindValueKind kind, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 90127, 91454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90293, 90330);

                f_10292_90293_90329((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90344, 90391);

                f_10292_90344_90390(f_10292_90357_90389(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90604, 90767) || true) && (kind == BindValueKind.AddressOf)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 90604, 90767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90673, 90727);

                    f_10292_90673_90726(diagnostics, ErrorCode.ERR_InvalidAddrOp, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90745, 90752);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 90604, 90767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90783, 90823);

                var
                symbolKind = f_10292_90800_90822(f_10292_90800_90811(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 90839, 91231);

                ErrorCode[]
                ReadOnlyErrors =
                            {
                ErrorCode.ERR_RefReturnReadonlyNotField,
                ErrorCode.ERR_RefReadonlyNotField,
                ErrorCode.ERR_AssignReadonlyNotField,
                ErrorCode.ERR_RefReturnReadonlyNotField2,
                ErrorCode.ERR_RefReadonlyNotField2,
                ErrorCode.ERR_AssignReadonlyNotField2,
            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 91247, 91361);

                int
                index = ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 91260, 91276) || ((checkingReceiver && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 91279, 91280)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 91283, 91284))) ? 3 : 0) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 91289, 91320) || ((kind == BindValueKind.RefReturn && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 91323, 91324)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 91327, 91359))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(10292, 91328, 91350) || ((f_10292_91328_91350(kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 91353, 91354)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 91357, 91358))) ? 1 : 2))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 91375, 91443);

                f_10292_91375_91442(diagnostics, ReadOnlyErrors[index], node, symbolKind, symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 90127, 91454);

                int
                f_10292_90293_90329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90293, 90329);
                    return 0;
                }


                bool
                f_10292_90357_90389(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresAssignableVariable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90357, 90389);
                    return return_v;
                }


                int
                f_10292_90344_90390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90344, 90390);
                    return 0;
                }


                int
                f_10292_90673_90726(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90673, 90726);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10292_90800_90811(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 90800, 90811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10292_90800_90822(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 90800, 90822);
                    return return_v;
                }


                bool
                f_10292_91328_91350(Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                kind)
                {
                    var return_v = RequiresRefOrOut(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 91328, 91350);
                    return return_v;
                }


                int
                f_10292_91375_91442(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 91375, 91442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 90127, 91454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 90127, 91454);
            }
        }

        internal BoundExpression ValidateEscape(BoundExpression expr, uint escapeTo, bool isByRef, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 91721, 92431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 91863, 92375) || true) && (isByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 91863, 92375);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 91908, 92101) || true) && (f_10292_91912_92028(expr.Syntax, expr, f_10292_91946_91966(this), escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 91908, 92101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 92070, 92082);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 91908, 92101);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 91863, 92375);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 91863, 92375);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 92167, 92360) || true) && (f_10292_92171_92287(expr.Syntax, expr, f_10292_92205_92225(this), escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 92167, 92360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 92329, 92341);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 92167, 92360);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 91863, 92375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 92391, 92420);

                return f_10292_92398_92419(this, expr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 91721, 92431);

                uint
                f_10292_91946_91966(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 91946, 91966);
                    return return_v;
                }


                bool
                f_10292_91912_92028(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 91912, 92028);
                    return return_v;
                }


                uint
                f_10292_92205_92225(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 92205, 92225);
                    return return_v;
                }


                bool
                f_10292_92171_92287(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 92171, 92287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_92398_92419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ToBadExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 92398, 92419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 91721, 92431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 91721, 92431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint GetRefEscape(BoundExpression expr, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 93013, 101617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93180, 93278) || true) && (f_10292_93184_93201(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93180, 93278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93235, 93263);

                    return Binder.ExternalScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93180, 93278);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93356, 93495) || true) && (f_10292_93370_93391(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10292_93360_93369(expr), 10292, 93360, 93391)) == SpecialType.System_Void)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93356, 93495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93452, 93480);

                    return Binder.ExternalScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93356, 93495);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93578, 93695) || true) && (f_10292_93582_93600(expr) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93578, 93695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93642, 93680);

                    return scopeOfTheContainingExpression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93578, 93695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 93837, 101434);

                switch (f_10292_93845_93854(expr))
                {

                    case BoundKind.ArrayAccess:
                    case BoundKind.PointerIndirectionOperator:
                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 94140, 94168);

                        return Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 94585, 94613);

                        return Binder.TopLevelScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 94743, 94749);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.DynamicMemberAccess:
                    case BoundKind.DynamicIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 95147, 95153);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 95220, 95275);

                        var
                        parameter = f_10292_95236_95274(((BoundParameter)expr))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 95504, 95591);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10292, 95511, 95544) || ((f_10292_95511_95528(parameter) == RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10292, 95547, 95567)) || DynAbs.Tracing.TraceSender.Conditional_F3(10292, 95570, 95590))) ? Binder.TopLevelScope : Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 95654, 95707);

                        return f_10292_95661_95706(f_10292_95661_95691(((BoundLocal)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 95778, 95817);

                        var
                        thisref = (BoundThisReference)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 95906, 96014) || true) && (f_10292_95910_95935_M(!f_10292_95911_95923(thisref).IsValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 95906, 96014);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 95985, 95991);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 95906, 96014);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96170, 96198);

                        return Binder.TopLevelScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96275, 96324);

                        var
                        conditional = (BoundConditionalOperator)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96348, 96708) || true) && (f_10292_96352_96369(conditional))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 96348, 96708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96486, 96685);

                            return f_10292_96493_96684(f_10292_96502_96571(f_10292_96515_96538(conditional), scopeOfTheContainingExpression), f_10292_96614_96683(f_10292_96627_96650(conditional), scopeOfTheContainingExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 96348, 96708);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 96782, 96788);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96857, 96898);

                        var
                        fieldAccess = (BoundFieldAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 96920, 96962);

                        var
                        fieldSymbol = f_10292_96938_96961(fieldAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97086, 97257) || true) && (f_10292_97090_97110(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 97090, 97156) || f_10292_97114_97156(f_10292_97114_97140(fieldSymbol))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 97086, 97257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97206, 97234);

                            return Binder.ExternalScope;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 97086, 97257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97345, 97422);

                        return f_10292_97352_97421(f_10292_97365_97388(fieldAccess), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97491, 97532);

                        var
                        eventAccess = (BoundEventAccess)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97554, 97727) || true) && (f_10292_97558_97586_M(!eventAccess.IsUsableAsField))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 97554, 97727);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 97698, 97704);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 97554, 97727);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97751, 97793);

                        var
                        eventSymbol = f_10292_97769_97792(eventAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 97928, 98099) || true) && (f_10292_97932_97952(eventSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 97932, 97998) || f_10292_97956_97998(f_10292_97956_97982(eventSymbol))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 97928, 98099);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98048, 98076);

                            return Binder.ExternalScope;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 97928, 98099);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98187, 98264);

                        return f_10292_98194_98263(f_10292_98207_98230(eventAccess), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98326, 98353);

                        var
                        call = (BoundCall)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98377, 98408);

                        var
                        methodSymbol = f_10292_98396_98407(call)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98430, 98549) || true) && (f_10292_98434_98454(methodSymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 98430, 98549);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 98520, 98526);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 98430, 98549);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 98573, 98977);

                        return f_10292_98580_98976(f_10292_98631_98642(call), f_10292_98669_98685(call), f_10292_98712_98735(methodSymbol), f_10292_98762_98776(call), f_10292_98803_98827(call), f_10292_98854_98874(call), scopeOfTheContainingExpression, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99060, 99117);

                        var
                        ptrInvocation = (BoundFunctionPointerInvocation)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99141, 99196);

                        methodSymbol = f_10292_99156_99195(f_10292_99156_99185(ptrInvocation));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99218, 99337) || true) && (f_10292_99222_99242(methodSymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 99218, 99337);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 99308, 99314);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 99218, 99337);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99361, 99789);

                        return f_10292_99368_99788(methodSymbol, receiverOpt: null, f_10292_99502_99525(methodSymbol), f_10292_99552_99575(ptrInvocation), f_10292_99602_99635(ptrInvocation), argsToParamsOpt: default, scopeOfTheContainingExpression, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99860, 99905);

                        var
                        indexerAccess = (BoundIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99927, 99969);

                        var
                        indexerSymbol = f_10292_99947_99968(indexerAccess)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 99993, 100436);

                        return f_10292_100000_100435(indexerSymbol, f_10292_100091_100116(indexerAccess), f_10292_100143_100167(indexerSymbol), f_10292_100194_100217(indexerAccess), f_10292_100244_100277(indexerAccess), f_10292_100304_100333(indexerAccess), scopeOfTheContainingExpression, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 100508, 100555);

                        var
                        propertyAccess = (BoundPropertyAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 100640, 101019);

                        return f_10292_100647_101018(f_10292_100698_100727(propertyAccess), f_10292_100754_100780(propertyAccess), default, default, default, default, scopeOfTheContainingExpression, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 93837, 101434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 101095, 101142);

                        var
                        assignment = (BoundAssignmentOperator)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 101166, 101326) || true) && (f_10292_101170_101187_M(!assignment.IsRef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 101166, 101326);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 101297, 101303);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 101166, 101326);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 101350, 101419);

                        return f_10292_101357_101418(f_10292_101370_101385(assignment), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 93837, 101434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 101568, 101606);

                return scopeOfTheContainingExpression;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 93013, 101617);

                bool
                f_10292_93184_93201(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 93184, 93201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_93360_93369(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 93360, 93369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10292_93370_93391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 93370, 93391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10292_93582_93600(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 93582, 93600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_93845_93854(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 93845, 93854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10292_95236_95274(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95236, 95274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_95511_95528(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95511, 95528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10292_95661_95691(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95661, 95691);
                    return return_v;
                }


                uint
                f_10292_95661_95706(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefEscapeScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95661, 95706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_95911_95923(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95911, 95923);
                    return return_v;
                }


                bool
                f_10292_95910_95935_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 95910, 95935);
                    return return_v;
                }


                bool
                f_10292_96352_96369(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 96352, 96369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_96515_96538(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 96515, 96538);
                    return return_v;
                }


                uint
                f_10292_96502_96571(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetRefEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 96502, 96571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_96627_96650(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 96627, 96650);
                    return return_v;
                }


                uint
                f_10292_96614_96683(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetRefEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 96614, 96683);
                    return return_v;
                }


                uint
                f_10292_96493_96684(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 96493, 96684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_96938_96961(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 96938, 96961);
                    return return_v;
                }


                bool
                f_10292_97090_97110(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97090, 97110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_97114_97140(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97114, 97140);
                    return return_v;
                }


                bool
                f_10292_97114_97156(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97114, 97156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_97365_97388(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97365, 97388);
                    return return_v;
                }


                uint
                f_10292_97352_97421(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetRefEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 97352, 97421);
                    return return_v;
                }


                bool
                f_10292_97558_97586_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97558, 97586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10292_97769_97792(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97769, 97792);
                    return return_v;
                }


                bool
                f_10292_97932_97952(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97932, 97952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_97956_97982(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97956, 97982);
                    return return_v;
                }


                bool
                f_10292_97956_97998(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 97956, 97998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_98207_98230(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98207, 98230);
                    return return_v;
                }


                uint
                f_10292_98194_98263(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetRefEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 98194, 98263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_98396_98407(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98396, 98407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_98434_98454(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98434, 98454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_98631_98642(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98631, 98642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_98669_98685(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98669, 98685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_98712_98735(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98712, 98735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_98762_98776(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98762, 98776);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_98803_98827(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98803, 98827);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_98854_98874(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 98854, 98874);
                    return return_v;
                }


                uint
                f_10292_98580_98976(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 98580, 98976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10292_99156_99185(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99156, 99185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10292_99156_99195(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99156, 99195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_99222_99242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99222, 99242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_99502_99525(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99502, 99525);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_99552_99575(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99552, 99575);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_99602_99635(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99602, 99635);
                    return return_v;
                }


                uint
                f_10292_99368_99788(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt: receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt: argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 99368, 99788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_99947_99968(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 99947, 99968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_100091_100116(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100091, 100116);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_100143_100167(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100143, 100167);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_100194_100217(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100194, 100217);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_100244_100277(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100244, 100277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_100304_100333(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100304, 100333);
                    return return_v;
                }


                uint
                f_10292_100000_100435(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 100000, 100435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_100698_100727(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100698, 100727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_100754_100780(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 100754, 100780);
                    return return_v;
                }


                uint
                f_10292_100647_101018(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 100647, 101018);
                    return return_v;
                }


                bool
                f_10292_101170_101187_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 101170, 101187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_101370_101385(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 101370, 101385);
                    return return_v;
                }


                uint
                f_10292_101357_101418(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetRefEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 101357, 101418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 93013, 101617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 93013, 101617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckRefEscape(SyntaxNode node, BoundExpression expr, uint escapeFrom, uint escapeTo, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 102006, 113083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102187, 102275);

                f_10292_102187_102274(!checkingReceiver || (DynAbs.Tracing.TraceSender.Expression_False(10292, 102200, 102242) || f_10292_102221_102242(f_10292_102221_102230(expr))) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 102200, 102273) || f_10292_102246_102273(f_10292_102246_102255(expr))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102291, 102440) || true) && (escapeTo >= escapeFrom)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 102291, 102440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102413, 102425);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 102291, 102440);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102456, 102575) || true) && (f_10292_102460_102477(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 102456, 102575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102548, 102560);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 102456, 102575);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102674, 102797) || true) && (f_10292_102688_102709(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10292_102678_102687(expr), 10292, 102678, 102709)) == SpecialType.System_Void)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 102674, 102797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102770, 102782);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 102674, 102797);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102884, 103062) || true) && (f_10292_102888_102906(expr) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 102884, 103062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 102948, 103016);

                    f_10292_102948_103015(diagnostics, f_10292_102967_103008(escapeTo), node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 103034, 103047);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 102884, 103062);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 103078, 112843);

                switch (f_10292_103086_103095(expr))
                {

                    case BoundKind.ArrayAccess:
                    case BoundKind.PointerIndirectionOperator:
                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 103381, 103393);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 103682, 103797) || true) && (escapeTo == Binder.ExternalScope)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103682, 103797);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 103768, 103774);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103682, 103797);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 103949, 103961);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 104091, 104097);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.DynamicMemberAccess:
                    case BoundKind.DynamicIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 104465, 104471);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 104538, 104575);

                        var
                        parameter = (BoundParameter)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 104597, 104686);

                        return f_10292_104604_104685(node, parameter, escapeTo, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 104749, 104778);

                        var
                        local = (BoundLocal)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 104800, 104881);

                        return f_10292_104807_104880(node, local, escapeTo, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 104952, 104991);

                        var
                        thisref = (BoundThisReference)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105080, 105188) || true) && (f_10292_105084_105109_M(!f_10292_105085_105097(thisref).IsValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 105080, 105188);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 105159, 105165);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 105080, 105188);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105286, 105526) || true) && (escapeTo == Binder.ExternalScope)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 105286, 105526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105372, 105464);

                            f_10292_105372_105463(diagnostics, ErrorCode.ERR_RefReturnStructThis, node, ThisParameterSymbol.SymbolName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105490, 105503);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 105286, 105526);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105608, 105620);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105697, 105746);

                        var
                        conditional = (BoundConditionalOperator)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105770, 106196) || true) && (f_10292_105774_105791(conditional))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 105770, 106196);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 105841, 106173);

                            return f_10292_105848_105992(f_10292_105863_105886(conditional).Syntax, f_10292_105895_105918(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 105848, 106172) && f_10292_106028_106172(f_10292_106043_106066(conditional).Syntax, f_10292_106075_106098(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 105770, 106196);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10292, 106273, 106279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106348, 106389);

                        var
                        fieldAccess = (BoundFieldAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106411, 106492);

                        return f_10292_106418_106491(node, fieldAccess, escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106561, 106602);

                        var
                        eventAccess = (BoundEventAccess)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106624, 106797) || true) && (f_10292_106628_106656_M(!eventAccess.IsUsableAsField))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 106624, 106797);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 106768, 106774);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 106624, 106797);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106821, 106911);

                        return f_10292_106828_106910(node, eventAccess, escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 106973, 107000);

                        var
                        call = (BoundCall)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107024, 107055);

                        var
                        methodSymbol = f_10292_107043_107054(call)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107077, 107196) || true) && (f_10292_107081_107101(methodSymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 107077, 107196);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 107167, 107173);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 107077, 107196);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107220, 107756);

                        return f_10292_107227_107755(call.Syntax, methodSymbol, f_10292_107352_107368(call), f_10292_107395_107418(methodSymbol), f_10292_107445_107459(call), f_10292_107486_107510(call), f_10292_107537_107557(call), checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107827, 107872);

                        var
                        indexerAccess = (BoundIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107894, 107936);

                        var
                        indexerSymbol = f_10292_107914_107935(indexerAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 107960, 108080) || true) && (f_10292_107964_107985(indexerSymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 107960, 108080);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 108051, 108057);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 107960, 108080);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 108104, 108687);

                        return f_10292_108111_108686(indexerAccess.Syntax, indexerSymbol, f_10292_108246_108271(indexerAccess), f_10292_108298_108322(indexerSymbol), f_10292_108349_108372(indexerAccess), f_10292_108399_108432(indexerAccess), f_10292_108459_108488(indexerAccess), checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 108777, 108842);

                        var
                        patternIndexer = (BoundIndexOrRangePatternIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 108864, 108880);

                        RefKind
                        refKind
                        = default(RefKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 108902, 108945);

                        ImmutableArray<ParameterSymbol>
                        parameters
                        = default(ImmutableArray<ParameterSymbol>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 108969, 109531);

                        switch (f_10292_108977_109005(patternIndexer))
                        {

                            case PropertySymbol p:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 108969, 109531);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109107, 109127);

                                refKind = f_10292_109117_109126(p);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109157, 109183);

                                parameters = f_10292_109170_109182(p);
                                DynAbs.Tracing.TraceSender.TraceBreak(10292, 109213, 109219);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 108969, 109531);

                            case MethodSymbol m:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 108969, 109531);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109295, 109315);

                                refKind = f_10292_109305_109314(m);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109345, 109371);

                                parameters = f_10292_109358_109370(m);
                                DynAbs.Tracing.TraceSender.TraceBreak(10292, 109401, 109407);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 108969, 109531);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 108969, 109531);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109471, 109508);

                                throw f_10292_109477_109507();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 108969, 109531);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109555, 109661) || true) && (refKind == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 109555, 109661);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 109632, 109638);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 109555, 109661);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 109685, 110260);

                        return f_10292_109692_110259(patternIndexer.Syntax, f_10292_109788_109816(patternIndexer), f_10292_109843_109866(patternIndexer), parameters, f_10292_109930_109993(f_10292_109969_109992(patternIndexer)), default, default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 110343, 110412);

                        var
                        functionPointerInvocation = (BoundFunctionPointerInvocation)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 110436, 110528);

                        FunctionPointerMethodSymbol
                        signature = f_10292_110476_110527(f_10292_110476_110517(functionPointerInvocation))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 110550, 110666) || true) && (f_10292_110554_110571(signature) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 110550, 110666);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 110637, 110643);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 110550, 110666);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 110690, 111314);

                        return f_10292_110697_111313(functionPointerInvocation.Syntax, signature, f_10292_110840_110883(functionPointerInvocation), f_10292_110910_110930(signature), f_10292_110957_110992(functionPointerInvocation), f_10292_111019_111064(functionPointerInvocation), argsToParamsOpt: default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 111386, 111433);

                        var
                        propertyAccess = (BoundPropertyAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 111455, 111506);

                        var
                        propertySymbol = f_10292_111476_111505(propertyAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 111530, 111651) || true) && (f_10292_111534_111556(propertySymbol) == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 111530, 111651);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 111622, 111628);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 111530, 111651);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 111736, 112241);

                        return f_10292_111743_112240(propertyAccess.Syntax, propertySymbol, f_10292_111880_111906(propertyAccess), default, default, default, default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 103078, 112843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 112317, 112364);

                        var
                        assignment = (BoundAssignmentOperator)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 112448, 112548) || true) && (f_10292_112452_112469_M(!assignment.IsRef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 112448, 112548);
                            DynAbs.Tracing.TraceSender.TraceBreak(10292, 112519, 112525);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 112448, 112548);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 112572, 112828);

                        return f_10292_112579_112827(node, f_10292_112651_112666(assignment), escapeFrom, escapeTo, checkingReceiver: false, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 103078, 112843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 112977, 113045);

                f_10292_112977_113044(diagnostics, f_10292_112996_113037(escapeTo), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113059, 113072);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 102006, 113083);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_102221_102230(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102221, 102230);
                    return return_v;
                }


                bool
                f_10292_102221_102242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102221, 102242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_102246_102255(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102246, 102255);
                    return return_v;
                }


                bool
                f_10292_102246_102273(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 102246, 102273);
                    return return_v;
                }


                int
                f_10292_102187_102274(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 102187, 102274);
                    return 0;
                }


                bool
                f_10292_102460_102477(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102460, 102477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_102678_102687(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102678, 102687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10292_102688_102709(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 102688, 102709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10292_102888_102906(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 102888, 102906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_102967_103008(uint
                escapeTo)
                {
                    var return_v = GetStandardRValueRefEscapeError(escapeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 102967, 103008);
                    return return_v;
                }


                int
                f_10292_102948_103015(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 102948, 103015);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_103086_103095(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 103086, 103095);
                    return return_v;
                }


                bool
                f_10292_104604_104685(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundParameter
                parameter, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckParameterRefEscape(node, parameter, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 104604, 104685);
                    return return_v;
                }


                bool
                f_10292_104807_104880(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundLocal
                local, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckLocalRefEscape(node, local, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 104807, 104880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_105085_105097(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 105085, 105097);
                    return return_v;
                }


                bool
                f_10292_105084_105109_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 105084, 105109);
                    return return_v;
                }


                int
                f_10292_105372_105463(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 105372, 105463);
                    return 0;
                }


                bool
                f_10292_105774_105791(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 105774, 105791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_105863_105886(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 105863, 105886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_105895_105918(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 105895, 105918);
                    return return_v;
                }


                bool
                f_10292_105848_105992(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 105848, 105992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_106043_106066(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 106043, 106066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_106075_106098(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 106075, 106098);
                    return return_v;
                }


                bool
                f_10292_106028_106172(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 106028, 106172);
                    return return_v;
                }


                bool
                f_10292_106418_106491(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFieldRefEscape(node, fieldAccess, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 106418, 106491);
                    return return_v;
                }


                bool
                f_10292_106628_106656_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 106628, 106656);
                    return return_v;
                }


                bool
                f_10292_106828_106910(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                eventAccess, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFieldLikeEventRefEscape(node, eventAccess, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 106828, 106910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_107043_107054(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107043, 107054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_107081_107101(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107081, 107101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_107352_107368(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107352, 107368);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_107395_107418(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107395, 107418);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_107445_107459(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107445, 107459);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_107486_107510(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107486, 107510);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_107537_107557(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107537, 107557);
                    return return_v;
                }


                bool
                f_10292_107227_107755(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 107227, 107755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_107914_107935(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107914, 107935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_107964_107985(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 107964, 107985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_108246_108271(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108246, 108271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_108298_108322(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108298, 108322);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_108349_108372(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108349, 108372);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_108399_108432(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108399, 108432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_108459_108488(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108459, 108488);
                    return return_v;
                }


                bool
                f_10292_108111_108686(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 108111, 108686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_108977_109005(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 108977, 109005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_109117_109126(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109117, 109126);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_109170_109182(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109170, 109182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_109305_109314(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109305, 109314);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_109358_109370(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109358, 109370);
                    return return_v;
                }


                System.Exception
                f_10292_109477_109507()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109477, 109507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_109788_109816(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109788, 109816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_109843_109866(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109843, 109866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_109969_109992(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 109969, 109992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_109930_109993(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 109930, 109993);
                    return return_v;
                }


                bool
                f_10292_109692_110259(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 109692, 110259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10292_110476_110517(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110476, 110517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10292_110476_110527(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110476, 110527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_110554_110571(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110554, 110571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_110840_110883(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.InvokedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110840, 110883);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_110910_110930(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110910, 110930);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_110957_110992(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 110957, 110992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_111019_111064(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 111019, 111064);
                    return return_v;
                }


                bool
                f_10292_110697_111313(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt: argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 110697, 111313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_111476_111505(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 111476, 111505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10292_111534_111556(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 111534, 111556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_111880_111906(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 111880, 111906);
                    return return_v;
                }


                bool
                f_10292_111743_112240(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 111743, 112240);
                    return return_v;
                }


                bool
                f_10292_112452_112469_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 112452, 112469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_112651_112666(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 112651, 112666);
                    return return_v;
                }


                bool
                f_10292_112579_112827(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckRefEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 112579, 112827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10292_112996_113037(uint
                escapeTo)
                {
                    var return_v = GetStandardRValueRefEscapeError(escapeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 112996, 113037);
                    return return_v;
                }


                int
                f_10292_112977_113044(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 112977, 113044);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 102006, 113083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 102006, 113083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint GetBroadestValEscape(BoundTupleExpression expr, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 113095, 113826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113225, 113272);

                uint
                broadest = scopeOfTheContainingExpression
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113286, 113783);
                    foreach (var element in f_10292_113310_113324_I(f_10292_113310_113324(expr)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 113286, 113783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113358, 113373);

                        uint
                        valEscape
                        = default(uint);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113391, 113707) || true) && (element is BoundTupleExpression te)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 113391, 113707);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113471, 113540);

                            valEscape = f_10292_113483_113539(te, scopeOfTheContainingExpression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 113391, 113707);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 113391, 113707);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113622, 113688);

                            valEscape = f_10292_113634_113687(element, scopeOfTheContainingExpression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 113391, 113707);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113727, 113768);

                        broadest = f_10292_113738_113767(broadest, valEscape);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 113286, 113783);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 113799, 113815);

                return broadest;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 113095, 113826);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_113310_113324(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 113310, 113324);
                    return return_v;
                }


                uint
                f_10292_113483_113539(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetBroadestValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 113483, 113539);
                    return return_v;
                }


                uint
                f_10292_113634_113687(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 113634, 113687);
                    return return_v;
                }


                uint
                f_10292_113738_113767(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 113738, 113767);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_113310_113324_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 113310, 113324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 113095, 113826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 113095, 113826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint GetValEscape(BoundExpression expr, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 114152, 127995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114319, 114417) || true) && (f_10292_114323_114340(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114319, 114417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114374, 114402);

                    return Binder.ExternalScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114319, 114417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114496, 114603) || true) && (f_10292_114500_114518(expr) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114496, 114603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114560, 114588);

                    return Binder.ExternalScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114496, 114603);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114706, 114819) || true) && (f_10292_114710_114734_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10292_114710_114719(expr), 10292, 114710, 114734)?.IsRefLikeType) != true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114706, 114819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114776, 114804);

                    return Binder.ExternalScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114706, 114819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 114961, 127984);

                switch (f_10292_114969_114978(expr))
                {

                    case BoundKind.DefaultLiteral:
                    case BoundKind.DefaultExpression:
                    case BoundKind.Parameter:
                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 115247, 115275);

                        return Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.TupleLiteral:
                    case BoundKind.ConvertedTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 115400, 115446);

                        var
                        tupleLiteral = (BoundTupleExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 115468, 115549);

                        return f_10292_115475_115548(f_10292_115493_115515(tupleLiteral), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.MakeRefOperator:
                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 115852, 115880);

                        return Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116007, 116035);

                        return Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.DeconstructValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116120, 116178);

                        return f_10292_116127_116177(((BoundDeconstructValuePlaceholder)expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116241, 116294);

                        return f_10292_116248_116293(f_10292_116248_116278(((BoundLocal)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.StackAllocArrayCreation:
                    case BoundKind.ConvertedStackAllocExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116438, 116466);

                        return Binder.TopLevelScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116543, 116592);

                        var
                        conditional = (BoundConditionalOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116616, 116703);

                        var
                        consEscape = f_10292_116633_116702(f_10292_116646_116669(conditional), scopeOfTheContainingExpression)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116727, 117001) || true) && (f_10292_116731_116748(conditional))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 116727, 117001);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 116960, 116978);

                            return consEscape;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 116727, 117001);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117096, 117232);

                        return f_10292_117103_117231(consEscape, f_10292_117161_117230(f_10292_117174_117197(conditional), scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.NullCoalescingOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117312, 117365);

                        var
                        coalescingOp = (BoundNullCoalescingOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117389, 117587);

                        return f_10292_117396_117586(f_10292_117405_117475(f_10292_117418_117442(coalescingOp), scopeOfTheContainingExpression), f_10292_117514_117585(f_10292_117527_117552(coalescingOp), scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117656, 117697);

                        var
                        fieldAccess = (BoundFieldAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117719, 117761);

                        var
                        fieldSymbol = f_10292_117737_117760(fieldAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117785, 118007) || true) && (f_10292_117789_117809(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 117789, 117854) || f_10292_117813_117854_M(!f_10292_117814_117840(fieldSymbol).IsRefLikeType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 117785, 118007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 117956, 117984);

                            return Binder.ExternalScope;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 117785, 118007);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118098, 118175);

                        return f_10292_118105_118174(f_10292_118118_118141(fieldAccess), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118237, 118264);

                        var
                        call = (BoundCall)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118288, 118692);

                        return f_10292_118295_118691(f_10292_118346_118357(call), f_10292_118384_118400(call), f_10292_118427_118449(f_10292_118427_118438(call)), f_10292_118476_118490(call), f_10292_118517_118541(call), f_10292_118568_118588(call), scopeOfTheContainingExpression, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118775, 118832);

                        var
                        ptrInvocation = (BoundFunctionPointerInvocation)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118854, 118910);

                        var
                        ptrSymbol = f_10292_118870_118909(f_10292_118870_118899(ptrInvocation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 118934, 119357);

                        return f_10292_118941_119356(ptrSymbol, receiverOpt: null, f_10292_119072_119092(ptrSymbol), f_10292_119119_119142(ptrInvocation), f_10292_119169_119202(ptrInvocation), argsToParamsOpt: default, scopeOfTheContainingExpression, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 119428, 119473);

                        var
                        indexerAccess = (BoundIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 119495, 119537);

                        var
                        indexerSymbol = f_10292_119515_119536(indexerAccess)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 119561, 120005);

                        return f_10292_119568_120004(indexerSymbol, f_10292_119659_119684(indexerAccess), f_10292_119711_119735(indexerSymbol), f_10292_119762_119785(indexerAccess), f_10292_119812_119845(indexerAccess), f_10292_119872_119901(indexerAccess), scopeOfTheContainingExpression, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120095, 120160);

                        var
                        patternIndexer = (BoundIndexOrRangePatternIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120182, 120498);

                        var
                        parameters = f_10292_120199_120227(patternIndexer) switch
                        {
                            PropertySymbol p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120283, 120315) && DynAbs.Tracing.TraceSender.Expression_True(10292, 120283, 120315))
=> f_10292_120303_120315(p),
                            MethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120342, 120372) && DynAbs.Tracing.TraceSender.Expression_True(10292, 120342, 120372))
=> f_10292_120360_120372(m),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120399, 120474) && DynAbs.Tracing.TraceSender.Expression_True(10292, 120399, 120474))
=> throw f_10292_120410_120474(f_10292_120445_120473(patternIndexer))
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120522, 120901);

                        return f_10292_120529_120900(f_10292_120580_120608(patternIndexer), f_10292_120635_120658(patternIndexer), parameters, default, default, default, scopeOfTheContainingExpression, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 120973, 121020);

                        var
                        propertyAccess = (BoundPropertyAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 121105, 121485);

                        return f_10292_121112_121484(f_10292_121163_121192(propertyAccess), f_10292_121219_121245(propertyAccess), default, default, default, default, scopeOfTheContainingExpression, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 121567, 121624);

                        var
                        objectCreation = (BoundObjectCreationExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 121646, 121697);

                        var
                        constructorSymbol = f_10292_121670_121696(objectCreation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 121721, 122161);

                        var
                        escape = f_10292_121734_122160(constructorSymbol, null, f_10292_121860_121888(constructorSymbol), f_10292_121915_121939(objectCreation), f_10292_121966_122000(objectCreation), f_10292_122027_122057(objectCreation), scopeOfTheContainingExpression, isRefEscape: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122185, 122246);

                        var
                        initializerOpt = f_10292_122206_122245(objectCreation)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122268, 122455) || true) && (initializerOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 122268, 122455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122344, 122432);

                            escape = f_10292_122353_122431(escape, f_10292_122370_122430(initializerOpt, scopeOfTheContainingExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 122268, 122455);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122479, 122493);

                        return escape;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.UnaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122564, 122652);

                        return f_10292_122571_122651(f_10292_122584_122618(((BoundUnaryOperator)expr)), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122720, 122759);

                        var
                        conversion = (BoundConversion)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122781, 122895);

                        f_10292_122781_122894(f_10292_122794_122819(conversion) != ConversionKind.StackAllocToSpanType, "StackAllocToSpanType unexpected");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 122919, 122991);

                        return f_10292_122926_122990(f_10292_122939_122957(conversion), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123067, 123158);

                        return f_10292_123074_123157(f_10292_123087_123124(((BoundAssignmentOperator)expr)), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.IncrementOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123233, 123325);

                        return f_10292_123240_123324(f_10292_123253_123291(((BoundIncrementOperator)expr)), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.CompoundAssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123409, 123462);

                        var
                        compound = (BoundCompoundAssignmentOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123486, 123662);

                        return f_10292_123493_123661(f_10292_123502_123561(f_10292_123515_123528(compound), scopeOfTheContainingExpression), f_10292_123600_123660(f_10292_123613_123627(compound), scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.BinaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123734, 123773);

                        var
                        binary = (BoundBinaryOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 123797, 123969);

                        return f_10292_123804_123968(f_10292_123813_123870(f_10292_123826_123837(binary), scopeOfTheContainingExpression), f_10292_123909_123967(f_10292_123922_123934(binary), scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.UserDefinedConditionalLogicalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124064, 124122);

                        var
                        uo = (BoundUserDefinedConditionalLogicalOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124146, 124310);

                        return f_10292_124153_124309(f_10292_124162_124215(f_10292_124175_124182(uo), scopeOfTheContainingExpression), f_10292_124254_124308(f_10292_124267_124275(uo), scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.QueryClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124379, 124463);

                        return f_10292_124386_124462(f_10292_124399_124429(((BoundQueryClause)expr)), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124534, 124620);

                        return f_10292_124541_124619(f_10292_124554_124586(((BoundRangeVariable)expr)), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ObjectInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124705, 124759);

                        var
                        initExpr = (BoundObjectInitializerExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124781, 124862);

                        return f_10292_124788_124861(initExpr, scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.CollectionInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 124951, 125008);

                        var
                        colExpr = (BoundCollectionInitializerExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 125030, 125104);

                        return f_10292_125037_125103(f_10292_125050_125070(colExpr), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.CollectionElementInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 125190, 125247);

                        var
                        colElement = (BoundCollectionElementInitializer)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 125269, 125343);

                        return f_10292_125276_125342(f_10292_125289_125309(colElement), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ObjectInitializerMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 125748, 125786);

                        return scopeOfTheContainingExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ImplicitReceiver:
                    case BoundKind.ObjectOrCollectionValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 126134, 126172);

                        return scopeOfTheContainingExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.DisposableValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 126471, 126509);

                        return scopeOfTheContainingExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.AwaitableValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 126592, 126648);

                        return f_10292_126599_126647(((BoundAwaitableValuePlaceholder)expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.PointerElementAccess:
                    case BoundKind.PointerIndirectionOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 126856, 126884);

                        return Binder.ExternalScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.AsOperator:
                    case BoundKind.AwaitExpression:
                    case BoundKind.ConditionalAccess:
                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 127171, 127209);

                        return scopeOfTheContainingExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    case BoundKind.ConvertedSwitchExpression:
                    case BoundKind.UnconvertedSwitchExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 127353, 127398);

                        var
                        switchExpr = (BoundSwitchExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 127420, 127523);

                        return f_10292_127427_127522(switchExpr.SwitchArms.SelectAsArray(a => a.Value), scopeOfTheContainingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 114961, 127984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 127842, 127909);

                        f_10292_127842_127908(false, $"{f_10292_127865_127874(expr)} expression of {f_10292_127891_127900(expr)} type");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 127931, 127969);

                        return scopeOfTheContainingExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 114961, 127984);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 114152, 127995);

                bool
                f_10292_114323_114340(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 114323, 114340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10292_114500_114518(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 114500, 114518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_114710_114719(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 114710, 114719);
                    return return_v;
                }


                bool?
                f_10292_114710_114734_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 114710, 114734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_114969_114978(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 114969, 114978);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_115493_115515(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 115493, 115515);
                    return return_v;
                }


                uint
                f_10292_115475_115548(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetTupleValEscape(elements, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 115475, 115548);
                    return return_v;
                }


                uint
                f_10292_116127_116177(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                this_param)
                {
                    var return_v = this_param.ValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 116127, 116177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10292_116248_116278(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 116248, 116278);
                    return return_v;
                }


                uint
                f_10292_116248_116293(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ValEscapeScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 116248, 116293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_116646_116669(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 116646, 116669);
                    return return_v;
                }


                uint
                f_10292_116633_116702(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 116633, 116702);
                    return return_v;
                }


                bool
                f_10292_116731_116748(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 116731, 116748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_117174_117197(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117174, 117197);
                    return return_v;
                }


                uint
                f_10292_117161_117230(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 117161, 117230);
                    return return_v;
                }


                uint
                f_10292_117103_117231(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 117103, 117231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_117418_117442(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117418, 117442);
                    return return_v;
                }


                uint
                f_10292_117405_117475(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 117405, 117475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_117527_117552(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117527, 117552);
                    return return_v;
                }


                uint
                f_10292_117514_117585(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 117514, 117585);
                    return return_v;
                }


                uint
                f_10292_117396_117586(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 117396, 117586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_117737_117760(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117737, 117760);
                    return return_v;
                }


                bool
                f_10292_117789_117809(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117789, 117809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_117814_117840(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117814, 117840);
                    return return_v;
                }


                bool
                f_10292_117813_117854_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 117813, 117854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_118118_118141(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118118, 118141);
                    return return_v;
                }


                uint
                f_10292_118105_118174(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 118105, 118174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_118346_118357(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118346, 118357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_118384_118400(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118384, 118400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_118427_118438(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118427, 118438);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_118427_118449(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118427, 118449);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_118476_118490(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118476, 118490);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_118517_118541(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118517, 118541);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_118568_118588(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118568, 118588);
                    return return_v;
                }


                uint
                f_10292_118295_118691(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 118295, 118691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10292_118870_118899(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118870, 118899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10292_118870_118909(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 118870, 118909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_119072_119092(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119072, 119092);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_119119_119142(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119119, 119142);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_119169_119202(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119169, 119202);
                    return return_v;
                }


                uint
                f_10292_118941_119356(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt: receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt: argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 118941, 119356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_119515_119536(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119515, 119536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_119659_119684(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119659, 119684);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_119711_119735(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119711, 119735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_119762_119785(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119762, 119785);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_119812_119845(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119812, 119845);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_119872_119901(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 119872, 119901);
                    return return_v;
                }


                uint
                f_10292_119568_120004(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 119568, 120004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_120199_120227(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120199, 120227);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_120303_120315(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120303, 120315);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_120360_120372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120360, 120372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_120445_120473(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120445, 120473);
                    return return_v;
                }


                System.Exception
                f_10292_120410_120474(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 120410, 120474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_120580_120608(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120580, 120608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_120635_120658(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 120635, 120658);
                    return return_v;
                }


                uint
                f_10292_120529_120900(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope(symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 120529, 120900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_121163_121192(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121163, 121192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_121219_121245(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121219, 121245);
                    return return_v;
                }


                uint
                f_10292_121112_121484(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 121112, 121484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_121670_121696(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121670, 121696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_121860_121888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121860, 121888);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_121915_121939(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121915, 121939);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_121966_122000(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 121966, 122000);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_122027_122057(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 122027, 122057);
                    return return_v;
                }


                uint
                f_10292_121734_122160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, bool
                isRefEscape)
                {
                    var return_v = GetInvocationEscapeScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, scopeOfTheContainingExpression, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 121734, 122160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10292_122206_122245(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 122206, 122245);
                    return return_v;
                }


                uint
                f_10292_122370_122430(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 122370, 122430);
                    return return_v;
                }


                uint
                f_10292_122353_122431(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 122353, 122431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_122584_122618(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 122584, 122618);
                    return return_v;
                }


                uint
                f_10292_122571_122651(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 122571, 122651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10292_122794_122819(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 122794, 122819);
                    return return_v;
                }


                int
                f_10292_122781_122894(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 122781, 122894);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_122939_122957(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 122939, 122957);
                    return return_v;
                }


                uint
                f_10292_122926_122990(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 122926, 122990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123087_123124(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123087, 123124);
                    return return_v;
                }


                uint
                f_10292_123074_123157(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123074, 123157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123253_123291(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123253, 123291);
                    return return_v;
                }


                uint
                f_10292_123240_123324(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123240, 123324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123515_123528(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123515, 123528);
                    return return_v;
                }


                uint
                f_10292_123502_123561(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123502, 123561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123613_123627(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123613, 123627);
                    return return_v;
                }


                uint
                f_10292_123600_123660(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123600, 123660);
                    return return_v;
                }


                uint
                f_10292_123493_123661(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123493, 123661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123826_123837(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123826, 123837);
                    return return_v;
                }


                uint
                f_10292_123813_123870(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123813, 123870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_123922_123934(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 123922, 123934);
                    return return_v;
                }


                uint
                f_10292_123909_123967(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123909, 123967);
                    return return_v;
                }


                uint
                f_10292_123804_123968(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 123804, 123968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_124175_124182(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 124175, 124182);
                    return return_v;
                }


                uint
                f_10292_124162_124215(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124162, 124215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_124267_124275(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 124267, 124275);
                    return return_v;
                }


                uint
                f_10292_124254_124308(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124254, 124308);
                    return return_v;
                }


                uint
                f_10292_124153_124309(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124153, 124309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_124399_124429(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 124399, 124429);
                    return return_v;
                }


                uint
                f_10292_124386_124462(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124386, 124462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_124554_124586(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 124554, 124586);
                    return return_v;
                }


                uint
                f_10292_124541_124619(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124541, 124619);
                    return return_v;
                }


                uint
                f_10292_124788_124861(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                initExpr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscapeOfObjectInitializer(initExpr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 124788, 124861);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_125050_125070(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 125050, 125070);
                    return return_v;
                }


                uint
                f_10292_125037_125103(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expressions, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 125037, 125103);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_125289_125309(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 125289, 125309);
                    return return_v;
                }


                uint
                f_10292_125276_125342(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expressions, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 125276, 125342);
                    return return_v;
                }


                uint
                f_10292_126599_126647(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                this_param)
                {
                    var return_v = this_param.ValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 126599, 126647);
                    return return_v;
                }


                uint
                f_10292_127427_127522(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expressions, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 127427, 127522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_127865_127874(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 127865, 127874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_127891_127900(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 127891, 127900);
                    return return_v;
                }


                int
                f_10292_127842_127908(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 127842, 127908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 114152, 127995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 114152, 127995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint GetTupleValEscape(ImmutableArray<BoundExpression> elements, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 128007, 128442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128148, 128201);

                uint
                narrowestScope = scopeOfTheContainingExpression
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128215, 128393);
                    foreach (var element in f_10292_128239_128247_I(elements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 128215, 128393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128281, 128378);

                        narrowestScope = f_10292_128298_128377(narrowestScope, f_10292_128323_128376(element, scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 128215, 128393);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128409, 128431);

                return narrowestScope;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 128007, 128442);

                uint
                f_10292_128323_128376(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128323, 128376);
                    return return_v;
                }


                uint
                f_10292_128298_128377(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128298, 128377);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_128239_128247_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128239, 128247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 128007, 128442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 128007, 128442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint GetValEscapeOfObjectInitializer(BoundObjectInitializerExpression initExpr, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 128454, 129430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128610, 128644);

                var
                result = Binder.ExternalScope
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128658, 129389);
                    foreach (var expression in f_10292_128685_128706_I(f_10292_128685_128706(initExpr)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 128658, 129389);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128740, 129374) || true) && (f_10292_128744_128759(expression) == BoundKind.AssignmentOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 128740, 129374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128833, 128886);

                            var
                            assignment = (BoundAssignmentOperator)expression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 128908, 128998);

                            result = f_10292_128917_128997(result, f_10292_128934_128996(f_10292_128947_128963(assignment), scopeOfTheContainingExpression));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129022, 129079);

                            var
                            left = (BoundObjectInitializerMember)f_10292_129063_129078(assignment)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129101, 129189);

                            result = f_10292_129110_129188(result, f_10292_129127_129187(f_10292_129140_129154(left), scopeOfTheContainingExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 128740, 129374);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 128740, 129374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129271, 129355);

                            result = f_10292_129280_129354(result, f_10292_129297_129353(expression, scopeOfTheContainingExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 128740, 129374);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 128658, 129389);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129405, 129419);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 128454, 129430);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_128685_128706(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 128685, 128706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_128744_128759(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 128744, 128759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_128947_128963(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 128947, 128963);
                    return return_v;
                }


                uint
                f_10292_128934_128996(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128934, 128996);
                    return return_v;
                }


                uint
                f_10292_128917_128997(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128917, 128997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_129063_129078(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 129063, 129078);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_129140_129154(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 129140, 129154);
                    return return_v;
                }


                uint
                f_10292_129127_129187(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expressions, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129127, 129187);
                    return return_v;
                }


                uint
                f_10292_129110_129188(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129110, 129188);
                    return return_v;
                }


                uint
                f_10292_129297_129353(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129297, 129353);
                    return return_v;
                }


                uint
                f_10292_129280_129354(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129280, 129354);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_128685_128706_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 128685, 128706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 128454, 129430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 128454, 129430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint GetValEscape(ImmutableArray<BoundExpression> expressions, uint scopeOfTheContainingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 129442, 129841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129581, 129615);

                var
                result = Binder.ExternalScope
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129629, 129800);
                    foreach (var expression in f_10292_129656_129667_I(expressions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 129629, 129800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129701, 129785);

                        result = f_10292_129710_129784(result, f_10292_129727_129783(expression, scopeOfTheContainingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 129629, 129800);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 129816, 129830);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 129442, 129841);

                uint
                f_10292_129727_129783(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129727, 129783);
                    return return_v;
                }


                uint
                f_10292_129710_129784(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129710, 129784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_129656_129667_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 129656, 129667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 129442, 129841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 129442, 129841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckValEscape(SyntaxNode node, BoundExpression expr, uint escapeFrom, uint escapeTo, bool checkingReceiver, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 130229, 156368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130410, 130498);

                f_10292_130410_130497(!checkingReceiver || (DynAbs.Tracing.TraceSender.Expression_False(10292, 130423, 130465) || f_10292_130444_130465(f_10292_130444_130453(expr))) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 130423, 130496) || f_10292_130469_130496(f_10292_130469_130478(expr))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130514, 130663) || true) && (escapeTo >= escapeFrom)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 130514, 130663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130636, 130648);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 130514, 130663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130729, 130811) || true) && (f_10292_130733_130750(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 130729, 130811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130784, 130796);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 130729, 130811);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130890, 130981) || true) && (f_10292_130894_130912(expr) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 130890, 130981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 130954, 130966);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 130890, 130981);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131084, 131181) || true) && (f_10292_131088_131112_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10292_131088_131097(expr), 10292, 131088, 131112)?.IsRefLikeType) != true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131084, 131181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131154, 131166);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131084, 131181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131197, 156357);

                switch (f_10292_131205_131214(expr))
                {

                    case BoundKind.DefaultLiteral:
                    case BoundKind.DefaultExpression:
                    case BoundKind.Parameter:
                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131483, 131495);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.TupleLiteral:
                    case BoundKind.ConvertedTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131620, 131666);

                        var
                        tupleLiteral = (BoundTupleExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131688, 131774);

                        return f_10292_131695_131773(f_10292_131715_131737(tupleLiteral), escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.MakeRefOperator:
                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 131940, 131952);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132079, 132091);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.DeconstructValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132176, 132418) || true) && (f_10292_132180_132230(((BoundDeconstructValuePlaceholder)expr)) > escapeTo)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 132176, 132418);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132291, 132356);

                            f_10292_132291_132355(diagnostics, ErrorCode.ERR_EscapeLocal, node, expr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132382, 132395);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 132176, 132418);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132440, 132452);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.AwaitableValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132535, 132775) || true) && (f_10292_132539_132587(((BoundAwaitableValuePlaceholder)expr)) > escapeTo)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 132535, 132775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132648, 132713);

                            f_10292_132648_132712(diagnostics, ErrorCode.ERR_EscapeLocal, node, expr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132739, 132752);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 132535, 132775);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132797, 132809);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132872, 132921);

                        var
                        localSymbol = f_10292_132890_132920(((BoundLocal)expr))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 132943, 133161) || true) && (f_10292_132947_132973(localSymbol) > escapeTo)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 132943, 133161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133034, 133099);

                            f_10292_133034_133098(diagnostics, ErrorCode.ERR_EscapeLocal, node, localSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133125, 133138);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 132943, 133161);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133183, 133195);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.StackAllocArrayCreation:
                    case BoundKind.ConvertedStackAllocExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133339, 133554) || true) && (escapeTo < Binder.TopLevelScope)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 133339, 133554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133424, 133492);

                            f_10292_133424_133491(diagnostics, ErrorCode.ERR_EscapeStackAlloc, node, f_10292_133481_133490(expr));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133518, 133531);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 133339, 133554);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133576, 133588);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.UnconvertedConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133703, 133763);

                            var
                            conditional = (BoundUnconvertedConditionalOperator)expr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 133789, 134147);

                            return
                            f_10292_133825_133969(f_10292_133840_133863(conditional).Syntax, f_10292_133872_133895(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 133825, 134146) && f_10292_134002_134146(f_10292_134017_134040(conditional).Syntax, f_10292_134049_134072(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 134274, 134323);

                            var
                            conditional = (BoundConditionalOperator)expr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 134351, 134512);

                            var
                            consValid = f_10292_134367_134511(f_10292_134382_134405(conditional).Syntax, f_10292_134414_134437(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 134540, 134847) || true) && (!consValid || (DynAbs.Tracing.TraceSender.Expression_False(10292, 134544, 134575) || f_10292_134558_134575(conditional)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 134540, 134847);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 134803, 134820);

                                return consValid;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 134540, 134847);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 134875, 135027);

                            return f_10292_134882_135026(f_10292_134897_134920(conditional).Syntax, f_10292_134929_134952(conditional), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.NullCoalescingOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135130, 135183);

                        var
                        coalescingOp = (BoundNullCoalescingOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135205, 135500);

                        return f_10292_135212_135338(f_10292_135227_135251(coalescingOp).Syntax, f_10292_135260_135284(coalescingOp), escapeFrom, escapeTo, checkingReceiver, diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 135212, 135499) && f_10292_135371_135499(f_10292_135386_135411(coalescingOp).Syntax, f_10292_135420_135445(coalescingOp), escapeFrom, escapeTo, checkingReceiver, diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135569, 135610);

                        var
                        fieldAccess = (BoundFieldAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135632, 135674);

                        var
                        fieldSymbol = f_10292_135650_135673(fieldAccess)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135698, 135904) || true) && (f_10292_135702_135722(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 135702, 135767) || f_10292_135726_135767_M(!f_10292_135727_135753(fieldSymbol).IsRefLikeType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 135698, 135904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135869, 135881);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 135698, 135904);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 135995, 136089);

                        return f_10292_136002_136088(node, f_10292_136023_136046(fieldAccess), escapeFrom, escapeTo, true, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 136151, 136178);

                        var
                        call = (BoundCall)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 136200, 136231);

                        var
                        methodSymbol = f_10292_136219_136230(call)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 136255, 136792);

                        return f_10292_136262_136791(call.Syntax, methodSymbol, f_10292_136387_136403(call), f_10292_136430_136453(methodSymbol), f_10292_136480_136494(call), f_10292_136521_136545(call), f_10292_136572_136592(call), checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 136875, 136932);

                        var
                        ptrInvocation = (BoundFunctionPointerInvocation)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 136954, 137010);

                        var
                        ptrSymbol = f_10292_136970_137009(f_10292_136970_136999(ptrInvocation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 137034, 137597);

                        return f_10292_137041_137596(ptrInvocation.Syntax, ptrSymbol, receiverOpt: null, f_10292_137216_137236(ptrSymbol), f_10292_137263_137286(ptrInvocation), f_10292_137313_137346(ptrInvocation), argsToParamsOpt: default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 137668, 137713);

                        var
                        indexerAccess = (BoundIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 137735, 137777);

                        var
                        indexerSymbol = f_10292_137755_137776(indexerAccess)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 137801, 138385);

                        return f_10292_137808_138384(indexerAccess.Syntax, indexerSymbol, f_10292_137943_137968(indexerAccess), f_10292_137995_138019(indexerSymbol), f_10292_138046_138069(indexerAccess), f_10292_138096_138129(indexerAccess), f_10292_138156_138185(indexerAccess), checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138475, 138540);

                        var
                        patternIndexer = (BoundIndexOrRangePatternIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138562, 138611);

                        var
                        patternSymbol = f_10292_138582_138610(patternIndexer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138633, 138901);

                        var
                        parameters = patternSymbol switch
                        {
                            PropertySymbol p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138719, 138751) && DynAbs.Tracing.TraceSender.Expression_True(10292, 138719, 138751))
=> f_10292_138739_138751(p),
                            MethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138778, 138808) && DynAbs.Tracing.TraceSender.Expression_True(10292, 138778, 138808))
=> f_10292_138796_138808(m),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138835, 138876) && DynAbs.Tracing.TraceSender.Expression_True(10292, 138835, 138876))
=> throw f_10292_138846_138876(),
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 138925, 139469);

                        return f_10292_138932_139468(patternIndexer.Syntax, patternSymbol, f_10292_139068_139091(patternIndexer), parameters, f_10292_139155_139201(f_10292_139177_139200(patternIndexer)), default, default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 139541, 139588);

                        var
                        propertyAccess = (BoundPropertyAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 139673, 140194);

                        return f_10292_139680_140193(propertyAccess.Syntax, f_10292_139776_139805(propertyAccess), f_10292_139832_139858(propertyAccess), default, default, default, default, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 140276, 140333);

                        var
                        objectCreation = (BoundObjectCreationExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 140355, 140406);

                        var
                        constructorSymbol = f_10292_140379_140405(objectCreation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 140430, 141011);

                        var
                        escape = f_10292_140443_141010(objectCreation.Syntax, constructorSymbol, null, f_10292_140614_140642(constructorSymbol), f_10292_140669_140693(objectCreation), f_10292_140720_140754(objectCreation), f_10292_140781_140811(objectCreation), checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141035, 141097);

                        var
                        initializerExpr = f_10292_141057_141096(objectCreation)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141119, 141595) || true) && (initializerExpr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 141119, 141595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141196, 141572);

                            escape = escape && (DynAbs.Tracing.TraceSender.Expression_True(10292, 141205, 141571) && f_10292_141244_141571(initializerExpr.Syntax, initializerExpr, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 141119, 141595);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141619, 141633);

                        return escape;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.UnaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141704, 141741);

                        var
                        unary = (BoundUnaryOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141763, 141879);

                        return f_10292_141770_141878(node, f_10292_141791_141804(unary), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 141947, 141986);

                        var
                        conversion = (BoundConversion)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142008, 142122);

                        f_10292_142008_142121(f_10292_142021_142046(conversion) != ConversionKind.StackAllocToSpanType, "StackAllocToSpanType unexpected");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142144, 142265);

                        return f_10292_142151_142264(node, f_10292_142172_142190(conversion), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142341, 142388);

                        var
                        assignment = (BoundAssignmentOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142410, 142528);

                        return f_10292_142417_142527(node, f_10292_142438_142453(assignment), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.IncrementOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142603, 142648);

                        var
                        increment = (BoundIncrementOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142670, 142790);

                        return f_10292_142677_142789(node, f_10292_142698_142715(increment), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.CompoundAssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142874, 142927);

                        var
                        compound = (BoundCompoundAssignmentOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 142951, 143241);

                        return f_10292_142958_143082(f_10292_142973_142986(compound).Syntax, f_10292_142995_143008(compound), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 142958, 143240) && f_10292_143114_143240(f_10292_143129_143143(compound).Syntax, f_10292_143152_143166(compound), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.BinaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 143313, 143352);

                        var
                        binary = (BoundBinaryOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 143376, 143658);

                        return f_10292_143383_143503(f_10292_143398_143409(binary).Syntax, f_10292_143418_143429(binary), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 143383, 143657) && f_10292_143535_143657(f_10292_143550_143562(binary).Syntax, f_10292_143571_143583(binary), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.UserDefinedConditionalLogicalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 143753, 143811);

                        var
                        uo = (BoundUserDefinedConditionalLogicalOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 143835, 144101);

                        return f_10292_143842_143954(f_10292_143857_143864(uo).Syntax, f_10292_143873_143880(uo), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 143842, 144100) && f_10292_143986_144100(f_10292_144001_144009(uo).Syntax, f_10292_144018_144026(uo), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.QueryClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144170, 144219);

                        var
                        clauseValue = f_10292_144188_144218(((BoundQueryClause)expr))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144241, 144369);

                        return f_10292_144248_144368(clauseValue.Syntax, clauseValue, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144440, 144493);

                        var
                        variableValue = f_10292_144460_144492(((BoundRangeVariable)expr))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144515, 144647);

                        return f_10292_144522_144646(variableValue.Syntax, variableValue, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.ObjectInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144732, 144786);

                        var
                        initExpr = (BoundObjectInitializerExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 144808, 144894);

                        return f_10292_144815_144893(initExpr, escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.CollectionInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145192, 145249);

                        var
                        colExpr = (BoundCollectionInitializerExpression)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145271, 145350);

                        return f_10292_145278_145349(f_10292_145293_145313(colExpr), escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.CollectionElementInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145642, 145699);

                        var
                        colElement = (BoundCollectionElementInitializer)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145721, 145800);

                        return f_10292_145728_145799(f_10292_145743_145763(colElement), escapeFrom, escapeTo, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145878, 145948);

                        var
                        accessedExpression = f_10292_145903_145947(((BoundPointerElementAccess)expr))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 145970, 146092);

                        return f_10292_145977_146091(accessedExpression.Syntax, accessedExpression, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.PointerIndirectionOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146176, 146248);

                        var
                        operandExpression = f_10292_146200_146247(((BoundPointerIndirectionOperator)expr))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146270, 146390);

                        return f_10292_146277_146389(operandExpression.Syntax, operandExpression, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.AsOperator:
                    case BoundKind.AwaitExpression:
                    case BoundKind.ConditionalAccess:
                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146677, 146690);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    case BoundKind.UnconvertedSwitchExpression:
                    case BoundKind.ConvertedSwitchExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146834, 147175);
                            foreach (var arm in f_10292_146854_146894_I(f_10292_146854_146894(((BoundSwitchExpression)expr))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 146834, 147175);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146944, 146967);

                                var
                                result = f_10292_146957_146966(arm)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 146993, 147152) || true) && (!f_10292_146998_147108(result.Syntax, result, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 146993, 147152);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 147139, 147152);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 146993, 147152);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 146834, 147175);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 342);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 342);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 147199, 147211);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 131197, 156357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 147504, 147571);

                        f_10292_147504_147570(false, $"{f_10292_147527_147536(expr)} expression of {f_10292_147553_147562(expr)} type");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 147593, 147653);

                        f_10292_147593_147652(diagnostics, ErrorCode.ERR_InternalError, f_10292_147638_147651(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 147675, 147688);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 131197, 156357);

                        //                case BoundKind.ThrowExpression:
                        //                case BoundKind.ArgListOperator:
                        //                case BoundKind.ArgList:
                        //                case BoundKind.RefTypeOperator:
                        //                case BoundKind.AddressOfOperator:
                        //                case BoundKind.TypeOfOperator:
                        //                case BoundKind.IsOperator:
                        //                case BoundKind.SizeOfOperator:
                        //                case BoundKind.DynamicMemberAccess:
                        //                case BoundKind.DynamicInvocation:
                        //                case BoundKind.NewT:
                        //                case BoundKind.DelegateCreationExpression:
                        //                case BoundKind.ArrayCreation:
                        //                case BoundKind.AnonymousObjectCreationExpression:
                        //                case BoundKind.NameOfOperator:
                        //                case BoundKind.InterpolatedString:
                        //                case BoundKind.StringInsert:
                        //                case BoundKind.DynamicIndexerAccess:
                        //                case BoundKind.Lambda:
                        //                case BoundKind.DynamicObjectCreationExpression:
                        //                case BoundKind.NoPiaObjectCreationExpression:
                        //                case BoundKind.BaseReference:
                        //                case BoundKind.Literal:
                        //                case BoundKind.IsPatternExpression:
                        //                case BoundKind.DeconstructionAssignmentOperator:
                        //                case BoundKind.EventAccess:


                        //                case BoundKind.FieldEqualsValue:
                        //                case BoundKind.PropertyEqualsValue:
                        //                case BoundKind.ParameterEqualsValue:
                        //                case BoundKind.NamespaceExpression:
                        //                case BoundKind.TypeExpression:
                        //                case BoundKind.BadStatement:
                        //                case BoundKind.MethodDefIndex:
                        //                case BoundKind.SourceDocumentIndex:
                        //                case BoundKind.ArgList:
                        //                case BoundKind.ArgListOperator:
                        //                case BoundKind.Block:
                        //                case BoundKind.Scope:
                        //                case BoundKind.NoOpStatement:
                        //                case BoundKind.ReturnStatement:
                        //                case BoundKind.YieldReturnStatement:
                        //                case BoundKind.YieldBreakStatement:
                        //                case BoundKind.ThrowStatement:
                        //                case BoundKind.ExpressionStatement:
                        //                case BoundKind.SwitchStatement:
                        //                case BoundKind.SwitchSection:
                        //                case BoundKind.SwitchLabel:
                        //                case BoundKind.BreakStatement:
                        //                case BoundKind.LocalFunctionStatement:
                        //                case BoundKind.ContinueStatement:
                        //                case BoundKind.PatternSwitchStatement:
                        //                case BoundKind.PatternSwitchSection:
                        //                case BoundKind.PatternSwitchLabel:
                        //                case BoundKind.IfStatement:
                        //                case BoundKind.DoStatement:
                        //                case BoundKind.WhileStatement:
                        //                case BoundKind.ForStatement:
                        //                case BoundKind.ForEachStatement:
                        //                case BoundKind.ForEachDeconstructStep:
                        //                case BoundKind.UsingStatement:
                        //                case BoundKind.FixedStatement:
                        //                case BoundKind.LockStatement:
                        //                case BoundKind.TryStatement:
                        //                case BoundKind.CatchBlock:
                        //                case BoundKind.LabelStatement:
                        //                case BoundKind.GotoStatement:
                        //                case BoundKind.LabeledStatement:
                        //                case BoundKind.Label:
                        //                case BoundKind.StatementList:
                        //                case BoundKind.ConditionalGoto:
                        //                case BoundKind.LocalDeclaration:
                        //                case BoundKind.MultipleLocalDeclarations:
                        //                case BoundKind.ArrayInitialization:
                        //                case BoundKind.AnonymousPropertyDeclaration:
                        //                case BoundKind.MethodGroup:
                        //                case BoundKind.PropertyGroup:
                        //                case BoundKind.EventAssignmentOperator:
                        //                case BoundKind.Attribute:
                        //                case BoundKind.FixedLocalCollectionInitializer:
                        //                case BoundKind.DynamicObjectInitializerMember:
                        //                case BoundKind.DynamicCollectionElementInitializer:
                        //                case BoundKind.ImplicitReceiver:
                        //                case BoundKind.FieldInitializer:
                        //                case BoundKind.GlobalStatementInitializer:
                        //                case BoundKind.TypeOrInstanceInitializers:
                        //                case BoundKind.DeclarationPattern:
                        //                case BoundKind.ConstantPattern:
                        //                case BoundKind.WildcardPattern:


                        //                case BoundKind.MaximumMethodDefIndex:
                        //                case BoundKind.InstrumentationPayloadRoot:
                        //                case BoundKind.ModuleVersionId:
                        //                case BoundKind.ModuleVersionIdString:
                        //                case BoundKind.Dup:
                        //                case BoundKind.TypeOrValueExpression:
                        //                case BoundKind.BadExpression:
                        //                case BoundKind.ArrayLength:
                        //                case BoundKind.MethodInfo:
                        //                case BoundKind.FieldInfo:
                        //                case BoundKind.SequencePoint:
                        //                case BoundKind.SequencePointExpression:
                        //                case BoundKind.SequencePointWithSpan:
                        //                case BoundKind.StateMachineScope:
                        //                case BoundKind.ConditionalReceiver:
                        //                case BoundKind.ComplexConditionalReceiver:
                        //                case BoundKind.PreviousSubmissionReference:
                        //                case BoundKind.HostObjectMemberReference:
                        //                case BoundKind.UnboundLambda:
                        //                case BoundKind.LoweredConditionalAccess:
                        //                case BoundKind.Sequence:
                        //                case BoundKind.HoistedFieldAccess:
                        //                case BoundKind.OutVariablePendingInference:
                        //                case BoundKind.DeconstructionVariablePendingInference:
                        //                case BoundKind.OutDeconstructVarPendingInference:
                        //                case BoundKind.PseudoVariable:

                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 130229, 156368);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_130444_130453(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 130444, 130453);
                    return return_v;
                }


                bool
                f_10292_130444_130465(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 130444, 130465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_130469_130478(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 130469, 130478);
                    return return_v;
                }


                bool
                f_10292_130469_130496(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 130469, 130496);
                    return return_v;
                }


                int
                f_10292_130410_130497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 130410, 130497);
                    return 0;
                }


                bool
                f_10292_130733_130750(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 130733, 130750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10292_130894_130912(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 130894, 130912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10292_131088_131097(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 131088, 131097);
                    return return_v;
                }


                bool?
                f_10292_131088_131112_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 131088, 131112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_131205_131214(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 131205, 131214);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_131715_131737(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 131715, 131737);
                    return return_v;
                }


                bool
                f_10292_131695_131773(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckTupleValEscape(elements, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 131695, 131773);
                    return return_v;
                }


                uint
                f_10292_132180_132230(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                this_param)
                {
                    var return_v = this_param.ValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 132180, 132230);
                    return return_v;
                }


                int
                f_10292_132291_132355(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 132291, 132355);
                    return 0;
                }


                uint
                f_10292_132539_132587(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                this_param)
                {
                    var return_v = this_param.ValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 132539, 132587);
                    return return_v;
                }


                int
                f_10292_132648_132712(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 132648, 132712);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10292_132890_132920(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 132890, 132920);
                    return return_v;
                }


                uint
                f_10292_132947_132973(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ValEscapeScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 132947, 132973);
                    return return_v;
                }


                int
                f_10292_133034_133098(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 133034, 133098);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_133481_133490(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 133481, 133490);
                    return return_v;
                }


                int
                f_10292_133424_133491(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 133424, 133491);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_133840_133863(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 133840, 133863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_133872_133895(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 133872, 133895);
                    return return_v;
                }


                bool
                f_10292_133825_133969(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 133825, 133969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134017_134040(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134017, 134040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134049_134072(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134049, 134072);
                    return return_v;
                }


                bool
                f_10292_134002_134146(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 134002, 134146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134382_134405(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134382, 134405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134414_134437(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134414, 134437);
                    return return_v;
                }


                bool
                f_10292_134367_134511(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 134367, 134511);
                    return return_v;
                }


                bool
                f_10292_134558_134575(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134558, 134575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134897_134920(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134897, 134920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_134929_134952(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 134929, 134952);
                    return return_v;
                }


                bool
                f_10292_134882_135026(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 134882, 135026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_135227_135251(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135227, 135251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_135260_135284(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135260, 135284);
                    return return_v;
                }


                bool
                f_10292_135212_135338(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 135212, 135338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_135386_135411(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135386, 135411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_135420_135445(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135420, 135445);
                    return return_v;
                }


                bool
                f_10292_135371_135499(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 135371, 135499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_135650_135673(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135650, 135673);
                    return return_v;
                }


                bool
                f_10292_135702_135722(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135702, 135722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_135727_135753(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135727, 135753);
                    return return_v;
                }


                bool
                f_10292_135726_135767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 135726, 135767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_136023_136046(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136023, 136046);
                    return return_v;
                }


                bool
                f_10292_136002_136088(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 136002, 136088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_136219_136230(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136219, 136230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_136387_136403(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136387, 136403);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_136430_136453(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136430, 136453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_136480_136494(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136480, 136494);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_136521_136545(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136521, 136545);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_136572_136592(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136572, 136592);
                    return return_v;
                }


                bool
                f_10292_136262_136791(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 136262, 136791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10292_136970_136999(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136970, 136999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10292_136970_137009(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 136970, 137009);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_137216_137236(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137216, 137236);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_137263_137286(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137263, 137286);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_137313_137346(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137313, 137346);
                    return return_v;
                }


                bool
                f_10292_137041_137596(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt: receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt: argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 137041, 137596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_137755_137776(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137755, 137776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_137943_137968(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137943, 137968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_137995_138019(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 137995, 138019);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_138046_138069(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138046, 138069);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_138096_138129(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138096, 138129);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_138156_138185(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138156, 138185);
                    return return_v;
                }


                bool
                f_10292_137808_138384(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 137808, 138384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10292_138582_138610(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138582, 138610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_138739_138751(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138739, 138751);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_138796_138808(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138796, 138808);
                    return return_v;
                }


                System.Exception
                f_10292_138846_138876()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 138846, 138876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_139068_139091(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 139068, 139091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_139177_139200(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 139177, 139200);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_139155_139201(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 139155, 139201);
                    return return_v;
                }


                bool
                f_10292_138932_139468(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 138932, 139468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10292_139776_139805(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 139776, 139805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_139832_139858(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 139832, 139858);
                    return return_v;
                }


                bool
                f_10292_139680_140193(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 139680, 140193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10292_140379_140405(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 140379, 140405);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10292_140614_140642(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 140614, 140642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_140669_140693(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 140669, 140693);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10292_140720_140754(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 140720, 140754);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10292_140781_140811(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 140781, 140811);
                    return return_v;
                }


                bool
                f_10292_140443_141010(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                checkingReceiver, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isRefEscape)
                {
                    var return_v = CheckInvocationEscape(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argRefKindsOpt, argsToParamsOpt, checkingReceiver, escapeFrom, escapeTo, diagnostics, isRefEscape: isRefEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 140443, 141010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10292_141057_141096(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 141057, 141096);
                    return return_v;
                }


                bool
                f_10292_141244_141571(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 141244, 141571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_141791_141804(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 141791, 141804);
                    return return_v;
                }


                bool
                f_10292_141770_141878(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 141770, 141878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10292_142021_142046(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142021, 142046);
                    return return_v;
                }


                int
                f_10292_142008_142121(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 142008, 142121);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_142172_142190(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142172, 142190);
                    return return_v;
                }


                bool
                f_10292_142151_142264(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 142151, 142264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_142438_142453(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142438, 142453);
                    return return_v;
                }


                bool
                f_10292_142417_142527(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 142417, 142527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_142698_142715(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142698, 142715);
                    return return_v;
                }


                bool
                f_10292_142677_142789(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 142677, 142789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_142973_142986(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142973, 142986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_142995_143008(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 142995, 143008);
                    return return_v;
                }


                bool
                f_10292_142958_143082(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 142958, 143082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143129_143143(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143129, 143143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143152_143166(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143152, 143166);
                    return return_v;
                }


                bool
                f_10292_143114_143240(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 143114, 143240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143398_143409(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143398, 143409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143418_143429(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143418, 143429);
                    return return_v;
                }


                bool
                f_10292_143383_143503(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 143383, 143503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143550_143562(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143550, 143562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143571_143583(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143571, 143583);
                    return return_v;
                }


                bool
                f_10292_143535_143657(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 143535, 143657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143857_143864(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143857, 143864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_143873_143880(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 143873, 143880);
                    return return_v;
                }


                bool
                f_10292_143842_143954(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 143842, 143954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_144001_144009(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 144001, 144009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_144018_144026(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 144018, 144026);
                    return return_v;
                }


                bool
                f_10292_143986_144100(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 143986, 144100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_144188_144218(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 144188, 144218);
                    return return_v;
                }


                bool
                f_10292_144248_144368(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 144248, 144368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_144460_144492(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 144460, 144492);
                    return return_v;
                }


                bool
                f_10292_144522_144646(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 144522, 144646);
                    return return_v;
                }


                bool
                f_10292_144815_144893(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                initExpr, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscapeOfObjectInitializer(initExpr, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 144815, 144893);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_145293_145313(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 145293, 145313);
                    return return_v;
                }


                bool
                f_10292_145278_145349(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(expressions, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 145278, 145349);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_145743_145763(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 145743, 145763);
                    return return_v;
                }


                bool
                f_10292_145728_145799(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(expressions, escapeFrom, escapeTo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 145728, 145799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_145903_145947(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 145903, 145947);
                    return return_v;
                }


                bool
                f_10292_145977_146091(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 145977, 146091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_146200_146247(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 146200, 146247);
                    return return_v;
                }


                bool
                f_10292_146277_146389(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 146277, 146389);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10292_146854_146894(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 146854, 146894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_146957_146966(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 146957, 146966);
                    return return_v;
                }


                bool
                f_10292_146998_147108(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 146998, 147108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10292_146854_146894_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 146854, 146894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_147527_147536(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 147527, 147536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10292_147553_147562(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 147553, 147562);
                    return return_v;
                }


                int
                f_10292_147504_147570(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 147504, 147570);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10292_147638_147651(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 147638, 147651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10292_147593_147652(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 147593, 147652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 130229, 156368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 130229, 156368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckTupleValEscape(ImmutableArray<BoundExpression> elements, uint escapeFrom, uint escapeTo, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 156380, 156856);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 156545, 156817);
                    foreach (var element in f_10292_156569_156577_I(elements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 156545, 156817);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 156611, 156802) || true) && (!f_10292_156616_156728(element.Syntax, element, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 156611, 156802);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 156770, 156783);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 156611, 156802);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 156545, 156817);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 156833, 156845);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 156380, 156856);

                bool
                f_10292_156616_156728(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 156616, 156728);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_156569_156577_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 156569, 156577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 156380, 156856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 156380, 156856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckValEscapeOfObjectInitializer(BoundObjectInitializerExpression initExpr, uint escapeFrom, uint escapeTo, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 156868, 158149);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157048, 158110);
                    foreach (var expression in f_10292_157075_157096_I(f_10292_157075_157096(initExpr)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157048, 158110);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157130, 158095) || true) && (f_10292_157134_157149(expression) == BoundKind.AssignmentOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157130, 158095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157223, 157276);

                            var
                            assignment = (BoundAssignmentOperator)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157298, 157513) || true) && (!f_10292_157303_157427(expression.Syntax, f_10292_157337_157353(assignment), escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157298, 157513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157477, 157490);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157298, 157513);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157537, 157594);

                            var
                            left = (BoundObjectInitializerMember)f_10292_157578_157593(assignment)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157616, 157785) || true) && (!f_10292_157621_157699(f_10292_157636_157650(left), escapeFrom, escapeTo, diagnostics: diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157616, 157785);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157749, 157762);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157616, 157785);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157130, 158095);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157130, 158095);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 157867, 158076) || true) && (!f_10292_157872_157990(expression.Syntax, expression, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 157867, 158076);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158040, 158053);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157867, 158076);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157130, 158095);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 157048, 158110);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 1063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 1063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158126, 158138);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 156868, 158149);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_157075_157096(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 157075, 157096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_157134_157149(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 157134, 157149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_157337_157353(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 157337, 157353);
                    return return_v;
                }


                bool
                f_10292_157303_157427(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 157303, 157427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10292_157578_157593(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 157578, 157593);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_157636_157650(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 157636, 157650);
                    return return_v;
                }


                bool
                f_10292_157621_157699(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions, uint
                escapeFrom, uint
                escapeTo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(expressions, escapeFrom, escapeTo, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 157621, 157699);
                    return return_v;
                }


                bool
                f_10292_157872_157990(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 157872, 157990);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_157075_157096_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 157075, 157096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 156868, 158149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 156868, 158149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckValEscape(ImmutableArray<BoundExpression> expressions, uint escapeFrom, uint escapeTo, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 158161, 158647);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158324, 158608);
                    foreach (var expression in f_10292_158351_158362_I(expressions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 158324, 158608);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158396, 158593) || true) && (!f_10292_158401_158519(expression.Syntax, expression, escapeFrom, escapeTo, checkingReceiver: false, diagnostics: diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 158396, 158593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158561, 158574);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 158396, 158593);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 158324, 158608);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10292, 1, 285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10292, 1, 285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 158624, 158636);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 158161, 158647);

                bool
                f_10292_158401_158519(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeFrom, uint
                escapeTo, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckValEscape(node, expr, escapeFrom, escapeTo, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 158401, 158519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10292_158351_158362_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 158351, 158362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 158161, 158647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 158161, 158647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal enum AddressKind
        {
            // reference may be written to
            Writeable,

            // reference itself will not be written to, but may be used for call, callvirt.
            // for all purposes it is the same as Writeable, except when fetching an address of an array element
            // where it results in a ".readonly" prefix to deal with array covariance.
            Constrained,

            // reference itself will not be written to, nor it will be used to modify fields.
            ReadOnly,

            // same as ReadOnly, but we are not supposed to get a reference to a clone
            // regardless of compat settings.
            ReadOnlyStrict,
        }

        internal static bool IsAnyReadOnly(AddressKind addressKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10292, 159455, 159493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 159458, 159493);
                return addressKind >= AddressKind.ReadOnly; DynAbs.Tracing.TraceSender.TraceExitMethod(10292, 159455, 159493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 159455, 159493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 159455, 159493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Checks if expression directly or indirectly represents a value with its own home. In
        /// such cases it is possible to get a reference without loading into a temporary.
        /// </summary>
        internal static bool HasHome(
            BoundExpression expression,
            AddressKind addressKind,
            MethodSymbol method,
            bool peVerifyCompatEnabled,
            HashSet<LocalSymbol> stackLocalsOpt)
        {
            Debug.Assert(method is object);

            switch (expression.Kind)
            {
                case BoundKind.ArrayAccess:
                    if (addressKind == AddressKind.ReadOnly && !expression.Type.IsValueType && peVerifyCompatEnabled)
                    {
                        // due to array covariance getting a reference may throw ArrayTypeMismatch when element is not a struct, 
                        // passing "readonly." prefix would prevent that, but it is unverifiable, so will make a copy in compat case
                        return false;
                    }

                    return true;

                case BoundKind.PointerIndirectionOperator:
                case BoundKind.RefValueOperator:
                    return true;

                case BoundKind.ThisReference:
                    var type = expression.Type;
                    if (type.IsReferenceType)
                    {
                        Debug.Assert(IsAnyReadOnly(addressKind), "`this` is readonly in classes");
                        return true;
                    }

                    if (!IsAnyReadOnly(addressKind) && method.IsEffectivelyReadOnly)
                    {
                        return false;
                    }

                    return true;

                case BoundKind.ThrowExpression:
                    // vacuously this is true, we can take address of throw without temps
                    return true;

                case BoundKind.Parameter:
                    return IsAnyReadOnly(addressKind) ||
                        ((BoundParameter)expression).ParameterSymbol.RefKind != RefKind.In;

                case BoundKind.Local:
                    // locals have home unless they are byval stack locals or ref-readonly
                    // locals in a mutating call
                    var local = ((BoundLocal)expression).LocalSymbol;
                    return !((CodeGenerator.IsStackLocal(local, stackLocalsOpt) && local.RefKind == RefKind.None) ||
                        (!IsAnyReadOnly(addressKind) && local.RefKind == RefKind.RefReadOnly));

                case BoundKind.Call:
                    var methodRefKind = ((BoundCall)expression).Method.RefKind;
                    return methodRefKind == RefKind.Ref ||
                           (IsAnyReadOnly(addressKind) && methodRefKind == RefKind.RefReadOnly);

                case BoundKind.Dup:
                    //NB: Dup represents locals that do not need IL slot
                    var dupRefKind = ((BoundDup)expression).RefKind;
                    return dupRefKind == RefKind.Ref ||
                        (IsAnyReadOnly(addressKind) && dupRefKind == RefKind.RefReadOnly);

                case BoundKind.FieldAccess:
                    return HasHome((BoundFieldAccess)expression, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);

                case BoundKind.Sequence:
                    return HasHome(((BoundSequence)expression).Value, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);

                case BoundKind.AssignmentOperator:
                    var assignment = (BoundAssignmentOperator)expression;
                    if (!assignment.IsRef)
                    {
                        return false;
                    }
                    var lhsRefKind = assignment.Left.GetRefKind();
                    return lhsRefKind == RefKind.Ref ||
                        (IsAnyReadOnly(addressKind) && lhsRefKind == RefKind.RefReadOnly);

                case BoundKind.ComplexConditionalReceiver:
                    Debug.Assert(HasHome(
                        ((BoundComplexConditionalReceiver)expression).ValueTypeReceiver,
                        addressKind,
                        method,
                        peVerifyCompatEnabled,
                        stackLocalsOpt));
                    Debug.Assert(HasHome(
                        ((BoundComplexConditionalReceiver)expression).ReferenceTypeReceiver,
                        addressKind,
                        method,
                        peVerifyCompatEnabled,
                        stackLocalsOpt));
                    goto case BoundKind.ConditionalReceiver;

                case BoundKind.ConditionalReceiver:
                    //ConditionalReceiver is a noop from Emit point of view. - it represents something that has already been pushed. 
                    //We should never need a temp for it. 
                    return true;

                case BoundKind.ConditionalOperator:
                    var conditional = (BoundConditionalOperator)expression;

                    // only ref conditional may be referenced as a variable
                    if (!conditional.IsRef)
                    {
                        return false;
                    }

                    // branch that has no home will need a temporary
                    // if both have no home, just say whole expression has no home 
                    // so we could just use one temp for the whole thing
                    return HasHome(conditional.Consequence, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt)
                        && HasHome(conditional.Alternative, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);

                default:
                    return false;
            }
        }

        private static bool HasHome(
                    BoundFieldAccess fieldAccess,
                    AddressKind addressKind,
                    MethodSymbol method,
                    bool peVerifyCompatEnabled,
                    HashSet<LocalSymbol> stackLocalsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10292, 165777, 169242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166036, 166067);

                f_10292_166036_166066(method is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166083, 166127);

                FieldSymbol
                field = f_10292_166103_166126(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166225, 166304) || true) && (f_10292_166229_166242(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 166225, 166304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166276, 166289);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 166225, 166304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166426, 166532) || true) && (addressKind == AddressKind.ReadOnlyStrict)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 166426, 166532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166505, 166517);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 166426, 166532);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166642, 166768) || true) && (addressKind == AddressKind.ReadOnly && (DynAbs.Tracing.TraceSender.Expression_True(10292, 166646, 166707) && !peVerifyCompatEnabled))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 166642, 166768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166741, 166753);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 166642, 166768);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166862, 166949) || true) && (f_10292_166866_166887(fieldAccess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 166862, 166949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166921, 166934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 166862, 166949);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 166965, 168590) || true) && (f_10292_166969_166986_M(!field.IsReadOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 166965, 168590);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 167608, 168543) || true) && (!peVerifyCompatEnabled)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 167608, 168543);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 167676, 167718);

                        f_10292_167676_167717(!f_10292_167690_167716(addressKind));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 167742, 167781);

                        var
                        receiver = f_10292_167757_167780(fieldAccess)
                        ;

                        // LAFHIS
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 167803, 168524) || true) && f_10292_167816_167833(f_10292_167807_167833_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiver, 10292, 167807, 167833)?.Type)) == true)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 167803, 168524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168296, 168501);

                            return f_10292_168303_168380(receiver, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt) || (DynAbs.Tracing.TraceSender.Expression_False(10292, 168303, 168500) || !f_10292_168414_168500(receiver, AddressKind.ReadOnly, method, peVerifyCompatEnabled, stackLocalsOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 167803, 168524);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 167608, 168543);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168563, 168575);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 166965, 168590);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168708, 168871) || true) && (!f_10292_168713_168809(f_10292_168731_168751(field), f_10292_168753_168774(method), TypeCompareKind.AllIgnoreOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 168708, 168871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168843, 168856);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 168708, 168871);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168887, 169231) || true) && (f_10292_168891_168905(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 168887, 169231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 168939, 168996);

                    return f_10292_168946_168963(method) == MethodKind.StaticConstructor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 168887, 169231);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10292, 168887, 169231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 169062, 169216);

                    return (f_10292_169070_169087(method) == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10292, 169070, 169134) || f_10292_169117_169134(method))) && (DynAbs.Tracing.TraceSender.Expression_True(10292, 169069, 169215) && f_10292_169160_169188(f_10292_169160_169183(fieldAccess)) == BoundKind.ThisReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10292, 168887, 169231);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10292, 165777, 169242);

                int
                f_10292_166036_166066(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 166036, 166066);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10292_166103_166126(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 166103, 166126);
                    return return_v;
                }


                bool
                f_10292_166229_166242(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 166229, 166242);
                    return return_v;
                }


                bool
                f_10292_166866_166887(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.IsByValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 166866, 166887);
                    return return_v;
                }


                bool
                f_10292_166969_166986_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 166969, 166986);
                    return return_v;
                }


                bool
                f_10292_167690_167716(Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = IsAnyReadOnly(addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 167690, 167716);
                    return return_v;
                }


                int
                f_10292_167676_167717(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 167676, 167717);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_167757_167780(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 167757, 167780);
                    return return_v;
                }


                bool?
                f_10292_167816_167833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param?.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 167816, 167833);
                    return return_v;
                }


                TypeSymbol?
                f_10292_167807_167833_M(TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 167807, 167833);
                    return return_v;
                }


                bool
                f_10292_168303_168380(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                peVerifyCompatEnabled, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                stackLocalsOpt)
                {
                    var return_v = HasHome(expression, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 168303, 168380);
                    return return_v;
                }


                bool
                f_10292_168414_168500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                peVerifyCompatEnabled, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                stackLocalsOpt)
                {
                    var return_v = HasHome(expression, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 168414, 168500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_168731_168751(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 168731, 168751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10292_168753_168774(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 168753, 168774);
                    return return_v;
                }


                bool
                f_10292_168713_168809(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10292, 168713, 168809);
                    return return_v;
                }


                bool
                f_10292_168891_168905(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 168891, 168905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10292_168946_168963(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 168946, 168963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10292_169070_169087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 169070, 169087);
                    return return_v;
                }


                bool
                f_10292_169117_169134(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 169117, 169134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10292_169160_169183(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 169160, 169183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10292_169160_169188(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10292, 169160, 169188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10292, 165777, 169242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10292, 165777, 169242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
