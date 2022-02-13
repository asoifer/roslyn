// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SubstitutedNamedTypeSymbol : WrappedNamedTypeSymbol
    {
        private static readonly Func<Symbol, NamedTypeSymbol, Symbol> s_symbolAsMemberFunc;

        private readonly bool _unbound;

        private readonly TypeMap _inputMap;

        private readonly Symbol _newContainer;

        private TypeMap _lazyMap;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private int _hashCode;

        private ConcurrentCache<string, ImmutableArray<Symbol>> _lazyMembersByNameCache;

        protected SubstitutedNamedTypeSymbol(Symbol newContainer, TypeMap map, NamedTypeSymbol originalDefinition, NamedTypeSymbol constructedFrom = null, bool unbound = false, TupleExtraData tupleData = null)
        : base(f_10159_2246_2264_C(originalDefinition), tupleData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10159, 2024, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 995, 1003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 1039, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 1675, 1688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 1717, 1725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 1855, 1864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 1988, 2011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2301, 2347);

                f_10159_2301_2346(f_10159_2314_2345(originalDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2361, 2409);

                f_10159_2361_2408(!f_10159_2375_2407(originalDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2423, 2452);

                _newContainer = newContainer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2466, 2482);

                _inputMap = map;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2496, 2515);

                _unbound = unbound;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2702, 2970) || true) && ((object)constructedFrom != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 2702, 2970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2771, 2851);

                    f_10159_2771_2850(f_10159_2784_2849(f_10159_2800_2831(constructedFrom), constructedFrom));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2869, 2922);

                    _lazyTypeParameters = f_10159_2891_2921(constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 2940, 2955);

                    _lazyMap = map;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 2702, 2970);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10159, 2024, 2981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 2024, 2981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 2024, 2981);
            }
        }

        public sealed override bool IsUnboundGenericType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 3066, 3133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3102, 3118);

                    return _unbound;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 3066, 3133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 2993, 3144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 2993, 3144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeMap Map
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 3200, 3314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3236, 3265);

                    f_10159_3236_3264(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3283, 3299);

                    return _lazyMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 3200, 3314);

                    int
                    f_10159_3236_3264(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        this_param.EnsureMapAndTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 3236, 3264);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 3156, 3325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 3156, 3325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 3435, 3560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3471, 3500);

                    f_10159_3471_3499(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3518, 3545);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 3435, 3560);

                    int
                    f_10159_3471_3499(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        this_param.EnsureMapAndTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 3471, 3499);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 3337, 3571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 3337, 3571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureMapAndTypeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 3583, 4636);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3649, 3739) || true) && (f_10159_3653_3683_M(!_lazyTypeParameters.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 3649, 3739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3717, 3724);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 3649, 3739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3755, 3806);

                ImmutableArray<TypeParameterSymbol>
                typeParameters
                = default(ImmutableArray<TypeParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 3924, 4009);

                var
                newMap = f_10159_3937_4008(_inputMap, f_10159_3963_3981(), this, out typeParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4025, 4095);

                var
                prevMap = f_10159_4039_4094(ref _lazyMap, newMap, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4109, 4418) || true) && (prevMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 4109, 4418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4318, 4403);

                    typeParameters = f_10159_4335_4402(prevMap, f_10159_4368_4401(f_10159_4368_4386()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 4109, 4418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4434, 4569);

                f_10159_4434_4568(ref _lazyTypeParameters, typeParameters, default(ImmutableArray<TypeParameterSymbol>));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4583, 4625);

                f_10159_4583_4624(_lazyTypeParameters != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 3583, 4636);

                bool
                f_10159_3653_3683_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 3653, 3683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_3963_3981()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 3963, 3981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10159_3937_4008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                newTypeParameters)
                {
                    var return_v = this_param.WithAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner, out newTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 3937, 4008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10159_4039_4094(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 4039, 4094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_4368_4386()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 4368, 4386);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10159_4368_4401(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 4368, 4401);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10159_4335_4402(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                original)
                {
                    var return_v = this_param.SubstituteTypeParameters(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 4335, 4402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10159_4434_4568(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 4434, 4568);
                    return return_v;
                }


                int
                f_10159_4583_4624(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 4583, 4624);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 3583, 4636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 3583, 4636);
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 4719, 4748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4725, 4746);

                    return _newContainer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 4719, 4748);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 4648, 4759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 4648, 4759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 4842, 4933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 4878, 4918);

                    return _newContainer as NamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 4842, 4933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 4771, 4944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 4771, 4944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5019, 5058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 5025, 5056);

                    return f_10159_5032_5055(f_10159_5032_5050());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5019, 5058);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_5032_5050()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5032, 5050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10159_5032_5055(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5032, 5055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 4956, 5069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 4956, 5069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override NamedTypeSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5163, 5194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 5169, 5192);

                    return _underlyingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5163, 5194);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 5081, 5205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 5081, 5205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5217, 5463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 5343, 5452);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10159, 5350, 5358) || ((_unbound && DynAbs.Tracing.TraceSender.Conditional_F2(10159, 5361, 5365)) || DynAbs.Tracing.TraceSender.Conditional_F3(10159, 5368, 5451))) ? null : f_10159_5368_5451(f_10159_5368_5371(), f_10159_5392_5450(f_10159_5392_5410(), basesBeingResolved));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5217, 5463);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10159_5368_5371()
                {
                    var return_v = Map;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5368, 5371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_5392_5410()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5392, 5410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_5392_5450(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 5392, 5450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_5368_5451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 5368, 5451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 5217, 5463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 5217, 5463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5475, 5775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 5619, 5764);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10159, 5626, 5634) || ((_unbound && DynAbs.Tracing.TraceSender.Conditional_F2(10159, 5637, 5674)) || DynAbs.Tracing.TraceSender.Conditional_F3(10159, 5677, 5763))) ? ImmutableArray<NamedTypeSymbol>.Empty : f_10159_5677_5763(f_10159_5677_5680(), f_10159_5702_5762(f_10159_5702_5720(), basesBeingResolved));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5475, 5775);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10159_5677_5680()
                {
                    var return_v = Map;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5677, 5680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_5702_5720()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5702, 5720);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_5702_5762(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 5702, 5762);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_5677_5763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                original)
                {
                    var return_v = this_param.SubstituteNamedTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 5677, 5763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 5475, 5775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 5475, 5775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5870, 5963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 5873, 5963);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10159, 5873, 5881) || ((_unbound && DynAbs.Tracing.TraceSender.Conditional_F2(10159, 5884, 5888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10159, 5891, 5963))) ? null : f_10159_5891_5963(f_10159_5891_5894(), f_10159_5915_5962(f_10159_5915_5933())); DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5870, 5963);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 5870, 5963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 5870, 5963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 5976, 6294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6129, 6283);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10159, 6136, 6144) || ((_unbound && DynAbs.Tracing.TraceSender.Conditional_F2(10159, 6147, 6184)) || DynAbs.Tracing.TraceSender.Conditional_F3(10159, 6187, 6282))) ? ImmutableArray<NamedTypeSymbol>.Empty : f_10159_6187_6282(f_10159_6187_6190(), f_10159_6212_6281(f_10159_6212_6230(), basesBeingResolved));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 5976, 6294);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10159_6187_6190()
                {
                    var return_v = Map;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6187, 6190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_6212_6230()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6212, 6230);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_6212_6281(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6212, 6281);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_6187_6282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                original)
                {
                    var return_v = this_param.SubstituteNamedTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6187, 6282);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 5976, 6294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 5976, 6294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 6306, 6450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6402, 6439);

                throw f_10159_6408_6438();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 6306, 6450);

                System.Exception
                f_10159_6408_6438()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6408, 6438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 6306, 6450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 6306, 6450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 6541, 6952);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6577, 6732) || true) && (_unbound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 6577, 6732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6631, 6713);

                        return f_10159_6638_6712(f_10159_6655_6711(f_10159_6655_6680(this).Select(s => s.Name)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 6577, 6732);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6752, 6879) || true) && (f_10159_6756_6767())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 6752, 6879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6809, 6860);

                        return f_10159_6816_6859(f_10159_6816_6828(this).Select(s => s.Name));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 6752, 6879);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 6899, 6937);

                    return f_10159_6906_6936(f_10159_6906_6924());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 6541, 6952);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10159_6655_6680(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeMembersUnordered();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6655, 6680);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_10159_6655_6711(System.Collections.Generic.IEnumerable<string>
                    source)
                    {
                        var return_v = source.Distinct<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6655, 6711);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_10159_6638_6712(System.Collections.Generic.IEnumerable<string>
                    collection)
                    {
                        var return_v = new System.Collections.Generic.List<string>(collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6638, 6712);
                        return return_v;
                    }


                    bool
                    f_10159_6756_6767()
                    {
                        var return_v = IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6756, 6767);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10159_6816_6828(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6816, 6828);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_10159_6816_6859(System.Collections.Generic.IEnumerable<string>
                    source)
                    {
                        var return_v = source.Distinct<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 6816, 6859);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_6906_6924()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6906, 6924);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_10159_6906_6936(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MemberNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 6906, 6936);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 6462, 6963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 6462, 6963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 6975, 7127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 7074, 7116);

                return f_10159_7081_7115(f_10159_7081_7099());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 6975, 7127);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_7081_7099()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 7081, 7099);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10159_7081_7115(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 7081, 7115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 6975, 7127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 6975, 7127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 7139, 7360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 7246, 7349);

                return f_10159_7253_7297(f_10159_7253_7271()).SelectAsArray((t, self) => t.AsMember(self), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 7139, 7360);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_7253_7271()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 7253, 7271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_7253_7297(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 7253, 7297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 7139, 7360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 7139, 7360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 7372, 7573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 7468, 7562);

                return f_10159_7475_7510(f_10159_7475_7493()).SelectAsArray((t, self) => t.AsMember(self), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 7372, 7573);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_7475_7493()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 7475, 7493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_7475_7510(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 7475, 7510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 7372, 7573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 7372, 7573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 7585, 7801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 7692, 7790);

                return f_10159_7699_7738(f_10159_7699_7717(), name).SelectAsArray((t, self) => t.AsMember(self), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 7585, 7801);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_7699_7717()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 7699, 7717);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_7699_7738(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 7699, 7738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 7585, 7801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 7585, 7801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 7813, 8047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 7931, 8036);

                return f_10159_7938_7984(f_10159_7938_7956(), name, arity).SelectAsArray((t, self) => t.AsMember(self), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 7813, 8047);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_7938_7956()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 7938, 7956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_7938_7984(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 7938, 7984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 7813, 8047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 7813, 8047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 8059, 9048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8142, 8191);

                var
                builder = f_10159_8156_8190()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8207, 8793) || true) && (_unbound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8207, 8793);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8300, 8566);
                        foreach (var t in f_10159_8318_8349_I(f_10159_8318_8349(f_10159_8318_8336())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8300, 8566);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8391, 8547) || true) && (f_10159_8395_8401(t) == SymbolKind.NamedType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8391, 8547);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8475, 8524);

                                f_10159_8475_8523(builder, f_10159_8487_8522(((NamedTypeSymbol)t), this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8391, 8547);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8300, 8566);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8207, 8793);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8207, 8793);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8632, 8778);
                        foreach (var t in f_10159_8650_8681_I(f_10159_8650_8681(f_10159_8650_8668())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8632, 8778);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8723, 8759);

                            f_10159_8723_8758(builder, f_10159_8735_8757(t, this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8632, 8778);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 147);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8207, 8793);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8809, 8985) || true) && (f_10159_8813_8824())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 8809, 8985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8858, 8920);

                    builder = f_10159_8868_8919(this, f_10159_8890_8918(builder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 8938, 8970);

                    f_10159_8938_8969(builder is object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 8809, 8985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9001, 9037);

                return f_10159_9008_9036(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 8059, 9048);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8156_8190()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8156, 8190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_8318_8336()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 8318, 8336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8318_8349(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8318, 8349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10159_8395_8401(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 8395, 8401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_8487_8522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8487, 8522);
                    return return_v;
                }


                int
                f_10159_8475_8523(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8475, 8523);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8318_8349_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8318, 8349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_8650_8668()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 8650, 8668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8650_8681(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8650, 8681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10159_8735_8757(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8735, 8757);
                    return return_v;
                }


                int
                f_10159_8723_8758(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8723, 8758);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8650_8681_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8650, 8681);
                    return return_v;
                }


                bool
                f_10159_8813_8824()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 8813, 8824);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8890_8918(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8890, 8918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_8868_8919(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                currentMembers)
                {
                    var return_v = this_param.AddOrWrapTupleMembers(currentMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8868, 8919);
                    return return_v;
                }


                int
                f_10159_8938_8969(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 8938, 8969);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9008_9036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9008, 9036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 8059, 9048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 8059, 9048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<Symbol> GetMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 9060, 10031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9154, 9203);

                var
                builder = f_10159_9168_9202()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9219, 9776) || true) && (_unbound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9219, 9776);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9265, 9540);
                        foreach (var t in f_10159_9283_9323_I(f_10159_9283_9323(f_10159_9283_9301())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9265, 9540);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9365, 9521) || true) && (f_10159_9369_9375(t) == SymbolKind.NamedType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9365, 9521);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9449, 9498);

                                f_10159_9449_9497(builder, f_10159_9461_9496(((NamedTypeSymbol)t), this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9365, 9521);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9265, 9540);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 276);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9219, 9776);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9219, 9776);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9606, 9761);
                        foreach (var t in f_10159_9624_9664_I(f_10159_9624_9664(f_10159_9624_9642())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9606, 9761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9706, 9742);

                            f_10159_9706_9741(builder, f_10159_9718_9740(t, this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9606, 9761);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 156);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9219, 9776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9792, 9968) || true) && (f_10159_9796_9807())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 9792, 9968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9841, 9903);

                    builder = f_10159_9851_9902(this, f_10159_9873_9901(builder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9921, 9953);

                    f_10159_9921_9952(builder is object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 9792, 9968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 9984, 10020);

                return f_10159_9991_10019(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 9060, 10031);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9168_9202()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9168, 9202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_9283_9301()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 9283, 9301);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9283_9323(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9283, 9323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10159_9369_9375(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 9369, 9375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_9461_9496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9461, 9496);
                    return return_v;
                }


                int
                f_10159_9449_9497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9449, 9497);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9283_9323_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9283, 9323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_9624_9642()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 9624, 9642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9624_9664(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9624, 9664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10159_9718_9740(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9718, 9740);
                    return return_v;
                }


                int
                f_10159_9706_9741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9706, 9741);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9624_9664_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9624, 9664);
                    return return_v;
                }


                bool
                f_10159_9796_9807()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 9796, 9807);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9873_9901(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9873, 9901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9851_9902(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                currentMembers)
                {
                    var return_v = this_param.AddOrWrapTupleMembers(currentMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9851, 9902);
                    return return_v;
                }


                int
                f_10159_9921_9952(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9921, 9952);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_9991_10019(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 9991, 10019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 9060, 10031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 9060, 10031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 10043, 10490);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10137, 10204) || true) && (_unbound)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 10137, 10204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10151, 10204);

                    return f_10159_10158_10203(f_10159_10182_10202(this, name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 10137, 10204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10220, 10250);

                ImmutableArray<Symbol>
                result
                = default(ImmutableArray<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10264, 10300);

                var
                cache = _lazyMembersByNameCache
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10314, 10433) || true) && (cache != null && (DynAbs.Tracing.TraceSender.Expression_True(10159, 10318, 10370) && f_10159_10335_10370(cache, name, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 10314, 10433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10404, 10418);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 10314, 10433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10449, 10479);

                return f_10159_10456_10478(this, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 10043, 10490);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10159_10182_10202(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10182, 10202);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_10158_10203(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10158, 10203);
                    return return_v;
                }


                bool
                f_10159_10335_10370(Microsoft.CodeAnalysis.ConcurrentCache<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10335, 10370);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_10456_10478(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembersWorker(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10456, 10478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 10043, 10490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 10043, 10490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> GetMembersWorker(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 10502, 11952);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10587, 10801) || true) && (f_10159_10591_10602())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 10587, 10801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10636, 10710);

                    var
                    result = f_10159_10649_10661(this).WhereAsArray((m, name) => m.Name == name, name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10728, 10754);

                    f_10159_10728_10753(result, name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10772, 10786);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 10587, 10801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10817, 10875);

                var
                originalMembers = f_10159_10839_10874(f_10159_10839_10857(), name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10889, 10997) || true) && (originalMembers.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 10889, 10997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 10959, 10982);

                    return originalMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 10889, 10997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11013, 11084);

                var
                builder = f_10159_11027_11083(originalMembers.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11098, 11216);
                    foreach (var t in f_10159_11116_11131_I(originalMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 11098, 11216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11165, 11201);

                        f_10159_11165_11200(builder, f_10159_11177_11199(t, this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 11098, 11216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11232, 11286);

                var
                substitutedMembers = f_10159_11257_11285(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11300, 11338);

                f_10159_11300_11337(substitutedMembers, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11352, 11378);

                return substitutedMembers;

                void cacheResult(ImmutableArray<Symbol> result, string name2)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 11417, 11941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11727, 11878);

                        var
                        cache = _lazyMembersByNameCache ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConcurrentCache<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>>(10159, 11739, 11877) ?? (_lazyMembersByNameCache = f_10159_11822_11876(8)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 11898, 11926);

                        f_10159_11898_11925(
                                        cache, name2, result);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 11417, 11941);

                        Microsoft.CodeAnalysis.ConcurrentCache<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                        f_10159_11822_11876(int
                        size)
                        {
                            var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>(size);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11822, 11876);
                            return return_v;
                        }


                        bool
                        f_10159_11898_11925(Microsoft.CodeAnalysis.ConcurrentCache<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
                        this_param, string
                        key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        value)
                        {
                            var return_v = this_param.TryAdd(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11898, 11925);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 11417, 11941);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 11417, 11941);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 10502, 11952);

                bool
                f_10159_10591_10602()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 10591, 10602);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_10649_10661(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10649, 10661);
                    return return_v;
                }


                int
                f_10159_10728_10753(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                result, string
                name2)
                {
                    cacheResult(result, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10728, 10753);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_10839_10857()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 10839, 10857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_10839_10874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 10839, 10874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_11027_11083(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11027, 11083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10159_11177_11199(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11177, 11199);
                    return return_v;
                }


                int
                f_10159_11165_11200(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11165, 11200);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_11116_11131_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11116, 11131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_11257_11285(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11257, 11285);
                    return return_v;
                }


                int
                f_10159_11300_11337(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                result, string
                name2)
                {
                    cacheResult(result, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 11300, 11337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 10502, 11952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 10502, 11952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 11964, 12097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12049, 12086);

                throw f_10159_12055_12085();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 11964, 12097);

                System.Exception
                f_10159_12055_12085()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 12055, 12085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 11964, 12097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 11964, 12097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 12109, 12383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12209, 12372);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10159, 12216, 12224) || ((_unbound
                && DynAbs.Tracing.TraceSender.Conditional_F2(10159, 12244, 12256)) || DynAbs.Tracing.TraceSender.Conditional_F3(10159, 12276, 12371))) ? f_10159_12244_12256(this) : f_10159_12276_12329(f_10159_12276_12294()).SelectAsArray(s_symbolAsMemberFunc, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 12109, 12383);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12244_12256(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12244, 12256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_12276_12294()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 12276, 12294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12276_12329(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12276, 12329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 12109, 12383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 12109, 12383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 12395, 12846);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12506, 12544) || true) && (_unbound)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 12506, 12544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12520, 12544);

                    return f_10159_12527_12543(this, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 12506, 12544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12560, 12609);

                var
                builder = f_10159_12574_12608()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12623, 12783);
                    foreach (var t in f_10159_12641_12698_I(f_10159_12641_12698(f_10159_12641_12659(), name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 12623, 12783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12732, 12768);

                        f_10159_12732_12767(builder, f_10159_12744_12766(t, this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 12623, 12783);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10159, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10159, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12799, 12835);

                return f_10159_12806_12834(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 12395, 12846);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12527_12543(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12527, 12543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12574_12608()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12574, 12608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10159_12641_12659()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 12641, 12659);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12641_12698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12641, 12698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10159_12744_12766(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12744, 12766);
                    return return_v;
                }


                int
                f_10159_12732_12767(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12732, 12767);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12641_12698_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12641, 12698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10159_12806_12834(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 12806, 12834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 12395, 12846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 12395, 12846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override NamedTypeSymbol EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 12940, 13036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 12976, 13021);

                    return f_10159_12983_13020(f_10159_12983_13001());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 12940, 13036);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_12983_13001()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 12983, 13001);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_12983_13020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 12983, 13020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 12858, 13047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 12858, 13047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13059, 13263);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13117, 13219) || true) && (_hashCode == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10159, 13117, 13219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13169, 13204);

                    _hashCode = f_10159_13181_13203(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10159, 13117, 13219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13235, 13252);

                return _hashCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13059, 13263);

                int
                f_10159_13181_13203(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                type)
                {
                    var return_v = type.ComputeHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 13181, 13203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13059, 13263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13059, 13263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override TypeMap TypeSubstitution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13349, 13373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13355, 13371);

                    return f_10159_13362_13370(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13349, 13373);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10159_13362_13370(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Map;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13362, 13370);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13275, 13384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13275, 13384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13462, 13508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13468, 13506);

                    return f_10159_13475_13505(f_10159_13475_13493());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13462, 13508);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_13475_13493()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13475, 13493);
                        return return_v;
                    }


                    bool
                    f_10159_13475_13505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13475, 13505);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13396, 13519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13396, 13519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13613, 13664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13619, 13662);

                    return f_10159_13626_13661(f_10159_13626_13644());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13613, 13664);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_13626_13644()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13626, 13644);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10159_13626_13661(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ComImportCoClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13626, 13661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13531, 13675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13531, 13675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<MethodSymbol> GetMethodsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13687, 13822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13774, 13811);

                throw f_10159_13780_13810();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13687, 13822);

                System.Exception
                f_10159_13780_13810()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13780, 13810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13687, 13822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13687, 13822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<EventSymbol> GetEventsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13834, 13967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 13919, 13956);

                throw f_10159_13925_13955();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13834, 13967);

                System.Exception
                f_10159_13925_13955()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 13925, 13955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13834, 13967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13834, 13967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<PropertySymbol> GetPropertiesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 13979, 14119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14071, 14108);

                throw f_10159_14077_14107();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 13979, 14119);

                System.Exception
                f_10159_14077_14107()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 14077, 14107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 13979, 14119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 13979, 14119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 14131, 14311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14263, 14300);

                throw f_10159_14269_14299();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 14131, 14311);

                System.Exception
                f_10159_14269_14299()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 14269, 14299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 14131, 14311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 14131, 14311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 14382, 14421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14385, 14421);
                throw f_10159_14391_14421(); DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 14382, 14421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 14382, 14421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 14382, 14421);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10159_14391_14421()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 14391, 14421);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 14503, 14510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14506, 14510);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 14503, 14510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 14503, 14510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 14503, 14510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 14562, 14589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14565, 14589);
                    return f_10159_14565_14589(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 14562, 14589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 14562, 14589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 14562, 14589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10159, 14664, 14716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 14667, 14716);
                return f_10159_14667_14716(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10159, 14664, 14716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10159, 14664, 14716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 14664, 14716);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10159_14667_14716(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.HasPossibleWellKnownCloneMethod();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 14667, 14716);
                return return_v;
            }

        }

        static SubstitutedNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10159, 752, 14724);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10159, 906, 960);
            s_symbolAsMemberFunc = SymbolExtensions.SymbolAsMember; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10159, 752, 14724);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10159, 752, 14724);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10159, 752, 14724);

        bool
        f_10159_2314_2345(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 2314, 2345);
            return return_v;
        }


        int
        f_10159_2301_2346(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 2301, 2346);
            return 0;
        }


        bool
        f_10159_2375_2407(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type)
        {
            var return_v = type.IsErrorType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 2375, 2407);
            return return_v;
        }


        int
        f_10159_2361_2408(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 2361, 2408);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10159_2800_2831(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ConstructedFrom;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 2800, 2831);
            return return_v;
        }


        bool
        f_10159_2784_2849(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        objB)
        {
            var return_v = ReferenceEquals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 2784, 2849);
            return return_v;
        }


        int
        f_10159_2771_2850(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 2771, 2850);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10159_2891_2921(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 2891, 2921);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10159_2246_2264_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10159, 2024, 2981);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10159_5891_5894()
        {
            var return_v = Map;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5891, 5894);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10159_5915_5933()
        {
            var return_v = OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5915, 5933);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10159_5915_5962(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 5915, 5962);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10159_5891_5963(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        previous)
        {
            var return_v = this_param.SubstituteNamedType(previous);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10159, 5891, 5963);
            return return_v;
        }


        bool
        f_10159_14565_14589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10159, 14565, 14589);
            return return_v;
        }

    }
}
