// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public abstract class EmitMetadataTestBase : CSharpTestBase
    {
        internal static XElement DumpTypeInfo(ModuleSymbol moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 734, 890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 823, 879);

                return f_23127_830_878(f_23127_849_877(moduleSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 734, 890);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_23127_849_877(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 849, 877);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_23127_830_878(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                n)
                {
                    var return_v = LoadChildNamespace(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 830, 878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 734, 890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 734, 890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static XElement LoadChildNamespace(NamespaceSymbol n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 902, 1555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 989, 1060);

                XElement
                elem = f_23127_1005_1059(((DynAbs.Tracing.TraceSender.Conditional_F1(23127, 1019, 1037) || ((f_23127_1019_1032(f_23127_1019_1025(n)) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(23127, 1040, 1048)) || DynAbs.Tracing.TraceSender.Conditional_F3(23127, 1051, 1057))) ? "Global" : f_23127_1051_1057(n)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1076, 1161);

                // Lafhis
                var temp = f_23127_1096_1114(n);
                var
                childrenTypes = f_23127_1096_1160(ref temp, (t) => t, f_23127_1133_1159())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1177, 1235);

                f_23127_1177_1234(
                            elem, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from t in childrenTypes select LoadChildType(t), 23127, 1186, 1233));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1251, 1440);

                var
                childrenNS = f_23127_1268_1439(f_23127_1268_1282(n).
                                                OfType<NamespaceSymbol>(), child => child.Name, f_23127_1406_1438())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1456, 1516);

                f_23127_1456_1515(
                            elem, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from c in childrenNS select LoadChildNamespace(c), 23127, 1465, 1514));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1532, 1544);

                return elem;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 902, 1555);

                string
                f_23127_1019_1025(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1019, 1025);
                    return return_v;
                }


                int
                f_23127_1019_1032(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1019, 1032);
                    return return_v;
                }


                string
                f_23127_1051_1057(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1051, 1057);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_23127_1005_1059(string
                name)
                {
                    var return_v = new System.Xml.Linq.XElement((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1005, 1059);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_23127_1096_1114(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1096, 1114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer
                f_23127_1133_1159()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1133, 1159);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_23127_1096_1160(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                keySelector, Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(keySelector, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1096, 1160);
                    return return_v;
                }


                int
                f_23127_1177_1234(System.Xml.Linq.XElement
                this_param, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1177, 1234);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23127_1268_1282(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1268, 1282);
                    return return_v;
                }


                System.StringComparer
                f_23127_1406_1438()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1406, 1438);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_23127_1268_1439(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, string>
                keySelector, System.StringComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, string>(keySelector, (System.Collections.Generic.IComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1268, 1439);
                    return return_v;
                }


                int
                f_23127_1456_1515(System.Xml.Linq.XElement
                this_param, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1456, 1515);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 902, 1555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 902, 1555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static XElement LoadChildType(NamedTypeSymbol t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 1567, 2767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1648, 1685);

                XElement
                elem = f_23127_1664_1684("type")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1701, 1742);

                f_23127_1701_1741(
                            elem, f_23127_1710_1740("name", f_23127_1733_1739(t)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1758, 2202) || true) && (f_23127_1762_1769(t) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 1758, 2202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1807, 1840);

                    string
                    typeParams = string.Empty
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1860, 2124);
                        foreach (var param in f_23127_1882_1898_I(f_23127_1882_1898(t)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 1860, 2124);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 1940, 2056) || true) && (f_23127_1944_1961(typeParams) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 1940, 2056);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2015, 2033);

                                typeParams += ",";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 1940, 2056);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2080, 2105);

                            typeParams += f_23127_2094_2104(param);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 1860, 2124);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(23127, 1, 265);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(23127, 1, 265);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2144, 2187);

                    f_23127_2144_2186(
                                    elem, f_23127_2153_2185("Of", typeParams));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 1758, 2202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2218, 2368) || true) && ((object)f_23127_2230_2242(t) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 2218, 2368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2284, 2353);

                    f_23127_2284_2352(elem, f_23127_2293_2351("base", f_23127_2316_2350(f_23127_2316_2328(t))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 2218, 2368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2384, 2492);

                var
                fields = f_23127_2397_2491(f_23127_2397_2471(f_23127_2397_2411(t).Where(m => m.Kind == SymbolKind.Field), f => f.Name))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2508, 2555);

                f_23127_2508_2554(
                            elem, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from f in fields select LoadField(f), 23127, 2517, 2553));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2571, 2654);

                // Lafhis
                var temp = f_23127_2591_2609(t);
                var
                childrenTypes = f_23127_2591_2653(ref temp, c => c, f_23127_2626_2652())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2670, 2728);

                f_23127_2670_2727(
                            elem, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from c in childrenTypes select LoadChildType(c), 23127, 2679, 2726));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2744, 2756);

                return elem;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 1567, 2767);

                System.Xml.Linq.XElement
                f_23127_1664_1684(string
                name)
                {
                    var return_v = new System.Xml.Linq.XElement((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1664, 1684);
                    return return_v;
                }


                string
                f_23127_1733_1739(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1733, 1739);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_23127_1710_1740(string
                name, string
                value)
                {
                    var return_v = new System.Xml.Linq.XAttribute((System.Xml.Linq.XName)name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1710, 1740);
                    return return_v;
                }


                int
                f_23127_1701_1741(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1701, 1741);
                    return 0;
                }


                int
                f_23127_1762_1769(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1762, 1769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_23127_1882_1898(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1882, 1898);
                    return return_v;
                }


                int
                f_23127_1944_1961(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 1944, 1961);
                    return return_v;
                }


                string
                f_23127_2094_2104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 2094, 2104);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_23127_1882_1898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 1882, 1898);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_23127_2153_2185(string
                name, string
                value)
                {
                    var return_v = new System.Xml.Linq.XAttribute((System.Xml.Linq.XName)name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2153, 2185);
                    return return_v;
                }


                int
                f_23127_2144_2186(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2144, 2186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23127_2230_2242(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2230, 2242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23127_2316_2328(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2316, 2328);
                    return return_v;
                }


                string
                f_23127_2316_2350(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2316, 2350);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_23127_2293_2351(string
                name, string
                value)
                {
                    var return_v = new System.Xml.Linq.XAttribute((System.Xml.Linq.XName)name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2293, 2351);
                    return return_v;
                }


                int
                f_23127_2284_2352(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2284, 2352);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23127_2397_2411(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2397, 2411);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23127_2397_2471(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbol, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2397, 2471);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_23127_2397_2491(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2397, 2491);
                    return return_v;
                }


                int
                f_23127_2508_2554(System.Xml.Linq.XElement
                this_param, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2508, 2554);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_23127_2591_2609(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2591, 2609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer
                f_23127_2626_2652()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2626, 2652);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_23127_2591_2653(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                keySelector, Microsoft.CodeAnalysis.CSharp.UnitTests.NameAndArityComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(keySelector, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2591, 2653);
                    return return_v;
                }


                int
                f_23127_2670_2727(System.Xml.Linq.XElement
                this_param, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2670, 2727);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 1567, 2767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 1567, 2767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static XElement LoadField(FieldSymbol f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 2779, 3063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2852, 2890);

                XElement
                elem = f_23127_2868_2889("field")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2906, 2947);

                f_23127_2906_2946(
                            elem, f_23127_2915_2945("name", f_23127_2938_2944(f)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 2961, 3024);

                f_23127_2961_3023(elem, f_23127_2970_3022("type", f_23127_2993_3021(f_23127_2993_2999(f))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3040, 3052);

                return elem;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 2779, 3063);

                System.Xml.Linq.XElement
                f_23127_2868_2889(string
                name)
                {
                    var return_v = new System.Xml.Linq.XElement((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2868, 2889);
                    return return_v;
                }


                string
                f_23127_2938_2944(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 2938, 2944);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_23127_2915_2945(string
                name, string
                value)
                {
                    var return_v = new System.Xml.Linq.XAttribute((System.Xml.Linq.XName)name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2915, 2945);
                    return return_v;
                }


                int
                f_23127_2906_2946(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2906, 2946);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_23127_2993_2999(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 2993, 2999);
                    return return_v;
                }


                string
                f_23127_2993_3021(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2993, 3021);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_23127_2970_3022(string
                name, string
                value)
                {
                    var return_v = new System.Xml.Linq.XAttribute((System.Xml.Linq.XName)name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2970, 3022);
                    return return_v;
                }


                int
                f_23127_2961_3023(System.Xml.Linq.XElement
                this_param, System.Xml.Linq.XAttribute
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 2961, 3023);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 2779, 3063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 2779, 3063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ValidateDeclSecurity(ModuleSymbol module, params DeclSecurityEntry[] expectedEntries)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 3239, 4792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3370, 3427);

                var
                metadataReader = f_23127_3391_3426(f_23127_3391_3411(module))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3441, 3513);

                var
                actualEntries = f_23127_3461_3512(f_23127_3489_3511(expectedEntries))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3529, 3539);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3553, 4512);
                    foreach (var actualHandle in f_23127_3582_3626_I(f_23127_3582_3626(metadataReader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 3553, 4512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3660, 3734);

                        var
                        actual = f_23127_3673_3733(metadataReader, actualHandle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3754, 3835);

                        var
                        actualPermissionSetBytes = f_23127_3785_3834(metadataReader, actual.PermissionSet)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3853, 3947);

                        var
                        actualPermissionSet = f_23127_3879_3946(f_23127_3890_3945(f_23127_3890_3935(actualPermissionSetBytes, b => (char)b)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 3965, 3989);

                        string
                        actualParentName
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4007, 4035);

                        SymbolKind
                        actualParentKind
                        = default(SymbolKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4053, 4158);

                        f_23127_4053_4157(metadataReader, actual.Parent, out actualParentName, out actualParentKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4178, 4473);

                        f_23127_4178_4472(
                                        actualEntries, new DeclSecurityEntry()
                                        {
                                            ActionFlags = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => actual.Action, 23127, 4196, 4471),
                                            ParentNameOpt = actualParentName,
                                            PermissionSet = actualPermissionSet,
                                            ParentKind = actualParentKind
                                        });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4493, 4497);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 3553, 4512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23127, 1, 960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23127, 1, 960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4528, 4781);

                f_23127_4528_4780(expectedEntries, actualEntries, itemInspector: entry => $@"
{{
    ActionFlags = {entry.ActionFlags},
    ParentNameOpt = {entry.ParentNameOpt},
    PermissionSet = {entry.PermissionSet},
    ParentKind = {entry.ParentKind}
}}");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 3239, 4792);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_23127_3391_3411(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3391, 3411);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_23127_3391_3426(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 3391, 3426);
                    return return_v;
                }


                int
                f_23127_3489_3511(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 3489, 3511);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>
                f_23127_3461_3512(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3461, 3512);
                    return return_v;
                }


                System.Reflection.Metadata.DeclarativeSecurityAttributeHandleCollection
                f_23127_3582_3626(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.DeclarativeSecurityAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 3582, 3626);
                    return return_v;
                }


                System.Reflection.Metadata.DeclarativeSecurityAttribute
                f_23127_3673_3733(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.DeclarativeSecurityAttributeHandle
                handle)
                {
                    var return_v = this_param.GetDeclarativeSecurityAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3673, 3733);
                    return return_v;
                }


                byte[]
                f_23127_3785_3834(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobBytes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3785, 3834);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<char>
                f_23127_3890_3935(byte[]
                source, System.Func<byte, char>
                selector)
                {
                    var return_v = source.Select<byte, char>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3890, 3935);
                    return return_v;
                }


                char[]
                f_23127_3890_3945(System.Collections.Generic.IEnumerable<char>
                source)
                {
                    var return_v = source.ToArray<char>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3890, 3945);
                    return return_v;
                }


                string
                f_23127_3879_3946(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3879, 3946);
                    return return_v;
                }


                int
                f_23127_4053_4157(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                token, out string
                name, out Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    GetAttributeParentNameAndKind(metadataReader, token, out name, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 4053, 4157);
                    return 0;
                }


                int
                f_23127_4178_4472(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>
                this_param, Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 4178, 4472);
                    return 0;
                }


                System.Reflection.Metadata.DeclarativeSecurityAttributeHandleCollection
                f_23127_3582_3626_I(System.Reflection.Metadata.DeclarativeSecurityAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 3582, 3626);
                    return return_v;
                }


                int
                f_23127_4528_4780(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry[]
                expected, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>
                actual, System.Func<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry, string>
                itemInspector)
                {
                    AssertEx.SetEqual((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>)expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadataTestBase.DeclSecurityEntry>)actual, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 4528, 4780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 3239, 4792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 3239, 4792);
            }
        }

        private static void GetAttributeParentNameAndKind(MetadataReader metadataReader, EntityHandle token, out string name, out SymbolKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 4804, 5806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 4967, 5795);

                switch (token.Kind)
                {

                    case HandleKind.AssemblyDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 4967, 5795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5076, 5088);

                        name = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5110, 5137);

                        kind = SymbolKind.Assembly;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5159, 5166);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 4967, 5795);

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 4967, 5795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5239, 5339);

                        name = f_23127_5246_5338(metadataReader, f_23127_5271_5332(metadataReader, token).Name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5361, 5389);

                        kind = SymbolKind.NamedType;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5411, 5418);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 4967, 5795);

                    case HandleKind.MethodDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 4967, 5795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5493, 5597);

                        name = f_23127_5500_5596(metadataReader, f_23127_5525_5590(metadataReader, token).Name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5619, 5644);

                        kind = SymbolKind.Method;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5666, 5673);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 4967, 5795);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 4967, 5795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5723, 5780);

                        throw f_23127_5729_5779(token.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 4967, 5795);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 4804, 5806);

                System.Reflection.Metadata.TypeDefinition
                f_23127_5271_5332(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition((System.Reflection.Metadata.TypeDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5271, 5332);
                    return return_v;
                }


                string
                f_23127_5246_5338(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5246, 5338);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_23127_5525_5590(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition((System.Reflection.Metadata.MethodDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5525, 5590);
                    return return_v;
                }


                string
                f_23127_5500_5596(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5500, 5596);
                    return return_v;
                }


                System.InvalidOperationException
                f_23127_5729_5779(System.Reflection.Metadata.HandleKind
                o)
                {
                    var return_v = TestExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5729, 5779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 4804, 5806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 4804, 5806);
            }
        }

        private static TypeDefinitionHandle GetTokenForType(MetadataReader metadataReader, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 5818, 6461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5942, 5967);

                f_23127_5942_5966(typeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 5981, 6007);

                f_23127_5981_6006(typeName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6023, 6334);
                    foreach (var typeDef in f_23127_6047_6077_I(f_23127_6047_6077(metadataReader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 6023, 6334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6111, 6198);

                        string
                        name = f_23127_6125_6197(metadataReader, f_23127_6150_6191(metadataReader, typeDef).Name)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6218, 6319) || true) && (f_23127_6222_6243(typeName, name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 6218, 6319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6285, 6300);

                            return typeDef;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 6218, 6319);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 6023, 6334);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23127, 1, 312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23127, 1, 312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6350, 6399);

                f_23127_6350_6398("Unable to find type:" + typeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6413, 6450);

                return default(TypeDefinitionHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 5818, 6461);

                int
                f_23127_5942_5966(string
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5942, 5966);
                    return 0;
                }


                int
                f_23127_5981_6006(string
                collection)
                {
                    Assert.NotEmpty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 5981, 6006);
                    return 0;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_23127_6047_6077(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 6047, 6077);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_23127_6150_6191(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6150, 6191);
                    return return_v;
                }


                string
                f_23127_6125_6197(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6125, 6197);
                    return return_v;
                }


                bool
                f_23127_6222_6243(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6222, 6243);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_23127_6047_6077_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6047, 6077);
                    return return_v;
                }


                int
                f_23127_6350_6398(string
                message)
                {
                    AssertEx.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6350, 6398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 5818, 6461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 5818, 6461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodDefinitionHandle GetTokenForMethod(MetadataReader metadataReader, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23127, 6473, 7144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6603, 6630);

                f_23127_6603_6629(methodName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6644, 6672);

                f_23127_6644_6671(methodName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6688, 7011);
                    foreach (var methodDef in f_23127_6714_6746_I(f_23127_6714_6746(metadataReader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 6688, 7011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6780, 6871);

                        string
                        name = f_23127_6794_6870(metadataReader, f_23127_6819_6864(metadataReader, methodDef).Name)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6891, 6996) || true) && (f_23127_6895_6918(methodName, name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23127, 6891, 6996);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 6960, 6977);

                            return methodDef;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 6891, 6996);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23127, 6688, 7011);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23127, 1, 324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23127, 1, 324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 7027, 7080);

                f_23127_7027_7079("Unable to find method:" + methodName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23127, 7094, 7133);

                return default(MethodDefinitionHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23127, 6473, 7144);

                int
                f_23127_6603_6629(string
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6603, 6629);
                    return 0;
                }


                int
                f_23127_6644_6671(string
                collection)
                {
                    Assert.NotEmpty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6644, 6671);
                    return 0;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_23127_6714_6746(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MethodDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23127, 6714, 6746);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_23127_6819_6864(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6819, 6864);
                    return return_v;
                }


                string
                f_23127_6794_6870(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6794, 6870);
                    return return_v;
                }


                bool
                f_23127_6895_6918(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6895, 6918);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_23127_6714_6746_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 6714, 6746);
                    return return_v;
                }


                int
                f_23127_7027_7079(string
                message)
                {
                    AssertEx.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23127, 7027, 7079);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23127, 6473, 7144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 6473, 7144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal struct DeclSecurityEntry
        {

            public DeclarativeSecurityAction ActionFlags;

            public SymbolKind ParentKind;

            public string ParentNameOpt;

            public string PermissionSet;
            static DeclSecurityEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23127, 7156, 7397);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23127, 7156, 7397);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 7156, 7397);
            }
        }

        public EmitMetadataTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23127, 658, 7426);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23127, 658, 7426);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 658, 7426);
        }


        static EmitMetadataTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23127, 658, 7426);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23127, 658, 7426);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23127, 658, 7426);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23127, 658, 7426);
    }
}
