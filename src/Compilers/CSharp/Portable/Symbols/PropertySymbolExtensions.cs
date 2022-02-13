// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class PropertySymbolExtensions
    {
        public static MethodSymbol? GetOwnOrInheritedGetMethod(this PropertySymbol? property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10148, 663, 1122);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 773, 1083) || true) && ((object?)property != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 773, 1083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 839, 883);

                        MethodSymbol
                        getMethod = f_10148_864_882(property)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 901, 1009) || true) && ((object?)getMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 901, 1009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 973, 990);

                            return getMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 901, 1009);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1029, 1068);

                        property = f_10148_1040_1067(property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 773, 1083);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10148, 773, 1083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10148, 773, 1083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1099, 1111);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10148, 663, 1122);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10148_864_882(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 864, 882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10148_1040_1067(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 1040, 1067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10148, 663, 1122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10148, 663, 1122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodSymbol? GetOwnOrInheritedSetMethod(this PropertySymbol? property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10148, 1341, 1800);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1451, 1761) || true) && ((object?)property != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 1451, 1761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1517, 1561);

                        MethodSymbol
                        setMethod = f_10148_1542_1560(property)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1579, 1687) || true) && ((object?)setMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 1579, 1687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1651, 1668);

                            return setMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 1579, 1687);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1707, 1746);

                        property = f_10148_1718_1745(property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 1451, 1761);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10148, 1451, 1761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10148, 1451, 1761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1777, 1789);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10148, 1341, 1800);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10148_1542_1560(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 1542, 1560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10148_1718_1745(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 1718, 1745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10148, 1341, 1800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10148, 1341, 1800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanCallMethodsDirectly(this PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10148, 1812, 2224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1908, 2005) || true) && (f_10148_1912_1944(property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 1908, 2005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 1978, 1990);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 1908, 2005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 2119, 2213);

                return f_10148_2126_2152(property) && (DynAbs.Tracing.TraceSender.Expression_True(10148, 2126, 2212) && (f_10148_2157_2176_M(!property.IsIndexer) || (DynAbs.Tracing.TraceSender.Expression_False(10148, 2157, 2211) || f_10148_2180_2211(property))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10148, 1812, 2224);

                bool
                f_10148_1912_1944(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.MustCallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 1912, 1944);
                    return return_v;
                }


                bool
                f_10148_2126_2152(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 2126, 2152);
                    return return_v;
                }


                bool
                f_10148_2157_2176_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 2157, 2176);
                    return return_v;
                }


                bool
                f_10148_2180_2211(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.HasRefOrOutParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10148, 2180, 2211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10148, 1812, 2224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10148, 1812, 2224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasRefOrOutParameter(this PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10148, 2236, 2607);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 2330, 2569);
                    foreach (ParameterSymbol param in f_10148_2364_2383_I(f_10148_2364_2383(property)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 2330, 2569);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 2417, 2554) || true) && (f_10148_2421_2434(param) == RefKind.Ref || (DynAbs.Tracing.TraceSender.Expression_False(10148, 2421, 2481) || f_10148_2453_2466(param) == RefKind.Out))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10148, 2417, 2554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 2523, 2535);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 2417, 2554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10148, 2330, 2569);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10148, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10148, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10148, 2583, 2596);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10148, 2236, 2607);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10148_2364_2383(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 2364, 2383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10148_2421_2434(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 2421, 2434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10148_2453_2466(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10148, 2453, 2466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10148_2364_2383_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10148, 2364, 2383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10148, 2236, 2607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10148, 2236, 2607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PropertySymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10148, 393, 2614);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10148, 393, 2614);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10148, 393, 2614);
        }

    }
}
