// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class LockOrUsingBinder : LocalScopeBinder
    {
        private ImmutableHashSet<Symbol> _lazyLockedOrDisposedVariables;

        private ExpressionAndDiagnostics _lazyExpressionAndDiagnostics;

        internal LockOrUsingBinder(Binder enclosing)
        : base(f_10352_899_908_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10352, 834, 931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 718, 748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 792, 821);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10352, 834, 931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10352, 834, 931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 834, 931);
            }
        }

        protected abstract ExpressionSyntax TargetExpressionSyntax { get; }

        internal sealed override ImmutableHashSet<Symbol> LockedOrDisposedVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10352, 1122, 3918);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 1158, 3776) || true) && (_lazyLockedOrDisposedVariables == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 1158, 3776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 1242, 1331);

                        ImmutableHashSet<Symbol>
                        lockedOrDisposedVariables = f_10352_1295_1330(f_10352_1295_1304(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 1355, 1420);

                        ExpressionSyntax
                        targetExpressionSyntax = f_10352_1397_1419()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 1444, 3636) || true) && (targetExpressionSyntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 1444, 3636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 1601, 1787);

                            f_10352_1601_1786(f_10352_1614_1650(f_10352_1614_1643(targetExpressionSyntax)) == SyntaxKind.LockStatement || (DynAbs.Tracing.TraceSender.Expression_False(10352, 1614, 1785) || f_10352_1720_1756(f_10352_1720_1749(targetExpressionSyntax)) == SyntaxKind.UsingStatement));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 2612, 3613) || true) && (f_10352_2616_2645(targetExpressionSyntax) == SyntaxKind.IdentifierName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 2612, 3613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 2732, 2990);

                                BoundExpression
                                expression = f_10352_2761_2989(this, diagnostics: null, originalBinder: f_10352_2948_2988(this, f_10352_2958_2987(targetExpressionSyntax)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3022, 3586);

                                switch (f_10352_3030_3045(expression))
                                {

                                    case BoundKind.Local:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 3022, 3586);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3170, 3266);

                                        lockedOrDisposedVariables = f_10352_3198_3265(lockedOrDisposedVariables, f_10352_3228_3264(((BoundLocal)expression)));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10352, 3304, 3310);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 3022, 3586);

                                    case BoundKind.Parameter:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 3022, 3586);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3407, 3511);

                                        lockedOrDisposedVariables = f_10352_3435_3510(lockedOrDisposedVariables, f_10352_3465_3509(((BoundParameter)expression)));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10352, 3549, 3555);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 3022, 3586);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 2612, 3613);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 1444, 3636);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3660, 3757);

                        f_10352_3660_3756(ref _lazyLockedOrDisposedVariables, lockedOrDisposedVariables, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 1158, 3776);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3794, 3847);

                    f_10352_3794_3846(_lazyLockedOrDisposedVariables != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 3865, 3903);

                    return _lazyLockedOrDisposedVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10352, 1122, 3918);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10352_1295_1304(Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 1295, 1304);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10352_1295_1330(Microsoft.CodeAnalysis.CSharp.Binder?
                    this_param)
                    {
                        var return_v = this_param.LockedOrDisposedVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 1295, 1330);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10352_1397_1419()
                    {
                        var return_v = TargetExpressionSyntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 1397, 1419);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10352_1614_1643(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 1614, 1643);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10352_1614_1650(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 1614, 1650);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10352_1720_1749(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 1720, 1749);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10352_1720_1756(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 1720, 1756);
                        return return_v;
                    }


                    int
                    f_10352_1601_1786(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 1601, 1786);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10352_2616_2645(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 2616, 2645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10352_2958_2987(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 2958, 2987);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10352_2948_2988(Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 2948, 2988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10352_2761_2989(Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Binder?
                    originalBinder)
                    {
                        var return_v = this_param.BindTargetExpression(diagnostics: diagnostics, originalBinder: originalBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 2761, 2989);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10352_3030_3045(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 3030, 3045);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10352_3228_3264(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 3228, 3264);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10352_3198_3265(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 3198, 3265);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10352_3465_3509(Microsoft.CodeAnalysis.CSharp.BoundParameter
                    this_param)
                    {
                        var return_v = this_param.ParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 3465, 3509);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10352_3435_3510(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 3435, 3510);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    f_10352_3660_3756(ref System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    location1, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    value, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 3660, 3756);
                        return return_v;
                    }


                    int
                    f_10352_3794_3846(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 3794, 3846);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10352, 1022, 3929);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 1022, 3929);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected BoundExpression BindTargetExpression(DiagnosticBag diagnostics, Binder originalBinder, TypeSymbol targetTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10352, 3941, 5335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4095, 5042) || true) && (_lazyExpressionAndDiagnostics == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 4095, 5042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4229, 4295);

                    DiagnosticBag
                    expressionDiagnostics = f_10352_4267_4294()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4313, 4461);

                    BoundExpression
                    boundExpression = f_10352_4347_4460(originalBinder, f_10352_4372_4394(), expressionDiagnostics, Binder.BindValueKind.RValueOrMethodGroup)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4479, 4850) || true) && (targetTypeOpt is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 4479, 4850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4548, 4668);

                        boundExpression = f_10352_4566_4667(originalBinder, targetTypeOpt, boundExpression, expressionDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 4479, 4850);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 4479, 4850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4750, 4831);

                        boundExpression = f_10352_4768_4830(originalBinder, boundExpression, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 4479, 4850);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 4868, 5027);

                    f_10352_4868_5026(ref _lazyExpressionAndDiagnostics, f_10352_4931_5019(boundExpression, f_10352_4977_5018(expressionDiagnostics)), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 4095, 5042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5056, 5108);

                f_10352_5056_5107(_lazyExpressionAndDiagnostics != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5124, 5260) || true) && (diagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10352, 5124, 5260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5181, 5245);

                    f_10352_5181_5244(diagnostics, _lazyExpressionAndDiagnostics.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10352, 5124, 5260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5276, 5324);

                return _lazyExpressionAndDiagnostics.Expression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10352, 3941, 5335);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10352_4267_4294()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4267, 4294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10352_4372_4394()
                {
                    var return_v = TargetExpressionSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10352, 4372, 4394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10352_4347_4460(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4347, 4460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10352_4566_4667(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4566, 4667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10352_4768_4830(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4768, 4830);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10352_4977_5018(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4977, 5018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics
                f_10352_4931_5019(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4931, 5019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics?
                f_10352_4868_5026(ref Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics?
                location1, Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics
                value, Microsoft.CodeAnalysis.CSharp.LockOrUsingBinder.ExpressionAndDiagnostics?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 4868, 5026);
                    return return_v;
                }


                int
                f_10352_5056_5107(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 5056, 5107);
                    return 0;
                }


                int
                f_10352_5181_5244(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10352, 5181, 5244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10352, 3941, 5335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 3941, 5335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class ExpressionAndDiagnostics
        {
            public readonly BoundExpression Expression;

            public readonly ImmutableArray<Diagnostic> Diagnostics;

            public ExpressionAndDiagnostics(BoundExpression expression, ImmutableArray<Diagnostic> diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10352, 5807, 6032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5711, 5721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5939, 5968);

                    this.Expression = expression;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10352, 5986, 6017);

                    this.Diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10352, 5807, 6032);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10352, 5807, 6032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 5807, 6032);
                }
            }

            static ExpressionAndDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10352, 5616, 6043);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10352, 5616, 6043);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 5616, 6043);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10352, 5616, 6043);
        }

        static LockOrUsingBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10352, 608, 6050);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10352, 608, 6050);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10352, 608, 6050);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10352, 608, 6050);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10352_899_908_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10352, 834, 931);
            return return_v;
        }

    }
}
