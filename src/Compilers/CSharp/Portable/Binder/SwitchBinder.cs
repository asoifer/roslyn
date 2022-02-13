// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SwitchBinder : LocalScopeBinder
    {
        protected readonly SwitchStatementSyntax SwitchSyntax;

        private readonly GeneratedLabelSymbol _breakLabel;

        private BoundExpression _switchGoverningExpression;

        private DiagnosticBag _switchGoverningDiagnostics;

        private SwitchBinder(Binder next, SwitchStatementSyntax switchSyntax)
        : base(f_10369_1012_1016_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10369, 922, 1143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 714, 726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 777, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 823, 849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 882, 909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3004, 3024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19638, 19651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1042, 1070);

                SwitchSyntax = switchSyntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1084, 1132);

                _breakLabel = f_10369_1098_1131("break");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10369, 922, 1143);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 922, 1143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 922, 1143);
            }
        }

        protected bool PatternsEnabled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 1186, 1320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1202, 1320);
                    return f_10369_1202_1311_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((CSharpParseOptions)f_10369_1223_1254(f_10369_1223_1246(SwitchSyntax))), 10369, 1202, 1311)?.IsFeatureEnabled(MessageID.IDS_FeaturePatternMatching)) != false; DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 1186, 1320);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 1186, 1320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 1186, 1320);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected BoundExpression SwitchGoverningExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 1409, 1632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1445, 1498);

                    f_10369_1445_1497(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1516, 1565);

                    f_10369_1516_1564(_switchGoverningExpression != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1583, 1617);

                    return _switchGoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 1409, 1632);

                    int
                    f_10369_1445_1497(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                    this_param)
                    {
                        this_param.EnsureSwitchGoverningExpressionAndDiagnosticsBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1445, 1497);
                        return 0;
                    }


                    int
                    f_10369_1516_1564(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1516, 1564);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 1333, 1643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 1333, 1643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected TypeSymbol SwitchGoverningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 1696, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1699, 1729);
                    return f_10369_1699_1729(f_10369_1699_1724()); DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 1696, 1729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 1696, 1729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 1696, 1729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected uint SwitchGoverningValEscape
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 1782, 1841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1785, 1841);
                    return f_10369_1785_1841(f_10369_1798_1823(), f_10369_1825_1840()); DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 1782, 1841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 1782, 1841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 1782, 1841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected DiagnosticBag SwitchGoverningDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 1929, 2086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 1965, 2018);

                    f_10369_1965_2017(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2036, 2071);

                    return _switchGoverningDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 1929, 2086);

                    int
                    f_10369_1965_2017(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                    this_param)
                    {
                        this_param.EnsureSwitchGoverningExpressionAndDiagnosticsBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1965, 2017);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 1854, 2097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 1854, 2097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureSwitchGoverningExpressionAndDiagnosticsBound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 2109, 2636);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2199, 2625) || true) && (_switchGoverningExpression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 2199, 2625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2271, 2324);

                    var
                    switchGoverningDiagnostics = f_10369_2304_2323()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2342, 2428);

                    var
                    boundSwitchExpression = f_10369_2370_2427(this, switchGoverningDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2446, 2503);

                    _switchGoverningDiagnostics = switchGoverningDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 2521, 2610);

                    f_10369_2521_2609(ref _switchGoverningExpression, boundSwitchExpression, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 2199, 2625);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 2109, 2636);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10369_2304_2323()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 2304, 2323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_2370_2427(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchGoverningExpression(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 2370, 2427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10369_2521_2609(ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
                location1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 2521, 2609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 2109, 2636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 2109, 2636);
            }
        }

        private Dictionary<object, SourceLabelSymbol> _lazySwitchLabelsMap;

        private static readonly object s_defaultKey;

        private Dictionary<object, SourceLabelSymbol> LabelsByValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 3190, 3463);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3226, 3400) || true) && (_lazySwitchLabelsMap == null && (DynAbs.Tracing.TraceSender.Expression_True(10369, 3230, 3284) && this.Labels.Length > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 3226, 3400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3326, 3381);

                        _lazySwitchLabelsMap = f_10369_3349_3380(f_10369_3368_3379(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 3226, 3400);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3420, 3448);

                    return _lazySwitchLabelsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 3190, 3463);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10369_3368_3379(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                    this_param)
                    {
                        var return_v = this_param.Labels;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 3368, 3379);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                    f_10369_3349_3380(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    labels)
                    {
                        var return_v = BuildLabelsByValue(labels);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3349, 3380);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 3106, 3474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 3106, 3474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static Dictionary<object, SourceLabelSymbol> BuildLabelsByValue(ImmutableArray<LabelSymbol> labels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10369, 3486, 5190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3618, 3650);

                f_10369_3618_3649(labels.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3666, 3787);

                var
                map = f_10369_3676_3786(labels.Length, f_10369_3733_3785())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3801, 5152);
                    foreach (SourceLabelSymbol label in f_10369_3837_3843_I(labels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 3801, 5152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3877, 3935);

                        SyntaxKind
                        labelKind = label.IdentifierNodeOrToken.Kind()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3953, 4066) || true) && (labelKind == SyntaxKind.IdentifierToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 3953, 4066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4038, 4047);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 3953, 4066);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4086, 4097);

                        object
                        key
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4115, 4165);

                        var
                        constantValue = f_10369_4135_4164(label)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4183, 4898) || true) && ((object)constantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10369, 4187, 4240) && f_10369_4220_4240_M(!constantValue.IsBad)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 4183, 4898);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4385, 4421);

                            key = f_10369_4391_4420(constantValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 4183, 4898);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 4183, 4898);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4463, 4898) || true) && (labelKind == SyntaxKind.DefaultSwitchLabel)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 4463, 4898);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4636, 4655);

                                key = s_defaultKey;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 4463, 4898);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 4463, 4898);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 4836, 4879);

                                key = label.IdentifierNodeOrToken.AsNode();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 4463, 4898);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 4183, 4898);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5031, 5137) || true) && (!f_10369_5036_5056(map, key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 5031, 5137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5098, 5118);

                            f_10369_5098_5117(map, key, label);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 5031, 5137);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 3801, 5152);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 1352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 1352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5168, 5179);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10369, 3486, 5190);

                int
                f_10369_3618_3649(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3618, 3649);
                    return 0;
                }


                Microsoft.CodeAnalysis.SwitchConstantValueHelper.SwitchLabelsComparer
                f_10369_3733_3785()
                {
                    var return_v = new Microsoft.CodeAnalysis.SwitchConstantValueHelper.SwitchLabelsComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3733, 3785);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                f_10369_3676_3786(int
                capacity, Microsoft.CodeAnalysis.SwitchConstantValueHelper.SwitchLabelsComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>(capacity, (System.Collections.Generic.IEqualityComparer<object>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3676, 3786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10369_4135_4164(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                this_param)
                {
                    var return_v = this_param.SwitchCaseLabelConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 4135, 4164);
                    return return_v;
                }


                bool
                f_10369_4220_4240_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 4220, 4240);
                    return return_v;
                }


                object
                f_10369_4391_4420(Microsoft.CodeAnalysis.ConstantValue
                constantValue)
                {
                    var return_v = KeyForConstant(constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 4391, 4420);
                    return return_v;
                }


                bool
                f_10369_5036_5056(System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                this_param, object?
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5036, 5056);
                    return return_v;
                }


                int
                f_10369_5098_5117(System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                this_param, object?
                key, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5098, 5117);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10369_3837_3843_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3837, 3843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 3486, 5190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 3486, 5190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 5202, 5584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5287, 5341);

                var
                builder = f_10369_5301_5340()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5357, 5521);
                    foreach (var section in f_10369_5381_5402_I(f_10369_5381_5402(SwitchSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 5357, 5521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5436, 5506);

                        f_10369_5436_5505(builder, f_10369_5453_5504(this, f_10369_5465_5483(section), f_10369_5485_5503(this, section)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 5357, 5521);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5537, 5573);

                return f_10369_5544_5572(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 5202, 5584);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10369_5301_5340()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5301, 5340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_5381_5402(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 5381, 5402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10369_5465_5483(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 5465, 5483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10369_5485_5503(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5485, 5503);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10369_5453_5504(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements, Microsoft.CodeAnalysis.CSharp.Binder?
                enclosingBinder)
                {
                    var return_v = this_param.BuildLocals(statements, enclosingBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5453, 5504);
                    return return_v;
                }


                int
                f_10369_5436_5505(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5436, 5505);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_5381_5402_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5381, 5402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10369_5544_5572(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5544, 5572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 5202, 5584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 5202, 5584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 5596, 5990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5697, 5759);

                var
                builder = f_10369_5711_5758()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5775, 5927);
                    foreach (var section in f_10369_5799_5820_I(f_10369_5799_5820(SwitchSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 5775, 5927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5854, 5912);

                        f_10369_5854_5911(builder, f_10369_5871_5910(this, f_10369_5891_5909(section)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 5775, 5927);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 5943, 5979);

                return f_10369_5950_5978(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 5596, 5990);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10369_5711_5758()
                {
                    var return_v = ArrayBuilder<LocalFunctionSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5711, 5758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_5799_5820(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 5799, 5820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10369_5891_5909(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 5891, 5909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10369_5871_5910(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements)
                {
                    var return_v = this_param.BuildLocalFunctions(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5871, 5910);
                    return return_v;
                }


                int
                f_10369_5854_5911(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5854, 5911);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_5799_5820_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5799, 5820);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10369_5950_5978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 5950, 5978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 5596, 5990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 5596, 5990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 6077, 6140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6113, 6125);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 6077, 6140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 6002, 6151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 6002, 6151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol BreakLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 6237, 6307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6273, 6292);

                    return _breakLabel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 6237, 6307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 6163, 6318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 6163, 6318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 6330, 7296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6659, 6734);

                ArrayBuilder<LabelSymbol>
                labels = f_10369_6694_6733()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6748, 6810);

                DiagnosticBag
                tempDiagnosticBag = f_10369_6782_6809()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6824, 7195);
                    foreach (var section in f_10369_6848_6869_I(f_10369_6848_6869(SwitchSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 6824, 7195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 6954, 7035);

                        f_10369_6954_7034(this, f_10369_6972_6986(section), f_10369_6988_7006(this, section), labels, tempDiagnosticBag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7136, 7180);

                        f_10369_7136_7179(this, f_10369_7148_7166(section), ref labels);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 6824, 7195);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7211, 7236);

                f_10369_7211_7235(
                            tempDiagnosticBag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7250, 7285);

                return f_10369_7257_7284(labels);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 6330, 7296);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10369_6694_6733()
                {
                    var return_v = ArrayBuilder<LabelSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 6694, 6733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10369_6782_6809()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 6782, 6809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_6848_6869(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 6848, 6869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10369_6972_6986(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 6972, 6986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10369_6988_7006(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 6988, 7006);
                    return return_v;
                }


                int
                f_10369_6954_7034(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                labelsSyntax, Microsoft.CodeAnalysis.CSharp.Binder?
                sectionBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                labels, Microsoft.CodeAnalysis.DiagnosticBag
                tempDiagnosticBag)
                {
                    this_param.BuildSwitchLabels(labelsSyntax, sectionBinder, labels, tempDiagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 6954, 7034);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10369_7148_7166(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 7148, 7166);
                    return return_v;
                }


                int
                f_10369_7136_7179(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                labels)
                {
                    this_param.BuildLabels(statements, ref labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 7136, 7179);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10369_6848_6869_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 6848, 6869);
                    return return_v;
                }


                int
                f_10369_7211_7235(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 7211, 7235);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10369_7257_7284(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 7257, 7284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 6330, 7296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 6330, 7296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 7375, 7438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7411, 7423);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 7375, 7438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 7308, 7449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 7308, 7449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void BuildSwitchLabels(SyntaxList<SwitchLabelSyntax> labelsSyntax, Binder sectionBinder, ArrayBuilder<LabelSymbol> labels, DiagnosticBag tempDiagnosticBag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 7461, 9610);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7696, 9599);
                    foreach (var labelSyntax in f_10369_7724_7736_I(labelsSyntax))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 7696, 9599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7770, 7813);

                        ConstantValue
                        boundLabelConstantOpt = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 7831, 9405);

                        switch (f_10369_7839_7857(labelSyntax))
                        {

                            case SyntaxKind.CaseSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 7831, 9405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8041, 8092);

                                var
                                caseLabel = (CaseSwitchLabelSyntax)labelSyntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8118, 8156);

                                f_10369_8118_8155(f_10369_8131_8146(caseLabel) != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8182, 8276);

                                var
                                boundLabelExpression = f_10369_8209_8275(sectionBinder, f_10369_8240_8255(caseLabel), tempDiagnosticBag)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8302, 8738) || true) && (boundLabelExpression is BoundTypeExpression type)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 8302, 8738);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 8302, 8738);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 8302, 8738);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8589, 8711);

                                    _ = f_10369_8593_8710(this, labelSyntax, boundLabelExpression, sectionBinder, out boundLabelConstantOpt, tempDiagnosticBag);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 8302, 8738);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10369, 8764, 8770);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 7831, 9405);

                            case SyntaxKind.CasePatternSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 7831, 9405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 8964, 9023);

                                var
                                matchLabel = (CasePatternSwitchLabelSyntax)labelSyntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 9049, 9244);

                                _ = f_10369_9053_9243(sectionBinder, f_10369_9109_9127(matchLabel), f_10369_9129_9148(), f_10369_9150_9174(), permitDesignations: true, f_10369_9202_9223(labelSyntax), tempDiagnosticBag);
                                DynAbs.Tracing.TraceSender.TraceBreak(10369, 9270, 9276);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 7831, 9405);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 7831, 9405);
                                DynAbs.Tracing.TraceSender.TraceBreak(10369, 9380, 9386);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 7831, 9405);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 9469, 9584);

                        f_10369_9469_9583(
                                        // Create the label symbol
                                        labels, f_10369_9480_9582((MethodSymbol)f_10369_9516_9545(this), labelSyntax, boundLabelConstantOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 7696, 9599);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 1904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 1904);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 7461, 9610);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_7839_7857(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 7839, 7857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10369_8131_8146(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 8131, 8146);
                    return return_v;
                }


                int
                f_10369_8118_8155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 8118, 8155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10369_8240_8255(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 8240, 8255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_8209_8275(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeOrRValue(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 8209, 8275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_8593_8710(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                caseExpression, Microsoft.CodeAnalysis.CSharp.Binder
                sectionBinder, out Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertCaseExpression((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, caseExpression, sectionBinder, out constantValueOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 8593, 8710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10369_9109_9127(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 9109, 9127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_9129_9148()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 9129, 9148);
                    return return_v;
                }


                uint
                f_10369_9150_9174()
                {
                    var return_v = SwitchGoverningValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 9150, 9174);
                    return return_v;
                }


                bool
                f_10369_9202_9223(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 9202, 9223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10369_9053_9243(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations: permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 9053, 9243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10369_9516_9545(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 9516, 9545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10369_9480_9582(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMethod, Microsoft.CodeAnalysis.SyntaxNode
                identifierNodeOrToken, Microsoft.CodeAnalysis.ConstantValue?
                switchCaseLabelConstant)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)containingMethod, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)identifierNodeOrToken, switchCaseLabelConstant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 9480, 9582);
                    return return_v;
                }


                int
                f_10369_9469_9583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 9469, 9583);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10369_7724_7736_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 7724, 7736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 7461, 9610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 7461, 9610);
            }
        }

        protected BoundExpression ConvertCaseExpression(CSharpSyntaxNode node, BoundExpression caseExpression, Binder sectionBinder, out ConstantValue constantValueOpt, DiagnosticBag diagnostics, bool isGotoCaseExpr = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 9622, 11653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 9863, 9886);

                bool
                hasErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 9900, 11505) || true) && (isGotoCaseExpr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 9900, 11505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 10637, 10687);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 10705, 10835);

                    Conversion
                    conversion = f_10369_10729_10834(f_10369_10729_10740(), caseExpression, f_10369_10790_10809(), ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 10853, 10895);

                    f_10369_10853_10894(diagnostics, node, useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 10913, 11374) || true) && (f_10369_10917_10936_M(!conversion.IsValid))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 10913, 11374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 10978, 11078);

                        f_10369_10978_11077(this, diagnostics, node, conversion, caseExpression, f_10369_11057_11076());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11100, 11117);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 10913, 11374);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 10913, 11374);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11159, 11374) || true) && (f_10369_11163_11185_M(!conversion.IsImplicit))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 11159, 11374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11227, 11316);

                            f_10369_11227_11315(diagnostics, ErrorCode.WRN_GotoCaseShouldConvert, f_10369_11280_11293(node), f_10369_11295_11314());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11338, 11355);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 11159, 11374);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 10913, 11374);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11394, 11490);

                    caseExpression = f_10369_11411_11489(this, caseExpression, conversion, f_10369_11456_11475(), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 9900, 11505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11521, 11642);

                return f_10369_11528_11641(this, f_10369_11553_11572(), node, caseExpression, out constantValueOpt, hasErrors, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 9622, 11653);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10369_10729_10740()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 10729, 10740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_10790_10809()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 10790, 10809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10369_10729_10834(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 10729, 10834);
                    return return_v;
                }


                bool
                f_10369_10853_10894(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 10853, 10894);
                    return return_v;
                }


                bool
                f_10369_10917_10936_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 10917, 10936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_11057_11076()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11057, 11076);
                    return return_v;
                }


                int
                f_10369_10978_11077(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateImplicitConversionError(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax, conversion, operand, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 10978, 11077);
                    return 0;
                }


                bool
                f_10369_11163_11185_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11163, 11185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10369_11280_11293(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11280, 11293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_11295_11314()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11295, 11314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10369_11227_11315(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 11227, 11315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_11456_11475()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11456, 11475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_11411_11489(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(source, conversion, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 11411, 11489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_11553_11572()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11553, 11572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_11528_11641(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, out Microsoft.CodeAnalysis.ConstantValue
                constantValue, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertPatternExpression(inputType, node, expression, out constantValue, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 11528, 11641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 9622, 11653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 9622, 11653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly object s_nullKey;

        protected static object KeyForConstant(ConstantValue constantValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10369, 11731, 11954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11823, 11867);

                f_10369_11823_11866((object)constantValue != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11881, 11943);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10369, 11888, 11908) || ((f_10369_11888_11908(constantValue) && DynAbs.Tracing.TraceSender.Conditional_F2(10369, 11911, 11920)) || DynAbs.Tracing.TraceSender.Conditional_F3(10369, 11923, 11942))) ? s_nullKey : f_10369_11923_11942(constantValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10369, 11731, 11954);

                int
                f_10369_11823_11866(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 11823, 11866);
                    return 0;
                }


                bool
                f_10369_11888_11908(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11888, 11908);
                    return return_v;
                }


                object?
                f_10369_11923_11942(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 11923, 11942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 11731, 11954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 11731, 11954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SourceLabelSymbol FindMatchingSwitchCaseLabel(ConstantValue constantValue, CSharpSyntaxNode labelSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 11966, 12692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12378, 12389);

                object
                key
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12403, 12629) || true) && ((object)constantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10369, 12407, 12460) && f_10369_12440_12460_M(!constantValue.IsBad)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 12403, 12629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12494, 12530);

                    key = f_10369_12500_12529(constantValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 12403, 12629);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 12403, 12629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12596, 12614);

                    key = labelSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 12403, 12629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12645, 12681);

                return f_10369_12652_12680(this, key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 11966, 12692);

                bool
                f_10369_12440_12460_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 12440, 12460);
                    return return_v;
                }


                object
                f_10369_12500_12529(Microsoft.CodeAnalysis.ConstantValue
                constantValue)
                {
                    var return_v = KeyForConstant(constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 12500, 12529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10369_12652_12680(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, object
                key)
                {
                    var return_v = this_param.FindMatchingSwitchLabel(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 12652, 12680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 11966, 12692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 11966, 12692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourceLabelSymbol GetDefaultLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 12704, 12987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 12931, 12976);

                return f_10369_12938_12975(this, s_defaultKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 12704, 12987);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10369_12938_12975(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, object
                key)
                {
                    var return_v = this_param.FindMatchingSwitchLabel(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 12938, 12975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 12704, 12987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 12704, 12987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourceLabelSymbol FindMatchingSwitchLabel(object key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 12999, 13495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13085, 13111);

                f_10369_13085_13110(key != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13127, 13157);

                var
                labelsMap = f_10369_13143_13156()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13171, 13456) || true) && (labelsMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 13171, 13456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13226, 13250);

                    SourceLabelSymbol
                    label
                    = default(SourceLabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13268, 13441) || true) && (f_10369_13272_13309(labelsMap, key, out label))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 13268, 13441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13351, 13387);

                        f_10369_13351_13386((object)label != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13409, 13422);

                        return label;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 13268, 13441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 13171, 13456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13472, 13484);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 12999, 13495);

                int
                f_10369_13085_13110(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 13085, 13110);
                    return 0;
                }


                System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                f_10369_13143_13156()
                {
                    var return_v = LabelsByValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 13143, 13156);
                    return return_v;
                }


                bool
                f_10369_13272_13309(System.Collections.Generic.Dictionary<object, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol>
                this_param, object
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 13272, 13309);
                    return return_v;
                }


                int
                f_10369_13351_13386(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 13351, 13386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 12999, 13495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 12999, 13495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 13507, 13798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13631, 13734) || true) && (SwitchSyntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 13631, 13734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13700, 13719);

                    return f_10369_13707_13718(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 13631, 13734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13750, 13787);

                throw f_10369_13756_13786();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 13507, 13798);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10369_13707_13718(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 13707, 13718);
                    return return_v;
                }


                System.Exception
                f_10369_13756_13786()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 13756, 13786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 13507, 13798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 13507, 13798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 13810, 14131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 13956, 14067) || true) && (SwitchSyntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 13956, 14067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 14025, 14052);

                    return f_10369_14032_14051(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 13956, 14067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 14083, 14120);

                throw f_10369_14089_14119();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 13810, 14131);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10369_14032_14051(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 14032, 14051);
                    return return_v;
                }


                System.Exception
                f_10369_14089_14119()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 14089, 14119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 13810, 14131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 13810, 14131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 14212, 14283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 14248, 14268);

                    return SwitchSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 14212, 14283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 14143, 14294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 14143, 14294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private BoundExpression BindSwitchGoverningExpression(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 14400, 19582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15063, 15109);

                f_10369_15063_15108(f_10369_15076_15091() == SwitchSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15123, 15171);

                ExpressionSyntax
                node = f_10369_15147_15170(SwitchSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15185, 15219);

                var
                binder = f_10369_15198_15218(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15233, 15262);

                f_10369_15233_15261(binder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15278, 15364);

                var
                switchGoverningExpression = f_10369_15310_15363(binder, node, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15378, 15435);

                var
                switchGoverningType = f_10369_15404_15434(switchGoverningExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 15451, 19028) || true) && ((object)switchGoverningType != null && (DynAbs.Tracing.TraceSender.Expression_True(10369, 15455, 15528) && !f_10369_15495_15528(switchGoverningType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 15451, 19028);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 16640, 19013) || true) && (f_10369_16644_16694(switchGoverningType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 16640, 19013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 16956, 17173) || true) && (f_10369_16960_16991(switchGoverningType) == SpecialType.System_Boolean)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 16956, 17173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17071, 17150);

                            f_10369_17071_17149(node, MessageID.IDS_FeatureSwitchOnBool, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 16956, 17173);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17197, 17230);

                        return switchGoverningExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 16640, 19013);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 16640, 19013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17312, 17346);

                        TypeSymbol
                        resultantGoverningType
                        = default(TypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17368, 17418);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17440, 17618);

                        Conversion
                        conversion = f_10369_17464_17617(f_10369_17464_17482(binder), switchGoverningType, out resultantGoverningType, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17640, 17682);

                        f_10369_17640_17681(diagnostics, node, useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17704, 18994) || true) && (conversion.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 17704, 18994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17828, 17896);

                            f_10369_17828_17895(conversion.Kind == ConversionKind.ImplicitUserDefined);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 17922, 17980);

                            f_10369_17922_17979(f_10369_17935_17978(conversion.Method));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18006, 18066);

                            f_10369_18006_18065(conversion.UserDefinedToConversion.IsIdentity);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18092, 18193);

                            f_10369_18092_18192(f_10369_18105_18191(resultantGoverningType, isTargetTypeOfUserDefinedOp: true));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18219, 18373);

                            return f_10369_18226_18372(binder, node, switchGoverningExpression, conversion, isCast: false, conversionGroupOpt: null, resultantGoverningType, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 17704, 18994);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 17704, 18994);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18423, 18994) || true) && (!f_10369_18428_18460(switchGoverningType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 18423, 18994);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18562, 18748) || true) && (f_10369_18566_18582_M(!PatternsEnabled))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 18562, 18748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18640, 18721);

                                    f_10369_18640_18720(diagnostics, ErrorCode.ERR_V6SwitchGoverningTypeValueExpected, f_10369_18706_18719(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 18562, 18748);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18776, 18809);

                                return switchGoverningExpression;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 18423, 18994);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 18423, 18994);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 18907, 18971);

                                switchGoverningType = f_10369_18929_18970(this, f_10369_18945_18969(switchGoverningType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 18423, 18994);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 17704, 18994);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 16640, 19013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 15451, 19028);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19044, 19373) || true) && (f_10369_19048_19087_M(!switchGoverningExpression.HasAnyErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 19044, 19373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19121, 19229);

                    f_10369_19121_19228((object)f_10369_19142_19172(switchGoverningExpression) == null || (DynAbs.Tracing.TraceSender.Expression_False(10369, 19134, 19227) || f_10369_19184_19227(f_10369_19184_19214(switchGoverningExpression))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19247, 19358);

                    f_10369_19247_19357(diagnostics, ErrorCode.ERR_SwitchExpressionValueExpected, f_10369_19308_19321(node), f_10369_19323_19356(switchGoverningExpression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 19044, 19373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19389, 19571);

                return f_10369_19396_19570(node, LookupResultKind.Empty, ImmutableArray<Symbol>.Empty, f_10369_19479_19527(switchGoverningExpression), switchGoverningType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10369, 19529, 19569) ?? f_10369_19552_19569(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 14400, 19582);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10369_15076_15091()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 15076, 15091);
                    return return_v;
                }


                int
                f_10369_15063_15108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 15063, 15108);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10369_15147_15170(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 15147, 15170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10369_15198_15218(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 15198, 15218);
                    return return_v;
                }


                int
                f_10369_15233_15261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 15233, 15261);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_15310_15363(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 15310, 15363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10369_15404_15434(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 15404, 15434);
                    return return_v;
                }


                bool
                f_10369_15495_15528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 15495, 15528);
                    return return_v;
                }


                bool
                f_10369_16644_16694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidV6SwitchGoverningType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 16644, 16694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10369_16960_16991(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 16960, 16991);
                    return return_v;
                }


                bool
                f_10369_17071_17149(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17071, 17149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10369_17464_17482(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 17464, 17482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10369_17464_17617(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                switchGoverningType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitUserDefinedConversionForV6SwitchGoverningType(sourceType, out switchGoverningType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17464, 17617);
                    return return_v;
                }


                bool
                f_10369_17640_17681(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17640, 17681);
                    return return_v;
                }


                int
                f_10369_17828_17895(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17828, 17895);
                    return 0;
                }


                bool
                f_10369_17935_17978(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol)
                {
                    var return_v = symbol.IsUserDefinedConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17935, 17978);
                    return return_v;
                }


                int
                f_10369_17922_17979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 17922, 17979);
                    return 0;
                }


                int
                f_10369_18006_18065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18006, 18065);
                    return 0;
                }


                bool
                f_10369_18105_18191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isTargetTypeOfUserDefinedOp)
                {
                    var return_v = type.IsValidV6SwitchGoverningType(isTargetTypeOfUserDefinedOp: isTargetTypeOfUserDefinedOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18105, 18191);
                    return return_v;
                }


                int
                f_10369_18092_18192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18092, 18192);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_18226_18372(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isCast, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion((Microsoft.CodeAnalysis.SyntaxNode)syntax, source, conversion, isCast: isCast, conversionGroupOpt: conversionGroupOpt, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18226, 18372);
                    return return_v;
                }


                bool
                f_10369_18428_18460(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18428, 18460);
                    return return_v;
                }


                bool
                f_10369_18566_18582_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 18566, 18582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10369_18706_18719(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 18706, 18719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10369_18640_18720(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18640, 18720);
                    return return_v;
                }


                string
                f_10369_18945_18969(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 18945, 18969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10369_18929_18970(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 18929, 18970);
                    return return_v;
                }


                bool
                f_10369_19048_19087_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19048, 19087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10369_19142_19172(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19142, 19172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10369_19184_19214(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19184, 19214);
                    return return_v;
                }


                bool
                f_10369_19184_19227(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19184, 19227);
                    return return_v;
                }


                int
                f_10369_19121_19228(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19121, 19228);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10369_19308_19321(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19308, 19321);
                    return return_v;
                }


                object
                f_10369_19323_19356(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19323, 19356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10369_19247_19357(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19247, 19357);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10369_19479_19527(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19479, 19527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10369_19552_19569(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19552, 19569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10369_19396_19570(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19396, 19570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 14400, 19582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 14400, 19582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<SyntaxNode, LabelSymbol> _labelsByNode;

        protected Dictionary<SyntaxNode, LabelSymbol> LabelsByNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 19745, 20366);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19781, 20310) || true) && (_labelsByNode == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 19781, 20310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19848, 19903);

                        var
                        result = f_10369_19861_19902()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 19925, 20246);
                            foreach (var label in f_10369_19947_19953_I(f_10369_19947_19953()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 19925, 20246);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20003, 20072);

                                var
                                node = ((SourceLabelSymbol)label).IdentifierNodeOrToken.AsNode()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20098, 20223) || true) && (node != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 20098, 20223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20172, 20196);

                                    f_10369_20172_20195(result, node, label);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 20098, 20223);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 19925, 20246);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10369, 1, 322);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10369, 1, 322);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20268, 20291);

                        _labelsByNode = result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 19781, 20310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20330, 20351);

                    return _labelsByNode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 19745, 20366);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10369_19861_19902()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19861, 19902);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10369_19947_19953()
                    {
                        var return_v = Labels;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 19947, 19953);
                        return return_v;
                    }


                    int
                    f_10369_20172_20195(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 20172, 20195);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10369_19947_19953_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 19947, 19953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 19662, 20377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 19662, 20377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal BoundStatement BindGotoCaseOrDefault(GotoStatementSyntax node, Binder gotoBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10369, 20389, 24387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20531, 20639);

                f_10369_20531_20638(f_10369_20544_20555(node) == SyntaxKind.GotoCaseStatement || (DynAbs.Tracing.TraceSender.Expression_False(10369, 20544, 20637) || f_10369_20591_20602(node) == SyntaxKind.GotoDefaultStatement));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20653, 20698);

                BoundExpression
                gotoCaseExpressionOpt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20760, 24108) || true) && (f_10369_20764_20779_M(!node.HasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 20760, 24108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20813, 20861);

                    ConstantValue
                    gotoCaseExpressionConstant = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20879, 20902);

                    bool
                    hasErrors = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 20920, 20957);

                    SourceLabelSymbol
                    matchedLabelSymbol
                    = default(SourceLabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 21662, 23161) || true) && (f_10369_21666_21681(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 21662, 23161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 21731, 21789);

                        f_10369_21731_21788(f_10369_21744_21755(node) == SyntaxKind.GotoCaseStatement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 21867, 21964);

                        gotoCaseExpressionOpt = f_10369_21891_21963(gotoBinder, f_10369_21912_21927(node), diagnostics, BindValueKind.RValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 21988, 22167);

                        gotoCaseExpressionOpt = f_10369_22012_22166(this, node, gotoCaseExpressionOpt, gotoBinder, out gotoCaseExpressionConstant, diagnostics, isGotoCaseExpr: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22237, 22297);

                        hasErrors = hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10369, 22249, 22296) || f_10369_22262_22296(gotoCaseExpressionOpt));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22321, 22552) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10369, 22325, 22373) && gotoCaseExpressionConstant == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 22321, 22552);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22423, 22486);

                            f_10369_22423_22485(diagnostics, ErrorCode.ERR_ConstantExpected, f_10369_22471_22484(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22512, 22529);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 22321, 22552);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22576, 22664);

                        f_10369_22576_22663(gotoCaseExpressionOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 22855, 22938);

                        matchedLabelSymbol = f_10369_22876_22937(this, gotoCaseExpressionConstant, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 21662, 23161);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 21662, 23161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23020, 23081);

                        f_10369_23020_23080(f_10369_23033_23044(node) == SyntaxKind.GotoDefaultStatement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23103, 23142);

                        matchedLabelSymbol = f_10369_23124_23141(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 21662, 23161);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23181, 24093) || true) && ((object)matchedLabelSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 23181, 24093);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23261, 23896) || true) && (!hasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 23261, 23896);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23396, 23466);

                            var
                            labelName = f_10369_23412_23465(node.CaseOrDefaultKeyword.Kind())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23492, 23688) || true) && (f_10369_23496_23507(node) == SyntaxKind.GotoCaseStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 23492, 23688);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23597, 23661);

                                labelName += " " + f_10369_23616_23660_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10369_23616_23648(gotoCaseExpressionConstant), 10369, 23616, 23660).ToString());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 23492, 23688);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23714, 23731);

                            labelName += ":";
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23759, 23830);

                            f_10369_23759_23829(
                                                    diagnostics, ErrorCode.ERR_LabelNotFound, f_10369_23804_23817(node), labelName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23856, 23873);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 23261, 23896);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 23181, 24093);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10369, 23181, 24093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 23978, 24074);

                        return f_10369_23985_24073(node, matchedLabelSymbol, gotoCaseExpressionOpt, null, hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 23181, 24093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10369, 20760, 24108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 24124, 24376);

                return f_10369_24131_24375(syntax: node, childBoundNodes: (DynAbs.Tracing.TraceSender.Conditional_F1(10369, 24219, 24248) || ((gotoCaseExpressionOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10369, 24251, 24306)) || DynAbs.Tracing.TraceSender.Conditional_F3(10369, 24309, 24340))) ? f_10369_24251_24306(gotoCaseExpressionOpt) : ImmutableArray<BoundNode>.Empty, hasErrors: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10369, 20389, 24387);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_20544_20555(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 20544, 20555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_20591_20602(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 20591, 20602);
                    return return_v;
                }


                int
                f_10369_20531_20638(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 20531, 20638);
                    return 0;
                }


                bool
                f_10369_20764_20779_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 20764, 20779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10369_21666_21681(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 21666, 21681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_21744_21755(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 21744, 21755);
                    return return_v;
                }


                int
                f_10369_21731_21788(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 21731, 21788);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10369_21912_21927(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 21912, 21927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_21891_21963(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 21891, 21963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10369_22012_22166(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                caseExpression, Microsoft.CodeAnalysis.CSharp.Binder
                sectionBinder, out Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isGotoCaseExpr)
                {
                    var return_v = this_param.ConvertCaseExpression((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, caseExpression, sectionBinder, out constantValueOpt, diagnostics, isGotoCaseExpr: isGotoCaseExpr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 22012, 22166);
                    return return_v;
                }


                bool
                f_10369_22262_22296(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 22262, 22296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10369_22471_22484(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 22471, 22484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10369_22423_22485(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 22423, 22485);
                    return return_v;
                }


                int
                f_10369_22576_22663(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ConstantValueUtils.CheckLangVersionForConstantValue(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 22576, 22663);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10369_22876_22937(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.ConstantValue?
                constantValue, Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                labelSyntax)
                {
                    var return_v = this_param.FindMatchingSwitchCaseLabel(constantValue, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)labelSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 22876, 22937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_23033_23044(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23033, 23044);
                    return return_v;
                }


                int
                f_10369_23020_23080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23020, 23080);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10369_23124_23141(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.GetDefaultLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23124, 23141);
                    return return_v;
                }


                string
                f_10369_23412_23465(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23412, 23465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10369_23496_23507(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23496, 23507);
                    return return_v;
                }


                object?
                f_10369_23616_23648(Microsoft.CodeAnalysis.ConstantValue?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 23616, 23648);
                    return return_v;
                }


                string?
                f_10369_23616_23660_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23616, 23660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10369_23804_23817(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 23804, 23817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10369_23759_23829(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23759, 23829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10369_23985_24073(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                caseExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundLabel?
                labelExpressionOpt, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, caseExpressionOpt, labelExpressionOpt, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 23985, 24073);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10369_24251_24306(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create<BoundNode>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 24251, 24306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10369_24131_24375(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, childBoundNodes: childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 24131, 24375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10369, 20389, 24387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 20389, 24387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SwitchBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10369, 602, 24416);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 3066, 3093);
            s_defaultKey = f_10369_3081_3093(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10369, 11696, 11720);
            s_nullKey = f_10369_11708_11720(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10369, 602, 24416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10369, 602, 24416);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10369, 602, 24416);

        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10369_1098_1131(string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1098, 1131);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10369_1012_1016_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10369, 922, 1143);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_10369_1223_1246(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1223, 1246);
            return return_v;
        }


        Microsoft.CodeAnalysis.ParseOptions
        f_10369_1223_1254(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1223, 1254);
            return return_v;
        }


        bool?
        f_10369_1202_1311_I(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1202, 1311);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10369_1699_1724()
        {
            var return_v = SwitchGoverningExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1699, 1724);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10369_1699_1729(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1699, 1729);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10369_1798_1823()
        {
            var return_v = SwitchGoverningExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1798, 1823);
            return return_v;
        }


        uint
        f_10369_1825_1840()
        {
            var return_v = LocalScopeDepth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10369, 1825, 1840);
            return return_v;
        }


        uint
        f_10369_1785_1841(Microsoft.CodeAnalysis.CSharp.BoundExpression
        expr, uint
        scopeOfTheContainingExpression)
        {
            var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 1785, 1841);
            return return_v;
        }


        static object
        f_10369_3081_3093()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 3081, 3093);
            return return_v;
        }


        static object
        f_10369_11708_11720()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10369, 11708, 11720);
            return return_v;
        }

    }
}
