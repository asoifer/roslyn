﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// A type and its corresponding flow state resulting from evaluating an rvalue expression.
    /// </summary>
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal readonly struct TypeWithState
    {
        public readonly TypeSymbol? Type;
        public readonly NullableFlowState State;
        [MemberNotNullWhen(false, nameof(Type))]
        public bool HasNullType => Type is null;
        public bool MayBeNull => State == NullableFlowState.MaybeNull;
        public bool IsNotNull => State == NullableFlowState.NotNull;

        public static TypeWithState ForType(TypeSymbol? type)
        {
            return Create(type, NullableFlowState.MaybeDefault);
        }

        public static TypeWithState Create(TypeSymbol? type, NullableFlowState defaultState)
        {
            if (defaultState == NullableFlowState.MaybeDefault &&
                (type is null || type.IsTypeParameterDisallowingAnnotationInCSharp8()))
            {
                // LAFHIS
                Debug.Assert((!(type is null) ? type.IsNullableTypeOrTypeParameter() : false) != true);
                return new TypeWithState(type, defaultState);
            }
            var state = defaultState != NullableFlowState.NotNull && (type is null || type.CanContainNull()) ? NullableFlowState.MaybeNull : NullableFlowState.NotNull;
            return new TypeWithState(type, state);
        }

        public static TypeWithState Create(TypeWithAnnotations typeWithAnnotations, FlowAnalysisAnnotations annotations = FlowAnalysisAnnotations.None)
        {
            var type = typeWithAnnotations.Type;
            Debug.Assert((object)type != null);

            NullableFlowState state;
            if (type.CanContainNull())
            {
                if ((annotations & FlowAnalysisAnnotations.MaybeNull) == FlowAnalysisAnnotations.MaybeNull)
                {
                    state = NullableFlowState.MaybeDefault;
                }
                else if ((annotations & FlowAnalysisAnnotations.NotNull) == FlowAnalysisAnnotations.NotNull)
                {
                    state = NullableFlowState.NotNull;
                }
                else
                {
                    return typeWithAnnotations.ToTypeWithState();
                }
            }
            else
            {
                state = NullableFlowState.NotNull;
            }

            return Create(type, state);
        }

        private TypeWithState(TypeSymbol? type, NullableFlowState state)
        {
            Debug.Assert(state == NullableFlowState.NotNull || type is null || type.CanContainNull());
            // LAFHIS
            Debug.Assert(state != NullableFlowState.MaybeDefault || type is null || type.IsTypeParameterDisallowingAnnotationInCSharp8());
            Type = type;
            State = state;
        }

        public string GetDebuggerDisplay()
        {
            // LAFHIS
            var temp = Type is null ? "" : Type.GetDebuggerDisplay();
            return $"{{Type:{temp}, State:{State}{"}"}";
        }

        public override string ToString() => GetDebuggerDisplay();

        public TypeWithState WithNotNullState() => new TypeWithState(Type, NullableFlowState.NotNull);

        public TypeWithState WithSuppression(bool suppress) => suppress ? new TypeWithState(Type, NullableFlowState.NotNull) : this;

        public TypeWithAnnotations ToTypeWithAnnotations(CSharpCompilation compilation, bool asAnnotatedType = false)
        {
            // LAFHIS
            if (Type is not null && Type.IsTypeParameterDisallowingAnnotationInCSharp8())
            {
                var type = TypeWithAnnotations.Create(Type, NullableAnnotation.NotAnnotated);
                return State == NullableFlowState.MaybeDefault ? type.SetIsAnnotated(compilation) : type;
            }
            // LAFHIS
            NullableAnnotation annotation = asAnnotatedType ?
                ((Type is not null && Type.IsValueType) ? NullableAnnotation.NotAnnotated : NullableAnnotation.Annotated) :
                (State.IsNotNull() || (Type is null || !Type.CanContainNull()) ? NullableAnnotation.NotAnnotated : NullableAnnotation.Annotated);
            return TypeWithAnnotations.Create(this.Type, annotation);
        }

        public TypeWithAnnotations ToAnnotatedTypeWithAnnotations(CSharpCompilation compilation) =>
            ToTypeWithAnnotations(compilation, asAnnotatedType: true);
    }
}
