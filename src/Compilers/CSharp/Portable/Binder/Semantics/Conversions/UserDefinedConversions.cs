// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class ConversionsBase
    {
        private static TypeSymbol GetUnderlyingEffectiveType(TypeSymbol type, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10848, 568, 1522);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1198, 1483) || true) && ((object)type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 1198, 1483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1256, 1283);

                    type = f_10848_1263_1282(type);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1303, 1468) || true) && (f_10848_1307_1329(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 1303, 1468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1371, 1449);

                        type = f_10848_1378_1448(((TypeParameterSymbol)type), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 1303, 1468);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 1198, 1483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1499, 1511);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10848, 568, 1522);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10848_1263_1282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 1263, 1282);
                    return return_v;
                }


                bool
                f_10848_1307_1329(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 1307, 1329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10848_1378_1448(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 1378, 1448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10848, 568, 1522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10848, 568, 1522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void AddTypesParticipatingInUserDefinedConversion(ArrayBuilder<NamedTypeSymbol> result, TypeSymbol type, bool includeBaseTypes, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10848, 1534, 3003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1748, 1828) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 1748, 1828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 1806, 1813);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 1748, 1828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2035, 2073);

                f_10848_2035_2072(!f_10848_2049_2071(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2119, 2159);

                bool
                excludeExisting = f_10848_2142_2154(result) > 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2175, 2478) || true) && (f_10848_2179_2197(type) || (DynAbs.Tracing.TraceSender.Expression_False(10848, 2179, 2220) || f_10848_2201_2220(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 2175, 2478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2254, 2292);

                    var
                    namedType = (NamedTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2310, 2463) || true) && (!excludeExisting || (DynAbs.Tracing.TraceSender.Expression_False(10848, 2314, 2380) || !f_10848_2335_2380(namedType, result)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 2310, 2463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2422, 2444);

                        f_10848_2422_2443(result, namedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 2310, 2463);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 2175, 2478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2494, 2571) || true) && (!includeBaseTypes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 2494, 2571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2549, 2556);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 2494, 2571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2587, 2677);

                NamedTypeSymbol
                t = f_10848_2607_2676(type, ref useSiteDiagnostics)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2691, 2992) || true) && ((object)t != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 2691, 2992);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2749, 2886) || true) && (!excludeExisting || (DynAbs.Tracing.TraceSender.Expression_False(10848, 2753, 2811) || !f_10848_2774_2811(t, result)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10848, 2749, 2886);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2853, 2867);

                            f_10848_2853_2866(result, t);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 2749, 2886);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10848, 2906, 2977);

                        t = f_10848_2910_2976(t, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10848, 2691, 2992);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10848, 2691, 2992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10848, 2691, 2992);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10848, 1534, 3003);

                bool
                f_10848_2049_2071(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2049, 2071);
                    return return_v;
                }


                int
                f_10848_2035_2072(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2035, 2072);
                    return 0;
                }


                int
                f_10848_2142_2154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10848, 2142, 2154);
                    return return_v;
                }


                bool
                f_10848_2179_2197(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2179, 2197);
                    return return_v;
                }


                bool
                f_10848_2201_2220(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2201, 2220);
                    return return_v;
                }


                bool
                f_10848_2335_2380(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                targetTypes)
                {
                    var return_v = HasIdentityConversionToAny(type, targetTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2335, 2380);
                    return return_v;
                }


                int
                f_10848_2422_2443(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2422, 2443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10848_2607_2676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2607, 2676);
                    return return_v;
                }


                bool
                f_10848_2774_2811(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                targetTypes)
                {
                    var return_v = HasIdentityConversionToAny(type, targetTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2774, 2811);
                    return return_v;
                }


                int
                f_10848_2853_2866(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2853, 2866);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10848_2910_2976(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10848, 2910, 2976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10848, 1534, 3003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10848, 1534, 3003);
            }
        }
    }
}
