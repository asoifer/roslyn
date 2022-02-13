// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class MetadataOrSourceAssemblySymbol
            : NonMissingAssemblySymbol
    {
        private NamedTypeSymbol[] _lazySpecialTypes;

        private int _cachedSpecialTypes;

        private NativeIntegerTypeSymbol[] _lazyNativeIntegerTypes;

        internal sealed override NamedTypeSymbol GetDeclaredSpecialType(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 1335, 2390);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1452, 1595);
                    foreach (var module in f_10118_1475_1487_I(f_10118_1475_1487(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 1452, 1595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1521, 1580);

                        f_10118_1521_1579(f_10118_1534_1566(module).Length == 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 1452, 1595);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10118, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10118, 1, 144);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1619, 2327) || true) && (_lazySpecialTypes == null || (DynAbs.Tracing.TraceSender.Expression_False(10118, 1623, 1696) || (object)_lazySpecialTypes[(int)type] == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 1619, 2327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1730, 1855);

                    MetadataTypeName
                    emittedName = MetadataTypeName.FromFullName(f_10118_1791_1813(type), useCLSCompliantNameArityEncoding: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1873, 1911);

                    ModuleSymbol
                    module = f_10118_1895_1907(this)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1929, 2005);

                    NamedTypeSymbol
                    result = f_10118_1954_2004(module, ref emittedName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2023, 2258) || true) && (f_10118_2027_2038(result) != SymbolKind.ErrorType && (DynAbs.Tracing.TraceSender.Expression_True(10118, 2027, 2118) && f_10118_2066_2094(result) != Accessibility.Public))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 2023, 2258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2160, 2239);

                        result = f_10118_2169_2238(module, ref emittedName, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 2023, 2258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2276, 2312);

                    f_10118_2276_2311(this, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 1619, 2327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2343, 2379);

                return _lazySpecialTypes[(int)type];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 1335, 2390);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10118_1475_1487(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 1475, 1487);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_10118_1534_1566(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 1534, 1566);
                    return return_v;
                }


                int
                f_10118_1521_1579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 1521, 1579);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10118_1475_1487_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 1475, 1487);
                    return return_v;
                }


                string?
                f_10118_1791_1813(Microsoft.CodeAnalysis.SpecialType
                id)
                {
                    var return_v = id.GetMetadataName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 1791, 1813);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10118_1895_1907(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 1895, 1907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10118_1954_2004(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 1954, 2004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10118_2027_2038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2027, 2038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10118_2066_2094(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2066, 2094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10118_2169_2238(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2169, 2238);
                    return return_v;
                }


                int
                f_10118_2276_2311(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                corType)
                {
                    this_param.RegisterDeclaredSpecialType(corType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2276, 2311);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 1335, 2390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 1335, 2390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override void RegisterDeclaredSpecialType(NamedTypeSymbol corType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 2571, 3856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2678, 2719);

                SpecialType
                typeId = f_10118_2699_2718(corType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2733, 2774);

                f_10118_2733_2773(typeId != SpecialType.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2788, 2852);

                f_10118_2788_2851(f_10118_2801_2850(f_10118_2817_2843(corType), this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2866, 2918);

                f_10118_2866_2917(f_10118_2879_2911(f_10118_2879_2903(corType)) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 2932, 2985);

                f_10118_2932_2984(f_10118_2945_2983(f_10118_2961_2976(this), this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3001, 3206) || true) && (_lazySpecialTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 3001, 3206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3064, 3191);

                    f_10118_3064_3190(ref _lazySpecialTypes, new NamedTypeSymbol[(int)SpecialType.Count + 1], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 3001, 3206);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3222, 3845) || true) && ((object)f_10118_3234_3312(ref _lazySpecialTypes[(int)typeId], corType, null) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 3222, 3845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3354, 3612);

                    f_10118_3354_3611(f_10118_3367_3423(corType, _lazySpecialTypes[(int)typeId]) || (DynAbs.Tracing.TraceSender.Expression_False(10118, 3367, 3610) || (f_10118_3469_3481(corType) == SymbolKind.ErrorType && (DynAbs.Tracing.TraceSender.Expression_True(10118, 3469, 3609) && f_10118_3550_3585(_lazySpecialTypes[(int)typeId]) == SymbolKind.ErrorType))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 3222, 3845);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 3222, 3845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3678, 3725);

                    f_10118_3678_3724(ref _cachedSpecialTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 3743, 3830);

                    f_10118_3743_3829(_cachedSpecialTypes > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10118, 3756, 3828) && _cachedSpecialTypes <= (int)SpecialType.Count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 3222, 3845);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 2571, 3856);

                Microsoft.CodeAnalysis.SpecialType
                f_10118_2699_2718(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2699, 2718);
                    return return_v;
                }


                int
                f_10118_2733_2773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2733, 2773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10118_2817_2843(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2817, 2843);
                    return return_v;
                }


                bool
                f_10118_2801_2850(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2801, 2850);
                    return return_v;
                }


                int
                f_10118_2788_2851(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2788, 2851);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10118_2879_2903(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2879, 2903);
                    return return_v;
                }


                int
                f_10118_2879_2911(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2879, 2911);
                    return return_v;
                }


                int
                f_10118_2866_2917(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2866, 2917);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10118_2961_2976(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 2961, 2976);
                    return return_v;
                }


                bool
                f_10118_2945_2983(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2945, 2983);
                    return return_v;
                }


                int
                f_10118_2932_2984(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 2932, 2984);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                f_10118_3064_3190(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3064, 3190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10118_3234_3312(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3234, 3312);
                    return return_v;
                }


                bool
                f_10118_3367_3423(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3367, 3423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10118_3469_3481(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 3469, 3481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10118_3550_3585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 3550, 3585);
                    return return_v;
                }


                int
                f_10118_3354_3611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3354, 3611);
                    return 0;
                }


                int
                f_10118_3678_3724(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3678, 3724);
                    return return_v;
                }


                int
                f_10118_3743_3829(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 3743, 3829);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 2571, 3856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 2571, 3856);
            }
        }

        internal override bool KeepLookingForDeclaredSpecialTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 4156, 4301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4192, 4286);

                    return f_10118_4199_4237(f_10118_4215_4230(this), this) && (DynAbs.Tracing.TraceSender.Expression_True(10118, 4199, 4285) && _cachedSpecialTypes < (int)SpecialType.Count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 4156, 4301);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10118_4215_4230(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.CorLibrary;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 4215, 4230);
                        return return_v;
                    }


                    bool
                    f_10118_4199_4237(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 4199, 4237);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 4074, 4312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 4074, 4312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ICollection<string> _lazyTypeNames;

        private ICollection<string> _lazyNamespaceNames;

        public override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 4507, 4805);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4543, 4748) || true) && (_lazyTypeNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 4543, 4748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4611, 4729);

                        f_10118_4611_4728(ref _lazyTypeNames, f_10118_4659_4721(f_10118_4690_4702(this), m => m.TypeNames), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 4543, 4748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4768, 4790);

                    return _lazyTypeNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 4507, 4805);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10118_4690_4702(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 4690, 4702);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>
                    f_10118_4659_4721(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    collections, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol, System.Collections.Generic.ICollection<string>>
                    selector)
                    {
                        var return_v = UnionCollection<string>.Create(collections, selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 4659, 4721);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>?
                    f_10118_4611_4728(ref System.Collections.Generic.ICollection<string>?
                    location1, System.Collections.Generic.ICollection<string>
                    value, System.Collections.Generic.ICollection<string>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 4611, 4728);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 4437, 4816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 4437, 4816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol GetNativeIntegerType(NamedTypeSymbol underlyingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 4828, 5695);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4946, 5125) || true) && (_lazyNativeIntegerTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 4946, 5125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5015, 5110);

                    f_10118_5015_5109(ref _lazyNativeIntegerTypes, new NativeIntegerTypeSymbol[2], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 4946, 5125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5141, 5408);

                int
                index = f_10118_5153_5179(underlyingType) switch
                {
                    SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5219, 5249) && DynAbs.Tracing.TraceSender.Expression_True(10118, 5219, 5249))
=> 0,
                    SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5268, 5299) && DynAbs.Tracing.TraceSender.Expression_True(10118, 5268, 5299))
=> 1,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5318, 5391) && DynAbs.Tracing.TraceSender.Expression_True(10118, 5318, 5391))
=> throw f_10118_5329_5391(f_10118_5364_5390(underlyingType)),
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5424, 5630) || true) && (_lazyNativeIntegerTypes[index] is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 5424, 5630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5500, 5615);

                    f_10118_5500_5614(ref _lazyNativeIntegerTypes[index], f_10118_5564_5607(underlyingType), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 5424, 5630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5646, 5684);

                return _lazyNativeIntegerTypes[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 4828, 5695);

                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol[]?
                f_10118_5015_5109(ref Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5015, 5109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10118_5153_5179(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 5153, 5179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10118_5364_5390(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 5364, 5390);
                    return return_v;
                }


                System.Exception
                f_10118_5329_5391(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5329, 5391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                f_10118_5564_5607(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5564, 5607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                f_10118_5500_5614(ref Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5500, 5614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 4828, 5695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 4828, 5695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 5782, 6100);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5818, 6038) || true) && (_lazyNamespaceNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 5818, 6038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 5891, 6019);

                        f_10118_5891_6018(ref _lazyNamespaceNames, f_10118_5944_6011(f_10118_5975_5987(this), m => m.NamespaceNames), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 5818, 6038);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6058, 6085);

                    return _lazyNamespaceNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 5782, 6100);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10118_5975_5987(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 5975, 5987);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>
                    f_10118_5944_6011(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    collections, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol, System.Collections.Generic.ICollection<string>>
                    selector)
                    {
                        var return_v = UnionCollection<string>.Create(collections, selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5944, 6011);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>?
                    f_10118_5891_6018(ref System.Collections.Generic.ICollection<string>?
                    location1, System.Collections.Generic.ICollection<string>
                    value, System.Collections.Generic.ICollection<string>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 5891, 6018);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 5707, 6111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 5707, 6111);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Symbol[] _lazySpecialTypeMembers;

        internal override Symbol GetDeclaredSpecialTypeMember(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 6499, 8094);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6610, 6753);
                    foreach (var module in f_10118_6633_6645_I(f_10118_6633_6645(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 6610, 6753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6679, 6738);

                        f_10118_6679_6737(f_10118_6692_6724(module).Length == 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 6610, 6753);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10118, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10118, 1, 144);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6777, 8023) || true) && (_lazySpecialTypeMembers == null || (DynAbs.Tracing.TraceSender.Expression_False(10118, 6781, 6904) || f_10118_6816_6904(_lazySpecialTypeMembers[(int)member], ErrorTypeSymbol.UnknownResultType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 6777, 8023);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6938, 7408) || true) && (_lazySpecialTypeMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 6938, 7408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7015, 7077);

                        var
                        specialTypeMembers = new Symbol[(int)SpecialMember.Count]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7110, 7115);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7101, 7282) || true) && (i < f_10118_7121_7146(specialTypeMembers))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7148, 7151)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 7101, 7282))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 7101, 7282);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7201, 7259);

                                specialTypeMembers[i] = ErrorTypeSymbol.UnknownResultType;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10118, 1, 182);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10118, 1, 182);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7306, 7389);

                        f_10118_7306_7388(ref _lazySpecialTypeMembers, specialTypeMembers, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 6938, 7408);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7428, 7482);

                    var
                    descriptor = f_10118_7445_7481(member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7500, 7587);

                    NamedTypeSymbol
                    type = f_10118_7523_7586(this, descriptor.DeclaringTypeId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7605, 7626);

                    Symbol
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7646, 7875) || true) && (!f_10118_7651_7669(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 7646, 7875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7711, 7856);

                        result = f_10118_7720_7855(type, descriptor, CSharpCompilation.SpecialMembersSignatureComparer.Instance, accessWithinOpt: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 7646, 7875);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 7895, 8008);

                    f_10118_7895_8007(ref _lazySpecialTypeMembers[(int)member], result, ErrorTypeSymbol.UnknownResultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 6777, 8023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 8039, 8083);

                return _lazySpecialTypeMembers[(int)member];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 6499, 8094);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10118_6633_6645(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 6633, 6645);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_10118_6692_6724(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 6692, 6724);
                    return return_v;
                }


                int
                f_10118_6679_6737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 6679, 6737);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10118_6633_6645_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 6633, 6645);
                    return return_v;
                }


                bool
                f_10118_6816_6904(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 6816, 6904);
                    return return_v;
                }


                int
                f_10118_7121_7146(Microsoft.CodeAnalysis.CSharp.Symbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 7121, 7146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol[]?
                f_10118_7306_7388(ref Microsoft.CodeAnalysis.CSharp.Symbol[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbol[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7306, 7388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10118_7445_7481(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7445, 7481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10118_7523_7586(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param, short
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType((Microsoft.CodeAnalysis.SpecialType)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7523, 7586);
                    return return_v;
                }


                bool
                f_10118_7651_7669(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7651, 7669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10118_7720_7855(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaringType, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                descriptor, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.SpecialMembersSignatureComparer
                comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                accessWithinOpt)
                {
                    var return_v = CSharpCompilation.GetRuntimeMember(declaringType, descriptor, (Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>)comparer, accessWithinOpt: accessWithinOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7720, 7855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10118_7895_8007(ref Microsoft.CodeAnalysis.CSharp.Symbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 7895, 8007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 6499, 8094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 6499, 8094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected IVTConclusion MakeFinalIVTDetermination(AssemblySymbol potentialGiverOfAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 8492, 10451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 8605, 8626);

                IVTConclusion
                result
                = default(IVTConclusion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 8640, 8773) || true) && (f_10118_8644_8740(f_10118_8644_8692(), potentialGiverOfAccess, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 8640, 8773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 8759, 8773);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 8640, 8773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 8789, 8834);

                result = IVTConclusion.NoRelationshipClaimed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 9030, 9143);

                IEnumerable<ImmutableArray<byte>>
                publicKeys = f_10118_9077_9142(potentialGiverOfAccess, f_10118_9132_9141(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 9473, 9591) || true) && (f_10118_9477_9493(publicKeys) && (DynAbs.Tracing.TraceSender.Expression_True(10118, 9477, 9515) && f_10118_9497_9515(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 9473, 9591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 9549, 9576);

                    return IVTConclusion.Match;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 9473, 9591);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 9713, 10308);
                    foreach (var key in f_10118_9733_9743_I(publicKeys))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 9713, 10308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 9974, 10052);

                        result = f_10118_9983_10014(potentialGiverOfAccess).PerformIVTCheck(f_10118_10031_10045(this), key);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10070, 10130);

                        f_10118_10070_10129(result != IVTConclusion.NoRelationshipClaimed);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10150, 10293) || true) && (result == IVTConclusion.Match || (DynAbs.Tracing.TraceSender.Expression_False(10118, 10154, 10226) || result == IVTConclusion.OneSignedOneNot))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 10150, 10293);
                            DynAbs.Tracing.TraceSender.TraceBreak(10118, 10268, 10274);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 10150, 10293);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 9713, 10308);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10118, 1, 596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10118, 1, 596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10324, 10412);

                f_10118_10324_10411(f_10118_10324_10372(), potentialGiverOfAccess, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10426, 10440);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 8492, 10451);

                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                f_10118_8644_8692()
                {
                    var return_v = AssembliesToWhichInternalAccessHasBeenDetermined;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 8644, 8692);
                    return return_v;
                }


                bool
                f_10118_8644_8740(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, out Microsoft.CodeAnalysis.IVTConclusion
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 8644, 8740);
                    return return_v;
                }


                string
                f_10118_9132_9141(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 9132, 9141);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10118_9077_9142(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 9077, 9142);
                    return return_v;
                }


                bool
                f_10118_9477_9493(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                source)
                {
                    var return_v = source.Any<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 9477, 9493);
                    return return_v;
                }


                bool
                f_10118_9497_9515(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 9497, 9515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10118_9983_10014(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 9983, 10014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10118_10031_10045(Microsoft.CodeAnalysis.CSharp.Symbols.MetadataOrSourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 10031, 10045);
                    return return_v;
                }


                int
                f_10118_10070_10129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 10070, 10129);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10118_9733_9743_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 9733, 9743);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                f_10118_10324_10372()
                {
                    var return_v = AssembliesToWhichInternalAccessHasBeenDetermined;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10118, 10324, 10372);
                    return return_v;
                }


                bool
                f_10118_10324_10411(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, Microsoft.CodeAnalysis.IVTConclusion
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 10324, 10411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 8492, 10451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 8492, 10451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConcurrentDictionary<AssemblySymbol, IVTConclusion> _assembliesToWhichInternalAccessHasBeenAnalyzed;

        private ConcurrentDictionary<AssemblySymbol, IVTConclusion> AssembliesToWhichInternalAccessHasBeenDetermined
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 10886, 11238);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10922, 11150) || true) && (_assembliesToWhichInternalAccessHasBeenAnalyzed == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10118, 10922, 11150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 11004, 11150);

                        f_10118_11004_11149(ref _assembliesToWhichInternalAccessHasBeenAnalyzed, f_10118_11085_11142(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10118, 10922, 11150);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 11168, 11223);

                    return _assembliesToWhichInternalAccessHasBeenAnalyzed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 10886, 11238);

                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                    f_10118_11085_11142()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 11085, 11142);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>?
                    f_10118_11004_11149(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>?
                    location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>
                    value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.IVTConclusion>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10118, 11004, 11149);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 10753, 11249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 10753, 11249);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsNetModule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10118, 11297, 11305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 11300, 11305);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10118, 11297, 11305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10118, 11297, 11305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 11297, 11305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataOrSourceAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10118, 582, 11313);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 891, 908);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1035, 1054);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 1101, 1124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4352, 4366);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 4405, 4424);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 6272, 6295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10118, 10693, 10740);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10118, 582, 11313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 582, 11313);
        }


        static MetadataOrSourceAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10118, 582, 11313);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10118, 582, 11313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10118, 582, 11313);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10118, 582, 11313);
    }
}
