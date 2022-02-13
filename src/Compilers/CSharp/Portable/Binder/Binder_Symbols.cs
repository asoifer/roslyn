// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal TypeWithAnnotations BindTypeOrVarKeyword(TypeSyntax syntax, DiagnosticBag diagnostics, out bool isVar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 1427, 1801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 1563, 1636);

                var
                symbol = f_10319_1576_1635(this, syntax, diagnostics, out isVar)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 1650, 1690);

                f_10319_1650_1689(isVar == symbol.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 1704, 1790);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 1711, 1716) || ((isVar && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 1719, 1726)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 1729, 1789))) ? default : f_10319_1729_1769(this, symbol, diagnostics, syntax).TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 1427, 1801);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_1576_1635(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar)
                {
                    var return_v = this_param.BindTypeOrAliasOrVarKeyword(syntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 1576, 1635);
                    return return_v;
                }


                int
                f_10319_1650_1689(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 1650, 1689);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_1729_1769(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.UnwrapAlias(symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 1729, 1769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 1427, 1801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 1427, 1801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations BindTypeOrConstraintKeyword(TypeSyntax syntax, DiagnosticBag diagnostics, out ConstraintContextualKeyword keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 2537, 3031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 2704, 2786);

                var
                symbol = f_10319_2717_2785(this, syntax, diagnostics, out keyword)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 2800, 2880);

                f_10319_2800_2879((keyword != ConstraintContextualKeyword.None) == symbol.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 2894, 3020);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 2901, 2946) || (((keyword != ConstraintContextualKeyword.None) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 2949, 2956)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 2959, 3019))) ? default : f_10319_2959_2999(this, symbol, diagnostics, syntax).TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 2537, 3031);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_2717_2785(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Binder.ConstraintContextualKeyword
                keyword)
                {
                    var return_v = this_param.BindTypeOrAliasOrConstraintKeyword(syntax, diagnostics, out keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 2717, 2785);
                    return return_v;
                }


                int
                f_10319_2800_2879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 2800, 2879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_2959_2999(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.UnwrapAlias(symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 2959, 2999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 2537, 3031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 2537, 3031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations BindTypeOrVarKeyword(TypeSyntax syntax, DiagnosticBag diagnostics, out bool isVar, out AliasSymbol alias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 3811, 4371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 3970, 4043);

                var
                symbol = f_10319_3983_4042(this, syntax, diagnostics, out isVar)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 4057, 4097);

                f_10319_4057_4096(isVar == symbol.IsDefault);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 4111, 4360) || true) && (isVar)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 4111, 4360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 4154, 4167);

                    alias = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 4185, 4200);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 4111, 4360);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 4111, 4360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 4266, 4345);

                    return f_10319_4273_4324(this, symbol, out alias, diagnostics, syntax).TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 4111, 4360);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 3811, 4371);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_3983_4042(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar)
                {
                    var return_v = this_param.BindTypeOrAliasOrVarKeyword(syntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 3983, 4042);
                    return return_v;
                }


                int
                f_10319_4057_4096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 4057, 4096);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_4273_4324(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.UnwrapAlias(symbol, out alias, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 4273, 4324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 3811, 4371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 3811, 4371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindTypeOrAliasOrVarKeyword(TypeSyntax syntax, DiagnosticBag diagnostics, out bool isVar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 5207, 5915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5373, 5904) || true) && (f_10319_5377_5389(syntax))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 5373, 5904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5423, 5515);

                    var
                    symbol = f_10319_5436_5514(this, syntax, diagnostics, out isVar)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5535, 5687) || true) && (isVar)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 5535, 5687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5586, 5668);

                        f_10319_5586_5667(syntax, MessageID.IDS_FeatureImplicitLocal, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 5535, 5687);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5707, 5721);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 5373, 5904);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 5373, 5904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5787, 5801);

                    isVar = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 5819, 5889);

                    return f_10319_5826_5888(this, syntax, diagnostics, basesBeingResolved: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 5373, 5904);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 5207, 5915);

                bool
                f_10319_5377_5389(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 5377, 5389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_5436_5514(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isKeyword)
                {
                    var return_v = this_param.BindTypeOrAliasOrKeyword((Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax)syntax, diagnostics, out isKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 5436, 5514);
                    return return_v;
                }


                bool
                f_10319_5586_5667(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 5586, 5667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_5826_5888(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 5826, 5888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 5207, 5915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 5207, 5915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum ConstraintContextualKeyword
        {
            None,
            Unmanaged,
            NotNull,
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindTypeOrAliasOrConstraintKeyword(TypeSyntax syntax, DiagnosticBag diagnostics, out ConstraintContextualKeyword keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 6066, 7947);
                bool isKeyword = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6264, 6626) || true) && (f_10319_6268_6286(syntax))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6264, 6626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6320, 6368);

                    keyword = ConstraintContextualKeyword.Unmanaged;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6264, 6626);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6264, 6626);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6402, 6626) || true) && (f_10319_6406_6422(syntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6402, 6626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6456, 6502);

                        keyword = ConstraintContextualKeyword.NotNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6402, 6626);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6402, 6626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6568, 6611);

                        keyword = ConstraintContextualKeyword.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6402, 6626);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6264, 6626);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6642, 7936) || true) && (keyword != ConstraintContextualKeyword.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6642, 7936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6723, 6775);

                    var
                    identifierSyntax = (IdentifierNameSyntax)syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6793, 6882);

                    var
                    symbol = f_10319_6806_6881(this, identifierSyntax, diagnostics, out isKeyword)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6902, 7751) || true) && (isKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6902, 7751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 6957, 7607);

                        switch (keyword)
                        {

                            case ConstraintContextualKeyword.Unmanaged:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6957, 7607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7095, 7194);

                                f_10319_7095_7193(syntax, MessageID.IDS_FeatureUnmanagedGenericTypeConstraint, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10319, 7224, 7230);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6957, 7607);

                            case ConstraintContextualKeyword.NotNull:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6957, 7607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7327, 7434);

                                f_10319_7327_7433(identifierSyntax, MessageID.IDS_FeatureNotNullGenericTypeConstraint, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10319, 7464, 7470);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6957, 7607);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6957, 7607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7534, 7584);

                                throw f_10319_7540_7583(keyword);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6957, 7607);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6902, 7751);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6902, 7751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7689, 7732);

                        keyword = ConstraintContextualKeyword.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6902, 7751);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7771, 7785);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6642, 7936);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 6642, 7936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 7851, 7921);

                    return f_10319_7858_7920(this, syntax, diagnostics, basesBeingResolved: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 6642, 7936);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 6066, 7947);

                bool
                f_10319_6268_6286(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsUnmanaged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 6268, 6286);
                    return return_v;
                }


                bool
                f_10319_6406_6422(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 6406, 6422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_6806_6881(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isKeyword)
                {
                    var return_v = this_param.BindTypeOrAliasOrKeyword(syntax, diagnostics, out isKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 6806, 6881);
                    return return_v;
                }


                bool
                f_10319_7095_7193(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 7095, 7193);
                    return return_v;
                }


                bool
                f_10319_7327_7433(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 7327, 7433);
                    return return_v;
                }


                System.Exception
                f_10319_7540_7583(Microsoft.CodeAnalysis.CSharp.Binder.ConstraintContextualKeyword
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 7540, 7583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_7858_7920(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 7858, 7920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 6066, 7947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 6066, 7947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindTypeOrAliasOrKeyword(IdentifierNameSyntax syntax, DiagnosticBag diagnostics, out bool isKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 8489, 8788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 8666, 8777);

                return f_10319_8673_8776(this, f_10319_8698_8739(((IdentifierNameSyntax)syntax)), syntax, diagnostics, out isKeyword);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 8489, 8788);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_8698_8739(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 8698, 8739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_8673_8776(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isKeyword)
                {
                    var return_v = this_param.BindTypeOrAliasOrKeyword(identifier, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics, out isKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 8673, 8776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 8489, 8788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 8489, 8788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindTypeOrAliasOrKeyword(SyntaxToken identifier, SyntaxNode syntax, DiagnosticBag diagnostics, out bool isKeyword)
        {
            // Keywords can only be IdentifierNameSyntax
            var identifierValueText = identifier.ValueText;
            Symbol symbol = null;

            // Perform name lookup without generating diagnostics as it could possibly be a keyword in the current context.
            var lookupResult = LookupResult.GetInstance();
            HashSet<DiagnosticInfo> useSiteDiagnostics = null;
            this.LookupSymbolsInternal(lookupResult, identifierValueText, arity: 0, useSiteDiagnostics: ref useSiteDiagnostics, basesBeingResolved: null, options: LookupOptions.NamespacesOrTypesOnly, diagnose: false);

            // We have following possible cases for lookup:

            //  1) LookupResultKind.Empty: must be a keyword

            //  2) LookupResultKind.Viable:
            //      a) Single viable result that corresponds to 1) a non-error type: cannot be a keyword
            //                                                  2) an error type: must be a keyword
            //      b) Single viable result that corresponds to namespace: must be a keyword
            //      c) Multi viable result (ambiguous result), we must return an error type: cannot be a keyword

            // 3) Non viable, non empty lookup result: must be a keyword

            // BREAKING CHANGE:     Case (2)(c) is a breaking change from the native compiler.
            // BREAKING CHANGE:     Native compiler interprets lookup with ambiguous result to correspond to bind
            // BREAKING CHANGE:     to "var" keyword (isVar = true), rather than reporting an error.
            // BREAKING CHANGE:     See test SemanticErrorTests.ErrorMeansSuccess_var() for an example.

            switch (lookupResult.Kind)
            {
                case LookupResultKind.Empty:
                    // Case (1)
                    isKeyword = true;
                    symbol = null;
                    break;

                case LookupResultKind.Viable:
                    // Case (2)
                    var resultDiagnostics = DiagnosticBag.GetInstance();
                    bool wasError;
                    symbol = ResultSymbol(
                        lookupResult,
                        identifierValueText,
                        arity: 0,
                        where: syntax,
                        diagnostics: resultDiagnostics,
                        suppressUseSiteDiagnostics: false,
                        wasError: out wasError);

                    // Here, we're mimicking behavior of dev10.  If the identifier fails to bind
                    // as a type, even if the reason is (e.g.) a type/alias conflict, then treat
                    // it as the contextual keyword.
                    if (wasError && lookupResult.IsSingleViable)
                    {
                        // NOTE: don't report diagnostics - we're not going to use the lookup result.
                        resultDiagnostics.Free();
                        // Case (2)(a)(2)
                        goto default;
                    }

                    diagnostics.AddRange(resultDiagnostics);
                    resultDiagnostics.Free();

                    if (lookupResult.IsSingleViable)
                    {
                        var type = UnwrapAlias(symbol, diagnostics, syntax) as TypeSymbol;

                        if ((object)type != null)
                        {
                            // Case (2)(a)(1)
                            isKeyword = false;
                        }
                        else
                        {
                            // Case (2)(b)
                            Debug.Assert(UnwrapAliasNoDiagnostics(symbol) is NamespaceSymbol);
                            isKeyword = true;
                            symbol = null;
                        }
                    }
                    else
                    {
                        // Case (2)(c)
                        isKeyword = false;
                    }

                    break;

                default:
                    // Case (3)
                    isKeyword = true;
                    symbol = null;
                    break;
            }

            lookupResult.Free();

            return NamespaceOrTypeOrAliasSymbolWithAnnotations.CreateUnannotated(AreNullableAnnotationsEnabled(identifier), symbol);
        }

        internal TypeWithAnnotations BindType(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved = null, bool suppressUseSiteDiagnostics = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 13647, 14061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 13850, 13948);

                var
                symbol = f_10319_13863_13947(this, syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 13962, 14050);

                return f_10319_13969_14029(this, symbol, diagnostics, syntax, basesBeingResolved).TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 13647, 14061);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_13863_13947(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindTypeOrAlias(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 13863, 13947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_13969_14029(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 13969, 14029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 13647, 14061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 13647, 14061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations BindType(ExpressionSyntax syntax, DiagnosticBag diagnostics, out AliasSymbol alias, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 14297, 14676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 14482, 14552);

                var
                symbol = f_10319_14495_14551(this, syntax, diagnostics, basesBeingResolved)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 14566, 14665);

                return f_10319_14573_14644(this, symbol, out alias, diagnostics, syntax, basesBeingResolved).TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 14297, 14676);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_14495_14551(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias(syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 14495, 14551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_14573_14644(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, out alias, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 14573, 14644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 14297, 14676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 14297, 14676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceOrTypeOrAliasSymbolWithAnnotations BindTypeOrAlias(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved = null, bool suppressUseSiteDiagnostics = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 14862, 16302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15096, 15130);

                f_10319_15096_15129(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15146, 15291);

                var
                symbol = f_10319_15159_15290(this, syntax, diagnostics, basesBeingResolved, basesBeingResolved != null || (DynAbs.Tracing.TraceSender.Expression_False(10319, 15233, 15289) || suppressUseSiteDiagnostics))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15379, 15933) || true) && (symbol.IsType || (DynAbs.Tracing.TraceSender.Expression_False(10319, 15383, 15510) || (symbol.IsAlias && (DynAbs.Tracing.TraceSender.Expression_True(10319, 15418, 15509) && f_10319_15436_15495(symbol.Symbol, basesBeingResolved) is TypeSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 15379, 15933);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15544, 15884) || true) && (symbol.IsType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 15544, 15884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15783, 15865);

                        symbol.TypeWithAnnotations.ReportDiagnosticsIfObsolete(this, syntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 15544, 15884);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15904, 15918);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 15379, 15933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 15949, 16100);

                var
                diagnosticInfo = f_10319_15970_16099(diagnostics, ErrorCode.ERR_BadSKknown, f_10319_16012_16027(syntax), syntax, f_10319_16037_16064(symbol.Symbol), f_10319_16066_16098(MessageID.IDS_SK_TYPE))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 16114, 16291);

                return TypeWithAnnotations.Create(f_10319_16148_16289(f_10319_16176_16219(this, symbol.Symbol), symbol.Symbol, LookupResultKind.NotATypeOrNamespace, diagnosticInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 14862, 16302);

                int
                f_10319_15096_15129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 15096, 15129);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_15159_15290(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeOrAliasSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 15159, 15290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_15436_15495(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = UnwrapAliasNoDiagnostics(symbol, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 15436, 15495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_16012_16027(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16012, 16027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10319_16037_16064(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetKindText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 16037, 16064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10319_16066_16098(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 16066, 16098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_15970_16099(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 15970, 16099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_16176_16219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetContainingNamespaceOrType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 16176, 16219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_16148_16289(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 16148, 16289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 14862, 16302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 14862, 16302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeSymbol GetContainingNamespaceOrType(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 16522, 16718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 16620, 16707);

                return f_10319_16627_16661(symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?>(10319, 16627, 16706) ?? f_10319_16665_16706(f_10319_16665_16690(f_10319_16665_16681(this))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 16522, 16718);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                f_10319_16627_16661(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ContainingNamespaceOrType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 16627, 16661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_16665_16681(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16665, 16681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_16665_16690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16665, 16690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10319_16665_16706(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16665, 16706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 16522, 16718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 16522, 16718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Symbol BindNamespaceAliasSymbol(IdentifierNameSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 16730, 17707);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 16849, 17696) || true) && (node.Identifier.Kind() == SyntaxKind.GlobalKeyword)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 16849, 17696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 16937, 16982);

                    return f_10319_16944_16981(f_10319_16944_16960(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 16849, 17696);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 16849, 17696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17048, 17062);

                    bool
                    wasError
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17080, 17122);

                    var
                    plainName = node.Identifier.ValueText
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17140, 17180);

                    var
                    result = f_10319_17153_17179()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17198, 17248);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17266, 17385);

                    f_10319_17266_17384(this, result, plainName, 0, ref useSiteDiagnostics, null, LookupOptions.NamespaceAliasesOnly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17403, 17445);

                    f_10319_17403_17444(diagnostics, node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17465, 17608);

                    Symbol
                    bindingResult = f_10319_17488_17607(this, result, plainName, 0, node, diagnostics, false, out wasError, options: LookupOptions.NamespaceAliasesOnly)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17626, 17640);

                    f_10319_17626_17639(result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17660, 17681);

                    return bindingResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 16849, 17696);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 16730, 17707);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_16944_16960(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16944, 16960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10319_16944_16981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 16944, 16981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10319_17153_17179()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17153, 17179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10319_17266_17384(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.LookupSymbolsWithFallback(result, name, arity, ref useSiteDiagnostics, basesBeingResolved, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17266, 17384);
                    return return_v;
                }


                bool
                f_10319_17403_17444(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17403, 17444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_17488_17607(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                simpleName, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                where, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics, out bool
                wasError, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.ResultSymbol(result, simpleName, arity, (Microsoft.CodeAnalysis.SyntaxNode)where, diagnostics, suppressUseSiteDiagnostics, out wasError, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17488, 17607);
                    return return_v;
                }


                int
                f_10319_17626_17639(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17626, 17639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 16730, 17707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 16730, 17707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceOrTypeOrAliasSymbolWithAnnotations BindNamespaceOrTypeSymbol(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 17719, 18035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 17922, 18024);

                return f_10319_17929_18023(this, syntax, diagnostics, basesBeingResolved, basesBeingResolved != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 17719, 18035);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_17929_18023(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 17929, 18023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 17719, 18035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 17719, 18035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        internal NamespaceOrTypeOrAliasSymbolWithAnnotations BindNamespaceOrTypeSymbol(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved, bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 18300, 18837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 18581, 18696);

                var
                result = f_10319_18594_18695(this, syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 18710, 18742);

                f_10319_18710_18741(f_10319_18723_18740_M(!result.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 18758, 18826);

                return f_10319_18765_18825(this, result, diagnostics, syntax, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 18300, 18837);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_18594_18695(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeOrAliasSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 18594, 18695);
                    return return_v;
                }


                bool
                f_10319_18723_18740_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 18723, 18740);
                    return return_v;
                }


                int
                f_10319_18710_18741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 18710, 18741);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_18765_18825(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 18765, 18825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 18300, 18837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 18300, 18837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceOrTypeOrAliasSymbolWithAnnotations BindNamespaceOrTypeOrAliasSymbol(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved, bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 19916, 30085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20152, 24647);

                switch (f_10319_20160_20173(syntax))
                {

                    case SyntaxKind.NullableType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20258, 20319);

                        return f_10319_20265_20318(syntax, diagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.PredefinedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20392, 20435);

                        return f_10319_20399_20434(syntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20508, 20675);

                        return f_10319_20515_20674(this, syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20745, 20878);

                        return f_10319_20752_20877(this, syntax, diagnostics, basesBeingResolved, qualifierOpt: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 20955, 21041);

                        return f_10319_20962_21040(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21140, 21179);

                            var
                            node = (QualifiedNameSyntax)syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21205, 21314);

                            return f_10319_21212_21313(this, f_10319_21230_21239(node), f_10319_21241_21251(node), diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.SimpleMemberAccessExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21451, 21499);

                            var
                            node = (MemberAccessExpressionSyntax)syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21525, 21639);

                            return f_10319_21532_21638(this, f_10319_21550_21565(node), f_10319_21567_21576(node), diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21757, 21892);

                            return f_10319_21764_21891(this, syntax, diagnostics, permitDimensions: false, basesBeingResolved, disallowRestrictedTypes: true);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 21985, 22045);

                        return f_10319_21992_22044(syntax, diagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22123, 22189);

                        var
                        functionPointerTypeSyntax = (FunctionPointerTypeSyntax)syntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22211, 22721) || true) && (f_10319_22215_22259(this, sizeOfTypeOpt: null) is CSDiagnosticInfo info)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 22211, 22721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22334, 22392);

                            var
                            @delegate = f_10319_22350_22391(functionPointerTypeSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22418, 22473);

                            var
                            asterisk = f_10319_22433_22472(functionPointerTypeSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22499, 22550);

                            f_10319_22499_22549(@delegate.SyntaxTree is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22576, 22698);

                            f_10319_22576_22697(diagnostics, info, f_10319_22598_22696(@delegate.SyntaxTree, TextSpan.FromBounds(@delegate.SpanStart, asterisk.Span.End)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 22211, 22721);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 22745, 23089);

                        return TypeWithAnnotations.Create(f_10319_22805_23087(functionPointerTypeSyntax, this, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.OmittedTypeArgument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23194, 23271);

                            return f_10319_23201_23270(this, syntax, diagnostics, basesBeingResolved);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.TupleType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23389, 23435);

                            var
                            tupleTypeSyntax = (TupleTypeSyntax)syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23461, 23624);

                            return TypeWithAnnotations.Create(f_10319_23495_23557(this, f_10319_23525_23556(tupleTypeSyntax)), f_10319_23559_23622(this, tupleTypeSyntax, diagnostics, basesBeingResolved));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    case SyntaxKind.RefType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23806, 23848);

                            var
                            refTypeSyntax = (RefTypeSyntax)syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23874, 23914);

                            var
                            refToken = f_10319_23889_23913(refTypeSyntax)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 23940, 24138) || true) && (f_10319_23944_23961_M(!syntax.HasErrors))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 23940, 24138);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24019, 24111);

                                f_10319_24019_24110(diagnostics, ErrorCode.ERR_UnexpectedToken, refToken.GetLocation(), refToken.ToString());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 23940, 24138);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24166, 24287);

                            return f_10319_24173_24286(this, f_10319_24206_24224(refTypeSyntax), diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 20152, 24647);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24578, 24609);

                            return f_10319_24585_24608(syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 20152, 24647);
                }

                void reportNullableReferenceTypesIfNeeded(SyntaxToken questionToken, DiagnosticBag diagnostics, TypeWithAnnotations typeArgument = default)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 24663, 25918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24835, 24905);

                        bool
                        isNullableEnabled = f_10319_24860_24904(this, questionToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24923, 24977);

                        bool
                        isGeneratedCode = f_10319_24946_24976(this, questionToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 24995, 25038);

                        var
                        location = questionToken.GetLocation()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 25177, 25903) || true) && (typeArgument.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 25181, 25228) && f_10319_25205_25228_M(!ShouldCheckConstraints)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 25177, 25903);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 25270, 25521);

                            f_10319_25270_25520(isNullableEnabled, isGeneratedCode, typeArgument, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 25177, 25903);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 25177, 25903);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 25603, 25884);

                            f_10319_25603_25883(isNullableEnabled, isGeneratedCode, typeArgument, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 25177, 25903);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 24663, 25918);

                        bool
                        f_10319_24860_24904(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxToken
                        token)
                        {
                            var return_v = this_param.AreNullableAnnotationsEnabled(token);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 24860, 24904);
                            return return_v;
                        }


                        bool
                        f_10319_24946_24976(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxToken
                        token)
                        {
                            var return_v = this_param.IsGeneratedCode(token);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 24946, 24976);
                            return return_v;
                        }


                        bool
                        f_10319_25205_25228_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 25205, 25228);
                            return return_v;
                        }


                        int
                        f_10319_25270_25520(bool
                        isNullableEnabled, bool
                        isGeneratedCode, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        type, Microsoft.CodeAnalysis.Location
                        location, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            LazyMissingNonNullTypesContextDiagnosticInfo.AddAll(isNullableEnabled, isGeneratedCode, type, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 25270, 25520);
                            return 0;
                        }


                        int
                        f_10319_25603_25883(bool
                        isNullableEnabled, bool
                        isGeneratedCode, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        type, Microsoft.CodeAnalysis.Location
                        location, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            LazyMissingNonNullTypesContextDiagnosticInfo.ReportNullableReferenceTypesIfNeeded(isNullableEnabled, isGeneratedCode, type, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 25603, 25883);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 24663, 25918);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 24663, 25918);
                    }
                }

                NamespaceOrTypeOrAliasSymbolWithAnnotations bindNullable(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 25934, 27631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26116, 26164);

                        var
                        nullableSyntax = (NullableTypeSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26182, 26241);

                        TypeSyntax
                        typeArgumentSyntax = f_10319_26214_26240(nullableSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26259, 26356);

                        TypeWithAnnotations
                        typeArgument = f_10319_26294_26355(this, typeArgumentSyntax, diagnostics, basesBeingResolved)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26374, 26453);

                        TypeWithAnnotations
                        constructedType = typeArgument.SetIsAnnotated(f_10319_26440_26451())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26473, 26567);

                        f_10319_26473_26566(f_10319_26510_26538(nullableSyntax), diagnostics, typeArgument);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26587, 27573) || true) && (f_10319_26591_26614_M(!ShouldCheckConstraints))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 26587, 27573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26656, 26787);

                            f_10319_26656_26786(diagnostics, f_10319_26672_26763(f_10319_26718_26745(f_10319_26718_26729()), constructedType), f_10319_26765_26785(syntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 26587, 27573);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 26587, 27573);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26829, 27573) || true) && (constructedType.IsNullableType())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 26829, 27573);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 26907, 26994);

                                f_10319_26907_26993(f_10319_26932_26971(constructedType.Type), diagnostics, syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27016, 27065);

                                var
                                type = (NamedTypeSymbol)constructedType.Type
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27087, 27118);

                                var
                                location = f_10319_27102_27117(syntax)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27140, 27291);

                                type.CheckConstraints(f_10319_27162_27289(f_10319_27205_27221(this), f_10319_27223_27239(this), includeNullability: true, location, diagnostics));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 26829, 27573);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 26829, 27573);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27333, 27573) || true) && (f_10319_27337_27441(f_10319_27396_27423(f_10319_27396_27407()), constructedType) is { } diagnosticInfo)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 27333, 27573);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27505, 27554);

                                    f_10319_27505_27553(diagnostics, diagnosticInfo, f_10319_27537_27552(syntax));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 27333, 27573);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 26829, 27573);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 26587, 27573);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27593, 27616);

                        return constructedType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 25934, 27631);

                        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                        f_10319_26214_26240(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax
                        this_param)
                        {
                            var return_v = this_param.ElementType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26214, 26240);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10319_26294_26355(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                        syntax, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        basesBeingResolved)
                        {
                            var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26294, 26355);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_26440_26451()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26440, 26451);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxToken
                        f_10319_26510_26538(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax
                        this_param)
                        {
                            var return_v = this_param.QuestionToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26510, 26538);
                            return return_v;
                        }


                        int
                        f_10319_26473_26566(Microsoft.CodeAnalysis.SyntaxToken
                        questionToken, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeArgument)
                        {
                            reportNullableReferenceTypesIfNeeded(questionToken, diagnostics, typeArgument);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26473, 26566);
                            return 0;
                        }


                        bool
                        f_10319_26591_26614_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26591, 26614);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_26718_26729()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26718, 26729);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LanguageVersion
                        f_10319_26718_26745(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.LanguageVersion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26718, 26745);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LazyUseSiteDiagnosticsInfoForNullableType
                        f_10319_26672_26763(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                        languageVersion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        possiblyNullableTypeSymbol)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.LazyUseSiteDiagnosticsInfoForNullableType(languageVersion, possiblyNullableTypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26672, 26763);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_26765_26785(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26765, 26785);
                            return return_v;
                        }


                        int
                        f_10319_26656_26786(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.LazyUseSiteDiagnosticsInfoForNullableType
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26656, 26786);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10319_26932_26971(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 26932, 26971);
                            return return_v;
                        }


                        bool
                        f_10319_26907_26993(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        symbol, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        node)
                        {
                            var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 26907, 26993);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_27102_27117(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27102, 27117);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_27205_27221(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27205, 27221);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10319_27223_27239(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27223, 27239);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                        f_10319_27162_27289(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        currentCompilation, Microsoft.CodeAnalysis.CSharp.Conversions
                        conversions, bool
                        includeNullability, Microsoft.CodeAnalysis.Location
                        location, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs(currentCompilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, includeNullability: includeNullability, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 27162, 27289);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_27396_27407()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27396, 27407);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LanguageVersion
                        f_10319_27396_27423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.LanguageVersion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27396, 27423);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                        f_10319_27337_27441(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                        languageVersion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        type)
                        {
                            var return_v = GetNullableUnconstrainedTypeParameterDiagnosticIfNecessary(languageVersion, type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 27337, 27441);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_27537_27552(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 27537, 27552);
                            return return_v;
                        }


                        int
                        f_10319_27505_27553(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 27505, 27553);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 25934, 27631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 25934, 27631);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                NamespaceOrTypeOrAliasSymbolWithAnnotations bindPredefined(ExpressionSyntax syntax, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 27647, 28051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27790, 27840);

                        var
                        predefinedType = (PredefinedTypeSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27858, 27923);

                        var
                        type = f_10319_27869_27922(this, predefinedType, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 27941, 28036);

                        return TypeWithAnnotations.Create(f_10319_27975_28028(this, f_10319_28005_28027(predefinedType)), type);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 27647, 28051);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10319_27869_27922(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax
                        node, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.BindPredefinedTypeSymbol(node, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 27869, 27922);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxToken
                        f_10319_28005_28027(Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax
                        this_param)
                        {
                            var return_v = this_param.Keyword;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28005, 28027);
                            return return_v;
                        }


                        bool
                        f_10319_27975_28028(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxToken
                        token)
                        {
                            var return_v = this_param.AreNullableAnnotationsEnabled(token);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 27975, 28028);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 27647, 28051);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 27647, 28051);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                NamespaceOrTypeOrAliasSymbolWithAnnotations bindAlias(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved, bool suppressUseSiteDiagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 28067, 29079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28279, 28323);

                        var
                        node = (AliasQualifiedNameSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28341, 28411);

                        var
                        bindingResult = f_10319_28361_28410(this, f_10319_28386_28396(node), diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28429, 28470);

                        var
                        alias = bindingResult as AliasSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28488, 28589);

                        NamespaceOrTypeSymbol
                        left = (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 28517, 28534) || (((alias is object) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 28537, 28549)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 28552, 28588))) ? f_10319_28537_28549(alias) : (NamespaceOrTypeSymbol)bindingResult
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28609, 28915) || true) && (f_10319_28613_28622(left) == SymbolKind.NamedType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 28609, 28915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28688, 28896);

                            return TypeWithAnnotations.Create(f_10319_28722_28894(left, LookupResultKind.NotATypeOrNamespace, f_10319_28794_28893(diagnostics, ErrorCode.ERR_ColColWithTypeAlias, f_10319_28845_28864(f_10319_28845_28855(node)), f_10319_28866_28876(node).Identifier.Text)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 28609, 28915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 28935, 29064);

                        return f_10319_28942_29063(this, f_10319_28986_28995(node), diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, left);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 28067, 29079);

                        Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        f_10319_28386_28396(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Alias;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28386, 28396);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_28361_28410(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        node, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.BindNamespaceAliasSymbol(node, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 28361, 28410);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        f_10319_28537_28549(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                        this_param)
                        {
                            var return_v = this_param.Target;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28537, 28549);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_28613_28622(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28613, 28622);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        f_10319_28845_28855(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Alias;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28845, 28855);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_28845_28864(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28845, 28864);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        f_10319_28866_28876(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Alias;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28866, 28876);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_28794_28893(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 28794, 28893);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_28722_28894(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        errorInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 28722, 28894);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                        f_10319_28986_28995(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 28986, 28995);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                        f_10319_28942_29063(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                        syntax, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        basesBeingResolved, bool
                        suppressUseSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        qualifierOpt)
                        {
                            var return_v = this_param.BindSimpleNamespaceOrTypeOrAliasSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 28942, 29063);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 28067, 29079);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 28067, 29079);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                NamespaceOrTypeOrAliasSymbolWithAnnotations bindPointer(ExpressionSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 29095, 29789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29276, 29313);

                        var
                        node = (PointerTypeSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29331, 29409);

                        var
                        elementType = f_10319_29349_29408(this, f_10319_29358_29374(node), diagnostics, basesBeingResolved)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29427, 29471);

                        f_10319_29427_29470(this, node, diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29491, 29684) || true) && (!f_10319_29496_29547(Flags, BinderFlags.SuppressConstraintChecks))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 29491, 29684);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29589, 29665);

                            f_10319_29589_29664(f_10319_29606_29617(), elementType.Type, f_10319_29637_29650(node), diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 29491, 29684);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29704, 29774);

                        return TypeWithAnnotations.Create(f_10319_29738_29772(elementType));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 29095, 29789);

                        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                        f_10319_29358_29374(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
                        this_param)
                        {
                            var return_v = this_param.ElementType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 29358, 29374);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10319_29349_29408(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                        syntax, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        basesBeingResolved)
                        {
                            var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29349, 29408);
                            return return_v;
                        }


                        bool
                        f_10319_29427_29470(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
                        node, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.ReportUnsafeIfNotAllowed((Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29427, 29470);
                            return return_v;
                        }


                        bool
                        f_10319_29496_29547(Microsoft.CodeAnalysis.CSharp.BinderFlags
                        this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                        flag)
                        {
                            var return_v = this_param.HasFlag((System.Enum)flag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29496, 29547);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_29606_29617()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 29606, 29617);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_29637_29650(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 29637, 29650);
                            return return_v;
                        }


                        bool
                        f_10319_29589_29664(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.Location
                        location, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = CheckManagedAddr(compilation, type, location, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29589, 29664);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                        f_10319_29738_29772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        pointedAtType)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29738, 29772);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 29095, 29789);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 29095, 29789);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                NamespaceOrTypeOrAliasSymbolWithAnnotations createErrorType(ExpressionSyntax syntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 29805, 30074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 29922, 29988);

                        f_10319_29922_29987(diagnostics, ErrorCode.ERR_TypeExpected, f_10319_29966_29986(syntax));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30006, 30059);

                        return TypeWithAnnotations.Create(f_10319_30040_30057(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 29805, 30074);

                        Microsoft.CodeAnalysis.Location
                        f_10319_29966_29986(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29966, 29986);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_29922_29987(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 29922, 29987);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10319_30040_30057(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.CreateErrorType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 30040, 30057);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 29805, 30074);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 29805, 30074);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 19916, 30085);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10319_20160_20173(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20160, 20173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_20265_20318(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = bindNullable(syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20265, 20318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_20399_20434(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = bindPredefined(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20399, 20434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_20515_20674(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt)
                {
                    var return_v = this_param.BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax)node, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt: qualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20515, 20674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_20752_20877(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt)
                {
                    var return_v = this_param.BindGenericSimpleNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)node, diagnostics, basesBeingResolved, qualifierOpt: qualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20752, 20877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_20962_21040(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = bindAlias(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 20962, 21040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10319_21230_21239(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 21230, 21239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10319_21241_21251(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 21241, 21251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_21212_21313(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                leftName, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                rightName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindQualifiedName((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)leftName, rightName, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 21212, 21313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10319_21550_21565(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 21550, 21565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10319_21567_21576(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 21567, 21576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_21532_21638(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                leftName, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                rightName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindQualifiedName(leftName, rightName, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 21532, 21638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_21764_21891(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                permitDimensions, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                disallowRestrictedTypes)
                {
                    var return_v = this_param.BindArrayType((Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax)node, diagnostics, permitDimensions: permitDimensions, basesBeingResolved, disallowRestrictedTypes: disallowRestrictedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 21764, 21891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_21992_22044(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = bindPointer(syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 21992, 22044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_22215_22259(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sizeOfTypeOpt)
                {
                    var return_v = this_param.GetUnsafeDiagnosticInfo(sizeOfTypeOpt: sizeOfTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 22215, 22259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_22350_22391(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.DelegateKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 22350, 22391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_22433_22472(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.AsteriskToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 22433, 22472);
                    return return_v;
                }


                int
                f_10319_22499_22549(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 22499, 22549);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_22598_22696(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                textSpan)
                {
                    var return_v = Location.Create(syntaxTree, textSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 22598, 22696);
                    return return_v;
                }


                int
                f_10319_22576_22697(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 22576, 22697);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10319_22805_23087(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                typeBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = FunctionPointerTypeSymbol.CreateFromSource(syntax, typeBinder, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 22805, 23087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_23201_23270(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                typeArgument, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeArgument((Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)typeArgument, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 23201, 23270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_23525_23556(Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 23525, 23556);
                    return return_v;
                }


                bool
                f_10319_23495_23557(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 23495, 23557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10319_23559_23622(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTupleType(syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 23559, 23622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_23889_23913(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param)
                {
                    var return_v = this_param.RefKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 23889, 23913);
                    return return_v;
                }


                bool
                f_10319_23944_23961_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 23944, 23961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_24019_24110(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 24019, 24110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_24206_24224(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 24206, 24224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_24173_24286(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 24173, 24286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_24585_24608(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = createErrorType(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 24585, 24608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 19916, 30085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 19916, 30085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSDiagnosticInfo? GetNullableUnconstrainedTypeParameterDiagnosticIfNecessary(LanguageVersion languageVersion, in TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 30097, 30991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30276, 30954) || true) && (f_10319_30280_30337(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 30276, 30954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30601, 30693);

                    var
                    requiredVersion = f_10319_30623_30692(MessageID.IDS_FeatureDefaultTypeParameterConstraint)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30711, 30939) || true) && (requiredVersion > languageVersion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 30711, 30939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30790, 30920);

                        return f_10319_30797_30919(ErrorCode.ERR_NullableUnconstrainedTypeParameter, f_10319_30868_30918(requiredVersion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 30711, 30939);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 30276, 30954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 30968, 30980);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 30097, 30991);

                bool
                f_10319_30280_30337(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 30280, 30337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10319_30623_30692(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 30623, 30692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10319_30868_30918(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 30868, 30918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_30797_30919(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 30797, 30919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 30097, 30991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 30097, 30991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations BindArrayType(
                    ArrayTypeSyntax node,
                    DiagnosticBag diagnostics,
                    bool permitDimensions,
                    ConsList<TypeSymbol> basesBeingResolved,
                    bool disallowRestrictedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 31022, 33299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31297, 31384);

                TypeWithAnnotations
                type = f_10319_31324_31383(this, f_10319_31333_31349(node), diagnostics, basesBeingResolved)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31398, 31621) || true) && (type.IsStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 31398, 31621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31524, 31606);

                    f_10319_31524_31605(diagnostics, ErrorCode.ERR_ArrayOfStaticClass, f_10319_31577_31593(node), type.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 31398, 31621);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31637, 32368) || true) && (disallowRestrictedTypes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 31637, 32368);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31819, 32353) || true) && (f_10319_31823_31845())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 31819, 32353);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 31887, 32150) || true) && (type.IsRestrictedType())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 31887, 32150);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32039, 32127);

                            f_10319_32039_32126(diagnostics, ErrorCode.ERR_ArrayElementCantBeRefAny, f_10319_32098_32114(node), type.Type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 31887, 32150);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 31819, 32353);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 31819, 32353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32232, 32334);

                        f_10319_32232_32333(diagnostics, f_10319_32248_32300(type), f_10319_32302_32332(f_10319_32302_32318(node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 31819, 32353);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 31637, 32368);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32393, 32426);

                    for (int
        i = node.RankSpecifiers.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32384, 33260) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32436, 32439)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 32384, 33260))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 32384, 33260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32473, 32516);

                        var
                        rankSpecifier = f_10319_32493_32512(node)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32534, 32570);

                        var
                        dimension = f_10319_32550_32569(rankSpecifier)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32588, 33003) || true) && (!permitDimensions && (DynAbs.Tracing.TraceSender.Expression_True(10319, 32592, 32633) && dimension.Count != 0) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 32592, 32697) && f_10319_32637_32656(dimension[0]) != SyntaxKind.OmittedArraySizeExpression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 32588, 33003);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 32912, 32984);

                            f_10319_32912_32983(diagnostics, ErrorCode.ERR_ArraySizeInDeclaration, rankSpecifier);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 32588, 33003);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33023, 33122);

                        var
                        array = f_10319_33035_33121(f_10319_33069_33094(f_10319_33069_33085(this)), type, f_10319_33102_33120(rankSpecifier))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33140, 33245);

                        type = TypeWithAnnotations.Create(f_10319_33174_33236(this, f_10319_33204_33235(rankSpecifier)), array);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 877);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33276, 33288);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 31022, 33299);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_31333_31349(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 31333, 31349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_31324_31383(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 31324, 31383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_31577_31593(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 31577, 31593);
                    return return_v;
                }


                int
                f_10319_31524_31605(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 31524, 31605);
                    return 0;
                }


                bool
                f_10319_31823_31845()
                {
                    var return_v = ShouldCheckConstraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 31823, 31845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_32098_32114(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 32098, 32114);
                    return return_v;
                }


                int
                f_10319_32039_32126(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32039, 32126);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LazyArrayElementCantBeRefAnyDiagnosticInfo
                f_10319_32248_32300(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                possiblyRestrictedTypeSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LazyArrayElementCantBeRefAnyDiagnosticInfo(possiblyRestrictedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32248, 32300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_32302_32318(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 32302, 32318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_32302_32332(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32302, 32332);
                    return return_v;
                }


                int
                f_10319_32232_32333(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.LazyArrayElementCantBeRefAnyDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32232, 32333);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
                f_10319_32493_32512(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.RankSpecifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 32493, 32512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10319_32550_32569(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Sizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 32550, 32569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10319_32637_32656(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32637, 32656);
                    return return_v;
                }


                int
                f_10319_32912_32983(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 32912, 32983);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_33069_33085(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 33069, 33085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_33069_33094(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 33069, 33094);
                    return return_v;
                }


                int
                f_10319_33102_33120(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 33102, 33120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10319_33035_33121(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank)
                {
                    var return_v = ArrayTypeSymbol.CreateCSharpArray(declaringAssembly, elementTypeWithAnnotations, rank);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 33035, 33121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_33204_33235(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.CloseBracketToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 33204, 33235);
                    return return_v;
                }


                bool
                f_10319_33174_33236(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 33174, 33236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 31022, 33299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 31022, 33299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol BindTupleType(TupleTypeSyntax syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 33311, 36792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33460, 33500);

                int
                numElements = syntax.Elements.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33514, 33585);

                var
                types = f_10319_33526_33584(numElements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33599, 33663);

                var
                locations = f_10319_33615_33662(numElements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33677, 33718);

                ArrayBuilder<string>
                elementNames = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33776, 33835);

                var
                uniqueFieldNames = f_10319_33799_33834()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33849, 33879);

                bool
                hasExplicitNames = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33904, 33909);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33895, 34894) || true) && (i < numElements)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33928, 33931)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 33895, 34894))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 33895, 34894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 33965, 34005);

                        var
                        argumentSyntax = f_10319_33986_34001(syntax)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34025, 34107);

                        var
                        argumentType = f_10319_34044_34106(this, f_10319_34053_34072(argumentSyntax), diagnostics, basesBeingResolved)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34125, 34149);

                        f_10319_34125_34148(types, argumentType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34169, 34188);

                        string
                        name = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34206, 34256);

                        SyntaxToken
                        nameToken = f_10319_34230_34255(argumentSyntax)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34276, 34791) || true) && (nameToken.Kind() == SyntaxKind.IdentifierToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 34276, 34791);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34368, 34395);

                            name = nameToken.ValueText;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34472, 34496);

                            hasExplicitNames = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34518, 34590);

                            f_10319_34518_34589(name, i, nameToken, diagnostics, uniqueFieldNames);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34612, 34651);

                            f_10319_34612_34650(locations, nameToken.GetLocation());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 34276, 34791);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 34276, 34791);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34733, 34772);

                            f_10319_34733_34771(locations, f_10319_34747_34770(argumentSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 34276, 34791);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34811, 34879);

                        f_10319_34811_34878(name, i, numElements, ref elementNames);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 1000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 1000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34910, 34934);

                f_10319_34910_34933(
                            uniqueFieldNames);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 34950, 35519) || true) && (hasExplicitNames)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 34950, 35519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35319, 35387);

                    f_10319_35319_35386(                // If the tuple type with names is bound we must have the TupleElementNamesAttribute to emit
                                                        // it is typically there though, if we have ValueTuple at all
                                                        // and we need System.String as well

                                    // Report diagnostics if System.String doesn't exist
                                    this, SpecialType.System_String, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35407, 35504);

                    f_10319_35407_35503(f_10319_35456_35467(), f_10319_35469_35489(syntax), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 34950, 35519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35535, 35579);

                var
                typesArray = f_10319_35552_35578(types)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35593, 35645);

                var
                locationsArray = f_10319_35614_35644(locations)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35661, 35795) || true) && (typesArray.Length < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 35661, 35795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35720, 35780);

                    throw f_10319_35726_35779(typesArray.Length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 35661, 35795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35811, 35911);

                bool
                includeNullability = f_10319_35837_35910(f_10319_35837_35848(), MessageID.IDS_FeatureNullableReferenceTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 35925, 36781);

                return f_10319_35932_36780(f_10319_35960_35975(syntax), typesArray, locationsArray, (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 36134, 36154) || ((elementNames == null && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 36202, 36233)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 36281, 36314))) ? default(ImmutableArray<string>) : f_10319_36281_36314(elementNames), f_10319_36359_36375(this), f_10319_36420_36447(this), includeNullability: f_10319_36512_36539(this) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 36512, 36561) && includeNullability), errorPositions: default(ImmutableArray<bool>), syntax: syntax, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 33311, 36792);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_33526_33584(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 33526, 33584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                f_10319_33615_33662(int
                capacity)
                {
                    var return_v = ArrayBuilder<Location>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 33615, 33662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10319_33799_33834()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 33799, 33834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax>
                f_10319_33986_34001(Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 33986, 34001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10319_34053_34072(Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 34053, 34072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_34044_34106(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34044, 34106);
                    return return_v;
                }


                int
                f_10319_34125_34148(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34125, 34148);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_34230_34255(Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 34230, 34255);
                    return return_v;
                }


                bool
                f_10319_34518_34589(string
                name, int
                index, Microsoft.CodeAnalysis.SyntaxToken
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                uniqueFieldNames)
                {
                    var return_v = CheckTupleMemberName(name, index, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, diagnostics, uniqueFieldNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34518, 34589);
                    return return_v;
                }


                int
                f_10319_34612_34650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34612, 34650);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_34747_34770(Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 34747, 34770);
                    return return_v;
                }


                int
                f_10319_34733_34771(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34733, 34771);
                    return 0;
                }


                int
                f_10319_34811_34878(string?
                name, int
                elementIndex, int
                tupleSize, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>?
                elementNames)
                {
                    CollectTupleFieldMemberName(name, elementIndex, tupleSize, ref elementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34811, 34878);
                    return 0;
                }


                int
                f_10319_34910_34933(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 34910, 34933);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_35319_35386(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35319, 35386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_35456_35467()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 35456, 35467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_35469_35489(Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35469, 35489);
                    return return_v;
                }


                int
                f_10319_35407_35503(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportMissingTupleElementNamesAttributesIfNeeded(compilation, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35407, 35503);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_35552_35578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35552, 35578);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10319_35614_35644(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35614, 35644);
                    return return_v;
                }


                System.Exception
                f_10319_35726_35779(int
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35726, 35779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_35837_35848()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 35837, 35848);
                    return return_v;
                }


                bool
                f_10319_35837_35910(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35837, 35910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_35960_35975(Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 35960, 35975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10319_36281_36314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 36281, 36314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_36359_36375(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 36359, 36375);
                    return return_v;
                }


                bool
                f_10319_36420_36447(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ShouldCheckConstraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 36420, 36447);
                    return return_v;
                }


                bool
                f_10319_36512_36539(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ShouldCheckConstraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 36512, 36539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_35932_36780(Microsoft.CodeAnalysis.Location
                locationOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                elementLocations, System.Collections.Immutable.ImmutableArray<string>
                elementNames, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                shouldCheckConstraints, bool
                includeNullability, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = NamedTypeSymbol.CreateTuple(locationOpt, elementTypesWithAnnotations, elementLocations, elementNames, compilation, shouldCheckConstraints, includeNullability: includeNullability, errorPositions: errorPositions, syntax: (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 35932, 36780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 33311, 36792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 33311, 36792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportMissingTupleElementNamesAttributesIfNeeded(CSharpCompilation compilation, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 36804, 37288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 36975, 37277) || true) && (f_10319_36979_37015_M(!compilation.HasTupleNamesAttributes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 36975, 37277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37049, 37209);

                    var
                    info = f_10319_37060_37208(ErrorCode.ERR_TupleElementNamesAttributeMissing, AttributeDescription.TupleElementNamesAttribute.FullName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37227, 37262);

                    f_10319_37227_37261(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 36975, 37277);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 36804, 37288);

                bool
                f_10319_36979_37015_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 36979, 37015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_37060_37208(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 37060, 37208);
                    return return_v;
                }


                int
                f_10319_37227_37261(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, (Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 37227, 37261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 36804, 37288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 36804, 37288);
            }
        }

        private static void CollectTupleFieldMemberName(string name, int elementIndex, int tupleSize, ref ArrayBuilder<string> elementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 37300, 38139);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37630, 38128) || true) && (elementNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 37630, 38128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37688, 37711);

                    f_10319_37688_37710(elementNames, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 37630, 38128);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 37630, 38128);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37777, 38113) || true) && (name != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 37777, 38113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37835, 37894);

                        elementNames = f_10319_37850_37893(tupleSize);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37925, 37930);
                            for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37916, 38049) || true) && (j < elementIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 37950, 37953)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 37916, 38049))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 37916, 38049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38003, 38026);

                                f_10319_38003_38025(elementNames, null);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 134);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 134);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38071, 38094);

                        f_10319_38071_38093(elementNames, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 37777, 38113);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 37630, 38128);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 37300, 38139);

                int
                f_10319_37688_37710(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 37688, 37710);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10319_37850_37893(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 37850, 37893);
                    return return_v;
                }


                int
                f_10319_38003_38025(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38003, 38025);
                    return 0;
                }


                int
                f_10319_38071_38093(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38071, 38093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 37300, 38139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 37300, 38139);
            }
        }

        private static bool CheckTupleMemberName(string name, int index, SyntaxNodeOrToken syntax, DiagnosticBag diagnostics, PooledHashSet<string> uniqueFieldNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 38151, 39050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38333, 38397);

                int
                reserved = f_10319_38348_38396(name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38411, 39013) || true) && (reserved == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 38411, 39013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38462, 38546);

                    f_10319_38462_38545(diagnostics, ErrorCode.ERR_TupleReservedElementNameAnyPosition, syntax, name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38564, 38577);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 38411, 39013);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 38411, 39013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38611, 39013) || true) && (reserved > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10319, 38615, 38652) && reserved != index + 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 38611, 39013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38686, 38769);

                        f_10319_38686_38768(diagnostics, ErrorCode.ERR_TupleReservedElementName, syntax, name, reserved);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38787, 38800);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 38611, 39013);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 38611, 39013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38834, 39013) || true) && (!f_10319_38839_38865(uniqueFieldNames, name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 38834, 39013);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38899, 38967);

                            f_10319_38899_38966(diagnostics, ErrorCode.ERR_TupleDuplicateElementName, syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 38985, 38998);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 38834, 39013);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 38611, 39013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 38411, 39013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 39027, 39039);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 38151, 39050);

                int
                f_10319_38348_38396(string
                name)
                {
                    var return_v = NamedTypeSymbol.IsTupleElementNameReserved(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38348, 38396);
                    return return_v;
                }


                int
                f_10319_38462_38545(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38462, 38545);
                    return 0;
                }


                int
                f_10319_38686_38768(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38686, 38768);
                    return 0;
                }


                bool
                f_10319_38839_38865(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38839, 38865);
                    return return_v;
                }


                int
                f_10319_38899_38966(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                syntax)
                {
                    Error(diagnostics, code, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 38899, 38966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 38151, 39050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 38151, 39050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol BindPredefinedTypeSymbol(PredefinedTypeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 39062, 39279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 39189, 39268);

                return f_10319_39196_39267(this, f_10319_39211_39247(node.Keyword.Kind()), diagnostics, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 39062, 39279);

                Microsoft.CodeAnalysis.SpecialType
                f_10319_39211_39247(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = kind.GetSpecialType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 39211, 39247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_39196_39267(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 39196, 39267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 39062, 39279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 39062, 39279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindSimpleNamespaceOrTypeOrAliasSymbol(
                    SimpleNameSyntax syntax,
                    DiagnosticBag diagnostics,
                    ConsList<TypeSymbol> basesBeingResolved,
                    bool suppressUseSiteDiagnostics,
                    NamespaceOrTypeSymbol qualifierOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 39419, 41043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 40338, 41032);

                switch (f_10319_40346_40359(syntax))
                {

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 40338, 41032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 40423, 40586);

                        return TypeWithAnnotations.Create(f_10319_40457_40584(qualifierOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?>(10319, 40485, 40542) ?? f_10319_40501_40542(f_10319_40501_40526(f_10319_40501_40517(this)))), string.Empty, arity: 0, errorInfo: null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 40338, 41032);

                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 40338, 41032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 40659, 40820);

                        return f_10319_40666_40819(this, syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 40338, 41032);

                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 40338, 41032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 40890, 41017);

                        return f_10319_40897_41016(this, syntax, diagnostics, basesBeingResolved, qualifierOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 40338, 41032);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 39419, 41043);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10319_40346_40359(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 40346, 40359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_40501_40517(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 40501, 40517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_40501_40526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 40501, 40526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10319_40501_40542(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 40501, 40542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_40457_40584(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity: arity, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 40457, 40584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_40666_40819(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt)
                {
                    var return_v = this_param.BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax)node, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 40666, 40819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_40897_41016(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt)
                {
                    var return_v = this_param.BindGenericSimpleNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)node, diagnostics, basesBeingResolved, qualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 40897, 41016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 39419, 41043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 39419, 41043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsViableType(LookupResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 41055, 41720);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41133, 41220) || true) && (f_10319_41137_41158_M(!result.IsMultiViable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 41133, 41220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41192, 41205);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 41133, 41220);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41236, 41680);
                    foreach (var s in f_10319_41254_41268_I(f_10319_41254_41268(result)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 41236, 41680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41302, 41665);

                        switch (f_10319_41310_41316(s))
                        {

                            case SymbolKind.Alias:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 41302, 41665);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41406, 41476) || true) && (f_10319_41410_41438(f_10319_41410_41433(((AliasSymbol)s))) == SymbolKind.NamedType)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 41406, 41476);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41464, 41476);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 41406, 41476);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10319, 41502, 41508);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 41302, 41665);

                            case SymbolKind.NamedType:
                            case SymbolKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 41302, 41665);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41634, 41646);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 41302, 41665);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 41236, 41680);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 41696, 41709);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 41055, 41720);

                bool
                f_10319_41137_41158_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 41137, 41158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10319_41254_41268(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 41254, 41268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_41310_41316(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 41310, 41316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_41410_41433(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 41410, 41433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_41410_41438(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 41410, 41438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10319_41254_41268_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 41254, 41268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 41055, 41720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 41055, 41720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected NamespaceOrTypeOrAliasSymbolWithAnnotations BindNonGenericSimpleNamespaceOrTypeOrAliasSymbol(
                    IdentifierNameSyntax node,
                    DiagnosticBag diagnostics,
                    ConsList<TypeSymbol> basesBeingResolved,
                    bool suppressUseSiteDiagnostics,
                    NamespaceOrTypeSymbol qualifierOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 41732, 45579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 42089, 42141);

                var
                identifierValueText = node.Identifier.ValueText
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 42478, 42805) || true) && (f_10319_42482_42528(identifierValueText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 42478, 42805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 42562, 42790);

                    return TypeWithAnnotations.Create(f_10319_42596_42788(f_10319_42646_42682(f_10319_42646_42666(f_10319_42646_42657())), identifierValueText, 0, f_10319_42729_42787(ErrorCode.ERR_SingleTypeNameNotFound)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 42478, 42805);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 42821, 42938);

                var
                errorResult = f_10319_42839_42937(this, f_10319_42874_42885(node), qualifierOpt, identifierValueText, 0, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 42952, 43079) || true) && ((object)errorResult != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 42952, 43079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43017, 43064);

                    return TypeWithAnnotations.Create(errorResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 42952, 43079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43095, 43135);

                var
                result = f_10319_43108_43134()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43149, 43246);

                // LAFHIS
                var temp = node.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 43206, 43221);
                
                LookupOptions
                options = f_10319_43173_43245(node, temp.IsVerbatimIdentifier())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43262, 43312);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43326, 43490);

                f_10319_43326_43489(this, result, qualifierOpt, identifierValueText, 0, basesBeingResolved, options, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43504, 43546);

                f_10319_43504_43545(diagnostics, node, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43562, 43590);

                Symbol
                bindingResult = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43799, 44676) || true) && ((object)qualifierOpt == null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 43803, 43873) && !f_10319_43853_43873(result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 43799, 44676);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43907, 44661) || true) && (node.Identifier.ValueText == "dynamic")
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 43907, 44661);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 43991, 44496) || true) && ((f_10319_43996_44007(node) == null || (DynAbs.Tracing.TraceSender.Expression_False(10319, 43996, 44197) || f_10319_44046_44064(f_10319_44046_44057(node)) != SyntaxKind.Attribute && (DynAbs.Tracing.TraceSender.Expression_True(10319, 44046, 44197) && f_10319_44160_44197(node)))) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 43995, 44304) && f_10319_44227_44254(f_10319_44227_44238()) >= f_10319_44258_44304(MessageID.IDS_FeatureDynamic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 43991, 44496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44354, 44394);

                            bindingResult = f_10319_44370_44393(f_10319_44370_44381());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44420, 44473);

                            f_10319_44420_44472(this, diagnostics, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 43991, 44496);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 43907, 44661);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 43907, 44661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44578, 44642);

                        bindingResult = f_10319_44594_44641(this, node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 43907, 44661);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 43799, 44676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44692, 45392) || true) && (bindingResult is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 44692, 45392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44751, 44765);

                    bool
                    wasError
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44785, 44930);

                    bindingResult = f_10319_44801_44929(this, result, identifierValueText, 0, node, diagnostics, suppressUseSiteDiagnostics, out wasError, qualifierOpt, options);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 44948, 45377) || true) && (f_10319_44952_44970(bindingResult) == SymbolKind.Alias)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 44948, 45377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45032, 45114);

                        var
                        aliasTarget = f_10319_45050_45113(((AliasSymbol)bindingResult), basesBeingResolved)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45136, 45358) || true) && (f_10319_45140_45156(aliasTarget) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 45140, 45232) && f_10319_45184_45232(((NamedTypeSymbol)aliasTarget))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 45136, 45358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45282, 45335);

                            f_10319_45282_45334(this, diagnostics, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 45136, 45358);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 44948, 45377);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 44692, 45392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45408, 45422);

                f_10319_45408_45421(
                            result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45436, 45568);

                return NamespaceOrTypeOrAliasSymbolWithAnnotations.CreateUnannotated(f_10319_45505_45551(this, f_10319_45535_45550(node)), bindingResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 41732, 45579);

                bool
                f_10319_42482_42528(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 42482, 42528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_42646_42657()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 42646, 42657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_42646_42666(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 42646, 42666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10319_42646_42682(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 42646, 42682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_42729_42787(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 42729, 42787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_42596_42788(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 42596, 42788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_42874_42885(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 42874, 42885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_42839_42937(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateErrorIfLookupOnTypeParameter(node, qualifierOpt, name, arity, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 42839, 42937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10319_43108_43134()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 43108, 43134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupOptions
                f_10319_43173_43245(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, bool
                isVerbatimIdentifier)
                {
                    var return_v = GetSimpleNameLookupOptions((Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)node, isVerbatimIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 43173, 43245);
                    return return_v;
                }


                int
                f_10319_43326_43489(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                plainName, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsSimpleName(result, qualifierOpt, plainName, arity, basesBeingResolved, options, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 43326, 43489);
                    return 0;
                }


                bool
                f_10319_43504_43545(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 43504, 43545);
                    return return_v;
                }


                bool
                f_10319_43853_43873(Microsoft.CodeAnalysis.CSharp.LookupResult
                result)
                {
                    var return_v = IsViableType(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 43853, 43873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_43996_44007(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 43996, 44007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10319_44046_44057(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44046, 44057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10319_44046_44064(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44046, 44064);
                    return return_v;
                }


                bool
                f_10319_44160_44197(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = SyntaxFacts.IsInTypeOnlyContext((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44160, 44197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_44227_44238()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44227, 44238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10319_44227_44254(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44227, 44254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10319_44258_44304(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44258, 44304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_44370_44381()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44370, 44381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10319_44370_44393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44370, 44393);
                    return return_v;
                }


                int
                f_10319_44420_44472(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    this_param.ReportUseSiteDiagnosticForDynamic(diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44420, 44472);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_44594_44641(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNativeIntegerSymbolIfAny(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44594, 44641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_44801_44929(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                simpleName, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                where, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics, out bool
                wasError, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.ResultSymbol(result, simpleName, arity, (Microsoft.CodeAnalysis.SyntaxNode)where, diagnostics, suppressUseSiteDiagnostics, out wasError, qualifierOpt, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 44801, 44929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_44952_44970(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 44952, 44970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_45050_45113(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 45050, 45113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_45140_45156(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 45140, 45156);
                    return return_v;
                }


                bool
                f_10319_45184_45232(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 45184, 45232);
                    return return_v;
                }


                int
                f_10319_45282_45334(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    this_param.ReportUseSiteDiagnosticForDynamic(diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 45282, 45334);
                    return 0;
                }


                int
                f_10319_45408_45421(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 45408, 45421);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_45535_45550(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 45535, 45550);
                    return return_v;
                }


                bool
                f_10319_45505_45551(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 45505, 45551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 41732, 45579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 41732, 45579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol BindNativeIntegerSymbolIfAny(IdentifierNameSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 45797, 47405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45928, 45952);

                SpecialType
                specialType
                = default(SpecialType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 45966, 46327);

                switch (node.Identifier.Text)
                {

                    case "nint":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 45966, 46327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46062, 46102);

                        specialType = SpecialType.System_IntPtr;
                        DynAbs.Tracing.TraceSender.TraceBreak(10319, 46124, 46130);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 45966, 46327);

                    case "nuint":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 45966, 46327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46183, 46224);

                        specialType = SpecialType.System_UIntPtr;
                        DynAbs.Tracing.TraceSender.TraceBreak(10319, 46246, 46252);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 45966, 46327);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 45966, 46327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46300, 46312);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 45966, 46327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46343, 47211);

                switch (f_10319_46351_46362(node))
                {

                    case AttributeSyntax parent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46424, 46448) || true) && (f_10319_46429_46440(parent) == node) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 46424, 46448) || true)
                : // [nint]
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 46343, 47211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46481, 46493);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 46343, 47211);

                    case UsingDirectiveSyntax parent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46544, 46568) || true) && (f_10319_46549_46560(parent) == node) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 46544, 46568) || true)
                : // using nint; using A = nuint;
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 46343, 47211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46623, 46635);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 46343, 47211);

                    case ArgumentSyntax parent when // nameof(nint)
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 46680, 47054) || true) && ((f_10319_46723_46737() && (DynAbs.Tracing.TraceSender.Expression_True(10319, 46723, 46828) && f_10319_46766_46787_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10319_46766_46779(parent), 10319, 46766, 46787)?.Parent) is InvocationExpressionSyntax invocation) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 46723, 47053) &&                        // LAFHIS
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 46893, 46940) || (((f_10319_46894_46915(invocation) is IdentifierNameSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 46943, 47044)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 47047, 47052))) ? ((IdentifierNameSyntax)f_10319_46966_46987(invocation)).Identifier.ContextualKind() == SyntaxKind.NameOfKeyword : false)))) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 46680, 47054) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 46343, 47211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 47184, 47196);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 46343, 47211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 47227, 47303);

                f_10319_47227_47302(node, MessageID.IDS_FeatureNativeInt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 47317, 47394);

                return f_10319_47324_47393(f_10319_47324_47375(this, specialType, diagnostics, node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 45797, 47405);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_46351_46362(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46351, 46362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10319_46429_46440(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46429, 46440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10319_46549_46560(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46549, 46560);
                    return return_v;
                }


                bool
                f_10319_46723_46737()
                {
                    var return_v = IsInsideNameof;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46723, 46737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_46766_46779(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46766, 46779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_46766_46787_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46766, 46787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10319_46894_46915(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46894, 46915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10319_46966_46987(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 46966, 46987);
                    return return_v;
                }


                bool
                f_10319_47227_47302(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 47227, 47302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_47324_47375(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 47324, 47375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_47324_47393(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 47324, 47393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 45797, 47405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 45797, 47405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportUseSiteDiagnosticForDynamic(DiagnosticBag diagnostics, IdentifierNameSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 47417, 50164);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 49029, 50153) || true) && (f_10319_49033_49081(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 49029, 50153);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 49115, 50051) || true) && (!f_10319_49120_49158(f_10319_49120_49131()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 49115, 50051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 49826, 49945);

                        var
                        info = f_10319_49837_49944(ErrorCode.ERR_DynamicAttributeMissing, AttributeDescription.DynamicAttribute.FullName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 49967, 50032);

                        f_10319_49967_50031(info, diagnostics, f_10319_50017_50030(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 49115, 50051);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 50071, 50138);

                    f_10319_50071_50137(
                                    this, SpecialType.System_Boolean, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 49029, 50153);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 47417, 50164);

                bool
                f_10319_49033_49081(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                typeNode)
                {
                    var return_v = typeNode.IsTypeInContextWhichNeedsDynamicAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 49033, 49081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_49120_49131()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 49120, 49131);
                    return return_v;
                }


                bool
                f_10319_49120_49158(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasDynamicEmitAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 49120, 49158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_49837_49944(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 49837, 49944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_50017_50030(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 50017, 50030);
                    return return_v;
                }


                bool
                f_10319_49967_50031(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 49967, 50031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_50071_50137(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 50071, 50137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 47417, 50164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 47417, 50164);
            }
        }

        private static LookupOptions GetSimpleNameLookupOptions(NameSyntax node, bool isVerbatimIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 50257, 51351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 50381, 51340) || true) && (f_10319_50385_50418(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 50381, 51340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51108, 51216);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 51115, 51135) || ((isVerbatimIdentifier && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 51138, 51181)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 51184, 51215))) ? LookupOptions.VerbatimNameAttributeTypeOnly : LookupOptions.AttributeTypeOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 50381, 51340);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 50381, 51340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51282, 51325);

                    return LookupOptions.NamespacesOrTypesOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 50381, 51340);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 50257, 51351);

                bool
                f_10319_50385_50418(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = SyntaxFacts.IsAttributeName((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 50385, 50418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 50257, 51351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 50257, 51351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol UnwrapAliasNoDiagnostics(Symbol symbol, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 51363, 51686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51497, 51645) || true) && (f_10319_51501_51512(symbol) == SymbolKind.Alias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 51497, 51645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51566, 51630);

                    return f_10319_51573_51629(((AliasSymbol)symbol), basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 51497, 51645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51661, 51675);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 51363, 51686);

                Microsoft.CodeAnalysis.SymbolKind
                f_10319_51501_51512(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 51501, 51512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_51573_51629(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 51573, 51629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 51363, 51686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 51363, 51686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations UnwrapAlias(in NamespaceOrTypeOrAliasSymbolWithAnnotations symbol, DiagnosticBag diagnostics, SyntaxNode syntax, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 51698, 52285);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51935, 52244) || true) && (symbol.IsAlias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 51935, 52244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 51987, 52009);

                    AliasSymbol
                    discarded
                    = default(AliasSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52027, 52229);

                    return NamespaceOrTypeOrAliasSymbolWithAnnotations.CreateUnannotated(symbol.IsNullableEnabled, f_10319_52145_52227(this, symbol.Symbol, out discarded, diagnostics, syntax, basesBeingResolved));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 51935, 52244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52260, 52274);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 51698, 52285);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_52145_52227(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, out alias, diagnostics, syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 52145, 52227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 51698, 52285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 51698, 52285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations UnwrapAlias(in NamespaceOrTypeOrAliasSymbolWithAnnotations symbol, out AliasSymbol alias, DiagnosticBag diagnostics, SyntaxNode syntax, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 52297, 52890);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52557, 52822) || true) && (symbol.IsAlias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 52557, 52822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52609, 52807);

                    return NamespaceOrTypeOrAliasSymbolWithAnnotations.CreateUnannotated(symbol.IsNullableEnabled, f_10319_52727_52805(this, symbol.Symbol, out alias, diagnostics, syntax, basesBeingResolved));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 52557, 52822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52838, 52851);

                alias = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 52865, 52879);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 52297, 52890);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_52727_52805(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, out alias, diagnostics, syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 52727, 52805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 52297, 52890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 52297, 52890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol UnwrapAlias(Symbol symbol, DiagnosticBag diagnostics, SyntaxNode syntax, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 52902, 53192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53062, 53084);

                AliasSymbol
                discarded
                = default(AliasSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53098, 53181);

                return f_10319_53105_53180(this, symbol, out discarded, diagnostics, syntax, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 52902, 53192);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_53105_53180(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.UnwrapAlias(symbol, out alias, diagnostics, syntax, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 53105, 53180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 52902, 53192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 52902, 53192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol UnwrapAlias(Symbol symbol, out AliasSymbol alias, DiagnosticBag diagnostics, SyntaxNode syntax, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 53204, 54344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53387, 53416);

                f_10319_53387_53415(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53430, 53464);

                f_10319_53430_53463(diagnostics != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53480, 54276) || true) && (f_10319_53484_53495(symbol) == SymbolKind.Alias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 53480, 54276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53549, 53577);

                    alias = (AliasSymbol)symbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53595, 53649);

                    var
                    result = f_10319_53608_53648(alias, basesBeingResolved)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53667, 53699);

                    var
                    type = result as TypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53717, 54227) || true) && ((object)type != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 53717, 54227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53864, 53903);

                        var
                        args = (this, diagnostics, syntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 53925, 54208);

                        f_10319_53925_54207(type, (typePart, argTuple, isNested) =>
                        {
                            argTuple.Item1.ReportDiagnosticsIfObsolete(argTuple.diagnostics, typePart, argTuple.syntax, hasBaseReceiver: false);
                            return false;
                        }, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 53717, 54227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 54247, 54261);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 53480, 54276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 54292, 54305);

                alias = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 54319, 54333);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 53204, 54344);

                int
                f_10319_53387_53415(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 53387, 53415);
                    return 0;
                }


                int
                f_10319_53430_53463(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 53430, 53463);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_53484_53495(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 53484, 53495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_53608_53648(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 53608, 53648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10319_53925_54207(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, (Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics, Microsoft.CodeAnalysis.SyntaxNode syntax), bool, bool>
                predicate, (Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics, Microsoft.CodeAnalysis.SyntaxNode syntax)
                arg)
                {
                    var return_v = type.VisitType<(Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics, Microsoft.CodeAnalysis.SyntaxNode syntax)>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 53925, 54207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 53204, 54344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 53204, 54344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations BindGenericSimpleNamespaceOrTypeOrAliasSymbol(
                    GenericNameSyntax node,
                    DiagnosticBag diagnostics,
                    ConsList<TypeSymbol> basesBeingResolved,
                    NamespaceOrTypeSymbol qualifierOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 54356, 60744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 57602, 57644);

                var
                plainName = node.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 57660, 57740);

                SeparatedSyntaxList<TypeSyntax>
                typeArguments = f_10319_57708_57739(f_10319_57708_57729(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 57756, 57807);

                bool
                isUnboundTypeExpr = f_10319_57781_57806(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 57821, 57907);

                LookupOptions
                options = f_10319_57845_57906(node, isVerbatimIdentifier: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 57923, 58084);

                NamedTypeSymbol
                unconstructedType = f_10319_57959_58083(this, diagnostics, basesBeingResolved, qualifierOpt, node, plainName, f_10319_58063_58073(node), options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58098, 58125);

                NamedTypeSymbol
                resultType
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58141, 60037) || true) && (isUnboundTypeExpr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 58141, 60037);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58196, 59138) || true) && (!f_10319_58201_58227(this, node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 58196, 59138);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58380, 58648) || true) && (!f_10319_58385_58416(unconstructedType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 58380, 58648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58550, 58625);

                            f_10319_58550_58624(                        // error CS7003: Unexpected use of an unbound generic name
                                                    diagnostics, ErrorCode.ERR_UnexpectedUnboundGenericName, f_10319_58610_58623(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 58380, 58648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 58672, 58983);

                        resultType = f_10319_58685_58982(unconstructedType, f_10319_58739_58940(f_10319_58820_58852(unconstructedType), f_10319_58883_58893(node), errorInfo: null), unbound: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 58196, 59138);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 58196, 59138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 59065, 59119);

                        resultType = f_10319_59078_59118(unconstructedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 58196, 59138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 58141, 60037);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 58141, 60037);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 59172, 60037) || true) && ((Flags & BinderFlags.SuppressTypeArgumentBinding) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 59172, 60037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 59264, 59390);

                        resultType = f_10319_59277_59389(unconstructedType, f_10319_59305_59388(f_10319_59355_59387(unconstructedType)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 59172, 60037);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 59172, 60037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 59723, 60022);

                        resultType = f_10319_59736_60021(this, unconstructedType, node, typeArguments, f_10319_59880_59945(this, typeArguments, diagnostics, basesBeingResolved), basesBeingResolved, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 59172, 60037);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 58141, 60037);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 60053, 60600) || true) && (f_10319_60057_60088(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 60053, 60600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 60294, 60340);

                    f_10319_60294_60339(f_10319_60307_60338(unconstructedType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 60358, 60397);

                    f_10319_60358_60396(f_10319_60371_60395(resultType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 60415, 60585);

                    resultType = f_10319_60428_60584(f_10319_60456_60496(this, resultType), resultType, LookupResultKind.NotAnAttributeType, errorInfo: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 60053, 60600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 60616, 60733);

                return TypeWithAnnotations.Create(f_10319_60650_60719(this, f_10319_60680_60718(f_10319_60680_60701(node))), resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 54356, 60744);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                f_10319_57708_57729(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.TypeArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 57708, 57729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                f_10319_57708_57739(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 57708, 57739);
                    return return_v;
                }


                bool
                f_10319_57781_57806(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 57781, 57806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupOptions
                f_10319_57845_57906(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                node, bool
                isVerbatimIdentifier)
                {
                    var return_v = GetSimpleNameLookupOptions((Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)node, isVerbatimIdentifier: isVerbatimIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 57845, 57906);
                    return return_v;
                }


                int
                f_10319_58063_58073(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 58063, 58073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_57959_58083(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                node, string
                plainName, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.LookupGenericTypeName(diagnostics, basesBeingResolved, qualifierOpt, node, plainName, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 57959, 58083);
                    return return_v;
                }


                bool
                f_10319_58201_58227(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                syntax)
                {
                    var return_v = this_param.IsUnboundTypeAllowed(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 58201, 58227);
                    return return_v;
                }


                bool
                f_10319_58385_58416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 58385, 58416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_58610_58623(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 58610, 58623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_58550_58624(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 58550, 58624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10319_58820_58852(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 58820, 58852);
                    return return_v;
                }


                int
                f_10319_58883_58893(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 58883, 58893);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_58739_58940(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, int
                n, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo)
                {
                    var return_v = UnboundArgumentErrorTypeSymbol.CreateTypeArguments(typeParameters, n, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 58739, 58940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_58685_58982(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 58685, 58982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_59078_59118(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 59078, 59118);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10319_59355_59387(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 59355, 59387);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_59305_59388(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    var return_v = PlaceholderTypeArgumentSymbol.CreateTypeArguments(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 59305, 59388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_59277_59389(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 59277, 59389);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_59880_59945(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeArguments(typeArguments, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 59880, 59945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_59736_60021(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                typeSyntax, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConstructNamedType(type, (Microsoft.CodeAnalysis.SyntaxNode)typeSyntax, typeArgumentsSyntax, typeArguments, basesBeingResolved, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 59736, 60021);
                    return return_v;
                }


                bool
                f_10319_60057_60088(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60057, 60088);
                    return return_v;
                }


                bool
                f_10319_60307_60338(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60307, 60338);
                    return return_v;
                }


                int
                f_10319_60294_60339(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60294, 60339);
                    return 0;
                }


                bool
                f_10319_60371_60395(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60371, 60395);
                    return return_v;
                }


                int
                f_10319_60358_60396(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60358, 60396);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_60456_60496(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetContainingNamespaceOrType((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60456, 60496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_60428_60584(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, (Microsoft.CodeAnalysis.CSharp.Symbol)guessSymbol, resultKind, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60428, 60584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                f_10319_60680_60701(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.TypeArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 60680, 60701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10319_60680_60718(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.GreaterThanToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 60680, 60718);
                    return return_v;
                }


                bool
                f_10319_60650_60719(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 60650, 60719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 54356, 60744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 54356, 60744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol LookupGenericTypeName(
                    DiagnosticBag diagnostics,
                    ConsList<TypeSymbol> basesBeingResolved,
                    NamespaceOrTypeSymbol qualifierOpt,
                    GenericNameSyntax node,
                    string plainName,
                    int arity,
                    LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 60756, 63756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61098, 61209);

                var
                errorResult = f_10319_61116_61208(this, f_10319_61151_61162(node), qualifierOpt, plainName, arity, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61223, 61322) || true) && ((object)errorResult != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 61223, 61322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61288, 61307);

                    return errorResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 61223, 61322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61338, 61384);

                var
                lookupResult = f_10319_61357_61383()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61398, 61448);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61462, 61626);

                f_10319_61462_61625(this, lookupResult, qualifierOpt, plainName, arity, basesBeingResolved, options, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61640, 61682);

                f_10319_61640_61681(diagnostics, node, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61698, 61712);

                bool
                wasError
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 61726, 61885);

                Symbol
                lookupResultSymbol = f_10319_61754_61884(this, lookupResult, plainName, arity, node, diagnostics, (basesBeingResolved != null), out wasError, qualifierOpt, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 62966, 63027);

                NamedTypeSymbol
                type = lookupResultSymbol as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 63043, 63681) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 63043, 63681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 63319, 63360);

                    f_10319_63319_63359(f_10319_63332_63350(lookupResult) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 63378, 63666);

                    type = f_10319_63385_63665(f_10319_63435_63483(this, lookupResultSymbol), f_10319_63506_63555(lookupResultSymbol), f_10319_63578_63595(lookupResult), f_10319_63618_63636(lookupResult), arity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 63043, 63681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 63697, 63717);

                f_10319_63697_63716(
                            lookupResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 63733, 63745);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 60756, 63756);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10319_61151_61162(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 61151, 61162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_61116_61208(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateErrorIfLookupOnTypeParameter(node, qualifierOpt, name, arity, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 61116, 61208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10319_61357_61383()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 61357, 61383);
                    return return_v;
                }


                int
                f_10319_61462_61625(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                plainName, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsSimpleName(result, qualifierOpt, plainName, arity, basesBeingResolved, options, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 61462, 61625);
                    return 0;
                }


                bool
                f_10319_61640_61681(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 61640, 61681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_61754_61884(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                simpleName, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                where, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics, out bool
                wasError, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.ResultSymbol(result, simpleName, arity, (Microsoft.CodeAnalysis.SyntaxNode)where, diagnostics, suppressUseSiteDiagnostics, out wasError, qualifierOpt, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 61754, 61884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_63332_63350(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 63332, 63350);
                    return return_v;
                }


                int
                f_10319_63319_63359(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 63319, 63359);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10319_63435_63483(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetContainingNamespaceOrType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 63435, 63483);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10319_63506_63555(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 63506, 63555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10319_63578_63595(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 63578, 63595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_63618_63636(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 63618, 63636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_63385_63665(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                candidateSymbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo, int
                arity)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, candidateSymbols, resultKind, errorInfo, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 63385, 63665);
                    return return_v;
                }


                int
                f_10319_63697_63716(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 63697, 63716);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 60756, 63756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 60756, 63756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExtendedErrorTypeSymbol CreateErrorIfLookupOnTypeParameter(
                    CSharpSyntaxNode node,
                    NamespaceOrTypeSymbol qualifierOpt,
                    string name,
                    int arity,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 63768, 64484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64035, 64445) || true) && (((object)qualifierOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 64039, 64120) && (f_10319_64074_64091(qualifierOpt) == SymbolKind.TypeParameter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 64035, 64445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64154, 64246);

                    var
                    diagnosticInfo = f_10319_64175_64245(ErrorCode.ERR_LookupInTypeVariable, qualifierOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64264, 64311);

                    f_10319_64264_64310(diagnostics, diagnosticInfo, f_10319_64296_64309(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64329, 64430);

                    return f_10319_64336_64429(f_10319_64364_64380(this), name, arity, diagnosticInfo, unreported: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 64035, 64445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64461, 64473);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 63768, 64484);

                Microsoft.CodeAnalysis.SymbolKind
                f_10319_64074_64091(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 64074, 64091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_64175_64245(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64175, 64245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_64296_64309(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 64296, 64309);
                    return return_v;
                }


                int
                f_10319_64264_64310(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64264, 64310);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_64364_64380(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 64364, 64380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10319_64336_64429(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64336, 64429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 63768, 64484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 63768, 64484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> BindTypeArguments(SeparatedSyntaxList<TypeSyntax> typeArguments, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 64496, 65048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64704, 64742);

                f_10319_64704_64741(typeArguments.Count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64756, 64815);

                var
                args = f_10319_64767_64814()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64829, 64988);
                    foreach (var argSyntax in f_10319_64855_64868_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 64829, 64988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 64902, 64973);

                        f_10319_64902_64972(args, f_10319_64911_64971(this, argSyntax, diagnostics, basesBeingResolved));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 64829, 64988);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 65004, 65037);

                return f_10319_65011_65036(args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 64496, 65048);

                int
                f_10319_64704_64741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64704, 64741);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_64767_64814()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64767, 64814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_64911_64971(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgument, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeArgument(typeArgument, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64911, 64971);
                    return return_v;
                }


                int
                f_10319_64902_64972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64902, 64972);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                f_10319_64855_64868_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 64855, 64868);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10319_65011_65036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 65011, 65036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 64496, 65048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 64496, 65048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations BindTypeArgument(TypeSyntax typeArgument, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 65060, 65694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 65330, 65407);

                var
                binder = f_10319_65343_65406(this, BinderFlags.SuppressUnsafeDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 65423, 65656);

                var
                arg = (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 65433, 65486) || ((f_10319_65433_65452(typeArgument) == SyntaxKind.OmittedTypeArgument
                && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 65506, 65573)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 65593, 65655))) ? TypeWithAnnotations.Create(UnboundArgumentErrorTypeSymbol.Instance) : f_10319_65593_65655(binder, typeArgument, diagnostics, basesBeingResolved)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 65672, 65683);

                return arg;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 65060, 65694);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10319_65343_65406(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 65343, 65406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10319_65433_65452(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 65433, 65452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10319_65593_65655(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 65593, 65655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 65060, 65694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 65060, 65694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol ConstructNamedTypeUnlessTypeArgumentOmitted(SyntaxNode typeSyntax, NamedTypeSymbol type, SeparatedSyntaxList<TypeSyntax> typeArgumentsSyntax, ImmutableArray<TypeWithAnnotations> typeArguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 65856, 67350);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 66124, 67339) || true) && (typeArgumentsSyntax.Any(SyntaxKind.OmittedTypeArgument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 66124, 67339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 66421, 66543);

                    f_10319_66421_66542(diagnostics, ErrorCode.ERR_BadArity, typeSyntax, type, f_10319_66482_66514(MessageID.IDS_SK_TYPE), typeArgumentsSyntax.Count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 66934, 66946);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 66124, 67339);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 66124, 67339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 67192, 67324);

                    return f_10319_67199_67323(this, type, typeSyntax, typeArgumentsSyntax, typeArguments, basesBeingResolved: null, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 66124, 67339);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 65856, 67350);

                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10319_66482_66514(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 66482, 66514);
                    return return_v;
                }


                int
                f_10319_66421_66542(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 66421, 66542);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_67199_67323(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                typeSyntax, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConstructNamedType(type, typeSyntax, typeArgumentsSyntax, typeArguments, basesBeingResolved: basesBeingResolved, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 67199, 67323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 65856, 67350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 65856, 67350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundMethodOrPropertyGroup ConstructBoundMemberGroupAndReportOmittedTypeArguments(
                    SyntaxNode syntax,
                    SeparatedSyntaxList<TypeSyntax> typeArgumentsSyntax,
                    ImmutableArray<TypeWithAnnotations> typeArguments,
                    BoundExpression receiver,
                    string plainName,
                    ArrayBuilder<Symbol> members,
                    LookupResult lookupResult,
                    BoundMethodGroupFlags methodGroupFlags,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 67501, 69557);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68060, 68578) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10319, 68064, 68104) && f_10319_68078_68104(lookupResult)) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 68064, 68163) && typeArgumentsSyntax.Any(SyntaxKind.OmittedTypeArgument)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 68060, 68578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68401, 68528);

                    f_10319_68401_68527(diagnostics, ErrorCode.ERR_BadArity, syntax, plainName, f_10319_68463_68499(MessageID.IDS_MethodGroup), typeArgumentsSyntax.Count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68546, 68563);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 68060, 68578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68594, 68626);

                f_10319_68594_68625(f_10319_68607_68620(members) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68642, 69546);

                switch (f_10319_68650_68665(f_10319_68650_68660(members, 0)))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 68642, 69546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 68744, 69105);

                        return f_10319_68751_69104(syntax, typeArguments, receiver, plainName, f_10319_68942_68985(members, s_toMethodSymbolFunc), lookupResult, methodGroupFlags, hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 68642, 69546);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 68642, 69546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 69172, 69423);

                        return f_10319_69179_69422(syntax, f_10319_69261_69306(members, s_toPropertySymbolFunc), receiver, f_10319_69368_69385(lookupResult), hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 68642, 69546);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 68642, 69546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 69473, 69531);

                        throw f_10319_69479_69530(f_10319_69514_69529(f_10319_69514_69524(members, 0)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 68642, 69546);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 67501, 69557);

                bool
                f_10319_68078_68104(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 68078, 68104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10319_68463_68499(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 68463, 68499);
                    return return_v;
                }


                int
                f_10319_68401_68527(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 68401, 68527);
                    return 0;
                }


                int
                f_10319_68607_68620(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 68607, 68620);
                    return return_v;
                }


                int
                f_10319_68594_68625(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 68594, 68625);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_68650_68660(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 68650, 68660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_68650_68665(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 68650, 68665);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10319_68942_68985(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                map)
                {
                    var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 68942, 68985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10319_68751_69104(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.LookupResult
                lookupResult, Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags
                flags, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundMethodGroup(syntax, typeArgumentsOpt, receiverOpt, name, methods, lookupResult, flags, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 68751, 69104);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10319_69261_69306(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                map)
                {
                    var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>(map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 69261, 69306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10319_69368_69385(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 69368, 69385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPropertyGroup
                f_10319_69179_69422(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                properties, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPropertyGroup(syntax, properties, receiverOpt, resultKind, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 69179, 69422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_69514_69524(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 69514, 69524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_69514_69529(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 69514, 69529);
                    return return_v;
                }


                System.Exception
                f_10319_69479_69530(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 69479, 69530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 67501, 69557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 67501, 69557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<Symbol, MethodSymbol> s_toMethodSymbolFunc;

        private static readonly Func<Symbol, PropertySymbol> s_toPropertySymbolFunc;

        private NamedTypeSymbol ConstructNamedType(
                    NamedTypeSymbol type,
                    SyntaxNode typeSyntax,
                    SeparatedSyntaxList<TypeSyntax> typeArgumentsSyntax,
                    ImmutableArray<TypeWithAnnotations> typeArguments,
                    ConsList<TypeSymbol> basesBeingResolved,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 69787, 70686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70150, 70187);

                f_10319_70150_70186(f_10319_70163_70185_M(!typeArguments.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70201, 70238);

                type = f_10319_70208_70237(type, typeArguments);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70254, 70647) || true) && (f_10319_70258_70280() && (DynAbs.Tracing.TraceSender.Expression_True(10319, 70258, 70324) && f_10319_70284_70324(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 70254, 70647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70358, 70458);

                    bool
                    includeNullability = f_10319_70384_70457(f_10319_70384_70395(), MessageID.IDS_FeatureNullableReferenceTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70476, 70632);

                    f_10319_70476_70631(type, f_10319_70510_70526(this), includeNullability, typeSyntax, typeArgumentsSyntax, f_10319_70581_70597(this), basesBeingResolved, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 70254, 70647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 70663, 70675);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 69787, 70686);

                bool
                f_10319_70163_70185_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 70163, 70185);
                    return return_v;
                }


                int
                f_10319_70150_70186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 70150, 70186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_70208_70237(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 70208, 70237);
                    return return_v;
                }


                bool
                f_10319_70258_70280()
                {
                    var return_v = ShouldCheckConstraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 70258, 70280);
                    return return_v;
                }


                bool
                f_10319_70284_70324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = ConstraintsHelper.RequiresChecking(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 70284, 70324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_70384_70395()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 70384, 70395);
                    return return_v;
                }


                bool
                f_10319_70384_70457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 70384, 70457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10319_70510_70526(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 70510, 70526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_70581_70597(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 70581, 70597);
                    return return_v;
                }


                bool
                f_10319_70476_70631(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, bool
                includeNullability, Microsoft.CodeAnalysis.SyntaxNode
                typeSyntax, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = type.CheckConstraintsForNamedType((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, includeNullability, typeSyntax, typeArgumentsSyntax, currentCompilation, basesBeingResolved, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 70476, 70631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 69787, 70686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 69787, 70686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldCheckConstraints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 70990, 71107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 71026, 71092);

                    return !f_10319_71034_71091(this.Flags, BinderFlags.SuppressConstraintChecks);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 70990, 71107);

                    bool
                    f_10319_71034_71091(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 71034, 71091);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 70930, 71118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 70930, 71118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamespaceOrTypeOrAliasSymbolWithAnnotations BindQualifiedName(
                    ExpressionSyntax leftName,
                    SimpleNameSyntax rightName,
                    DiagnosticBag diagnostics,
                    ConsList<TypeSymbol> basesBeingResolved,
                    bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 71130, 73408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 71446, 71583);

                var
                left = f_10319_71457_71560(this, leftName, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics: false).NamespaceOrTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 71597, 71678);

                f_10319_71597_71677(this, diagnostics, left, leftName, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 71694, 71825);

                bool
                isLeftUnboundGenericType = f_10319_71726_71735(left) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 71726, 71824) && f_10319_71780_71824(((NamedTypeSymbol)left)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 71841, 72158) || true) && (isLeftUnboundGenericType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 71841, 72158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72093, 72143);

                    left = f_10319_72100_72142(((NamedTypeSymbol)left));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 71841, 72158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72286, 72420);

                var
                right = f_10319_72298_72419(this, rightName, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72620, 72734) || true) && (isLeftUnboundGenericType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 72620, 72734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72682, 72719);

                    return f_10319_72689_72718();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 72620, 72734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72750, 72763);

                return right;

                NamespaceOrTypeOrAliasSymbolWithAnnotations convertToUnboundGenericType()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 72876, 73397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 72982, 73035);

                        var
                        namedTypeRight = right.Symbol as NamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73053, 73349) || true) && ((object)namedTypeRight != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 73057, 73119) && f_10319_73091_73119(namedTypeRight)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 73053, 73349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73161, 73214);

                            TypeWithAnnotations
                            type = right.TypeWithAnnotations
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73236, 73330);

                            return type.WithTypeAndModifiers(f_10319_73269_73306(namedTypeRight), type.CustomModifiers);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 73053, 73349);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73369, 73382);

                        return right;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 72876, 73397);

                        bool
                        f_10319_73091_73119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsGenericType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 73091, 73119);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10319_73269_73306(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        type)
                        {
                            var return_v = type.AsUnboundGenericType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 73269, 73306);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 72876, 73397);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 72876, 73397);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 71130, 73408);

                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_71457_71560(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics: suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 71457, 71560);
                    return return_v;
                }


                int
                f_10319_71597_71677(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNode)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 71597, 71677);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_71726_71735(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 71726, 71735);
                    return return_v;
                }


                bool
                f_10319_71780_71824(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 71780, 71824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_72100_72142(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 72100, 72142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_72298_72419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt)
                {
                    var return_v = this_param.BindSimpleNamespaceOrTypeOrAliasSymbol(syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics, qualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 72298, 72419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10319_72689_72718()
                {
                    var return_v = convertToUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 72689, 72718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 71130, 73408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 71130, 73408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetSpecialType(SpecialType typeId, DiagnosticBag diagnostics, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 73420, 73626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73548, 73615);

                return f_10319_73555_73614(f_10319_73570_73586(this), typeId, node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 73420, 73626);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_73570_73586(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 73570, 73586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_73555_73614(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetSpecialType(compilation, typeId, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 73555, 73614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 73420, 73626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 73420, 73626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol GetSpecialType(CSharpCompilation compilation, SpecialType typeId, SyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 73638, 74088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73804, 73868);

                NamedTypeSymbol
                typeSymbol = f_10319_73833_73867(compilation, typeId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73882, 73975);

                f_10319_73882_73974((object)typeSymbol != null, "Expect an error type if special type isn't found");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 73989, 74045);

                f_10319_73989_74044(typeSymbol, diagnostics, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74059, 74077);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 73638, 74088);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_73833_73867(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 73833, 73867);
                    return return_v;
                }


                int
                f_10319_73882_73974(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 73882, 73974);
                    return 0;
                }


                bool
                f_10319_73989_74044(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 73989, 74044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 73638, 74088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 73638, 74088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol GetSpecialType(CSharpCompilation compilation, SpecialType typeId, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 74100, 74556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74268, 74332);

                NamedTypeSymbol
                typeSymbol = f_10319_74297_74331(compilation, typeId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74346, 74439);

                f_10319_74346_74438((object)typeSymbol != null, "Expect an error type if special type isn't found");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74453, 74513);

                f_10319_74453_74512(typeSymbol, diagnostics, location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74527, 74545);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 74100, 74556);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_74297_74331(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 74297, 74331);
                    return return_v;
                }


                int
                f_10319_74346_74438(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 74346, 74438);
                    return 0;
                }


                bool
                f_10319_74453_74512(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 74453, 74512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 74100, 74556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 74100, 74556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Symbol GetSpecialTypeMember(SpecialMember member, DiagnosticBag diagnostics, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 74754, 75080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74883, 74903);

                Symbol
                memberSymbol
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 74917, 75069);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 74924, 75012) || ((f_10319_74924_75012(f_10319_74948_74964(this), member, syntax, diagnostics, out memberSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 75032, 75044)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 75064, 75068))) ? memberSymbol
                : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 74754, 75080);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_74948_74964(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 74948, 74964);
                    return return_v;
                }


                bool
                f_10319_74924_75012(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = TryGetSpecialTypeMember(compilation, specialMember, syntax, diagnostics, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 74924, 75012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 74754, 75080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 74754, 75080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetSpecialTypeMember<TSymbol>(CSharpCompilation compilation, SpecialMember specialMember, SyntaxNode syntax, DiagnosticBag diagnostics, out TSymbol symbol)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 75092, 76054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75332, 75398);

                symbol = (TSymbol)f_10319_75350_75397<TSymbol>(compilation, specialMember);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75412, 75737) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 75412, 75737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75472, 75546);

                    MemberDescriptor
                    descriptor = f_10319_75502_75545<TSymbol>(specialMember)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75564, 75691);

                    f_10319_75564_75690<TSymbol>(diagnostics, ErrorCode.ERR_MissingPredefinedMember, f_10319_75619_75634<TSymbol>(syntax), descriptor.DeclaringTypeMetadataName, descriptor.Name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75709, 75722);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 75412, 75737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75753, 75832);

                var
                useSiteDiagnostic = f_10319_75777_75831<TSymbol>(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75846, 76015) || true) && (useSiteDiagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 75846, 76015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 75909, 76000);

                    f_10319_75909_75999<TSymbol>(useSiteDiagnostic, diagnostics, f_10319_75972_75998<TSymbol>(syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 75846, 76015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 76031, 76043);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 75092, 76054);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_75350_75397<TSymbol>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember) where TSymbol : Symbol

                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75350, 75397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10319_75502_75545<TSymbol>(Microsoft.CodeAnalysis.SpecialMember
                member) where TSymbol : Symbol

                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75502, 75545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_75619_75634<TSymbol>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 75619, 75634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_75564_75690<TSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args) where TSymbol : Symbol

                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75564, 75690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_75777_75831<TSymbol>(TSymbol
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.GetUseSiteDiagnosticForSymbolOrContainingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75777, 75831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10319_75972_75998<TSymbol>(Microsoft.CodeAnalysis.SyntaxNode
                node) where TSymbol : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75972, 75998);
                    return return_v;
                }


                bool
                f_10319_75909_75999<TSymbol>(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SourceLocation
                location) where TSymbol : Symbol

                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 75909, 75999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 75092, 76054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 75092, 76054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 76299, 76593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 76428, 76480);

                DiagnosticInfo
                info = f_10319_76450_76479(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 76494, 76582);

                return info != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 76501, 76581) && f_10319_76517_76581(info, diagnostics, f_10319_76567_76580(node)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 76299, 76593);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_76450_76479(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 76450, 76479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_76567_76580(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 76567, 76580);
                    return return_v;
                }


                bool
                f_10319_76517_76581(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 76517, 76581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 76299, 76593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 76299, 76593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 76605, 76907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 76736, 76788);

                DiagnosticInfo
                info = f_10319_76758_76787(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 76802, 76896);

                return info != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 76809, 76895) && f_10319_76825_76895(info, diagnostics, token.GetLocation()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 76605, 76907);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_76758_76787(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 76758, 76787);
                    return return_v;
                }


                bool
                f_10319_76825_76895(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 76825, 76895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 76605, 76907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 76605, 76907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 77152, 77443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 77283, 77335);

                DiagnosticInfo
                info = f_10319_77305_77334(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 77349, 77432);

                return info != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 77356, 77431) && f_10319_77372_77431(info, diagnostics, location));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 77152, 77443);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_77305_77334(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 77305, 77334);
                    return return_v;
                }


                bool
                f_10319_77372_77431(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 77372, 77431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 77152, 77443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 77152, 77443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetWellKnownType(WellKnownType type, DiagnosticBag diagnostics, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 77642, 77841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 77772, 77830);

                return f_10319_77779_77829(this, type, diagnostics, f_10319_77815_77828(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 77642, 77841);

                Microsoft.CodeAnalysis.Location
                f_10319_77815_77828(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 77815, 77828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_77779_77829(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetWellKnownType(type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 77779, 77829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 77642, 77841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 77642, 77841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetWellKnownType(WellKnownType type, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 78040, 78254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 78172, 78243);

                return f_10319_78179_78242(f_10319_78196_78212(this), type, diagnostics, location);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 78040, 78254);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_78196_78212(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 78196, 78212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_78179_78242(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 78179, 78242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 78040, 78254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 78040, 78254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol GetWellKnownType(CSharpCompilation compilation, WellKnownType type, DiagnosticBag diagnostics, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 78453, 78703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 78621, 78692);

                return f_10319_78628_78691(compilation, type, diagnostics, f_10319_78677_78690(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 78453, 78703);

                Microsoft.CodeAnalysis.Location
                f_10319_78677_78690(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 78677, 78690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_78628_78691(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 78628, 78691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 78453, 78703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 78453, 78703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol GetWellKnownType(CSharpCompilation compilation, WellKnownType type, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 78715, 79176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 78885, 78949);

                NamedTypeSymbol
                typeSymbol = f_10319_78914_78948(compilation, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 78963, 79059);

                f_10319_78963_79058((object)typeSymbol != null, "Expect an error type if well-known type isn't found");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79073, 79133);

                f_10319_79073_79132(typeSymbol, diagnostics, location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79147, 79165);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 78715, 79176);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_78914_78948(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 78914, 78948);
                    return return_v;
                }


                int
                f_10319_78963_79058(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 78963, 79058);
                    return 0;
                }


                bool
                f_10319_79073_79132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 79073, 79132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 78715, 79176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 78715, 79176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetWellKnownType(WellKnownType type, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 79375, 79839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79509, 79578);

                NamedTypeSymbol
                typeSymbol = f_10319_79538_79577(f_10319_79538_79554(this), type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79592, 79688);

                f_10319_79592_79687((object)typeSymbol != null, "Expect an error type if well-known type isn't found");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79702, 79796);

                f_10319_79702_79795(ref useSiteDiagnostics, f_10319_79761_79794(typeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 79810, 79828);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 79375, 79839);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_79538_79554(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 79538, 79554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_79538_79577(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 79538, 79577);
                    return return_v;
                }


                int
                f_10319_79592_79687(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 79592, 79687);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_79761_79794(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 79761, 79794);
                    return return_v;
                }


                bool
                f_10319_79702_79795(ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = HashSetExtensions.InitializeAndAdd(ref hashSet, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 79702, 79795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 79375, 79839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 79375, 79839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol GetWellKnownTypeMember(CSharpCompilation compilation, WellKnownMember member, DiagnosticBag diagnostics, Location location = null, SyntaxNode syntax = null, bool isOptional = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 80034, 80785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80263, 80315);

                f_10319_80263_80314((syntax != null) ^ (location != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80331, 80364);

                DiagnosticInfo
                useSiteDiagnostic
                = default(DiagnosticInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80378, 80479);

                Symbol
                memberSymbol = f_10319_80400_80478(compilation, member, out useSiteDiagnostic, isOptional)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80495, 80738) || true) && (useSiteDiagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 80495, 80738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80631, 80723);

                    f_10319_80631_80722(useSiteDiagnostic, diagnostics, location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10319, 80694, 80721) ?? f_10319_80706_80721(syntax)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 80495, 80738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80754, 80774);

                return memberSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 80034, 80785);

                int
                f_10319_80263_80314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 80263, 80314);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_80400_80478(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo, bool
                isOptional)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, out diagnosticInfo, isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 80400, 80478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_80706_80721(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 80706, 80721);
                    return return_v;
                }


                bool
                f_10319_80631_80722(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 80631, 80722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 80034, 80785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 80034, 80785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol GetWellKnownTypeMember(CSharpCompilation compilation, WellKnownMember member, out DiagnosticInfo diagnosticInfo, bool isOptional = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 80797, 82547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 80982, 81047);

                Symbol
                memberSymbol = f_10319_81004_81046(compilation, member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81063, 82500) || true) && ((object)memberSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 81063, 82500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81129, 81207);

                    diagnosticInfo = f_10319_81146_81206(memberSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81225, 82039) || true) && (diagnosticInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 81225, 82039);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81541, 82020) || true) && (isOptional)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 81541, 82020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81605, 81644);

                            var
                            severity = f_10319_81620_81643(diagnosticInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81717, 81739);

                            diagnosticInfo = null;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81860, 81997) || true) && (severity == DiagnosticSeverity.Error)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 81860, 81997);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 81958, 81970);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 81860, 81997);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 81541, 82020);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 81225, 82039);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 81063, 82500);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 81063, 82500);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82073, 82500) || true) && (!isOptional)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82073, 82500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82160, 82235);

                        MemberDescriptor
                        memberDescriptor = f_10319_82196_82234(member)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82253, 82397);

                        diagnosticInfo = f_10319_82270_82396(ErrorCode.ERR_MissingPredefinedMember, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82073, 82500);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82073, 82500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82463, 82485);

                        diagnosticInfo = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82073, 82500);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 81063, 82500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82516, 82536);

                return memberSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 80797, 82547);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10319_81004_81046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 81004, 81046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_81146_81206(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnosticForSymbolOrContainingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 81146, 81206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10319_81620_81643(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 81620, 81643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10319_82196_82234(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 82196, 82234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_82270_82396(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 82270, 82396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 80797, 82547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 80797, 82547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class ConsistentSymbolOrder : IComparer<Symbol>
        {
            public static readonly ConsistentSymbolOrder Instance;

            public int Compare(Symbol fst, Symbol snd)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 82737, 84013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82812, 82837) || true) && (snd == fst)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82812, 82837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82828, 82837);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82812, 82837);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82855, 82890) || true) && ((object)fst == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82855, 82890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82880, 82890);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82855, 82890);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82908, 82942) || true) && ((object)snd == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82908, 82942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82933, 82942);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82908, 82942);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82960, 83035) || true) && (f_10319_82964_82972(snd) != f_10319_82976_82984(fst))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 82960, 83035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82986, 83035);

                        return f_10319_82993_83034(f_10319_83015_83023(fst), f_10319_83025_83033(snd));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 82960, 83035);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83053, 83116) || true) && (f_10319_83057_83065(snd) != f_10319_83069_83077(fst))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83053, 83116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83079, 83116);

                        return (int)f_10319_83091_83099(fst) - (int)f_10319_83107_83115(snd);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83053, 83116);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83134, 83208);

                    int
                    aLocationsCount = (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 83156, 83180) || ((f_10319_83156_83180_M(!snd.Locations.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 83183, 83203)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 83206, 83207))) ? snd.Locations.Length : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83226, 83269);

                    int
                    bLocationsCount = fst.Locations.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83287, 83368) || true) && (aLocationsCount != bLocationsCount)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83287, 83368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83327, 83368);

                        return aLocationsCount - bLocationsCount;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83287, 83368);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83386, 83495) || true) && (aLocationsCount == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10319, 83390, 83434) && bLocationsCount == 0))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83386, 83495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83436, 83495);

                        return f_10319_83443_83494(this, f_10319_83451_83471(fst), f_10319_83473_83493(snd));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83386, 83495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83513, 83544);

                    Location
                    la = f_10319_83527_83540(snd)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83562, 83593);

                    Location
                    lb = f_10319_83576_83589(fst)[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83611, 83677) || true) && (f_10319_83615_83628(la) != f_10319_83632_83645(lb))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83611, 83677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83647, 83677);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 83654, 83667) || ((f_10319_83654_83667(la) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 83670, 83671)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 83674, 83676))) ? 1 : -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83611, 83677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83695, 83769);

                    int
                    containerResult = f_10319_83717_83768(this, f_10319_83725_83745(fst), f_10319_83747_83767(snd))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83787, 83830) || true) && (f_10319_83791_83805_M(!la.IsInSource))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83787, 83830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83807, 83830);

                        return containerResult;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83787, 83830);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83848, 83957) || true) && (containerResult == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10319, 83852, 83906) && f_10319_83876_83889(la) == f_10319_83893_83906(lb)))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 83848, 83957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83908, 83957);

                        return lb.SourceSpan.Start - la.SourceSpan.Start;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 83848, 83957);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 83975, 83998);

                    return containerResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 82737, 84013);

                    string
                    f_10319_82964_82972(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 82964, 82972);
                        return return_v;
                    }


                    string
                    f_10319_82976_82984(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 82976, 82984);
                        return return_v;
                    }


                    string
                    f_10319_83015_83023(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83015, 83023);
                        return return_v;
                    }


                    string
                    f_10319_83025_83033(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83025, 83033);
                        return return_v;
                    }


                    int
                    f_10319_82993_83034(string
                    strA, string
                    strB)
                    {
                        var return_v = string.CompareOrdinal(strA, strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 82993, 83034);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10319_83057_83065(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83057, 83065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10319_83069_83077(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83069, 83077);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10319_83091_83099(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83091, 83099);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10319_83107_83115(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83107, 83115);
                        return return_v;
                    }


                    bool
                    f_10319_83156_83180_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83156, 83180);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10319_83451_83471(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83451, 83471);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10319_83473_83493(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83473, 83493);
                        return return_v;
                    }


                    int
                    f_10319_83443_83494(Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    fst, Microsoft.CodeAnalysis.CSharp.Symbol
                    snd)
                    {
                        var return_v = this_param.Compare(fst, snd);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 83443, 83494);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10319_83527_83540(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83527, 83540);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10319_83576_83589(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83576, 83589);
                        return return_v;
                    }


                    bool
                    f_10319_83615_83628(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83615, 83628);
                        return return_v;
                    }


                    bool
                    f_10319_83632_83645(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83632, 83645);
                        return return_v;
                    }


                    bool
                    f_10319_83654_83667(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83654, 83667);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10319_83725_83745(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83725, 83745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10319_83747_83767(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83747, 83767);
                        return return_v;
                    }


                    int
                    f_10319_83717_83768(Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    fst, Microsoft.CodeAnalysis.CSharp.Symbol
                    snd)
                    {
                        var return_v = this_param.Compare(fst, snd);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 83717, 83768);
                        return return_v;
                    }


                    bool
                    f_10319_83791_83805_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83791, 83805);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10319_83876_83889(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83876, 83889);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10319_83893_83906(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 83893, 83906);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 82737, 84013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 82737, 84013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ConsistentSymbolOrder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10319, 82559, 84024);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10319, 82559, 84024);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 82559, 84024);
            }


            static ConsistentSymbolOrder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10319, 82559, 84024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 82684, 82722);
                Instance = f_10319_82695_82722(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10319, 82559, 84024);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 82559, 84024);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10319, 82559, 84024);

            static Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder
            f_10319_82695_82722()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 82695, 82722);
                return return_v;
            }

        }

        internal Symbol ResultSymbol(
                    LookupResult result,
                    string simpleName,
                    int arity,
                    SyntaxNode where,
                    DiagnosticBag diagnostics,
                    bool suppressUseSiteDiagnostics,
                    out bool wasError,
                    NamespaceOrTypeSymbol qualifierOpt = null,
                    LookupOptions options = default(LookupOptions))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 84124, 109887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 84534, 84675);

                Symbol
                symbol = f_10319_84550_84674(result, simpleName, arity, where, diagnostics, suppressUseSiteDiagnostics, out wasError, qualifierOpt, options)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 84691, 84861) || true) && (f_10319_84695_84706(symbol) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 84691, 84861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 84764, 84846);

                    f_10319_84764_84845(this, where, receiverOpt: null, symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 84691, 84861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 84877, 84891);

                return symbol;

                Symbol resultSymbol(
                                LookupResult result,
                                string simpleName,
                                int arity,
                                SyntaxNode where,
                                DiagnosticBag diagnostics,
                                bool suppressUseSiteDiagnostics,
                                out bool wasError,
                                NamespaceOrTypeSymbol qualifierOpt,
                                LookupOptions options)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 84907, 109876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85320, 85348);

                        f_10319_85320_85347(where != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85366, 85400);

                        f_10319_85366_85399(diagnostics != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85420, 85449);

                        var
                        symbols = f_10319_85434_85448(result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85467, 85484);

                        wasError = false;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85504, 106825) || true) && (f_10319_85508_85528(result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 85504, 106825);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85570, 106806) || true) && (f_10319_85574_85587(symbols) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 85570, 106806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85705, 85750);

                                f_10319_85705_85749(                        // gracefully handle symbols.Count > 2
                                                        symbols, ConsistentSymbolOrder.Instance);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85778, 85822);

                                var
                                originalSymbols = f_10319_85800_85821(symbols)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85859, 85864);

                                    for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85850, 86030) || true) && (i < f_10319_85870_85883(symbols))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85885, 85888)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 85850, 86030))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 85850, 86030);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 85946, 86003);

                                        symbols[i] = f_10319_85959_86002(this, f_10319_85971_85981(symbols, i), diagnostics, where);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 181);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 181);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86058, 86084);

                                BestSymbolInfo
                                secondBest
                                = default(BestSymbolInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86110, 86175);

                                BestSymbolInfo
                                best = f_10319_86132_86174(this, symbols, out secondBest)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86203, 86230);

                                f_10319_86203_86229(f_10319_86216_86228_M(!best.IsNone));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86256, 86289);

                                f_10319_86256_86288(f_10319_86269_86287_M(!secondBest.IsNone));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86317, 90043) || true) && (best.IsFromCompilation && (DynAbs.Tracing.TraceSender.Expression_True(10319, 86321, 86376) && f_10319_86347_86376_M(!secondBest.IsFromCompilation)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 86317, 90043);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86434, 86470);

                                    var
                                    srcSymbol = f_10319_86450_86469(symbols, best.Index)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86500, 86541);

                                    var
                                    mdSymbol = f_10319_86515_86540(symbols, secondBest.Index)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86573, 86585);

                                    object
                                    arg0
                                    = default(object);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86617, 87031) || true) && (best.IsFromSourceModule)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 86617, 87031);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86710, 86765);

                                        arg0 = f_10319_86717_86764(f_10319_86717_86755(srcSymbol.Locations.First()));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 86617, 87031);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 86617, 87031);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86895, 86932);

                                        f_10319_86895_86931(best.IsFromAddedModule);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 86966, 87000);

                                        arg0 = f_10319_86973_86999(srcSymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 86617, 87031);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 87173, 90016) || true) && (f_10319_87177_87226(srcSymbol, mdSymbol))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 87173, 90016);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 87292, 89985) || true) && (f_10319_87296_87310(srcSymbol) == SymbolKind.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(10319, 87296, 87375) && f_10319_87338_87351(mdSymbol) == SymbolKind.NamedType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 87292, 89985);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 87642, 87948);

                                            f_10319_87642_87947(                                    // ErrorCode.WRN_SameFullNameThisNsAgg: The namespace '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the namespace defined in '{0}'.
                                                                                diagnostics, ErrorCode.WRN_SameFullNameThisNsAgg, f_10319_87695_87709(where), originalSymbols, arg0, srcSymbol, f_10319_87868_87895(mdSymbol), mdSymbol);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 87988, 88023);

                                            return originalSymbols[best.Index];
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 87292, 89985);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 87292, 89985);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 88097, 89985) || true) && (f_10319_88101_88115(srcSymbol) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 88101, 88180) && f_10319_88143_88156(mdSymbol) == SymbolKind.Namespace))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 88097, 89985);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 88442, 88752);

                                                f_10319_88442_88751(                                    // ErrorCode.WRN_SameFullNameThisAggNs: The type '{1}' in '{0}' conflicts with the imported namespace '{3}' in '{2}'. Using the type defined in '{0}'.
                                                                                    diagnostics, ErrorCode.WRN_SameFullNameThisAggNs, f_10319_88495_88509(where), originalSymbols, arg0, srcSymbol, f_10319_88668_88699(mdSymbol), mdSymbol);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 88792, 88827);

                                                return originalSymbols[best.Index];
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 88097, 89985);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 88097, 89985);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 88901, 89985) || true) && (f_10319_88905_88919(srcSymbol) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 88905, 88984) && f_10319_88947_88960(mdSymbol) == SymbolKind.NamedType))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 88901, 89985);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 89232, 89539);

                                                    f_10319_89232_89538(                                    // WRN_SameFullNameThisAggAgg: The type '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the type defined in '{0}'.
                                                                                        diagnostics, ErrorCode.WRN_SameFullNameThisAggAgg, f_10319_89286_89300(where), originalSymbols, arg0, srcSymbol, f_10319_89459_89486(mdSymbol), mdSymbol);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 89579, 89614);

                                                    return originalSymbols[best.Index];
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 88901, 89985);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 88901, 89985);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 89853, 89950);

                                                    f_10319_89853_89949(!(f_10319_89868_89882(srcSymbol) == SymbolKind.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(10319, 89868, 89947) && f_10319_89910_89923(mdSymbol) == SymbolKind.Namespace)));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 88901, 89985);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 88097, 89985);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 87292, 89985);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 87173, 90016);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 86317, 90043);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90071, 90103);

                                var
                                first = f_10319_90083_90102(symbols, best.Index)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90129, 90168);

                                var
                                second = f_10319_90142_90167(symbols, secondBest.Index)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90196, 90448);

                                f_10319_90196_90447(!f_10319_90210_90323(originalSymbols[best.Index], originalSymbols[secondBest.Index], TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 90209, 90358) || f_10319_90327_90358(options)), "This kind of ambiguity is only possible for attributes.");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90476, 90763);

                                f_10319_90476_90762(!f_10319_90490_90554(first, second, TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 90489, 90672) || !f_10319_90559_90672(originalSymbols[best.Index], originalSymbols[secondBest.Index], TypeCompareKind.ConsiderEverything)), "Why does the LookupResult contain the same symbol twice?");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90791, 90813);

                                CSDiagnosticInfo
                                info
                                = default(CSDiagnosticInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90839, 90856);

                                bool
                                reportError
                                = default(bool);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 90990, 103278) || true) && (first != second && (DynAbs.Tracing.TraceSender.Expression_True(10319, 90994, 91085) && f_10319_91042_91085(first, second)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 90990, 103278);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 91346, 91420);

                                    reportError = !(best.IsFromSourceModule && (DynAbs.Tracing.TraceSender.Expression_True(10319, 91362, 91418) && secondBest.IsFromSourceModule));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 91452, 100231) || true) && (f_10319_91456_91466(first) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 91456, 91529) && f_10319_91494_91505(second) == SymbolKind.NamedType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 91452, 100231);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 91595, 94593) || true) && (f_10319_91599_91623(first) == f_10319_91627_91652(second))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 91595, 94593);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 91931, 91950);

                                            reportError = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 92086, 92631);

                                            info = f_10319_92093_92630(ErrorCode.ERR_AmbigContext, originalSymbols, new object[] {
                                            // LAFHIS
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 92312, 92333)||(((where is NameSyntax) &&DynAbs.Tracing.TraceSender.Conditional_F2(10319, 92336, 92374))||DynAbs.Tracing.TraceSender.Conditional_F3(10319, 92377, 92381)))?f_10319_92336_92374(((NameSyntax)where)):null) ??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(10319, 92311, 92396)??simpleName),
f_10319_92439_92511(first, f_10319_92466_92510()),
f_10319_92554_92627(second, f_10319_92582_92626())});
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 91595, 94593);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 91595, 94593);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 92777, 92814);

                                            f_10319_92777_92813(f_10319_92790_92812_M(!best.IsFromCorLibrary));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 92974, 93171);

                                            info = f_10319_92981_93170(ErrorCode.ERR_SameFullNameAggAgg, originalSymbols, new object[] { f_10319_93109_93133(first), first, f_10319_93142_93167(second) });

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 93679, 94558) || true) && (secondBest.IsFromAddedModule)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 93679, 94558);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 93793, 93830);

                                                f_10319_93793_93829(best.IsFromCompilation);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 93872, 93892);

                                                reportError = false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 93679, 94558);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 93679, 94558);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 93974, 94558) || true) && (f_10319_93978_94042(this.Flags, BinderFlags.IgnoreCorLibraryDuplicatedTypes) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 93978, 94114) && secondBest.IsFromCorLibrary))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 93974, 94558);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 94506, 94519);

                                                    return first;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 93974, 94558);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 93679, 94558);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 91595, 94593);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 91452, 100231);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 91452, 100231);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 94659, 100231) || true) && (f_10319_94663_94673(first) == SymbolKind.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(10319, 94663, 94736) && f_10319_94701_94712(second) == SymbolKind.NamedType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 94659, 100231);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 94939, 95143);

                                            info = f_10319_94946_95142(ErrorCode.ERR_SameFullNameNsAgg, originalSymbols, new object[] { f_10319_95069_95097(first), first, f_10319_95106_95131(second), second });

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 95418, 95606) || true) && (best.IsFromSourceModule && (DynAbs.Tracing.TraceSender.Expression_True(10319, 95422, 95477) && secondBest.IsFromAddedModule))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 95418, 95606);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 95551, 95571);

                                                reportError = false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 95418, 95606);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 94659, 100231);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 94659, 100231);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 95672, 100231) || true) && (f_10319_95676_95686(first) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 95676, 95749) && f_10319_95714_95725(second) == SymbolKind.Namespace))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 95672, 100231);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 95815, 98780) || true) && (f_10319_95819_95848_M(!secondBest.IsFromCompilation) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 95819, 95881) || secondBest.IsFromSourceModule))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 95815, 98780);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 96096, 96304);

                                                    info = f_10319_96103_96303(ErrorCode.ERR_SameFullNameNsAgg, originalSymbols, new object[] { f_10319_96230_96259(second), second, f_10319_96269_96293(first), first });
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 95815, 98780);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 95815, 98780);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 96450, 96493);

                                                    f_10319_96450_96492(secondBest.IsFromAddedModule);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 96682, 96694);

                                                    object
                                                    arg0
                                                    = default(object);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 96734, 97204) || true) && (best.IsFromSourceModule)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 96734, 97204);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 96843, 96894);

                                                        arg0 = f_10319_96850_96893(f_10319_96850_96884(first.Locations.First()));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 96734, 97204);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 96734, 97204);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97056, 97093);

                                                        f_10319_97056_97092(best.IsFromAddedModule);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97135, 97165);

                                                        arg0 = f_10319_97142_97164(first);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 96734, 97204);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97244, 97288);

                                                    ModuleSymbol
                                                    arg2 = f_10319_97264_97287(second)
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97560, 98432) || true) && ((object)arg2 == null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 97560, 98432);
                                                        try
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97666, 98393);
                                                            foreach (NamespaceSymbol ns in f_10319_97697_97744_I(f_10319_97697_97744(((NamespaceSymbol)second))))
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 97666, 98393);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97834, 98350) || true) && (f_10319_97838_97859(ns) == f_10319_97863_97883(f_10319_97863_97874()))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 97834, 98350);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 97981, 98023);

                                                                    ModuleSymbol
                                                                    module = f_10319_98003_98022(ns)
                                                                    ;

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 98075, 98303) || true) && ((object)arg2 == null || (DynAbs.Tracing.TraceSender.Expression_False(10319, 98079, 98132) || f_10319_98103_98115(arg2) > f_10319_98118_98132(module)))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 98075, 98303);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 98238, 98252);

                                                                        arg2 = module;
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 98075, 98303);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 97834, 98350);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 97666, 98393);
                                                            }
                                                        }
                                                        catch (System.Exception)
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 728);
                                                            throw;
                                                        }
                                                        finally
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 728);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 97560, 98432);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 98472, 98534);

                                                    f_10319_98472_98533(f_10319_98485_98508(arg2) == f_10319_98512_98532(f_10319_98512_98523()));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 98574, 98745);

                                                    info = f_10319_98581_98744(ErrorCode.ERR_SameFullNameThisAggThisNs, originalSymbols, new object[] { arg0, first, arg2, second });
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 95815, 98780);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 95672, 100231);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 95672, 100231);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 98846, 100231) || true) && (f_10319_98850_98860(first) == SymbolKind.RangeVariable && (DynAbs.Tracing.TraceSender.Expression_True(10319, 98850, 98931) && f_10319_98892_98903(second) == SymbolKind.RangeVariable))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 98846, 100231);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 99105, 99246);

                                                    info = f_10319_99112_99245(ErrorCode.ERR_AmbigMember, originalSymbols, new object[] { first, second });
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 98846, 100231);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 98846, 100231);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100004, 100145);

                                                    info = f_10319_100011_100144(ErrorCode.ERR_AmbigMember, originalSymbols, new object[] { first, second });
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100181, 100200);

                                                    reportError = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 98846, 100231);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 95672, 100231);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 94659, 100231);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 91452, 100231);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 90990, 103278);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 90990, 103278);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100345, 100717);

                                    f_10319_100345_100716(f_10319_100358_100390(originalSymbols[best.Index]) != f_10319_100394_100432(originalSymbols[secondBest.Index]) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 100358, 100592) || !f_10319_100479_100592(originalSymbols[best.Index], originalSymbols[secondBest.Index], TypeCompareKind.ConsiderEverything)), "Why was the lookup result viable if it contained non-equal symbols with the same name?");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100749, 100768);

                                    reportError = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100800, 103251) || true) && (first is NamespaceOrTypeSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100804, 100869) && second is NamespaceOrTypeSymbol))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 100800, 103251);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 100935, 102871) || true) && (f_10319_100939_100970(options) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100939, 101045) && f_10319_101011_101021(first) == SymbolKind.NamedType) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100939, 101121) && f_10319_101086_101097(second) == SymbolKind.NamedType) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100939, 101236) && f_10319_101162_101194(originalSymbols[best.Index]) != f_10319_101198_101236(originalSymbols[secondBest.Index])) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100939, 101362) && f_10319_101311_101362(f_10319_101311_101322(), (NamedTypeSymbol)first)) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 100939, 101455) && f_10319_101403_101455(f_10319_101403_101414(), (NamedTypeSymbol)second)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 100935, 102871);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 101759, 102049);

                                            info = f_10319_101766_102048(ErrorCode.ERR_AmbiguousAttribute, originalSymbols, new object[] { ((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 101946, 101967) || (((where is NameSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 101970, 102008)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 102011, 102015))) ? f_10319_101970_102008(((NameSyntax)where)) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10319, 101945, 102030) ?? simpleName), first, second });
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 100935, 102871);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 100935, 102871);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 102291, 102836);

                                            info = f_10319_102298_102835(ErrorCode.ERR_AmbigContext, originalSymbols, new object[] {
                                            // LAFHIS
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 102517, 102538)||(((where is NameSyntax) &&DynAbs.Tracing.TraceSender.Conditional_F2(10319, 102541, 102579))||DynAbs.Tracing.TraceSender.Conditional_F3(10319, 102582, 102586)))?f_10319_102541_102579(((NameSyntax)where)):null) ??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(10319, 102516, 102601)??simpleName),
f_10319_102644_102716(first, f_10319_102671_102715()),
f_10319_102759_102832(second, f_10319_102787_102831())});
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 100935, 102871);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 100800, 103251);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 100800, 103251);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103079, 103220);

                                        info = f_10319_103086_103219(ErrorCode.ERR_AmbigMember, originalSymbols, new object[] { first, second });
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 100800, 103251);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 90990, 103278);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103306, 103322);

                                wasError = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103350, 103488) || true) && (reportError)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 103350, 103488);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103423, 103461);

                                    f_10319_103423_103460(diagnostics, info, f_10319_103445_103459(where));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 103350, 103488);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103516, 103805);

                                return f_10319_103523_103804(f_10319_103581_103629(this, originalSymbols[0]), originalSymbols, LookupResultKind.Ambiguous, info, arity);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 85570, 106806);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 85570, 106806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 103953, 103983);

                                var
                                singleResult = f_10319_103972_103982(symbols, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104078, 104122);

                                var
                                singleType = singleResult as TypeSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104148, 106735) || true) && ((object)singleType != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 104152, 104240) && f_10319_104182_104210(singleType) == Cci.PrimitiveTypeCode.Void) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 104152, 104264) && simpleName == "Void"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 104148, 106735);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104322, 104338);

                                    wasError = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104368, 104431);

                                    var
                                    errorInfo = f_10319_104384_104430(ErrorCode.ERR_SystemVoid)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104461, 104504);

                                    f_10319_104461_104503(diagnostics, errorInfo, f_10319_104488_104502(where));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104534, 104680);

                                    singleResult = f_10319_104549_104679(f_10319_104577_104619(this, singleResult), singleResult, LookupResultKind.NotReferencable, errorInfo);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 104148, 106735);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 104148, 106735);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 104874, 105336) || true) && (f_10319_104878_104895(singleResult) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10319, 104878, 105040) && f_10319_104956_105040(((SourceModuleSymbol)f_10319_104977_105006(f_10319_104977_104993(this))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 104874, 105336);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105200, 105305);

                                        f_10319_105200_105304(singleResult, where, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 104874, 105336);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105368, 106708) || true) && (!suppressUseSiteDiagnostics)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 105368, 106708);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105465, 105535);

                                        wasError = f_10319_105476_105534(singleResult, diagnostics, where);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 105368, 106708);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 105368, 106708);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105601, 106708) || true) && (f_10319_105605_105622(singleResult) == SymbolKind.ErrorType)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 105601, 106708);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105890, 105936);

                                            var
                                            errorType = (ErrorTypeSymbol)singleResult
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 105972, 106677) || true) && (f_10319_105976_105996(errorType))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 105972, 106677);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106070, 106117);

                                                DiagnosticInfo
                                                errorInfo = f_10319_106097_106116(errorType)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106157, 106642) || true) && (errorInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 106161, 106231) && f_10319_106182_106196(errorInfo) == (int)ErrorCode.ERR_CircularBase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 106157, 106642);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106313, 106329);

                                                    wasError = true;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106371, 106414);

                                                    f_10319_106371_106413(diagnostics, errorInfo, f_10319_106398_106412(where));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106456, 106603);

                                                    singleResult = f_10319_106471_106602(f_10319_106499_106538(this, errorType), f_10319_106540_106554(errorType), f_10319_106556_106571(errorType), errorInfo, unreported: false);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 106157, 106642);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 105972, 106677);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 105601, 106708);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 105368, 106708);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 104148, 106735);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106763, 106783);

                                return singleResult;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 85570, 106806);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 85504, 106825);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106955, 106971);

                        wasError = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 106991, 107985) || true) && (f_10319_106995_107006(result) == LookupResultKind.Empty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 106991, 107985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107074, 107097);

                            string
                            aliasOpt = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107119, 107143);

                            SyntaxNode
                            node = where
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107165, 107554) || true) && (node is ExpressionSyntax)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 107165, 107554);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107246, 107486) || true) && (f_10319_107250_107261(node) == SyntaxKind.AliasQualifiedName)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 107246, 107486);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107352, 107423);

                                        aliasOpt = f_10319_107363_107401(((AliasQualifiedNameSyntax)node)).Identifier.ValueText;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10319, 107453, 107459);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 107246, 107486);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107512, 107531);

                                    node = f_10319_107519_107530(node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 107165, 107554);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 107165, 107554);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 107165, 107554);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107578, 107830);

                            CSDiagnosticInfo
                            info = f_10319_107602_107829(this, where, simpleName, arity, ((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 107698, 107719) || (((where is NameSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 107722, 107760)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 107763, 107767))) ? f_10319_107722_107760(((NameSyntax)where)) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10319, 107697, 107782) ?? simpleName), diagnostics, aliasOpt, qualifierOpt, options)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 107852, 107966);

                            return f_10319_107859_107965(qualifierOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>(10319, 107887, 107939) ?? f_10319_107903_107939(f_10319_107903_107923(f_10319_107903_107914()))), simpleName, arity, info);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 106991, 107985);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108005, 108037);

                        f_10319_108005_108036(f_10319_108018_108031(symbols) > 0);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108140, 108400) || true) && (!suppressUseSiteDiagnostics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 108140, 108400);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108222, 108227);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108213, 108381) || true) && (i < f_10319_108233_108246(symbols))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108248, 108251)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 108213, 108381))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 108213, 108381);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108301, 108358);

                                    f_10319_108301_108357(f_10319_108326_108336(symbols, i), diagnostics, where);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 169);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 108140, 108400);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108582, 108854) || true) && (f_10319_108586_108598(result) != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 108586, 108706) && ((object)qualifierOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10319, 108632, 108705) || f_10319_108664_108681(qualifierOpt) != SymbolKind.ErrorType))))
                        ) // Suppress cascading.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 108582, 108854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108771, 108835);

                            f_10319_108771_108834(diagnostics, f_10319_108787_108833(f_10319_108804_108816(result), f_10319_108818_108832(where)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 108582, 108854);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 108874, 109861) || true) && ((f_10319_108879_108892(symbols) > 1) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 108878, 108967) || (f_10319_108902_108912(symbols, 0) is NamespaceOrTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10319, 108902, 108966) || f_10319_108941_108951(symbols, 0) is AliasSymbol))) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 108878, 109043) || f_10319_108992_109003(result) == LookupResultKind.NotATypeOrNamespace) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 108878, 109097) || f_10319_109047_109058(result) == LookupResultKind.NotAnAttributeType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 108874, 109861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 109500, 109634);

                            return f_10319_109507_109633(f_10319_109535_109575(this, f_10319_109564_109574(symbols, 0)), f_10319_109577_109598(symbols), f_10319_109600_109611(result), f_10319_109613_109625(result), arity);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 108874, 109861);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 108874, 109861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 109824, 109842);

                            return f_10319_109831_109841(symbols, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 108874, 109861);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 84907, 109876);

                        int
                        f_10319_85320_85347(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 85320, 85347);
                            return 0;
                        }


                        int
                        f_10319_85366_85399(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 85366, 85399);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10319_85434_85448(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Symbols;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 85434, 85448);
                            return return_v;
                        }


                        bool
                        f_10319_85508_85528(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.IsMultiViable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 85508, 85528);
                            return return_v;
                        }


                        int
                        f_10319_85574_85587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 85574, 85587);
                            return return_v;
                        }


                        int
                        f_10319_85705_85749(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder
                        comparer)
                        {
                            this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 85705, 85749);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10319_85800_85821(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 85800, 85821);
                            return return_v;
                        }


                        int
                        f_10319_85870_85883(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 85870, 85883);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_85971_85981(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 85971, 85981);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_85959_86002(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = this_param.UnwrapAlias(symbol, diagnostics, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 85959, 86002);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                        f_10319_86132_86174(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, out Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                        secondBest)
                        {
                            var return_v = this_param.GetBestSymbolInfo(symbols, out secondBest);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 86132, 86174);
                            return return_v;
                        }


                        bool
                        f_10319_86216_86228_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86216, 86228);
                            return return_v;
                        }


                        int
                        f_10319_86203_86229(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 86203, 86229);
                            return 0;
                        }


                        bool
                        f_10319_86269_86287_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86269, 86287);
                            return return_v;
                        }


                        int
                        f_10319_86256_86288(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 86256, 86288);
                            return 0;
                        }


                        bool
                        f_10319_86347_86376_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86347, 86376);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_86450_86469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86450, 86469);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_86515_86540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86515, 86540);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree?
                        f_10319_86717_86755(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86717, 86755);
                            return return_v;
                        }


                        string
                        f_10319_86717_86764(Microsoft.CodeAnalysis.SyntaxTree?
                        this_param)
                        {
                            var return_v = this_param.FilePath;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86717, 86764);
                            return return_v;
                        }


                        int
                        f_10319_86895_86931(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 86895, 86931);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10319_86973_86999(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 86973, 86999);
                            return return_v;
                        }


                        bool
                        f_10319_87177_87226(Microsoft.CodeAnalysis.CSharp.Symbol
                        x, Microsoft.CodeAnalysis.CSharp.Symbol
                        y)
                        {
                            var return_v = NameAndArityMatchRecursively(x, y);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 87177, 87226);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_87296_87310(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 87296, 87310);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_87338_87351(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 87338, 87351);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_87695_87709(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 87695, 87709);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_87868_87895(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 87868, 87895);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_87642_87947(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 87642, 87947);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_88101_88115(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 88101, 88115);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_88143_88156(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 88143, 88156);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_88495_88509(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 88495, 88509);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_88668_88699(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = GetContainingAssembly(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 88668, 88699);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_88442_88751(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 88442, 88751);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_88905_88919(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 88905, 88919);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_88947_88960(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 88947, 88960);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_89286_89300(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 89286, 89300);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_89459_89486(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 89459, 89486);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_89232_89538(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 89232, 89538);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_89868_89882(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 89868, 89882);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_89910_89923(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 89910, 89923);
                            return return_v;
                        }


                        int
                        f_10319_89853_89949(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 89853, 89949);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_90083_90102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 90083, 90102);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_90142_90167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 90142, 90167);
                            return return_v;
                        }


                        bool
                        f_10319_90210_90323(Microsoft.CodeAnalysis.CSharp.Symbol
                        first, Microsoft.CodeAnalysis.CSharp.Symbol
                        second, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = Symbol.Equals(first, second, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90210, 90323);
                            return return_v;
                        }


                        bool
                        f_10319_90327_90358(Microsoft.CodeAnalysis.CSharp.LookupOptions
                        options)
                        {
                            var return_v = options.IsAttributeTypeLookup();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90327, 90358);
                            return return_v;
                        }


                        int
                        f_10319_90196_90447(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90196, 90447);
                            return 0;
                        }


                        bool
                        f_10319_90490_90554(Microsoft.CodeAnalysis.CSharp.Symbol
                        first, Microsoft.CodeAnalysis.CSharp.Symbol
                        second, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = Symbol.Equals(first, second, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90490, 90554);
                            return return_v;
                        }


                        bool
                        f_10319_90559_90672(Microsoft.CodeAnalysis.CSharp.Symbol
                        first, Microsoft.CodeAnalysis.CSharp.Symbol
                        second, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = Symbol.Equals(first, second, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90559, 90672);
                            return return_v;
                        }


                        int
                        f_10319_90476_90762(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 90476, 90762);
                            return 0;
                        }


                        bool
                        f_10319_91042_91085(Microsoft.CodeAnalysis.CSharp.Symbol
                        x, Microsoft.CodeAnalysis.CSharp.Symbol
                        y)
                        {
                            var return_v = NameAndArityMatchRecursively(x, y);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 91042, 91085);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_91456_91466(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 91456, 91466);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_91494_91505(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 91494, 91505);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_91599_91623(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 91599, 91623);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_91627_91652(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 91627, 91652);
                            return return_v;
                        }


                        string
                        f_10319_92336_92374(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                        this_param)
                        {
                            var return_v = this_param.ErrorDisplayName();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92336, 92374);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolDisplayFormat
                        f_10319_92466_92510()
                        {
                            var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 92466, 92510);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FormattedSymbol
                        f_10319_92439_92511(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                        symbolDisplayFormat)
                        {
                            var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92439, 92511);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolDisplayFormat
                        f_10319_92582_92626()
                        {
                            var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 92582, 92626);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FormattedSymbol
                        f_10319_92554_92627(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                        symbolDisplayFormat)
                        {
                            var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92554, 92627);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_92093_92630(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92093, 92630);
                            return return_v;
                        }


                        bool
                        f_10319_92790_92812_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 92790, 92812);
                            return return_v;
                        }


                        int
                        f_10319_92777_92813(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92777, 92813);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_93109_93133(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 93109, 93133);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_93142_93167(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 93142, 93167);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_92981_93170(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 92981, 93170);
                            return return_v;
                        }


                        int
                        f_10319_93793_93829(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 93793, 93829);
                            return 0;
                        }


                        bool
                        f_10319_93978_94042(Microsoft.CodeAnalysis.CSharp.BinderFlags
                        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                        other)
                        {
                            var return_v = self.Includes(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 93978, 94042);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_94663_94673(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 94663, 94673);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_94701_94712(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 94701, 94712);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_95069_95097(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = GetContainingAssembly(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 95069, 95097);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_95106_95131(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 95106, 95131);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_94946_95142(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 94946, 95142);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_95676_95686(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 95676, 95686);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_95714_95725(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 95714, 95725);
                            return return_v;
                        }


                        bool
                        f_10319_95819_95848_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 95819, 95848);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_96230_96259(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = GetContainingAssembly(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 96230, 96259);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_96269_96293(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 96269, 96293);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_96103_96303(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 96103, 96303);
                            return return_v;
                        }


                        int
                        f_10319_96450_96492(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 96450, 96492);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree?
                        f_10319_96850_96884(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 96850, 96884);
                            return return_v;
                        }


                        string
                        f_10319_96850_96893(Microsoft.CodeAnalysis.SyntaxTree?
                        this_param)
                        {
                            var return_v = this_param.FilePath;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 96850, 96893);
                            return return_v;
                        }


                        int
                        f_10319_97056_97092(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 97056, 97092);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10319_97142_97164(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97142, 97164);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10319_97264_97287(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97264, 97287);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                        f_10319_97697_97744(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.ConstituentNamespaces;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97697, 97744);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_97838_97859(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97838, 97859);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_97863_97874()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97863, 97874);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_97863_97883(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 97863, 97883);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10319_98003_98022(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98003, 98022);
                            return return_v;
                        }


                        int
                        f_10319_98103_98115(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98103, 98115);
                            return return_v;
                        }


                        int
                        f_10319_98118_98132(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98118, 98132);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                        f_10319_97697_97744_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 97697, 97744);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_98485_98508(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol?
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98485, 98508);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_98512_98523()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98512, 98523);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_98512_98532(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98512, 98532);
                            return return_v;
                        }


                        int
                        f_10319_98472_98533(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 98472, 98533);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_98581_98744(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 98581, 98744);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_98850_98860(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98850, 98860);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_98892_98903(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 98892, 98903);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_99112_99245(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 99112, 99245);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_100011_100144(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 100011, 100144);
                            return return_v;
                        }


                        string
                        f_10319_100358_100390(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 100358, 100390);
                            return return_v;
                        }


                        string
                        f_10319_100394_100432(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 100394, 100432);
                            return return_v;
                        }


                        bool
                        f_10319_100479_100592(Microsoft.CodeAnalysis.CSharp.Symbol
                        first, Microsoft.CodeAnalysis.CSharp.Symbol
                        second, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = Symbol.Equals(first, second, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 100479, 100592);
                            return return_v;
                        }


                        int
                        f_10319_100345_100716(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 100345, 100716);
                            return 0;
                        }


                        bool
                        f_10319_100939_100970(Microsoft.CodeAnalysis.CSharp.LookupOptions
                        options)
                        {
                            var return_v = options.IsAttributeTypeLookup();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 100939, 100970);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_101011_101021(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101011, 101021);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_101086_101097(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101086, 101097);
                            return return_v;
                        }


                        string
                        f_10319_101162_101194(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101162, 101194);
                            return return_v;
                        }


                        string
                        f_10319_101198_101236(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101198, 101236);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_101311_101322()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101311, 101322);
                            return return_v;
                        }


                        bool
                        f_10319_101311_101362(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        type)
                        {
                            var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 101311, 101362);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_101403_101414()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 101403, 101414);
                            return return_v;
                        }


                        bool
                        f_10319_101403_101455(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        type)
                        {
                            var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 101403, 101455);
                            return return_v;
                        }


                        string
                        f_10319_101970_102008(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                        this_param)
                        {
                            var return_v = this_param.ErrorDisplayName();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 101970, 102008);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_101766_102048(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 101766, 102048);
                            return return_v;
                        }


                        string
                        f_10319_102541_102579(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                        this_param)
                        {
                            var return_v = this_param.ErrorDisplayName();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 102541, 102579);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolDisplayFormat
                        f_10319_102671_102715()
                        {
                            var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 102671, 102715);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FormattedSymbol
                        f_10319_102644_102716(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                        symbolDisplayFormat)
                        {
                            var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 102644, 102716);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolDisplayFormat
                        f_10319_102787_102831()
                        {
                            var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 102787, 102831);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FormattedSymbol
                        f_10319_102759_102832(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                        symbolDisplayFormat)
                        {
                            var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 102759, 102832);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_102298_102835(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 102298, 102835);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_103086_103219(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        symbols, object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, symbols, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 103086, 103219);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_103445_103459(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 103445, 103459);
                            return return_v;
                        }


                        int
                        f_10319_103423_103460(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 103423, 103460);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        f_10319_103581_103629(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = this_param.GetContainingNamespaceOrType(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 103581, 103629);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_103523_103804(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        candidateSymbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        errorInfo, int
                        arity)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, candidateSymbols, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, arity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 103523, 103804);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_103972_103982(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 103972, 103982);
                            return return_v;
                        }


                        Microsoft.Cci.PrimitiveTypeCode
                        f_10319_104182_104210(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.PrimitiveTypeCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104182, 104210);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_104384_104430(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 104384, 104430);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_104488_104502(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104488, 104502);
                            return return_v;
                        }


                        int
                        f_10319_104461_104503(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 104461, 104503);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        f_10319_104577_104619(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = this_param.GetContainingNamespaceOrType(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 104577, 104619);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_104549_104679(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                        guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        errorInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 104549, 104679);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_104878_104895(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104878, 104895);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_104977_104993(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104977, 104993);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10319_104977_105006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.SourceModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104977, 105006);
                            return return_v;
                        }


                        bool
                        f_10319_104956_105040(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.AnyReferencedAssembliesAreLinked;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 104956, 105040);
                            return return_v;
                        }


                        bool
                        f_10319_105200_105304(Microsoft.CodeAnalysis.CSharp.Symbol
                        namedType, Microsoft.CodeAnalysis.SyntaxNode
                        syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = Emit.NoPia.EmbeddedTypesManager.IsValidEmbeddableType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)namedType, syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 105200, 105304);
                            return return_v;
                        }


                        bool
                        f_10319_105476_105534(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = ReportUseSiteDiagnostics(symbol, diagnostics, node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 105476, 105534);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_105605_105622(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 105605, 105622);
                            return return_v;
                        }


                        bool
                        f_10319_105976_105996(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Unreported;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 105976, 105996);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo?
                        f_10319_106097_106116(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ErrorInfo;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106097, 106116);
                            return return_v;
                        }


                        int
                        f_10319_106182_106196(Microsoft.CodeAnalysis.DiagnosticInfo
                        this_param)
                        {
                            var return_v = this_param.Code;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106182, 106196);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_106398_106412(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106398, 106412);
                            return return_v;
                        }


                        int
                        f_10319_106371_106413(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add(info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 106371, 106413);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        f_10319_106499_106538(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                        symbol)
                        {
                            var return_v = this_param.GetContainingNamespaceOrType((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 106499, 106538);
                            return return_v;
                        }


                        string
                        f_10319_106540_106554(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106540, 106554);
                            return return_v;
                        }


                        int
                        f_10319_106556_106571(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Arity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106556, 106571);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_106471_106602(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        containingSymbol, string
                        name, int
                        arity, Microsoft.CodeAnalysis.DiagnosticInfo
                        errorInfo, bool
                        unreported)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity, errorInfo, unreported: unreported);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 106471, 106602);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        f_10319_106995_107006(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 106995, 107006);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_10319_107250_107261(Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = node.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 107250, 107261);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        f_10319_107363_107401(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Alias;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 107363, 107401);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode?
                        f_10319_107519_107530(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 107519, 107530);
                            return return_v;
                        }


                        string
                        f_10319_107722_107760(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                        this_param)
                        {
                            var return_v = this_param.ErrorDisplayName();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 107722, 107760);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10319_107602_107829(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        where, string
                        simpleName, int
                        arity, string
                        whereText, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, string?
                        aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        qualifierOpt, Microsoft.CodeAnalysis.CSharp.LookupOptions
                        options)
                        {
                            var return_v = this_param.NotFound(where, simpleName, arity, whereText, diagnostics, aliasOpt, qualifierOpt, options);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 107602, 107829);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10319_107903_107914()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 107903, 107914);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10319_107903_107923(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 107903, 107923);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        f_10319_107903_107939(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.GlobalNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 107903, 107939);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_107859_107965(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        containingSymbol, string
                        name, int
                        arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        errorInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 107859, 107965);
                            return return_v;
                        }


                        int
                        f_10319_108018_108031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108018, 108031);
                            return return_v;
                        }


                        int
                        f_10319_108005_108036(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 108005, 108036);
                            return 0;
                        }


                        int
                        f_10319_108233_108246(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108233, 108246);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_108326_108336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108326, 108336);
                            return return_v;
                        }


                        bool
                        f_10319_108301_108357(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = ReportUseSiteDiagnostics(symbol, diagnostics, node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 108301, 108357);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo
                        f_10319_108586_108598(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Error;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108586, 108598);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10319_108664_108681(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108664, 108681);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo
                        f_10319_108804_108816(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Error;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108804, 108816);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10319_108818_108832(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108818, 108832);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                        f_10319_108787_108833(Microsoft.CodeAnalysis.DiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 108787, 108833);
                            return return_v;
                        }


                        int
                        f_10319_108771_108834(Microsoft.CodeAnalysis.DiagnosticBag
                        this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                        diag)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 108771, 108834);
                            return 0;
                        }


                        int
                        f_10319_108879_108892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108879, 108892);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_108902_108912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108902, 108912);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_108941_108951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108941, 108951);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        f_10319_108992_109003(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 108992, 109003);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        f_10319_109047_109058(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 109047, 109058);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_109564_109574(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 109564, 109574);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        f_10319_109535_109575(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = this_param.GetContainingNamespaceOrType(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 109535, 109575);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10319_109577_109598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 109577, 109598);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        f_10319_109600_109611(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 109600, 109611);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo?
                        f_10319_109613_109625(Microsoft.CodeAnalysis.CSharp.LookupResult
                        this_param)
                        {
                            var return_v = this_param.Error;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 109613, 109625);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                        f_10319_109507_109633(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        candidateSymbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        resultKind, Microsoft.CodeAnalysis.DiagnosticInfo?
                        errorInfo, int
                        arity)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, candidateSymbols, resultKind, errorInfo, arity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 109507, 109633);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10319_109831_109841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 109831, 109841);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 84907, 109876);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 84907, 109876);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 84124, 109887);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_84550_84674(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                simpleName, int
                arity, Microsoft.CodeAnalysis.SyntaxNode
                where, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics, out bool
                wasError, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = resultSymbol(result, simpleName, arity, where, diagnostics, suppressUseSiteDiagnostics, out wasError, qualifierOpt, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 84550, 84674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_84695_84706(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 84695, 84706);
                    return return_v;
                }


                int
                f_10319_84764_84845(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckRuntimeSupportForSymbolAccess(node, receiverOpt: receiverOpt, symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 84764, 84845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 84124, 109887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 84124, 109887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AssemblySymbol GetContainingAssembly(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 109899, 110288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 110166, 110277);

                return f_10319_110173_110198(symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(10319, 110173, 110276) ?? f_10319_110202_110276(((NamespaceSymbol)symbol).ConstituentNamespaces.First()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 109899, 110288);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_110173_110198(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 110173, 110198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_110202_110276(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 110202, 110276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 109899, 110288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 109899, 110288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Flags]
        private enum BestSymbolLocation
        {
            None,
            FromSourceModule,
            FromAddedModule,
            FromReferencedAssembly,
            FromCorLibrary,
        }

        [DebuggerDisplay("Location = {_location}, Index = {_index}")]
        private struct BestSymbolInfo
        {

            private readonly BestSymbolLocation _location;

            private readonly int _index;

            public int Index
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 110898, 110989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 110942, 110970);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 110949, 110955) || ((IsNone && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 110958, 110960)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 110963, 110969))) ? -1 : _index;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 110898, 110989);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 110849, 111004);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 110849, 111004);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsFromSourceModule
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 111083, 111202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 111127, 111183);

                        return _location == BestSymbolLocation.FromSourceModule;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 111083, 111202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 111020, 111217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 111020, 111217);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsFromAddedModule
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 111295, 111413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 111339, 111394);

                        return _location == BestSymbolLocation.FromAddedModule;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 111295, 111413);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 111233, 111428);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 111233, 111428);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsFromCompilation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 111506, 111680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 111550, 111661);

                        return (_location == BestSymbolLocation.FromSourceModule) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 111557, 111660) || (_location == BestSymbolLocation.FromAddedModule));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 111506, 111680);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 111444, 111695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 111444, 111695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsNone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 111762, 111869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 111806, 111850);

                        return _location == BestSymbolLocation.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 111762, 111869);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 111711, 111884);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 111711, 111884);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsFromCorLibrary
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 111961, 112078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112005, 112059);

                        return _location == BestSymbolLocation.FromCorLibrary;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 111961, 112078);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 111900, 112093);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 111900, 112093);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public BestSymbolInfo(BestSymbolLocation location, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10319, 112109, 112340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112203, 112253);

                    f_10319_112203_112252(location != BestSymbolLocation.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112271, 112292);

                    _location = location;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112310, 112325);

                    _index = index;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10319, 112109, 112340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 112109, 112340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 112109, 112340);
                }
            }

            public static bool Sort(ref BestSymbolInfo first, ref BestSymbolInfo second)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 112576, 112990);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112685, 112942) || true) && (IsSecondLocationBetter(first._location, second._location))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 112685, 112942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112788, 112816);

                        BestSymbolInfo
                        temp = first
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112838, 112853);

                        first = second;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112875, 112889);

                        second = temp;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112911, 112923);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 112685, 112942);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 112962, 112975);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 112576, 112990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 112576, 112990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 112576, 112990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool IsSecondLocationBetter(BestSymbolLocation firstLocation, BestSymbolLocation secondLocation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 113142, 113438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113285, 113319);

                    f_10319_113285_113318(secondLocation != 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113337, 113423);

                    return (firstLocation == BestSymbolLocation.None) || (DynAbs.Tracing.TraceSender.Expression_False(10319, 113344, 113422) || (firstLocation > secondLocation));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 113142, 113438);

                    int
                    f_10319_113285_113318(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 113285, 113318);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 113142, 113438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 113142, 113438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static BestSymbolInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10319, 110528, 113449);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10319, 110528, 113449);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 110528, 113449);
            }

            static int
            f_10319_112203_112252(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 112203, 112252);
                return 0;
            }

        }

        private BestSymbolInfo GetBestSymbolInfo(ArrayBuilder<Symbol> symbols, out BestSymbolInfo secondBest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 113614, 115323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113740, 113787);

                BestSymbolInfo
                first = default(BestSymbolInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113801, 113849);

                BestSymbolInfo
                second = default(BestSymbolInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113863, 113898);

                var
                compilation = f_10319_113881_113897(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113923, 113928);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113914, 115162) || true) && (i < f_10319_113934_113947(symbols))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113949, 113952)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 113914, 115162))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 113914, 115162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 113986, 114010);

                        var
                        symbol = f_10319_113999_114009(symbols, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114028, 114056);

                        BestSymbolLocation
                        location
                        = default(BestSymbolLocation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114076, 114915) || true) && (f_10319_114080_114091(symbol) == SymbolKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114076, 114915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114157, 114192);

                            location = BestSymbolLocation.None;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114214, 114770);
                                foreach (var ns in f_10319_114233_114280_I(f_10319_114233_114280(((NamespaceSymbol)symbol))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114214, 114770);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114330, 114373);

                                    var
                                    current = f_10319_114344_114372(compilation, ns)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114399, 114747) || true) && (BestSymbolInfo.IsSecondLocationBetter(location, current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114399, 114747);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114517, 114536);

                                        location = current;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114566, 114720) || true) && (location == BestSymbolLocation.FromSourceModule)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114566, 114720);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10319, 114683, 114689);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114566, 114720);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114399, 114747);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114214, 114770);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 557);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 557);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114076, 114915);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114076, 114915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114852, 114896);

                            location = f_10319_114863_114895(compilation, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114076, 114915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114935, 114979);

                        var
                        third = f_10319_114947_114978(location, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 114997, 115147) || true) && (BestSymbolInfo.Sort(ref second, ref third))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 114997, 115147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115085, 115128);

                            BestSymbolInfo.Sort(ref first, ref second);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 114997, 115147);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 1249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 1249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115178, 115206);

                f_10319_115178_115205(f_10319_115191_115204_M(!first.IsNone));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115220, 115249);

                f_10319_115220_115248(f_10319_115233_115247_M(!second.IsNone));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115265, 115285);

                secondBest = second;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115299, 115312);

                return first;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 113614, 115323);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_113881_113897(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 113881, 113897);
                    return return_v;
                }


                int
                f_10319_113934_113947(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 113934, 113947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_113999_114009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 113999, 114009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_114080_114091(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 114080, 114091);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10319_114233_114280(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ConstituentNamespaces;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 114233, 114280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolLocation
                f_10319_114344_114372(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = GetLocation(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 114344, 114372);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10319_114233_114280_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 114233, 114280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolLocation
                f_10319_114863_114895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetLocation(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 114863, 114895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                f_10319_114947_114978(Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolLocation
                location, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo(location, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 114947, 114978);
                    return return_v;
                }


                bool
                f_10319_115191_115204_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115191, 115204);
                    return return_v;
                }


                int
                f_10319_115178_115205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 115178, 115205);
                    return 0;
                }


                bool
                f_10319_115233_115247_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115233, 115247);
                    return return_v;
                }


                int
                f_10319_115220_115248(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 115220, 115248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 113614, 115323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 113614, 115323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BestSymbolLocation GetLocation(CSharpCompilation compilation, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 115335, 116055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115451, 115502);

                var
                containingAssembly = f_10319_115476_115501(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115516, 116044) || true) && (containingAssembly == f_10319_115542_115568(compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 115516, 116044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115602, 115780);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 115609, 115662) || (((f_10319_115610_115633(symbol) == f_10319_115637_115661(compilation)) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 115686, 115721)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 115745, 115779))) ? BestSymbolLocation.FromSourceModule : BestSymbolLocation.FromAddedModule;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 115516, 116044);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 115516, 116044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 115846, 116029);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 115853, 115906) || (((containingAssembly == f_10319_115876_115905(containingAssembly)) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 115930, 115963)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 115987, 116028))) ? BestSymbolLocation.FromCorLibrary : BestSymbolLocation.FromReferencedAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 115516, 116044);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 115335, 116055);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_115476_115501(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115476, 115501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10319_115542_115568(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115542, 115568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10319_115610_115633(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115610, 115633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10319_115637_115661(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115637, 115661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_115876_115905(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 115876, 115905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 115335, 116055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 115335, 116055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSDiagnosticInfo NotFound(SyntaxNode where, string simpleName, int arity, string whereText, DiagnosticBag diagnostics, string aliasOpt, NamespaceOrTypeSymbol qualifierOpt, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 116263, 121036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 116490, 116520);

                var
                location = f_10319_116505_116519(where)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 116913, 116948);

                AssemblySymbol
                forwardedToAssembly
                = default(AssemblySymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117036, 117404) || true) && (f_10319_117040_117071(options) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 117040, 117119) && !f_10319_117076_117119(options)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 117036, 117404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117237, 117389);

                    f_10319_117237_117388(this, where, simpleName, arity, whereText + "Attribute", diagnostics, aliasOpt, qualifierOpt, options | LookupOptions.VerbatimNameAttributeTypeOnly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 117036, 117404);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117420, 119761) || true) && ((object)qualifierOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 117420, 119761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117486, 119746) || true) && (f_10319_117490_117509(qualifierOpt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 117486, 119746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117551, 117604);

                        var
                        errorQualifier = qualifierOpt as ErrorTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117626, 117819) || true) && ((object)errorQualifier != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 117630, 117696) && f_10319_117664_117688(errorQualifier) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 117626, 117819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117746, 117796);

                            return (CSDiagnosticInfo)f_10319_117771_117795(errorQualifier);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 117626, 117819);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 117843, 117944);

                        return f_10319_117850_117943(diagnostics, ErrorCode.ERR_DottedTypeNameNotFoundInAgg, location, whereText, qualifierOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 117486, 119746);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 117486, 119746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118026, 118065);

                        f_10319_118026_118064(f_10319_118039_118063(qualifierOpt));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118089, 118194);

                        forwardedToAssembly = f_10319_118111_118193(this, simpleName, arity, ref qualifierOpt, diagnostics, location);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118218, 119727) || true) && (f_10319_118222_118280(qualifierOpt, f_10319_118252_118279(f_10319_118252_118263())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 118218, 119727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118330, 118422);

                            f_10319_118330_118421(aliasOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10319, 118343, 118420) || aliasOpt == f_10319_118375_118420(SyntaxKind.GlobalKeyword)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118448, 118753);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 118455, 118490) || (((object)forwardedToAssembly == null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 118522, 118616)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 118648, 118752))) ? f_10319_118522_118616(diagnostics, ErrorCode.ERR_GlobalSingleTypeNameNotFound, location, whereText, qualifierOpt) : f_10319_118648_118752(diagnostics, ErrorCode.ERR_GlobalSingleTypeNameNotFoundFwd, location, whereText, forwardedToAssembly);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 118218, 119727);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 118218, 119727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 118851, 118883);

                            object
                            container = qualifierOpt
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119160, 119367) || true) && (aliasOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 119164, 119208) && f_10319_119184_119208(qualifierOpt)) && (DynAbs.Tracing.TraceSender.Expression_True(10319, 119164, 119261) && f_10319_119212_119261(((NamespaceSymbol)qualifierOpt))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 119160, 119367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119319, 119340);

                                container = aliasOpt;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 119160, 119367);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119395, 119704);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 119402, 119437) || (((object)forwardedToAssembly == null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 119469, 119558)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 119590, 119703))) ? f_10319_119469_119558(diagnostics, ErrorCode.ERR_DottedTypeNameNotFoundInNS, location, whereText, container) : f_10319_119590_119703(diagnostics, ErrorCode.ERR_DottedTypeNameNotFoundInNSFwd, location, whereText, container, forwardedToAssembly);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 118218, 119727);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 117486, 119746);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 117420, 119761);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119777, 119948) || true) && (options == LookupOptions.NamespaceAliasesOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 119777, 119948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119860, 119933);

                    return f_10319_119867_119932(diagnostics, ErrorCode.ERR_AliasNotFound, location, whereText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 119777, 119948);
                }

                if (
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 119964, 120412) || true) && (((DynAbs.Tracing.TraceSender.Conditional_F1(10319, 120014, 120045) || (((where is IdentifierNameSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 120066, 120120)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 120123, 120128))) ? ((IdentifierNameSyntax)where).Identifier.Text == "var" : false)
                && (DynAbs.Tracing.TraceSender.Expression_True(10319, 120013, 120182) && !f_10319_120151_120182(options)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 119964, 120412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120216, 120340);

                    var
                    code = (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 120227, 120262) || (((f_10319_120228_120240(where) is QueryClauseSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 120265, 120307)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 120310, 120339))) ? ErrorCode.ERR_TypeVarNotFoundRangeVariable : ErrorCode.ERR_TypeVarNotFound
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120358, 120397);

                    return f_10319_120365_120396(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 119964, 120412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120428, 120533);

                forwardedToAssembly = f_10319_120450_120532(this, simpleName, arity, ref qualifierOpt, diagnostics, location);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120549, 120927) || true) && ((object)forwardedToAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 120549, 120927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120622, 120912);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10319, 120629, 120649) || ((qualifierOpt == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10319, 120673, 120771)) || DynAbs.Tracing.TraceSender.Conditional_F3(10319, 120795, 120911))) ? f_10319_120673_120771(diagnostics, ErrorCode.ERR_SingleTypeNameNotFoundFwd, location, whereText, forwardedToAssembly) : f_10319_120795_120911(diagnostics, ErrorCode.ERR_DottedTypeNameNotFoundInNSFwd, location, whereText, qualifierOpt, forwardedToAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 120549, 120927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 120943, 121025);

                return f_10319_120950_121024(diagnostics, ErrorCode.ERR_SingleTypeNameNotFound, location, whereText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 116263, 121036);

                Microsoft.CodeAnalysis.Location
                f_10319_116505_116519(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 116505, 116519);
                    return return_v;
                }


                bool
                f_10319_117040_117071(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 117040, 117071);
                    return return_v;
                }


                bool
                f_10319_117076_117119(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsVerbatimNameAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 117076, 117119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_117237_117388(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                where, string
                simpleName, int
                arity, string
                whereText, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.NotFound(where, simpleName, arity, whereText, diagnostics, aliasOpt, qualifierOpt, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 117237, 117388);
                    return return_v;
                }


                bool
                f_10319_117490_117509(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 117490, 117509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10319_117664_117688(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 117664, 117688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10319_117771_117795(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 117771, 117795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_117850_117943(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 117850, 117943);
                    return return_v;
                }


                bool
                f_10319_118039_118063(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 118039, 118063);
                    return return_v;
                }


                int
                f_10319_118026_118064(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118026, 118064);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_118111_118193(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name, int
                arity, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetForwardedToAssembly(name, arity, ref qualifierOpt, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118111, 118193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_118252_118263()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 118252, 118263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10319_118252_118279(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 118252, 118279);
                    return return_v;
                }


                bool
                f_10319_118222_118280(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118222, 118280);
                    return return_v;
                }


                string
                f_10319_118375_118420(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118375, 118420);
                    return return_v;
                }


                int
                f_10319_118330_118421(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118330, 118421);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_118522_118616(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118522, 118616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_118648_118752(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 118648, 118752);
                    return return_v;
                }


                bool
                f_10319_119184_119208(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 119184, 119208);
                    return return_v;
                }


                bool
                f_10319_119212_119261(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 119212, 119261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_119469_119558(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 119469, 119558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_119590_119703(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 119590, 119703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_119867_119932(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 119867, 119932);
                    return return_v;
                }


                bool
                f_10319_120151_120182(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120151, 120182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10319_120228_120240(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 120228, 120240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_120365_120396(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120365, 120396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_120450_120532(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name, int
                arity, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetForwardedToAssembly(name, arity, ref qualifierOpt, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120450, 120532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_120673_120771(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120673, 120771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_120795_120911(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120795, 120911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_120950_121024(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 120950, 121024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 116263, 121036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 116263, 121036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual AssemblySymbol GetForwardedToAssemblyInUsingNamespaces(string metadataName, ref NamespaceOrTypeSymbol qualifierOpt, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 121048, 121371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121252, 121360);

                return f_10319_121259_121359_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10319_121259_121263(), 10319, 121259, 121359)?.GetForwardedToAssemblyInUsingNamespaces(metadataName, ref qualifierOpt, diagnostics, location));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 121048, 121371);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10319_121259_121263()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 121259, 121263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10319_121259_121359_I(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 121259, 121359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 121048, 121371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 121048, 121371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected AssemblySymbol GetForwardedToAssembly(string fullName, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 121383, 123016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121518, 121577);

                var
                metadataName = MetadataTypeName.FromFullName(fullName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121591, 122977);
                    foreach (var referencedAssembly in f_10319_121643_121705_I(f_10319_121643_121705(f_10319_121643_121671(f_10319_121643_121663(f_10319_121643_121654()))[0])))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 121591, 122977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121739, 121848);

                        var
                        forwardedType =
                        f_10319_121780_121847(referencedAssembly, ref metadataName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121866, 122962) || true) && ((object)forwardedType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 121866, 122962);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 121941, 122879) || true) && (f_10319_121945_121963(forwardedType) == SymbolKind.ErrorType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 121941, 122879);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122037, 122106);

                                DiagnosticInfo
                                diagInfo = f_10319_122063_122105(((ErrorTypeSymbol)forwardedType))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122134, 122856) || true) && (f_10319_122138_122151(diagInfo) == (int)ErrorCode.ERR_CycleInTypeForwarder)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 122134, 122856);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122252, 122370);

                                    f_10319_122252_122369((object)f_10319_122273_122305(forwardedType) != null, "How did we find a cycle if there was no forwarding?");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122400, 122511);

                                    f_10319_122400_122510(diagnostics, ErrorCode.ERR_CycleInTypeForwarder, location, fullName, f_10319_122472_122509(f_10319_122472_122504(forwardedType)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 122134, 122856);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 122134, 122856);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122569, 122856) || true) && (f_10319_122573_122586(diagInfo) == (int)ErrorCode.ERR_TypeForwardedToMultipleAssemblies)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 122569, 122856);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122700, 122736);

                                        f_10319_122700_122735(diagnostics, diagInfo, location);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122766, 122778);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 122569, 122856);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 122134, 122856);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 121941, 122879);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122903, 122943);

                            return f_10319_122910_122942(forwardedType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 121866, 122962);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 121591, 122977);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 1, 1387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 1, 1387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 122993, 123005);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 121383, 123016);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10319_121643_121654()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 121643, 121654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_121643_121663(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 121643, 121663);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10319_121643_121671(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 121643, 121671);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10319_121643_121705(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 121643, 121705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10319_121780_121847(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.TryLookupForwardedMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 121780, 121847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_121945_121963(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 121945, 121963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10319_122063_122105(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122063, 122105);
                    return return_v;
                }


                int
                f_10319_122138_122151(Microsoft.CodeAnalysis.DiagnosticInfo?
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122138, 122151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_122273_122305(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122273, 122305);
                    return return_v;
                }


                int
                f_10319_122252_122369(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 122252, 122369);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_122472_122504(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122472, 122504);
                    return return_v;
                }


                string
                f_10319_122472_122509(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122472, 122509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10319_122400_122510(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 122400, 122510);
                    return return_v;
                }


                int
                f_10319_122573_122586(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122573, 122586);
                    return return_v;
                }


                int
                f_10319_122700_122735(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 122700, 122735);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_122910_122942(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 122910, 122942);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10319_121643_121705_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 121643, 121705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 121383, 123016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 121383, 123016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected AssemblySymbol GetForwardedToAssembly(string name, int arity, ref NamespaceOrTypeSymbol qualifierOpt, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10319, 124180, 126676);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 124951, 125750) || true) && ((this.Flags & BinderFlags.InContextualAttributeBinder) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 124951, 125750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125048, 125067);

                    var
                    current = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 125087, 125735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125130, 125199);

                                var
                                contextualAttributeBinder = current as ContextualAttributeBinder
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125223, 125627) || true) && (contextualAttributeBinder != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 125223, 125627);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125310, 125570) || true) && ((object)f_10319_125322_125363(contextualAttributeBinder) != null && (DynAbs.Tracing.TraceSender.Expression_True(10319, 125314, 125473) && f_10319_125404_125450(f_10319_125404_125445(contextualAttributeBinder)) == SymbolKind.Assembly))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 125310, 125570);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125531, 125543);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 125310, 125570);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10319, 125598, 125604);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 125223, 125627);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125651, 125674);

                                current = f_10319_125661_125673(current);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 125087, 125735);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 125087, 125735) || true) && (current != null)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10319, 125087, 125735);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10319, 125087, 125735);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 124951, 125750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126001, 126082);

                var
                metadataName = f_10319_126020_126081(name, arity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126096, 126244);

                var
                fullMetadataName = f_10319_126119_126243(f_10319_126154_126228_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(qualifierOpt, 10319, 126154, 126228)?.ToDisplayString(SymbolDisplayFormat.QualifiedNameOnlyFormat)), metadataName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126258, 126335);

                var
                result = f_10319_126271_126334(this, fullMetadataName, diagnostics, location)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126349, 126438) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 126349, 126438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126409, 126423);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 126349, 126438);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126454, 126637) || true) && ((object)qualifierOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 126454, 126637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126520, 126622);

                    return f_10319_126527_126621(this, metadataName, ref qualifierOpt, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 126454, 126637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126653, 126665);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10319, 124180, 126676);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_125322_125363(Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder
                this_param)
                {
                    var return_v = this_param.AttributeTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 125322, 125363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10319_125404_125445(Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder
                this_param)
                {
                    var return_v = this_param.AttributeTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 125404, 125445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10319_125404_125450(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 125404, 125450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10319_125661_125673(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 125661, 125673);
                    return return_v;
                }


                string
                f_10319_126020_126081(string
                name, int
                arity)
                {
                    var return_v = MetadataHelpers.ComposeAritySuffixedMetadataName(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126020, 126081);
                    return return_v;
                }


                string?
                f_10319_126154_126228_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126154, 126228);
                    return return_v;
                }


                string
                f_10319_126119_126243(string?
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126119, 126243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_126271_126334(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                fullName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetForwardedToAssembly(fullName, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126271, 126334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10319_126527_126621(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                metadataName, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetForwardedToAssemblyInUsingNamespaces(metadataName, ref qualifierOpt, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126527, 126621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 124180, 126676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 124180, 126676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckFeatureAvailability(SyntaxNode syntax, MessageID feature, DiagnosticBag diagnostics, Location? location = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 126706, 126986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 126868, 126975);

                return f_10319_126875_126974(f_10319_126900_126917(syntax), feature, diagnostics, location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10319, 126941, 126973) ?? f_10319_126953_126973(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 126706, 126986);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10319_126900_126917(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 126900, 126917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10319_126953_126973(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126953, 126973);
                    return return_v;
                }


                bool
                f_10319_126875_126974(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = CheckFeatureAvailability(tree, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 126875, 126974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 126706, 126986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 126706, 126986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckFeatureAvailability(SyntaxTree tree, MessageID feature, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10319, 126998, 127401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 127150, 127364) || true) && (f_10319_127154_127232(feature, f_10319_127219_127231(tree)) is { } diagInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10319, 127150, 127364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 127282, 127318);

                    f_10319_127282_127317(diagnostics, diagInfo, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 127336, 127349);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10319, 127150, 127364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 127378, 127390);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10319, 126998, 127401);

                Microsoft.CodeAnalysis.ParseOptions
                f_10319_127219_127231(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10319, 127219, 127231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10319_127154_127232(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.ParseOptions
                options)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.CSharpParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 127154, 127232);
                    return return_v;
                }


                int
                f_10319_127282_127317(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10319, 127282, 127317);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10319, 126998, 127401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10319, 126998, 127401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
