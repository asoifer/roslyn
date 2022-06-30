// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Specifies the kinds of a piece of classified text (SymbolDisplayPart).
    /// </summary>
    public enum SymbolDisplayPartKind
    {
        /// <summary>The name of an alias.</summary>
        AliasName = 0,
        /// <summary>The name of an assembly.</summary>
        AssemblyName = 1,
        /// <summary>The name of a class.</summary>
        ClassName = 2,
        /// <summary>The name of a delegate.</summary>
        DelegateName = 3,
        /// <summary>The name of an enum.</summary>
        EnumName = 4,
        /// <summary>The name of an error type.</summary>
        /// <seealso cref="IErrorTypeSymbol"/>
        ErrorTypeName = 5,
        /// <summary>The name of an event.</summary>
        EventName = 6,
        /// <summary>The name of a field.</summary>
        FieldName = 7,
        /// <summary>The name of an interface.</summary>
        InterfaceName = 8,
        /// <summary>A language keyword.</summary>
        Keyword = 9,
        /// <summary>The name of a label.</summary>
        LabelName = 10,
        /// <summary>A line-break (i.e. whitespace).</summary>
        LineBreak = 11,
        /// <summary>A numeric literal.</summary>
        /// <remarks>Typically for the default values of parameters and the constant values of fields.</remarks>
        NumericLiteral = 12,
        /// <summary>A string literal.</summary>
        /// <remarks>Typically for the default values of parameters and the constant values of fields.</remarks>
        StringLiteral = 13,
        /// <summary>The name of a local.</summary>
        LocalName = 14,
        /// <summary>The name of a method.</summary>
        MethodName = 15,
        /// <summary>The name of a module.</summary>
        ModuleName = 16,
        /// <summary>The name of a namespace.</summary>
        NamespaceName = 17,
        /// <summary>The symbol of an operator (e.g. "+").</summary>
        Operator = 18,
        /// <summary>The name of a parameter.</summary>
        ParameterName = 19,
        /// <summary>The name of a property.</summary>
        PropertyName = 20,
        /// <summary>A punctuation character (e.g. "(", ".", ",") other than an <see cref="Operator"/>.</summary>
        Punctuation = 21,
        /// <summary>A single space character.</summary>
        Space = 22,
        /// <summary>The name of a struct (structure in Visual Basic).</summary>
        StructName = 23,
        /// <summary>A keyword-like part for anonymous types (not actually a keyword).</summary>
        AnonymousTypeIndicator = 24,
        /// <summary>An unclassified part.</summary>
        /// <remarks>Never returned - only set in user-constructed parts.</remarks>
        Text = 25,
        /// <summary>The name of a type parameter.</summary>
        TypeParameterName = 26,
        /// <summary>The name of a query range variable.</summary>
        RangeVariableName = 27,
        /// <summary>The name of an enum member.</summary>
        EnumMemberName = 28,
        /// <summary>The name of a reduced extension method.</summary>
        /// <remarks>
        /// When an extension method is in it's non-reduced form it will be will be marked as MethodName.
        /// </remarks>
        ExtensionMethodName = 29,
        /// <summary>The name of a field or local constant.</summary>
        ConstantName = 30,
        /// <summary>The name of a record.</summary>
        RecordClassName = 31,
    }
    internal static class InternalSymbolDisplayPartKind
    {
        private const SymbolDisplayPartKind
        @base = SymbolDisplayPartKind.RecordClassName + 1
        ;

        public const SymbolDisplayPartKind
        Arity = @base + 0
        ;

        public const SymbolDisplayPartKind
        Other = @base + 1
        ;

        static InternalSymbolDisplayPartKind()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(584, 3769, 4056);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(584, 3873, 3922);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(584, 3968, 3985);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(584, 4031, 4048);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(584, 3769, 4056);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(584, 3769, 4056);
        }

    }
    internal static partial class EnumBounds
    {
        internal static bool IsValid(this SymbolDisplayPartKind value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(584, 4121, 4434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(584, 4208, 4423);

                return (value >= SymbolDisplayPartKind.AliasName && (DynAbs.Tracing.TraceSender.Expression_True(584, 4216, 4306) && value <= SymbolDisplayPartKind.RecordClassName)) || (DynAbs.Tracing.TraceSender.Expression_False(584, 4215, 4422) || (value >= InternalSymbolDisplayPartKind.Arity && (DynAbs.Tracing.TraceSender.Expression_True(584, 4329, 4421) && value <= InternalSymbolDisplayPartKind.Other)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(584, 4121, 4434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(584, 4121, 4434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(584, 4121, 4434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
