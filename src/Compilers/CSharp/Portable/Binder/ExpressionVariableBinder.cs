// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ExpressionVariableBinder : LocalScopeBinder
    {
        internal override SyntaxNode ScopeDesignator { get; }

        internal ExpressionVariableBinder(SyntaxNode scopeDesignator, Binder next) : base(f_10335_756_760_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10335, 674, 836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 609, 662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 786, 825);

                this.ScopeDesignator = scopeDesignator;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10335, 674, 836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10335, 674, 836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10335, 674, 836);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10335, 848, 1269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 933, 987);

                var
                builder = f_10335_947_986()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1001, 1208);

                f_10335_1001_1207(this, builder, f_10335_1083_1098(), f_10335_1162_1206(this, (CSharpSyntaxNode)f_10335_1190_1205()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1222, 1258);

                return f_10335_1229_1257(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10335, 848, 1269);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10335_947_986()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10335, 947, 986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10335_1083_1098()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1083, 1098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10335_1190_1205()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1190, 1205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10335_1162_1206(Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10335, 1162, 1206);
                    return return_v;
                }


                int
                f_10335_1001_1207(Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder?
                enclosingBinderOpt)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10335, 1001, 1207);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10335_1229_1257(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10335, 1229, 1257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10335, 848, 1269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10335, 848, 1269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10335, 1281, 1575);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1405, 1511) || true) && (f_10335_1409_1424() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10335, 1405, 1511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1477, 1496);

                    return f_10335_1484_1495(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10335, 1405, 1511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1527, 1564);

                throw f_10335_1533_1563();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10335, 1281, 1575);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10335_1409_1424()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1409, 1424);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10335_1484_1495(Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1484, 1495);
                    return return_v;
                }


                System.Exception
                f_10335_1533_1563()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1533, 1563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10335, 1281, 1575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10335, 1281, 1575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10335, 1587, 1781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10335, 1733, 1770);

                throw f_10335_1739_1769();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10335, 1587, 1781);

                System.Exception
                f_10335_1739_1769()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10335, 1739, 1769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10335, 1587, 1781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10335, 1587, 1781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExpressionVariableBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10335, 527, 1788);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10335, 527, 1788);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10335, 527, 1788);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10335, 527, 1788);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10335_756_760_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10335, 674, 836);
            return return_v;
        }

    }
}
