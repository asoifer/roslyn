// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ExpressionListVariableBinder : LocalScopeBinder
    {
        private readonly SeparatedSyntaxList<ExpressionSyntax> _expressions;

        internal ExpressionListVariableBinder(SeparatedSyntaxList<ExpressionSyntax> expressions, Binder next) : base(f_10334_779_783_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10334, 670, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 809, 845);

                f_10334_809_844(expressions.Count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 859, 886);

                _expressions = expressions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10334, 670, 897);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10334, 670, 897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 670, 897);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10334, 909, 1201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 994, 1048);

                var
                builder = f_10334_1008_1047()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1062, 1140);

                f_10334_1062_1139(this, builder, _expressions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1154, 1190);

                return f_10334_1161_1189(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10334, 909, 1201);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10334_1008_1047()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10334, 1008, 1047);
                    return return_v;
                }


                int
                f_10334_1062_1139(Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder
                binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                nodes)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)binder, builder, nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10334, 1062, 1139);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10334_1161_1189(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10334, 1161, 1189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10334, 909, 1201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 909, 1201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10334, 1282, 1356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1318, 1341);

                    return _expressions[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10334, 1282, 1356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10334, 1213, 1367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 1213, 1367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10334, 1379, 1673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1503, 1609) || true) && (f_10334_1507_1522() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10334, 1503, 1609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1575, 1594);

                    return f_10334_1582_1593(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10334, 1503, 1609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1625, 1662);

                throw f_10334_1631_1661();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10334, 1379, 1673);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10334_1507_1522()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10334, 1507, 1522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10334_1582_1593(Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10334, 1582, 1593);
                    return return_v;
                }


                System.Exception
                f_10334_1631_1661()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10334, 1631, 1661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10334, 1379, 1673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 1379, 1673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10334, 1685, 1879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10334, 1831, 1868);

                throw f_10334_1837_1867();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10334, 1685, 1879);

                System.Exception
                f_10334_1837_1867()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10334, 1837, 1867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10334, 1685, 1879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 1685, 1879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExpressionListVariableBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10334, 504, 1886);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10334, 504, 1886);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10334, 504, 1886);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10334, 504, 1886);

        int
        f_10334_809_844(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10334, 809, 844);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10334_779_783_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10334, 670, 897);
            return return_v;
        }

    }
}
