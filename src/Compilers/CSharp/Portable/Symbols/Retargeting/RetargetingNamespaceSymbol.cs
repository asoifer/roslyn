// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingNamespaceSymbol
            : NamespaceSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private readonly NamespaceSymbol _underlyingNamespace;

        public RetargetingNamespaceSymbol(RetargetingModuleSymbol retargetingModule, NamespaceSymbol underlyingNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10600, 1446, 1900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1211, 1229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1413, 1433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1584, 1632);

                f_10600_1584_1631((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1646, 1696);

                f_10600_1646_1695((object)underlyingNamespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1710, 1777);

                f_10600_1710_1776(!(underlyingNamespace is RetargetingNamespaceSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1793, 1832);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 1846, 1889);

                _underlyingNamespace = underlyingNamespace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10600, 1446, 1900);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 1446, 1900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 1446, 1900);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 2018, 2117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2054, 2102);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 2018, 2117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 1912, 2128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 1912, 2128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamespaceSymbol UnderlyingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 2207, 2286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2243, 2271);

                    return _underlyingNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 2207, 2286);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 2140, 2297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 2140, 2297);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamespaceExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 2374, 2472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2410, 2457);

                    return f_10600_2417_2456(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 2374, 2472);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10600_2417_2456(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    module)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 2417, 2456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 2309, 2483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 2309, 2483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 2495, 2640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2571, 2629);

                return f_10600_2578_2628(this, f_10600_2594_2627(_underlyingNamespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 2495, 2640);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_2594_2627(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 2594, 2627);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_2578_2628(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 2578, 2628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 2495, 2640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 2495, 2640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> RetargetMembers(ImmutableArray<Symbol> underlyingMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 2652, 3299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2765, 2838);

                var
                builder = f_10600_2779_2837(underlyingMembers.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2854, 3236);
                    foreach (Symbol s in f_10600_2875_2892_I(underlyingMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 2854, 3236);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 2984, 3149) || true) && (f_10600_2988_2994(s) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10600, 2988, 3079) && f_10600_3022_3079(((NamedTypeSymbol)s))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 2984, 3149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3121, 3130);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 2984, 3149);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3169, 3221);

                        f_10600_3169_3220(
                                        builder, f_10600_3181_3219(f_10600_3181_3207(this), s));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 2854, 3236);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10600, 1, 383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10600, 1, 383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3252, 3288);

                return f_10600_3259_3287(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 2652, 3299);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_2779_2837(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 2779, 2837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10600_2988_2994(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 2988, 2994);
                    return return_v;
                }


                bool
                f_10600_3022_3079(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 3022, 3079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10600_3181_3207(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 3181, 3207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10600_3181_3219(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.Retarget(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3181, 3219);
                    return return_v;
                }


                int
                f_10600_3169_3220(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3169, 3220);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_2875_2892_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 2875, 2892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_3259_3287(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3259, 3287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 2652, 3299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 2652, 3299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 3311, 3476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3398, 3465);

                return f_10600_3405_3464(this, f_10600_3421_3463(_underlyingNamespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 3311, 3476);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_3421_3463(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3421, 3463);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_3405_3464(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3405, 3464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 3311, 3476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 3311, 3476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 3488, 3648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3575, 3637);

                return f_10600_3582_3636(this, f_10600_3598_3635(_underlyingNamespace, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 3488, 3648);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_3598_3635(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3598, 3635);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10600_3582_3636(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3582, 3636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 3488, 3648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 3488, 3648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 3660, 3846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3760, 3835);

                return f_10600_3767_3834(this, f_10600_3787_3833(_underlyingNamespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 3660, 3846);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_3787_3833(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3787, 3833);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_3767_3834(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetTypeMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3767, 3834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 3660, 3846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 3660, 3846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 3858, 4024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 3947, 4013);

                return f_10600_3954_4012(this, f_10600_3974_4011(_underlyingNamespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 3858, 4024);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_3974_4011(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3974, 4011);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_3954_4012(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetTypeMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 3954, 4012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 3858, 4024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 3858, 4024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> RetargetTypeMembers(ImmutableArray<NamedTypeSymbol> underlyingMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 4036, 4806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4171, 4253);

                var
                builder = f_10600_4185_4252(underlyingMembers.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4269, 4743);
                    foreach (NamedTypeSymbol t in f_10600_4299_4316_I(underlyingMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 4269, 4743);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4408, 4520) || true) && (f_10600_4412_4450(t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 4408, 4520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4492, 4501);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 4408, 4520);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4540, 4612);

                        f_10600_4540_4611(f_10600_4553_4572(t) == Cci.PrimitiveTypeCode.NotPrimitive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4630, 4728);

                        f_10600_4630_4727(builder, f_10600_4642_4726(f_10600_4642_4668(this), t, RetargetOptions.RetargetPrimitiveTypesByName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 4269, 4743);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10600, 1, 475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10600, 1, 475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4759, 4795);

                return f_10600_4766_4794(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 4036, 4806);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_4185_4252(int
                capacity)
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4185, 4252);
                    return return_v;
                }


                bool
                f_10600_4412_4450(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 4412, 4450);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10600_4553_4572(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 4553, 4572);
                    return return_v;
                }


                int
                f_10600_4540_4611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4540, 4611);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10600_4642_4668(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 4642, 4668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10600_4642_4726(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4642, 4726);
                    return return_v;
                }


                int
                f_10600_4630_4727(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4630, 4727);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_4299_4316_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4299, 4316);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_4766_4794(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4766, 4794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 4036, 4806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 4036, 4806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 4818, 4999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 4918, 4988);

                return f_10600_4925_4987(this, f_10600_4945_4986(_underlyingNamespace, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 4818, 4999);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_4945_4986(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4945, 4986);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_4925_4987(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetTypeMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 4925, 4987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 4818, 4999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 4818, 4999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 5011, 5210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 5122, 5199);

                return f_10600_5129_5198(this, f_10600_5149_5197(_underlyingNamespace, name, arity));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 5011, 5210);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_5149_5197(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 5149, 5197);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10600_5129_5198(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                underlyingMembers)
                {
                    var return_v = this_param.RetargetTypeMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 5129, 5198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 5011, 5210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 5011, 5210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 5286, 5419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 5322, 5404);

                    return f_10600_5329_5403(f_10600_5329_5355(this), f_10600_5365_5402(_underlyingNamespace));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 5286, 5419);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10600_5329_5355(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 5329, 5355);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10600_5365_5402(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 5365, 5402);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10600_5329_5403(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 5329, 5403);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 5222, 5430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 5222, 5430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 5517, 5604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 5553, 5589);

                    return f_10600_5560_5588(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 5517, 5604);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10600_5560_5588(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 5560, 5588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 5442, 5615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 5442, 5615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 5725, 5830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 5761, 5815);

                    return f_10600_5768_5814(_underlyingNamespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 5725, 5830);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10600_5768_5814(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 5768, 5814);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 5627, 5841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 5627, 5841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 5927, 6023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 5963, 6008);

                    return f_10600_5970_6007(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 5927, 6023);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10600_5970_6007(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 5970, 6007);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 5853, 6034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 5853, 6034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 6118, 6195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 6154, 6180);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 6118, 6195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 6046, 6206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 6046, 6206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 6281, 6378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 6317, 6363);

                    return f_10600_6324_6362(_underlyingNamespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 6281, 6378);

                    bool
                    f_10600_6324_6362(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 6324, 6362);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 6218, 6389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 6218, 6389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 6453, 6537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 6489, 6522);

                    return f_10600_6496_6521(_underlyingNamespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 6453, 6537);

                    string
                    f_10600_6496_6521(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 6496, 6521);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 6401, 6548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 6401, 6548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 6560, 6885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 6766, 6874);

                return f_10600_6773_6873(_underlyingNamespace, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 6560, 6885);

                string
                f_10600_6773_6873(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 6773, 6873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 6560, 6885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 6560, 6885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol LookupMetadataType(ref MetadataTypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 6897, 7853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 7235, 7318);

                NamedTypeSymbol
                underlying = f_10600_7264_7317(_underlyingNamespace, ref typeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 7334, 7431);

                f_10600_7334_7430((object)f_10600_7355_7382(underlying) == (object)f_10600_7394_7429(_retargetingModule));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 7447, 7725) || true) && (!f_10600_7452_7476(underlying) && (DynAbs.Tracing.TraceSender.Expression_True(10600, 7451, 7527) && f_10600_7480_7527(underlying)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 7447, 7725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 7630, 7710);

                    return f_10600_7637_7709(_retargetingModule, ref typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 7447, 7725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 7741, 7842);

                return f_10600_7748_7841(f_10600_7748_7774(this), underlying, RetargetOptions.RetargetPrimitiveTypesByName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 6897, 7853);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10600_7264_7317(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 7264, 7317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10600_7355_7382(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 7355, 7382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                f_10600_7394_7429(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 7394, 7429);
                    return return_v;
                }


                int
                f_10600_7334_7430(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 7334, 7430);
                    return 0;
                }


                bool
                f_10600_7452_7476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 7452, 7476);
                    return return_v;
                }


                bool
                f_10600_7480_7527(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 7480, 7527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10600_7637_7709(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 7637, 7709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10600_7748_7774(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 7748, 7774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10600_7748_7841(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 7748, 7841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 6897, 7853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 6897, 7853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GetExtensionMethods(ArrayBuilder<MethodSymbol> methods, string nameOpt, int arity, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 7865, 8412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8018, 8083);

                var
                underlyingMethods = f_10600_8042_8082()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8097, 8182);

                f_10600_8097_8181(_underlyingNamespace, underlyingMethods, nameOpt, arity, options);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8196, 8362);
                    foreach (var underlyingMethod in f_10600_8229_8246_I(underlyingMethods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10600, 8196, 8362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8280, 8347);

                        f_10600_8280_8346(methods, f_10600_8292_8345(f_10600_8292_8318(this), underlyingMethod));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10600, 8196, 8362);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10600, 1, 167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10600, 1, 167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8376, 8401);

                f_10600_8376_8400(underlyingMethods);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 7865, 8412);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10600_8042_8082()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8042, 8082);
                    return return_v;
                }


                int
                f_10600_8097_8181(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.GetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8097, 8181);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10600_8292_8318(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10600, 8292, 8318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10600_8292_8345(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Retarget(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8292, 8345);
                    return return_v;
                }


                int
                f_10600_8280_8346(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8280, 8346);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10600_8229_8246_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8229, 8246);
                    return return_v;
                }


                int
                f_10600_8376_8400(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 8376, 8400);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 7865, 8412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 7865, 8412);
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10600, 8537, 8557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10600, 8543, 8555);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10600, 8537, 8557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10600, 8424, 8568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 8424, 8568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10600, 986, 8575);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10600, 986, 8575);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10600, 986, 8575);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10600, 986, 8575);

        int
        f_10600_1584_1631(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 1584, 1631);
            return 0;
        }


        int
        f_10600_1646_1695(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 1646, 1695);
            return 0;
        }


        int
        f_10600_1710_1776(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10600, 1710, 1776);
            return 0;
        }

    }
}
