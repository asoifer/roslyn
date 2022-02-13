// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal abstract partial class BoundNode
    {
        private readonly BoundKind _kind;

        private BoundNodeAttributes _attributes;

        public readonly SyntaxNode Syntax;

        [Flags()]
        private enum BoundNodeAttributes : short
        {
            HasErrors = 1 << 0,
            CompilerGenerated = 1 << 1,
            IsSuppressed = 1 << 2,

            // Bit 3: 1 if the node has maybe-null state, 0 if the node is not null
            // Bits 4 and 5: 01 if the node is not annotated, 10 if the node is annotated, 11 if the node is disabled
            TopLevelFlowStateMaybeNull = 1 << 3,
            TopLevelNotAnnotated = 1 << 4,
            TopLevelAnnotated = 1 << 5,
            TopLevelNone = TopLevelAnnotated | TopLevelNotAnnotated,
            TopLevelAnnotationMask = TopLevelNone,

            /// <summary>
            /// Captures the fact that consumers of the node already checked the state of the WasCompilerGenerated bit.
            /// Allows to assert on attempts to set WasCompilerGenerated bit after that.
            /// </summary>
            WasCompilerGeneratedIsChecked = 1 << 6,
            WasTopLevelNullabilityChecked = 1 << 7,

            /// <summary>
            /// Captures the fact that the node was either converted to some type, or converted to its natural
            /// type.  This is used to check the fact that every rvalue must pass through one of the two,
            /// so that expressions like tuple literals and switch expressions can reliably be rewritten once
            /// the target type is known.
            /// </summary>
            WasConverted = 1 << 8,

            AttributesPreservedInClone = HasErrors | CompilerGenerated | IsSuppressed | WasConverted,
        }

        protected new BoundNode MemberwiseClone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 2526, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 2592, 2639);

                var
                result = (BoundNode)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.MemberwiseClone(), 10562, 2616, 2638)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 2653, 2722);

                result._attributes &= BoundNodeAttributes.AttributesPreservedInClone;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 2736, 2750);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 2526, 2761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 2526, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 2526, 2761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundNode(BoundKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10562, 2773, 3173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 591, 596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 635, 646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 896, 902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 2852, 3098);

                f_10562_2852_3097(kind == BoundKind.SequencePoint || (DynAbs.Tracing.TraceSender.Expression_False(10562, 2883, 2976) || kind == BoundKind.SequencePointExpression) || (DynAbs.Tracing.TraceSender.Expression_False(10562, 2883, 3029) || kind == (BoundKind)byte.MaxValue) || (DynAbs.Tracing.TraceSender.Expression_False(10562, 2883, 3096) || syntax != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 3114, 3127);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 3141, 3162);

                this.Syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10562, 2773, 3173);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 2773, 3173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 2773, 3173);
            }
        }

        protected BoundNode(BoundKind kind, SyntaxNode syntax, bool hasErrors)
        : this(f_10562_3276_3280_C(kind), syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10562, 3185, 3431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 3314, 3420) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 3314, 3420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 3361, 3405);

                    _attributes = BoundNodeAttributes.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 3314, 3420);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10562, 3185, 3431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 3185, 3431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 3185, 3431);
            }
        }

        public bool HasAnyErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 3856, 4357);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 4010, 4149) || true) && (f_10562_4014_4028(this) || (DynAbs.Tracing.TraceSender.Expression_False(10562, 4014, 4076) || this.Syntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10562, 4032, 4076) && f_10562_4055_4076(this.Syntax))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 4010, 4149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 4118, 4130);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 4010, 4149);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 4167, 4208);

                    var
                    expression = this as BoundExpression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 4253, 4342);

                    return expression != null && (DynAbs.Tracing.TraceSender.Expression_True(10562, 4260, 4308) && !(f_10562_4284_4299(expression) is null)) && (DynAbs.Tracing.TraceSender.Expression_True(10562, 4260, 4341) && f_10562_4312_4341(f_10562_4312_4327(expression)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 3856, 4357);

                    bool
                    f_10562_4014_4028(Microsoft.CodeAnalysis.CSharp.BoundNode
                    this_param)
                    {
                        var return_v = this_param.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 4014, 4028);
                        return return_v;
                    }


                    bool
                    f_10562_4055_4076(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 4055, 4076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10562_4284_4299(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 4284, 4299);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10562_4312_4327(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 4312, 4327);
                        return return_v;
                    }


                    bool
                    f_10562_4312_4341(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 4312, 4341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 3807, 4368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 3807, 4368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 5132, 5241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5168, 5226);

                    return (_attributes & BoundNodeAttributes.HasErrors) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 5132, 5241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 5086, 5655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 5086, 5655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 5255, 5644);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5299, 5629) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 5299, 5629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5350, 5395);

                        _attributes |= BoundNodeAttributes.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 5299, 5629);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 5299, 5629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5477, 5610);

                        f_10562_5477_5609((_attributes & BoundNodeAttributes.HasErrors) == 0, "HasErrors flag should not be reset here");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 5299, 5629);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 5255, 5644);

                    int
                    f_10562_5477_5609(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 5477, 5609);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 5086, 5655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 5086, 5655);
                }
            }
        }

        public SyntaxTree? SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 5721, 5798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5757, 5783);

                    return f_10562_5764_5782_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Syntax, 10562, 5764, 5782)?.SyntaxTree);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 5721, 5798);

                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10562_5764_5782_M(Microsoft.CodeAnalysis.SyntaxTree?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 5764, 5782);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 5667, 5809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 5667, 5809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void CopyAttributes(BoundNode original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 5821, 6179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5895, 5953);

                this.WasCompilerGenerated = f_10562_5923_5952(original);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 5969, 6037);

                f_10562_5969_6036(original is BoundExpression || (DynAbs.Tracing.TraceSender.Expression_False(10562, 5982, 6035) || f_10562_6013_6035_M(!original.IsSuppressed)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6051, 6093);

                this.IsSuppressed = f_10562_6071_6092(original);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6118, 6160);

                this.WasConverted = f_10562_6138_6159(original);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 5821, 6179);

                bool
                f_10562_5923_5952(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 5923, 5952);
                    return return_v;
                }


                bool
                f_10562_6013_6035_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 6013, 6035);
                    return return_v;
                }


                int
                f_10562_5969_6036(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 5969, 6036);
                    return 0;
                }


                bool
                f_10562_6071_6092(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 6071, 6092);
                    return return_v;
                }


                bool
                f_10562_6138_6159(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.WasConverted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 6138, 6159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 5821, 6179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 5821, 6179);
            }
        }

        public bool WasCompilerGenerated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 6346, 6565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6393, 6458);

                    _attributes |= BoundNodeAttributes.WasCompilerGeneratedIsChecked;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6484, 6550);

                    return (_attributes & BoundNodeAttributes.CompilerGenerated) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 6346, 6565);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 6289, 7212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 6289, 7212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 6579, 7201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6635, 6803);

                    f_10562_6635_6802((_attributes & BoundNodeAttributes.WasCompilerGeneratedIsChecked) == 0, "compiler generated flag should not be set after reading it");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6831, 7186) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 6831, 7186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 6882, 6935);

                        _attributes |= BoundNodeAttributes.CompilerGenerated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 6831, 7186);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 6831, 7186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 7017, 7167);

                        f_10562_7017_7166((_attributes & BoundNodeAttributes.CompilerGenerated) == 0, "compiler generated flag should not be reset here");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 6831, 7186);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 6579, 7201);

                    int
                    f_10562_6635_6802(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 6635, 6802);
                        return 0;
                    }


                    int
                    f_10562_7017_7166(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 7017, 7166);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 6289, 7212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 6289, 7212);
                }
            }
        }

        public void ResetCompilerGenerated(bool newCompilerGenerated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 7468, 8008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 7565, 7729);

                f_10562_7565_7728((_attributes & BoundNodeAttributes.WasCompilerGeneratedIsChecked) == 0, "compiler generated flag should not be set after reading it");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 7751, 7997) || true) && (newCompilerGenerated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 7751, 7997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 7809, 7862);

                    _attributes |= BoundNodeAttributes.CompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 7751, 7997);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 7751, 7997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 7928, 7982);

                    _attributes &= ~BoundNodeAttributes.CompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 7751, 7997);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 7468, 8008);

                int
                f_10562_7565_7728(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 7565, 7728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 7468, 8008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 7468, 8008);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected NullabilityInfo TopLevelNullability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 8287, 8720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 8334, 8399);

                    _attributes |= BoundNodeAttributes.WasTopLevelNullabilityChecked;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 8674, 8705);

                    return f_10562_8681_8704();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 8287, 8720);

                    Microsoft.CodeAnalysis.NullabilityInfo
                    f_10562_8681_8704()
                    {
                        var return_v = TopLevelNullabilityCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 8681, 8704);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 8158, 10136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 8158, 10136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 8734, 10125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 8781, 8948);

                    f_10562_8781_8947((_attributes & BoundNodeAttributes.WasTopLevelNullabilityChecked) == 0, "bound node nullability should not be set after reading it");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 8974, 9084);

                    _attributes &= ~(BoundNodeAttributes.TopLevelAnnotationMask | BoundNodeAttributes.TopLevelFlowStateMaybeNull);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9104, 9567);

                    _attributes |= value.Annotation switch
                    {
                        CodeAnalysis.NullableAnnotation.Annotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9183, 9265) && DynAbs.Tracing.TraceSender.Expression_True(10562, 9183, 9265))
    => BoundNodeAttributes.TopLevelAnnotated,
                        CodeAnalysis.NullableAnnotation.NotAnnotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9288, 9376) && DynAbs.Tracing.TraceSender.Expression_True(10562, 9288, 9376))
    => BoundNodeAttributes.TopLevelNotAnnotated,
                        CodeAnalysis.NullableAnnotation.None when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9399, 9471) && DynAbs.Tracing.TraceSender.Expression_True(10562, 9399, 9471))
    => BoundNodeAttributes.TopLevelNone,
                        var a when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9494, 9546) && DynAbs.Tracing.TraceSender.Expression_True(10562, 9494, 9546))
    => throw f_10562_9509_9546(a),
                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9587, 10110);

                    switch (value.FlowState)
                    {

                        case CodeAnalysis.NullableFlowState.MaybeNull:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 9587, 10110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 9724, 9786);

                            _attributes |= BoundNodeAttributes.TopLevelFlowStateMaybeNull;
                            DynAbs.Tracing.TraceSender.TraceBreak(10562, 9812, 9818);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 9587, 10110);

                        case CodeAnalysis.NullableFlowState.NotNull:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 9587, 10110);
                            DynAbs.Tracing.TraceSender.TraceBreak(10562, 9969, 9975);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 9587, 10110);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 9587, 10110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10033, 10091);

                            throw f_10562_10039_10090(value.FlowState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 9587, 10110);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 8734, 10125);

                    int
                    f_10562_8781_8947(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 8781, 8947);
                        return 0;
                    }


                    System.Exception
                    f_10562_9509_9546(Microsoft.CodeAnalysis.NullableAnnotation
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 9509, 9546);
                        return return_v;
                    }


                    System.Exception
                    f_10562_10039_10090(Microsoft.CodeAnalysis.NullableFlowState
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 10039, 10090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 8158, 10136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 8158, 10136);
                }
            }
        }

        private NullabilityInfo TopLevelNullabilityCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 10569, 11553);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10605, 10748) || true) && ((_attributes & BoundNodeAttributes.TopLevelAnnotationMask) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 10605, 10748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10714, 10729);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 10605, 10748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10768, 11280);

                    var
                    annotation = (_attributes & BoundNodeAttributes.TopLevelAnnotationMask) switch
                    {
                        BoundNodeAttributes.TopLevelAnnotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10891, 10973) && DynAbs.Tracing.TraceSender.Expression_True(10562, 10891, 10973))
=> CodeAnalysis.NullableAnnotation.Annotated,
                        BoundNodeAttributes.TopLevelNotAnnotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 10996, 11084) && DynAbs.Tracing.TraceSender.Expression_True(10562, 10996, 11084))
=> CodeAnalysis.NullableAnnotation.NotAnnotated,
                        BoundNodeAttributes.TopLevelNone when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11107, 11179) && DynAbs.Tracing.TraceSender.Expression_True(10562, 11107, 11179))
=> CodeAnalysis.NullableAnnotation.None,
                        var mask when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11202, 11260) && DynAbs.Tracing.TraceSender.Expression_True(10562, 11202, 11260))
=> throw f_10562_11220_11260(mask)
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11300, 11468);

                    var
                    flowState = (DynAbs.Tracing.TraceSender.Conditional_F1(10562, 11316, 11383) || (((_attributes & BoundNodeAttributes.TopLevelFlowStateMaybeNull) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10562, 11386, 11424)) || DynAbs.Tracing.TraceSender.Conditional_F3(10562, 11427, 11467))) ? CodeAnalysis.NullableFlowState.NotNull : CodeAnalysis.NullableFlowState.MaybeNull
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11488, 11538);

                    return f_10562_11495_11537(annotation, flowState);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 10569, 11553);

                    System.Exception
                    f_10562_11220_11260(Microsoft.CodeAnalysis.CSharp.BoundNode.BoundNodeAttributes
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 11220, 11260);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.NullabilityInfo
                    f_10562_11495_11537(Microsoft.CodeAnalysis.NullableAnnotation
                    annotation, Microsoft.CodeAnalysis.NullableFlowState
                    flowState)
                    {
                        var return_v = new Microsoft.CodeAnalysis.NullabilityInfo(annotation, flowState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 11495, 11537);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 10497, 11564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 10497, 11564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSuppressed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 11625, 11737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11661, 11722);

                    return (_attributes & BoundNodeAttributes.IsSuppressed) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 11625, 11737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 11576, 12068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 11576, 12068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 11751, 12057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11797, 11906);

                    f_10562_11797_11905((_attributes & BoundNodeAttributes.IsSuppressed) == 0, "flag should not be set twice or reset");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11924, 12042) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 11924, 12042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 11975, 12023);

                        _attributes |= BoundNodeAttributes.IsSuppressed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 11924, 12042);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 11751, 12057);

                    int
                    f_10562_11797_11905(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 11797, 11905);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 11576, 12068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 11576, 12068);
                }
            }
        }

        public bool WasConverted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 12488, 12600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 12524, 12585);

                    return (_attributes & BoundNodeAttributes.WasConverted) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 12488, 12600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 12439, 12944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 12439, 12944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 12614, 12933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 12660, 12782);

                    f_10562_12660_12781((_attributes & BoundNodeAttributes.WasConverted) == 0, "WasConverted flag should not be set twice or reset");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 12800, 12918) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 12800, 12918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 12851, 12899);

                        _attributes |= BoundNodeAttributes.WasConverted;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 12800, 12918);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 12614, 12933);

                    int
                    f_10562_12660_12781(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 12660, 12781);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 12439, 12944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 12439, 12944);
                }
            }
        }

        public BoundKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 13010, 13074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13046, 13059);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 13010, 13074);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 12964, 13085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 12964, 13085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual BoundNode? Accept(BoundTreeVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 13097, 13227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13180, 13216);

                throw f_10562_13186_13215();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 13097, 13227);

                System.NotImplementedException
                f_10562_13186_13215()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 13186, 13215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 13097, 13227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13097, 13227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundNode WithHasErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 13363, 13598);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13422, 13471) || true) && (f_10562_13426_13440(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 13422, 13471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13459, 13471);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 13422, 13471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13487, 13523);

                BoundNode
                clone = f_10562_13505_13522(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13537, 13560);

                clone.HasErrors = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13574, 13587);

                return clone;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 13363, 13598);

                bool
                f_10562_13426_13440(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 13426, 13440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10562_13505_13522(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 13505, 13522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 13363, 13598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13363, 13598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class MyTreeDumper : TreeDumper
        {
            private MyTreeDumper() : base()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10562, 13685, 13720);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10562, 13685, 13720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 13685, 13720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13685, 13720);
                }
            }

            public static new string DumpCompact(TreeDumperNode root)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10562, 13736, 13887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13826, 13872);

                    return f_10562_13833_13871(f_10562_13833_13851(), root);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10562, 13736, 13887);

                    Microsoft.CodeAnalysis.CSharp.BoundNode.MyTreeDumper
                    f_10562_13833_13851()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNode.MyTreeDumper();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 13833, 13851);
                        return return_v;
                    }


                    string
                    f_10562_13833_13871(Microsoft.CodeAnalysis.CSharp.BoundNode.MyTreeDumper
                    this_param, Microsoft.CodeAnalysis.TreeDumperNode
                    root)
                    {
                        var return_v = this_param.DoDumpCompact(root);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 13833, 13871);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 13736, 13887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13736, 13887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override string DumperString(object o)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 13903, 14074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 13984, 14059);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10562, 13991, 14016) || (((o is SynthesizedLocal) && DynAbs.Tracing.TraceSender.Conditional_F2(10562, 14019, 14035)) || DynAbs.Tracing.TraceSender.Conditional_F3(10562, 14038, 14058))) ? f_10562_14019_14035((SynthesizedLocal)o) : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DumperString(o), 10562, 14038, 14058);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 13903, 14074);

                    string
                    f_10562_14019_14035(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.DumperString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14019, 14035);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 13903, 14074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13903, 14074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static MyTreeDumper()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10562, 13621, 14085);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10562, 13621, 14085);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 13621, 14085);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10562, 13621, 14085);
        }

        internal virtual string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 14097, 14239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14152, 14228);

                return f_10562_14159_14227(f_10562_14184_14226(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 14097, 14239);

                Microsoft.CodeAnalysis.TreeDumperNode
                f_10562_14184_14226(Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = BoundTreeDumperNodeProducer.MakeTree(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14184, 14226);
                    return return_v;
                }


                string
                f_10562_14159_14227(Microsoft.CodeAnalysis.TreeDumperNode
                root)
                {
                    var return_v = MyTreeDumper.DumpCompact(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14159, 14227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 14097, 14239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 14097, 14239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 14259, 14502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14320, 14348);

                var
                result = f_10562_14333_14347(f_10562_14333_14342(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14362, 14463) || true) && (Syntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 14362, 14463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14414, 14448);

                    result += " " + f_10562_14430_14447(Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 14362, 14463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14477, 14491);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 14259, 14502);

                System.Type
                f_10562_14333_14342(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14333, 14342);
                    return return_v;
                }


                string
                f_10562_14333_14347(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 14333, 14347);
                    return return_v;
                }


                string
                f_10562_14430_14447(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14430, 14447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 14259, 14502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 14259, 14502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        public void CheckLocalsDefined()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 14514, 14672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14614, 14653);

                f_10562_14614_14652(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 14514, 14672);

                int
                f_10562_14614_14652(Microsoft.CodeAnalysis.CSharp.BoundNode
                root)
                {
                    LocalsScanner.CheckLocalsDefined(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14614, 14652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 14514, 14672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 14514, 14672);
            }
        }
        private class LocalsScanner : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            public readonly PooledHashSet<LocalSymbol> DeclaredLocals;

            private LocalsScanner()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10562, 14937, 14990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 14863, 14920);
                    this.DeclaredLocals = f_10562_14880_14920(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10562, 14937, 14990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 14937, 14990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 14937, 14990);
                }
            }

            public static void CheckLocalsDefined(BoundNode root)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10562, 15006, 15230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15092, 15132);

                    var
                    localsScanner = f_10562_15112_15131()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15150, 15176);

                    f_10562_15150_15175(localsScanner, root);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15194, 15215);

                    f_10562_15194_15214(localsScanner);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10562, 15006, 15230);

                    Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    f_10562_15112_15131()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15112, 15131);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10562_15150_15175(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15150, 15175);
                        return return_v;
                    }


                    int
                    f_10562_15194_15214(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15194, 15214);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 15006, 15230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 15006, 15230);
                }
            }

            private void AddAll(ImmutableArray<LocalSymbol> locals)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 15246, 15610);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15334, 15595);
                        foreach (var local in f_10562_15356_15362_I(locals))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 15334, 15595);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15404, 15576) || true) && (!f_10562_15409_15434(DeclaredLocals, local))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 15404, 15576);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15484, 15553);

                                f_10562_15484_15552(false, "duplicate local " + f_10562_15525_15551(local));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 15404, 15576);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 15334, 15595);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10562, 1, 262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10562, 1, 262);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 15246, 15610);

                    bool
                    f_10562_15409_15434(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15409, 15434);
                        return return_v;
                    }


                    string
                    f_10562_15525_15551(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDebuggerDisplay();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15525, 15551);
                        return return_v;
                    }


                    int
                    f_10562_15484_15552(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15484, 15552);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_15356_15362_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15356, 15362);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 15246, 15610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 15246, 15610);
                }
            }

            private void RemoveAll(ImmutableArray<LocalSymbol> locals)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 15626, 15994);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15717, 15979);
                        foreach (var local in f_10562_15739_15745_I(locals))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 15717, 15979);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15787, 15960) || true) && (!f_10562_15792_15820(DeclaredLocals, local))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 15787, 15960);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 15870, 15937);

                                f_10562_15870_15936(false, "missing local " + f_10562_15909_15935(local));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 15787, 15960);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 15717, 15979);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10562, 1, 263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10562, 1, 263);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 15626, 15994);

                    bool
                    f_10562_15792_15820(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = this_param.Remove(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15792, 15820);
                        return return_v;
                    }


                    string
                    f_10562_15909_15935(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDebuggerDisplay();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15909, 15935);
                        return return_v;
                    }


                    int
                    f_10562_15870_15936(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15870, 15936);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_15739_15745_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 15739, 15745);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 15626, 15994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 15626, 15994);
                }
            }

            private void CheckDeclared(LocalSymbol local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 16010, 16269);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16088, 16254) || true) && (!f_10562_16093_16123(DeclaredLocals, local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10562, 16088, 16254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16165, 16235);

                        f_10562_16165_16234(false, "undeclared local " + f_10562_16207_16233(local));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10562, 16088, 16254);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 16010, 16269);

                    bool
                    f_10562_16093_16123(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16093, 16123);
                        return return_v;
                    }


                    string
                    f_10562_16207_16233(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDebuggerDisplay();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16207, 16233);
                        return return_v;
                    }


                    int
                    f_10562_16165_16234(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16165, 16234);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 16010, 16269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 16010, 16269);
                }
            }

            public override BoundNode? VisitFieldEqualsValue(BoundFieldEqualsValue node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 16285, 16551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16394, 16414);

                    f_10562_16394_16413(this, f_10562_16401_16412(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16432, 16465);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFieldEqualsValue(node), 10562, 16432, 16464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16483, 16506);

                    f_10562_16483_16505(this, f_10562_16493_16504(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16524, 16536);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 16285, 16551);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_16401_16412(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 16401, 16412);
                        return return_v;
                    }


                    int
                    f_10562_16394_16413(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16394, 16413);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_16493_16504(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 16493, 16504);
                        return return_v;
                    }


                    int
                    f_10562_16483_16505(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16483, 16505);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 16285, 16551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 16285, 16551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitPropertyEqualsValue(BoundPropertyEqualsValue node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 16567, 16842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16682, 16702);

                    f_10562_16682_16701(this, f_10562_16689_16700(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16720, 16756);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyEqualsValue(node), 10562, 16720, 16755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16774, 16797);

                    f_10562_16774_16796(this, f_10562_16784_16795(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16815, 16827);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 16567, 16842);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_16689_16700(Microsoft.CodeAnalysis.CSharp.BoundPropertyEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 16689, 16700);
                        return return_v;
                    }


                    int
                    f_10562_16682_16701(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16682, 16701);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_16784_16795(Microsoft.CodeAnalysis.CSharp.BoundPropertyEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 16784, 16795);
                        return return_v;
                    }


                    int
                    f_10562_16774_16796(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16774, 16796);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 16567, 16842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 16567, 16842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitParameterEqualsValue(BoundParameterEqualsValue node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 16858, 17136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 16975, 16995);

                    f_10562_16975_16994(this, f_10562_16982_16993(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17013, 17050);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameterEqualsValue(node), 10562, 17013, 17049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17068, 17091);

                    f_10562_17068_17090(this, f_10562_17078_17089(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17109, 17121);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 16858, 17136);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_16982_16993(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 16982, 16993);
                        return return_v;
                    }


                    int
                    f_10562_16975_16994(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 16975, 16994);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_17078_17089(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17078, 17089);
                        return return_v;
                    }


                    int
                    f_10562_17068_17090(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17068, 17090);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 16858, 17136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 16858, 17136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitBlock(BoundBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 17152, 17385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17239, 17259);

                    f_10562_17239_17258(this, f_10562_17246_17257(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17277, 17299);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 10562, 17277, 17298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17317, 17340);

                    f_10562_17317_17339(this, f_10562_17327_17338(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17358, 17370);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 17152, 17385);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_17246_17257(Microsoft.CodeAnalysis.CSharp.BoundBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17246, 17257);
                        return return_v;
                    }


                    int
                    f_10562_17239_17258(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17239, 17258);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_17327_17338(Microsoft.CodeAnalysis.CSharp.BoundBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17327, 17338);
                        return return_v;
                    }


                    int
                    f_10562_17317_17339(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17317, 17339);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 17152, 17385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 17152, 17385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitLocalDeclaration(BoundLocalDeclaration node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 17401, 17638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17510, 17542);

                    f_10562_17510_17541(this, f_10562_17524_17540(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17560, 17593);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalDeclaration(node), 10562, 17560, 17592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17611, 17623);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 17401, 17638);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10562_17524_17540(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17524, 17540);
                        return return_v;
                    }


                    int
                    f_10562_17510_17541(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        this_param.CheckDeclared(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17510, 17541);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 17401, 17638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 17401, 17638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSequence(BoundSequence node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 17654, 17896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17747, 17767);

                    f_10562_17747_17766(this, f_10562_17754_17765(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17785, 17810);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSequence(node), 10562, 17785, 17809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17828, 17851);

                    f_10562_17828_17850(this, f_10562_17838_17849(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 17869, 17881);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 17654, 17896);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_17754_17765(Microsoft.CodeAnalysis.CSharp.BoundSequence
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17754, 17765);
                        return return_v;
                    }


                    int
                    f_10562_17747_17766(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17747, 17766);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_17838_17849(Microsoft.CodeAnalysis.CSharp.BoundSequence
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 17838, 17849);
                        return return_v;
                    }


                    int
                    f_10562_17828_17850(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 17828, 17850);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 17654, 17896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 17654, 17896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSpillSequence(BoundSpillSequence node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 17912, 18169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18015, 18035);

                    f_10562_18015_18034(this, f_10562_18022_18033(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18053, 18083);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSpillSequence(node), 10562, 18053, 18082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18101, 18124);

                    f_10562_18101_18123(this, f_10562_18111_18122(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18142, 18154);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 17912, 18169);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18022_18033(Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18022, 18033);
                        return return_v;
                    }


                    int
                    f_10562_18015_18034(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18015, 18034);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18111_18122(Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18111, 18122);
                        return return_v;
                    }


                    int
                    f_10562_18101_18123(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18101, 18123);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 17912, 18169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 17912, 18169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSwitchStatement(BoundSwitchStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 18185, 18458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18292, 18317);

                    f_10562_18292_18316(this, f_10562_18299_18315(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18335, 18367);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchStatement(node), 10562, 18335, 18366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18385, 18413);

                    f_10562_18385_18412(this, f_10562_18395_18411(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18431, 18443);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 18185, 18458);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18299_18315(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18299, 18315);
                        return return_v;
                    }


                    int
                    f_10562_18292_18316(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18292, 18316);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18395_18411(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18395, 18411);
                        return return_v;
                    }


                    int
                    f_10562_18385_18412(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18385, 18412);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 18185, 18458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 18185, 18458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSwitchExpressionArm(BoundSwitchExpressionArm node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 18474, 18749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18589, 18609);

                    f_10562_18589_18608(this, f_10562_18596_18607(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18627, 18663);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchExpressionArm(node), 10562, 18627, 18662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18681, 18704);

                    f_10562_18681_18703(this, f_10562_18691_18702(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18722, 18734);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 18474, 18749);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18596_18607(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18596, 18607);
                        return return_v;
                    }


                    int
                    f_10562_18589_18608(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18589, 18608);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18691_18702(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18691, 18702);
                        return return_v;
                    }


                    int
                    f_10562_18681_18703(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18681, 18703);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 18474, 18749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 18474, 18749);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSwitchSection(BoundSwitchSection node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 18765, 19022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18868, 18888);

                    f_10562_18868_18887(this, f_10562_18875_18886(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18906, 18936);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchSection(node), 10562, 18906, 18935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18954, 18977);

                    f_10562_18954_18976(this, f_10562_18964_18975(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 18995, 19007);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 18765, 19022);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18875_18886(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18875, 18886);
                        return return_v;
                    }


                    int
                    f_10562_18868_18887(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18868, 18887);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_18964_18975(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 18964, 18975);
                        return return_v;
                    }


                    int
                    f_10562_18954_18976(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 18954, 18976);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 18765, 19022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 18765, 19022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDoStatement(BoundDoStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 19038, 19289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19137, 19157);

                    f_10562_19137_19156(this, f_10562_19144_19155(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19175, 19203);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDoStatement(node), 10562, 19175, 19202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19221, 19244);

                    f_10562_19221_19243(this, f_10562_19231_19242(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19262, 19274);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 19038, 19289);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19144_19155(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19144, 19155);
                        return return_v;
                    }


                    int
                    f_10562_19137_19156(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19137, 19156);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19231_19242(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19231, 19242);
                        return return_v;
                    }


                    int
                    f_10562_19221_19243(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19221, 19243);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 19038, 19289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 19038, 19289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitWhileStatement(BoundWhileStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 19305, 19565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19410, 19430);

                    f_10562_19410_19429(this, f_10562_19417_19428(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19448, 19479);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitWhileStatement(node), 10562, 19448, 19478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19497, 19520);

                    f_10562_19497_19519(this, f_10562_19507_19518(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19538, 19550);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 19305, 19565);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19417_19428(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19417, 19428);
                        return return_v;
                    }


                    int
                    f_10562_19410_19429(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19410, 19429);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19507_19518(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19507, 19518);
                        return return_v;
                    }


                    int
                    f_10562_19497_19519(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19497, 19519);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 19305, 19565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 19305, 19565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitForStatement(BoundForStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 19581, 20064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19682, 19707);

                    f_10562_19682_19706(this, f_10562_19689_19705(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19725, 19754);

                    f_10562_19725_19753(this, f_10562_19736_19752(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19772, 19797);

                    f_10562_19772_19796(this, f_10562_19779_19795(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19815, 19842);

                    f_10562_19815_19841(this, f_10562_19826_19840(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19860, 19887);

                    f_10562_19860_19886(this, f_10562_19871_19885(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19905, 19927);

                    f_10562_19905_19926(this, f_10562_19916_19925(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19945, 19973);

                    f_10562_19945_19972(this, f_10562_19955_19971(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 19991, 20019);

                    f_10562_19991_20018(this, f_10562_20001_20017(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20037, 20049);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 19581, 20064);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19689_19705(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.OuterLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19689, 19705);
                        return return_v;
                    }


                    int
                    f_10562_19682_19706(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19682, 19706);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    f_10562_19736_19752(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.Initializer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19736, 19752);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10562_19725_19753(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19725, 19753);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19779_19795(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19779, 19795);
                        return return_v;
                    }


                    int
                    f_10562_19772_19796(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19772, 19796);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10562_19826_19840(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.Condition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19826, 19840);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10562_19815_19841(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19815, 19841);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    f_10562_19871_19885(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.Increment;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19871, 19885);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10562_19860_19886(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19860, 19886);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10562_19916_19925(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19916, 19925);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10562_19905_19926(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19905, 19926);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_19955_19971(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 19955, 19971);
                        return return_v;
                    }


                    int
                    f_10562_19945_19972(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19945, 19972);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20001_20017(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                    this_param)
                    {
                        var return_v = this_param.OuterLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20001, 20017);
                        return return_v;
                    }


                    int
                    f_10562_19991_20018(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 19991, 20018);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 19581, 20064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 19581, 20064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitForEachStatement(BoundForEachStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 20080, 20370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20189, 20221);

                    f_10562_20189_20220(this, f_10562_20196_20219(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20239, 20272);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForEachStatement(node), 10562, 20239, 20271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20290, 20325);

                    f_10562_20290_20324(this, f_10562_20300_20323(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20343, 20355);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 20080, 20370);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20196_20219(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.IterationVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20196, 20219);
                        return return_v;
                    }


                    int
                    f_10562_20189_20220(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20189, 20220);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20300_20323(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.IterationVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20300, 20323);
                        return return_v;
                    }


                    int
                    f_10562_20290_20324(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20290, 20324);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 20080, 20370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 20080, 20370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitUsingStatement(BoundUsingStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 20386, 20646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20491, 20511);

                    f_10562_20491_20510(this, f_10562_20498_20509(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20529, 20560);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUsingStatement(node), 10562, 20529, 20559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20578, 20601);

                    f_10562_20578_20600(this, f_10562_20588_20599(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20619, 20631);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 20386, 20646);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20498_20509(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20498, 20509);
                        return return_v;
                    }


                    int
                    f_10562_20491_20510(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20491, 20510);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20588_20599(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20588, 20599);
                        return return_v;
                    }


                    int
                    f_10562_20578_20600(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20578, 20600);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 20386, 20646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 20386, 20646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitFixedStatement(BoundFixedStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 20662, 20922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20767, 20787);

                    f_10562_20767_20786(this, f_10562_20774_20785(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20805, 20836);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFixedStatement(node), 10562, 20805, 20835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20854, 20877);

                    f_10562_20854_20876(this, f_10562_20864_20875(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 20895, 20907);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 20662, 20922);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20774_20785(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20774, 20785);
                        return return_v;
                    }


                    int
                    f_10562_20767_20786(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20767, 20786);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_20864_20875(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 20864, 20875);
                        return return_v;
                    }


                    int
                    f_10562_20854_20876(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 20854, 20876);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 20662, 20922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 20662, 20922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitCatchBlock(BoundCatchBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 20938, 21186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21035, 21055);

                    f_10562_21035_21054(this, f_10562_21042_21053(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21073, 21100);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10562, 21073, 21099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21118, 21141);

                    f_10562_21118_21140(this, f_10562_21128_21139(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21159, 21171);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 20938, 21186);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_21042_21053(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21042, 21053);
                        return return_v;
                    }


                    int
                    f_10562_21035_21054(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21035, 21054);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_21128_21139(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21128, 21139);
                        return return_v;
                    }


                    int
                    f_10562_21118_21140(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21118, 21140);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 20938, 21186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 20938, 21186);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitLocal(BoundLocal node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 21202, 21406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21289, 21321);

                    f_10562_21289_21320(this, f_10562_21303_21319(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21339, 21361);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10562, 21339, 21360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21379, 21391);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 21202, 21406);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10562_21303_21319(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21303, 21319);
                        return return_v;
                    }


                    int
                    f_10562_21289_21320(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        this_param.CheckDeclared(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21289, 21320);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 21202, 21406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 21202, 21406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitPseudoVariable(BoundPseudoVariable node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 21422, 21653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21527, 21559);

                    f_10562_21527_21558(this, f_10562_21541_21557(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21577, 21608);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPseudoVariable(node), 10562, 21577, 21607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21626, 21638);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 21422, 21653);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10562_21541_21557(Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21541, 21557);
                        return return_v;
                    }


                    int
                    f_10562_21527_21558(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        this_param.CheckDeclared(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21527, 21558);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 21422, 21653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 21422, 21653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitConstructorMethodBody(BoundConstructorMethodBody node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 21669, 21950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21788, 21808);

                    f_10562_21788_21807(this, f_10562_21795_21806(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21826, 21864);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConstructorMethodBody(node), 10562, 21826, 21863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21882, 21905);

                    f_10562_21882_21904(this, f_10562_21892_21903(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 21923, 21935);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 21669, 21950);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_21795_21806(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21795, 21806);
                        return return_v;
                    }


                    int
                    f_10562_21788_21807(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21788, 21807);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10562_21892_21903(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10562, 21892, 21903);
                        return return_v;
                    }


                    int
                    f_10562_21882_21904(Microsoft.CodeAnalysis.CSharp.BoundNode.LocalsScanner
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.RemoveAll(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 21882, 21904);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 21669, 21950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 21669, 21950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10562, 21966, 22054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10562, 22017, 22039);

                    f_10562_22017_22038(DeclaredLocals);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10562, 21966, 22054);

                    int
                    f_10562_22017_22038(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 22017, 22038);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10562, 21966, 22054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 21966, 22054);
                }
            }

            static LocalsScanner()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10562, 14695, 22065);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10562, 14695, 22065);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 14695, 22065);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10562, 14695, 22065);

            Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
            f_10562_14880_14920()
            {
                var return_v = PooledHashSet<LocalSymbol>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 14880, 14920);
                return return_v;
            }

        }

        static BoundNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10562, 453, 22080);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10562, 453, 22080);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10562, 453, 22080);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10562, 453, 22080);

        int
        f_10562_2852_3097(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10562, 2852, 3097);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10562_3276_3280_C(Microsoft.CodeAnalysis.CSharp.BoundKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10562, 3185, 3431);
            return return_v;
        }

    }
}
