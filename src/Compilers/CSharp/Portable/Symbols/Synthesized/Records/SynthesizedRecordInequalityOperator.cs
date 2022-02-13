// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordInequalityOperator : SynthesizedRecordEqualityOperatorBase
    {
        public SynthesizedRecordInequalityOperator(SourceMemberContainerTypeSymbol containingType, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10727_1348_1362_C(containingType), WellKnownMemberNames.InequalityOperatorName, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10727, 1192, 1457);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10727, 1192, 1457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10727, 1192, 1457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10727, 1192, 1457);
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10727, 1469, 2333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10727, 1601, 1715);

                var
                F = f_10727_1609_1714(this, f_10727_1645_1682(f_10727_1645_1659()), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10727, 1803, 2107);

                    f_10727_1803_2106(                // => !(r1 == r2);
                                    F, f_10727_1817_2105(F, f_10727_1825_2104(F, f_10727_1834_2103(F, f_10727_1840_2102(F, receiver: null, f_10727_1863_1984(f_10727_1863_1931(f_10727_1863_1877(), WellKnownMemberNames.EqualityOperatorName).OfType<SynthesizedRecordEqualityOperator>()), f_10727_2047_2073(F, f_10727_2059_2069()[0]), f_10727_2075_2101(F, f_10727_2087_2097()[1]))))));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10727, 2136, 2322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10727, 2229, 2260);

                    f_10727_2229_2259(diagnostics, f_10727_2245_2258(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10727, 2278, 2307);

                    f_10727_2278_2306(F, f_10727_2292_2305(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10727, 2136, 2322);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10727, 1469, 2333);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10727_1645_1659()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10727, 1645, 1659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10727_1645_1682(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1645, 1682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10727_1609_1714(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordInequalityOperator
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1609, 1714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10727_1863_1877()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10727, 1863, 1877);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10727_1863_1931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1863, 1931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperator
                f_10727_1863_1984(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperator>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1863, 1984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10727_2059_2069()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10727, 2059, 2069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10727_2047_2073(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 2047, 2073);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10727_2087_2097()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10727, 2087, 2097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10727_2075_2101(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 2075, 2101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10727_1840_2102(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperator
                method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg0, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg1)
                {
                    var return_v = this_param.Call(receiver: receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1840, 2102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10727_1834_2103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = this_param.Not((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1834, 2103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10727_1825_2104(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1825, 2104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10727_1817_2105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1817, 2105);
                    return return_v;
                }


                int
                f_10727_1803_2106(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 1803, 2106);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10727_2245_2258(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10727, 2245, 2258);
                    return return_v;
                }


                int
                f_10727_2229_2259(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 2229, 2259);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10727_2292_2305(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 2292, 2305);
                    return return_v;
                }


                int
                f_10727_2278_2306(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10727, 2278, 2306);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10727, 1469, 2333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10727, 1469, 2333);
            }
        }

        static SynthesizedRecordInequalityOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10727, 1078, 2340);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10727, 1078, 2340);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10727, 1078, 2340);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10727, 1078, 2340);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10727_1348_1362_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10727, 1192, 1457);
            return return_v;
        }

    }
}
