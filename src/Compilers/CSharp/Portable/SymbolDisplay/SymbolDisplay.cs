// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static class SymbolDisplay
    {
        public static string ToDisplayString(
                    ISymbol symbol,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 1369, 1576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 1509, 1565);

                return f_10042_1516_1546(symbol, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 1369, 1576);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_1516_1546(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToDisplayParts(symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 1516, 1546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 1369, 1576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 1369, 1576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToDisplayString(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableFlowState nullableFlowState,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 1685, 1978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 1892, 1967);

                return f_10042_1899_1948(symbol, nullableFlowState, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 1685, 1978);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_1899_1948(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToDisplayParts(symbol, nullableFlowState, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 1899, 1948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 1685, 1978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 1685, 1978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToDisplayString(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableAnnotation nullableAnnotation,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 1990, 2286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 2199, 2275);

                return f_10042_2206_2256(symbol, nullableAnnotation, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 1990, 2286);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_2206_2256(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToDisplayParts(symbol, nullableAnnotation, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 2206, 2256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 1990, 2286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 1990, 2286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToMinimalDisplayString(
                    ISymbol symbol,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 3372, 3687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 3588, 3676);

                return f_10042_3595_3657(symbol, semanticModel, position, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 3372, 3687);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_3595_3657(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToMinimalDisplayParts(symbol, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 3595, 3657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 3372, 3687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 3372, 3687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToMinimalDisplayString(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableFlowState nullableFlowState,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 3796, 4197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 4079, 4186);

                return f_10042_4086_4167(symbol, nullableFlowState, semanticModel, position, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 3796, 4197);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_4086_4167(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToMinimalDisplayParts(symbol, nullableFlowState, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 4086, 4167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 3796, 4197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 3796, 4197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToMinimalDisplayString(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableAnnotation nullableAnnotation,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 4209, 4613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 4494, 4602);

                return f_10042_4501_4583(symbol, nullableAnnotation, semanticModel, position, format).ToDisplayString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 4209, 4613);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_4501_4583(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = ToMinimalDisplayParts(symbol, nullableAnnotation, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 4501, 4583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 4209, 4613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 4209, 4613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToDisplayParts(
                    ISymbol symbol,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 5325, 5751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 5541, 5605);

                format = format ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SymbolDisplayFormat?>(10042, 5550, 5604) ?? f_10042_5560_5604());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 5619, 5740);

                return f_10042_5626_5739(symbol, semanticModelOpt: null, positionOpt: -1, format: format, minimal: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 5325, 5751);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_5560_5604()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 5560, 5604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_5626_5739(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel?
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts(symbol, semanticModelOpt: semanticModelOpt, positionOpt: positionOpt, format: format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 5626, 5739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 5325, 5751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 5325, 5751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToDisplayParts(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableFlowState nullableFlowState,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 5929, 6441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 6212, 6276);

                format = format ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SymbolDisplayFormat?>(10042, 6221, 6275) ?? f_10042_6231_6275());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 6290, 6430);

                return f_10042_6297_6429(symbol, nullableFlowState, semanticModelOpt: null, positionOpt: -1, format: format, minimal: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 5929, 6441);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_6231_6275()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 6231, 6275);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_6297_6429(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel?
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts(symbol, nullableFlowState, semanticModelOpt: semanticModelOpt, positionOpt: positionOpt, format: format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 6297, 6429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 5929, 6441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 5929, 6441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToDisplayParts(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableAnnotation nullableAnnotation,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 6453, 7041);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 6761, 6852) || true) && (format == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 6761, 6852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 6798, 6852);

                    format = f_10042_6807_6851();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 6761, 6852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 6866, 7030);

                return f_10042_6873_7029(f_10042_6906_6955(symbol, nullableAnnotation), semanticModelOpt: null, positionOpt: -1, format: format, minimal: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 6453, 7041);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_6807_6851()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 6807, 6851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10042_6906_6955(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.WithNullableAnnotation(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 6906, 6955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_6873_7029(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel?
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, semanticModelOpt: semanticModelOpt, positionOpt: positionOpt, format: format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 6873, 7029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 6453, 7041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 6453, 7041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    ISymbol symbol,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 8009, 8468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 8274, 8365) || true) && (format == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 8274, 8365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 8311, 8365);

                    format = f_10042_8320_8364();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 8274, 8365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 8379, 8457);

                return f_10042_8386_8456(symbol, semanticModel, position, format, minimal: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 8009, 8468);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_8320_8364()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 8320, 8364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_8386_8456(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts(symbol, semanticModelOpt, positionOpt, format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 8386, 8456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 8009, 8468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 8009, 8468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableFlowState nullableFlowState,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 8646, 9191);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 8978, 9069) || true) && (format == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 8978, 9069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 9015, 9069);

                    format = f_10042_9024_9068();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 8978, 9069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 9083, 9180);

                return f_10042_9090_9179(symbol, nullableFlowState, semanticModel, position, format, minimal: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 8646, 9191);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_9024_9068()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 9024, 9068);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_9090_9179(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts(symbol, nullableFlowState, semanticModelOpt, positionOpt, format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 9090, 9179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 8646, 9191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 8646, 9191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableAnnotation nullableAnnotation,
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat? format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 9203, 9774);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 9537, 9628) || true) && (format == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 9537, 9628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 9574, 9628);

                    format = f_10042_9583_9627();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 9537, 9628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 9642, 9763);

                return f_10042_9649_9762(f_10042_9664_9713(symbol, nullableAnnotation), semanticModel, position, format, minimal: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 9203, 9774);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10042_9583_9627()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 9583, 9627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10042_9664_9713(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.WithNullableAnnotation(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 9664, 9713);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_9649_9762(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, semanticModelOpt, positionOpt, format, minimal: minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 9649, 9762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 9203, 9774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 9203, 9774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<SymbolDisplayPart> ToDisplayParts(
                    ITypeSymbol symbol,
                    CodeAnalysis.NullableFlowState nullableFlowState,
                    SemanticModel? semanticModelOpt,
                    int positionOpt,
                    SymbolDisplayFormat format,
                    bool minimal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 9883, 10358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10212, 10347);

                return f_10042_10219_10346(f_10042_10234_10297(symbol, f_10042_10264_10296(nullableFlowState)), semanticModelOpt, positionOpt, format, minimal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 9883, 10358);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10042_10264_10296(Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState)
                {
                    var return_v = nullableFlowState.ToAnnotation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 10264, 10296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10042_10234_10297(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.WithNullableAnnotation(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 10234, 10297);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_10219_10346(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel?
                semanticModelOpt, int
                positionOpt, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, bool
                minimal)
                {
                    var return_v = ToDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, semanticModelOpt, positionOpt, format, minimal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 10219, 10346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 9883, 10358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 9883, 10358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<SymbolDisplayPart> ToDisplayParts(
                    ISymbol symbol,
                    SemanticModel? semanticModelOpt,
                    int positionOpt,
                    SymbolDisplayFormat format,
                    bool minimal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 10370, 12242);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10632, 10747) || true) && (symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10632, 10747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10684, 10732);

                    throw f_10042_10690_10731(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10632, 10747);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10763, 11408) || true) && (minimal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10763, 11408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10808, 11240) || true) && (semanticModelOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10808, 11240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10878, 10951);

                        throw f_10042_10884_10950(f_10042_10906_10949());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10808, 11240);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10808, 11240);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 10993, 11240) || true) && (positionOpt < 0 || (DynAbs.Tracing.TraceSender.Expression_False(10042, 10997, 11064) || positionOpt > f_10042_11030_11064(f_10042_11030_11057(semanticModelOpt))))
                        ) // Note: not >= since EOF is allowed.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10993, 11240);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11144, 11221);

                            throw f_10042_11150_11220(f_10042_11182_11219());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10993, 11240);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10808, 11240);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10763, 11408);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 10763, 11408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11306, 11345);

                    f_10042_11306_11344(semanticModelOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11363, 11393);

                    f_10042_11363_11392(positionOpt < 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 10763, 11408);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11588, 11965) || true) && (symbol is Symbols.PublicModel.MethodSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10042, 11592, 11765) && f_10042_11656_11721(((Symbols.PublicModel.MethodSymbol)symbol)) is SynthesizedSimpleProgramEntryPointSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 11588, 11965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11799, 11950);

                    return f_10042_11806_11949(f_10042_11847_11948(SymbolDisplayPartKind.MethodName, symbol, "<top-level-statements-entry-point>"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 11588, 11965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 11981, 12041);

                var
                builder = f_10042_11995_12040()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 12055, 12142);

                var
                visitor = f_10042_12069_12141(builder, format, semanticModelOpt, positionOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 12156, 12179);

                f_10042_12156_12178(symbol, visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 12195, 12231);

                return f_10042_12202_12230(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 10370, 12242);

                System.ArgumentNullException
                f_10042_10690_10731(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 10690, 10731);
                    return return_v;
                }


                string
                f_10042_10906_10949()
                {
                    var return_v = CSharpResources.SyntaxTreeSemanticModelMust;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 10906, 10949);
                    return return_v;
                }


                System.ArgumentException
                f_10042_10884_10950(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 10884, 10950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10042_11030_11057(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 11030, 11057);
                    return return_v;
                }


                int
                f_10042_11030_11064(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 11030, 11064);
                    return return_v;
                }


                string
                f_10042_11182_11219()
                {
                    var return_v = CSharpResources.PositionNotWithinTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 11182, 11219);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_10042_11150_11220(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11150, 11220);
                    return return_v;
                }


                int
                f_10042_11306_11344(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11306, 11344);
                    return 0;
                }


                int
                f_10042_11363_11392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11363, 11392);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10042_11656_11721(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10042, 11656, 11721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10042_11847_11948(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11847, 11948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_11806_11949(Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    var return_v = ImmutableArray.Create<SymbolDisplayPart>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11806, 11949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_11995_12040()
                {
                    var return_v = ArrayBuilder<SymbolDisplayPart>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 11995, 12040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                f_10042_12069_12141(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                builder, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, Microsoft.CodeAnalysis.SemanticModel?
                semanticModelOpt, int
                positionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor(builder, format, semanticModelOpt, positionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 12069, 12141);
                    return return_v;
                }


                int
                f_10042_12156_12178(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 12156, 12178);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10042_12202_12230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 12202, 12230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 10370, 12242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 10370, 12242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string FormatPrimitive(object obj, bool quoteStrings, bool useHexadecimalNumbers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 13197, 13720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13317, 13381);

                var
                options = ObjectDisplayOptions.EscapeNonPrintableCharacters
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13395, 13502) || true) && (quoteStrings)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 13395, 13502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13445, 13487);

                    options |= ObjectDisplayOptions.UseQuotes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 13395, 13502);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13516, 13644) || true) && (useHexadecimalNumbers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10042, 13516, 13644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13575, 13629);

                    options |= ObjectDisplayOptions.UseHexadecimalNumbers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10042, 13516, 13644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 13658, 13709);

                return f_10042_13665_13708(obj, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 13197, 13720);

                string
                f_10042_13665_13708(object
                obj, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatPrimitive(obj, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 13665, 13708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 13197, 13720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 13197, 13720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string FormatLiteral(string value, bool quote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 14201, 14514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 14286, 14438);

                var
                options = ObjectDisplayOptions.EscapeNonPrintableCharacters |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10042, 14370, 14375) || ((quote && DynAbs.Tracing.TraceSender.Conditional_F2(10042, 14378, 14408)) || DynAbs.Tracing.TraceSender.Conditional_F3(10042, 14411, 14436))) ? ObjectDisplayOptions.UseQuotes : ObjectDisplayOptions.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 14452, 14503);

                return f_10042_14459_14502(value, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 14201, 14514);

                string
                f_10042_14459_14502(string
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 14459, 14502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 14201, 14514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 14201, 14514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string FormatLiteral(char c, bool quote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10042, 15003, 15306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 15082, 15234);

                var
                options = ObjectDisplayOptions.EscapeNonPrintableCharacters |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10042, 15166, 15171) || ((quote && DynAbs.Tracing.TraceSender.Conditional_F2(10042, 15174, 15204)) || DynAbs.Tracing.TraceSender.Conditional_F3(10042, 15207, 15232))) ? ObjectDisplayOptions.UseQuotes : ObjectDisplayOptions.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10042, 15248, 15295);

                return f_10042_15255_15294(c, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10042, 15003, 15306);

                string
                f_10042_15255_15294(char
                c, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(c, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10042, 15255, 15294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10042, 15003, 15306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 15003, 15306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolDisplay()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10042, 731, 15313);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10042, 731, 15313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10042, 731, 15313);
        }

    }
}
