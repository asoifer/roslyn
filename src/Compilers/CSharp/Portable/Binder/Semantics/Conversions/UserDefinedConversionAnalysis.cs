// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum UserDefinedConversionAnalysisKind : byte
    {
        ApplicableInNormalForm,
        ApplicableInLiftedForm
    }
    internal sealed class UserDefinedConversionAnalysis
    {
        public readonly TypeSymbol FromType;

        public readonly TypeSymbol ToType;

        public readonly MethodSymbol Operator;

        public readonly Conversion SourceConversion;

        public readonly Conversion TargetConversion;

        public readonly UserDefinedConversionAnalysisKind Kind;

        public static UserDefinedConversionAnalysis Normal(
                    MethodSymbol op,
                    Conversion sourceConversion,
                    Conversion targetConversion,
                    TypeSymbol fromType,
                    TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10846, 930, 1457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 1186, 1446);

                return f_10846_1193_1445(UserDefinedConversionAnalysisKind.ApplicableInNormalForm, op, sourceConversion, targetConversion, fromType, toType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10846, 930, 1457);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10846_1193_1445(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysisKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis(kind, op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10846, 1193, 1445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10846, 930, 1457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10846, 930, 1457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UserDefinedConversionAnalysis Lifted(
                    MethodSymbol op,
                    Conversion sourceConversion,
                    Conversion targetConversion,
                    TypeSymbol fromType,
                    TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10846, 1469, 1996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 1725, 1985);

                return f_10846_1732_1984(UserDefinedConversionAnalysisKind.ApplicableInLiftedForm, op, sourceConversion, targetConversion, fromType, toType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10846, 1469, 1996);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10846_1732_1984(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysisKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis(kind, op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10846, 1732, 1984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10846, 1469, 1996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10846, 1469, 1996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UserDefinedConversionAnalysis(
                    UserDefinedConversionAnalysisKind kind,
                    MethodSymbol op,
                    Conversion sourceConversion,
                    Conversion targetConversion,
                    TypeSymbol fromType,
                    TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10846, 2008, 2549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 642, 650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 688, 694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 734, 742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 913, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2304, 2321);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2335, 2354);

                this.Operator = op;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2368, 2409);

                this.SourceConversion = sourceConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2423, 2464);

                this.TargetConversion = targetConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2478, 2503);

                this.FromType = fromType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10846, 2517, 2538);

                this.ToType = toType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10846, 2008, 2549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10846, 2008, 2549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10846, 2008, 2549);
            }
        }

        static UserDefinedConversionAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10846, 547, 2556);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10846, 547, 2556);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10846, 547, 2556);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10846, 547, 2556);
    }
}
