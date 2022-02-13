// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal readonly struct NamespaceOrTypeOrAliasSymbolWithAnnotations
        {

            private readonly TypeWithAnnotations _typeWithAnnotations;

            private readonly Symbol _symbol;

            private readonly bool _isNullableEnabled;

            private NamespaceOrTypeOrAliasSymbolWithAnnotations(TypeWithAnnotations typeWithAnnotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10287, 666, 1076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 791, 833);

                    // LAFHIS
                    f_10287_791_832(typeWithAnnotations.HasType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 851, 894);

                    _typeWithAnnotations = typeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 912, 927);

                    _symbol = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 945, 972);

                    _isNullableEnabled = false;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10287, 666, 1076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 666, 1076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 666, 1076);
                }
            }

            private NamespaceOrTypeOrAliasSymbolWithAnnotations(Symbol symbol, bool isNullableEnabled)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10287, 1092, 1409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1215, 1253);

                    // LAFHIS
                    f_10287_1215_1252(!(symbol is TypeSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1271, 1302);

                    _typeWithAnnotations = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1320, 1337);

                    _symbol = symbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1355, 1394);

                    _isNullableEnabled = isNullableEnabled;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10287, 1092, 1409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1092, 1409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1092, 1409);
                }
            }

            internal TypeWithAnnotations TypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1474, 1497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1477, 1497);
                        return _typeWithAnnotations; DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1474, 1497);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1474, 1497);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1474, 1497);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal Symbol Symbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1535, 1573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1538, 1573);
                        return _symbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol>(10287, 1538, 1573) ?? TypeWithAnnotations.Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1535, 1573);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1535, 1573);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1535, 1573);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1609, 1643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1612, 1643);
                        return f_10287_1612_1643_M(!_typeWithAnnotations.IsDefault); DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1609, 1643);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1609, 1643);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1609, 1643);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsAlias
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1680, 1716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1683, 1716);
                        return f_10287_1683_1696_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_symbol, 10287, 1683, 1696)?.Kind) == SymbolKind.Alias; DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1680, 1716);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1680, 1716);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1680, 1716);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal NamespaceOrTypeSymbol NamespaceOrTypeSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1784, 1818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1787, 1818);
                        return Symbol as NamespaceOrTypeSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1784, 1818);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1784, 1818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1784, 1818);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsDefault
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1857, 1908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 1860, 1908);
                        return f_10287_1860_1889_M(!_typeWithAnnotations.HasType) && (DynAbs.Tracing.TraceSender.Expression_True(10287, 1860, 1908) && _symbol is null); DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1857, 1908);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1857, 1908);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1857, 1908);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsNullableEnabled
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10287, 1989, 2197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2033, 2081);

                        f_10287_2033_2080(f_10287_2046_2059_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_symbol, 10287, 2046, 2059)?.Kind) == SymbolKind.Alias);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2152, 2178);

                        return _isNullableEnabled;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10287, 1989, 2197);

                        Microsoft.CodeAnalysis.SymbolKind?
                        f_10287_2046_2059_M(Microsoft.CodeAnalysis.SymbolKind?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10287, 2046, 2059);
                            return return_v;
                        }


                        int
                        f_10287_2033_2080(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 2033, 2080);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 1925, 2212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 1925, 2212);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal static NamespaceOrTypeOrAliasSymbolWithAnnotations CreateUnannotated(bool isNullableEnabled, Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10287, 2228, 2796);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2377, 2471) || true) && (symbol is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10287, 2377, 2471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2437, 2452);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10287, 2377, 2471);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2489, 2521);

                    var
                    type = symbol as TypeSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2539, 2781);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10287, 2546, 2558) || ((type is null && DynAbs.Tracing.TraceSender.Conditional_F2(10287, 2582, 2656)) || DynAbs.Tracing.TraceSender.Conditional_F3(10287, 2680, 2780))) ? f_10287_2582_2656(symbol, isNullableEnabled) : f_10287_2680_2780(TypeWithAnnotations.Create(isNullableEnabled, type));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10287, 2228, 2796);

                    Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                    f_10287_2582_2656(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol, bool
                    isNullableEnabled)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations(symbol, isNullableEnabled);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 2582, 2656);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                    f_10287_2680_2780(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    typeWithAnnotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations(typeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 2680, 2780);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 2228, 2796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 2228, 2796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static implicit operator NamespaceOrTypeOrAliasSymbolWithAnnotations(TypeWithAnnotations typeWithAnnotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10287, 2812, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10287, 2961, 3037);

                    return f_10287_2968_3036(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10287, 2812, 3052);

                    Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                    f_10287_2968_3036(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    typeWithAnnotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations(typeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 2968, 3036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10287, 2812, 3052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 2812, 3052);
                }
            }
            static NamespaceOrTypeOrAliasSymbolWithAnnotations()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10287, 398, 3063);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10287, 398, 3063);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10287, 398, 3063);
            }

            static int
            f_10287_791_832(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 791, 832);
                return 0;
            }


            static int
            f_10287_1215_1252(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10287, 1215, 1252);
                return 0;
            }


            bool
            f_10287_1612_1643_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10287, 1612, 1643);
                return return_v;
            }


            Microsoft.CodeAnalysis.SymbolKind?
            f_10287_1683_1696_M(Microsoft.CodeAnalysis.SymbolKind?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10287, 1683, 1696);
                return return_v;
            }


            bool
            f_10287_1860_1889_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10287, 1860, 1889);
                return return_v;
            }

        }
    }
}
