// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class EvaluatedConstant
    {
        public readonly ConstantValue Value;

        public readonly ImmutableArray<Diagnostic> Diagnostics;

        public EvaluatedConstant(ConstantValue value, ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10093, 645, 844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 562, 567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 755, 774);

                this.Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 788, 833);

                this.Diagnostics = diagnostics.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10093, 645, 844);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 645, 844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 645, 844);
            }
        }

        static EvaluatedConstant()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10093, 476, 851);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10093, 476, 851);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 476, 851);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10093, 476, 851);
    }
    internal static class ConstantValueUtils
    {
        public static ConstantValue EvaluateFieldConstant(
                    SourceFieldSymbol symbol,
                    EqualsValueClauseSyntax equalsValueNode,
                    HashSet<SourceFieldSymbolWithSyntaxReference> dependencies,
                    bool earlyDecodingWellKnownAttributes,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10093, 916, 2170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1249, 1295);

                var
                compilation = f_10093_1267_1294(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1309, 1402);

                var
                binderFactory = f_10093_1329_1401(compilation, f_10093_1370_1400(f_10093_1370_1386(symbol)[0]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1416, 1470);

                var
                binder = f_10093_1429_1469(binderFactory, equalsValueNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1484, 1620) || true) && (earlyDecodingWellKnownAttributes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 1484, 1620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1554, 1605);

                    binder = f_10093_1563_1604(binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 1484, 1620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1634, 1752);

                var
                inProgressBinder = f_10093_1657_1751(f_10093_1692_1742(symbol, dependencies), binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1766, 1884);

                BoundFieldEqualsValue
                boundValue = f_10093_1801_1883(inProgressBinder, symbol, equalsValueNode, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1898, 1957);

                var
                initValueNodeLocation = f_10093_1926_1956(f_10093_1926_1947(equalsValueNode))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 1973, 2088);

                var
                value = f_10093_1985_2087(f_10093_2013_2029(boundValue), symbol, f_10093_2039_2050(symbol), initValueNodeLocation, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2102, 2130);

                f_10093_2102_2129(value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2146, 2159);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10093, 916, 2170);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10093_1267_1294(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 1267, 1294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10093_1370_1386(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 1370, 1386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10093_1370_1400(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 1370, 1400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10093_1329_1401(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1329, 1401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10093_1429_1469(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1429, 1469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                f_10093_1563_1604(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder(enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1563, 1604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                f_10093_1692_1742(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                fieldOpt, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                dependencies)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress(fieldOpt, dependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1692, 1742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgressBinder
                f_10093_1657_1751(Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgressBinder(inProgress, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1657, 1751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10093_1801_1883(Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgressBinder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BindFieldOrEnumInitializer((Microsoft.CodeAnalysis.CSharp.Binder)binder, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol, initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1801, 1883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10093_1926_1947(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 1926, 1947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10093_1926_1956(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 1926, 1956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10093_2013_2029(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 2013, 2029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10093_2039_2050(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 2039, 2050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10093_1985_2087(Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundValue, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                thisSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.Location
                initValueNodeLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetAndValidateConstantValue(boundValue, (Microsoft.CodeAnalysis.CSharp.Symbol)thisSymbol, typeSymbol, initValueNodeLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 1985, 2087);
                    return return_v;
                }


                int
                f_10093_2102_2129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 2102, 2129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 916, 2170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 916, 2170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundFieldEqualsValue BindFieldOrEnumInitializer(
                    Binder binder,
                    FieldSymbol fieldSymbol,
                    EqualsValueClauseSyntax initializer,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10093, 2182, 3089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2427, 2486);

                var
                enumConstant = fieldSymbol as SourceEnumConstantSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2500, 2556);

                Binder
                collisionDetector = f_10093_2527_2555(binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2570, 2660);

                collisionDetector = f_10093_2590_2659(initializer, fieldSymbol, collisionDetector);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2674, 2703);

                BoundFieldEqualsValue
                result
                = default(BoundFieldEqualsValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2719, 3048) || true) && ((object)enumConstant != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 2719, 3048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2785, 2880);

                    result = f_10093_2794_2879(collisionDetector, enumConstant, initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 2719, 3048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 2719, 3048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 2946, 3033);

                    result = f_10093_2955_3032(collisionDetector, fieldSymbol, initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 2719, 3048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3064, 3078);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10093, 2182, 3089);

                Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                f_10093_2527_2555(Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 2527, 2555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10093_2590_2659(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 2590, 2659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10093_2794_2879(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                equalsValueSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindEnumConstantInitializer(symbol, equalsValueSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 2794, 2879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10093_2955_3032(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializerOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindFieldInitializer(field, initializerOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 2955, 3032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 2182, 3089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 2182, 3089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string UnescapeInterpolatedStringLiteral(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10093, 3101, 3698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3192, 3240);

                var
                builder = f_10093_3206_3239()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3254, 3290);

                var
                stringBuilder = builder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3304, 3332);

                int
                formatLength = f_10093_3323_3331(s)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3355, 3360);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3346, 3640) || true) && (i < formatLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3380, 3383)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 3346, 3640))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 3346, 3640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3417, 3431);

                        char
                        c = f_10093_3426_3430(s, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3449, 3473);

                        f_10093_3449_3472(stringBuilder, c);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3491, 3625) || true) && ((c == '{' || (DynAbs.Tracing.TraceSender.Expression_False(10093, 3496, 3516) || c == '}')) && (DynAbs.Tracing.TraceSender.Expression_True(10093, 3495, 3543) && (i + 1) < formatLength) && (DynAbs.Tracing.TraceSender.Expression_True(10093, 3495, 3560) && f_10093_3547_3555(s, i + 1) == c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 3491, 3625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3602, 3606);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 3491, 3625);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10093, 1, 295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10093, 1, 295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3654, 3687);

                return f_10093_3661_3686(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10093, 3101, 3698);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10093_3206_3239()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 3206, 3239);
                    return return_v;
                }


                int
                f_10093_3323_3331(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 3323, 3331);
                    return return_v;
                }


                char
                f_10093_3426_3430(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 3426, 3430);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10093_3449_3472(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 3449, 3472);
                    return return_v;
                }


                char
                f_10093_3547_3555(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 3547, 3555);
                    return return_v;
                }


                string
                f_10093_3661_3686(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 3661, 3686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 3101, 3698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 3101, 3698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConstantValue GetAndValidateConstantValue(
                    BoundExpression boundValue,
                    Symbol thisSymbol,
                    TypeSymbol typeSymbol,
                    Location initValueNodeLocation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10093, 3710, 7201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 3987, 4017);

                var
                value = f_10093_3999_4016()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4031, 4089);

                f_10093_4031_4088(boundValue, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4103, 7161) || true) && (f_10093_4107_4131_M(!boundValue.HasAnyErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 4103, 7161);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4165, 7146) || true) && (f_10093_4169_4188(typeSymbol) == TypeKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 4165, 7146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4256, 4365);

                        f_10093_4256_4364(diagnostics, ErrorCode.ERR_InvalidConstantDeclarationType, initValueNodeLocation, thisSymbol, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 4165, 7146);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 4165, 7146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4447, 4481);

                        bool
                        hasDynamicConversion = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4503, 4542);

                        var
                        unconvertedBoundValue = boundValue
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4564, 4930) || true) && (f_10093_4571_4597(unconvertedBoundValue) == BoundKind.Conversion)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 4564, 4930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4671, 4727);

                                var
                                conversion = (BoundConversion)unconvertedBoundValue
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4753, 4838);

                                hasDynamicConversion = hasDynamicConversion || (DynAbs.Tracing.TraceSender.Expression_False(10093, 4776, 4837) || f_10093_4800_4837(f_10093_4800_4825(conversion)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 4864, 4907);

                                unconvertedBoundValue = f_10093_4888_4906(conversion);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 4564, 4930);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10093, 4564, 4930);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10093, 4564, 4930);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 5172, 5217);

                        var
                        constantValue = f_10093_5192_5216(boundValue)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 5241, 5308);

                        var
                        unconvertedConstantValue = f_10093_5272_5307(unconvertedBoundValue)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 5330, 6772) || true) && (unconvertedConstantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10093, 5334, 5427) && f_10093_5395_5427_M(!unconvertedConstantValue.IsNull)) && (DynAbs.Tracing.TraceSender.Expression_True(10093, 5334, 5482) && f_10093_5456_5482(typeSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10093, 5334, 5562) && f_10093_5511_5533(typeSymbol) != SpecialType.System_String))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 5330, 6772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 6084, 6183);

                            f_10093_6084_6182(                        // Suppose we are in this case:
                                                                      //
                                                                      // const object x = "some_string"
                                                                      //
                                                                      // A constant of type object can only be initialized to
                                                                      // null; it may not contain an implicit reference conversion
                                                                      // from string.
                                                                      //
                                                                      // Give a special error for that case.
                                                    diagnostics, ErrorCode.ERR_NotNullConstRefField, initValueNodeLocation, thisSymbol, typeSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 6691, 6749);

                            constantValue = constantValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConstantValue?>(10093, 6707, 6748) ?? unconvertedConstantValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 5330, 6772);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 6796, 7127) || true) && (constantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10093, 6800, 6846) && !hasDynamicConversion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 6796, 7127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 6896, 6918);

                            value = constantValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 6796, 7127);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 6796, 7127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7016, 7104);

                            f_10093_7016_7103(diagnostics, ErrorCode.ERR_NotConstantExpression, initValueNodeLocation, thisSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 6796, 7127);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 4165, 7146);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 4103, 7161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7177, 7190);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10093, 3710, 7201);

                Microsoft.CodeAnalysis.ConstantValue
                f_10093_3999_4016()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 3999, 4016);
                    return return_v;
                }


                int
                f_10093_4031_4088(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckLangVersionForConstantValue(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 4031, 4088);
                    return 0;
                }


                bool
                f_10093_4107_4131_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 4107, 4131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10093_4169_4188(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 4169, 4188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10093_4256_4364(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 4256, 4364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10093_4571_4597(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 4571, 4597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10093_4800_4825(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 4800, 4825);
                    return return_v;
                }


                bool
                f_10093_4800_4837(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 4800, 4837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10093_4888_4906(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 4888, 4906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10093_5192_5216(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 5192, 5216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10093_5272_5307(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 5272, 5307);
                    return return_v;
                }


                bool
                f_10093_5395_5427_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 5395, 5427);
                    return return_v;
                }


                bool
                f_10093_5456_5482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 5456, 5482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10093_5511_5533(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 5511, 5533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10093_6084_6182(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 6084, 6182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10093_7016_7103(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 7016, 7103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 3710, 7201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 3710, 7201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class CheckConstantInterpolatedStringValidity : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            internal readonly DiagnosticBag diagnostics;

            public CheckConstantInterpolatedStringValidity(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10093, 7431, 7583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7403, 7414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7537, 7568);

                    this.diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10093, 7431, 7583);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 7431, 7583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 7431, 7583);
                }
            }

            public override BoundNode VisitInterpolatedString(BoundInterpolatedString node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10093, 7599, 7864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7711, 7819);

                    f_10093_7711_7818(node.Syntax, MessageID.IDS_FeatureConstantInterpolatedStrings, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 7837, 7849);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10093, 7599, 7864);

                    bool
                    f_10093_7711_7818(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                    feature, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = Binder.CheckFeatureAvailability(syntax, feature, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 7711, 7818);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 7599, 7864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 7599, 7864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CheckConstantInterpolatedStringValidity()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10093, 7213, 7875);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10093, 7213, 7875);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 7213, 7875);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10093, 7213, 7875);
        }

        internal static void CheckLangVersionForConstantValue(BoundExpression expression, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10093, 7887, 8259);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 8020, 8248) || true) && (!(f_10093_8026_8041(expression) is null) && (DynAbs.Tracing.TraceSender.Expression_True(10093, 8024, 8084) && f_10093_8054_8084(f_10093_8054_8069(expression))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10093, 8020, 8248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 8118, 8189);

                    var
                    visitor = f_10093_8132_8188(diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10093, 8207, 8233);

                    f_10093_8207_8232(visitor, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10093, 8020, 8248);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10093, 7887, 8259);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10093_8026_8041(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 8026, 8041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10093_8054_8069(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10093, 8054, 8069);
                    return return_v;
                }


                bool
                f_10093_8054_8084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsStringType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 8054, 8084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantValueUtils.CheckConstantInterpolatedStringValidity
                f_10093_8132_8188(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstantValueUtils.CheckConstantInterpolatedStringValidity(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 8132, 8188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10093_8207_8232(Microsoft.CodeAnalysis.CSharp.Symbols.ConstantValueUtils.CheckConstantInterpolatedStringValidity
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10093, 8207, 8232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10093, 7887, 8259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 7887, 8259);
            }
        }

        static ConstantValueUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10093, 859, 8266);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10093, 859, 8266);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10093, 859, 8266);
        }

    }
}
