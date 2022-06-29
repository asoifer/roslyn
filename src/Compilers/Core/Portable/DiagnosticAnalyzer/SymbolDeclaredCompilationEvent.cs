// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class SymbolDeclaredCompilationEvent : CompilationEvent
    {
        private readonly Lazy<ImmutableArray<SyntaxReference>> _lazyCachedDeclaringReferences;

        public SymbolDeclaredCompilationEvent(Compilation compilation, ISymbol symbol, SemanticModel? semanticModelWithCachedBoundNodes = null)
        : base(f_274_940_951_C(compilation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(274, 784, 1217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 741, 771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1229, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1269, 1333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 977, 993);

                Symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1007, 1077);

                SemanticModelWithCachedBoundNodes = semanticModelWithCachedBoundNodes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1091, 1206);

                _lazyCachedDeclaringReferences = f_274_1124_1205(() => symbol.DeclaringSyntaxReferences);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(274, 784, 1217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(274, 784, 1217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(274, 784, 1217);
            }
        }

        public ISymbol Symbol { get; }

        public SemanticModel? SemanticModelWithCachedBoundNodes { get; }

        public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(274, 1568, 1607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1571, 1607);
                    return f_274_1571_1607(_lazyCachedDeclaringReferences); DynAbs.Tracing.TraceSender.TraceExitMethod(274, 1568, 1607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(274, 1568, 1607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(274, 1568, 1607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(274, 1620, 2101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1678, 1701);

                var
                name = f_274_1689_1700(f_274_1689_1695())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1715, 1748) || true) && (name == "")
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(274, 1715, 1748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1731, 1748);

                    name = "<empty>";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(274, 1715, 1748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1762, 1939);

                //var temp = f_274_1868_1893();
                //var loc = (DynAbs.Tracing.TraceSender.Conditional_F1(274, 1772, 1809) || 
                //    ((f_274_1772_1797().Length != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(274, 1812, 1931)) || 
                //    DynAbs.Tracing.TraceSender.Conditional_F3(274, 1934, 1938))) ? " @ " + 
                //    f_274_1820_1931(", ", f_274_1838_1930(ref temp, r => r.GetLocation().GetLineSpan())) : null;

                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(274, 1772, 1809);
                var loc = (string)null;
                if ((f_274_1772_1797().Length != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(274, 1812, 1931)) ||
                    DynAbs.Tracing.TraceSender.Conditional_F3(274, 1934, 1938))
                {
                    var temp = f_274_1868_1893();
                    loc = " @ " + f_274_1820_1931(", ", f_274_1838_1930(ref temp, r => r.GetLocation().GetLineSpan()));
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(274, 1953, 2090);
                return "SymbolDeclaredCompilationEvent(" + name + " " + f_274_2009_2077(f_274_2009_2015(), f_274_2032_2076()) + loc + ")";
                
                DynAbs.Tracing.TraceSender.TraceExitMethod(274, 1620, 2101);

                Microsoft.CodeAnalysis.ISymbol
                f_274_1689_1695()
                {
                    var return_v = Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 1689, 1695);
                    return return_v;
                }


                string
                f_274_1689_1700(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 1689, 1700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_274_1772_1797()
                {
                    var return_v = DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 1772, 1797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_274_1868_1893()
                {
                    var return_v = DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 1868, 1893);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FileLinePositionSpan>
                f_274_1838_1930(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.FileLinePositionSpan>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.FileLinePositionSpan>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(274, 1838, 1930);
                    return return_v;
                }


                string
                f_274_1820_1931(string
                separator, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FileLinePositionSpan>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(274, 1820, 1931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_274_2009_2015()
                {
                    var return_v = Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 2009, 2015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_274_2032_2076()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 2032, 2076);
                    return return_v;
                }


                string
                f_274_2009_2077(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(274, 2009, 2077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(274, 1620, 2101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(274, 1620, 2101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolDeclaredCompilationEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(274, 598, 2108);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(274, 598, 2108);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(274, 598, 2108);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(274, 598, 2108);

        static System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>>
        f_274_1124_1205(System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(274, 1124, 1205);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_274_940_951_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(274, 784, 1217);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_274_1571_1607(System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(274, 1571, 1607);
            return return_v;
        }

    }
}
