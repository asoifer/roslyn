// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

#pragma warning disable CS0660

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class TypeSymbol : NamespaceOrTypeSymbol, ITypeSymbolInternal
    {
        internal const string
        ImplicitTypeName = "<invalid-global-code>"
        ;

        private static readonly InterfaceInfo s_noInterfaces;

        private ImmutableHashSet<Symbol> _lazyAbstractMembers;

        private InterfaceInfo _lazyInterfaceInfo;
        private class InterfaceInfo
        {
            internal ImmutableArray<NamedTypeSymbol> allInterfaces;

            internal MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> interfacesAndTheirBaseInterfaces;

            internal static readonly MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> EmptyInterfacesAndTheirBaseInterfaces;

            private ConcurrentDictionary<Symbol, SymbolAndDiagnostics> _implementationForInterfaceMemberMap;

            public ConcurrentDictionary<Symbol, SymbolAndDiagnostics> ImplementationForInterfaceMemberMap
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 2981, 3630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 3025, 3072);

                        var
                        map = _implementationForInterfaceMemberMap
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 3094, 3193) || true) && (map != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 3094, 3193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 3159, 3170);

                            return map;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 3094, 3193);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 3346, 3494);

                        map = f_10054_3352_3493(concurrencyLevel: 1, capacity: 1, comparer: SymbolEqualityComparer.ConsiderEverything);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 3516, 3611);

                        return f_10054_3523_3603(ref _implementationForInterfaceMemberMap, map, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>>(10054, 3523, 3610) ?? map);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 2981, 3630);

                        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                        f_10054_3352_3493(int
                        concurrencyLevel, int
                        capacity, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                        comparer)
                        {
                            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>(concurrencyLevel: concurrencyLevel, capacity: capacity, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 3352, 3493);
                            return return_v;
                        }


                        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                        f_10054_3523_3603(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                        location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                        value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 3523, 3603);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 2855, 3645);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 2855, 3645);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal MultiDictionary<Symbol, Symbol> explicitInterfaceImplementationMap;

            internal bool IsDefaultValue()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 4124, 4434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4187, 4419);

                    return allInterfaces.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10054, 4194, 4282) && interfacesAndTheirBaseInterfaces == null) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 4194, 4351) && _implementationForInterfaceMemberMap == null) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 4194, 4418) && explicitInterfaceImplementationMap == null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 4124, 4434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 4124, 4434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 4124, 4434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public InterfaceInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10054, 1772, 4445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 2225, 2257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 2802, 2838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4073, 4107);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10054, 1772, 4445);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 1772, 4445);
            }


            static InterfaceInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10054, 1772, 4445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 2349, 2531);
                EmptyInterfacesAndTheirBaseInterfaces = f_10054_2438_2531(0, SymbolEqualityComparer.CLRSignature); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10054, 1772, 4445);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 1772, 4445);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10054, 1772, 4445);

            static Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10054_2438_2531(int
            capacity, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
            comparer)
            {
                var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(capacity, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 2438, 2531);
                return return_v;
            }

        }

        private InterfaceInfo GetInterfaceInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 4457, 5815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4522, 4552);

                var
                info = _lazyInterfaceInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4566, 4753) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 4566, 4753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4616, 4708);

                    f_10054_4616_4707(info != s_noInterfaces || (DynAbs.Tracing.TraceSender.Expression_False(10054, 4629, 4676) || f_10054_4655_4676(info)), "default value was modified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4726, 4738);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 4566, 4753);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4778, 4793);

                    for (var
        baseType = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4769, 5630) || true) && (!f_10054_4796_4827(baseType, null))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4829, 4877)
        , baseType = f_10054_4840_4877(baseType), DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 4769, 5630))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 4769, 5630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 4911, 5092);

                        var
                        interfaces = (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 4928, 4973) || (((f_10054_4929_4946(baseType) == TypeKind.TypeParameter) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 4976, 5047)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 5050, 5091))) ? f_10054_4976_5047(((TypeParameterSymbol)baseType)) : f_10054_5050_5091(baseType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 5110, 5615) || true) && (f_10054_5114_5133_M(!interfaces.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 5110, 5615);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 5258, 5285);

                            info = f_10054_5265_5284();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 5517, 5596);

                            return f_10054_5524_5587(ref _lazyInterfaceInfo, info, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo>(10054, 5524, 5595) ?? info);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 5110, 5615);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 5735, 5778);

                _lazyInterfaceInfo = info = s_noInterfaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 5792, 5804);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 4457, 5815);

                bool
                f_10054_4655_4676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                this_param)
                {
                    var return_v = this_param.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 4655, 4676);
                    return return_v;
                }


                int
                f_10054_4616_4707(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 4616, 4707);
                    return 0;
                }


                bool
                f_10054_4796_4827(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 4796, 4827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_4840_4877(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 4840, 4877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10054_4929_4946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 4929, 4946);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_4976_5047(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.EffectiveInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 4976, 5047);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_5050_5091(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 5050, 5091);
                    return return_v;
                }


                bool
                f_10054_5114_5133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 5114, 5133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                f_10054_5265_5284()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 5265, 5284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                f_10054_5524_5587(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 5524, 5587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 4457, 5815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 4457, 5815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new TypeSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 6179, 6266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 6215, 6251);

                    return f_10054_6222_6250();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 6179, 6266);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10054_6222_6250()
                    {
                        var return_v = OriginalTypeSymbolDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 6222, 6250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 6114, 6277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 6114, 6277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual TypeSymbol OriginalTypeSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 6371, 6434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 6407, 6419);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 6371, 6434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 6289, 6445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 6289, 6445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override Symbol OriginalSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 6539, 6631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 6575, 6616);

                    return f_10054_6582_6615(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 6539, 6631);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10054_6582_6615(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalTypeSymbolDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 6582, 6615);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 6457, 6642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 6457, 6642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract NamedTypeSymbol BaseTypeNoUseSiteDiagnostics { get; }

        internal NamedTypeSymbol BaseTypeWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 7114, 7498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7252, 7294);

                var
                result = f_10054_7265_7293()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7310, 7457) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 7310, 7457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7370, 7442);

                    f_10054_7370_7441(f_10054_7370_7395(result), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 7310, 7457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7473, 7487);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 7114, 7498);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_7265_7293()
                {
                    var return_v = BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 7265, 7293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_7370_7395(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 7370, 7395);
                    return return_v;
                }


                int
                f_10054_7370_7441(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 7370, 7441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 7114, 7498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 7114, 7498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol BaseTypeOriginalDefinition(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 7510, 7914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7634, 7676);

                var
                result = f_10054_7647_7675()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7692, 7873) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 7692, 7873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7752, 7787);

                    result = f_10054_7761_7786(result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7805, 7858);

                    f_10054_7805_7857(result, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 7692, 7873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 7889, 7903);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 7510, 7914);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_7647_7675()
                {
                    var return_v = BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 7647, 7675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_7761_7786(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 7761, 7786);
                    return return_v;
                }


                int
                f_10054_7805_7857(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 7805, 7857);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 7510, 7914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 7510, 7914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved = null);

        internal ImmutableArray<NamedTypeSymbol> AllInterfacesNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 9213, 9290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9249, 9275);

                    return f_10054_9256_9274(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 9213, 9290);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10054_9256_9274(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAllInterfaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 9256, 9274);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 9114, 9301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 9114, 9301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<NamedTypeSymbol> AllInterfacesWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 9313, 10059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9472, 9519);

                var
                result = f_10054_9485_9518()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9640, 9659);

                var
                current = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 9675, 9854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9710, 9793);

                            current = f_10054_9720_9792(current, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 9675, 9854);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9675, 9854) || true) && ((object)current != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 9675, 9854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 9675, 9854);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9870, 10018);
                    foreach (var iface in f_10054_9892_9898_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 9870, 10018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 9932, 10003);

                        f_10054_9932_10002(f_10054_9932_9956(iface), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 9870, 10018);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 10034, 10048);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 9313, 10059);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_9485_9518()
                {
                    var return_v = AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 9485, 9518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_9720_9792(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 9720, 9792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_9932_9956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 9932, 9956);
                    return return_v;
                }


                int
                f_10054_9932_10002(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 9932, 10002);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_9892_9898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 9892, 9898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 9313, 10059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 9313, 10059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol EffectiveTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 10300, 10457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 10336, 10442);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 10343, 10365) || ((f_10054_10343_10365(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 10368, 10434)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 10437, 10441))) ? f_10054_10368_10434(((TypeParameterSymbol)this)) : this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 10300, 10457);

                    bool
                    f_10054_10343_10365(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsTypeParameter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 10343, 10365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10054_10368_10434(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.EffectiveBaseClassNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 10368, 10434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 10222, 10468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 10222, 10468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeSymbol EffectiveType(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 10480, 10707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 10586, 10696);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 10593, 10615) || ((f_10054_10593_10615(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 10618, 10688)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 10691, 10695))) ? f_10054_10618_10688(((TypeParameterSymbol)this), ref useSiteDiagnostics) : this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 10480, 10707);

                bool
                f_10054_10593_10615(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 10593, 10615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_10618_10688(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 10618, 10688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 10480, 10707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 10480, 10707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDerivedFrom(TypeSymbol type, TypeCompareKind comparison, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 10832, 11589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 10977, 11012);

                f_10054_10977_11011((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11026, 11064);

                f_10054_11026_11063(!f_10054_11040_11062(type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11080, 11174) || true) && ((object)this == (object)type)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 11080, 11174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11146, 11159);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 11080, 11174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11190, 11268);

                var
                t = f_10054_11198_11267(this, ref useSiteDiagnostics)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11282, 11549) || true) && ((object)t != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 11282, 11549);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11340, 11443) || true) && (f_10054_11344_11370(type, t, comparison))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 11340, 11443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11412, 11424);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 11340, 11443);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11463, 11534);

                        t = f_10054_11467_11533(t, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 11282, 11549);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 11282, 11549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 11282, 11549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11565, 11578);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 10832, 11589);

                int
                f_10054_10977_11011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 10977, 11011);
                    return 0;
                }


                bool
                f_10054_11040_11062(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11040, 11062);
                    return return_v;
                }


                int
                f_10054_11026_11063(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11026, 11063);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_11198_11267(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11198, 11267);
                    return return_v;
                }


                bool
                f_10054_11344_11370(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11344, 11370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_11467_11533(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11467, 11533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 10832, 11589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 10832, 11589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsEqualToOrDerivedFrom(TypeSymbol type, TypeCompareKind comparison, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 11726, 11992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 11880, 11981);

                return f_10054_11887_11916(this, type, comparison) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 11887, 11980) || f_10054_11920_11980(this, type, comparison, ref useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 11726, 11992);

                bool
                f_10054_11887_11916(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11887, 11916);
                    return return_v;
                }


                bool
                f_10054_11920_11980(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom(type, comparison, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 11920, 11980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 11726, 11992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 11726, 11992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool Equals(TypeSymbol t2, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 12549, 12690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 12646, 12679);

                return f_10054_12653_12678(this, t2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 12549, 12690);

                bool
                f_10054_12653_12678(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 12653, 12678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 12549, 12690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 12549, 12690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 12702, 12984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 12804, 12833);

                var
                t2 = other as TypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 12847, 12923) || true) && (t2 is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 12847, 12923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 12895, 12908);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 12847, 12923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 12937, 12973);

                return f_10054_12944_12972(this, t2, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 12702, 12984);

                bool
                f_10054_12944_12972(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 12944, 12972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 12702, 12984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 12702, 12984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 13200, 13309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13258, 13298);

                return f_10054_13265_13297(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 13200, 13309);

                int
                f_10054_13265_13297(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 13265, 13297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 13200, 13309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 13200, 13309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual ImmutableArray<NamedTypeSymbol> GetAllInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 13321, 13821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13414, 13449);

                var
                info = f_10054_13425_13448(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13463, 13583) || true) && (info == s_noInterfaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 13463, 13583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13523, 13568);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 13463, 13583);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13599, 13768) || true) && (info.allInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 13599, 13768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13665, 13753);

                    f_10054_13665_13752(ref info.allInterfaces, f_10054_13732_13751(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 13599, 13768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 13784, 13810);

                return info.allInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 13321, 13821);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                f_10054_13425_13448(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfaceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 13425, 13448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_13732_13751(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeAllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 13732, 13751);
                    return return_v;
                }


                bool
                f_10054_13665_13752(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 13665, 13752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 13321, 13821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 13321, 13821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual ImmutableArray<NamedTypeSymbol> MakeAllInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 14185, 15745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14279, 14336);

                var
                result = f_10054_14292_14335()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14350, 14436);

                var
                visited = f_10054_14364_14435(SymbolEqualityComparer.ConsiderEverything)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14461, 14476);

                    for (var
        baseType = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14452, 14965) || true) && (!f_10054_14479_14510(baseType, null))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14512, 14560)
        , baseType = f_10054_14523_14560(baseType), DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 14452, 14965))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 14452, 14965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14594, 14775);

                        var
                        interfaces = (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 14611, 14656) || (((f_10054_14612_14629(baseType) == TypeKind.TypeParameter) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 14659, 14730)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 14733, 14774))) ? f_10054_14659_14730(((TypeParameterSymbol)baseType)) : f_10054_14733_14774(baseType)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14802, 14827);
                            for (int
            i = interfaces.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14793, 14950) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14837, 14840)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 14793, 14950))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 14793, 14950);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14882, 14931);

                                f_10054_14882_14930(interfaces[i], visited, result);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 158);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 158);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 14981, 15006);

                f_10054_14981_15005(
                            result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15020, 15055);

                return f_10054_15027_15054(result);

                static void addAllInterfaces(NamedTypeSymbol @interface, HashSet<NamedTypeSymbol> visited, ArrayBuilder<NamedTypeSymbol> result)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 15071, 15734);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15232, 15719) || true) && (f_10054_15236_15259(visited, @interface))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 15232, 15719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15301, 15394);

                            ImmutableArray<NamedTypeSymbol>
                            baseInterfaces = f_10054_15350_15393(@interface)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15425, 15454);
                                for (int
            i = baseInterfaces.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15416, 15653) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15464, 15467)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 15416, 15653))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 15416, 15653);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15517, 15555);

                                    var
                                    baseInterface = baseInterfaces[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15581, 15630);

                                    f_10054_15581_15629(baseInterface, visited, result);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 238);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 238);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 15677, 15700);

                            f_10054_15677_15699(
                                                result, @interface);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 15232, 15719);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 15071, 15734);

                        bool
                        f_10054_15236_15259(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 15236, 15259);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10054_15350_15393(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 15350, 15393);
                            return return_v;
                        }


                        int
                        f_10054_15581_15629(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        @interface, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        visited, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        result)
                        {
                            addAllInterfaces(@interface, visited, result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 15581, 15629);
                            return 0;
                        }


                        int
                        f_10054_15677_15699(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 15677, 15699);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 15071, 15734);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 15071, 15734);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 14185, 15745);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_14292_14335()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14292, 14335);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_14364_14435(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14364, 14435);
                    return return_v;
                }


                bool
                f_10054_14479_14510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14479, 14510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_14523_14560(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 14523, 14560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10054_14612_14629(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 14612, 14629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_14659_14730(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.EffectiveInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 14659, 14730);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_14733_14774(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14733, 14774);
                    return return_v;
                }


                int
                f_10054_14882_14930(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                visited, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result)
                {
                    addAllInterfaces(@interface, visited, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14882, 14930);
                    return 0;
                }


                int
                f_10054_14981_15005(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 14981, 15005);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_15027_15054(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 15027, 15054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 14185, 15745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 14185, 15745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 16560, 17255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 16596, 16631);

                    var
                    info = f_10054_16607_16630(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 16649, 16891) || true) && (info == s_noInterfaces)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 16649, 16891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 16717, 16791);

                        f_10054_16717_16790(f_10054_16730_16789(InterfaceInfo.EmptyInterfacesAndTheirBaseInterfaces));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 16813, 16872);

                        return InterfaceInfo.EmptyInterfacesAndTheirBaseInterfaces;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 16649, 16891);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 16911, 17175) || true) && (info.interfacesAndTheirBaseInterfaces == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 16911, 17175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17002, 17156);

                        f_10054_17002_17155(ref info.interfacesAndTheirBaseInterfaces, f_10054_17073_17148(f_10054_17110_17147(this)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 16911, 17175);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17195, 17240);

                    return info.interfacesAndTheirBaseInterfaces;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 16560, 17255);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                    f_10054_16607_16630(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetInterfaceInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 16607, 16630);
                        return return_v;
                    }


                    bool
                    f_10054_16730_16789(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.IsEmpty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 16730, 16789);
                        return return_v;
                    }


                    int
                    f_10054_16717_16790(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 16717, 16790);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10054_17110_17147(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 17110, 17147);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10054_17073_17148(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    declaredInterfaces)
                    {
                        var return_v = MakeInterfacesAndTheirBaseInterfaces(declaredInterfaces);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 17073, 17148);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                    f_10054_17002_17155(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                    location1, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    value, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 17002, 17155);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 16424, 17266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 16424, 17266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> InterfacesAndTheirBaseInterfacesWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 17278, 17750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17474, 17540);

                var
                result = f_10054_17487_17539()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17556, 17709);
                    foreach (var iface in f_10054_17578_17589_I(f_10054_17578_17589(result)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 17556, 17709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17623, 17694);

                        f_10054_17623_17693(f_10054_17623_17647(iface), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 17556, 17709);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 17725, 17739);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 17278, 17750);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_17487_17539()
                {
                    var return_v = InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 17487, 17539);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10054_17578_17589(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 17578, 17589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_17623_17647(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 17623, 17647);
                    return return_v;
                }


                int
                f_10054_17623_17693(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 17623, 17693);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10054_17578_17589_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 17578, 17589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 17278, 17750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 17278, 17750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> MakeInterfacesAndTheirBaseInterfaces(ImmutableArray<NamedTypeSymbol> declaredInterfaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 17979, 18795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18157, 18338);

                var
                resultBuilder = f_10054_18177_18337(declaredInterfaces.Length, SymbolEqualityComparer.CLRSignature, SymbolEqualityComparer.ConsiderEverything)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18352, 18747);
                    foreach (var @interface in f_10054_18379_18397_I(declaredInterfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 18352, 18747);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18431, 18732) || true) && (f_10054_18435_18476(resultBuilder, @interface, @interface))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 18431, 18732);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18518, 18713);
                                foreach (var baseInterface in f_10054_18548_18592_I(f_10054_18548_18592(@interface)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 18518, 18713);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18642, 18690);

                                    f_10054_18642_18689(resultBuilder, baseInterface, baseInterface);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 18518, 18713);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 196);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 196);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 18431, 18732);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 18352, 18747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 18763, 18784);

                return resultBuilder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 17979, 18795);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_18177_18337(int
                capacity, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                valueComparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(capacity, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)valueComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 18177, 18337);
                    return return_v;
                }


                bool
                f_10054_18435_18476(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                k, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 18435, 18476);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_18548_18592(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 18548, 18592);
                    return return_v;
                }


                bool
                f_10054_18642_18689(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                k, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 18642, 18689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_18548_18592_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 18548, 18592);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_18379_18397_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 18379, 18397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 17979, 18795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 17979, 18795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Symbol FindImplementationForInterfaceMember(Symbol interfaceMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 19394, 20127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19493, 19634) || true) && ((object)interfaceMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 19493, 19634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19562, 19619);

                    throw f_10054_19568_19618(nameof(interfaceMember));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 19493, 19634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19650, 19764) || true) && (!f_10054_19655_19703(interfaceMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 19650, 19764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19737, 19749);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 19650, 19764);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19780, 20025) || true) && (f_10054_19784_19806(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 19780, 20025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19840, 19890);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 19908, 20010);

                    return f_10054_19915_20009(interfaceMember, this, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 19780, 20025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 20041, 20116);

                return f_10054_20048_20115(this, interfaceMember);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 19394, 20127);

                System.ArgumentNullException
                f_10054_19568_19618(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 19568, 19618);
                    return return_v;
                }


                bool
                f_10054_19655_19703(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsImplementableInterfaceMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 19655, 19703);
                    return return_v;
                }


                bool
                f_10054_19784_19806(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 19784, 19806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_19915_20009(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingInterface, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = FindMostSpecificImplementation(interfaceMember, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)implementingInterface, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 19915, 20009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_20048_20115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterface(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 20048, 20115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 19394, 20127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 19394, 20127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract bool IsReferenceType { get; }

        public abstract bool IsValueType { get; }

        internal TypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10054, 20945, 20988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 1688, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 1741, 1759);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10054, 20945, 20988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 20945, 20988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 20945, 20988);
            }
        }

        public abstract TypeKind TypeKind { get; }

        public virtual SpecialType SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 21423, 21498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 21459, 21483);

                    return SpecialType.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 21423, 21498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 21360, 21509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 21360, 21509);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Microsoft.Cci.PrimitiveTypeCode PrimitiveTypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 21719, 21999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 21722, 21999);
                    return f_10054_21722_21730() switch
                    {
                        TypeKind.Pointer when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 21770, 21829) && DynAbs.Tracing.TraceSender.Expression_True(10054, 21770, 21829))
        => Microsoft.Cci.PrimitiveTypeCode.Pointer,
                        TypeKind.FunctionPointer when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 21848, 21923) && DynAbs.Tracing.TraceSender.Expression_True(10054, 21848, 21923))
        => Microsoft.Cci.PrimitiveTypeCode.FunctionPointer,
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 21942, 21984) && DynAbs.Tracing.TraceSender.Expression_True(10054, 21942, 21984))
        => f_10054_21947_21984(f_10054_21972_21983())
                    }; DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 21719, 21999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 21719, 21999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 21719, 21999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 22282, 22369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 22318, 22354);

                    return (int)ErrorCode.ERR_BogusType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 22282, 22369);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 22207, 22380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 22207, 22380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 22469, 22656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 22505, 22550);

                    DiagnosticInfo
                    info = f_10054_22527_22549(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 22568, 22641);

                    return (object)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 22575, 22640) && f_10054_22599_22608(info) == (int)ErrorCode.ERR_BogusType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 22469, 22656);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10054_22527_22549(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 22527, 22549);
                        return return_v;
                    }


                    int
                    f_10054_22599_22608(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 22599, 22608);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 22394, 22667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 22394, 22667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes);

        public virtual bool IsAnonymousType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 23037, 23101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23073, 23086);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 23037, 23101);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 22977, 23112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 22977, 23112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsTupleType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 23246, 23254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23249, 23254);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 23246, 23254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 23246, 23254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 23246, 23254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsNativeIntegerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 23498, 23506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23501, 23506);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 23498, 23506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 23498, 23506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 23498, 23506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsTupleTypeOfCardinality(int targetCardinality)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 23718, 23974);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23802, 23934) || true) && (f_10054_23806_23817())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 23802, 23934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23851, 23919);

                    return f_10054_23858_23890().Length == targetCardinality;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 23802, 23934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 23950, 23963);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 23718, 23974);

                bool
                f_10054_23806_23817()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 23806, 23817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10054_23858_23890()
                {
                    var return_v = TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 23858, 23890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 23718, 23974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 23718, 23974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ImmutableArray<TypeWithAnnotations> TupleElementTypesWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 24209, 24256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 24212, 24256);
                    return default(ImmutableArray<TypeWithAnnotations>); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 24209, 24256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 24209, 24256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 24209, 24256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ImmutableArray<string> TupleElementNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 24464, 24498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 24467, 24498);
                    return default(ImmutableArray<string>); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 24464, 24498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 24464, 24498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 24464, 24498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ImmutableArray<FieldSymbol> TupleElements
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 24750, 24789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 24753, 24789);
                    return default(ImmutableArray<FieldSymbol>); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 24750, 24789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 24750, 24789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 24750, 24789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsManagedType(ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 25153, 25217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 25156, 25217);
                return f_10054_25156_25194(this, ref useSiteDiagnostics) == ManagedKind.Managed; DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 25153, 25217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 25153, 25217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 25153, 25217);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ManagedKind
            f_10054_25156_25194(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
            useSiteDiagnostics)
            {
                var return_v = this_param.GetManagedKind(ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 25156, 25194);
                return return_v;
            }

        }

        internal bool IsManagedTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 25302, 25467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 25338, 25389);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 25407, 25452);

                    return f_10054_25414_25451(this, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 25302, 25467);

                    bool
                    f_10054_25414_25451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.IsManagedType(ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 25414, 25451);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 25230, 25478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 25230, 25478);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo>? useSiteDiagnostics);

        internal ManagedKind ManagedKindNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 25903, 26069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 25939, 25990);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 26008, 26054);

                    return f_10054_26015_26053(this, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 25903, 26069);

                    Microsoft.CodeAnalysis.ManagedKind
                    f_10054_26015_26053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.GetManagedKind(ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 26015, 26053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 25826, 26080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 25826, 26080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool NeedsNullableAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 26111, 26283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 26174, 26272);

                return TypeWithAnnotations.NeedsNullableAttribute(typeWithAnnotationsOpt: default, typeOpt: this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 26111, 26283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 26111, 26283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 26111, 26283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void AddNullableTransforms(ArrayBuilder<byte> transforms);

        internal abstract bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result);

        internal abstract TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform);

        internal TypeSymbol SetUnknownNullabilityForReferenceTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 26674, 26834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 26759, 26823);

                return f_10054_26766_26822(this, s_setUnknownNullability);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 26674, 26834);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10054_26766_26822(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                transform)
                {
                    var return_v = this_param.SetNullabilityForReferenceTypes(transform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 26766, 26822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 26674, 26834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 26674, 26834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeWithAnnotations, TypeWithAnnotations> s_setUnknownNullability;

        internal abstract TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance);

        public abstract bool IsRefLikeType { get; }

        public abstract bool IsReadOnly { get; }

        public string ToDisplayString(CodeAnalysis.NullableFlowState topLevelNullability, SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 27812, 28052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 27953, 28041);

                return f_10054_27960_28040(f_10054_28003_28010(), topLevelNullability, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 27812, 28052);

                Microsoft.CodeAnalysis.ISymbol
                f_10054_28003_28010()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 28003, 28010);
                    return return_v;
                }


                string
                f_10054_27960_28040(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 27960, 28040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 27812, 28052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 27812, 28052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SymbolDisplayPart> ToDisplayParts(CodeAnalysis.NullableFlowState topLevelNullability, SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 28064, 28329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 28231, 28318);

                return f_10054_28238_28317(f_10054_28280_28287(), topLevelNullability, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 28064, 28329);

                Microsoft.CodeAnalysis.ISymbol
                f_10054_28280_28287()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 28280, 28287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10054_28238_28317(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayParts((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 28238, 28317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 28064, 28329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 28064, 28329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToMinimalDisplayString(
                    SemanticModel semanticModel,
                    CodeAnalysis.NullableFlowState topLevelNullability,
                    int position,
                    SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 28341, 28716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 28585, 28705);

                return f_10054_28592_28704(f_10054_28642_28649(), topLevelNullability, semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 28341, 28716);

                Microsoft.CodeAnalysis.ISymbol
                f_10054_28642_28649()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 28642, 28649);
                    return return_v;
                }


                string
                f_10054_28592_28704(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayString((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 28592, 28704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 28341, 28716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 28341, 28716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    SemanticModel semanticModel,
                    CodeAnalysis.NullableFlowState topLevelNullability,
                    int position,
                    SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 28728, 29128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 28998, 29117);

                return f_10054_29005_29116(f_10054_29054_29061(), topLevelNullability, semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 28728, 29128);

                Microsoft.CodeAnalysis.ISymbol
                f_10054_29054_29061()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 29054, 29061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10054_29005_29116(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayParts((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 29005, 29116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 28728, 29128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 28728, 29128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SymbolAndDiagnostics FindImplementationForInterfaceMemberInNonInterfaceWithDiagnostics(Symbol interfaceMember, bool ignoreImplementationInInterfacesIfResultIsNotReady = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 32171, 34507);
                bool implementationInInterfacesMightChangeResult = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32381, 32427);

                f_10054_32381_32426((object)interfaceMember != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32441, 32479);

                f_10054_32441_32478(!f_10054_32455_32477(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32495, 32604) || true) && (f_10054_32499_32521(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 32495, 32604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32555, 32589);

                    return SymbolAndDiagnostics.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 32495, 32604);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32620, 32671);

                var
                interfaceType = f_10054_32640_32670(interfaceMember)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32685, 32831) || true) && ((object)interfaceType == null || (DynAbs.Tracing.TraceSender.Expression_False(10054, 32689, 32748) || f_10054_32722_32748_M(!interfaceType.IsInterface)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 32685, 32831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32782, 32816);

                    return SymbolAndDiagnostics.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 32685, 32831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 32847, 34496);

                switch (f_10054_32855_32875(interfaceMember))
                {

                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 32847, 34496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33037, 33072);

                        var
                        info = f_10054_33048_33071(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33094, 33227) || true) && (info == s_noInterfaces)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 33094, 33227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33170, 33204);

                            return SymbolAndDiagnostics.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 33094, 33227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33353, 33404);

                        var
                        map = f_10054_33363_33403(info)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33426, 33454);

                        SymbolAndDiagnostics
                        result
                        = default(SymbolAndDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33476, 33611) || true) && (f_10054_33480_33524(map, interfaceMember, out result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 33476, 33611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33574, 33588);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 33476, 33611);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33635, 33939);

                        result = f_10054_33644_33938(this, interfaceMember, ignoreImplementationInInterfaces: ignoreImplementationInInterfacesIfResultIsNotReady, out implementationInInterfacesMightChangeResult);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 33963, 34076);

                        f_10054_33963_34075(ignoreImplementationInInterfacesIfResultIsNotReady || (DynAbs.Tracing.TraceSender.Expression_False(10054, 33976, 34074) || !implementationInInterfacesMightChangeResult));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34098, 34182);

                        f_10054_34098_34181(!implementationInInterfacesMightChangeResult || (DynAbs.Tracing.TraceSender.Expression_False(10054, 34111, 34180) || result.Symbol is null));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34204, 34361) || true) && (!implementationInInterfacesMightChangeResult)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 34204, 34361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34302, 34338);

                            f_10054_34302_34337(map, interfaceMember, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 34204, 34361);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34383, 34397);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 32847, 34496);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 32847, 34496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34447, 34481);

                        return SymbolAndDiagnostics.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 32847, 34496);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 32171, 34507);

                int
                f_10054_32381_32426(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 32381, 32426);
                    return 0;
                }


                bool
                f_10054_32455_32477(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 32455, 32477);
                    return return_v;
                }


                int
                f_10054_32441_32478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 32441, 32478);
                    return 0;
                }


                bool
                f_10054_32499_32521(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 32499, 32521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_32640_32670(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 32640, 32670);
                    return return_v;
                }


                bool
                f_10054_32722_32748_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 32722, 32748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_32855_32875(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 32855, 32875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                f_10054_33048_33071(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfaceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 33048, 33071);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                f_10054_33363_33403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                this_param)
                {
                    var return_v = this_param.ImplementationForInterfaceMemberMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 33363, 33403);
                    return return_v;
                }


                bool
                f_10054_33480_33524(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 33480, 33524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10054_33644_33938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                ignoreImplementationInInterfaces, out bool
                implementationInInterfacesMightChangeResult)
                {
                    var return_v = this_param.ComputeImplementationAndDiagnosticsForInterfaceMember(interfaceMember, ignoreImplementationInInterfaces: ignoreImplementationInInterfaces, out implementationInInterfacesMightChangeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 33644, 33938);
                    return return_v;
                }


                int
                f_10054_33963_34075(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 33963, 34075);
                    return 0;
                }


                int
                f_10054_34098_34181(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 34098, 34181);
                    return 0;
                }


                bool
                f_10054_34302_34337(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 34302, 34337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 32171, 34507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 32171, 34507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Symbol FindImplementationForInterfaceMemberInNonInterface(Symbol interfaceMember, bool ignoreImplementationInInterfacesIfResultIsNotReady = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 34519, 34859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 34699, 34848);

                return f_10054_34706_34840(this, interfaceMember, ignoreImplementationInInterfacesIfResultIsNotReady).Symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 34519, 34859);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10054_34706_34840(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                ignoreImplementationInInterfacesIfResultIsNotReady)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterfaceWithDiagnostics(interfaceMember, ignoreImplementationInInterfacesIfResultIsNotReady);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 34706, 34840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 34519, 34859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 34519, 34859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SymbolAndDiagnostics ComputeImplementationAndDiagnosticsForInterfaceMember(Symbol interfaceMember, bool ignoreImplementationInInterfaces, out bool implementationInInterfacesMightChangeResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 34871, 35535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 35095, 35141);

                var
                diagnostics = f_10054_35113_35140()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 35155, 35339);

                var
                implementingMember = f_10054_35180_35338(interfaceMember, this, diagnostics, ignoreImplementationInInterfaces, out implementationInInterfacesMightChangeResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 35353, 35470);

                var
                implementingMemberAndDiagnostics = f_10054_35392_35469(implementingMember, f_10054_35437_35468(diagnostics))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 35484, 35524);

                return implementingMemberAndDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 34871, 35535);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10054_35113_35140()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 35113, 35140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_35180_35338(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                ignoreImplementationInInterfaces, out bool
                implementationInInterfacesMightChangeResult)
                {
                    var return_v = ComputeImplementationForInterfaceMember(interfaceMember, implementingType, diagnostics, ignoreImplementationInInterfaces, out implementationInInterfacesMightChangeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 35180, 35338);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10054_35437_35468(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 35437, 35468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10054_35392_35469(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics(symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 35392, 35469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 34871, 35535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 34871, 35535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol ComputeImplementationForInterfaceMember(Symbol interfaceMember, TypeSymbol implementingType, DiagnosticBag diagnostics,
                                                                              bool ignoreImplementationInInterfaces, out bool implementationInInterfacesMightChangeResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 37112, 48071);
                Microsoft.CodeAnalysis.CSharp.Symbol currTypeExplicitImpl = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37442, 37492);

                f_10054_37442_37491(!f_10054_37456_37490(implementingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37506, 37653);

                f_10054_37506_37652(f_10054_37519_37539(interfaceMember) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10054, 37519, 37607) || f_10054_37564_37584(interfaceMember) == SymbolKind.Property) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 37519, 37651) || f_10054_37611_37631(interfaceMember) == SymbolKind.Event));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37667, 37730);

                f_10054_37667_37729(f_10054_37680_37728(interfaceMember));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37746, 37809);

                NamedTypeSymbol
                interfaceType = f_10054_37778_37808(interfaceMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37823, 37896);

                f_10054_37823_37895((object)interfaceType != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 37836, 37894) && f_10054_37869_37894(interfaceType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 37912, 37952);

                bool
                seenTypeDeclaringInterface = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39267, 39361);

                bool
                implementingTypeIsFromSomeCompilation = f_10054_39312_39360(implementingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39377, 39404);

                Symbol
                implicitImpl = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39418, 39448);

                Symbol
                closestMismatch = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39462, 39632);

                bool
                canBeImplementedImplicitly = f_10054_39496_39533(interfaceMember) == Accessibility.Public && (DynAbs.Tracing.TraceSender.Expression_True(10054, 39496, 39631) && !f_10054_39562_39631(interfaceMember))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39646, 39684);

                TypeSymbol
                implementingBaseOpt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39756, 39805);

                bool
                implementingTypeImplementsInterface = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39819, 39869);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39901, 39928);

                    for (TypeSymbol
        currType = implementingType
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39885, 43987) || true) && ((object)currType != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 39956, 40040)
        , currType = f_10054_39967_40040(currType, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 39885, 43987))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 39885, 43987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40552, 40678);

                        MultiDictionary<Symbol, Symbol>.ValueSet
                        explicitImpl = f_10054_40608_40677(currType, interfaceMember)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40696, 41360) || true) && (explicitImpl.Count == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 40696, 41360);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40765, 40817);

                            implementationInInterfacesMightChangeResult = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40839, 40868);

                            return explicitImpl.Single();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 40696, 41360);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 40696, 41360);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40910, 41360) || true) && (explicitImpl.Count > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 40910, 41360);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 40978, 41231) || true) && ((object)currType == implementingType || (DynAbs.Tracing.TraceSender.Expression_False(10054, 40982, 41057) || implementingTypeImplementsInterface))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 40978, 41231);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41107, 41208);

                                    f_10054_41107_41207(diagnostics, ErrorCode.ERR_DuplicateExplicitImpl, f_10054_41160_41186(implementingType)[0], interfaceMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 40978, 41231);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41255, 41307);

                                implementationInInterfacesMightChangeResult = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41329, 41341);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 40910, 41360);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 40696, 41360);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41380, 41966) || true) && (f_10054_41384_41479(interfaceMember, currType, out currTypeExplicitImpl))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 41380, 41966);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41802, 41854);

                            implementationInInterfacesMightChangeResult = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41919, 41947);

                            return currTypeExplicitImpl;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 41380, 41966);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 41986, 42819) || true) && (!seenTypeDeclaringInterface || (DynAbs.Tracing.TraceSender.Expression_False(10054, 41990, 42110) || (!canBeImplementedImplicitly && (DynAbs.Tracing.TraceSender.Expression_True(10054, 42043, 42109) && (object)implementingBaseOpt == null))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 41986, 42819);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42152, 42800) || true) && (f_10054_42156_42280(f_10054_42156_42253(currType, ref useSiteDiagnostics), interfaceType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 42152, 42800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42330, 42364);

                                seenTypeDeclaringInterface = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42392, 42777) || true) && ((object)currType == implementingType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 42392, 42777);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42490, 42533);

                                    implementingTypeImplementsInterface = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 42392, 42777);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 42392, 42777);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42591, 42777) || true) && (!canBeImplementedImplicitly && (DynAbs.Tracing.TraceSender.Expression_True(10054, 42595, 42661) && (object)implementingBaseOpt == null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 42591, 42777);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 42719, 42750);

                                        implementingBaseOpt = currType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 42591, 42777);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 42392, 42777);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 42152, 42800);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 41986, 42819);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43026, 43972) || true) && (seenTypeDeclaringInterface)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 43026, 43972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43172, 43200);

                            Symbol
                            currTypeImplicitImpl
                            = default(Symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43222, 43251);

                            Symbol
                            currTypeCloseMismatch
                            = default(Symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43275, 43576);

                            f_10054_43275_43575(interfaceMember, implementingTypeIsFromSomeCompilation, currType, out currTypeImplicitImpl, out currTypeCloseMismatch);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43600, 43781) || true) && ((object)currTypeImplicitImpl != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 43600, 43781);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43690, 43726);

                                implicitImpl = currTypeImplicitImpl;
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 43752, 43758);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 43600, 43781);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43805, 43953) || true) && ((object)closestMismatch == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 43805, 43953);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 43890, 43930);

                                closestMismatch = currTypeCloseMismatch;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 43805, 43953);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 43026, 43972);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 4103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 4103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44003, 44084);

                f_10054_44003_44083(!canBeImplementedImplicitly || (DynAbs.Tracing.TraceSender.Expression_False(10054, 44016, 44082) || (object)implementingBaseOpt == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44100, 44146);

                bool
                tryDefaultInterfaceImplementation = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44408, 45063) || true) && (f_10054_44412_44440(interfaceMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 44408, 45063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44474, 44517);

                    Symbol
                    originalImplicitImpl = implicitImpl
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44535, 44694);

                    f_10054_44535_44693(interfaceMember, implementingType, implementingTypeIsFromSomeCompilation, ref implicitImpl);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44887, 45048) || true) && (originalImplicitImpl is object && (DynAbs.Tracing.TraceSender.Expression_True(10054, 44891, 44945) && implicitImpl is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 44887, 45048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 44987, 45029);

                        tryDefaultInterfaceImplementation = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 44887, 45048);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 44408, 45063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45079, 45105);

                Symbol
                defaultImpl = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45121, 45888) || true) && ((object)implicitImpl == null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 45125, 45183) && seenTypeDeclaringInterface) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 45125, 45220) && tryDefaultInterfaceImplementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 45121, 45888);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45254, 45755) || true) && (ignoreImplementationInInterfaces)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 45254, 45755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45332, 45383);

                        implementationInInterfacesMightChangeResult = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 45254, 45755);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 45254, 45755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45533, 45662);

                        defaultImpl = f_10054_45547_45661(interfaceMember, implementingType, ref useSiteDiagnostics, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45684, 45736);

                        implementationInInterfacesMightChangeResult = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 45254, 45755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 45121, 45888);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 45121, 45888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 45821, 45873);

                    implementationInInterfacesMightChangeResult = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 45121, 45888);
                }

                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46127, 46220);

                    f_10054_46127_46219(diagnostics, f_10054_46143_46198(interfaceMember, implementingType), useSiteDiagnostics);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46251, 46578) || true) && (defaultImpl is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46251, 46578);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46310, 46524) || true) && (implementingTypeImplementsInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46310, 46524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46391, 46505);

                        f_10054_46391_46504(interfaceMember, implementingType, defaultImpl, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46310, 46524);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46544, 46563);

                    return defaultImpl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46251, 46578);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46594, 48024) || true) && (implementingTypeImplementsInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46594, 48024);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46667, 48009) || true) && ((object)implicitImpl != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46667, 48009);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46741, 47553) || true) && (!canBeImplementedImplicitly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46741, 47553);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 46822, 47325) || true) && (f_10054_46826_46846(interfaceMember) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10054, 46826, 46935) && (object)implementingBaseOpt == null))
                            ) // Otherwise any approprite errors are going to be reported for the base.

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46822, 47325);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47067, 47298);

                                f_10054_47067_47297(diagnostics, ErrorCode.ERR_ImplicitImplementationOfNonPublicInterfaceMember, f_10054_47147_47202(interfaceMember, implementingType), implementingType, interfaceMember, implicitImpl);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46822, 47325);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46741, 47553);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46741, 47553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47423, 47530);

                            f_10054_47423_47529(interfaceMember, implementingType, implicitImpl, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46741, 47553);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46667, 48009);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 46667, 48009);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47595, 48009) || true) && ((object)closestMismatch != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 47595, 48009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47672, 47748);

                            f_10054_47672_47747(f_10054_47685_47722(interfaceMember) == Accessibility.Public);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47770, 47855);

                            f_10054_47770_47854(!f_10054_47784_47853(interfaceMember));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 47877, 47990);

                            f_10054_47877_47989(interfaceMember, implementingType, closestMismatch, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 47595, 48009);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46667, 48009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 46594, 48024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 48040, 48060);

                return implicitImpl;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 37112, 48071);

                bool
                f_10054_37456_37490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37456, 37490);
                    return return_v;
                }


                int
                f_10054_37442_37491(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37442, 37491);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_37519_37539(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 37519, 37539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_37564_37584(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 37564, 37584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_37611_37631(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 37611, 37631);
                    return return_v;
                }


                int
                f_10054_37506_37652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37506, 37652);
                    return 0;
                }


                bool
                f_10054_37680_37728(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsImplementableInterfaceMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37680, 37728);
                    return return_v;
                }


                int
                f_10054_37667_37729(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37667, 37729);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_37778_37808(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 37778, 37808);
                    return return_v;
                }


                bool
                f_10054_37869_37894(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 37869, 37894);
                    return return_v;
                }


                int
                f_10054_37823_37895(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 37823, 37895);
                    return 0;
                }


                bool
                f_10054_39312_39360(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Dangerous_IsFromSomeCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 39312, 39360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10054_39496_39533(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 39496, 39533);
                    return return_v;
                }


                bool
                f_10054_39562_39631(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsEventOrPropertyWithImplementableNonPublicAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 39562, 39631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_39967_40040(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 39967, 40040);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_40608_40677(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.GetExplicitImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 40608, 40677);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10054_41160_41186(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 41160, 41186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_41107_41207(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 41107, 41207);
                    return return_v;
                }


                bool
                f_10054_41384_41479(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                implementingMember)
                {
                    var return_v = IsExplicitlyImplementedViaAccessors(interfaceMember, currType, out implementingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 41384, 41479);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_42156_42253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 42156, 42253);
                    return return_v;
                }


                bool
                f_10054_42156_42280(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                k)
                {
                    var return_v = this_param.ContainsKey(k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 42156, 42280);
                    return return_v;
                }


                int
                f_10054_43275_43575(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                implementingTypeIsFromSomeCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                implicitImpl, out Microsoft.CodeAnalysis.CSharp.Symbol
                closeMismatch)
                {
                    FindPotentialImplicitImplementationMemberDeclaredInType(interfaceMember, implementingTypeIsFromSomeCompilation, currType, out implicitImpl, out closeMismatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 43275, 43575);
                    return 0;
                }


                int
                f_10054_44003_44083(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 44003, 44083);
                    return 0;
                }


                bool
                f_10054_44412_44440(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 44412, 44440);
                    return return_v;
                }


                int
                f_10054_44535_44693(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, bool
                implementingTypeIsFromSomeCompilation, ref Microsoft.CodeAnalysis.CSharp.Symbol?
                implicitImpl)
                {
                    CheckForImplementationOfCorrespondingPropertyOrEvent((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)interfaceMethod, implementingType, implementingTypeIsFromSomeCompilation, ref implicitImpl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 44535, 44693);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_45547_45661(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = FindMostSpecificImplementationInInterfaces(interfaceMember, implementingType, ref useSiteDiagnostics, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 45547, 45661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_46143_46198(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 46143, 46198);
                    return return_v;
                }


                bool
                f_10054_46127_46219(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 46127, 46219);
                    return return_v;
                }


                int
                f_10054_46391_46504(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                implicitImpl, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportDefaultInterfaceImplementationMatchDiagnostics(interfaceMember, implementingType, implicitImpl, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 46391, 46504);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_46826_46846(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 46826, 46846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_47147_47202(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47147, 47202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_47067_47297(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47067, 47297);
                    return return_v;
                }


                int
                f_10054_47423_47529(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                implicitImpl, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportImplicitImplementationMatchDiagnostics(interfaceMember, implementingType, implicitImpl, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47423, 47529);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10054_47685_47722(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 47685, 47722);
                    return return_v;
                }


                int
                f_10054_47672_47747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47672, 47747);
                    return 0;
                }


                bool
                f_10054_47784_47853(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsEventOrPropertyWithImplementableNonPublicAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47784, 47853);
                    return return_v;
                }


                int
                f_10054_47770_47854(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47770, 47854);
                    return 0;
                }


                int
                f_10054_47877_47989(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                closestMismatch, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportImplicitImplementationMismatchDiagnostics(interfaceMember, implementingType, closestMismatch, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 47877, 47989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 37112, 48071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 37112, 48071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol FindMostSpecificImplementationInInterfaces(Symbol interfaceMember, TypeSymbol implementingType,
                                                                                 ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                                                                                 DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 48083, 50913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 48448, 48498);

                f_10054_48448_48497(!f_10054_48462_48496(implementingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 48774, 48886);

                (MethodSymbol interfaceAccessor1, MethodSymbol interfaceAccessor2) = f_10054_48843_48885(interfaceMember);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 48902, 49067) || true) && (f_10054_48906_48954(interfaceAccessor1, implementingType) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 48906, 49006) || f_10054_48958_49006(interfaceAccessor2, implementingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 48902, 49067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49040, 49052);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 48902, 49067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49083, 49389);

                Symbol
                defaultImpl = f_10054_49104_49388(interfaceMember, implementingType, ref useSiteDiagnostics, out var conflict1, out var conflict2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49405, 49906) || true) && ((object)conflict1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 49405, 49906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49468, 49510);

                    f_10054_49468_49509((object)defaultImpl == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49528, 49568);

                    f_10054_49528_49567((object)conflict2 != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49586, 49783);

                    f_10054_49586_49782(diagnostics, ErrorCode.ERR_MostSpecificImplementationIsNotFound, f_10054_49654_49709(interfaceMember, implementingType), interfaceMember, conflict1, conflict2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 49405, 49906);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 49405, 49906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49849, 49891);

                    f_10054_49849_49890(((object)conflict2 == null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 49405, 49906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 49922, 49941);

                return defaultImpl;

                static bool stopLookup(MethodSymbol interfaceAccessor, TypeSymbol implementingType)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 49957, 50902);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50073, 50176) || true) && (interfaceAccessor is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 50073, 50176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50144, 50157);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 50073, 50176);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50196, 50342);

                        SymbolAndDiagnostics
                        symbolAndDiagnostics = f_10054_50240_50341(implementingType, interfaceAccessor)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50362, 50527) || true) && (symbolAndDiagnostics.Symbol is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 50362, 50527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50445, 50508);

                            return f_10054_50452_50507_M(!f_10054_50453_50495(symbolAndDiagnostics.Symbol).IsInterface);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 50362, 50527);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 50770, 50887);

                        return !symbolAndDiagnostics.Diagnostics.Any(d => d.Code == (int)ErrorCode.ERR_MostSpecificImplementationIsNotFound);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 49957, 50902);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                        f_10054_50240_50341(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        interfaceMember)
                        {
                            var return_v = this_param.FindImplementationForInterfaceMemberInNonInterfaceWithDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 50240, 50341);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10054_50453_50495(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 50453, 50495);
                            return return_v;
                        }


                        bool
                        f_10054_50452_50507_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 50452, 50507);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 49957, 50902);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 49957, 50902);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 48083, 50913);

                bool
                f_10054_48462_48496(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 48462, 48496);
                    return return_v;
                }


                int
                f_10054_48448_48497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 48448, 48497);
                    return 0;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor2)
                f_10054_48843_48885(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = GetImplementableAccessors(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 48843, 48885);
                    return return_v;
                }


                bool
                f_10054_48906_48954(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = stopLookup(interfaceAccessor, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 48906, 48954);
                    return return_v;
                }


                bool
                f_10054_48958_49006(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = stopLookup(interfaceAccessor, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 48958, 49006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_49104_49388(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation1, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation2)
                {
                    var return_v = FindMostSpecificImplementationInBases(interfaceMember, implementingType, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49104, 49388);
                    return return_v;
                }


                int
                f_10054_49468_49509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49468, 49509);
                    return 0;
                }


                int
                f_10054_49528_49567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49528, 49567);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_49654_49709(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49654, 49709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_49586_49782(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49586, 49782);
                    return return_v;
                }


                int
                f_10054_49849_49890(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 49849, 49890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 48083, 50913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 48083, 50913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol FindMostSpecificImplementation(Symbol interfaceMember, NamedTypeSymbol implementingInterface, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 50925, 52745);
                Microsoft.CodeAnalysis.CSharp.Symbol _ = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 51113, 51245);

                MultiDictionary<Symbol, Symbol>.ValueSet
                implementingMember = f_10054_51175_51244(interfaceMember, implementingInterface)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 51261, 52734);

                switch (implementingMember.Count)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 51261, 52734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 51356, 51468);

                        (MethodSymbol interfaceAccessor1, MethodSymbol interfaceAccessor2) = f_10054_51425_51467(interfaceMember);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 51691, 52043) || true) && ((interfaceAccessor1 is object && (DynAbs.Tracing.TraceSender.Expression_True(10054, 51696, 51811) && f_10054_51728_51800(interfaceAccessor1, implementingInterface).Count != 0)) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 51695, 51958) || (interfaceAccessor2 is object && (DynAbs.Tracing.TraceSender.Expression_True(10054, 51842, 51957) && f_10054_51874_51946(interfaceAccessor2, implementingInterface).Count != 0))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 51691, 52043);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52008, 52020);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 51691, 52043);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52067, 52330);

                        return f_10054_52074_52329(interfaceMember, implementingInterface, ref useSiteDiagnostics, out _, out _);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 51261, 52734);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 51261, 52734);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52404, 52448);

                            Symbol
                            result = implementingMember.Single()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52476, 52594) || true) && (f_10054_52480_52497(result))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 52476, 52594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52555, 52567);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 52476, 52594);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52622, 52636);

                            return result;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 51261, 52734);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 51261, 52734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 52707, 52719);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 51261, 52734);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 50925, 52745);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_51175_51244(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType)
                {
                    var return_v = FindImplementationInInterface(interfaceMember, interfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 51175, 51244);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor2)
                f_10054_51425_51467(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = GetImplementableAccessors(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 51425, 51467);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_51728_51800(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType)
                {
                    var return_v = FindImplementationInInterface((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, interfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 51728, 51800);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_51874_51946(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType)
                {
                    var return_v = FindImplementationInInterface((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, interfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 51874, 51946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_52074_52329(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation1, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation2)
                {
                    var return_v = FindMostSpecificImplementationInBases(interfaceMember, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingType, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 52074, 52329);
                    return return_v;
                }


                bool
                f_10054_52480_52497(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 52480, 52497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 50925, 52745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 50925, 52745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol FindMostSpecificImplementationInBases(
                    Symbol interfaceMember,
                    TypeSymbol implementingType,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    out Symbol conflictingImplementation1,
                    out Symbol conflictingImplementation2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 53053, 64760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 53382, 53517);

                ImmutableArray<NamedTypeSymbol>
                allInterfaces = f_10054_53430_53516(implementingType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 53533, 53723) || true) && (allInterfaces.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 53533, 53723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 53592, 53626);

                    conflictingImplementation1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 53644, 53678);

                    conflictingImplementation2 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 53696, 53708);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 53533, 53723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 54450, 54562);

                (MethodSymbol interfaceAccessor1, MethodSymbol interfaceAccessor2) = f_10054_54519_54561(interfaceMember);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 54578, 54852) || true) && (interfaceAccessor1 is null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 54582, 54638) && interfaceAccessor2 is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 54578, 54852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 54672, 54837);

                    return f_10054_54679_54836(interfaceMember, allInterfaces, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 54578, 54852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 54868, 55180);

                Symbol
                accessorImpl1 = f_10054_54891_55179(interfaceAccessor1 ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10054, 54929, 54969) ?? interfaceAccessor2), allInterfaces, ref useSiteDiagnostics, out var conflictingAccessorImplementation11, out var conflictingAccessorImplementation12)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55196, 55476) || true) && (accessorImpl1 is null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 55200, 55268) && conflictingAccessorImplementation11 is null))
                ) // implementation of accessor is not found

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 55196, 55476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55345, 55379);

                    conflictingImplementation1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55397, 55431);

                    conflictingImplementation2 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55449, 55461);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 55196, 55476);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55492, 56417) || true) && (interfaceAccessor1 is null || (DynAbs.Tracing.TraceSender.Expression_False(10054, 55496, 55552) || interfaceAccessor2 is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 55492, 56417);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55586, 55855) || true) && (accessorImpl1 is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 55586, 55855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55655, 55689);

                        conflictingImplementation1 = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55711, 55745);

                        conflictingImplementation2 = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55767, 55836);

                        return f_10054_55774_55835(interfaceMember, accessorImpl1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 55586, 55855);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 55875, 55988);

                    conflictingImplementation1 = f_10054_55904_55987(interfaceMember, conflictingAccessorImplementation11);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56006, 56119);

                    conflictingImplementation2 = f_10054_56035_56118(interfaceMember, conflictingAccessorImplementation12);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56139, 56370) || true) && ((conflictingImplementation1 is null) != (conflictingImplementation2 is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 56139, 56370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56261, 56295);

                        conflictingImplementation1 = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56317, 56351);

                        conflictingImplementation2 = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 56139, 56370);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56390, 56402);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 55492, 56417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56433, 56723);

                Symbol
                accessorImpl2 = f_10054_56456_56722(interfaceAccessor2, allInterfaces, ref useSiteDiagnostics, out var conflictingAccessorImplementation21, out var conflictingAccessorImplementation22)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 56739, 57207) || true) && ((accessorImpl2 is null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 56744, 56812) && conflictingAccessorImplementation21 is null)) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 56743, 56927) || (accessorImpl1 is null) != (accessorImpl2 is null)))
                ) // there is most specific implementation for one accessor and an ambiguous implementation for the other accessor. 

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 56739, 57207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57076, 57110);

                    conflictingImplementation1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57128, 57162);

                    conflictingImplementation2 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57180, 57192);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 56739, 57207);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57223, 57487) || true) && (accessorImpl1 is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 57223, 57487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57284, 57318);

                    conflictingImplementation1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57336, 57370);

                    conflictingImplementation2 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57388, 57472);

                    return f_10054_57395_57471(interfaceMember, accessorImpl1, accessorImpl2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 57223, 57487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57503, 57653);

                conflictingImplementation1 = f_10054_57532_57652(interfaceMember, conflictingAccessorImplementation11, conflictingAccessorImplementation21);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57667, 57817);

                conflictingImplementation2 = f_10054_57696_57816(interfaceMember, conflictingAccessorImplementation12, conflictingAccessorImplementation22);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 57833, 58271) || true) && ((conflictingImplementation1 is null) != (conflictingImplementation2 is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 57833, 58271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58170, 58204);

                    conflictingImplementation1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58222, 58256);

                    conflictingImplementation2 = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 57833, 58271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58287, 58299);

                return null;

                static Symbol findImplementationInInterface(Symbol interfaceMember, Symbol inplementingAccessor1, Symbol implementingAccessor2 = null)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 58315, 59331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58482, 58559);

                        NamedTypeSymbol
                        implementingInterface = f_10054_58522_58558(inplementingAccessor1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58579, 58915) || true) && (implementingAccessor2 is object && (DynAbs.Tracing.TraceSender.Expression_True(10054, 58583, 58721) && !f_10054_58619_58721(implementingInterface, f_10054_58648_58684(implementingAccessor2), TypeCompareKind.ConsiderEverything)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 58579, 58915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58884, 58896);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 58579, 58915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 58935, 59067);

                        MultiDictionary<Symbol, Symbol>.ValueSet
                        implementingMember = f_10054_58997_59066(interfaceMember, implementingInterface)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59087, 59316);

                        switch (implementingMember.Count)
                        {

                            case 1:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 59087, 59316);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59194, 59229);

                                return implementingMember.Single();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 59087, 59316);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 59087, 59316);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59285, 59297);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 59087, 59316);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 58315, 59331);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10054_58522_58558(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 58522, 58558);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10054_58648_58684(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 58648, 58684);
                            return return_v;
                        }


                        bool
                        f_10054_58619_58721(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        comparison)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 58619, 58721);
                            return return_v;
                        }


                        Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        f_10054_58997_59066(Microsoft.CodeAnalysis.CSharp.Symbol
                        interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        interfaceType)
                        {
                            var return_v = FindImplementationInInterface(interfaceMember, interfaceType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 58997, 59066);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 58315, 59331);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 58315, 59331);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static Symbol findMostSpecificImplementationInBases(
                                Symbol interfaceMember,
                                ImmutableArray<NamedTypeSymbol> allInterfaces,
                                ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                                out Symbol conflictingImplementation1,
                                out Symbol conflictingImplementation2)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 59347, 64749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59714, 59874);

                        var
                        implementations = f_10054_59736_59873()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59894, 63069);
                            foreach (var interfaceType in f_10054_59924_59937_I(allInterfaces))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 59894, 63069);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 59979, 60162) || true) && (f_10054_59983_60009_M(!interfaceType.IsInterface))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 59979, 60162);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60130, 60139);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 59979, 60162);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60186, 60301);

                                MultiDictionary<Symbol, Symbol>.ValueSet
                                candidate = f_10054_60239_60300(interfaceMember, interfaceType)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60325, 60431) || true) && (candidate.Count == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 60325, 60431);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60399, 60408);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 60325, 60431);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60464, 60469);

                                    for (int
                i = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60455, 61912) || true) && (i < f_10054_60475_60496(implementations))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60498, 60501)
                , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 60455, 61912))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 60455, 61912);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60551, 60682);

                                        (MultiDictionary<Symbol, Symbol>.ValueSet methodSet, MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> bases) = f_10054_60663_60681(implementations, i);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60708, 60744);

                                        Symbol
                                        previous = f_10054_60726_60743(ref methodSet)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60770, 60835);

                                        NamedTypeSymbol
                                        previousContainingType = f_10054_60811_60834(previous)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 60863, 61225) || true) && (f_10054_60867_60955(previousContainingType, interfaceType, TypeCompareKind.CLRSignatureCompareOptions))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 60863, 61225);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61072, 61112);

                                            implementations[i] = (candidate, bases);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61142, 61162);

                                            candidate = default;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 61192, 61198);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 60863, 61225);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61253, 61616) || true) && (bases == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 61253, 61616);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61328, 61369);

                                            f_10054_61328_61368(f_10054_61341_61362(implementations) == 1);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61399, 61519);

                                            bases = f_10054_61407_61518(previousContainingType, ref useSiteDiagnostics);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61549, 61589);

                                            implementations[i] = (methodSet, bases);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 61253, 61616);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61644, 61889) || true) && (f_10054_61648_61680(bases, interfaceType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 61644, 61889);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61806, 61826);

                                            candidate = default;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 61856, 61862);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 61644, 61889);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 1458);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 1458);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 61936, 62042) || true) && (candidate.Count == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 61936, 62042);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62010, 62019);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 61936, 62042);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62066, 63050) || true) && (f_10054_62070_62091(implementations) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 62066, 63050);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62146, 62307);

                                    MultiDictionary<NamedTypeSymbol, NamedTypeSymbol>
                                    bases = f_10054_62204_62306(interfaceType, ref useSiteDiagnostics)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62344, 62373);

                                        for (int
                i = f_10054_62348_62369(implementations) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62335, 62822) || true) && (i >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62383, 62386)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 62335, 62822))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 62335, 62822);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62483, 62513);

                                            var
                                            temp = f_10054_62494_62512(implementations, i)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62543, 62795) || true) && (f_10054_62547_62603(bases, f_10054_62565_62602(f_10054_62565_62587(ref temp.MethodSet))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 62543, 62795);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62736, 62764);

                                                f_10054_62736_62763(                                // new candidate is more specific
                                                                                implementations, i);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 62543, 62795);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 488);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 488);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62850, 62890);

                                    f_10054_62850_62889(
                                                            implementations, (candidate, bases));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 62066, 63050);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 62066, 63050);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 62988, 63027);

                                    f_10054_62988_63026(implementations, (candidate, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 62066, 63050);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 59894, 63069);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 3176);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 3176);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63089, 63103);

                        Symbol
                        result
                        = default(Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63123, 64659);

                        switch (f_10054_63131_63152(implementations))
                        {

                            case 0:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63123, 64659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63227, 63241);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63267, 63301);

                                conflictingImplementation1 = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63327, 63361);

                                conflictingImplementation2 = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 63387, 63393);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63123, 64659);

                            case 1:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63123, 64659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63448, 63530);

                                MultiDictionary<Symbol, Symbol>.ValueSet
                                methodSet = implementations[0].MethodSet
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63556, 64077);

                                switch (methodSet.Count)
                                {

                                    case 1:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63556, 64077);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63678, 63706);

                                        result = methodSet.Single();

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63740, 63884) || true) && (f_10054_63744_63761(result))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63740, 63884);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63835, 63849);

                                            result = null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63740, 63884);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10054, 63918, 63924);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63556, 64077);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63556, 64077);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 63996, 64010);

                                        result = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10054, 64044, 64050);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63556, 64077);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64105, 64139);

                                conflictingImplementation1 = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64165, 64199);

                                conflictingImplementation2 = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 64225, 64231);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63123, 64659);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 63123, 64659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64287, 64301);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64362, 64393);

                                var
                                temp1 = f_10054_64374_64392(implementations, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64419, 64472);

                                conflictingImplementation1 = f_10054_64448_64471(ref temp1.MethodSet);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64498, 64529);

                                var
                                temp2 = f_10054_64510_64528(implementations, 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64555, 64608);

                                conflictingImplementation2 = f_10054_64584_64607(ref temp2.MethodSet);
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 64634, 64640);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 63123, 64659);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64679, 64702);

                        f_10054_64679_64701(
                                        implementations);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64720, 64734);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 59347, 64749);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        f_10054_59736_59873()
                        {
                            var return_v = ArrayBuilder<(MultiDictionary<Symbol, Symbol>.ValueSet MethodSet, MultiDictionary<NamedTypeSymbol, NamedTypeSymbol> Bases)>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 59736, 59873);
                            return return_v;
                        }


                        bool
                        f_10054_59983_60009_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 59983, 60009);
                            return return_v;
                        }


                        Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        f_10054_60239_60300(Microsoft.CodeAnalysis.CSharp.Symbol
                        interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        interfaceType)
                        {
                            var return_v = FindImplementationInInterface(interfaceMember, interfaceType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 60239, 60300);
                            return return_v;
                        }


                        int
                        f_10054_60475_60496(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 60475, 60496);
                            return return_v;
                        }


                        (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)
                        f_10054_60663_60681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 60663, 60681);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10054_60726_60743(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 60726, 60743);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10054_60811_60834(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 60811, 60834);
                            return return_v;
                        }


                        bool
                        f_10054_60867_60955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        comparison)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 60867, 60955);
                            return return_v;
                        }


                        int
                        f_10054_61341_61362(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 61341, 61362);
                            return return_v;
                        }


                        int
                        f_10054_61328_61368(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 61328, 61368);
                            return 0;
                        }


                        Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10054_61407_61518(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.InterfacesAndTheirBaseInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 61407, 61518);
                            return return_v;
                        }


                        bool
                        f_10054_61648_61680(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        k)
                        {
                            var return_v = this_param.ContainsKey(k);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 61648, 61680);
                            return return_v;
                        }


                        int
                        f_10054_62070_62091(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 62070, 62091);
                            return return_v;
                        }


                        Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10054_62204_62306(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.InterfacesAndTheirBaseInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62204, 62306);
                            return return_v;
                        }


                        int
                        f_10054_62348_62369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 62348, 62369);
                            return return_v;
                        }


                        (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)
                        f_10054_62494_62512(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 62494, 62512);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10054_62565_62587(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62565, 62587);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10054_62565_62602(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 62565, 62602);
                            return return_v;
                        }


                        bool
                        f_10054_62547_62603(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        k)
                        {
                            var return_v = this_param.ContainsKey(k);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62547, 62603);
                            return return_v;
                        }


                        int
                        f_10054_62736_62763(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, int
                        index)
                        {
                            this_param.RemoveAt(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62736, 62763);
                            return 0;
                        }


                        int
                        f_10054_62850_62889(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet candidate, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> bases)
                        item)
                        {
                            this_param.Add(((Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases))item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62850, 62889);
                            return 0;
                        }


                        int
                        f_10054_62988_63026(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet candidate, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?)
                        item)
                        {
                            this_param.Add(((Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases))item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 62988, 63026);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10054_59924_59937_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 59924, 59937);
                            return return_v;
                        }


                        int
                        f_10054_63131_63152(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 63131, 63152);
                            return return_v;
                        }


                        bool
                        f_10054_63744_63761(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.IsAbstract;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 63744, 63761);
                            return return_v;
                        }


                        (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)
                        f_10054_64374_64392(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 64374, 64392);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10054_64448_64471(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 64448, 64471);
                            return return_v;
                        }


                        (Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)
                        f_10054_64510_64528(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 64510, 64528);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10054_64584_64607(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 64584, 64607);
                            return return_v;
                        }


                        int
                        f_10054_64679_64701(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet MethodSet, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol> Bases)>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 64679, 64701);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 59347, 64749);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 59347, 64749);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 53053, 64760);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_53430_53516(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 53430, 53516);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor2)
                f_10054_54519_54561(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = GetImplementableAccessors(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 54519, 54561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_54679_54836(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                allInterfaces, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation1, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation2)
                {
                    var return_v = findMostSpecificImplementationInBases(interfaceMember, allInterfaces, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 54679, 54836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_54891_55179(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                allInterfaces, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation1, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation2)
                {
                    var return_v = findMostSpecificImplementationInBases((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, allInterfaces, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 54891, 55179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_55774_55835(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 55774, 55835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_55904_55987(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 55904, 55987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_56035_56118(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 56035, 56118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_56456_56722(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                allInterfaces, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation1, out Microsoft.CodeAnalysis.CSharp.Symbol
                conflictingImplementation2)
                {
                    var return_v = findMostSpecificImplementationInBases((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, allInterfaces, ref useSiteDiagnostics, out conflictingImplementation1, out conflictingImplementation2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 56456, 56722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_57395_57471(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1, Microsoft.CodeAnalysis.CSharp.Symbol?
                implementingAccessor2)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1, implementingAccessor2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 57395, 57471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_57532_57652(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1, Microsoft.CodeAnalysis.CSharp.Symbol
                implementingAccessor2)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1, implementingAccessor2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 57532, 57652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_57696_57816(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbol
                inplementingAccessor1, Microsoft.CodeAnalysis.CSharp.Symbol
                implementingAccessor2)
                {
                    var return_v = findImplementationInInterface(interfaceMember, inplementingAccessor1, implementingAccessor2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 57696, 57816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 53053, 64760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 53053, 64760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MultiDictionary<Symbol, Symbol>.ValueSet FindImplementationInInterface(Symbol interfaceMember, NamedTypeSymbol interfaceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 64772, 65767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64938, 64978);

                f_10054_64938_64977(f_10054_64951_64976(interfaceType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 64994, 65058);

                NamedTypeSymbol
                containingType = f_10054_65027_65057(interfaceMember)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65072, 65658) || true) && (f_10054_65076_65156(containingType, interfaceType, TypeCompareKind.CLRSignatureCompareOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 65072, 65658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65190, 65608) || true) && (f_10054_65194_65221_M(!interfaceMember.IsAbstract))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 65190, 65608);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65263, 65496) || true) && (!f_10054_65268_65340(containingType, interfaceType, TypeCompareKind.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 65263, 65496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65390, 65473);

                            interfaceMember = f_10054_65408_65472(f_10054_65408_65442(interfaceMember), interfaceType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 65263, 65496);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65520, 65589);

                        return f_10054_65527_65588(interfaceMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 65190, 65608);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65628, 65643);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 65072, 65658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65674, 65756);

                return f_10054_65681_65755(interfaceType, interfaceMember);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 64772, 65767);

                bool
                f_10054_64951_64976(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 64951, 64976);
                    return return_v;
                }


                int
                f_10054_64938_64977(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 64938, 64977);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_65027_65057(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 65027, 65057);
                    return return_v;
                }


                bool
                f_10054_65076_65156(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 65076, 65156);
                    return return_v;
                }


                bool
                f_10054_65194_65221_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 65194, 65221);
                    return return_v;
                }


                bool
                f_10054_65268_65340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 65268, 65340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_65408_65442(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 65408, 65442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_65408_65472(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 65408, 65472);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_65527_65588(Microsoft.CodeAnalysis.CSharp.Symbol
                value)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 65527, 65588);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_65681_65755(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.GetExplicitImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 65681, 65755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 64772, 65767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 64772, 65767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (MethodSymbol interfaceAccessor1, MethodSymbol interfaceAccessor2) GetImplementableAccessors(Symbol interfaceMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 65779, 67348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65935, 65967);

                MethodSymbol
                interfaceAccessor1
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 65981, 66013);

                MethodSymbol
                interfaceAccessor2
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66029, 67009);

                switch (f_10054_66037_66057(interfaceMember))
                {

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 66029, 67009);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66165, 66232);

                            PropertySymbol
                            interfaceProperty = (PropertySymbol)interfaceMember
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66258, 66307);

                            interfaceAccessor1 = f_10054_66279_66306(interfaceProperty);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66333, 66382);

                            interfaceAccessor2 = f_10054_66354_66381(interfaceProperty);
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 66408, 66414);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 66029, 67009);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 66029, 67009);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66526, 66584);

                            EventSymbol
                            interfaceEvent = (EventSymbol)interfaceMember
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66610, 66656);

                            interfaceAccessor1 = f_10054_66631_66655(interfaceEvent);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66682, 66731);

                            interfaceAccessor2 = f_10054_66703_66730(interfaceEvent);
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 66757, 66763);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 66029, 67009);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 66029, 67009);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66861, 66887);

                            interfaceAccessor1 = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 66913, 66939);

                            interfaceAccessor2 = null;
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 66965, 66971);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 66029, 67009);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 67025, 67141) || true) && (!f_10054_67030_67066(interfaceAccessor1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 67025, 67141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 67100, 67126);

                    interfaceAccessor1 = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 67025, 67141);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 67157, 67273) || true) && (!f_10054_67162_67198(interfaceAccessor2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 67157, 67273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 67232, 67258);

                    interfaceAccessor2 = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 67157, 67273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 67289, 67337);

                return (interfaceAccessor1, interfaceAccessor2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 65779, 67348);

                Microsoft.CodeAnalysis.SymbolKind
                f_10054_66037_66057(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 66037, 66057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_66279_66306(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 66279, 66306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_66354_66381(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 66354, 66381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_66631_66655(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 66631, 66655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_66703_66730(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 66703, 66730);
                    return return_v;
                }


                bool
                f_10054_67030_67066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 67030, 67066);
                    return return_v;
                }


                bool
                f_10054_67162_67198(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 67162, 67198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 65779, 67348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 65779, 67348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsExplicitlyImplementedViaAccessors(Symbol interfaceMember, TypeSymbol currType, out Symbol implementingMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 69148, 71057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 69304, 69416);

                (MethodSymbol interfaceAccessor1, MethodSymbol interfaceAccessor2) = f_10054_69373_69415(interfaceMember);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 69432, 69451);

                Symbol
                associated1
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 69465, 69484);

                Symbol
                associated2
                = default(Symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 69500, 70977) || true) && (f_10054_69504_69604(interfaceAccessor1, currType, out associated1) |  // NB: not ||
                f_10054_69639_69739(interfaceAccessor2, currType, out associated2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 69500, 70977);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 69939, 70930) || true) && ((object)associated1 == null || (DynAbs.Tracing.TraceSender.Expression_False(10054, 69943, 70001) || (object)associated2 == null) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 69943, 70031) || associated1 == associated2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 69939, 70930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70073, 70121);

                        implementingMember = associated1 ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10054, 70094, 70120) ?? associated2);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70612, 70803) || true) && ((object)implementingMember != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 70616, 70704) && f_10054_70654_70704(implementingMember)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 70612, 70803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70754, 70780);

                            implementingMember = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 70612, 70803);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 69939, 70930);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 69939, 70930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70885, 70911);

                        implementingMember = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 69939, 70930);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70950, 70962);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 69500, 70977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 70993, 71019);

                implementingMember = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71033, 71046);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 69148, 71057);

                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol interfaceAccessor2)
                f_10054_69373_69415(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = GetImplementableAccessors(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 69373, 69415);
                    return return_v;
                }


                bool
                f_10054_69504_69604(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                associated)
                {
                    var return_v = TryGetExplicitImplementationAssociatedPropertyOrEvent(interfaceAccessor, currType, out associated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 69504, 69604);
                    return return_v;
                }


                bool
                f_10054_69639_69739(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                associated)
                {
                    var return_v = TryGetExplicitImplementationAssociatedPropertyOrEvent(interfaceAccessor, currType, out associated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 69639, 69739);
                    return return_v;
                }


                bool
                f_10054_70654_70704(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Dangerous_IsFromSomeCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 70654, 70704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 69148, 71057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 69148, 71057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetExplicitImplementationAssociatedPropertyOrEvent(MethodSymbol interfaceAccessor, TypeSymbol currType, out Symbol associated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 71069, 72025);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71243, 71953) || true) && ((object)interfaceAccessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 71243, 71953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71468, 71587);

                    MultiDictionary<Symbol, Symbol>.ValueSet
                    set = f_10054_71515_71586(currType, interfaceAccessor)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71605, 71938) || true) && (set.Count == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 71605, 71938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71665, 71702);

                        Symbol
                        implementation = set.Single()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71724, 71885);

                        associated = (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 71737, 71777) || ((f_10054_71737_71756(implementation) == SymbolKind.Method
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 71805, 71852)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 71880, 71884))) ? f_10054_71805_71852(((MethodSymbol)implementation)) : null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71907, 71919);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 71605, 71938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 71243, 71953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 71969, 71987);

                associated = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 72001, 72014);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 71069, 72025);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_71515_71586(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember)
                {
                    var return_v = this_param.GetExplicitImplementationForInterfaceMember((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 71515, 71586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_71737_71756(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 71737, 71756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_71805_71852(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 71805, 71852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 71069, 72025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 71069, 72025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckForImplementationOfCorrespondingPropertyOrEvent(MethodSymbol interfaceMethod, TypeSymbol implementingType, bool implementingTypeIsFromSomeCompilation,
                                                                                         ref Symbol implicitImpl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 72686, 78419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 72993, 73043);

                f_10054_72993_73042(!f_10054_73007_73041(implementingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 73057, 73100);

                f_10054_73057_73099(f_10054_73070_73098(interfaceMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 73116, 73193);

                Symbol
                associatedInterfacePropertyOrEvent = f_10054_73160_73192(interfaceMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 74299, 74616);

                Symbol
                implementingPropertyOrEvent = f_10054_74336_74615(implementingType, associatedInterfacePropertyOrEvent, ignoreImplementationInInterfacesIfResultIsNotReady: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 74650, 74704);

                MethodSymbol
                correspondingImplementingAccessor = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 74718, 75941) || true) && ((object)implementingPropertyOrEvent != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 74722, 74824) && f_10054_74769_74824_M(!f_10054_74770_74812(implementingPropertyOrEvent).IsInterface)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74718, 75941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 74858, 75926);

                    switch (f_10054_74866_74892(interfaceMethod))
                    {

                        case MethodKind.PropertyGet:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74858, 75926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 74988, 75099);

                            correspondingImplementingAccessor = f_10054_75024_75098(((PropertySymbol)implementingPropertyOrEvent));
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 75125, 75131);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74858, 75926);

                        case MethodKind.PropertySet:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74858, 75926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 75207, 75318);

                            correspondingImplementingAccessor = f_10054_75243_75317(((PropertySymbol)implementingPropertyOrEvent));
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 75344, 75350);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74858, 75926);

                        case MethodKind.EventAdd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74858, 75926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 75423, 75531);

                            correspondingImplementingAccessor = f_10054_75459_75530(((EventSymbol)implementingPropertyOrEvent));
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 75557, 75563);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74858, 75926);

                        case MethodKind.EventRemove:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74858, 75926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 75639, 75750);

                            correspondingImplementingAccessor = f_10054_75675_75749(((EventSymbol)implementingPropertyOrEvent));
                            DynAbs.Tracing.TraceSender.TraceBreak(10054, 75776, 75782);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74858, 75926);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 74858, 75926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 75838, 75907);

                            throw f_10054_75844_75906(f_10054_75879_75905(interfaceMethod));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74858, 75926);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 74718, 75941);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 75957, 78408) || true) && (correspondingImplementingAccessor == implicitImpl)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 75957, 78408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 76044, 76051);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 75957, 78408);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 75957, 78408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 76085, 78408) || true) && ((object)correspondingImplementingAccessor == null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 76089, 76170) && (object)implicitImpl != null) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 76089, 76199) && f_10054_76174_76199(implicitImpl)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 76085, 78408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 76397, 76417);

                        implicitImpl = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 76085, 78408);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 76085, 78408);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 76451, 78408) || true) && ((object)correspondingImplementingAccessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 76455, 76675) && ((object)implicitImpl == null || (DynAbs.Tracing.TraceSender.Expression_False(10054, 76509, 76674) || f_10054_76541_76674(f_10054_76559_76607(correspondingImplementingAccessor), f_10054_76609_76636(implicitImpl), TypeCompareKind.ConsiderEverything2)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 76451, 78408);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 77331, 78025);

                            MethodSymbol
                            interfaceAccessorWithImplementationName = f_10054_77386_78024(f_10054_77438_77476(correspondingImplementingAccessor), f_10054_77499_77529(interfaceMethod), f_10054_77552_77578(interfaceMethod), f_10054_77601_77634(interfaceMethod), f_10054_77657_77687(interfaceMethod), f_10054_77710_77736(interfaceMethod), f_10054_77759_77782(interfaceMethod), f_10054_77805_77831(interfaceMethod), f_10054_77854_77895(interfaceMethod), f_10054_77918_77952(interfaceMethod), f_10054_77975_78023(interfaceMethod))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 78133, 78393) || true) && (f_10054_78137_78283(correspondingImplementingAccessor, interfaceAccessorWithImplementationName, implementingTypeIsFromSomeCompilation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 78133, 78393);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 78325, 78374);

                                implicitImpl = correspondingImplementingAccessor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 78133, 78393);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 76451, 78408);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 76085, 78408);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 75957, 78408);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 72686, 78419);

                bool
                f_10054_73007_73041(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 73007, 73041);
                    return return_v;
                }


                int
                f_10054_72993_73042(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 72993, 73042);
                    return 0;
                }


                bool
                f_10054_73070_73098(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 73070, 73098);
                    return return_v;
                }


                int
                f_10054_73057_73099(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 73057, 73099);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_73160_73192(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 73160, 73192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10054_74336_74615(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                ignoreImplementationInInterfacesIfResultIsNotReady)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterface(interfaceMember, ignoreImplementationInInterfacesIfResultIsNotReady: ignoreImplementationInInterfacesIfResultIsNotReady);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 74336, 74615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_74770_74812(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 74770, 74812);
                    return return_v;
                }


                bool
                f_10054_74769_74824_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 74769, 74824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10054_74866_74892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 74866, 74892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_75024_75098(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = ((PropertySymbol)property).GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 75024, 75098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_75243_75317(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = ((PropertySymbol)property).GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 75243, 75317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_75459_75530(Microsoft.CodeAnalysis.CSharp.Symbol
                @event)
                {
                    var return_v = ((EventSymbol)@event).GetOwnOrInheritedAddMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 75459, 75530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_75675_75749(Microsoft.CodeAnalysis.CSharp.Symbol
                @event)
                {
                    var return_v = ((EventSymbol)@event).GetOwnOrInheritedRemoveMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 75675, 75749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10054_75879_75905(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 75879, 75905);
                    return return_v;
                }


                System.Exception
                f_10054_75844_75906(Microsoft.CodeAnalysis.MethodKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 75844, 75906);
                    return return_v;
                }


                bool
                f_10054_76174_76199(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 76174, 76199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_76559_76607(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 76559, 76607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_76609_76636(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 76609, 76636);
                    return return_v;
                }


                bool
                f_10054_76541_76674(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 76541, 76674);
                    return return_v;
                }


                string
                f_10054_77438_77476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77438, 77476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_77499_77529(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77499, 77529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10054_77552_77578(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77552, 77578);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10054_77601_77634(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77601, 77634);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10054_77657_77687(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77657, 77687);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10054_77710_77736(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77710, 77736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10054_77759_77782(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77759, 77782);
                    return return_v;
                }


                bool
                f_10054_77805_77831(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77805, 77831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10054_77854_77895(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77854, 77895);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10054_77918_77952(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77918, 77952);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10054_77975_78023(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 77975, 78023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol
                f_10054_77386_78024(string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.MethodKind
                methodKind, Microsoft.Cci.CallingConvention
                callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                isInitOnly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                explicitInterfaceImplementations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, methodKind, callingConvention, typeParameters, parameters, refKind, isInitOnly, returnType, refCustomModifiers, explicitInterfaceImplementations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 77386, 78024);
                    return return_v;
                }


                bool
                f_10054_78137_78283(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                candidateMember, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, bool
                implementingTypeIsFromSomeCompilation)
                {
                    var return_v = IsInterfaceMemberImplementation((Microsoft.CodeAnalysis.CSharp.Symbol)candidateMember, (Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, implementingTypeIsFromSomeCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 78137, 78283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 72686, 78419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 72686, 78419);
            }
        }

        private static void ReportDefaultInterfaceImplementationMatchDiagnostics(Symbol interfaceMember, TypeSymbol implementingType, Symbol implicitImpl, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 78431, 80324);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 78629, 80313) || true) && (f_10054_78633_78653(interfaceMember) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10054, 78633, 78744) && f_10054_78678_78711(implementingType) != f_10054_78715_78744(implicitImpl)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 78629, 80313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 78980, 79077);

                    LanguageVersion
                    requiredVersion = f_10054_79014_79076(MessageID.IDS_DefaultInterfaceImplementation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 79095, 79186);

                    LanguageVersion?
                    availableVersion = f_10054_79131_79185_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10054_79131_79168(implementingType), 10054, 79131, 79185)?.LanguageVersion)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 79204, 79859) || true) && (requiredVersion > availableVersion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 79204, 79859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 79284, 79840);

                        f_10054_79284_79839(diagnostics, ErrorCode.ERR_LanguageVersionDoesNotSupportDefaultInterfaceImplementationForMember, f_10054_79421_79476(interfaceMember, implementingType), implicitImpl, interfaceMember, implementingType, f_10054_79601_79656(MessageID.IDS_DefaultInterfaceImplementation), f_10054_79695_79749(f_10054_79695_79731(availableVersion)), f_10054_79788_79838(requiredVersion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 79204, 79859);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 79879, 80298) || true) && (f_10054_79883_79965_M(!f_10054_79884_79919(implementingType).RuntimeSupportsDefaultInterfaceImplementation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 79879, 80298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80007, 80279);

                        f_10054_80007_80278(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportDefaultInterfaceImplementationForMember, f_10054_80136_80191(interfaceMember, implementingType), implicitImpl, interfaceMember, implementingType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 79879, 80298);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 78629, 80313);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 78431, 80324);

                Microsoft.CodeAnalysis.SymbolKind
                f_10054_78633_78653(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 78633, 78653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10054_78678_78711(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 78678, 78711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10054_78715_78744(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 78715, 78744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10054_79014_79076(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79014, 79076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10054_79131_79168(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 79131, 79168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion?
                f_10054_79131_79185_M(Microsoft.CodeAnalysis.CSharp.LanguageVersion?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 79131, 79185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_79421_79476(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79421, 79476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10054_79601_79656(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79601, 79656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10054_79695_79731(Microsoft.CodeAnalysis.CSharp.LanguageVersion?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79695, 79731);
                    return return_v;
                }


                string
                f_10054_79695_79749(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79695, 79749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10054_79788_79838(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79788, 79838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_79284_79839(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 79284, 79839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10054_79884_79919(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 79884, 79919);
                    return return_v;
                }


                bool
                f_10054_79883_79965_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 79883, 79965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_80136_80191(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 80136, 80191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_80007_80278(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 80007, 80278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 78431, 80324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 78431, 80324);
            }
        }

        private static void ReportImplicitImplementationMatchDiagnostics(Symbol interfaceMember, TypeSymbol implementingType, Symbol implicitImpl, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 80526, 84686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80716, 80745);

                bool
                reportedAnError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80761, 82603) || true) && (f_10054_80765_80785(interfaceMember) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 80761, 82603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80840, 80892);

                    var
                    interfaceMethod = (MethodSymbol)interfaceMember
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80910, 80966);

                    bool
                    implicitImplIsAccessor = f_10054_80940_80965(implicitImpl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 80984, 81046);

                    bool
                    interfaceMethodIsAccessor = f_10054_81017_81045(interfaceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81066, 82588) || true) && (interfaceMethodIsAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10054, 81070, 81122) && !implicitImplIsAccessor) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 81070, 81170) && !f_10054_81127_81170(interfaceMethod)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81066, 82588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81212, 81413);

                        f_10054_81212_81412(diagnostics, ErrorCode.ERR_MethodImplementingAccessor, f_10054_81270_81362(interfaceMember, implementingType, implicitImpl), implicitImpl, interfaceMethod, implementingType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81066, 82588);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81066, 82588);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81455, 82588) || true) && (!interfaceMethodIsAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10054, 81459, 81511) && implicitImplIsAccessor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81455, 82588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81553, 81754);

                            f_10054_81553_81753(diagnostics, ErrorCode.ERR_AccessorImplementingMethod, f_10054_81611_81703(interfaceMember, implementingType, implicitImpl), implicitImpl, interfaceMethod, implementingType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81455, 82588);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81455, 82588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81836, 81888);

                            var
                            implicitImplMethod = (MethodSymbol)implicitImpl
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 81912, 82569) || true) && (f_10054_81916_81948(implicitImplMethod))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81912, 82569);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 82113, 82321);

                                f_10054_82113_82320(                        // CS0629: Conditional member '{0}' cannot implement interface member '{1}' in type '{2}'
                                                        diagnostics, ErrorCode.ERR_InterfaceImplementedByConditional, f_10054_82178_82270(interfaceMember, implementingType, implicitImpl), implicitImpl, interfaceMethod, implementingType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81912, 82569);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 81912, 82569);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 82371, 82569) || true) && (f_10054_82375_82473(interfaceMethod, implementingType, implicitImplMethod, diagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 82371, 82569);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 82523, 82546);

                                    reportedAnError = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 82371, 82569);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81912, 82569);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81455, 82588);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 81066, 82588);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 80761, 82603);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 82619, 83153) || true) && (f_10054_82623_82656(implicitImpl) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 82623, 82753) && f_10054_82660_82753(implicitImpl, interfaceMember)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 82619, 83153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 82923, 83097);

                    f_10054_82923_83096(                // it is ok to implement implicitly with no tuple names, for compatibility with C# 6, but otherwise names should match
                                    diagnostics, ErrorCode.ERR_ImplBadTupleNames, f_10054_82972_83064(interfaceMember, implementingType, implicitImpl), implicitImpl, interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83115, 83138);

                    reportedAnError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 82619, 83153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83169, 83423) || true) && (!reportedAnError && (DynAbs.Tracing.TraceSender.Expression_True(10054, 83173, 83238) && f_10054_83193_83230(implementingType) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 83169, 83423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83272, 83408);

                    f_10054_83272_83407(implementingType, implicitImpl, interfaceMember, isExplicit: false, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 83169, 83423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83691, 84675) || true) && (f_10054_83695_83736_M(!f_10054_83696_83723(implicitImpl).IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 83691, 84675);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83770, 84660);
                        foreach (Symbol member in f_10054_83796_83853_I(f_10054_83796_83853(f_10054_83796_83823(implicitImpl), f_10054_83835_83852(implicitImpl))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 83770, 84660);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 83895, 84641) || true) && (f_10054_83899_83927(member) != Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10054, 83899, 83970) || f_10054_83955_83970(member)) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 83899, 83996) || member == implicitImpl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 83895, 84641);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 83895, 84641);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 83895, 84641);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 84142, 84641) || true) && (f_10054_84146_84239(MemberSignatureComparer.RuntimeImplicitImplementationComparer, interfaceMember, member) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 84146, 84263) && !f_10054_84244_84263(member)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 84142, 84641);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 84419, 84618);

                                    f_10054_84419_84617(                        // CONSIDER: Dev10 does not seem to report this for indexers or their accessors.
                                                            diagnostics, ErrorCode.WRN_MultipleRuntimeImplementationMatches, f_10054_84487_84573(interfaceMember, implementingType, member), member, interfaceMember, implementingType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 84142, 84641);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 83895, 84641);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 83770, 84660);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 891);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 83691, 84675);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 80526, 84686);

                Microsoft.CodeAnalysis.SymbolKind
                f_10054_80765_80785(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 80765, 80785);
                    return return_v;
                }


                bool
                f_10054_80940_80965(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 80940, 80965);
                    return return_v;
                }


                bool
                f_10054_81017_81045(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81017, 81045);
                    return return_v;
                }


                bool
                f_10054_81127_81170(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsIndexedPropertyAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81127, 81170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_81270_81362(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81270, 81362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_81212_81412(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81212, 81412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_81611_81703(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81611, 81703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_81553_81753(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 81553, 81753);
                    return return_v;
                }


                bool
                f_10054_81916_81948(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 81916, 81948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_82178_82270(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82178, 82270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_82113_82320(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82113, 82320);
                    return return_v;
                }


                bool
                f_10054_82375_82473(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implicitImpl, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ReportAnyMismatchedConstraints(interfaceMethod, implementingType, implicitImpl, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82375, 82473);
                    return return_v;
                }


                bool
                f_10054_82623_82656(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82623, 82656);
                    return return_v;
                }


                bool
                f_10054_82660_82753(Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = MemberSignatureComparer.ConsideringTupleNamesCreatesDifference(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82660, 82753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_82972_83064(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82972, 83064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_82923_83096(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 82923, 83096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10054_83193_83230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83193, 83230);
                    return return_v;
                }


                int
                f_10054_83272_83407(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                isExplicit, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckNullableReferenceTypeMismatchOnImplementingMember(implementingType, implementingMember, interfaceMember, isExplicit: isExplicit, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 83272, 83407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_83696_83723(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83696, 83723);
                    return return_v;
                }


                bool
                f_10054_83695_83736_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83695, 83736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_83796_83823(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83796, 83823);
                    return return_v;
                }


                string
                f_10054_83835_83852(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83835, 83852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_83796_83853(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 83796, 83853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10054_83899_83927(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83899, 83927);
                    return return_v;
                }


                bool
                f_10054_83955_83970(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 83955, 83970);
                    return return_v;
                }


                bool
                f_10054_84146_84239(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 84146, 84239);
                    return return_v;
                }


                bool
                f_10054_84244_84263(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 84244, 84263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_84487_84573(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 84487, 84573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_84419_84617(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 84419, 84617);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_83796_83853_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 83796, 83853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 80526, 84686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 80526, 84686);
            }
        }

        internal static void CheckNullableReferenceTypeMismatchOnImplementingMember(TypeSymbol implementingType, Symbol implementingMember, Symbol interfaceMember, bool isExplicit, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 84698, 95400);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 84922, 95389) || true) && (f_10054_84926_84966_M(!implementingMember.IsImplicitlyDeclared) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 84926, 85002) && !f_10054_84971_85002(implementingMember)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 84922, 95389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 85036, 85106);

                    CSharpCompilation
                    compilation = f_10054_85068_85105(implementingType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 85126, 95374) || true) && (f_10054_85130_85150(interfaceMember) == SymbolKind.Event)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 85126, 95374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 85212, 85268);

                        var
                        implementingEvent = (EventSymbol)implementingMember
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 85290, 85342);

                        var
                        implementedEvent = (EventSymbol)interfaceMember
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 85364, 87757);

                        f_10054_85364_87756(compilation, implementedEvent, implementingEvent, diagnostics, (diagnostics, implementedEvent, implementingEvent, arg) =>
                                                                                                            {
                                                                                                                if (arg.isExplicit)
                                                                                                                {
                                                                                                                    diagnostics.Add(ErrorCode.WRN_NullabilityMismatchInTypeOnExplicitImplementation,
                                                                                                                                    implementingEvent.Locations[0], new FormattedSymbol(implementedEvent, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    diagnostics.Add(ErrorCode.WRN_NullabilityMismatchInTypeOnImplicitImplementation,
                                                                                                                                    GetImplicitImplementationDiagnosticLocation(implementedEvent, arg.implementingType, implementingEvent),
                                                                                                                                    new FormattedSymbol(implementingEvent, SymbolDisplayFormat.MinimallyQualifiedFormat),
                                                                                                                                    new FormattedSymbol(implementedEvent, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                                                                                }
                                                                                                            }, (implementingType, isExplicit));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 85126, 95374);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 85126, 95374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 87839, 89760);

                        ReportMismatchInReturnType<(TypeSymbol implementingType, bool isExplicit)>
                        reportMismatchInReturnType =
                                                (diagnostics, implementedMethod, implementingMethod, topLevel, arg) =>
                                                {
                                                    if (arg.isExplicit)
                                                    {
                                                // We use ConstructedFrom symbols here and below to not leak methods with Ignored annotations in type arguments
                                                // into diagnostics
                                                diagnostics.Add(topLevel ?
                                                                                    ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnExplicitImplementation :
                                                                                    ErrorCode.WRN_NullabilityMismatchInReturnTypeOnExplicitImplementation,
                                                                                implementingMethod.Locations[0], new FormattedSymbol(implementedMethod.ConstructedFrom, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                    }
                                                    else
                                                    {
                                                        diagnostics.Add(topLevel ?
                                                                            ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnImplicitImplementation :
                                                                            ErrorCode.WRN_NullabilityMismatchInReturnTypeOnImplicitImplementation,
                                                                        GetImplicitImplementationDiagnosticLocation(implementedMethod, arg.implementingType, implementingMethod),
                                                                        new FormattedSymbol(implementingMethod, SymbolDisplayFormat.MinimallyQualifiedFormat),
                                                                        new FormattedSymbol(implementedMethod.ConstructedFrom, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                    }
                                                }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 89784, 91849);

                        ReportMismatchInParameterType<(TypeSymbol implementingType, bool isExplicit)>
                        reportMismatchInParameterType =
                                                (diagnostics, implementedMethod, implementingMethod, implementingParameter, topLevel, arg) =>
                                                {
                                                    if (arg.isExplicit)
                                                    {
                                                        diagnostics.Add(topLevel ?
                                                                            ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnExplicitImplementation :
                                                                            ErrorCode.WRN_NullabilityMismatchInParameterTypeOnExplicitImplementation,
                                                                        implementingMethod.Locations[0],
                                                                        new FormattedSymbol(implementingParameter, SymbolDisplayFormat.ShortFormat),
                                                                        new FormattedSymbol(implementedMethod.ConstructedFrom, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                    }
                                                    else
                                                    {
                                                        diagnostics.Add(topLevel ?
                                                                            ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnImplicitImplementation :
                                                                            ErrorCode.WRN_NullabilityMismatchInParameterTypeOnImplicitImplementation,
                                                                        GetImplicitImplementationDiagnosticLocation(implementedMethod, arg.implementingType, implementingMethod),
                                                                        new FormattedSymbol(implementingParameter, SymbolDisplayFormat.ShortFormat),
                                                                        new FormattedSymbol(implementingMethod, SymbolDisplayFormat.MinimallyQualifiedFormat),
                                                                        new FormattedSymbol(implementedMethod.ConstructedFrom, SymbolDisplayFormat.MinimallyQualifiedFormat));
                                                    }
                                                }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 91873, 95355);

                        switch (f_10054_91881_91901(interfaceMember))
                        {

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 91873, 95355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 92006, 92068);

                                var
                                implementingProperty = (PropertySymbol)implementingMember
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 92098, 92156);

                                var
                                implementedProperty = (PropertySymbol)interfaceMember
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 92186, 93437) || true) && (f_10054_92190_92237(f_10054_92190_92219(implementedProperty)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 92186, 93437);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 92303, 92390);

                                    MethodSymbol
                                    implementingGetMethod = f_10054_92340_92389(implementingProperty)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 92424, 93406);

                                    f_10054_92424_93405(compilation, f_10054_92577_92606(implementedProperty), implementingGetMethod, diagnostics, reportMismatchInReturnType, (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 93002, 93296) || ((                                    // Don't check parameters on the getter if there is a setter
                                                                                                                                                                                                                                                                                        // because they will be a subset of the setter
                                                                        (!f_10054_93004_93051(f_10054_93004_93033(implementedProperty)) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 93003, 93159) || f_10054_93096_93135_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(implementingGetMethod, 10054, 93096, 93135)?.AssociatedSymbol) != implementingProperty) || (DynAbs.Tracing.TraceSender.Expression_False(10054, 93003, 93295) || f_10054_93204_93271_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10054_93204_93253(implementingProperty), 10054, 93204, 93271)?.AssociatedSymbol) != implementingProperty)) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 93299, 93328)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 93331, 93335))) ? reportMismatchInParameterType : null, (implementingType, isExplicit));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 92186, 93437);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 93469, 94119) || true) && (f_10054_93473_93520(f_10054_93473_93502(implementedProperty)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 93469, 94119);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 93586, 94088);

                                    f_10054_93586_94087(compilation, f_10054_93739_93768(implementedProperty), f_10054_93807_93856(implementingProperty), diagnostics, null, reportMismatchInParameterType, (implementingType, isExplicit));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 93469, 94119);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 94149, 94155);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 91873, 95355);

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 91873, 95355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 94234, 94292);

                                var
                                implementingMethod = (MethodSymbol)implementingMember
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 94322, 94376);

                                var
                                implementedMethod = (MethodSymbol)interfaceMember
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 94408, 94684) || true) && (f_10054_94412_94445(implementedMethod))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 94408, 94684);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 94511, 94653);

                                    implementedMethod = f_10054_94531_94652(implementedMethod, f_10054_94559_94651(f_10054_94617_94650(implementingMethod)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 94408, 94684);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 94716, 95169);

                                f_10054_94716_95168(compilation, implementedMethod, implementingMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, (implementingType, isExplicit));
                                DynAbs.Tracing.TraceSender.TraceBreak(10054, 95199, 95205);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 91873, 95355);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 91873, 95355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 95269, 95332);

                                throw f_10054_95275_95331(f_10054_95310_95330(interfaceMember));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 91873, 95355);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 85126, 95374);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 84922, 95389);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 84698, 95400);

                bool
                f_10054_84926_84966_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 84926, 84966);
                    return return_v;
                }


                bool
                f_10054_84971_85002(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 84971, 85002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10054_85068_85105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 85068, 85105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_85130_85150(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 85130, 85150);
                    return return_v;
                }


                int
                f_10054_85364_87756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                overriddenEvent, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                overridingEvent, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Action<Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatch, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)
                extraArgument)
                {
                    SourceMemberContainerTypeSymbol.CheckValidNullableEventOverride(compilation, overriddenEvent, overridingEvent, diagnostics, reportMismatch, extraArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 85364, 87756);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_91881_91901(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 91881, 91901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_92190_92219(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 92190, 92219);
                    return return_v;
                }


                bool
                f_10054_92190_92237(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 92190, 92237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_92340_92389(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 92340, 92389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_92577_92606(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 92577, 92606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_93004_93033(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 93004, 93033);
                    return return_v;
                }


                bool
                f_10054_93004_93051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 93004, 93051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10054_93096_93135_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 93096, 93135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_93204_93253(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 93204, 93253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10054_93204_93271_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 93204, 93271);
                    return return_v;
                }


                int
                f_10054_92424_93405(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                baseMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                overrideMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatchInReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>?
                reportMismatchInParameterType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)
                extraArgument)
                {
                    SourceMemberContainerTypeSymbol.CheckValidNullableMethodOverride(compilation, baseMethod, overrideMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, extraArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 92424, 93405);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_93473_93502(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 93473, 93502);
                    return return_v;
                }


                bool
                f_10054_93473_93520(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 93473, 93520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_93739_93768(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 93739, 93768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10054_93807_93856(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 93807, 93856);
                    return return_v;
                }


                int
                f_10054_93586_94087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                baseMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                overrideMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatchInReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatchInParameterType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)
                extraArgument)
                {
                    SourceMemberContainerTypeSymbol.CheckValidNullableMethodOverride(compilation, baseMethod, overrideMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, extraArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 93586, 94087);
                    return 0;
                }


                bool
                f_10054_94412_94445(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 94412, 94445);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10054_94617_94650(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 94617, 94650);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10054_94559_94651(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    var return_v = TypeMap.TypeParametersAsTypeSymbolsWithIgnoredAnnotations(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 94559, 94651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_94531_94652(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 94531, 94652);
                    return return_v;
                }


                int
                f_10054_94716_95168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                baseMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overrideMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatchInReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)>
                reportMismatchInParameterType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol implementingType, bool isExplicit)
                extraArgument)
                {
                    SourceMemberContainerTypeSymbol.CheckValidNullableMethodOverride(compilation, baseMethod, overrideMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, extraArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 94716, 95168);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_95310_95330(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 95310, 95330);
                    return return_v;
                }


                System.Exception
                f_10054_95275_95331(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 95275, 95331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 84698, 95400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 84698, 95400);
            }
        }

        private static void ReportImplicitImplementationMismatchDiagnostics(Symbol interfaceMember, TypeSymbol implementingType, Symbol closestMismatch, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 95579, 99521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 95893, 95978);

                Location
                interfaceLocation = f_10054_95922_95977(interfaceMember, implementingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 95994, 99510) || true) && (f_10054_95998_96022(closestMismatch))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 95994, 99510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96056, 96198);

                    f_10054_96056_96197(diagnostics, ErrorCode.ERR_CloseUnimplementedInterfaceMemberStatic, interfaceLocation, implementingType, interfaceMember, closestMismatch);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 95994, 99510);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 95994, 99510);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96232, 99510) || true) && (f_10054_96236_96273(closestMismatch) != Accessibility.Public)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 96232, 99510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96331, 96488);

                        ErrorCode
                        errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10054, 96353, 96381) || ((f_10054_96353_96381(interfaceMember) && DynAbs.Tracing.TraceSender.Conditional_F2(10054, 96384, 96428)) || DynAbs.Tracing.TraceSender.Conditional_F3(10054, 96431, 96487))) ? ErrorCode.ERR_UnimplementedInterfaceAccessor : ErrorCode.ERR_CloseUnimplementedInterfaceMemberNotPublic
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96506, 96604);

                        f_10054_96506_96603(diagnostics, errorCode, interfaceLocation, implementingType, interfaceMember, closestMismatch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 96232, 99510);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 96232, 99510);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96638, 99510) || true) && (f_10054_96642_96696(interfaceMember, closestMismatch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 96638, 99510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96730, 96879);

                            f_10054_96730_96878(diagnostics, ErrorCode.ERR_CloseUnimplementedInterfaceMemberWrongInitOnly, interfaceLocation, implementingType, interfaceMember, closestMismatch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 96638, 99510);
                        }

                        else //return ref kind or type doesn't match

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 96638, 99510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 96985, 97031);

                            RefKind
                            interfaceMemberRefKind = RefKind.None
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97049, 97086);

                            TypeSymbol
                            interfaceMemberReturnType
                            = default(TypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97104, 98028);

                            switch (f_10054_97112_97132(interfaceMember))
                            {

                                case SymbolKind.Method:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 97104, 98028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97223, 97266);

                                    var
                                    method = (MethodSymbol)interfaceMember
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97292, 97332);

                                    interfaceMemberRefKind = f_10054_97317_97331(method);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97358, 97404);

                                    interfaceMemberReturnType = f_10054_97386_97403(method);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 97430, 97436);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 97104, 98028);

                                case SymbolKind.Property:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 97104, 98028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97509, 97556);

                                    var
                                    property = (PropertySymbol)interfaceMember
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97582, 97624);

                                    interfaceMemberRefKind = f_10054_97607_97623(property);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97650, 97692);

                                    interfaceMemberReturnType = f_10054_97678_97691(property);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 97718, 97724);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 97104, 98028);

                                case SymbolKind.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 97104, 98028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97794, 97858);

                                    interfaceMemberReturnType = f_10054_97822_97857(((EventSymbol)interfaceMember));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 97884, 97890);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 97104, 98028);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 97104, 98028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 97946, 98009);

                                    throw f_10054_97952_98008(f_10054_97987_98007(interfaceMember));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 97104, 98028);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98048, 98082);

                            bool
                            hasRefReturnMismatch = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98100, 98557);

                            switch (f_10054_98108_98128(closestMismatch))
                            {

                                case SymbolKind.Method:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 98100, 98557);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98219, 98308);

                                    hasRefReturnMismatch = f_10054_98242_98281(((MethodSymbol)closestMismatch)) != interfaceMemberRefKind;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 98334, 98340);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 98100, 98557);

                                case SymbolKind.Property:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 98100, 98557);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98415, 98506);

                                    hasRefReturnMismatch = f_10054_98438_98479(((PropertySymbol)closestMismatch)) != interfaceMemberRefKind;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 98532, 98538);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 98100, 98557);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98577, 98610);

                            DiagnosticInfo
                            useSiteDiagnostic
                            = default(DiagnosticInfo);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98628, 99495) || true) && ((object)interfaceMemberReturnType != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 98632, 98776) && (useSiteDiagnostic = f_10054_98719_98767(interfaceMemberReturnType)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 98632, 98862) && f_10054_98801_98834(useSiteDiagnostic) == DiagnosticSeverity.Error))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 98628, 99495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 98904, 98958);

                                f_10054_98904_98957(diagnostics, useSiteDiagnostic, interfaceLocation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 98628, 99495);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 98628, 99495);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99000, 99495) || true) && (hasRefReturnMismatch)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 99000, 99495);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99066, 99216);

                                    f_10054_99066_99215(diagnostics, ErrorCode.ERR_CloseUnimplementedInterfaceMemberWrongRefReturn, interfaceLocation, implementingType, interfaceMember, closestMismatch);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 99000, 99495);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 99000, 99495);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99298, 99476);

                                    f_10054_99298_99475(diagnostics, ErrorCode.ERR_CloseUnimplementedInterfaceMemberWrongReturnType, interfaceLocation, implementingType, interfaceMember, closestMismatch, interfaceMemberReturnType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 99000, 99495);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 98628, 99495);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 96638, 99510);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 96232, 99510);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 95994, 99510);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 95579, 99521);

                Microsoft.CodeAnalysis.Location
                f_10054_95922_95977(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType)
                {
                    var return_v = GetInterfaceLocation(interfaceMember, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 95922, 95977);
                    return return_v;
                }


                bool
                f_10054_95998_96022(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 95998, 96022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_96056_96197(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 96056, 96197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10054_96236_96273(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 96236, 96273);
                    return return_v;
                }


                bool
                f_10054_96353_96381(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 96353, 96381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_96506_96603(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 96506, 96603);
                    return return_v;
                }


                bool
                f_10054_96642_96696(Microsoft.CodeAnalysis.CSharp.Symbol
                one, Microsoft.CodeAnalysis.CSharp.Symbol
                other)
                {
                    var return_v = HaveInitOnlyMismatch(one, other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 96642, 96696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_96730_96878(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 96730, 96878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_97112_97132(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97112, 97132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10054_97317_97331(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97317, 97331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10054_97386_97403(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97386, 97403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10054_97607_97623(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97607, 97623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10054_97678_97691(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97678, 97691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10054_97822_97857(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97822, 97857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_97987_98007(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 97987, 98007);
                    return return_v;
                }


                System.Exception
                f_10054_97952_98008(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 97952, 98008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_98108_98128(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 98108, 98128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10054_98242_98281(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 98242, 98281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10054_98438_98479(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 98438, 98479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10054_98719_98767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 98719, 98767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10054_98801_98834(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 98801, 98834);
                    return return_v;
                }


                int
                f_10054_98904_98957(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 98904, 98957);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_99066_99215(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 99066, 99215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_99298_99475(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 99298, 99475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 95579, 99521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 95579, 99521);
            }
        }

        internal static bool HaveInitOnlyMismatch(Symbol one, Symbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 99533, 99922);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99625, 99723) || true) && (!(one is MethodSymbol oneMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 99625, 99723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99695, 99708);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 99625, 99723);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99739, 99841) || true) && (!(other is MethodSymbol otherMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 99739, 99841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99813, 99826);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 99739, 99841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 99857, 99911);

                return f_10054_99864_99884(oneMethod) != f_10054_99888_99910(otherMethod);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 99533, 99922);

                bool
                f_10054_99864_99884(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 99864, 99884);
                    return return_v;
                }


                bool
                f_10054_99888_99910(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 99888, 99910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 99533, 99922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 99533, 99922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Location GetInterfaceLocation(Symbol interfaceMember, TypeSymbol implementingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 100095, 100729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100217, 100264);

                f_10054_100217_100263((object)implementingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100278, 100326);

                var
                @interface = f_10054_100295_100325(interfaceMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100342, 100385);

                SourceMemberContainerTypeSymbol
                snt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100399, 100612) || true) && (f_10054_100403_100472(implementingType)[@interface].Contains(@interface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 100399, 100612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100539, 100597);

                    snt = implementingType as SourceMemberContainerTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 100399, 100612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100628, 100718);

                return f_10054_100635_100673_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(snt, 10054, 100635, 100673)?.GetImplementsLocation(@interface)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10054, 100635, 100717) ?? implementingType.Locations.FirstOrNone());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 100095, 100729);

                int
                f_10054_100217_100263(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 100217, 100263);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_100295_100325(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 100295, 100325);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10054_100403_100472(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 100403, 100472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10054_100635_100673_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 100635, 100673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 100095, 100729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 100095, 100729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReportAnyMismatchedConstraints(MethodSymbol interfaceMethod, TypeSymbol implementingType, MethodSymbol implicitImpl, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 100741, 103676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 100929, 100987);

                f_10054_100929_100986(f_10054_100942_100963(interfaceMethod) == f_10054_100967_100985(implicitImpl));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101003, 101023);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101037, 101071);

                var
                arity = f_10054_101049_101070(interfaceMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101087, 103635) || true) && (arity > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 101087, 103635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101134, 101187);

                    var
                    typeParameters1 = f_10054_101156_101186(interfaceMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101205, 101255);

                    var
                    typeParameters2 = f_10054_101227_101254(implicitImpl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101273, 101340);

                    var
                    indexedTypeParameters = f_10054_101301_101339(arity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101360, 101445);

                    var
                    typeMap1 = f_10054_101375_101444(typeParameters1, indexedTypeParameters, allowAlpha: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101463, 101548);

                    var
                    typeMap2 = f_10054_101478_101547(typeParameters2, indexedTypeParameters, allowAlpha: true)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101639, 101644);

                        // Report any mismatched method constraints.
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101630, 103620) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101657, 101660)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 101630, 103620))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 101630, 103620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101702, 101742);

                            var
                            typeParameter1 = typeParameters1[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101764, 101804);

                            var
                            typeParameter2 = typeParameters2[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 101828, 103601) || true) && (!f_10054_101833_101928(typeParameter1, typeMap1, typeParameter2, typeMap2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 101828, 103601);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 102852, 103069);

                                f_10054_102852_103068(                        // If the matching method for the interface member is defined on the implementing type,
                                                                              // the matching method location is used for the error. Otherwise, the location of the
                                                                              // implementing type is used. (This differs from Dev10 which associates the error with
                                                                              // the closest method always. That behavior can be confusing though, since in the case
                                                                              // of "interface I { M; } class A { M; } class B : A, I { }", this means reporting an error on
                                                                              // A.M that it does not satisfy I.M even though A does not implement I. Furthermore if
                                                                              // A is defined in metadata, there is no location for A.M. Instead, we simply report the
                                                                              // error on B if the match to I.M is in a base class.)
                                                        diagnostics, ErrorCode.ERR_ImplBadConstraints, f_10054_102902_102994(interfaceMethod, implementingType, implicitImpl), f_10054_102996_103015(typeParameter2), implicitImpl, f_10054_103031_103050(typeParameter1), interfaceMethod);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 101828, 103601);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 101828, 103601);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 103119, 103601) || true) && (!f_10054_103124_103232(typeParameter1, typeMap1, typeParameter2, typeMap2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 103119, 103601);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 103282, 103578);

                                    f_10054_103282_103577(diagnostics, ErrorCode.WRN_NullabilityMismatchInConstraintsOnImplicitImplementation, f_10054_103370_103462(interfaceMethod, implementingType, implicitImpl), f_10054_103505_103524(typeParameter2), implicitImpl, f_10054_103540_103559(typeParameter1), interfaceMethod);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 103119, 103601);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 101828, 103601);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 1991);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 1991);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 101087, 103635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 103651, 103665);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 100741, 103676);

                int
                f_10054_100942_100963(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 100942, 100963);
                    return return_v;
                }


                int
                f_10054_100967_100985(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 100967, 100985);
                    return return_v;
                }


                int
                f_10054_100929_100986(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 100929, 100986);
                    return 0;
                }


                int
                f_10054_101049_101070(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 101049, 101070);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10054_101156_101186(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 101156, 101186);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10054_101227_101254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 101227, 101254);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10054_101301_101339(int
                count)
                {
                    var return_v = IndexedTypeParameterSymbol.Take(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 101301, 101339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10054_101375_101444(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 101375, 101444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10054_101478_101547(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 101478, 101547);
                    return return_v;
                }


                bool
                f_10054_101833_101928(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = MemberSignatureComparer.HaveSameConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 101833, 101928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_102902_102994(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, implementingType, (Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 102902, 102994);
                    return return_v;
                }


                string
                f_10054_102996_103015(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 102996, 103015);
                    return return_v;
                }


                string
                f_10054_103031_103050(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 103031, 103050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_102852_103068(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 102852, 103068);
                    return return_v;
                }


                bool
                f_10054_103124_103232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = MemberSignatureComparer.HaveSameNullabilityInConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 103124, 103232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10054_103370_103462(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation((Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, implementingType, (Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 103370, 103462);
                    return return_v;
                }


                string
                f_10054_103505_103524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 103505, 103524);
                    return return_v;
                }


                string
                f_10054_103540_103559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 103540, 103559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10054_103282_103577(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 103282, 103577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 100741, 103676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 100741, 103676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Location GetImplicitImplementationDiagnosticLocation(Symbol interfaceMember, TypeSymbol implementingType, Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 103688, 104354);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 103849, 104343) || true) && (f_10054_103853_103948(f_10054_103871_103892(member), implementingType, TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 103849, 104343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 103982, 104009);

                    return f_10054_103989_104005(member)[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 103849, 104343);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 103849, 104343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 104075, 104123);

                    var
                    @interface = f_10054_104092_104122(interfaceMember)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 104141, 104231);

                    SourceMemberContainerTypeSymbol
                    snt = implementingType as SourceMemberContainerTypeSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 104249, 104328);

                    return f_10054_104256_104294_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(snt, 10054, 104256, 104294)?.GetImplementsLocation(@interface)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10054, 104256, 104327) ?? f_10054_104298_104324(implementingType)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 103849, 104343);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 103688, 104354);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_103871_103892(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 103871, 103892);
                    return return_v;
                }


                bool
                f_10054_103853_103948(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 103853, 103948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10054_103989_104005(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 103989, 104005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_104092_104122(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 104092, 104122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10054_104256_104294_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 104256, 104294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10054_104298_104324(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 104298, 104324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 103688, 104354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 103688, 104354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FindPotentialImplicitImplementationMemberDeclaredInType(
                    Symbol interfaceMember,
                    bool implementingTypeIsFromSomeCompilation,
                    TypeSymbol currType,
                    out Symbol implicitImpl,
                    out Symbol closeMismatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 105729, 107750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106035, 106055);

                implicitImpl = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106069, 106090);

                closeMismatch = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106106, 107739);
                    foreach (Symbol member in f_10054_106132_106173_I(f_10054_106132_106173(currType, f_10054_106152_106172(interfaceMember))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 106106, 107739);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106207, 107724) || true) && (f_10054_106211_106222(member) == f_10054_106226_106246(interfaceMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 106207, 107724);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106288, 107705) || true) && (f_10054_106292_106387(member, interfaceMember, implementingTypeIsFromSomeCompilation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 106288, 107705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106437, 106459);

                                implicitImpl = member;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106485, 106492);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 106288, 107705);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 106288, 107705);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 106939, 107705) || true) && ((object)closeMismatch == null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 106943, 107013) && implementingTypeIsFromSomeCompilation) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 106943, 107108) && f_10054_107047_107084(interfaceMember) == Accessibility.Public) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 106943, 107212) && !f_10054_107143_107212(interfaceMember)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 106939, 107705);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 107473, 107682) || true) && (f_10054_107477_107574(MemberSignatureComparer.CSharpCloseImplicitImplementationComparer, interfaceMember, member))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 107473, 107682);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 107632, 107655);

                                        closeMismatch = member;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 107473, 107682);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 106939, 107705);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 106288, 107705);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 106207, 107724);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 106106, 107739);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 1634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 1634);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 105729, 107750);

                string
                f_10054_106152_106172(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 106152, 106172);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_106132_106173(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 106132, 106173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_106211_106222(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 106211, 106222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_106226_106246(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 106226, 106246);
                    return return_v;
                }


                bool
                f_10054_106292_106387(Microsoft.CodeAnalysis.CSharp.Symbol
                candidateMember, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, bool
                implementingTypeIsFromSomeCompilation)
                {
                    var return_v = IsInterfaceMemberImplementation(candidateMember, interfaceMember, implementingTypeIsFromSomeCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 106292, 106387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10054_107047_107084(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 107047, 107084);
                    return return_v;
                }


                bool
                f_10054_107143_107212(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsEventOrPropertyWithImplementableNonPublicAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 107143, 107212);
                    return return_v;
                }


                bool
                f_10054_107477_107574(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 107477, 107574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_106132_106173_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 106132, 106173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 105729, 107750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 105729, 107750);
            }
        }

        private static bool IsInterfaceMemberImplementation(Symbol candidateMember, Symbol interfaceMember, bool implementingTypeIsFromSomeCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 109698, 111540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 109866, 111529) || true) && (f_10054_109870_109907(candidateMember) != Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10054, 109870, 109959) || f_10054_109935_109959(candidateMember)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 109866, 111529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 109993, 110006);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 109866, 111529);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 109866, 111529);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 110040, 111529) || true) && (f_10054_110044_110098(candidateMember, interfaceMember))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 110040, 111529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 110132, 110145);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 110040, 111529);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 110040, 111529);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 110179, 111529) || true) && (implementingTypeIsFromSomeCompilation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 110179, 111529);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 110691, 110800);

                            return f_10054_110698_110799(MemberSignatureComparer.CSharpImplicitImplementationComparer, interfaceMember, candidateMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 110179, 111529);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 110179, 111529);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111404, 111514);

                            return f_10054_111411_111513(MemberSignatureComparer.RuntimeImplicitImplementationComparer, interfaceMember, candidateMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 110179, 111529);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 110040, 111529);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 109866, 111529);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 109698, 111540);

                Microsoft.CodeAnalysis.Accessibility
                f_10054_109870_109907(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 109870, 109907);
                    return return_v;
                }


                bool
                f_10054_109935_109959(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 109935, 109959);
                    return return_v;
                }


                bool
                f_10054_110044_110098(Microsoft.CodeAnalysis.CSharp.Symbol
                one, Microsoft.CodeAnalysis.CSharp.Symbol
                other)
                {
                    var return_v = HaveInitOnlyMismatch(one, other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 110044, 110098);
                    return return_v;
                }


                bool
                f_10054_110698_110799(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 110698, 110799);
                    return return_v;
                }


                bool
                f_10054_111411_111513(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 111411, 111513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 109698, 111540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 109698, 111540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected MultiDictionary<Symbol, Symbol>.ValueSet GetExplicitImplementationForInterfaceMember(Symbol interfaceMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 111552, 112162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111695, 111730);

                var
                info = f_10054_111706_111729(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111744, 111834) || true) && (info == s_noInterfaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 111744, 111834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111804, 111819);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 111744, 111834);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111850, 112071) || true) && (info.explicitInterfaceImplementationMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 111850, 112071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 111935, 112056);

                    f_10054_111935_112055(ref info.explicitInterfaceImplementationMap, f_10054_112008_112048(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 111850, 112071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112087, 112151);

                return f_10054_112094_112150(info.explicitInterfaceImplementationMap, interfaceMember);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 111552, 112162);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
                f_10054_111706_111729(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfaceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 111706, 111729);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112008_112048(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.MakeExplicitInterfaceImplementationMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112008, 112048);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                f_10054_111935_112055(ref Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                location1, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                value, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 111935, 112055);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10054_112094_112150(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 112094, 112150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 111552, 112162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 111552, 112162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MultiDictionary<Symbol, Symbol> MakeExplicitInterfaceImplementationMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 112174, 112869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112279, 112395);

                var
                map = f_10054_112289_112394(ExplicitInterfaceImplementationTargetMemberEqualityComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112409, 112833);
                    foreach (var member in f_10054_112432_112458_I(f_10054_112432_112458(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 112409, 112833);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112492, 112818);
                            foreach (var interfaceMember in f_10054_112524_112568_I(f_10054_112524_112568(member)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 112492, 112818);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112610, 112744);

                                f_10054_112610_112743(f_10054_112623_112643(interfaceMember) != SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10054, 112623, 112742) || (object)interfaceMember == f_10054_112695_112742(((MethodSymbol)interfaceMember))));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112766, 112799);

                                f_10054_112766_112798(map, interfaceMember, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 112492, 112818);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 327);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 327);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 112409, 112833);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 112847, 112858);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 112174, 112869);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112289_112394(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.ExplicitInterfaceImplementationTargetMemberEqualityComparer
                comparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112289, 112394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112432_112458(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112432, 112458);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112524_112568(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetExplicitInterfaceImplementations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112524, 112568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_112623_112643(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 112623, 112643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_112695_112742(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 112695, 112742);
                    return return_v;
                }


                int
                f_10054_112610_112743(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112610, 112743);
                    return 0;
                }


                bool
                f_10054_112766_112798(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                k, Microsoft.CodeAnalysis.CSharp.Symbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112766, 112798);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112524_112568_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112524, 112568);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_112432_112458_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 112432, 112458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 112174, 112869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 112174, 112869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        protected class ExplicitInterfaceImplementationTargetMemberEqualityComparer : IEqualityComparer<Symbol>
        {
            public static readonly ExplicitInterfaceImplementationTargetMemberEqualityComparer Instance;

            private ExplicitInterfaceImplementationTargetMemberEqualityComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10054, 113185, 113258);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10054, 113185, 113258);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 113185, 113258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 113185, 113258);
                }
            }

            public bool Equals(Symbol x, Symbol y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 113272, 113523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 113343, 113508);

                    return f_10054_113350_113370(x) == f_10054_113374_113394(y) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 113350, 113507) && f_10054_113422_113507(f_10054_113422_113438(x), f_10054_113446_113462(y), TypeCompareKind.CLRSignatureCompareOptions));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 113272, 113523);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10054_113350_113370(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 113350, 113370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10054_113374_113394(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 113374, 113394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10054_113422_113438(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 113422, 113438);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10054_113446_113462(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 113446, 113462);
                        return return_v;
                    }


                    bool
                    f_10054_113422_113507(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 113422, 113507);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 113272, 113523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 113272, 113523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(Symbol obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 113539, 113665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 113606, 113650);

                    return f_10054_113613_113649(f_10054_113613_113635(obj));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 113539, 113665);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10054_113613_113635(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 113613, 113635);
                        return return_v;
                    }


                    int
                    f_10054_113613_113649(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 113613, 113649);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 113539, 113665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 113539, 113665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ExplicitInterfaceImplementationTargetMemberEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10054, 112881, 113676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 113092, 113168);
                Instance = f_10054_113103_113168(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10054, 112881, 113676);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 112881, 113676);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10054, 112881, 113676);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.ExplicitInterfaceImplementationTargetMemberEqualityComparer
            f_10054_113103_113168()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.ExplicitInterfaceImplementationTargetMemberEqualityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 113103, 113168);
                return return_v;
            }

        }

        internal ImmutableHashSet<Symbol> AbstractMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 114013, 114289);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114049, 114228) || true) && (_lazyAbstractMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114049, 114228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114123, 114209);

                        f_10054_114123_114208(ref _lazyAbstractMembers, f_10054_114177_114201(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114049, 114228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114246, 114274);

                    return _lazyAbstractMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 114013, 114289);

                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10054_114177_114201(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ComputeAbstractMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114177, 114201);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    f_10054_114123_114208(ref System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    location1, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    value, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114123, 114208);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 113939, 114300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 113939, 114300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableHashSet<Symbol> ComputeAbstractMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 114312, 116344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114394, 114450);

                var
                abstractMembers = f_10054_114416_114449()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114464, 114522);

                var
                overriddenMembers = f_10054_114488_114521()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114538, 115801);
                    foreach (var member in f_10054_114561_114587_I(f_10054_114561_114587(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114538, 115801);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114621, 114807) || true) && (f_10054_114625_114640(this) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 114625, 114661) && f_10054_114644_114661(member)) && (DynAbs.Tracing.TraceSender.Expression_True(10054, 114625, 114700) && f_10054_114665_114676(member) != SymbolKind.NamedType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114621, 114807);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114742, 114788);

                            abstractMembers = f_10054_114760_114787(abstractMembers, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114621, 114807);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114827, 114858);

                        Symbol
                        overriddenMember = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 114876, 115609);

                        switch (f_10054_114884_114895(member))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114876, 115609);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115017, 115076);

                                    overriddenMember = f_10054_115036_115075(((MethodSymbol)member));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 115106, 115112);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114876, 115609);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114876, 115609);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115243, 115306);

                                    overriddenMember = f_10054_115262_115305(((PropertySymbol)member));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 115336, 115342);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114876, 115609);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 114876, 115609);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115470, 115527);

                                    overriddenMember = f_10054_115489_115526(((EventSymbol)member));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10054, 115557, 115563);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114876, 115609);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115629, 115786) || true) && ((object)overriddenMember != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 115629, 115786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115707, 115767);

                            overriddenMembers = f_10054_115727_115766(overriddenMembers, overriddenMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 115629, 115786);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 114538, 115801);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 1264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 1264);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115817, 116294) || true) && ((object)f_10054_115829_115862(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(10054, 115821, 115918) && f_10054_115874_115918(f_10054_115874_115907(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 115817, 116294);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 115952, 116279);
                        foreach (var baseAbstractMember in f_10054_115987_116036_I(f_10054_115987_116036(f_10054_115987_116020(this))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 115952, 116279);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116078, 116260) || true) && (!f_10054_116083_116129(overriddenMembers, baseAbstractMember))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 116078, 116260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116179, 116237);

                                abstractMembers = f_10054_116197_116236(abstractMembers, baseAbstractMember);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 116078, 116260);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 115952, 116279);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10054, 1, 328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10054, 1, 328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 115817, 116294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116310, 116333);

                return abstractMembers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 114312, 116344);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_114416_114449()
                {
                    var return_v = ImmutableHashSet.Create<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114416, 114449);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_114488_114521()
                {
                    var return_v = ImmutableHashSet.Create<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114488, 114521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_114561_114587(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114561, 114587);
                    return return_v;
                }


                bool
                f_10054_114625_114640(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 114625, 114640);
                    return return_v;
                }


                bool
                f_10054_114644_114661(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 114644, 114661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_114665_114676(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 114665, 114676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_114760_114787(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114760, 114787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10054_114884_114895(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 114884, 114895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10054_115036_115075(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115036, 115075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10054_115262_115305(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115262, 115305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10054_115489_115526(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115489, 115526);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_115727_115766(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 115727, 115766);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_114561_114587_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 114561, 114587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_115829_115862(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115829, 115862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_115874_115907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115874, 115907);
                    return return_v;
                }


                bool
                f_10054_115874_115918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115874, 115918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10054_115987_116020(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115987, 116020);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_115987_116036(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AbstractMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 115987, 116036);
                    return return_v;
                }


                bool
                f_10054_116083_116129(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 116083, 116129);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_116197_116236(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 116197, 116236);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10054_115987_116036_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 115987, 116036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 114312, 116344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 114312, 116344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use TypeWithAnnotations.Is method.", true)]
        internal bool Equals(TypeWithAnnotations other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 116404, 116588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116540, 116577);

                throw f_10054_116546_116576();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 116404, 116588);

                System.Exception
                f_10054_116546_116576()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 116546, 116576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 116404, 116588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 116404, 116588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Equals(TypeSymbol left, TypeSymbol right, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10054, 116600, 116864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116713, 116799) || true) && (left is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 116713, 116799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116763, 116784);

                    return right is null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 116713, 116799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 116815, 116853);

                return f_10054_116822_116852(left, right, comparison);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10054, 116600, 116864);

                bool
                f_10054_116822_116852(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 116822, 116852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 116600, 116864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 116600, 116864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator ==(TypeSymbol left, TypeSymbol right)
            => throw f_10054_117066_117096();

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator !=(TypeSymbol left, TypeSymbol right)
            => throw f_10054_117299_117329();

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator ==(Symbol left, TypeSymbol right)
            => throw f_10054_117528_117558();

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator !=(Symbol left, TypeSymbol right)
            => throw f_10054_117757_117787();

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator ==(TypeSymbol left, Symbol right)
            => throw f_10054_117986_118016();

        [Obsolete("Use 'TypeSymbol.Equals(TypeSymbol, TypeSymbol, TypeCompareKind)' method.", true)]
        public static bool operator !=(TypeSymbol left, Symbol right)
            => throw f_10054_118215_118245();

        internal ITypeSymbol GetITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 118258, 118575);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118370, 118503) || true) && (nullableAnnotation == f_10054_118396_118421())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10054, 118370, 118503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118455, 118488);

                    return (ITypeSymbol)f_10054_118475_118487(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10054, 118370, 118503);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118519, 118564);

                return f_10054_118526_118563(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 118258, 118575);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10054_118396_118421()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 118396, 118421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10054_118475_118487(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 118475, 118487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10054_118526_118563(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.CreateITypeSymbol(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 118526, 118563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 118258, 118575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 118258, 118575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CodeAnalysis.NullableAnnotation DefaultNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 118654, 118740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118657, 118740);
                    return f_10054_118657_118740(this, NullableAnnotation.Oblivious); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 118654, 118740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 118654, 118740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 118654, 118740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation);

        TypeKind ITypeSymbolInternal.TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 118904, 118920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118907, 118920);
                    return f_10054_118907_118920(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 118904, 118920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 118904, 118920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 118904, 118920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        SpecialType ITypeSymbolInternal.SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 118977, 118996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 118980, 118996);
                    return f_10054_118980_118996(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 118977, 118996);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 118977, 118996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 118977, 118996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbolInternal.IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 119050, 119073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 119053, 119073);
                    return f_10054_119053_119073(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 119050, 119073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 119050, 119073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 119050, 119073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbolInternal.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 119123, 119142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 119126, 119142);
                    return f_10054_119126_119142(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 119123, 119142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 119123, 119142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 119123, 119142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol ITypeSymbolInternal.GetITypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10054, 119155, 119288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 119228, 119277);

                return f_10054_119235_119276(this, f_10054_119250_119275());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10054, 119155, 119288);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10054_119250_119275()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 119250, 119275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10054_119235_119276(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.GetITypeSymbol(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 119235, 119276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10054, 119155, 119288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 119155, 119288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool IsRecord { get; }

        static TypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10054, 802, 119347);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 1409, 1451);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 1606, 1642);
            s_noInterfaces = f_10054_1623_1642(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10054, 26917, 27011);
            s_setUnknownNullability = (type) => type.SetUnknownNullabilityForReferenceTypes(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10054, 802, 119347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10054, 802, 119347);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10054, 802, 119347);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo
        f_10054_1623_1642()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.InterfaceInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 1623, 1642);
            return return_v;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10054_21722_21730()
        {
            var return_v = TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 21722, 21730);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10054_21972_21983()
        {
            var return_v = SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 21972, 21983);
            return return_v;
        }


        Microsoft.Cci.PrimitiveTypeCode
        f_10054_21947_21984(Microsoft.CodeAnalysis.SpecialType
        typeId)
        {
            var return_v = SpecialTypes.GetTypeCode(typeId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 21947, 21984);
            return return_v;
        }


        static System.Exception
        f_10054_117066_117096()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 117066, 117096);
            return return_v;
        }


        static System.Exception
        f_10054_117299_117329()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 117299, 117329);
            return return_v;
        }


        static System.Exception
        f_10054_117528_117558()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 117528, 117558);
            return return_v;
        }


        static System.Exception
        f_10054_117757_117787()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 117757, 117787);
            return return_v;
        }


        static System.Exception
        f_10054_117986_118016()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 117986, 118016);
            return return_v;
        }


        static System.Exception
        f_10054_118215_118245()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 118215, 118245);
            return return_v;
        }


        Microsoft.CodeAnalysis.NullableAnnotation
        f_10054_118657_118740(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, Microsoft.CodeAnalysis.CSharp.NullableAnnotation
        annotation)
        {
            var return_v = NullableAnnotationExtensions.ToPublicAnnotation(type, annotation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10054, 118657, 118740);
            return return_v;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10054_118907_118920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 118907, 118920);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10054_118980_118996(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 118980, 118996);
            return return_v;
        }


        bool
        f_10054_119053_119073(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsReferenceType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 119053, 119073);
            return return_v;
        }


        bool
        f_10054_119126_119142(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsValueType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10054, 119126, 119142);
            return return_v;
        }

    }
}
