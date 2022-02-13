// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal class SyntaxLastTokenReplacer : CSharpSyntaxRewriter
    {
        private readonly SyntaxToken _oldToken;

        private readonly SyntaxToken _newToken;

        private int _count;

        private bool _found;

        private SyntaxLastTokenReplacer(SyntaxToken oldToken, SyntaxToken newToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10031, 696, 863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 562, 571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 611, 620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 643, 653);
                this._count = 1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 677, 683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 796, 817);

                _oldToken = oldToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 831, 852);

                _newToken = newToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10031, 696, 863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10031, 696, 863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10031, 696, 863);
            }
        }

        internal static TRoot Replace<TRoot>(TRoot root, SyntaxToken newToken)
                    where TRoot : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10031, 875, 1266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1014, 1049);

                var
                oldToken = f_10031_1029_1048<TRoot>(root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1063, 1126);

                var
                replacer = f_10031_1078_1125<TRoot>(oldToken, newToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1140, 1182);

                var
                newRoot = (TRoot)f_10031_1161_1181<TRoot>(replacer, root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1196, 1226);

                f_10031_1196_1225<TRoot>(replacer._found);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1240, 1255);

                return newRoot;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10031, 875, 1266);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10031_1029_1048<TRoot>(TRoot
                this_param) where TRoot : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1029, 1048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxLastTokenReplacer
                f_10031_1078_1125<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                oldToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                newToken) where TRoot : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxLastTokenReplacer(oldToken, newToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1078, 1125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10031_1161_1181<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxLastTokenReplacer
                this_param, TRoot
                node) where TRoot : CSharpSyntaxNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1161, 1181);
                    return return_v;
                }


                int
                f_10031_1196_1225<TRoot>(bool
                condition) where TRoot : CSharpSyntaxNode

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1196, 1225);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10031, 875, 1266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10031, 875, 1266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int CountNonNullSlots(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10031, 1278, 1413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1362, 1402);

                return f_10031_1369_1395(node).Count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10031, 1278, 1413);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_10031_1369_1395(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1369, 1395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10031, 1278, 1413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10031, 1278, 1413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override CSharpSyntaxNode Visit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10031, 1425, 2093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1511, 2054) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10031, 1515, 1538) && !_found))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10031, 1511, 2054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1572, 1581);

                    _count--;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1599, 2039) || true) && (_count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10031, 1599, 2039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1656, 1688);

                        var
                        token = node as SyntaxToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1710, 1916) || true) && (token != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10031, 1710, 1916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1777, 1810);

                            f_10031_1777_1809(token == _oldToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1836, 1850);

                            _found = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1876, 1893);

                            return _newToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10031, 1710, 1916);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1940, 1974);

                        _count += f_10031_1950_1973(node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 1996, 2020);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10031, 2003, 2019);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10031, 1599, 2039);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10031, 1511, 2054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10031, 2070, 2082);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10031, 1425, 2093);

                int
                f_10031_1777_1809(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1777, 1809);
                    return 0;
                }


                int
                f_10031_1950_1973(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node)
                {
                    var return_v = CountNonNullSlots(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10031, 1950, 1973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10031, 1425, 2093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10031, 1425, 2093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxLastTokenReplacer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10031, 455, 2100);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10031, 455, 2100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10031, 455, 2100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10031, 455, 2100);
    }
}
