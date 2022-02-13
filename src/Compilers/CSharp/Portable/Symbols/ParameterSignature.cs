// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class ParameterSignature
    {
        internal readonly ImmutableArray<TypeWithAnnotations> parameterTypesWithAnnotations;

        internal readonly ImmutableArray<RefKind> parameterRefKinds;

        internal static readonly ParameterSignature NoParams;

        private ParameterSignature(ImmutableArray<TypeWithAnnotations> parameterTypesWithAnnotations,
                                           ImmutableArray<RefKind> parameterRefKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10142, 917, 1249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1114, 1181);

                this.parameterTypesWithAnnotations = parameterTypesWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1195, 1238);

                this.parameterRefKinds = parameterRefKinds;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10142, 917, 1249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10142, 917, 1249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10142, 917, 1249);
            }
        }

        private static ParameterSignature MakeParamTypesAndRefKinds(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10142, 1261, 2484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1389, 1480) || true) && (parameters.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 1389, 1480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1449, 1465);

                    return NoParams;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 1389, 1480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1496, 1556);

                var
                types = f_10142_1508_1555()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1570, 1604);

                ArrayBuilder<RefKind>
                refs = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1629, 1637);

                    for (int
        parm = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1620, 2264) || true) && (parm < parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1665, 1671)
        , ++parm, DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 1620, 2264))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 1620, 2264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1705, 1738);

                        var
                        parameter = parameters[parm]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1756, 1797);

                        f_10142_1756_1796(types, f_10142_1766_1795(parameter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1817, 1849);

                        var
                        refKind = f_10142_1831_1848(parameter)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1867, 2249) || true) && (refs == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 1867, 2249);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 1925, 2130) || true) && (refKind != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 1925, 2130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2002, 2063);

                                refs = f_10142_2009_2062(parm, RefKind.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2089, 2107);

                                f_10142_2089_2106(refs, refKind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 1925, 2130);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 1867, 2249);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 1867, 2249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2212, 2230);

                            f_10142_2212_2229(refs, refKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 1867, 2249);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10142, 1, 645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10142, 1, 645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2280, 2391);

                ImmutableArray<RefKind>
                refKinds = (DynAbs.Tracing.TraceSender.Conditional_F1(10142, 2315, 2327) || ((refs != null && DynAbs.Tracing.TraceSender.Conditional_F2(10142, 2330, 2355)) || DynAbs.Tracing.TraceSender.Conditional_F3(10142, 2358, 2390))) ? f_10142_2330_2355(refs) : default(ImmutableArray<RefKind>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2405, 2473);

                return f_10142_2412_2472(f_10142_2435_2461(types), refKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10142, 1261, 2484);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10142_1508_1555()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 1508, 1555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10142_1766_1795(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10142, 1766, 1795);
                    return return_v;
                }


                int
                f_10142_1756_1796(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 1756, 1796);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10142_1831_1848(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10142, 1831, 1848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10142_2009_2062(int
                capacity, Microsoft.CodeAnalysis.RefKind
                fillWithValue)
                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2009, 2062);
                    return return_v;
                }


                int
                f_10142_2089_2106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2089, 2106);
                    return 0;
                }


                int
                f_10142_2212_2229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2212, 2229);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10142_2330_2355(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2330, 2355);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10142_2435_2461(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2435, 2461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                f_10142_2412_2472(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature(parameterTypesWithAnnotations, parameterRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2412, 2472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10142, 1261, 2484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10142, 1261, 2484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void PopulateParameterSignature(ImmutableArray<ParameterSymbol> parameters, ref ParameterSignature lazySignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10142, 2496, 2827);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2650, 2816) || true) && (lazySignature == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10142, 2650, 2816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 2709, 2801);

                    f_10142_2709_2800(ref lazySignature, f_10142_2756_2793(parameters), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10142, 2650, 2816);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10142, 2496, 2827);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                f_10142_2756_2793(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    var return_v = MakeParamTypesAndRefKinds(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2756, 2793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature?
                f_10142_2709_2800(ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 2709, 2800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10142, 2496, 2827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10142, 2496, 2827);
            }
        }

        static ParameterSignature()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10142, 521, 2834);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10142, 781, 904);
            NoParams = f_10142_805_904(ImmutableArray<TypeWithAnnotations>.Empty, default(ImmutableArray<RefKind>)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10142, 521, 2834);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10142, 521, 2834);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10142, 521, 2834);

        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
        f_10142_805_904(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        parameterTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
        parameterRefKinds)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature(parameterTypesWithAnnotations, parameterRefKinds);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10142, 805, 904);
            return return_v;
        }

    }
}
