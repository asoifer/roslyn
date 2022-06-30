// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis
{
    public static class WellKnownMemberNames
    {
        public const string
        EnumBackingFieldName = "value__"
        ;

        public const string
        InstanceConstructorName = ".ctor"
        ;

        public const string
        StaticConstructorName = ".cctor"
        ;

        public const string
        Indexer = "this[]"
        ;

        public const string
        DestructorName = "Finalize"
        ;

        public const string
        DelegateInvokeName = "Invoke"
        ;

        public const string
        DelegateBeginInvokeName = "BeginInvoke"
        ;

        public const string
        DelegateEndInvokeName = "EndInvoke"
        ;

        public const string
        EntryPointMethodName = "Main"
        ;

        public const string
        DefaultScriptClassName = "Script"
        ;

        public const string
        ObjectToString = "ToString"
        ;

        public const string
        ObjectEquals = "Equals"
        ;

        public const string
        ObjectGetHashCode = "GetHashCode"
        ;

        public const string
        ImplicitConversionName = "op_Implicit"
        ;

        public const string
        ExplicitConversionName = "op_Explicit"
        ;

        public const string
        AdditionOperatorName = "op_Addition"
        ;

        public const string
        BitwiseAndOperatorName = "op_BitwiseAnd"
        ;

        public const string
        BitwiseOrOperatorName = "op_BitwiseOr"
        ;

        public const string
        DecrementOperatorName = "op_Decrement"
        ;

        public const string
        DivisionOperatorName = "op_Division"
        ;

        public const string
        EqualityOperatorName = "op_Equality"
        ;

        public const string
        ExclusiveOrOperatorName = "op_ExclusiveOr"
        ;

        public const string
        FalseOperatorName = "op_False"
        ;

        public const string
        GreaterThanOperatorName = "op_GreaterThan"
        ;

        public const string
        GreaterThanOrEqualOperatorName = "op_GreaterThanOrEqual"
        ;

        public const string
        IncrementOperatorName = "op_Increment"
        ;

        public const string
        InequalityOperatorName = "op_Inequality"
        ;

        public const string
        LeftShiftOperatorName = "op_LeftShift"
        ;

        public const string
        UnsignedLeftShiftOperatorName = "op_UnsignedLeftShift"
        ;

        public const string
        LessThanOperatorName = "op_LessThan"
        ;

        public const string
        LessThanOrEqualOperatorName = "op_LessThanOrEqual"
        ;

        public const string
        LogicalNotOperatorName = "op_LogicalNot"
        ;

        public const string
        LogicalOrOperatorName = "op_LogicalOr"
        ;

        public const string
        LogicalAndOperatorName = "op_LogicalAnd"
        ;

        public const string
        ModulusOperatorName = "op_Modulus"
        ;

        public const string
        MultiplyOperatorName = "op_Multiply"
        ;

        public const string
        OnesComplementOperatorName = "op_OnesComplement"
        ;

        public const string
        RightShiftOperatorName = "op_RightShift"
        ;

        public const string
        UnsignedRightShiftOperatorName = "op_UnsignedRightShift"
        ;

        public const string
        SubtractionOperatorName = "op_Subtraction"
        ;

        public const string
        TrueOperatorName = "op_True"
        ;

        public const string
        UnaryNegationOperatorName = "op_UnaryNegation"
        ;

        public const string
        UnaryPlusOperatorName = "op_UnaryPlus"
        ;

        public const string
        ConcatenateOperatorName = "op_Concatenate"
        ;

        public const string
        ExponentOperatorName = "op_Exponent"
        ;

        public const string
        IntegerDivisionOperatorName = "op_IntegerDivision"
        ;

        public const string
        LikeOperatorName = "op_Like"
        ;

        public const string
        GetEnumeratorMethodName = "GetEnumerator"
        ;

        public const string
        GetAsyncEnumeratorMethodName = "GetAsyncEnumerator"
        ;

        public const string
        MoveNextAsyncMethodName = "MoveNextAsync"
        ;

        public const string
        DeconstructMethodName = "Deconstruct"
        ;

        public const string
        MoveNextMethodName = "MoveNext"
        ;

        public const string
        CurrentPropertyName = "Current"
        ;

        public const string
        ValuePropertyName = "Value"
        ;

        public const string
        CollectionInitializerAddMethodName = "Add"
        ;

        public const string
        GetAwaiter = nameof(GetAwaiter)
        ;

        public const string
        IsCompleted = nameof(IsCompleted)
        ;

        public const string
        GetResult = nameof(GetResult)
        ;

        public const string
        OnCompleted = nameof(OnCompleted)
        ;

        public const string
        DisposeMethodName = "Dispose"
        ;

        public const string
        DisposeAsyncMethodName = "DisposeAsync"
        ;

        public const string
        CountPropertyName = "Count"
        ;

        public const string
        LengthPropertyName = "Length"
        ;

        public const string
        SliceMethodName = "Slice"
        ;

        internal const string
        CloneMethodName = "<Clone>$"
        ;

        internal const string
        PrintMembersMethodName = "PrintMembers"
        ;

        public const string
        TopLevelStatementsEntryPointMethodName = "<Main>$"
        ;

        public const string
        TopLevelStatementsEntryPointTypeName = "<Program>$"
        ;

        static WellKnownMemberNames()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(654, 449, 13747);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 618, 650);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 789, 822);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 960, 992);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 1292, 1310);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 1440, 1467);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 1616, 1645);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 1799, 1838);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 1990, 2025);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 2153, 2182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 2334, 2367);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 2512, 2539);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 2682, 2705);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 2853, 2886);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3035, 3073);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3223, 3261);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3398, 3434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3573, 3613);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3751, 3789);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 3927, 3965);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4102, 4138);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4275, 4311);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4451, 4493);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4627, 4657);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4797, 4839);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 4986, 5042);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 5180, 5218);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 5357, 5397);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 5535, 5573);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 5719, 5773);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 5910, 5946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6090, 6140);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6279, 6319);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6457, 6495);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6634, 6674);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6810, 6844);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 6981, 7017);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 7160, 7208);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 7347, 7387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 7534, 7590);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 7730, 7772);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 7905, 7933);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8075, 8121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8259, 8297);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8437, 8479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8616, 8652);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8796, 8846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 8986, 9014);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 9190, 9231);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 9412, 9463);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 9645, 9686);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 9857, 9894);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 10065, 10096);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 10268, 10299);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 10542, 10569);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 10839, 10881);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 11131, 11162);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 11426, 11459);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 11728, 11757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 12025, 12058);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 12226, 12255);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 12435, 12474);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 12663, 12690);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 12880, 12909);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 13087, 13112);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 13202, 13230);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 13263, 13302);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 13467, 13517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(654, 13688, 13739);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(654, 449, 13747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(654, 449, 13747);
        }

    }
}
