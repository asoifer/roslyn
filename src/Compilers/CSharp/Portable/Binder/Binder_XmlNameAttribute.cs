// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal ImmutableArray<Symbol> BindXmlNameAttribute(XmlNameAttributeSyntax syntax, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10323, 585, 2037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 741, 776);

                var
                identifier = f_10323_758_775(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 792, 901) || true) && (f_10323_796_816(identifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10323, 792, 901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 850, 886);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10323, 792, 901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 917, 960);

                var
                name = identifier.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 976, 1022);

                var
                lookupResult = f_10323_995_1021()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1036, 1141);

                f_10323_1036_1140(this, lookupResult, name, arity: 0, useSiteDiagnostics: ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1157, 1327) || true) && (f_10323_1161_1178(lookupResult) == LookupResultKind.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10323, 1157, 1327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1238, 1258);

                    f_10323_1238_1257(lookupResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1276, 1312);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10323, 1157, 1327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1496, 1537);

                f_10323_1496_1536(f_10323_1509_1535(lookupResult));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1553, 1611);

                ArrayBuilder<Symbol>
                lookupSymbols = f_10323_1590_1610(lookupResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1627, 1740);

                f_10323_1627_1739(f_10323_1640_1661(f_10323_1640_1656(lookupSymbols, 0)) == SymbolKind.TypeParameter || (DynAbs.Tracing.TraceSender.Expression_False(10323, 1640, 1738) || f_10323_1693_1714(f_10323_1693_1709(lookupSymbols, 0)) == SymbolKind.Parameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1754, 1828);

                f_10323_1754_1827(f_10323_1767_1826(lookupSymbols, sym => sym.Kind == lookupSymbols[0].Kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1900, 1960);

                ImmutableArray<Symbol>
                result = f_10323_1932_1959(lookupSymbols)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 1976, 1996);

                f_10323_1976_1995(
                            lookupResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10323, 2012, 2026);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10323, 585, 2037);

                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10323_758_775(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 758, 775);
                    return return_v;
                }


                bool
                f_10323_796_816(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 796, 816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10323_995_1021()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 995, 1021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10323_1036_1140(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LookupSymbolsWithFallback(result, name, arity: arity, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1036, 1140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10323_1161_1178(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1161, 1178);
                    return return_v;
                }


                int
                f_10323_1238_1257(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1238, 1257);
                    return 0;
                }


                bool
                f_10323_1509_1535(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1509, 1535);
                    return return_v;
                }


                int
                f_10323_1496_1536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1496, 1536);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10323_1590_1610(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1590, 1610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10323_1640_1656(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1640, 1656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10323_1640_1661(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1640, 1661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10323_1693_1709(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1693, 1709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10323_1693_1714(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10323, 1693, 1714);
                    return return_v;
                }


                int
                f_10323_1627_1739(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1627, 1739);
                    return 0;
                }


                bool
                f_10323_1767_1826(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
                predicate)
                {
                    var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1767, 1826);
                    return return_v;
                }


                int
                f_10323_1754_1827(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1754, 1827);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10323_1932_1959(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1932, 1959);
                    return return_v;
                }


                int
                f_10323_1976_1995(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10323, 1976, 1995);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10323, 585, 2037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10323, 585, 2037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
