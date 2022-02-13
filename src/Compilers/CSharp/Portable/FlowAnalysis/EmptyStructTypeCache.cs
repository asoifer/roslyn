// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class EmptyStructTypeCache
    {
        private SmallDictionary<NamedTypeSymbol, bool> _cache;

        private readonly bool _dev12CompilerCompatibility;

        private readonly SourceAssemblySymbol _sourceAssembly;

        private SmallDictionary<NamedTypeSymbol, bool> Cache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 1168, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 1204, 1326);

                    return _cache ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>>(10893, 1211, 1325) ?? (_cache = f_10893_1231_1324(Symbols.SymbolEqualityComparer.ConsiderEverything)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 1168, 1341);

                    Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                    f_10893_1231_1324(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                    comparer)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 1231, 1324);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 1091, 1352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 1091, 1352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static EmptyStructTypeCache CreateForDev12Compatibility(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 1471, 1545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 1474, 1545);
                return f_10893_1474_1545(compilation, dev12CompilerCompatibility: true); DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 1471, 1545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 1471, 1545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 1471, 1545);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
            f_10893_1474_1545(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation, bool
            dev12CompilerCompatibility)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache(compilation, dev12CompilerCompatibility: dev12CompilerCompatibility);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 1474, 1545);
                return return_v;
            }

        }

        public static EmptyStructTypeCache CreatePrecise()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 1622, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 1625, 1662);
                return f_10893_1625_1662(null, false); DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 1622, 1662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 1622, 1662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 1622, 1662);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
            f_10893_1625_1662(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation, bool
            dev12CompilerCompatibility)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache(compilation, dev12CompilerCompatibility);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 1625, 1662);
                return return_v;
            }

        }

        public static EmptyStructTypeCache CreateNeverEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 1742, 1776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 1745, 1776);
                return f_10893_1745_1776(); DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 1742, 1776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 1742, 1776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 1742, 1776);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache.NeverEmptyStructTypeCache
            f_10893_1745_1776()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache.NeverEmptyStructTypeCache();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 1745, 1776);
                return return_v;
            }

        }

        private EmptyStructTypeCache(CSharpCompilation compilation, bool dev12CompilerCompatibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10893, 2300, 2624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 806, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 985, 1012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 1063, 1078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 2417, 2482);

                f_10893_2417_2481(compilation != null || (DynAbs.Tracing.TraceSender.Expression_False(10893, 2430, 2480) || !dev12CompilerCompatibility));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 2496, 2553);

                _dev12CompilerCompatibility = dev12CompilerCompatibility;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 2567, 2613);

                _sourceAssembly = f_10893_2585_2612_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(compilation, 10893, 2585, 2612)?.SourceAssembly);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10893, 2300, 2624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 2300, 2624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 2300, 2624);
            }
        }
        private sealed class NeverEmptyStructTypeCache : EmptyStructTypeCache
        {
            public NeverEmptyStructTypeCache()
            : base(f_10893_2919_2923_C(null), false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10893, 2861, 2961);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10893, 2861, 2961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 2861, 2961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 2861, 2961);
                }
            }

            public override bool IsEmptyStructType(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 2977, 3093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 3065, 3078);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 2977, 3093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 2977, 3093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 2977, 3093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NeverEmptyStructTypeCache()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10893, 2767, 3104);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10893, 2767, 3104);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 2767, 3104);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10893, 2767, 3104);

            static Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
            f_10893_2919_2923_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10893, 2861, 2961);
                return return_v;
            }

        }

        public virtual bool IsEmptyStructType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 3229, 3383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 3308, 3372);

                return f_10893_3315_3371(this, type, ConsList<NamedTypeSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 3229, 3383);

                bool
                f_10893_3315_3371(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                typesWithMembersOfThisType)
                {
                    var return_v = this_param.IsEmptyStructType(type, typesWithMembersOfThisType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 3315, 3371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 3229, 3383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 3229, 3383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsEmptyStructType(TypeSymbol type, ConsList<NamedTypeSymbol> typesWithMembersOfThisType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 3669, 4358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 3795, 3829);

                var
                nts = type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 3843, 3959) || true) && ((object)nts == null || (DynAbs.Tracing.TraceSender.Expression_False(10893, 3847, 3897) || !f_10893_3871_3897(nts)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 3843, 3959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 3931, 3944);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 3843, 3959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4010, 4022);

                bool
                result
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4036, 4137) || true) && (f_10893_4040_4074(f_10893_4040_4045(), nts, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 4036, 4137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4108, 4122);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 4036, 4137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4153, 4207);

                result = f_10893_4162_4206(this, typesWithMembersOfThisType, nts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4221, 4283);

                f_10893_4221_4282(!f_10893_4235_4257(f_10893_4235_4240(), nts) || (DynAbs.Tracing.TraceSender.Expression_False(10893, 4234, 4281) || f_10893_4261_4271(f_10893_4261_4266(), nts) == result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4297, 4317);

                f_10893_4297_4302()[nts] = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4333, 4347);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 3669, 4358);

                bool
                f_10893_3871_3897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = IsTrackableStructType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 3871, 3897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                f_10893_4040_4045()
                {
                    var return_v = Cache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 4040, 4045);
                    return return_v;
                }


                bool
                f_10893_4040_4074(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4040, 4074);
                    return return_v;
                }


                bool
                f_10893_4162_4206(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                typesWithMembersOfThisType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                nts)
                {
                    var return_v = this_param.CheckStruct(typesWithMembersOfThisType, nts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4162, 4206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                f_10893_4235_4240()
                {
                    var return_v = Cache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 4235, 4240);
                    return return_v;
                }


                bool
                f_10893_4235_4257(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4235, 4257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                f_10893_4261_4266()
                {
                    var return_v = Cache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 4261, 4266);
                    return return_v;
                }


                bool
                f_10893_4261_4271(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 4261, 4271);
                    return return_v;
                }


                int
                f_10893_4221_4282(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4221, 4282);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                f_10893_4297_4302()
                {
                    var return_v = Cache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 4297, 4302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 3669, 4358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 3669, 4358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckStruct(ConsList<NamedTypeSymbol> typesWithMembersOfThisType, NamedTypeSymbol nts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 4370, 5012);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4596, 4973) || true) && (!f_10893_4601_4650(typesWithMembersOfThisType, nts))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 4596, 4973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4782, 4874);

                    typesWithMembersOfThisType = f_10893_4811_4873(nts, typesWithMembersOfThisType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4892, 4958);

                    return f_10893_4899_4957(this, typesWithMembersOfThisType, nts);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 4596, 4973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 4989, 5001);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 4370, 5012);

                bool
                f_10893_4601_4650(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4601, 4650);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10893_4811_4873(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                head, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4811, 4873);
                    return return_v;
                }


                bool
                f_10893_4899_4957(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                typesWithMembersOfThisType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.CheckStructInstanceFields(typesWithMembersOfThisType, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 4899, 4957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 4370, 5012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 4370, 5012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTrackableStructType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10893, 5024, 5382);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5106, 5145) || true) && ((object)type == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 5106, 5145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5132, 5145);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 5106, 5145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5159, 5212);

                var
                nts = f_10893_5169_5192(type) as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5226, 5264) || true) && ((object)nts == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 5226, 5264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5251, 5264);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 5226, 5264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5278, 5371);

                return f_10893_5285_5303(nts) && (DynAbs.Tracing.TraceSender.Expression_True(10893, 5285, 5342) && f_10893_5307_5322(nts) == SpecialType.None) && (DynAbs.Tracing.TraceSender.Expression_True(10893, 5285, 5370) && f_10893_5346_5370_M(!nts.KnownCircularStruct));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10893, 5024, 5382);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10893_5169_5192(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 5169, 5192);
                    return return_v;
                }


                bool
                f_10893_5285_5303(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 5285, 5303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10893_5307_5322(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 5307, 5322);
                    return return_v;
                }


                bool
                f_10893_5346_5370_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 5346, 5370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 5024, 5382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 5024, 5382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckStructInstanceFields(ConsList<NamedTypeSymbol> typesWithMembersOfThisType, NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 5535, 6434);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5818, 6395);
                    foreach (var member in f_10893_5841_5886_I(f_10893_5841_5886(f_10893_5841_5864(type))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 5818, 6395);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5920, 6009) || true) && (f_10893_5924_5939(member))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 5920, 6009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 5981, 5990);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 5920, 6009);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6027, 6068);

                        var
                        field = f_10893_6039_6067(this, member, type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6086, 6380) || true) && ((object)field != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 6086, 6380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6153, 6186);

                            var
                            actualFieldType = f_10893_6175_6185(field)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6208, 6361) || true) && (!f_10893_6213_6275(this, actualFieldType, typesWithMembersOfThisType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 6208, 6361);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6325, 6338);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 6208, 6361);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 6086, 6380);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 5818, 6395);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10893, 1, 578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10893, 1, 578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6411, 6423);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 5535, 6434);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10893_5841_5864(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 5841, 5864);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10893_5841_5886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 5841, 5886);
                    return return_v;
                }


                bool
                f_10893_5924_5939(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 5924, 5939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10893_6039_6067(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.GetActualField(member, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 6039, 6067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10893_6175_6185(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 6175, 6185);
                    return return_v;
                }


                bool
                f_10893_6213_6275(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                typesWithMembersOfThisType)
                {
                    var return_v = this_param.IsEmptyStructType(type, typesWithMembersOfThisType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 6213, 6275);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10893_5841_5886_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 5841, 5886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 5535, 6434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 5535, 6434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<FieldSymbol> GetStructInstanceFields(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 6600, 6955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6697, 6731);

                var
                nts = type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6745, 6878) || true) && ((object)nts == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 6745, 6878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6802, 6863);

                    return f_10893_6809_6862();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 6745, 6878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 6894, 6944);

                return f_10893_6901_6943(this, nts, includeStatic: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 6600, 6955);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10893_6809_6862()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 6809, 6862);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10893_6901_6943(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                includeStatic)
                {
                    var return_v = this_param.GetStructFields(type, includeStatic: includeStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 6901, 6943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 6600, 6955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 6600, 6955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<FieldSymbol> GetStructFields(NamedTypeSymbol type, bool includeStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 6967, 7642);

                var listYield = new List<FieldSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7225, 7631);
                    foreach (var member in f_10893_7248_7293_I(f_10893_7248_7293(f_10893_7248_7271(type))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 7225, 7631);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7327, 7434) || true) && (!includeStatic && (DynAbs.Tracing.TraceSender.Expression_True(10893, 7331, 7364) && f_10893_7349_7364(member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 7327, 7434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7406, 7415);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 7327, 7434);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7452, 7493);

                        var
                        field = f_10893_7464_7492(this, member, type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7511, 7616) || true) && ((object)field != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 7511, 7616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7578, 7597);

                            listYield.Add(field);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 7511, 7616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 7225, 7631);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10893, 1, 407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10893, 1, 407);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 6967, 7642);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10893_7248_7271(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 7248, 7271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10893_7248_7293(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 7248, 7293);
                    return return_v;
                }


                bool
                f_10893_7349_7364(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 7349, 7364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10893_7464_7492(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.GetActualField(member, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 7464, 7492);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10893_7248_7293_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 7248, 7293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 6967, 7642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 6967, 7642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FieldSymbol GetActualField(Symbol member, NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 7654, 8739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7750, 8700);

                switch (f_10893_7758_7769(member))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 7750, 8700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 7847, 7879);

                        var
                        field = (FieldSymbol)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8163, 8277) || true) && (f_10893_8167_8192(field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 8163, 8277);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8242, 8254);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 8163, 8277);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8301, 8410);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10893, 8308, 8379) || (((f_10893_8309_8332(field) || (DynAbs.Tracing.TraceSender.Expression_False(10893, 8309, 8378) || f_10893_8336_8378(this, field, f_10893_8367_8377(field)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10893, 8382, 8386)) || DynAbs.Tracing.TraceSender.Conditional_F3(10893, 8389, 8409))) ? null : f_10893_8389_8409(field, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 7750, 8700);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 7750, 8700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8474, 8512);

                        var
                        eventSymbol = (EventSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8534, 8685);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10893, 8541, 8632) || (((f_10893_8542_8573_M(!eventSymbol.HasAssociatedField) || (DynAbs.Tracing.TraceSender.Expression_False(10893, 8542, 8631) || f_10893_8577_8631(this, eventSymbol, f_10893_8614_8630(eventSymbol)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10893, 8635, 8639)) || DynAbs.Tracing.TraceSender.Conditional_F3(10893, 8642, 8684))) ? null : f_10893_8642_8684(f_10893_8642_8669(eventSymbol), type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 7750, 8700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8716, 8728);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 7654, 8739);

                Microsoft.CodeAnalysis.SymbolKind
                f_10893_7758_7769(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 7758, 7769);
                    return return_v;
                }


                bool
                f_10893_8167_8192(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtualTupleField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8167, 8192);
                    return return_v;
                }


                bool
                f_10893_8309_8332(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8309, 8332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10893_8367_8377(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8367, 8377);
                    return return_v;
                }


                bool
                f_10893_8336_8378(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                memberType)
                {
                    var return_v = this_param.ShouldIgnoreStructField((Microsoft.CodeAnalysis.CSharp.Symbol)member, memberType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 8336, 8378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10893_8389_8409(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 8389, 8409);
                    return return_v;
                }


                bool
                f_10893_8542_8573_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8542, 8573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10893_8614_8630(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8614, 8630);
                    return return_v;
                }


                bool
                f_10893_8577_8631(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                memberType)
                {
                    var return_v = this_param.ShouldIgnoreStructField((Microsoft.CodeAnalysis.CSharp.Symbol)member, memberType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 8577, 8631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10893_8642_8669(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 8642, 8669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10893_8642_8684(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 8642, 8684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 7654, 8739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 7654, 8739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldIgnoreStructField(Symbol member, TypeSymbol memberType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10893, 8751, 9493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 8850, 9431);

                return _dev12CompilerCompatibility && (DynAbs.Tracing.TraceSender.Expression_True(10893, 8857, 9146) && ((object)f_10893_9019_9044(member) != _sourceAssembly || (DynAbs.Tracing.TraceSender.Expression_False(10893, 9011, 9145) || f_10893_9109_9140(f_10893_9109_9132(member)) != 0))) && (DynAbs.Tracing.TraceSender.Expression_True(10893, 8857, 9255) && f_10893_9228_9255(memberType)) && (DynAbs.Tracing.TraceSender.Expression_True(10893, 8857, 9430) && !f_10893_9383_9430(member, _sourceAssembly));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10893, 8751, 9493);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10893_9019_9044(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 9019, 9044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10893_9109_9132(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 9109, 9132);
                    return return_v;
                }


                int
                f_10893_9109_9140(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 9109, 9140);
                    return return_v;
                }


                bool
                f_10893_9228_9255(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsIgnorableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 9228, 9255);
                    return return_v;
                }


                bool
                f_10893_9383_9430(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                assembly)
                {
                    var return_v = IsAccessibleInAssembly(symbol, assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 9383, 9430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 8751, 9493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 8751, 9493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsIgnorableType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10893, 9727, 10339);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 9804, 10328) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 9804, 10328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 9849, 10313);

                        switch (f_10893_9857_9870(type))
                        {

                            case TypeKind.Enum:
                            case TypeKind.Struct:
                            case TypeKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 9849, 10313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10050, 10063);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 9849, 10313);

                            case TypeKind.Array:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 9849, 10313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10131, 10191);

                                type = f_10893_10138_10190(((ArrayTypeSymbol)type));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10217, 10226);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 9849, 10313);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 9849, 10313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10282, 10294);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 9849, 10313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 9804, 10328);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10893, 9804, 10328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10893, 9804, 10328);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10893, 9727, 10339);

                Microsoft.CodeAnalysis.TypeKind
                f_10893_9857_9870(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 9857, 9870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10893_10138_10190(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 10138, 10190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 9727, 10339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 9727, 10339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAccessibleInAssembly(Symbol symbol, SourceAssemblySymbol assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10893, 10684, 11389);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10797, 11350) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10893, 10804, 10857) && f_10893_10822_10833(symbol) != SymbolKind.Namespace))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10859, 10891)
   , symbol = f_10893_10868_10891(symbol), DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 10797, 11350))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 10797, 11350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 10925, 11335);

                        switch (f_10893_10933_10961(symbol))
                        {

                            case Accessibility.Internal:
                            case Accessibility.ProtectedAndInternal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 10925, 11335);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 11119, 11194) || true) && (!f_10893_11124_11179(assembly, f_10893_11153_11178(symbol)))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 11119, 11194);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 11181, 11194);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 11119, 11194);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10893, 11220, 11226);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 10925, 11335);

                            case Accessibility.Private:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10893, 10925, 11335);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 11303, 11316);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10893, 10925, 11335);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10893, 1, 554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10893, 1, 554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10893, 11366, 11378);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10893, 10684, 11389);

                Microsoft.CodeAnalysis.SymbolKind
                f_10893_10822_10833(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 10822, 10833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10893_10868_10891(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 10868, 10891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10893_10933_10961(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 10933, 10961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10893_11153_11178(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 11153, 11178);
                    return return_v;
                }


                bool
                f_10893_11124_11179(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 11124, 11179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10893, 10684, 11389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 10684, 11389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmptyStructTypeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10893, 707, 11396);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10893, 707, 11396);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10893, 707, 11396);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10893, 707, 11396);

        int
        f_10893_2417_2481(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10893, 2417, 2481);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol?
        f_10893_2585_2612_M(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10893, 2585, 2612);
            return return_v;
        }

    }
}
