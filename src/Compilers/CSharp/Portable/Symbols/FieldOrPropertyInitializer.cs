// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal struct FieldOrPropertyInitializer
    {

        internal readonly FieldSymbol FieldOpt;

        internal readonly SyntaxReference Syntax;

        public FieldOrPropertyInitializer(FieldSymbol fieldOpt, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10109, 1156, 1626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1278, 1331);

                // LAFHIS
                //var a1 = f_10109_1287_1330(syntax, SyntaxKind.EqualsValueClause);

                var a1 = syntax.IsKind(SyntaxKind.EqualsValueClause);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1287, 1330);

                // LAFHIS
                //var a2 = f_10109_1354_1389(syntax, SyntaxKind.Parameter);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1345, 1390);
                var a2 = syntax.IsKind(SyntaxKind.Parameter);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1354, 1389);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1404, 1430);

                var
                a3 = fieldOpt != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1444, 1479);

                var
                a4 = syntax is StatementSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1495, 1534);

                f_10109_1495_1533(((a1 || (DynAbs.Tracing.TraceSender.Expression_False(10109, 1510, 1518) || a2)) && (DynAbs.Tracing.TraceSender.Expression_True(10109, 1509, 1525) && a3)) || (DynAbs.Tracing.TraceSender.Expression_False(10109, 1508, 1532) || a4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1550, 1570);

                FieldOpt = fieldOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10109, 1584, 1615);

                Syntax = f_10109_1593_1614(syntax);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10109, 1156, 1626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10109, 1156, 1626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10109, 1156, 1626);
            }
        }
        static FieldOrPropertyInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10109, 501, 1633);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10109, 501, 1633);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10109, 501, 1633);
        }

        bool
        f_10109_1287_1330(Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1287, 1330);
            return return_v;
        }


        bool
        f_10109_1354_1389(Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1354, 1389);
            return return_v;
        }


        static int
        f_10109_1495_1533(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1495, 1533);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10109_1593_1614(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10109, 1593, 1614);
            return return_v;
        }

    }
}
