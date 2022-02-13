// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SwitchExpressionArmBinder : Binder
    {
        private readonly SwitchExpressionArmSyntax _arm;

        private readonly ExpressionVariableBinder _armScopeBinder;

        private readonly SwitchExpressionBinder _switchExpressionBinder;

        public SwitchExpressionArmBinder(SwitchExpressionArmSyntax arm, ExpressionVariableBinder armScopeBinder, SwitchExpressionBinder switchExpressionBinder) : base(f_10371_1282_1296_C(armScopeBinder))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10371, 1123, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 964, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1021, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1087, 1110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1322, 1338);

                this._arm = arm;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1352, 1390);

                this._armScopeBinder = armScopeBinder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1404, 1458);

                this._switchExpressionBinder = switchExpressionBinder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10371, 1123, 1469);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10371, 1123, 1469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10371, 1123, 1469);
            }
        }

        internal override BoundSwitchExpressionArm BindSwitchExpressionArm(SwitchExpressionArmSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10371, 1481, 2592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1631, 1658);

                f_10371_1631_1657(node == _arm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1672, 1712);

                Binder
                armBinder = f_10371_1691_1711(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1726, 1801);

                bool
                hasErrors = f_10371_1743_1800(f_10371_1743_1786(_switchExpressionBinder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1815, 1875);

                ImmutableArray<LocalSymbol>
                locals = f_10371_1852_1874(_armScopeBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 1889, 2093);

                BoundPattern
                pattern = f_10371_1912_2092(armBinder, f_10371_1934_1946(node), f_10371_1948_1991(_switchExpressionBinder), f_10371_1993_2041(_switchExpressionBinder), permitDesignations: true, hasErrors, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 2107, 2275);

                BoundExpression
                whenClause = (DynAbs.Tracing.TraceSender.Conditional_F1(10371, 2136, 2159) || ((f_10371_2136_2151(node) != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10371, 2179, 2250)) || DynAbs.Tracing.TraceSender.Conditional_F3(10371, 2270, 2274))) ? f_10371_2179_2250(armBinder, f_10371_2211_2236(f_10371_2211_2226(node)), diagnostics) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 2289, 2389);

                BoundExpression
                armResult = f_10371_2317_2388(armBinder, f_10371_2337_2352(node), diagnostics, BindValueKind.RValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 2403, 2447);

                var
                label = f_10371_2415_2446("arm")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10371, 2461, 2581);

                return f_10371_2468_2580(node, locals, pattern, whenClause, armResult, label, hasErrors | f_10371_2562_2579(pattern));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10371, 1481, 2592);

                int
                f_10371_1631_1657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 1631, 1657);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10371_1691_1711(Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 1691, 1711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10371_1743_1786(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 1743, 1786);
                    return return_v;
                }


                bool
                f_10371_1743_1800(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 1743, 1800);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10371_1852_1874(Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 1852, 1874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10371_1934_1946(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 1934, 1946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10371_1948_1991(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 1948, 1991);
                    return return_v;
                }


                uint
                f_10371_1993_2041(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.SwitchGoverningValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 1993, 2041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10371_1912_2092(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations: permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 1912, 2092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10371_2136_2151(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 2136, 2151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                f_10371_2211_2226(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 2211, 2226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10371_2211_2236(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 2211, 2236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10371_2179_2250(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBooleanExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 2179, 2250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10371_2337_2352(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 2337, 2352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10371_2317_2388(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 2317, 2388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10371_2415_2446(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 2415, 2446);
                    return return_v;
                }


                bool
                f_10371_2562_2579(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10371, 2562, 2579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                f_10371_2468_2580(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm((Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, pattern, whenClause, value, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10371, 2468, 2580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10371, 1481, 2592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10371, 1481, 2592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SwitchExpressionArmBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10371, 855, 2599);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10371, 855, 2599);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10371, 855, 2599);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10371, 855, 2599);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10371_1282_1296_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10371, 1123, 1469);
            return return_v;
        }

    }
}
