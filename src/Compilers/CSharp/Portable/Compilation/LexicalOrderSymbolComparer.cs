// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class LexicalOrderSymbolComparer : IComparer<Symbol>
    {
        public static readonly LexicalOrderSymbolComparer Instance;

        private LexicalOrderSymbolComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10220, 937, 995);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10220, 937, 995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10220, 937, 995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10220, 937, 995);
            }
        }

        public int Compare(Symbol x, Symbol y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10220, 1007, 1855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1070, 1085);

                int
                comparison
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1099, 1167) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10220, 1099, 1167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1143, 1152);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10220, 1099, 1167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1183, 1220);

                var
                xSortKey = f_10220_1198_1219(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1234, 1271);

                var
                ySortKey = f_10220_1249_1270(y)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1285, 1356);

                f_10220_1285_1355((object)f_10220_1306_1328(x) == f_10220_1332_1354(y));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1372, 1428);

                comparison = LexicalSortKey.Compare(xSortKey, ySortKey);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1442, 1528) || true) && (comparison != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10220, 1442, 1528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1495, 1513);

                    return comparison;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10220, 1442, 1528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1544, 1601);

                comparison = f_10220_1557_1577(f_10220_1557_1563(x)) - f_10220_1580_1600(f_10220_1580_1586(y));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1615, 1701) || true) && (comparison != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10220, 1615, 1701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1668, 1686);

                    return comparison;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10220, 1615, 1701);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1717, 1768);

                comparison = f_10220_1730_1767(f_10220_1752_1758(x), f_10220_1760_1766(y));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1782, 1812);

                f_10220_1782_1811(comparison != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 1826, 1844);

                return comparison;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10220, 1007, 1855);

                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10220_1198_1219(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLexicalSortKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1198, 1219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10220_1249_1270(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLexicalSortKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1249, 1270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10220_1306_1328(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1306, 1328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10220_1332_1354(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1332, 1354);
                    return return_v;
                }


                int
                f_10220_1285_1355(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1285, 1355);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10220_1557_1563(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1557, 1563);
                    return return_v;
                }


                int
                f_10220_1557_1577(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1557, 1577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10220_1580_1586(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1580, 1586);
                    return return_v;
                }


                int
                f_10220_1580_1600(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.ToSortOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1580, 1600);
                    return return_v;
                }


                string
                f_10220_1752_1758(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1752, 1758);
                    return return_v;
                }


                string
                f_10220_1760_1766(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10220, 1760, 1766);
                    return return_v;
                }


                int
                f_10220_1730_1767(string
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1730, 1767);
                    return return_v;
                }


                int
                f_10220_1782_1811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 1782, 1811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10220, 1007, 1855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10220, 1007, 1855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LexicalOrderSymbolComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10220, 753, 1862);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10220, 881, 924);
            Instance = f_10220_892_924(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10220, 753, 1862);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10220, 753, 1862);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10220, 753, 1862);

        static Microsoft.CodeAnalysis.CSharp.LexicalOrderSymbolComparer
        f_10220_892_924()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.LexicalOrderSymbolComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10220, 892, 924);
            return return_v;
        }

    }
}
