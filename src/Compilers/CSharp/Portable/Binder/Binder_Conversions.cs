// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal BoundExpression CreateConversion(
                    BoundExpression source,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 624, 1221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 805, 856);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 870, 977);

                var
                conversion = f_10303_887_976(f_10303_887_898(), source, destination, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 993, 1044);

                f_10303_993_1043(
                            diagnostics, source.Syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 1058, 1210);

                return f_10303_1065_1209(this, source.Syntax, source, conversion, isCast: false, conversionGroupOpt: null, destination: destination, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 624, 1221);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_887_898()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 887, 898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_887_976(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 887, 976);
                    return return_v;
                }


                bool
                f_10303_993_1043(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 993, 1043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_1065_1209(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 1065, 1209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 624, 1221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 624, 1221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression CreateConversion(
                    BoundExpression source,
                    Conversion conversion,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 1233, 1613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 1450, 1602);

                return f_10303_1457_1601(this, source.Syntax, source, conversion, isCast: false, conversionGroupOpt: null, destination: destination, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 1233, 1613);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_1457_1601(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 1457, 1601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 1233, 1613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 1233, 1613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression CreateConversion(
                    SyntaxNode syntax,
                    BoundExpression source,
                    Conversion conversion,
                    bool isCast,
                    ConversionGroup? conversionGroupOpt,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 1625, 2104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 1950, 2093);

                return f_10303_1957_2092(this, syntax, source, conversion, isCast: isCast, conversionGroupOpt, f_10303_2038_2065(source), destination, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 1625, 2104);

                bool
                f_10303_2038_2065(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 2038, 2065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_1957_2092(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, bool
                wasCompilerGenerated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt, wasCompilerGenerated, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 1957, 2092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 1625, 2104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 1625, 2104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpression CreateConversion(
                    SyntaxNode syntax,
                    BoundExpression source,
                    Conversion conversion,
                    bool isCast,
                    ConversionGroup? conversionGroupOpt,
                    bool wasCompilerGenerated,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics,
                    bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 2116, 8505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2519, 2554);

                f_10303_2519_2553(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2568, 2616);

                f_10303_2568_2615((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2630, 2688);

                f_10303_2630_2687(!isCast || (DynAbs.Tracing.TraceSender.Expression_False(10303, 2649, 2686) || conversionGroupOpt != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2704, 3719) || true) && (conversion.IsIdentity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 2704, 3719);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2763, 2954) || true) && (source is BoundTupleLiteral sourceTuple)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 2763, 2954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 2848, 2935);

                        f_10303_2848_2934(destination, sourceTuple, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 2763, 2954);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3145, 3193);

                    source = f_10303_3154_3192(this, source, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3211, 3253);

                    f_10303_3211_3252(f_10303_3230_3241(source) is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3525, 3704) || true) && (!isCast && (DynAbs.Tracing.TraceSender.Expression_True(10303, 3529, 3629) && f_10303_3540_3629(f_10303_3540_3551(source), destination, TypeCompareKind.IgnoreNullableModifiersForReferenceTypes)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 3525, 3704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3671, 3685);

                        return source;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 3525, 3704);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 2704, 3719);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3735, 3937) || true) && (conversion.IsMethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 3735, 3937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 3797, 3922);

                    return f_10303_3804_3921(this, syntax, source, conversion, isCast: isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 3735, 3937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4069, 4154);

                f_10303_4069_4153(this, diagnostics, conversion, syntax, hasBaseReceiver: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4170, 4426) || true) && (conversion.IsAnonymousFunction && (DynAbs.Tracing.TraceSender.Expression_True(10303, 4174, 4246) && f_10303_4208_4219(source) == BoundKind.UnboundLambda))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 4170, 4426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4280, 4411);

                    return f_10303_4287_4410(syntax, source, conversion, isCast: isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 4170, 4426);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4442, 4634) || true) && (conversion.IsStackAlloc)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 4442, 4634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4503, 4619);

                    return f_10303_4510_4618(this, syntax, source, conversion, isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 4442, 4634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4650, 4991) || true) && (conversion.IsTupleLiteralConversion || (DynAbs.Tracing.TraceSender.Expression_False(10303, 4654, 4797) || (conversion.IsNullable && (DynAbs.Tracing.TraceSender.Expression_True(10303, 4711, 4796) && conversion.UnderlyingConversions[0].IsTupleLiteralConversion))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 4650, 4991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 4831, 4976);

                    return f_10303_4838_4975(this, syntax, source, conversion, isCast: isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 4650, 4991);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5007, 5246) || true) && (conversion.Kind == ConversionKind.SwitchExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 5007, 5246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5095, 5231);

                    return f_10303_5102_5230(this, source, destination, conversionIfTargetTyped: conversion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 5007, 5246);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5262, 5514) || true) && (conversion.Kind == ConversionKind.ConditionalExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 5262, 5514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5355, 5499);

                    return f_10303_5362_5498(this, source, destination, conversionIfTargetTyped: conversion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 5262, 5514);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5530, 6217) || true) && (f_10303_5534_5545(source) == BoundKind.UnconvertedSwitchExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 5530, 6217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5620, 5651);

                    TypeSymbol?
                    type = f_10303_5639_5650(source)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5669, 5865) || true) && (type is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 5669, 5865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5727, 5760);

                        f_10303_5727_5759(f_10303_5740_5758_M(!conversion.Exists));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5782, 5807);

                        type = f_10303_5789_5806(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5829, 5846);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 5669, 5865);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 5885, 6021);

                    source = f_10303_5894_6020(this, source, type, conversionIfTargetTyped: null, diagnostics, hasErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6039, 6202) || true) && (f_10303_6043_6103(destination, type, TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10303, 6043, 6127) && wasCompilerGenerated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 6039, 6202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6169, 6183);

                        return source;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 6039, 6202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 5530, 6217);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6233, 6444) || true) && (conversion.IsObjectCreation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 6233, 6444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6298, 6429);

                    return f_10303_6305_6428(this, syntax, source, isCast, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 6233, 6444);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6460, 7158) || true) && (f_10303_6464_6475(source) == BoundKind.UnconvertedConditionalOperator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 6460, 7158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6553, 6584);

                    TypeSymbol?
                    type = f_10303_6572_6583(source)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6602, 6798) || true) && (type is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 6602, 6798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6660, 6693);

                        f_10303_6660_6692(f_10303_6673_6691_M(!conversion.Exists));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6715, 6740);

                        type = f_10303_6722_6739(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6762, 6779);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 6602, 6798);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6818, 6962);

                    source = f_10303_6827_6961(this, source, type, conversionIfTargetTyped: null, diagnostics, hasErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 6980, 7143) || true) && (f_10303_6984_7044(destination, type, TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10303, 6984, 7068) && wasCompilerGenerated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 6980, 7143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7110, 7124);

                        return source;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 6980, 7143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 6460, 7158);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7174, 7589) || true) && (conversion.IsUserDefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 7174, 7589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7403, 7574);

                    return f_10303_7410_7573(this, syntax, source, conversion, isCast: isCast, conversionGroupOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.ConversionGroup?>(10303, 7482, 7535) ?? f_10303_7504_7535(conversion)), destination, diagnostics, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 7174, 7589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7605, 7718);

                ConstantValue?
                constantValue = f_10303_7636_7717(this, syntax, source, conversion, destination, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7732, 7995) || true) && (conversion.Kind == ConversionKind.DefaultLiteral)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 7732, 7995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 7818, 7980);

                    source = f_10303_7827_7979(f_10303_7827_7920(source.Syntax, targetType: null, constantValue, type: destination), f_10303_7959_7978(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 7732, 7995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 8011, 8494);

                return new BoundConversion(
                                syntax,
                f_10303_8081_8119(this, source, diagnostics),
                                conversion,
                                @checked: f_10303_8177_8199(),
                                explicitCastInCode: isCast && (DynAbs.Tracing.TraceSender.Expression_True(10303, 8238, 8269) && !wasCompilerGenerated),
                                conversionGroupOpt,
                                constantValueOpt: constantValue,
                                type: destination,
                                hasErrors: hasErrors)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => wasCompilerGenerated, 10303, 8018, 8493) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 2116, 8505);

                int
                f_10303_2519_2553(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 2519, 2553);
                    return 0;
                }


                int
                f_10303_2568_2615(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 2568, 2615);
                    return 0;
                }


                int
                f_10303_2630_2687(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 2630, 2687);
                    return 0;
                }


                int
                f_10303_2848_2934(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                literal, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    NamedTypeSymbol.ReportTupleNamesMismatchesIfAny(destination, literal, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 2848, 2934);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_3154_3192(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 3154, 3192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_3230_3241(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 3230, 3241);
                    return return_v;
                }


                int
                f_10303_3211_3252(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 3211, 3252);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_3540_3551(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 3540, 3551);
                    return return_v;
                }


                bool
                f_10303_3540_3629(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 3540, 3629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_3804_3921(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroup, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateMethodGroupConversion(syntax, source, conversion, isCast: isCast, conversionGroup, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 3804, 3921);
                    return return_v;
                }


                int
                f_10303_4069_4153(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, conversion, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 4069, 4153);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_4208_4219(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 4208, 4219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_4287_4410(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroup, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CreateAnonymousFunctionConversion(syntax, source, conversion, isCast: isCast, conversionGroup, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 4287, 4410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_4510_4618(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroup, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateStackAllocConversion(syntax, source, conversion, isCast, conversionGroup, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 4510, 4618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_4838_4975(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceTuple, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroup, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateTupleLiteralConversion(syntax, (Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)sourceTuple, conversion, isCast: isCast, conversionGroup, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 4838, 4975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_5102_5230(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertSwitchExpression((Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression)source, destination, conversionIfTargetTyped: (Microsoft.CodeAnalysis.CSharp.Conversion?)conversionIfTargetTyped, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 5102, 5230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_5362_5498(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertConditionalExpression((Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator)source, destination, conversionIfTargetTyped: (Microsoft.CodeAnalysis.CSharp.Conversion?)conversionIfTargetTyped, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 5362, 5498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_5534_5545(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 5534, 5545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_5639_5650(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 5639, 5650);
                    return return_v;
                }


                bool
                f_10303_5740_5758_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 5740, 5758);
                    return return_v;
                }


                int
                f_10303_5727_5759(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 5727, 5759);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_5789_5806(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 5789, 5806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_5894_6020(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion?
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                hasErrors)
                {
                    var return_v = this_param.ConvertSwitchExpression((Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression)source, destination, conversionIfTargetTyped: conversionIfTargetTyped, diagnostics, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 5894, 6020);
                    return return_v;
                }


                bool
                f_10303_6043_6103(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6043, 6103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_6305_6428(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isCast, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertObjectCreationExpression(syntax, (Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression)node, isCast, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6305, 6428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_6464_6475(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 6464, 6475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_6572_6583(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 6572, 6583);
                    return return_v;
                }


                bool
                f_10303_6673_6691_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 6673, 6691);
                    return return_v;
                }


                int
                f_10303_6660_6692(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6660, 6692);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_6722_6739(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6722, 6739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_6827_6961(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion?
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                hasErrors)
                {
                    var return_v = this_param.ConvertConditionalExpression((Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator)source, destination, conversionIfTargetTyped: conversionIfTargetTyped, diagnostics, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6827, 6961);
                    return return_v;
                }


                bool
                f_10303_6984_7044(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 6984, 7044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup
                f_10303_7504_7535(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ConversionGroup(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 7504, 7535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_7410_7573(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroup, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                hasErrors)
                {
                    var return_v = this_param.CreateUserDefinedConversion(syntax, source, conversion, isCast: isCast, conversionGroup, destination, diagnostics, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 7410, 7573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_7636_7717(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FoldConstantConversion(syntax, source, conversion, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 7636, 7717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10303_7827_7920(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                targetType, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, targetType: targetType, constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 7827, 7920);
                    return return_v;
                }


                bool
                f_10303_7959_7978(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 7959, 7978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_7827_7979(Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                this_param, bool
                suppress)
                {
                    var return_v = this_param.WithSuppression(suppress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 7827, 7979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_8081_8119(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 8081, 8119);
                    return return_v;
                }


                bool
                f_10303_8177_8199()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 8177, 8199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 2116, 8505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 2116, 8505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ConvertObjectCreationExpression(SyntaxNode syntax, BoundUnconvertedObjectCreationExpression node, bool isCast, TypeSymbol destination, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 8517, 10060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 8727, 8838);

                var
                arguments = f_10303_8743_8837(f_10303_8773_8787(node), f_10303_8789_8813(node), f_10303_8815_8836(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 8852, 8962);

                BoundExpression
                expr = f_10303_8875_8961(this, node, f_10303_8910_8936(destination), arguments, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 8976, 9992) || true) && (f_10303_8980_9008(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 8976, 9992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 9313, 9364);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 9382, 9492);

                    var
                    conversion = f_10303_9399_9491(f_10303_9399_9410(), null, f_10303_9444_9453(expr), destination, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 9510, 9913);

                    expr = f_10303_9517_9912(node.Syntax, operand: expr, conversion: conversion, @checked: false, explicitCastInCode: isCast, conversionGroupOpt: f_10303_9781_9812(conversion), constantValueOpt: f_10303_9853_9871(expr), type: destination);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 9933, 9977);

                    f_10303_9933_9976(
                                    diagnostics, syntax, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 8976, 9992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 10006, 10023);

                f_10303_10006_10022(arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 10037, 10049);

                return expr;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 8517, 10060);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10303_8773_8787(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 8773, 8787);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10303_8789_8813(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 8789, 8813);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_10303_8815_8836(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 8815, 8836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10303_8743_8837(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                argumentNamesOpt)
                {
                    var return_v = AnalyzedArguments.GetInstance(arguments, argumentRefKindsOpt, argumentNamesOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 8743, 8837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_8910_8936(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 8910, 8936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_8875_8961(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindObjectCreationExpression(node, type, arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 8875, 8961);
                    return return_v;
                }


                bool
                f_10303_8980_9008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 8980, 9008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_9399_9410()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 9399, 9410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_9444_9453(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 9444, 9453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_9399_9491(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 9399, 9491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup
                f_10303_9781_9812(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ConversionGroup(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 9781, 9812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_9853_9871(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 9853, 9871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10303_9517_9912(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand: operand, conversion: conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 9517, 9912);
                    return return_v;
                }


                bool
                f_10303_9933_9976(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 9933, 9976);
                    return return_v;
                }


                int
                f_10303_10006_10022(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 10006, 10022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 8517, 10060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 8517, 10060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindObjectCreationExpression(BoundUnconvertedObjectCreationExpression node, TypeSymbol type, AnalyzedArguments arguments, DiagnosticBag diagnostics)
        {
            var syntax = node.Syntax;
            switch (type.TypeKind)
            {
                case TypeKind.Enum:
                case TypeKind.Struct:
                case TypeKind.Class when !type.IsAnonymousType: // We don't want to enable object creation with unspeakable types
                    return BindClassCreationExpression(syntax, type.Name, typeNode: syntax, (NamedTypeSymbol)type, arguments, diagnostics, node.InitializerOpt, wasTargetTyped: true);
                case TypeKind.TypeParameter:
                    return BindTypeParameterCreationExpression(syntax, (TypeParameterSymbol)type, arguments, node.InitializerOpt, typeSyntax: syntax, diagnostics);
                case TypeKind.Delegate:
                    return BindDelegateCreationExpression(syntax, (NamedTypeSymbol)type, arguments, node.InitializerOpt, diagnostics);
                case TypeKind.Interface:
                    return BindInterfaceCreationExpression(syntax, (NamedTypeSymbol)type, diagnostics, typeNode: syntax, arguments, node.InitializerOpt, wasTargetTyped: true);
                case TypeKind.Array:
                case TypeKind.Class:
                case TypeKind.Dynamic:
                    Error(diagnostics, ErrorCode.ERR_ImplicitObjectCreationIllegalTargetType, syntax, type);
                    goto case TypeKind.Error;
                case TypeKind.Pointer:
                case TypeKind.FunctionPointer:
                    Error(diagnostics, ErrorCode.ERR_UnsafeTypeInObjectCreation, syntax, type);
                    goto case TypeKind.Error;
                case TypeKind.Error:
                    return MakeBadExpressionForObjectCreation(syntax, type, arguments, node.InitializerOpt, typeSyntax: syntax, diagnostics);
                case var v:
                    throw ExceptionUtilities.UnexpectedValue(v);
            }
        }

        private BoundExpression ConvertConditionalExpression(
                    BoundUnconvertedConditionalOperator source,
                    TypeSymbol destination,
                    Conversion? conversionIfTargetTyped,
                    DiagnosticBag diagnostics,
                    bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 12329, 14315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 12628, 12678);

                bool
                targetTyped = conversionIfTargetTyped is { }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 12692, 12818);

                f_10303_12692_12817(targetTyped || (DynAbs.Tracing.TraceSender.Expression_False(10303, 12705, 12745) || f_10303_12720_12745(destination)) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 12705, 12816) || f_10303_12749_12816(destination, f_10303_12768_12779(source), TypeCompareKind.ConsiderEverything)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 12832, 12949);

                ImmutableArray<Conversion>
                underlyingConversions = conversionIfTargetTyped.GetValueOrDefault().UnderlyingConversions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 12963, 12996);

                var
                condition = f_10303_12979_12995(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13010, 13069);

                hasErrors |= f_10303_13023_13039(source) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 13023, 13068) || f_10303_13043_13068(destination));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13085, 13402);

                var
                trueExpr =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 13117, 13128) || ((targetTyped
                && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 13148, 13304)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 13324, 13401))) ? f_10303_13148_13304(this, f_10303_13165_13183(source).Syntax, f_10303_13192_13210(source), underlyingConversions[0], isCast: false, conversionGroupOpt: null, destination, diagnostics) : f_10303_13324_13401(this, destination, f_10303_13369_13387(source), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13416, 13734);

                var
                falseExpr =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 13449, 13460) || ((targetTyped
                && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 13480, 13636)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 13656, 13733))) ? f_10303_13480_13636(this, f_10303_13497_13515(source).Syntax, f_10303_13524_13542(source), underlyingConversions[1], isCast: false, conversionGroupOpt: null, destination, diagnostics) : f_10303_13656_13733(this, destination, f_10303_13701_13719(source), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13748, 13824);

                var
                constantValue = f_10303_13768_13823(condition, trueExpr, falseExpr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13838, 13880);

                hasErrors |= f_10303_13851_13871_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(constantValue, 10303, 13851, 13871)?.IsBad) == true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13894, 14055) || true) && (targetTyped && (DynAbs.Tracing.TraceSender.Expression_True(10303, 13898, 13939) && !f_10303_13914_13939(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 13894, 14055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 13958, 14055);

                    f_10303_13958_14054(MessageID.IDS_FeatureTargetTypedConditional, diagnostics, source.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 13894, 14055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 14071, 14304);

                return f_10303_14078_14303(f_10303_14078_14248(source.Syntax, isRef: false, condition, trueExpr, falseExpr, constantValue, f_10303_14183_14194(source), wasTargetTyped: targetTyped, destination, hasErrors), f_10303_14283_14302(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 12329, 14315);

                bool
                f_10303_12720_12745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 12720, 12745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_12768_12779(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 12768, 12779);
                    return return_v;
                }


                bool
                f_10303_12749_12816(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 12749, 12816);
                    return return_v;
                }


                int
                f_10303_12692_12817(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 12692, 12817);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_12979_12995(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 12979, 12995);
                    return return_v;
                }


                bool
                f_10303_13023_13039(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13023, 13039);
                    return return_v;
                }


                bool
                f_10303_13043_13068(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13043, 13068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13165_13183(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13165, 13183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13192_13210(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13192, 13210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13148_13304(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13148, 13304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13369_13387(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13369, 13387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13324_13401(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13324, 13401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13497_13515(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13497, 13515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13524_13542(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13524, 13542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13480_13636(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13480, 13636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13701_13719(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13701, 13719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_13656_13733(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13656, 13733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_13768_13823(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                trueExpr, Microsoft.CodeAnalysis.CSharp.BoundExpression
                falseExpr)
                {
                    var return_v = FoldConditionalOperator(condition, trueExpr, falseExpr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13768, 13823);
                    return return_v;
                }


                bool?
                f_10303_13851_13871_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 13851, 13871);
                    return return_v;
                }


                bool
                f_10303_13914_13939(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13914, 13939);
                    return return_v;
                }


                bool
                f_10303_13958_14054(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 13958, 14054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_14183_14194(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 14183, 14194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                f_10303_14078_14248(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isRef, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                naturalTypeOpt, bool
                wasTargetTyped, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator(syntax, isRef: isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped: wasTargetTyped, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 14078, 14248);
                    return return_v;
                }


                bool
                f_10303_14283_14302(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 14283, 14302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_14078_14303(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param, bool
                suppress)
                {
                    var return_v = this_param.WithSuppression(suppress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 14078, 14303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 12329, 14315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 12329, 14315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ConvertSwitchExpression(BoundUnconvertedSwitchExpression source, TypeSymbol destination, Conversion? conversionIfTargetTyped, DiagnosticBag diagnostics, bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 14486, 16345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 14711, 14761);

                bool
                targetTyped = conversionIfTargetTyped is { }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 14775, 14846);

                Conversion
                conversion = conversionIfTargetTyped ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Conversion?>(10303, 14799, 14845) ?? Conversion.Identity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 14860, 14986);

                f_10303_14860_14985(targetTyped || (DynAbs.Tracing.TraceSender.Expression_False(10303, 14873, 14913) || f_10303_14888_14913(destination)) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 14873, 14984) || f_10303_14917_14984(destination, f_10303_14936_14947(source), TypeCompareKind.ConsiderEverything)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15000, 15084);

                ImmutableArray<Conversion>
                underlyingConversions = conversion.UnderlyingConversions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15098, 15189);

                var
                builder = f_10303_15112_15188(source.SwitchArms.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15212, 15217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15219, 15247);
                    for (int
        i = 0
        ,
        n = source.SwitchArms.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15203, 15976) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15256, 15259)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 15203, 15976))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 15203, 15976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15293, 15328);

                        var
                        oldCase = f_10303_15307_15324(source)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15346, 15375);

                        var
                        oldValue = f_10303_15361_15374(oldCase)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15393, 15692);

                        var
                        newValue =
                        (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 15429, 15440) || ((targetTyped
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 15464, 15600)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 15624, 15691))) ? f_10303_15464_15600(this, oldValue.Syntax, oldValue, underlyingConversions[i], isCast: false, conversionGroupOpt: null, destination, diagnostics) : f_10303_15624_15691(this, destination, oldValue, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15710, 15922);

                        var
                        newCase = (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 15724, 15746) || (((oldValue == newValue) && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 15749, 15756)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 15780, 15921))) ? oldCase : f_10303_15780_15921(oldCase.Syntax, f_10303_15825_15839(oldCase), f_10303_15841_15856(oldCase), f_10303_15858_15876(oldCase), newValue, f_10303_15888_15901(oldCase), f_10303_15903_15920(oldCase))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15940, 15961);

                        f_10303_15940_15960(builder, newCase);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10303, 1, 774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10303, 1, 774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 15992, 16041);

                var
                newSwitchArms = f_10303_16012_16040(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16055, 16334);

                return f_10303_16062_16333(source.Syntax, f_10303_16130_16141(source), targetTyped, conversion, f_10303_16168_16185(source), newSwitchArms, f_10303_16202_16220(source), f_10303_16239_16258(source), f_10303_16260_16288(source), destination, hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10303, 16303, 16332) || f_10303_16316_16332(source)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 14486, 16345);

                bool
                f_10303_14888_14913(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 14888, 14913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_14936_14947(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 14936, 14947);
                    return return_v;
                }


                bool
                f_10303_14917_14984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 14917, 14984);
                    return return_v;
                }


                int
                f_10303_14860_14985(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 14860, 14985);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10303_15112_15188(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSwitchExpressionArm>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 15112, 15188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10303_15307_15324(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15307, 15324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_15361_15374(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15361, 15374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_15464_15600(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 15464, 15600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_15624_15691(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 15624, 15691);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10303_15825_15839(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15825, 15839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10303_15841_15856(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15841, 15856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10303_15858_15876(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15858, 15876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10303_15888_15901(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15888, 15901);
                    return return_v;
                }


                bool
                f_10303_15903_15920(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 15903, 15920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                f_10303_15780_15921(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm(syntax, locals, pattern, whenClause, value, label, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 15780, 15921);
                    return return_v;
                }


                int
                f_10303_15940_15960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 15940, 15960);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10303_16012_16040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 16012, 16040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_16130_16141(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16130, 16141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_16168_16185(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16168, 16185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10303_16202_16220(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16202, 16220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10303_16239_16258(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16239, 16258);
                    return return_v;
                }


                bool
                f_10303_16260_16288(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.ReportedNotExhaustive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16260, 16288);
                    return return_v;
                }


                bool
                f_10303_16316_16332(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16316, 16332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                f_10303_16062_16333(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                naturalTypeOpt, bool
                wasTargetTyped, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchArms, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                defaultLabel, bool
                reportedNotExhaustive, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression(syntax, naturalTypeOpt, wasTargetTyped, conversion, expression, switchArms, decisionDag, defaultLabel, reportedNotExhaustive, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 16062, 16333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 14486, 16345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 14486, 16345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression CreateUserDefinedConversion(
                    SyntaxNode syntax,
                    BoundExpression source,
                    Conversion conversion,
                    bool isCast,
                    ConversionGroup conversionGroup,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics,
                    bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 16357, 24988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16717, 16755);

                f_10303_16717_16754(conversionGroup != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16771, 17454) || true) && (f_10303_16775_16794_M(!conversion.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 16771, 17454);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16828, 16951) || true) && (!hasErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 16828, 16951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16865, 16951);

                        f_10303_16865_16950(this, diagnostics, syntax, conversion, source, destination);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 16828, 16951);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 16971, 17439);

                    return new BoundConversion(
                                        syntax,
                                        source,
                                        conversion,
                    f_10303_17111_17133(),
                                        explicitCastInCode: isCast,
                                        conversionGroup,
                                        constantValueOpt: ConstantValue.NotAvailable,
                                        type: destination,
                                        hasErrors: true)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10303_17409_17436(source), 10303, 16978, 17438) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 16771, 17454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 19105, 19174);

                f_10303_19105_19173(conversion.BestUserDefinedConversionAnalysis is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 19313, 19766);

                BoundExpression
                convertedOperand = f_10303_19348_19765(this, syntax: source.Syntax, source: source, conversion: conversion.UserDefinedFromConversion, isCast: false, conversionGroupOpt: conversionGroup, wasCompilerGenerated: false, destination: conversion.BestUserDefinedConversionAnalysis.FromType, diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 19782, 19893);

                TypeSymbol
                conversionParameterType = f_10303_19819_19892(conversion.BestUserDefinedConversionAnalysis.Operator, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 19907, 19958);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 19974, 20898) || true) && (conversion.BestUserDefinedConversionAnalysis.Kind == UserDefinedConversionAnalysisKind.ApplicableInNormalForm && (DynAbs.Tracing.TraceSender.Expression_True(10303, 19978, 20243) && !f_10303_20109_20243(conversion.BestUserDefinedConversionAnalysis.FromType, conversionParameterType, TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 19974, 20898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 20362, 20883);

                    convertedOperand = f_10303_20381_20882(this, syntax: syntax, source: convertedOperand, conversion: f_10303_20516_20632(f_10303_20516_20527(), null, f_10303_20561_20582(convertedOperand), conversionParameterType, ref useSiteDiagnostics), isCast: false, conversionGroupOpt: conversionGroup, wasCompilerGenerated: true, destination: conversionParameterType, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 19974, 20898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 20914, 20952);

                BoundExpression
                userDefinedConversion
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 20968, 21067);

                TypeSymbol
                conversionReturnType = f_10303_21002_21066(conversion.BestUserDefinedConversionAnalysis.Operator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 21081, 21163);

                TypeSymbol
                conversionToType = conversion.BestUserDefinedConversionAnalysis.ToType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 21177, 21238);

                Conversion
                toConversion = conversion.UserDefinedToConversion
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 21254, 24262) || true) && (conversion.BestUserDefinedConversionAnalysis.Kind == UserDefinedConversionAnalysisKind.ApplicableInNormalForm && (DynAbs.Tracing.TraceSender.Expression_True(10303, 21258, 21483) && !f_10303_21389_21483(conversionToType, conversionReturnType, TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 21254, 24262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 21707, 22246);

                    userDefinedConversion = new BoundConversion(
                                        syntax,
                                        convertedOperand,
                                        conversion,
                                        @checked: false, // There are no checked user-defined conversions, but the conversions on either side might be checked.
                                        explicitCastInCode: isCast,
                                        conversionGroup,
                                        constantValueOpt: ConstantValue.NotAvailable,
                                        type: conversionReturnType)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10303, 21731, 22245) };

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 22266, 23561) || true) && (f_10303_22270_22303(conversionToType) && (DynAbs.Tracing.TraceSender.Expression_True(10303, 22270, 22429) && f_10303_22307_22429(f_10303_22325_22369(conversionToType), conversionReturnType, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 22266, 23561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 22660, 22773);

                        toConversion = f_10303_22675_22772(f_10303_22675_22686(), conversionReturnType, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 22795, 22829);

                        f_10303_22795_22828(toConversion.Exists);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 22266, 23561);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 22266, 23561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 22994, 23542);

                        userDefinedConversion = f_10303_23018_23541(this, syntax: syntax, source: userDefinedConversion, conversion: f_10303_23170_23278(f_10303_23170_23181(), null, conversionReturnType, conversionToType, ref useSiteDiagnostics), isCast: false, conversionGroupOpt: conversionGroup, wasCompilerGenerated: true, destination: conversionToType, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 22266, 23561);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 21254, 24262);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 21254, 24262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 23815, 24247);

                    userDefinedConversion = new BoundConversion(
                                        syntax,
                                        convertedOperand,
                                        conversion,
                                        @checked: false,
                                        explicitCastInCode: isCast,
                                        conversionGroup,
                                        constantValueOpt: ConstantValue.NotAvailable,
                                        type: conversionToType)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10303, 23839, 24246) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 21254, 24262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 24278, 24322);

                f_10303_24278_24321(
                            diagnostics, syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 24392, 24854);

                BoundExpression
                finalConversion = f_10303_24426_24853(this, syntax: syntax, source: userDefinedConversion, conversion: toConversion, isCast: false, conversionGroupOpt: conversionGroup, wasCompilerGenerated: true, destination: destination, diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 24870, 24938);

                f_10303_24870_24937(
                            finalConversion, f_10303_24909_24936(source));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 24954, 24977);

                return finalConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 16357, 24988);

                int
                f_10303_16717_16754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 16717, 16754);
                    return 0;
                }


                bool
                f_10303_16775_16794_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 16775, 16794);
                    return return_v;
                }


                int
                f_10303_16865_16950(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateImplicitConversionError(diagnostics, syntax, conversion, operand, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 16865, 16950);
                    return 0;
                }


                bool
                f_10303_17111_17133()
                {
                    var return_v = CheckOverflowAtRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 17111, 17133);
                    return return_v;
                }


                bool
                f_10303_17409_17436(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 17409, 17436);
                    return return_v;
                }


                int
                f_10303_19105_19173(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 19105, 19173);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_19348_19765(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroupOpt, bool
                wasCompilerGenerated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax: syntax, source: source, conversion: conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, wasCompilerGenerated: wasCompilerGenerated, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 19348, 19765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_19819_19892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 19819, 19892);
                    return return_v;
                }


                bool
                f_10303_20109_20243(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 20109, 20243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_20516_20527()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 20516, 20527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_20561_20582(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 20561, 20582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_20516_20632(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 20516, 20632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_20381_20882(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroupOpt, bool
                wasCompilerGenerated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax: syntax, source: source, conversion: conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, wasCompilerGenerated: wasCompilerGenerated, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 20381, 20882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_21002_21066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 21002, 21066);
                    return return_v;
                }


                bool
                f_10303_21389_21483(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 21389, 21483);
                    return return_v;
                }


                bool
                f_10303_22270_22303(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 22270, 22303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_22325_22369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 22325, 22369);
                    return return_v;
                }


                bool
                f_10303_22307_22429(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 22307, 22429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_22675_22686()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 22675, 22686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_22675_22772(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 22675, 22772);
                    return return_v;
                }


                int
                f_10303_22795_22828(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 22795, 22828);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_23170_23181()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 23170, 23181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_23170_23278(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 23170, 23278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_23018_23541(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroupOpt, bool
                wasCompilerGenerated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax: syntax, source: source, conversion: conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, wasCompilerGenerated: wasCompilerGenerated, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 23018, 23541);
                    return return_v;
                }


                bool
                f_10303_24278_24321(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 24278, 24321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_24426_24853(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup
                conversionGroupOpt, bool
                wasCompilerGenerated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax: syntax, source: source, conversion: conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, wasCompilerGenerated: wasCompilerGenerated, destination: destination, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 24426, 24853);
                    return return_v;
                }


                bool
                f_10303_24909_24936(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 24909, 24936);
                    return return_v;
                }


                int
                f_10303_24870_24937(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param, bool
                newCompilerGenerated)
                {
                    this_param.ResetCompilerGenerated(newCompilerGenerated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 24870, 24937);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 16357, 24988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 16357, 24988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression CreateAnonymousFunctionConversion(SyntaxNode syntax, BoundExpression source, Conversion conversion, bool isCast, ConversionGroup? conversionGroup, TypeSymbol destination, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 25000, 26250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 25648, 25690);

                var
                unboundLambda = (UnboundLambda)source
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 25704, 25771);

                var
                boundLambda = f_10303_25722_25770(unboundLambda, destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 25785, 25831);

                f_10303_25785_25830(diagnostics, f_10303_25806_25829(boundLambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 25847, 26239);

                return new BoundConversion(
                                syntax,
                                boundLambda,
                                conversion,
                                @checked: false,
                                explicitCastInCode: isCast,
                                conversionGroup,
                                constantValueOpt: ConstantValue.NotAvailable,
                                type: destination)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10303_26209_26236(source), 10303, 25854, 26238) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 25000, 26250);

                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10303_25722_25770(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType)
                {
                    var return_v = this_param.Bind((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 25722, 25770);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10303_25806_25829(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 25806, 25829);
                    return return_v;
                }


                int
                f_10303_25785_25830(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 25785, 25830);
                    return 0;
                }


                bool
                f_10303_26209_26236(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 26209, 26236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 25000, 26250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 25000, 26250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression CreateMethodGroupConversion(SyntaxNode syntax, BoundExpression source, Conversion conversion, bool isCast, ConversionGroup? conversionGroup, TypeSymbol destination, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 26262, 27443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26502, 26788);

                var (originalGroup, isAddressOf) = source switch
                {
                    BoundMethodGroup m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26583, 26615) && DynAbs.Tracing.TraceSender.Expression_True(10303, 26583, 26615))
    => (m, false),
                    BoundUnconvertedAddressOfOperator { Operand: { } m } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26634, 26699) && DynAbs.Tracing.TraceSender.Expression_True(10303, 26634, 26699))
    => (m, true),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26718, 26771) && DynAbs.Tracing.TraceSender.Expression_True(10303, 26718, 26771))
    => throw f_10303_26729_26771(source),
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26802, 26897);

                BoundMethodGroup
                group = f_10303_26827_26896(this, originalGroup, conversion, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26911, 26934);

                bool
                hasErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 26950, 27158) || true) && (f_10303_26954_27092(this, syntax, conversion, f_10303_27005_27022(group), conversion.IsExtensionMethod, isAddressOf, destination, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 26950, 27158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27126, 27143);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 26950, 27158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27174, 27432);

                return new BoundConversion(syntax, group, conversion, @checked: false, explicitCastInCode: isCast, conversionGroup, constantValueOpt: ConstantValue.NotAvailable, type: destination, hasErrors: hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10303_27402_27429(source), 10303, 27181, 27431) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 26262, 27443);

                System.Exception
                f_10303_26729_26771(Microsoft.CodeAnalysis.CSharp.BoundExpression
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 26729, 26771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10303_26827_26896(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                group, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FixMethodGroupWithTypeOrValue(group, conversion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 26827, 26896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10303_27005_27022(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 27005, 27022);
                    return return_v;
                }


                bool
                f_10303_26954_27092(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, bool
                isExtensionMethod, bool
                isAddressOf, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateOrFuncPtrType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MethodGroupConversionHasErrors(syntax, conversion, receiverOpt, isExtensionMethod, isAddressOf, delegateOrFuncPtrType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 26954, 27092);
                    return return_v;
                }


                bool
                f_10303_27402_27429(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 27402, 27429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 26262, 27443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 26262, 27443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression CreateStackAllocConversion(SyntaxNode syntax, BoundExpression source, Conversion conversion, bool isCast, ConversionGroup? conversionGroup, TypeSymbol destination, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 27455, 29092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27694, 27732);

                f_10303_27694_27731(conversion.IsStackAlloc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27748, 27807);

                var
                boundStackAlloc = (BoundStackAllocArrayCreation)source
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27821, 27867);

                var
                elementType = f_10303_27839_27866(boundStackAlloc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27881, 27907);

                TypeSymbol
                stackAllocType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 27923, 28660);

                switch (conversion.Kind)
                {

                    case ConversionKind.StackAllocToPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 27923, 28660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28046, 28101);

                        f_10303_28046_28100(this, f_10303_28071_28086(syntax), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28123, 28203);

                        stackAllocType = f_10303_28140_28202(TypeWithAnnotations.Create(elementType));
                        DynAbs.Tracing.TraceSender.TraceBreak(10303, 28225, 28231);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 27923, 28660);

                    case ConversionKind.StackAllocToSpanType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 27923, 28660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28312, 28391);

                        f_10303_28312_28390(syntax, MessageID.IDS_FeatureRefStructs, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28413, 28511);

                        stackAllocType = f_10303_28430_28510(f_10303_28430_28487(f_10303_28430_28441(), WellKnownType.System_Span_T), elementType);
                        DynAbs.Tracing.TraceSender.TraceBreak(10303, 28533, 28539);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 27923, 28660);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 27923, 28660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28587, 28645);

                        throw f_10303_28593_28644(conversion.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 27923, 28660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28676, 28854);

                var
                convertedNode = f_10303_28696_28853(syntax, elementType, f_10303_28756_28777(boundStackAlloc), f_10303_28779_28809(boundStackAlloc), stackAllocType, f_10303_28827_28852(boundStackAlloc))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28870, 28939);

                var
                underlyingConversion = conversion.UnderlyingConversions.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 28953, 29081);

                return f_10303_28960_29080(this, syntax, convertedNode, underlyingConversion, isCast: isCast, conversionGroup, destination, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 27455, 29092);

                int
                f_10303_27694_27731(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 27694, 27731);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_27839_27866(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 27839, 27866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_28071_28086(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 28071, 28086);
                    return return_v;
                }


                bool
                f_10303_28046_28100(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportUnsafeIfNotAllowed(location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28046, 28100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10303_28140_28202(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28140, 28202);
                    return return_v;
                }


                bool
                f_10303_28312_28390(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability(syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28312, 28390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10303_28430_28441()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 28430, 28441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_28430_28487(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28430, 28487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_28430_28510(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28430, 28510);
                    return return_v;
                }


                System.Exception
                f_10303_28593_28644(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28593, 28644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_28756_28777(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 28756, 28777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10303_28779_28809(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 28779, 28809);
                    return return_v;
                }


                bool
                f_10303_28827_28852(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 28827, 28852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                f_10303_28696_28853(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                count, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                initializerOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression(syntax, elementType, count, initializerOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28696, 28853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_28960_29080(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)source, conversion, isCast: isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 28960, 29080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 27455, 29092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 27455, 29092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression CreateTupleLiteralConversion(SyntaxNode syntax, BoundTupleLiteral sourceTuple, Conversion conversion, bool isCast, ConversionGroup? conversionGroup, TypeSymbol destination, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 29104, 34365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29583, 29651);

                f_10303_29583_29650(conversion.IsNullable == f_10303_29621_29649(destination));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29667, 29712);

                var
                destinationWithoutNullable = destination
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29726, 29769);

                var
                conversionWithoutNullable = conversion
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29785, 30010) || true) && (conversion.IsNullable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 29785, 30010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29844, 29913);

                    destinationWithoutNullable = f_10303_29873_29912(destination);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 29931, 29995);

                    conversionWithoutNullable = conversion.UnderlyingConversions[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 29785, 30010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30026, 30091);

                f_10303_30026_30090(conversionWithoutNullable.IsTupleLiteralConversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30107, 30180);

                NamedTypeSymbol
                targetType = (NamedTypeSymbol)destinationWithoutNullable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30194, 31754) || true) && (f_10303_30198_30220(targetType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 30194, 31754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30254, 30340);

                    f_10303_30254_30339(targetType, sourceTuple, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30771, 31739) || true) && (f_10303_30775_30791(sourceTuple) is NamedTypeSymbol { IsTupleType: true } sourceType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 30771, 31739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 30885, 30939);

                        targetType = f_10303_30898_30938(targetType, sourceType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 30771, 31739);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 30771, 31739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31021, 31081);

                        var
                        tupleSyntax = (TupleExpressionSyntax)sourceTuple.Syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31103, 31163);

                        var
                        locationBuilder = f_10303_31125_31162()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31187, 31441);
                            foreach (var argument in f_10303_31212_31233_I(f_10303_31212_31233(tupleSyntax)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 31187, 31441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31318, 31418);

                                f_10303_31318_31417(                        // LAFHIS
                                                        locationBuilder, (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 31338, 31364) || ((f_10303_31338_31356(argument) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 31367, 31399)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 31402, 31416))) ? f_10303_31367_31399(f_10303_31367_31390(f_10303_31367_31385(argument))) : (Location)null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 31187, 31441);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10303, 1, 255);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10303, 1, 255);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31465, 31720);

                        targetType = f_10303_31478_31719(targetType, sourceTuple.ArgumentNamesOpt!, f_10303_31562_31598(locationBuilder), errorPositions: default, f_10303_31675_31718(f_10303_31697_31717(tupleSyntax)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 30771, 31739);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 30194, 31754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31770, 31808);

                var
                arguments = f_10303_31786_31807(sourceTuple)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31822, 31907);

                var
                convertedArguments = f_10303_31847_31906(arguments.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 31923, 31992);

                var
                targetElementTypes = f_10303_31948_31991(targetType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32006, 32118);

                f_10303_32006_32117(targetElementTypes.Length == arguments.Length, "converting a tuple literal to incompatible type?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32132, 32208);

                var
                underlyingConversions = conversionWithoutNullable.UnderlyingConversions
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32233, 32238);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32224, 32749) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32262, 32265)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 32224, 32749))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 32224, 32749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32299, 32327);

                        var
                        argument = arguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32345, 32382);

                        var
                        destType = targetElementTypes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32400, 32449);

                        var
                        elementConversion = underlyingConversions[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32467, 32561);

                        var
                        elementConversionGroup = (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 32496, 32502) || ((isCast && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 32505, 32553)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 32556, 32560))) ? f_10303_32505_32553(elementConversion, destType) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32579, 32734);

                        f_10303_32579_32733(convertedArguments, f_10303_32602_32732(this, argument.Syntax, argument, elementConversion, isCast: isCast, elementConversionGroup, destType.Type, diagnostics));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10303, 1, 526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10303, 1, 526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 32765, 33151);

                BoundExpression
                result = f_10303_32790_33150(f_10303_32790_33108(sourceTuple.Syntax, sourceTuple, wasTargetTyped: true, f_10303_32945_32984(convertedArguments), f_10303_33003_33031(sourceTuple), f_10303_33050_33078(sourceTuple), targetType), f_10303_33125_33149(sourceTuple))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 33167, 33731) || true) && (!f_10303_33172_33257(f_10303_33190_33206(sourceTuple), destination, TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 33167, 33731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 33351, 33716);

                    result = f_10303_33360_33715(sourceTuple.Syntax, result, conversion, @checked: false, explicitCastInCode: isCast, conversionGroup, constantValueOpt: ConstantValue.NotAvailable, type: destination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 33167, 33731);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 33903, 34324) || true) && (isCast)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 33903, 34324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 33947, 34309);

                    result = f_10303_33956_34308(syntax, result, Conversion.Identity, @checked: false, explicitCastInCode: isCast, conversionGroup, constantValueOpt: ConstantValue.NotAvailable, type: destination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 33903, 34324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34340, 34354);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 29104, 34365);

                bool
                f_10303_29621_29649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 29621, 29649);
                    return return_v;
                }


                int
                f_10303_29583_29650(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 29583, 29650);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_29873_29912(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 29873, 29912);
                    return return_v;
                }


                int
                f_10303_30026_30090(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 30026, 30090);
                    return 0;
                }


                bool
                f_10303_30198_30220(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 30198, 30220);
                    return return_v;
                }


                int
                f_10303_30254_30339(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                literal, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    NamedTypeSymbol.ReportTupleNamesMismatchesIfAny((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, literal, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 30254, 30339);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_30775_30791(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 30775, 30791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_30898_30938(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                original)
                {
                    var return_v = this_param.WithTupleDataFrom(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 30898, 30938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                f_10303_31125_31162()
                {
                    var return_v = ArrayBuilder<Location?>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31125, 31162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10303_31212_31233(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31212, 31233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10303_31338_31356(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31338, 31356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10303_31367_31385(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31367, 31385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10303_31367_31390(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31367, 31390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_31367_31399(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31367, 31399);
                    return return_v;
                }


                int
                f_10303_31318_31417(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param, Microsoft.CodeAnalysis.Location?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31318, 31417);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10303_31212_31233_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31212, 31233);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10303_31562_31598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31562, 31598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_31697_31717(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31697, 31717);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10303_31675_31718(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31675, 31718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_31478_31719(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<string?>
                newElementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                newElementLocations, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = this_param.WithElementNames(newElementNames, newElementLocations, errorPositions: errorPositions, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31478, 31719);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10303_31786_31807(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31786, 31807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10303_31847_31906(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 31847, 31906);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10303_31948_31991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 31948, 31991);
                    return return_v;
                }


                int
                f_10303_32006_32117(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32006, 32117);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup
                f_10303_32505_32553(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                explicitType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ConversionGroup(conversion, explicitType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32505, 32553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_32602_32732(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(syntax, source, conversion, isCast: isCast, conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32602, 32732);
                    return return_v;
                }


                int
                f_10303_32579_32733(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32579, 32733);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10303_32945_32984(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32945, 32984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10303_33003_33031(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 33003, 33031);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10303_33050_33078(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.InferredNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 33050, 33078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10303_32790_33108(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax, sourceTuple, wasTargetTyped: wasTargetTyped, arguments, argumentNamesOpt, inferredNamesOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32790, 33108);
                    return return_v;
                }


                bool
                f_10303_33125_33149(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 33125, 33149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_32790_33150(Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                this_param, bool
                suppress)
                {
                    var return_v = this_param.WithSuppression(suppress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 32790, 33150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_33190_33206(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 33190, 33206);
                    return return_v;
                }


                bool
                f_10303_33172_33257(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 33172, 33257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10303_33360_33715(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 33360, 33715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10303_33956_34308(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 33956, 34308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 29104, 34365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 29104, 34365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMethodGroupWithTypeOrValueReceiver(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 34377, 34677);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34474, 34574) || true) && (f_10303_34478_34487(node) != BoundKind.MethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 34474, 34574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34546, 34559);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 34474, 34574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34590, 34666);

                return f_10303_34597_34665(f_10303_34628_34664(((BoundMethodGroup)node)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 34377, 34677);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_34478_34487(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 34478, 34487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10303_34628_34664(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 34628, 34664);
                    return return_v;
                }


                bool
                f_10303_34597_34665(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = Binder.IsTypeOrValueExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 34597, 34665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 34377, 34677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 34377, 34677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundMethodGroup FixMethodGroupWithTypeOrValue(BoundMethodGroup group, Conversion conversion, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 34689, 35583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34842, 34952) || true) && (!f_10303_34847_34890(group))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 34842, 34952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34924, 34937);

                    return group;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 34842, 34952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 34968, 35017);

                BoundExpression?
                receiverOpt = f_10303_34999_35016(group)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 35031, 35071);

                f_10303_35031_35070(receiverOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 35087, 35250);

                receiverOpt = f_10303_35101_35249(this, receiverOpt, useType: f_10303_35150_35193_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(conversion.Method, 10303, 35150, 35193)?.RequiresInstanceReceiver) == false && (DynAbs.Tracing.TraceSender.Expression_True(10303, 35150, 35235) && f_10303_35206_35235_M(!conversion.IsExtensionMethod)), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 35264, 35572);

                return f_10303_35271_35571(group, f_10303_35302_35324(group), f_10303_35343_35353(group), f_10303_35372_35385(group), f_10303_35404_35425(group), f_10303_35444_35461(group), f_10303_35480_35491(group), receiverOpt, f_10303_35554_35570(group));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 34689, 35583);

                bool
                f_10303_34847_34890(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node)
                {
                    var return_v = IsMethodGroupWithTypeOrValueReceiver((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 34847, 34890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10303_34999_35016(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 34999, 35016);
                    return return_v;
                }


                int
                f_10303_35031_35070(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 35031, 35070);
                    return 0;
                }


                bool?
                f_10303_35150_35193_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35150, 35193);
                    return return_v;
                }


                bool
                f_10303_35206_35235_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35206, 35235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_35101_35249(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, bool
                useType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReplaceTypeOrValueReceiver(receiver, useType: useType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 35101, 35249);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10303_35302_35324(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35302, 35324);
                    return return_v;
                }


                string
                f_10303_35343_35353(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35343, 35353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10303_35372_35385(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35372, 35385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10303_35404_35425(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35404, 35425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10303_35444_35461(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35444, 35461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                f_10303_35480_35491(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35480, 35491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10303_35554_35570(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 35554, 35570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10303_35271_35571(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.Symbol?
                lookupSymbolOpt, Microsoft.CodeAnalysis.DiagnosticInfo?
                lookupError, Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                flags, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = this_param.Update(typeArgumentsOpt, name, methods, lookupSymbolOpt, lookupError, flags, receiverOpt, resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 35271, 35571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 34689, 35583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 34689, 35583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MemberGroupFinalValidation(BoundExpression? receiverOpt, MethodSymbol methodSymbol, SyntaxNode node, DiagnosticBag diagnostics, bool invokedAsExtensionMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 36271, 39352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 36467, 36663) || true) && (!f_10303_36472_36533(this, node, receiverOpt, methodSymbol, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 36467, 36663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 36567, 36648);

                    f_10303_36567_36647(this, node, receiverOpt, methodSymbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 36467, 36663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 36679, 36861) || true) && (f_10303_36683_36800(this, receiverOpt, methodSymbol, node, diagnostics, invokedAsExtensionMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 36679, 36861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 36834, 36846);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 36679, 36861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 39248, 39341);

                return !f_10303_39256_39340(methodSymbol, f_10303_39286_39302(this), node, f_10303_39310_39326(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 36271, 39352);

                bool
                f_10303_36472_36533(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.IsBadBaseAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)member, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 36472, 36533);
                    return return_v;
                }


                int
                f_10303_36567_36647(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckRuntimeSupportForSymbolAccess(node, receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 36567, 36647);
                    return 0;
                }


                bool
                f_10303_36683_36800(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invokedAsExtensionMethod)
                {
                    var return_v = this_param.MemberGroupFinalValidationAccessibilityChecks(receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, node, diagnostics, invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 36683, 36800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_39286_39302(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 39286, 39302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10303_39310_39326(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 39310, 39326);
                    return return_v;
                }


                bool
                f_10303_39256_39340(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = method.CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, syntaxNode, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 39256, 39340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 36271, 39352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 36271, 39352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MemberGroupFinalValidationAccessibilityChecks(BoundExpression? receiverOpt, Symbol memberSymbol, SyntaxNode node, DiagnosticBag diagnostics, bool invokedAsExtensionMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 40979, 46662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 41260, 41368);

                f_10303_41260_41367(f_10303_41273_41290(memberSymbol) != SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10303, 41273, 41366) || f_10303_41332_41366(memberSymbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 41604, 45375) || true) && (f_10303_41608_41644(receiverOpt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 41604, 45375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 41926, 41966);

                    f_10303_41926_41965(!invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 41604, 45375);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 41604, 45375);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42000, 45375) || true) && (!f_10303_42005_42044(memberSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42000, 45375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42078, 42143);

                        f_10303_42078_42142(!invokedAsExtensionMethod || (DynAbs.Tracing.TraceSender.Expression_False(10303, 42091, 42141) || (receiverOpt != null)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42163, 43962) || true) && (invokedAsExtensionMethod)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42163, 43962);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42233, 43049) || true) && (f_10303_42237_42277(receiverOpt))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42233, 43049);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42327, 42988) || true) && (f_10303_42331_42347(receiverOpt) == BoundKind.QueryClause)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42327, 42988);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42557, 42656);

                                    f_10303_42557_42655(                            // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.
                                                                diagnostics, ErrorCode.ERR_QueryNoProvider, f_10303_42604_42617(node), f_10303_42619_42635(receiverOpt), f_10303_42637_42654(memberSymbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42327, 42988);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42327, 42988);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 42886, 42961);

                                    f_10303_42886_42960(                            // An object reference is required for the non-static field, method, or property '{0}'
                                                                diagnostics, ErrorCode.ERR_ObjectRequired, f_10303_42932_42945(node), memberSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42327, 42988);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43014, 43026);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42233, 43049);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42163, 43962);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42163, 43962);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43091, 43962) || true) && (!f_10303_43096_43128(receiverOpt) && (DynAbs.Tracing.TraceSender.Expression_True(10303, 43095, 43183) && f_10303_43132_43183(receiverOpt)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43091, 43962);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43225, 43909) || true) && (f_10303_43229_43292(this.Flags, BinderFlags.CollectionInitializerAddMethod))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43225, 43909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43342, 43434);

                                    f_10303_43342_43433(diagnostics, ErrorCode.ERR_InitializerAddHasWrongSignature, f_10303_43405_43418(node), memberSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43225, 43909);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43225, 43909);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43484, 43909) || true) && (f_10303_43488_43499(node) == SyntaxKind.AwaitExpression && (DynAbs.Tracing.TraceSender.Expression_True(10303, 43488, 43585) && f_10303_43533_43550(memberSymbol) == WellKnownMemberNames.GetAwaiter))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43484, 43909);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43635, 43711);

                                        f_10303_43635_43710(diagnostics, ErrorCode.ERR_BadAwaitArg, f_10303_43678_43691(node), f_10303_43693_43709(receiverOpt));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43484, 43909);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43484, 43909);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43809, 43886);

                                        f_10303_43809_43885(diagnostics, ErrorCode.ERR_ObjectProhibited, f_10303_43857_43870(node), memberSymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43484, 43909);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43225, 43909);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43931, 43943);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43091, 43962);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42163, 43962);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42000, 45375);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 42000, 45375);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 43996, 45375) || true) && (f_10303_44000_44040(receiverOpt))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43996, 45375);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44074, 44149);

                            f_10303_44074_44148(diagnostics, ErrorCode.ERR_ObjectRequired, f_10303_44120_44133(node), memberSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44167, 44179);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43996, 45375);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 43996, 45375);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44213, 45375) || true) && (f_10303_44217_44249(receiverOpt))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 44213, 45375);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44283, 44919) || true) && (f_10303_44287_44305() && (DynAbs.Tracing.TraceSender.Expression_True(10303, 44287, 44339) && f_10303_44309_44339_M(!ContainingType!.IsScriptClass)) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 44287, 44367) || f_10303_44343_44367()) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 44287, 44390) || f_10303_44371_44390()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 44283, 44919);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44432, 44460);

                                    SyntaxNode
                                    errorNode = node
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44482, 44659) || true) && (f_10303_44486_44497(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10303, 44486, 44562) && f_10303_44509_44527(f_10303_44509_44520(node)) == SyntaxKind.InvocationExpression))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 44482, 44659);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44612, 44636);

                                        errorNode = f_10303_44624_44635(node);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 44482, 44659);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44683, 44788);

                                    ErrorCode
                                    code = (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 44700, 44718) || ((f_10303_44700_44718() && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 44721, 44756)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 44759, 44787))) ? ErrorCode.ERR_FieldInitRefNonstatic : ErrorCode.ERR_ObjectRequired
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44810, 44866);

                                    f_10303_44810_44865(diagnostics, code, f_10303_44832_44850(errorNode), memberSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 44888, 44900);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 44283, 44919);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45142, 45360) || true) && (receiverOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10303, 45146, 45196) || f_10303_45169_45196(f_10303_45169_45187(this))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 45142, 45360);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45238, 45307);

                                    f_10303_45238_45306(diagnostics, ErrorCode.ERR_ObjectRequired, node, memberSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45329, 45341);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 45142, 45360);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 44213, 45375);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 43996, 45375);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 42000, 45375);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 41604, 45375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45391, 45432);

                var
                containingType = f_10303_45412_45431(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45446, 46622) || true) && (containingType is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 45446, 46622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45508, 45559);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45577, 45713);

                    bool
                    isAccessible = f_10303_45597_45712(this, f_10303_45632_45666(memberSymbol).Type, containingType, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45731, 45773);

                    f_10303_45731_45772(diagnostics, node, useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 45793, 46607) || true) && (!isAccessible)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 45793, 46607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46490, 46554);

                        f_10303_46490_46553(diagnostics, ErrorCode.ERR_BadAccess, node, memberSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46576, 46588);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 45793, 46607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 45446, 46622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46638, 46651);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 40979, 46662);

                Microsoft.CodeAnalysis.SymbolKind
                f_10303_41273_41290(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 41273, 41290);
                    return return_v;
                }


                bool
                f_10303_41332_41366(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.CanBeReferencedByName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 41332, 41366);
                    return return_v;
                }


                int
                f_10303_41260_41367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 41260, 41367);
                    return 0;
                }


                bool
                f_10303_41608_41644(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = IsTypeOrValueExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 41608, 41644);
                    return return_v;
                }


                int
                f_10303_41926_41965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 41926, 41965);
                    return 0;
                }


                bool
                f_10303_42005_42044(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 42005, 42044);
                    return return_v;
                }


                int
                f_10303_42078_42142(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 42078, 42142);
                    return 0;
                }


                bool
                f_10303_42237_42277(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = IsMemberAccessedThroughType(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 42237, 42277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_42331_42347(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 42331, 42347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_42604_42617(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 42604, 42617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_42619_42635(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 42619, 42635);
                    return return_v;
                }


                string
                f_10303_42637_42654(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 42637, 42654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_42557_42655(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 42557, 42655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_42932_42945(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 42932, 42945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_42886_42960(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 42886, 42960);
                    return return_v;
                }


                bool
                f_10303_43096_43128(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = WasImplicitReceiver(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43096, 43128);
                    return return_v;
                }


                bool
                f_10303_43132_43183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt)
                {
                    var return_v = IsMemberAccessedThroughVariableOrValue(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43132, 43183);
                    return return_v;
                }


                bool
                f_10303_43229_43292(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43229, 43292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_43405_43418(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 43405, 43418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_43342_43433(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43342, 43433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10303_43488_43499(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43488, 43499);
                    return return_v;
                }


                string
                f_10303_43533_43550(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 43533, 43550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_43678_43691(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 43678, 43691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_43693_43709(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 43693, 43709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_43635_43710(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43635, 43710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_43857_43870(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 43857, 43870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_43809_43885(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 43809, 43885);
                    return return_v;
                }


                bool
                f_10303_44000_44040(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = IsMemberAccessedThroughType(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 44000, 44040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_44120_44133(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44120, 44133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_44074_44148(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 44074, 44148);
                    return return_v;
                }


                bool
                f_10303_44217_44249(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = WasImplicitReceiver(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 44217, 44249);
                    return return_v;
                }


                bool
                f_10303_44287_44305()
                {
                    var return_v = InFieldInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44287, 44305);
                    return return_v;
                }


                bool
                f_10303_44309_44339_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44309, 44339);
                    return return_v;
                }


                bool
                f_10303_44343_44367()
                {
                    var return_v = InConstructorInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44343, 44367);
                    return return_v;
                }


                bool
                f_10303_44371_44390()
                {
                    var return_v = InAttributeArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44371, 44390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10303_44486_44497(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44486, 44497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10303_44509_44520(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44509, 44520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10303_44509_44527(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 44509, 44527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10303_44624_44635(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44624, 44635);
                    return return_v;
                }


                bool
                f_10303_44700_44718()
                {
                    var return_v = InFieldInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44700, 44718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_44832_44850(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 44832, 44850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_44810_44865(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 44810, 44865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10303_45169_45187(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 45169, 45187);
                    return return_v;
                }


                bool
                f_10303_45169_45196(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 45169, 45196);
                    return return_v;
                }


                int
                f_10303_45238_45306(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 45238, 45306);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10303_45412_45431(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 45412, 45431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10303_45632_45666(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 45632, 45666);
                    return return_v;
                }


                bool
                f_10303_45597_45712(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsSymbolAccessibleConditional((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 45597, 45712);
                    return return_v;
                }


                bool
                f_10303_45731_45772(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 45731, 45772);
                    return return_v;
                }


                int
                f_10303_46490_46553(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 46490, 46553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 40979, 46662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 40979, 46662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMemberAccessedThroughVariableOrValue(BoundExpression? receiverOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 46674, 46948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46787, 46872) || true) && (receiverOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 46787, 46872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46844, 46857);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 46787, 46872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 46888, 46937);

                return !f_10303_46896_46936(receiverOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 46674, 46948);

                bool
                f_10303_46896_46936(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt)
                {
                    var return_v = IsMemberAccessedThroughType(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 46896, 46936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 46674, 46948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 46674, 46948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsMemberAccessedThroughType([NotNullWhen(true)] BoundExpression? receiverOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 46960, 47412);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47083, 47168) || true) && (receiverOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47083, 47168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47140, 47153);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47083, 47168);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47184, 47333) || true) && (f_10303_47191_47207(receiverOpt) == BoundKind.QueryClause)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47184, 47333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47266, 47318);

                        receiverOpt = f_10303_47280_47317(((BoundQueryClause)receiverOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47184, 47333);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10303, 47184, 47333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10303, 47184, 47333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47349, 47401);

                return f_10303_47356_47372(receiverOpt) == BoundKind.TypeExpression;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 46960, 47412);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_47191_47207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 47191, 47207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10303_47280_47317(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 47280, 47317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_47356_47372(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 47356, 47372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 46960, 47412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 46960, 47412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool WasImplicitReceiver([NotNullWhen(false)] BoundExpression? receiverOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 47532, 48093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47648, 47685) || true) && (receiverOpt == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47648, 47685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47673, 47685);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47648, 47685);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47699, 47751) || true) && (f_10303_47703_47736_M(!receiverOpt.WasCompilerGenerated))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47699, 47751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47738, 47751);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47699, 47751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47765, 48082);

                switch (f_10303_47773_47789(receiverOpt))
                {

                    case BoundKind.ThisReference:
                    case BoundKind.HostObjectMemberReference:
                    case BoundKind.PreviousSubmissionReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47765, 48082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 47994, 48006);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47765, 48082);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 47765, 48082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 48054, 48067);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 47765, 48082);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 47532, 48093);

                bool
                f_10303_47703_47736_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 47703, 47736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10303_47773_47789(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 47773, 47789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 47532, 48093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 47532, 48093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool MethodIsCompatibleWithDelegateOrFunctionPointer(BoundExpression? receiverOpt, bool isExtensionMethod, MethodSymbol method, TypeSymbol delegateType, Location errorLocation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 48221, 56511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 48458, 48776);

                f_10303_48458_48775(delegateType is NamedTypeSymbol { TypeKind: TypeKind.Delegate, DelegateInvokeMethod: { HasUseSiteError: false } }
                || (DynAbs.Tracing.TraceSender.Expression_False(10303, 48471, 48665) || f_10303_48616_48637(delegateType) == TypeKind.FunctionPointer), "This method should only be called for valid delegate or function pointer types.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 48792, 49138);

                MethodSymbol
                delegateOrFuncPtrMethod = delegateType switch
                {
                    NamedTypeSymbol { DelegateInvokeMethod: { } invokeMethod } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 48883, 48957) && DynAbs.Tracing.TraceSender.Expression_True(10303, 48883, 48957))
=> invokeMethod,
                    FunctionPointerTypeSymbol { Signature: { } signature } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 48976, 49043) && DynAbs.Tracing.TraceSender.Expression_True(10303, 48976, 49043))
=> signature,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49062, 49121) && DynAbs.Tracing.TraceSender.Expression_True(10303, 49062, 49121))
=> throw f_10303_49073_49121(delegateType),
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49154, 49212);

                f_10303_49154_49211(!isExtensionMethod || (DynAbs.Tracing.TraceSender.Expression_False(10303, 49167, 49210) || (receiverOpt != null)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49274, 49343);

                var
                delegateOrFuncPtrParameters = f_10303_49308_49342(delegateOrFuncPtrMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49357, 49398);

                var
                methodParameters = f_10303_49380_49397(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49412, 49463);

                int
                numParams = delegateOrFuncPtrParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49479, 49907) || true) && (methodParameters.Length != numParams + ((DynAbs.Tracing.TraceSender.Conditional_F1(10303, 49523, 49540) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 49543, 49544)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 49547, 49548))) ? 1 : 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 49479, 49907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49656, 49736);

                    f_10303_49656_49735(methodParameters.Length > numParams + ((DynAbs.Tracing.TraceSender.Conditional_F1(10303, 49708, 49725) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 49728, 49729)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 49732, 49733))) ? 1 : 0));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49754, 49861);

                    f_10303_49754_49860(diagnostics, f_10303_49773_49822(f_10303_49800_49821(delegateType)), errorLocation, method, delegateType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49879, 49892);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 49479, 49907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 49923, 49974);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50173, 50384);

                f_10303_50173_50383(!isExtensionMethod || (DynAbs.Tracing.TraceSender.Expression_False(10303, 50186, 50382) || (f_10303_50226_50336(f_10303_50226_50237(), f_10303_50268_50292(methodParameters[0]), f_10303_50294_50311(receiverOpt!), ref useSiteDiagnostics).Exists && (DynAbs.Tracing.TraceSender.Expression_True(10303, 50226, 50381) && f_10303_50347_50381(useSiteDiagnostics)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50400, 50426);

                useSiteDiagnostics = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50451, 50456);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50442, 52425) || true) && (i < numParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50473, 50476)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 50442, 52425))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 50442, 52425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50510, 50565);

                        var
                        delegateParameter = delegateOrFuncPtrParameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 50583, 50653);

                        var
                        methodParameter = methodParameters[(DynAbs.Tracing.TraceSender.Conditional_F1(10303, 50622, 50639) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 50642, 50647)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 50650, 50651))) ? i + 1 : i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 51889, 52410) || true) && (!f_10303_51894_52065(f_10303_51908_51929(delegateType), f_10303_51931_51942(), f_10303_51944_51966(delegateParameter), f_10303_51968_51988(methodParameter), f_10303_51990_52015(delegateParameter), f_10303_52017_52040(methodParameter), ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 51889, 52410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52176, 52283);

                            f_10303_52176_52282(diagnostics, f_10303_52195_52244(f_10303_52222_52243(delegateType)), errorLocation, method, delegateType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52305, 52356);

                            f_10303_52305_52355(diagnostics, errorLocation, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52378, 52391);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 51889, 52410);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10303, 1, 1984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10303, 1, 1984);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52441, 52747) || true) && (f_10303_52445_52476(delegateOrFuncPtrMethod) != f_10303_52480_52494(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 52441, 52747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52528, 52632);

                    f_10303_52528_52631(diagnostics, f_10303_52547_52593(f_10303_52571_52592(delegateType)), errorLocation, method, delegateType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52650, 52701);

                    f_10303_52650_52700(diagnostics, errorLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52719, 52732);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 52441, 52747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52763, 52804);

                var
                methodReturnType = f_10303_52786_52803(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52818, 52878);

                var
                delegateReturnType = f_10303_52843_52877(delegateOrFuncPtrMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52892, 53263);

                bool
                returnsMatch = delegateOrFuncPtrMethod switch
                {
                    { RefKind: RefKind.None, ReturnsVoid: true } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 52975, 53041) && DynAbs.Tracing.TraceSender.Expression_True(10303, 52975, 53041))
=> f_10303_53023_53041(method),
                    { RefKind: var destinationRefKind } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53060, 53246) && DynAbs.Tracing.TraceSender.Expression_True(10303, 53060, 53246))
=> f_10303_53099_53246(f_10303_53113_53134(delegateType), f_10303_53136_53147(), methodReturnType, delegateReturnType, f_10303_53187_53201(method), destinationRefKind, ref useSiteDiagnostics),
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53279, 53532) || true) && (!returnsMatch)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 53279, 53532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53330, 53417);

                    f_10303_53330_53416(diagnostics, ErrorCode.ERR_BadRetType, errorLocation, method, f_10303_53398_53415(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53435, 53486);

                    f_10303_53435_53485(diagnostics, errorLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53504, 53517);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 53279, 53532);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53548, 54586) || true) && (f_10303_53552_53584(delegateType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 53548, 54586);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53618, 53900) || true) && (isExtensionMethod)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 53618, 53900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53681, 53773);

                        f_10303_53681_53772(diagnostics, ErrorCode.ERR_CannotUseReducedExtensionMethodInAddressOf, errorLocation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53795, 53846);

                        f_10303_53795_53845(diagnostics, errorLocation, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53868, 53881);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 53618, 53900);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 53920, 54571) || true) && (f_10303_53924_53940_M(!method.IsStatic))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 53920, 54571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54263, 54341);

                        f_10303_54263_54340("This method should have been eliminated in overload resolution!");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54363, 54444);

                        f_10303_54363_54443(diagnostics, ErrorCode.ERR_FuncPtrMethMustBeStatic, errorLocation, method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54466, 54517);

                        f_10303_54466_54516(diagnostics, errorLocation, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54539, 54552);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 53920, 54571);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 53548, 54586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54602, 54653);

                f_10303_54602_54652(
                            diagnostics, errorLocation, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54667, 54679);

                return true;

                static bool hasConversion(TypeKind targetKind, Conversions conversions, TypeSymbol source, TypeSymbol destination,
                                RefKind sourceRefKind, RefKind destinationRefKind, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 54695, 55745);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 54959, 55072) || true) && (sourceRefKind != destinationRefKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 54959, 55072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55040, 55053);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 54959, 55072);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55092, 55252) || true) && (sourceRefKind != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 55092, 55252);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55167, 55233);

                            return f_10303_55174_55232(source, destination);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 55092, 55252);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55272, 55446) || true) && (f_10303_55276_55373(conversions, source, destination, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 55272, 55446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55415, 55427);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 55272, 55446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55466, 55730);

                        return targetKind == TypeKind.FunctionPointer
                        && (DynAbs.Tracing.TraceSender.Expression_True(10303, 55473, 55729) && (f_10303_55540_55611(source, destination) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 55540, 55728) || f_10303_55643_55728(conversions, source, destination, ref useSiteDiagnostics))));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 54695, 55745);

                        bool
                        f_10303_55174_55232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type2)
                        {
                            var return_v = ConversionsBase.HasIdentityConversion(type1, type2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 55174, 55232);
                            return return_v;
                        }


                        bool
                        f_10303_55276_55373(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 55276, 55373);
                            return return_v;
                        }


                        bool
                        f_10303_55540_55611(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination)
                        {
                            var return_v = ConversionsBase.HasImplicitPointerToVoidConversion(source, destination);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 55540, 55611);
                            return return_v;
                        }


                        bool
                        f_10303_55643_55728(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.HasImplicitPointerConversion(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 55643, 55728);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 54695, 55745);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 54695, 55745);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static ErrorCode getMethodMismatchErrorCode(TypeKind type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 55837, 56124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55840, 56124);
                        return type switch
                        {
                            TypeKind.Delegate when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55892, 55947) && DynAbs.Tracing.TraceSender.Expression_True(10303, 55892, 55947))
        => ErrorCode.ERR_MethDelegateMismatch,
                            TypeKind.FunctionPointer when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 55970, 56031) && DynAbs.Tracing.TraceSender.Expression_True(10303, 55970, 56031))
        => ErrorCode.ERR_MethFuncPtrMismatch,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 56054, 56105) && DynAbs.Tracing.TraceSender.Expression_True(10303, 56054, 56105))
        => throw f_10303_56065_56105(type)
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 55837, 56124);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 55837, 56124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 55837, 56124);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static ErrorCode getRefMismatchErrorCode(TypeKind type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 56214, 56499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 56217, 56499);
                        return type switch
                        {
                            TypeKind.Delegate when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 56269, 56323) && DynAbs.Tracing.TraceSender.Expression_True(10303, 56269, 56323))
        => ErrorCode.ERR_DelegateRefMismatch,
                            TypeKind.FunctionPointer when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 56346, 56406) && DynAbs.Tracing.TraceSender.Expression_True(10303, 56346, 56406))
        => ErrorCode.ERR_FuncPtrRefMismatch,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 56429, 56480) && DynAbs.Tracing.TraceSender.Expression_True(10303, 56429, 56480))
        => throw f_10303_56440_56480(type)
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 56214, 56499);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 56214, 56499);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 56214, 56499);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 48221, 56511);

                Microsoft.CodeAnalysis.TypeKind
                f_10303_48616_48637(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 48616, 48637);
                    return return_v;
                }


                int
                f_10303_48458_48775(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 48458, 48775);
                    return 0;
                }


                System.Exception
                f_10303_49073_49121(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 49073, 49121);
                    return return_v;
                }


                int
                f_10303_49154_49211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 49154, 49211);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10303_49308_49342(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 49308, 49342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10303_49380_49397(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 49380, 49397);
                    return return_v;
                }


                int
                f_10303_49656_49735(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 49656, 49735);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_49800_49821(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 49800, 49821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10303_49773_49822(Microsoft.CodeAnalysis.TypeKind
                type)
                {
                    var return_v = getMethodMismatchErrorCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 49773, 49822);
                    return return_v;
                }


                int
                f_10303_49754_49860(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 49754, 49860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_50226_50237()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 50226, 50237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_50268_50292(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 50268, 50292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10303_50294_50311(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 50294, 50311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_50226_50336(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                parameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                thisType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ConvertExtensionMethodThisArg(parameterType, thisType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 50226, 50336);
                    return return_v;
                }


                bool
                f_10303_50347_50381(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 50347, 50381);
                    return return_v;
                }


                int
                f_10303_50173_50383(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 50173, 50383);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_51908_51929(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 51908, 51929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_51931_51942()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 51931, 51942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_51944_51966(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 51944, 51966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_51968_51988(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 51968, 51988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10303_51990_52015(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 51990, 52015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10303_52017_52040(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52017, 52040);
                    return return_v;
                }


                bool
                f_10303_51894_52065(Microsoft.CodeAnalysis.TypeKind
                targetKind, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.RefKind
                sourceRefKind, Microsoft.CodeAnalysis.RefKind
                destinationRefKind, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = hasConversion(targetKind, conversions, source, destination, sourceRefKind, destinationRefKind, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 51894, 52065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_52222_52243(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52222, 52243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10303_52195_52244(Microsoft.CodeAnalysis.TypeKind
                type)
                {
                    var return_v = getMethodMismatchErrorCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52195, 52244);
                    return return_v;
                }


                int
                f_10303_52176_52282(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52176, 52282);
                    return 0;
                }


                bool
                f_10303_52305_52355(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52305, 52355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10303_52445_52476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52445, 52476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10303_52480_52494(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52480, 52494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_52571_52592(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52571, 52592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10303_52547_52593(Microsoft.CodeAnalysis.TypeKind
                type)
                {
                    var return_v = getRefMismatchErrorCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52547, 52593);
                    return return_v;
                }


                int
                f_10303_52528_52631(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52528, 52631);
                    return 0;
                }


                bool
                f_10303_52650_52700(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 52650, 52700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_52786_52803(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52786, 52803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_52843_52877(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 52843, 52877);
                    return return_v;
                }


                bool
                f_10303_53023_53041(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53023, 53041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_53113_53134(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53113, 53134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_53136_53147()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53136, 53147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10303_53187_53201(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53187, 53201);
                    return return_v;
                }


                bool
                f_10303_53099_53246(Microsoft.CodeAnalysis.TypeKind
                targetKind, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.RefKind
                sourceRefKind, Microsoft.CodeAnalysis.RefKind
                destinationRefKind, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = hasConversion(targetKind, conversions, source, destination, sourceRefKind, destinationRefKind, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53099, 53246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_53398_53415(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53398, 53415);
                    return return_v;
                }


                int
                f_10303_53330_53416(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53330, 53416);
                    return 0;
                }


                bool
                f_10303_53435_53485(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53435, 53485);
                    return return_v;
                }


                bool
                f_10303_53552_53584(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53552, 53584);
                    return return_v;
                }


                int
                f_10303_53681_53772(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53681, 53772);
                    return 0;
                }


                bool
                f_10303_53795_53845(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 53795, 53845);
                    return return_v;
                }


                bool
                f_10303_53924_53940_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 53924, 53940);
                    return return_v;
                }


                int
                f_10303_54263_54340(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 54263, 54340);
                    return 0;
                }


                int
                f_10303_54363_54443(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 54363, 54443);
                    return 0;
                }


                bool
                f_10303_54466_54516(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 54466, 54516);
                    return return_v;
                }


                bool
                f_10303_54602_54652(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 54602, 54652);
                    return return_v;
                }


                static System.Exception
                f_10303_56065_56105(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 56065, 56105);
                    return return_v;
                }


                static System.Exception
                f_10303_56440_56480(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 56440, 56480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 48221, 56511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 48221, 56511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MethodGroupConversionHasErrors(
                    SyntaxNode syntax,
                    Conversion conversion,
                    BoundExpression? receiverOpt,
                    bool isExtensionMethod,
                    bool isAddressOf,
                    TypeSymbol delegateOrFuncPtrType,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 57253, 59885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 57588, 57716);

                f_10303_57588_57715(f_10303_57601_57631(delegateOrFuncPtrType) == TypeKind.Delegate || (DynAbs.Tracing.TraceSender.Expression_False(10303, 57601, 57714) || f_10303_57656_57686(delegateOrFuncPtrType) == TypeKind.FunctionPointer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 57732, 57774);

                f_10303_57732_57773(conversion.Method is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 57788, 57836);

                MethodSymbol
                selectedMethod = conversion.Method
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 57852, 57883);

                var
                location = f_10303_57867_57882(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 57897, 58220) || true) && (!f_10303_57902_58043(this, receiverOpt, isExtensionMethod, selectedMethod, delegateOrFuncPtrType, location, diagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 57901, 58159) || f_10303_58064_58159(this, receiverOpt, selectedMethod, syntax, diagnostics, isExtensionMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 57897, 58220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58193, 58205);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 57897, 58220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58236, 58530) || true) && (f_10303_58240_58268(selectedMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 58236, 58530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58403, 58485);

                    f_10303_58403_58484(diagnostics, ErrorCode.ERR_DelegateOnConditional, location, selectedMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58503, 58515);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 58236, 58530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58546, 58610);

                var
                sourceMethod = selectedMethod as SourceOrdinaryMethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58624, 58996) || true) && (sourceMethod is object && (DynAbs.Tracing.TraceSender.Expression_True(10303, 58628, 58697) && f_10303_58654_58697(sourceMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 58624, 58996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58867, 58951);

                    f_10303_58867_58950(diagnostics, ErrorCode.ERR_PartialMethodToDelegate, location, selectedMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 58969, 58981);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 58624, 58996);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59012, 59203) || true) && ((f_10303_59017_59052(selectedMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10303, 59017, 59092) || f_10303_59056_59092(f_10303_59056_59081(selectedMethod)))) && (DynAbs.Tracing.TraceSender.Expression_True(10303, 59016, 59142) && f_10303_59097_59142(this, syntax, diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 59012, 59203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59176, 59188);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 59012, 59203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59217, 59389) || true) && (!isAddressOf)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 59217, 59389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59267, 59374);

                    f_10303_59267_59373(diagnostics, selectedMethod, location, isDelegateConversion: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 59217, 59389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59403, 59492);

                f_10303_59403_59491(this, diagnostics, selectedMethod, syntax, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59731, 59845);

                f_10303_59731_59844(f_10303_59744_59775_M(!selectedMethod.HasUseSiteError), "Shouldn't have reached this point if there were use site errors.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 59861, 59874);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 57253, 59885);

                Microsoft.CodeAnalysis.TypeKind
                f_10303_57601_57631(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 57601, 57631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10303_57656_57686(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 57656, 57686);
                    return return_v;
                }


                int
                f_10303_57588_57715(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 57588, 57715);
                    return 0;
                }


                int
                f_10303_57732_57773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 57732, 57773);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10303_57867_57882(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 57867, 57882);
                    return return_v;
                }


                bool
                f_10303_57902_58043(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MethodIsCompatibleWithDelegateOrFunctionPointer(receiverOpt, isExtensionMethod, method, delegateType, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 57902, 58043);
                    return return_v;
                }


                bool
                f_10303_58064_58159(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invokedAsExtensionMethod)
                {
                    var return_v = this_param.MemberGroupFinalValidation(receiverOpt, methodSymbol, node, diagnostics, invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 58064, 58159);
                    return return_v;
                }


                bool
                f_10303_58240_58268(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 58240, 58268);
                    return return_v;
                }


                int
                f_10303_58403_58484(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 58403, 58484);
                    return 0;
                }


                bool
                f_10303_58654_58697(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsPartialWithoutImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 58654, 58697);
                    return return_v;
                }


                int
                f_10303_58867_58950(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 58867, 58950);
                    return 0;
                }


                bool
                f_10303_59017_59052(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.HasUnsafeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59017, 59052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10303_59056_59081(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 59056, 59081);
                    return return_v;
                }


                bool
                f_10303_59056_59092(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59056, 59092);
                    return return_v;
                }


                bool
                f_10303_59097_59142(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportUnsafeIfNotAllowed(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59097, 59142);
                    return return_v;
                }


                int
                f_10303_59267_59373(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.Location
                location, bool
                isDelegateConversion)
                {
                    ReportDiagnosticsIfUnmanagedCallersOnly(diagnostics, symbol, location, isDelegateConversion: isDelegateConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59267, 59373);
                    return 0;
                }


                int
                f_10303_59403_59491(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59403, 59491);
                    return 0;
                }


                bool
                f_10303_59744_59775_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 59744, 59775);
                    return return_v;
                }


                int
                f_10303_59731_59844(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 59731, 59844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 57253, 59885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 57253, 59885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MethodGroupConversionDoesNotExistOrHasErrors(
                    BoundMethodGroup boundMethodGroup,
                    NamedTypeSymbol delegateType,
                    Location delegateMismatchLocation,
                    DiagnosticBag diagnostics,
                    out Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 60097, 61840);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60399, 60609) || true) && (f_10303_60403_60493(diagnostics, delegateType, delegateMismatchLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 60399, 60609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60527, 60564);

                    conversion = Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60582, 60594);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 60399, 60609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60625, 60676);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60690, 60804);

                conversion = f_10303_60703_60803(f_10303_60703_60714(), boundMethodGroup, delegateType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60818, 60880);

                f_10303_60818_60879(diagnostics, delegateMismatchLocation, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60894, 61829) || true) && (f_10303_60898_60916_M(!conversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 60894, 61829);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 60950, 61316) || true) && (!f_10303_60955_61071(this, boundMethodGroup, delegateType, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 60950, 61316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 61182, 61297);

                        f_10303_61182_61296(                    // No overload for '{0}' matches delegate '{1}'
                                            diagnostics, ErrorCode.ERR_MethDelegateMismatch, delegateMismatchLocation, f_10303_61260_61281(boundMethodGroup), delegateType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 60950, 61316);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 61336, 61348);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 60894, 61829);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 60894, 61829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 61414, 61447);

                    f_10303_61414_61446(conversion.IsValid);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 61627, 61814);

                    return f_10303_61634_61813(this, boundMethodGroup.Syntax, conversion, f_10303_61707_61735(boundMethodGroup), conversion.IsExtensionMethod, isAddressOf: false, delegateType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 60894, 61829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 60097, 61840);

                bool
                f_10303_60403_60493(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                possibleDelegateType, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = ReportDelegateInvokeUseSiteDiagnostic(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)possibleDelegateType, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 60403, 60493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10303_60703_60714()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 60703, 60714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10303_60703_60803(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetMethodGroupDelegateConversion(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 60703, 60803);
                    return return_v;
                }


                bool
                f_10303_60818_60879(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 60818, 60879);
                    return return_v;
                }


                bool
                f_10303_60898_60916_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 60898, 60916);
                    return return_v;
                }


                bool
                f_10303_60955_61071(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Conversions.ReportDelegateOrFunctionPointerMethodGroupDiagnostics(binder, expr, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)targetType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 60955, 61071);
                    return return_v;
                }


                string
                f_10303_61260_61281(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 61260, 61281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10303_61182_61296(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 61182, 61296);
                    return return_v;
                }


                int
                f_10303_61414_61446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 61414, 61446);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10303_61707_61735(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 61707, 61735);
                    return return_v;
                }


                bool
                f_10303_61634_61813(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, bool
                isExtensionMethod, bool
                isAddressOf, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateOrFuncPtrType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MethodGroupConversionHasErrors(syntax, conversion, receiverOpt, isExtensionMethod, isAddressOf: isAddressOf, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)delegateOrFuncPtrType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 61634, 61813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 60097, 61840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 60097, 61840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ConstantValue? FoldConstantConversion(
                    SyntaxNode syntax,
                    BoundExpression source,
                    Conversion conversion,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 61852, 66496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 62104, 62139);

                f_10303_62104_62138(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 62153, 62201);

                f_10303_62153_62200((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 63741, 63788);

                var
                sourceConstantValue = f_10303_63767_63787(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 63802, 64265) || true) && (sourceConstantValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 63802, 64265);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 63867, 64126) || true) && (conversion.Kind == ConversionKind.DefaultLiteral)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 63867, 64126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 63961, 63998);

                        return f_10303_63968_63997(destination);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 63867, 64126);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 63867, 64126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64080, 64107);

                        return sourceConstantValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 63867, 64126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 63802, 64265);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 63802, 64265);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64160, 64265) || true) && (f_10303_64164_64189(sourceConstantValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64160, 64265);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64223, 64250);

                        return sourceConstantValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64160, 64265);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 63802, 64265);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64281, 64365) || true) && (f_10303_64285_64304(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64281, 64365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64338, 64350);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64281, 64365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64381, 66457);

                switch (conversion.Kind)
                {

                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64381, 66457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64745, 65210);

                        switch (f_10303_64753_64776(destination))
                        {

                            case SpecialType.System_Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64745, 65210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 64887, 64948);

                                return f_10303_64894_64947(f_10303_64915_64946(sourceConstantValue));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64745, 65210);

                            case SpecialType.System_Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64745, 65210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 65035, 65096);

                                return f_10303_65042_65095(f_10303_65063_65094(sourceConstantValue));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64745, 65210);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64745, 65210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 65160, 65187);

                                return sourceConstantValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64745, 65210);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64381, 66457);

                    case ConversionKind.NullLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64381, 66457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 65284, 65311);

                        return sourceConstantValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64381, 66457);

                    case ConversionKind.ImplicitConstant:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64381, 66457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 65390, 65482);

                        return f_10303_65397_65481(this, syntax, sourceConstantValue, destination, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64381, 66457);

                    case ConversionKind.ExplicitNumeric:
                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ExplicitEnumeration:
                    case ConversionKind.ImplicitEnumeration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64381, 66457);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66010, 66127) || true) && (f_10303_66014_66042(destination))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 66010, 66127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66092, 66104);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 66010, 66127);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66151, 66243);

                        return f_10303_66158_66242(this, syntax, sourceConstantValue, destination, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64381, 66457);

                    case ConversionKind.ExplicitReference:
                    case ConversionKind.ImplicitReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 64381, 66457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66379, 66442);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 66386, 66412) || ((f_10303_66386_66412(sourceConstantValue) && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 66415, 66434)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 66437, 66441))) ? sourceConstantValue : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 64381, 66457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66473, 66485);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 61852, 66496);

                int
                f_10303_62104_62138(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 62104, 62138);
                    return 0;
                }


                int
                f_10303_62153_62200(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 62153, 62200);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_63767_63787(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 63767, 63787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_63968_63997(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 63968, 63997);
                    return return_v;
                }


                bool
                f_10303_64164_64189(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 64164, 64189);
                    return return_v;
                }


                bool
                f_10303_64285_64304(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 64285, 64304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10303_64753_64776(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 64753, 64776);
                    return return_v;
                }


                float
                f_10303_64915_64946(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SingleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 64915, 64946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_64894_64947(float
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 64894, 64947);
                    return return_v;
                }


                double
                f_10303_65063_65094(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 65063, 65094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_65042_65095(double
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 65042, 65095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_65397_65481(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                sourceValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FoldConstantNumericConversion(syntax, sourceValue, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 65397, 65481);
                    return return_v;
                }


                bool
                f_10303_66014_66042(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 66014, 66042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10303_66158_66242(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                sourceValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FoldConstantNumericConversion(syntax, sourceValue, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 66158, 66242);
                    return return_v;
                }


                bool
                f_10303_66386_66412(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 66386, 66412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 61852, 66496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 61852, 66496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConstantValue? FoldConstantNumericConversion(
                    SyntaxNode syntax,
                    ConstantValue sourceValue,
                    TypeSymbol destination,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10303, 66508, 69886);
                bool maySucceedAtRuntime = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66735, 66775);

                f_10303_66735_66774(sourceValue != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66789, 66822);

                f_10303_66789_66821(f_10303_66802_66820_M(!sourceValue.IsBad));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66838, 66866);

                SpecialType
                destinationType
                = default(SpecialType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66880, 67387) || true) && ((object)destination != null && (DynAbs.Tracing.TraceSender.Expression_True(10303, 66884, 66939) && f_10303_66915_66939(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 66880, 67387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 66973, 67044);

                    var
                    underlyingType = f_10303_66994_67043(((NamedTypeSymbol)destination))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67062, 67113);

                    f_10303_67062_67112((object)underlyingType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67131, 67192);

                    f_10303_67131_67191(f_10303_67144_67170(underlyingType) != SpecialType.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67210, 67255);

                    destinationType = f_10303_67228_67254(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 66880, 67387);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 66880, 67387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67321, 67372);

                    destinationType = f_10303_67339_67371(destination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 66880, 67387);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67757, 69761) || true) && (f_10303_67761_67782(sourceValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 67757, 69761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67816, 68161) || true) && (!f_10303_67821_67877(destinationType, sourceValue, out _))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 67816, 68161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 67998, 68095);

                        f_10303_67998_68094(diagnostics, ErrorCode.ERR_ConstOutOfRange, syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10303_68056_68073(sourceValue)).ToString(), 10303, 68056, 68073) + "M", destination!);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68117, 68142);

                        return f_10303_68124_68141();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 67816, 68161);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 67757, 69761);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 67757, 69761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68195, 69761) || true) && (destinationType == SpecialType.System_Decimal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68195, 69761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68278, 68539) || true) && (!f_10303_68283_68339(destinationType, sourceValue, out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68278, 68539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68381, 68473);

                            f_10303_68381_68472(diagnostics, ErrorCode.ERR_ConstOutOfRange, syntax, sourceValue.Value!, destination!);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68495, 68520);

                            return f_10303_68502_68519();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68278, 68539);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68195, 69761);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68195, 69761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68573, 69761) || true) && (f_10303_68577_68603())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68573, 69761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68637, 69357) || true) && (!f_10303_68642_68721(destinationType, sourceValue, out maySucceedAtRuntime))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68637, 69357);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68763, 69338) || true) && (maySucceedAtRuntime)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68763, 69338);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 68930, 69029);

                                    f_10303_68930_69028(diagnostics, ErrorCode.WRN_ConstOutOfRangeChecked, syntax, sourceValue.Value!, destination!);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69055, 69067);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68763, 69338);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68763, 69338);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69165, 69264);

                                    f_10303_69165_69263(diagnostics, ErrorCode.ERR_ConstOutOfRangeChecked, syntax, sourceValue.Value!, destination!);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69290, 69315);

                                    return f_10303_69297_69314();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68763, 69338);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68637, 69357);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68573, 69761);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 68573, 69761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69391, 69761) || true) && (destinationType == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10303, 69395, 69488) || destinationType == SpecialType.System_UIntPtr))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 69391, 69761);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69522, 69746) || true) && (!f_10303_69527_69583(destinationType, sourceValue, out _))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 69522, 69746);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69715, 69727);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 69522, 69746);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 69391, 69761);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68573, 69761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 68195, 69761);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 67757, 69761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 69777, 69875);

                return f_10303_69784_69874(f_10303_69805_69856(destinationType, sourceValue), destinationType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10303, 66508, 69886);

                int
                f_10303_66735_66774(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 66735, 66774);
                    return 0;
                }


                bool
                f_10303_66802_66820_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 66802, 66820);
                    return return_v;
                }


                int
                f_10303_66789_66821(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 66789, 66821);
                    return 0;
                }


                bool
                f_10303_66915_66939(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 66915, 66939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10303_66994_67043(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 66994, 67043);
                    return return_v;
                }


                int
                f_10303_67062_67112(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 67062, 67112);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10303_67144_67170(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 67144, 67170);
                    return return_v;
                }


                int
                f_10303_67131_67191(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 67131, 67191);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10303_67228_67254(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 67228, 67254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10303_67339_67371(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 67339, 67371);
                    return return_v;
                }


                bool
                f_10303_67761_67782(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsDecimal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 67761, 67782);
                    return return_v;
                }


                bool
                f_10303_67821_67877(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 67821, 67877);
                    return return_v;
                }


                object?
                f_10303_68056_68073(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 68056, 68073);
                    return return_v;
                }


                int
                f_10303_67998_68094(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 67998, 68094);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_68124_68141()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 68124, 68141);
                    return return_v;
                }


                bool
                f_10303_68283_68339(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 68283, 68339);
                    return return_v;
                }


                int
                f_10303_68381_68472(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 68381, 68472);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_68502_68519()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 68502, 68519);
                    return return_v;
                }


                bool
                f_10303_68577_68603()
                {
                    var return_v = CheckOverflowAtCompileTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 68577, 68603);
                    return return_v;
                }


                bool
                f_10303_68642_68721(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 68642, 68721);
                    return return_v;
                }


                int
                f_10303_68930_69028(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 68930, 69028);
                    return 0;
                }


                int
                f_10303_69165_69263(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 69165, 69263);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_69297_69314()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 69297, 69314);
                    return return_v;
                }


                bool
                f_10303_69527_69583(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 69527, 69583);
                    return return_v;
                }


                object
                f_10303_69805_69856(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = DoUncheckedConversion(destinationType, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 69805, 69856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10303_69784_69874(object
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create(value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 69784, 69874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 66508, 69886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 66508, 69886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object DoUncheckedConversion(SpecialType destinationType, ConstantValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 69898, 92285);
                // Note that we keep "single" floats as doubles internally to maintain higher precision. However,
                // we do not do so in an entirely "lossless" manner. When *converting* to a float, we do lose 
                // the precision lost due to the conversion. But when doing arithmetic, we do the arithmetic on
                // the double values.
                //
                // An example will help. Suppose we have:
                //
                // const float cf1 = 1.0f;
                // const float cf2 = 1.0e-15f;
                // const double cd3 = cf1 - cf2;
                //
                // We first take the double-precision values for 1.0 and 1.0e-15 and round them to floats,
                // and then turn them back into doubles. Then when we do the subtraction, we do the subtraction
                // in doubles, not in floats. Had we done the subtraction in floats, we'd get 1.0; but instead we
                // do it in doubles and get 0.99999999999999.
                //
                // Similarly, if we have
                //
                // const int i4 = int.MaxValue; // 2147483647
                // const float cf5 = int.MaxValue; //  2147483648.0
                // const double cd6 = cf5; // 2147483648.0
                //
                // The int is converted to float and stored internally as the double 214783648, even though the
                // fully precise int would fit into a double.

                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71473, 92149);

                    switch (f_10303_71481_71500(value))
                    {

                        case ConstantValueTypeDiscriminator.Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71609, 71642);

                            byte
                            byteValue = f_10303_71626_71641(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71668, 73011);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71779, 71802);

                                    return (byte)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71862, 71885);

                                    return (char)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 71947, 71972);

                                    return (ushort)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72034, 72057);

                                    return (uint)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72119, 72143);

                                    return (ulong)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72204, 72228);

                                    return (sbyte)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72289, 72313);

                                    return (short)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72374, 72396);

                                    return (int)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72457, 72480);

                                    return (long)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72542, 72564);

                                    return (int)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72627, 72650);

                                    return (uint)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72773, 72798);

                                    return (double)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72861, 72887);

                                    return (decimal)byteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71668, 73011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 72926, 72984);

                                    throw f_10303_72932_72983(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71668, 73011);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73100, 73133);

                            char
                            charValue = f_10303_73117_73132(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73159, 74502);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73270, 73293);

                                    return (byte)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73353, 73376);

                                    return (char)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73438, 73463);

                                    return (ushort)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73525, 73548);

                                    return (uint)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73610, 73634);

                                    return (ulong)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73695, 73719);

                                    return (sbyte)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73780, 73804);

                                    return (short)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73865, 73887);

                                    return (int)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 73948, 73971);

                                    return (long)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74033, 74055);

                                    return (int)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74118, 74141);

                                    return (uint)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74264, 74289);

                                    return (double)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74352, 74378);

                                    return (decimal)charValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 73159, 74502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74417, 74475);

                                    throw f_10303_74423_74474(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 73159, 74502);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74593, 74632);

                            ushort
                            uint16Value = f_10303_74614_74631(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74658, 76027);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74769, 74794);

                                    return (byte)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74854, 74879);

                                    return (char)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 74941, 74968);

                                    return (ushort)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75030, 75055);

                                    return (uint)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75117, 75143);

                                    return (ulong)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75204, 75230);

                                    return (sbyte)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75291, 75317);

                                    return (short)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75378, 75402);

                                    return (int)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75463, 75488);

                                    return (long)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75550, 75574);

                                    return (int)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75637, 75662);

                                    return (uint)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75785, 75812);

                                    return (double)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75875, 75903);

                                    return (decimal)uint16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 74658, 76027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 75942, 76000);

                                    throw f_10303_75948_75999(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 74658, 76027);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76118, 76155);

                            uint
                            uint32Value = f_10303_76137_76154(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76181, 77585);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76292, 76317);

                                    return (byte)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76377, 76402);

                                    return (char)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76464, 76491);

                                    return (ushort)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76553, 76578);

                                    return (uint)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76640, 76666);

                                    return (ulong)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76727, 76753);

                                    return (sbyte)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76814, 76840);

                                    return (short)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76901, 76925);

                                    return (int)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 76986, 77011);

                                    return (long)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77073, 77097);

                                    return (int)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77160, 77185);

                                    return (uint)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77247, 77281);

                                    return (double)(float)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77343, 77370);

                                    return (double)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77433, 77461);

                                    return (decimal)uint32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 76181, 77585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77500, 77558);

                                    throw f_10303_77506_77557(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 76181, 77585);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77676, 77714);

                            ulong
                            uint64Value = f_10303_77696_77713(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77740, 79144);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77851, 77876);

                                    return (byte)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 77936, 77961);

                                    return (char)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78023, 78050);

                                    return (ushort)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78112, 78137);

                                    return (uint)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78199, 78225);

                                    return (ulong)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78286, 78312);

                                    return (sbyte)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78373, 78399);

                                    return (short)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78460, 78484);

                                    return (int)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78545, 78570);

                                    return (long)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78632, 78656);

                                    return (int)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78719, 78744);

                                    return (uint)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78806, 78840);

                                    return (double)(float)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78902, 78929);

                                    return (double)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 78992, 79020);

                                    return (decimal)uint64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 77740, 79144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79059, 79117);

                                    throw f_10303_79065_79116(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 77740, 79144);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.NUInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79234, 79270);

                            uint
                            nuintValue = f_10303_79252_79269(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79296, 80599);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79407, 79431);

                                    return (byte)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79491, 79515);

                                    return (char)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79577, 79603);

                                    return (ushort)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79665, 79689);

                                    return (uint)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79751, 79776);

                                    return (ulong)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79837, 79862);

                                    return (sbyte)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 79923, 79948);

                                    return (short)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80009, 80032);

                                    return (int)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80093, 80117);

                                    return (long)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80179, 80202);

                                    return (int)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80264, 80297);

                                    return (double)(float)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80359, 80385);

                                    return (double)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80448, 80475);

                                    return (decimal)nuintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 79296, 80599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80514, 80572);

                                    throw f_10303_80520_80571(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 79296, 80599);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80689, 80725);

                            sbyte
                            sbyteValue = f_10303_80708_80724(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80751, 82107);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80862, 80886);

                                    return (byte)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 80946, 80970);

                                    return (char)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81032, 81058);

                                    return (ushort)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81120, 81144);

                                    return (uint)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81206, 81231);

                                    return (ulong)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81292, 81317);

                                    return (sbyte)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81378, 81403);

                                    return (short)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81464, 81487);

                                    return (int)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81548, 81572);

                                    return (long)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81634, 81657);

                                    return (int)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81720, 81744);

                                    return (uint)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81867, 81893);

                                    return (double)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 81956, 81983);

                                    return (decimal)sbyteValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 80751, 82107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82022, 82080);

                                    throw f_10303_82028_82079(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 80751, 82107);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82197, 82233);

                            short
                            int16Value = f_10303_82216_82232(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82259, 83615);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82370, 82394);

                                    return (byte)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82454, 82478);

                                    return (char)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82540, 82566);

                                    return (ushort)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82628, 82652);

                                    return (uint)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82714, 82739);

                                    return (ulong)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82800, 82825);

                                    return (sbyte)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82886, 82911);

                                    return (short)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 82972, 82995);

                                    return (int)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83056, 83080);

                                    return (long)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83142, 83165);

                                    return (int)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83228, 83252);

                                    return (uint)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83375, 83401);

                                    return (double)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83464, 83491);

                                    return (decimal)int16Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 82259, 83615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83530, 83588);

                                    throw f_10303_83536_83587(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 82259, 83615);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83705, 83739);

                            int
                            int32Value = f_10303_83722_83738(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83765, 85155);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83876, 83900);

                                    return (byte)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 83960, 83984);

                                    return (char)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84046, 84072);

                                    return (ushort)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84134, 84158);

                                    return (uint)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84220, 84245);

                                    return (ulong)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84306, 84331);

                                    return (sbyte)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84392, 84417);

                                    return (short)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84478, 84501);

                                    return (int)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84562, 84586);

                                    return (long)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84648, 84671);

                                    return (int)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84734, 84758);

                                    return (uint)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84820, 84853);

                                    return (double)(float)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 84915, 84941);

                                    return (double)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85004, 85031);

                                    return (decimal)int32Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 83765, 85155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85070, 85128);

                                    throw f_10303_85076_85127(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 83765, 85155);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85245, 85280);

                            long
                            int64Value = f_10303_85263_85279(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85306, 86696);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85417, 85441);

                                    return (byte)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85501, 85525);

                                    return (char)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85587, 85613);

                                    return (ushort)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85675, 85699);

                                    return (uint)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85761, 85786);

                                    return (ulong)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85847, 85872);

                                    return (sbyte)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 85933, 85958);

                                    return (short)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86019, 86042);

                                    return (int)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86103, 86127);

                                    return (long)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86189, 86212);

                                    return (int)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86275, 86299);

                                    return (uint)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86361, 86394);

                                    return (double)(float)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86456, 86482);

                                    return (double)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86545, 86572);

                                    return (decimal)int64Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 85306, 86696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86611, 86669);

                                    throw f_10303_86617_86668(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 85306, 86696);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.NInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86785, 86818);

                            int
                            nintValue = f_10303_86801_86817(value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86844, 88220);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 86955, 86978);

                                    return (byte)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87038, 87061);

                                    return (char)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87123, 87148);

                                    return (ushort)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87210, 87233);

                                    return (uint)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87295, 87319);

                                    return (ulong)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87380, 87404);

                                    return (sbyte)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87465, 87489);

                                    return (short)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87550, 87572);

                                    return (int)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87633, 87656);

                                    return (long)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87718, 87740);

                                    return (int)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87803, 87826);

                                    return (uint)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87888, 87920);

                                    return (double)(float)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 87982, 88007);

                                    return (double)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 88070, 88096);

                                    return (decimal)nintValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 86844, 88220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 88135, 88193);

                                    throw f_10303_88141_88192(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 86844, 88220);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Single:
                        case ConstantValueTypeDiscriminator.Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 88729, 88838);

                            double
                            doubleValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 88750, 88812) || ((f_10303_88750_88812(destinationType, f_10303_88787_88804(value), out _) && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 88815, 88832)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 88835, 88837))) ? f_10303_88815_88832(value) : 0D
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 88864, 90363);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 88975, 89000);

                                    return (byte)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89060, 89085);

                                    return (char)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89147, 89174);

                                    return (ushort)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89236, 89261);

                                    return (uint)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89323, 89349);

                                    return (ulong)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89410, 89436);

                                    return (sbyte)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89497, 89523);

                                    return (short)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89584, 89608);

                                    return (int)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89669, 89694);

                                    return (long)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89756, 89780);

                                    return (int)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89843, 89868);

                                    return (uint)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 89930, 89964);

                                    return (double)(float)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90026, 90053);

                                    return (double)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90116, 90239);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 90123, 90185) || (((f_10303_90124_90143(value) == ConstantValueTypeDiscriminator.Single) && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 90188, 90215)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 90218, 90238))) ? (decimal)(float)doubleValue : (decimal)doubleValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 88864, 90363);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90278, 90336);

                                    throw f_10303_90284_90335(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 88864, 90363);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        case ConstantValueTypeDiscriminator.Decimal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90455, 90568);

                            decimal
                            decimalValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 90478, 90541) || ((f_10303_90478_90541(destinationType, f_10303_90515_90533(value), out _) && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 90544, 90562)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 90565, 90567))) ? f_10303_90544_90562(value) : 0m
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90594, 92012);

                            switch (destinationType)
                            {

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90705, 90731);

                                    return (byte)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90791, 90817);

                                    return (char)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90879, 90907);

                                    return (ushort)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 90969, 90995);

                                    return (uint)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91057, 91084);

                                    return (ulong)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91145, 91172);

                                    return (sbyte)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91233, 91260);

                                    return (short)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91321, 91346);

                                    return (int)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91407, 91433);

                                    return (long)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91495, 91520);

                                    return (int)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91583, 91609);

                                    return (uint)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91671, 91706);

                                    return (double)(float)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91768, 91796);

                                    return (double)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91859, 91888);

                                    return (decimal)decimalValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 90594, 92012);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 91927, 91985);

                                    throw f_10303_91933_91984(destinationType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 90594, 92012);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 71473, 92149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92068, 92130);

                            throw f_10303_92074_92129(f_10303_92109_92128(value));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 71473, 92149);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 69898, 92285);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10303_71481_71500(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 71481, 71500);
                    return return_v;
                }


                byte
                f_10303_71626_71641(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 71626, 71641);
                    return return_v;
                }


                System.Exception
                f_10303_72932_72983(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 72932, 72983);
                    return return_v;
                }


                char
                f_10303_73117_73132(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.CharValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 73117, 73132);
                    return return_v;
                }


                System.Exception
                f_10303_74423_74474(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 74423, 74474);
                    return return_v;
                }


                ushort
                f_10303_74614_74631(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 74614, 74631);
                    return return_v;
                }


                System.Exception
                f_10303_75948_75999(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 75948, 75999);
                    return return_v;
                }


                uint
                f_10303_76137_76154(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 76137, 76154);
                    return return_v;
                }


                System.Exception
                f_10303_77506_77557(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 77506, 77557);
                    return return_v;
                }


                ulong
                f_10303_77696_77713(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 77696, 77713);
                    return return_v;
                }


                System.Exception
                f_10303_79065_79116(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 79065, 79116);
                    return return_v;
                }


                uint
                f_10303_79252_79269(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 79252, 79269);
                    return return_v;
                }


                System.Exception
                f_10303_80520_80571(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 80520, 80571);
                    return return_v;
                }


                sbyte
                f_10303_80708_80724(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 80708, 80724);
                    return return_v;
                }


                System.Exception
                f_10303_82028_82079(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 82028, 82079);
                    return return_v;
                }


                short
                f_10303_82216_82232(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 82216, 82232);
                    return return_v;
                }


                System.Exception
                f_10303_83536_83587(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 83536, 83587);
                    return return_v;
                }


                int
                f_10303_83722_83738(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 83722, 83738);
                    return return_v;
                }


                System.Exception
                f_10303_85076_85127(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 85076, 85127);
                    return return_v;
                }


                long
                f_10303_85263_85279(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 85263, 85279);
                    return return_v;
                }


                System.Exception
                f_10303_86617_86668(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 86617, 86668);
                    return return_v;
                }


                int
                f_10303_86801_86817(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 86801, 86817);
                    return return_v;
                }


                System.Exception
                f_10303_88141_88192(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 88141, 88192);
                    return return_v;
                }


                double
                f_10303_88787_88804(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 88787, 88804);
                    return return_v;
                }


                bool
                f_10303_88750_88812(Microsoft.CodeAnalysis.SpecialType
                destinationType, double
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 88750, 88812);
                    return return_v;
                }


                double
                f_10303_88815_88832(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 88815, 88832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10303_90124_90143(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 90124, 90143);
                    return return_v;
                }


                System.Exception
                f_10303_90284_90335(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 90284, 90335);
                    return return_v;
                }


                decimal
                f_10303_90515_90533(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 90515, 90533);
                    return return_v;
                }


                bool
                f_10303_90478_90541(Microsoft.CodeAnalysis.SpecialType
                destinationType, decimal
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 90478, 90541);
                    return return_v;
                }


                decimal
                f_10303_90544_90562(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 90544, 90562);
                    return return_v;
                }


                System.Exception
                f_10303_91933_91984(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 91933, 91984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10303_92109_92128(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 92109, 92128);
                    return return_v;
                }


                System.Exception
                f_10303_92074_92129(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 92074, 92129);
                    return return_v;
                }


                // all cases should have been handled in the switch above.
                // return value.Value;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 69898, 92285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 69898, 92285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckConstantBounds(SpecialType destinationType, ConstantValue value, out bool maySucceedAtRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 92297, 93244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92440, 92635) || true) && (f_10303_92444_92455(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 92440, 92635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92562, 92590);

                    maySucceedAtRuntime = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92608, 92620);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 92440, 92635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92926, 92975);

                var
                canonicalValue = f_10303_92947_92974(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 92989, 93233);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10303, 92996, 93021) || ((canonicalValue is decimal && DynAbs.Tracing.TraceSender.Conditional_F2(10303, 93041, 93127)) || DynAbs.Tracing.TraceSender.Conditional_F3(10303, 93147, 93232))) ? f_10303_93041_93127(destinationType, canonicalValue, out maySucceedAtRuntime) : f_10303_93147_93232(destinationType, canonicalValue, out maySucceedAtRuntime);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 92297, 93244);

                bool
                f_10303_92444_92455(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 92444, 92455);
                    return return_v;
                }


                object
                f_10303_92947_92974(Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = CanonicalizeConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 92947, 92974);
                    return return_v;
                }


                bool
                f_10303_93041_93127(Microsoft.CodeAnalysis.SpecialType
                destinationType, object
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, (decimal)value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 93041, 93127);
                    return return_v;
                }


                bool
                f_10303_93147_93232(Microsoft.CodeAnalysis.SpecialType
                destinationType, object
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = CheckConstantBounds(destinationType, (double)value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 93147, 93232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 92297, 93244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 92297, 93244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckConstantBounds(SpecialType destinationType, double value, out bool maySucceedAtRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 93256, 95439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 93393, 93421);

                maySucceedAtRuntime = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 93564, 95400);

                switch (destinationType)
                {

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 93651, 93719);

                        return (byte.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 93658, 93718) && value < (byte.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 93767, 93835);

                        return (char.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 93774, 93834) && value < (char.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 93885, 93957);

                        return (ushort.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 93892, 93956) && value < (ushort.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94007, 94075);

                        return (uint.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94014, 94074) && value < (uint.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94125, 94195);

                        return (ulong.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94132, 94194) && value < (ulong.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94244, 94314);

                        return (sbyte.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94251, 94313) && value < (sbyte.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94363, 94433);

                        return (short.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94370, 94432) && value < (short.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94482, 94548);

                        return (int.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94489, 94547) && value < (int.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94686, 94755);

                        return (long.MinValue - 1D) <= value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94693, 94754) && value < (long.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94806, 94896);

                        return ((double)decimal.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94813, 94895) && value < ((double)decimal.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 94967, 95050);

                        maySucceedAtRuntime = (long.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 94989, 95049) && value < (long.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95072, 95138);

                        return (int.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 95079, 95137) && value < (int.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);

                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 93564, 95400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95210, 95295);

                        maySucceedAtRuntime = (ulong.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 95232, 95294) && value < (ulong.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95317, 95385);

                        return (uint.MinValue - 1D) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 95324, 95384) && value < (uint.MaxValue + 1D));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 93564, 95400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95416, 95428);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 93256, 95439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 93256, 95439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 93256, 95439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckConstantBounds(SpecialType destinationType, decimal value, out bool maySucceedAtRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 95451, 97404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95589, 95617);

                maySucceedAtRuntime = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95760, 97365);

                switch (destinationType)
                {

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95847, 95915);

                        return (byte.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 95854, 95914) && value < (byte.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 95963, 96031);

                        return (char.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 95970, 96030) && value < (char.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96081, 96153);

                        return (ushort.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96088, 96152) && value < (ushort.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96203, 96271);

                        return (uint.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96210, 96270) && value < (uint.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96321, 96391);

                        return (ulong.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96328, 96390) && value < (ulong.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96440, 96510);

                        return (sbyte.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96447, 96509) && value < (sbyte.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96559, 96629);

                        return (short.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96566, 96628) && value < (short.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96678, 96744);

                        return (int.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96685, 96743) && value < (int.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96793, 96861);

                        return (long.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96800, 96860) && value < (long.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 96932, 97015);

                        maySucceedAtRuntime = (long.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 96954, 97014) && value < (long.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97037, 97103);

                        return (int.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 97044, 97102) && value < (int.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);

                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 95760, 97365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97175, 97260);

                        maySucceedAtRuntime = (ulong.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 97197, 97259) && value < (ulong.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97282, 97350);

                        return (uint.MinValue - 1M) < value && (DynAbs.Tracing.TraceSender.Expression_True(10303, 97289, 97349) && value < (uint.MaxValue + 1M));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 95760, 97365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97381, 97393);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 95451, 97404);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 95451, 97404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 95451, 97404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object CanonicalizeConstant(ConstantValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10303, 97515, 99092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97603, 99023);

                switch (f_10303_97611_97630(value))
                {

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97707, 97740);

                        return (decimal)f_10303_97723_97739(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97801, 97834);

                        return (decimal)f_10303_97817_97833(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97895, 97928);

                        return (decimal)f_10303_97911_97927(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 97989, 98022);

                        return (decimal)f_10303_98005_98021(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98082, 98115);

                        return (decimal)f_10303_98098_98114(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98175, 98207);

                        return (decimal)f_10303_98191_98206(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98267, 98299);

                        return (decimal)f_10303_98283_98298(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98361, 98395);

                        return (decimal)f_10303_98377_98394(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98457, 98491);

                        return (decimal)f_10303_98473_98490(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98553, 98587);

                        return (decimal)f_10303_98569_98586(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98648, 98682);

                        return (decimal)f_10303_98664_98681(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Single:
                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98805, 98830);

                        return f_10303_98812_98829(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    case ConstantValueTypeDiscriminator.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98893, 98919);

                        return f_10303_98900_98918(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10303, 97603, 99023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10303, 98946, 99008);

                        throw f_10303_98952_99007(f_10303_98987_99006(value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10303, 97603, 99023);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10303, 97515, 99092);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10303_97611_97630(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 97611, 97630);
                    return return_v;
                }


                sbyte
                f_10303_97723_97739(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 97723, 97739);
                    return return_v;
                }


                short
                f_10303_97817_97833(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 97817, 97833);
                    return return_v;
                }


                int
                f_10303_97911_97927(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 97911, 97927);
                    return return_v;
                }


                long
                f_10303_98005_98021(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98005, 98021);
                    return return_v;
                }


                int
                f_10303_98098_98114(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98098, 98114);
                    return return_v;
                }


                byte
                f_10303_98191_98206(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98191, 98206);
                    return return_v;
                }


                char
                f_10303_98283_98298(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.CharValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98283, 98298);
                    return return_v;
                }


                ushort
                f_10303_98377_98394(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98377, 98394);
                    return return_v;
                }


                uint
                f_10303_98473_98490(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98473, 98490);
                    return return_v;
                }


                ulong
                f_10303_98569_98586(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98569, 98586);
                    return return_v;
                }


                uint
                f_10303_98664_98681(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98664, 98681);
                    return return_v;
                }


                double
                f_10303_98812_98829(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98812, 98829);
                    return return_v;
                }


                decimal
                f_10303_98900_98918(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98900, 98918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10303_98987_99006(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10303, 98987, 99006);
                    return return_v;
                }


                System.Exception
                f_10303_98952_99007(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10303, 98952, 99007);
                    return return_v;
                }


                // all cases handled in the switch, above.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10303, 97515, 99092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10303, 97515, 99092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
