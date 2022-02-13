// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class TypeParameterSymbolExtensions
    {
        public static bool DependsOn(this TypeParameterSymbol typeParameter1, TypeParameterSymbol typeParameter2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10173, 394, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 524, 569);

                f_10173_524_568((object)typeParameter1 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 583, 628);

                f_10173_583_627((object)typeParameter2 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 644, 685);

                Stack<TypeParameterSymbol>?
                stack = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 699, 744);

                HashSet<TypeParameterSymbol>?
                visited = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 760, 1886) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 760, 1886);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 805, 1702);
                            foreach (var constraintType in f_10173_836_886_I(f_10173_836_886(typeParameter1)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 805, 1702);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 928, 1683) || true) && (constraintType.Type is TypeParameterSymbol typeParameter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 928, 1683);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1038, 1175) || true) && (f_10173_1042_1078(typeParameter, typeParameter2))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 1038, 1175);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1136, 1148);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 1038, 1175);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1236, 1331) || true) && (visited == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 1236, 1331);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1286, 1331);

                                        visited = f_10173_1296_1330();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 1236, 1331);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1357, 1660) || true) && (f_10173_1361_1387(visited, typeParameter))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 1357, 1660);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1484, 1577) || true) && (stack == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 1484, 1577);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1536, 1577);

                                            stack = f_10173_1544_1576();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 1484, 1577);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1607, 1633);

                                        f_10173_1607_1632(stack, typeParameter);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 1357, 1660);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 928, 1683);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 805, 1702);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10173, 1, 898);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10173, 1, 898);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1720, 1824) || true) && (stack is null || (DynAbs.Tracing.TraceSender.Expression_False(10173, 1724, 1757) || f_10173_1741_1752(stack) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10173, 1720, 1824);
                            DynAbs.Tracing.TraceSender.TraceBreak(10173, 1799, 1805);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 1720, 1824);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1842, 1871);

                        typeParameter1 = f_10173_1859_1870(stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10173, 760, 1886);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10173, 760, 1886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10173, 760, 1886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10173, 1902, 1915);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10173, 394, 1926);

                int
                f_10173_524_568(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 524, 568);
                    return 0;
                }


                int
                f_10173_583_627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 583, 627);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10173_836_886(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10173, 836, 886);
                    return return_v;
                }


                bool
                f_10173_1042_1078(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1042, 1078);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10173_1296_1330()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1296, 1330);
                    return return_v;
                }


                bool
                f_10173_1361_1387(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1361, 1387);
                    return return_v;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10173_1544_1576()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1544, 1576);
                    return return_v;
                }


                int
                f_10173_1607_1632(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1607, 1632);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10173_836_886_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 836, 886);
                    return return_v;
                }


                int
                f_10173_1741_1752(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10173, 1741, 1752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10173_1859_1870(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10173, 1859, 1870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10173, 394, 1926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10173, 394, 1926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterSymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10173, 326, 1933);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10173, 326, 1933);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10173, 326, 1933);
        }

    }
}
