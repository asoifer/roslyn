// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceLabelSymbol : LabelSymbol
    {
        private readonly MethodSymbol _containingMethod;

        private readonly SyntaxNodeOrToken _identifierNodeOrToken;

        private readonly ConstantValue? _switchCaseLabelConstant;

        private string? _lazyName;

        public SourceLabelSymbol(
                    MethodSymbol containingMethod,
                    SyntaxNodeOrToken identifierNodeOrToken,
                    ConstantValue? switchCaseLabelConstant = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10254, 956, 1428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 557, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 815, 839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 934, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1164, 1240);

                f_10254_1164_1239(identifierNodeOrToken.IsToken || (DynAbs.Tracing.TraceSender.Expression_False(10254, 1177, 1238) || identifierNodeOrToken.IsNode));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1254, 1291);

                _containingMethod = containingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1305, 1352);

                _identifierNodeOrToken = identifierNodeOrToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1366, 1417);

                _switchCaseLabelConstant = switchCaseLabelConstant;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10254, 956, 1428);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 956, 1428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 956, 1428);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 1492, 1614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1528, 1599);

                    return _lazyName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10254, 1535, 1598) ?? (_lazyName = f_10254_1582_1597(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 1492, 1614);

                    string
                    f_10254_1582_1597(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                    this_param)
                    {
                        var return_v = this_param.MakeLabelName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 1582, 1597);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 1440, 1625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 1440, 1625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string MakeLabelName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 1637, 2275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1692, 1735);

                var
                node = _identifierNodeOrToken.AsNode()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1749, 2025) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 1749, 2025);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1799, 1967) || true) && (f_10254_1803_1814(node) == SyntaxKind.DefaultSwitchLabel)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 1799, 1967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1889, 1948);

                        return ((DefaultSwitchLabelSyntax)node).Keyword.ToString();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 1799, 1967);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 1987, 2010);

                    return f_10254_1994_2009(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 1749, 2025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2041, 2083);

                var
                tk = _identifierNodeOrToken.AsToken()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2097, 2198) || true) && (tk.Kind() != SyntaxKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 2097, 2198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2163, 2183);

                    return tk.ValueText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 2097, 2198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2214, 2264);

                return f_10254_2221_2257_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_switchCaseLabelConstant, 10254, 2221, 2257)?.ToString()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10254, 2221, 2263) ?? "");
                DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 1637, 2275);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10254_1803_1814(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 1803, 1814);
                    return return_v;
                }


                string
                f_10254_1994_2009(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 1994, 2009);
                    return return_v;
                }


                string?
                f_10254_2221_2257_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 2221, 2257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 1637, 2275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 1637, 2275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceLabelSymbol(
                    MethodSymbol containingMethod,
                    ConstantValue switchCaseLabelConstant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10254, 2287, 2606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 557, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 815, 839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 934, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2433, 2470);

                _containingMethod = containingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2484, 2530);

                _identifierNodeOrToken = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2544, 2595);

                _switchCaseLabelConstant = switchCaseLabelConstant;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10254, 2287, 2606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 2287, 2606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 2287, 2606);
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 2693, 2971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 2729, 2956);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10254, 2736, 2807) || ((_identifierNodeOrToken.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(10254, 2736, 2807) && _identifierNodeOrToken.Parent == null
                    ) && DynAbs.Tracing.TraceSender.Conditional_F2(10254, 2831, 2861)) || DynAbs.Tracing.TraceSender.Conditional_F3(10254, 2885, 2955))) ? ImmutableArray<Location>.Empty
                    : f_10254_2885_2955(_identifierNodeOrToken.GetLocation()!);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 2693, 2971);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10254_2885_2955(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create<Location>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 2885, 2955);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 2618, 2982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 2618, 2982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 3092, 3744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3128, 3158);

                    CSharpSyntaxNode?
                    node = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3178, 3587) || true) && (_identifierNodeOrToken.IsToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 3178, 3587);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3254, 3405) || true) && (_identifierNodeOrToken.Parent != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 3254, 3405);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3322, 3405);

                            node = f_10254_3329_3404(_identifierNodeOrToken.Parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 3254, 3405);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 3178, 3587);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 3178, 3587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3487, 3568);

                        node = f_10254_3494_3567(_identifierNodeOrToken.AsNode()!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 3178, 3587);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3607, 3729);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10254, 3614, 3626) || ((node == null && DynAbs.Tracing.TraceSender.Conditional_F2(10254, 3629, 3666)) || DynAbs.Tracing.TraceSender.Conditional_F3(10254, 3669, 3728))) ? ImmutableArray<SyntaxReference>.Empty : f_10254_3669_3728(f_10254_3708_3727(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 3092, 3744);

                    Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax?
                    f_10254_3329_3404(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 3329, 3404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax?
                    f_10254_3494_3567(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 3494, 3567);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10254_3708_3727(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 3708, 3727);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10254_3669_3728(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 3669, 3728);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 2994, 3755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 2994, 3755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol ContainingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 3837, 3913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 3873, 3898);

                    return _containingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 3837, 3913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 3767, 3924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 3767, 3924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 4000, 4076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 4036, 4061);

                    return _containingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 4000, 4076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 3936, 4087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 3936, 4087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNodeOrToken IdentifierNodeOrToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 4415, 4496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 4451, 4481);

                    return _identifierNodeOrToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 4415, 4496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 4333, 4507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 4333, 4507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ConstantValue? SwitchCaseLabelConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 4783, 4866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 4819, 4851);

                    return _switchCaseLabelConstant;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 4783, 4866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 4713, 4877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 4713, 4877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(Symbol? obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 4889, 5418);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 4983, 5067) || true) && (obj == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10254, 4983, 5067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 5040, 5052);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10254, 4983, 5067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 5083, 5121);

                var
                symbol = obj as SourceLabelSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 5135, 5407);

                return (object?)symbol != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10254, 5142, 5241) && symbol._identifierNodeOrToken.Kind() != SyntaxKind.None
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10254, 5142, 5322) && symbol._identifierNodeOrToken.Equals(_identifierNodeOrToken)) && (DynAbs.Tracing.TraceSender.Expression_True(10254, 5142, 5406) && f_10254_5343_5406(symbol._containingMethod, _containingMethod, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 4889, 5418);

                bool
                f_10254_5343_5406(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 5343, 5406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 4889, 5418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 4889, 5418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10254, 5430, 5543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10254, 5488, 5532);

                return _identifierNodeOrToken.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10254, 5430, 5543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10254, 5430, 5543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 5430, 5543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceLabelSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10254, 457, 5550);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10254, 457, 5550);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10254, 457, 5550);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10254, 457, 5550);

        int
        f_10254_1164_1239(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10254, 1164, 1239);
            return 0;
        }

    }
}
