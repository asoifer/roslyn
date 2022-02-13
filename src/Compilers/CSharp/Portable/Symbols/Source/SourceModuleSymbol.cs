// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceModuleSymbol : NonMissingModuleSymbol, IAttributeTargetSymbol
    {
        private readonly SourceAssemblySymbol _assemblySymbol;

        private ImmutableArray<AssemblySymbol> _lazyAssembliesToEmbedTypesFrom;

        private ThreeState _lazyContainsExplicitDefinitionOfNoPiaLocalTypes;

        private readonly DeclarationTable _sources;

        private SymbolCompletionState _state;

        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        private ImmutableArray<Location> _locations;

        private NamespaceSymbol _globalNamespace;

        private bool _hasBadAttributes;

        internal SourceModuleSymbol(
                    SourceAssemblySymbol assemblySymbol,
                    DeclarationTable declarations,
                    string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10067, 1720, 2075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1045, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1175, 1244);
                this._lazyContainsExplicitDefinitionOfNoPiaLocalTypes = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1418, 1426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1535, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1648, 1664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1690, 1707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 14132, 14137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1899, 1944);

                f_10067_1899_1943((object)assemblySymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 1960, 1993);

                _assemblySymbol = assemblySymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2007, 2031);

                _sources = declarations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2045, 2064);

                _name = moduleName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10067, 1720, 2075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 1720, 2075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 1720, 2075);
            }
        }

        internal void RecordPresenceOfBadAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 2087, 2193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2157, 2182);

                _hasBadAttributes = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 2087, 2193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 2087, 2193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 2087, 2193);
            }
        }

        internal bool HasBadAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 2260, 2336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2296, 2321);

                    return _hasBadAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 2260, 2336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 2205, 2347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 2205, 2347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 2413, 2473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2449, 2458);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 2413, 2473);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 2359, 2484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 2359, 2484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 2554, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2590, 3107);

                    switch (f_10067_2598_2635(f_10067_2598_2626(f_10067_2598_2618())))
                    {

                        case Platform.Arm:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 2590, 3107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2721, 2746);

                            return Machine.ArmThumb2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 2590, 3107);

                        case Platform.X64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 2590, 3107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2812, 2833);

                            return Machine.Amd64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 2590, 3107);

                        case Platform.Arm64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 2590, 3107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2901, 2922);

                            return Machine.Arm64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 2590, 3107);

                        case Platform.Itanium:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 2590, 3107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 2992, 3012);

                            return Machine.IA64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 2590, 3107);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 2590, 3107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3068, 3088);

                            return Machine.I386;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 2590, 3107);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 2554, 3122);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10067_2598_2618()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 2598, 2618);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10067_2598_2626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 2598, 2626);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Platform
                    f_10067_2598_2635(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.Platform;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 2598, 2635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 2496, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 2496, 3133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 3206, 3318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3242, 3303);

                    return f_10067_3249_3286(f_10067_3249_3277(f_10067_3249_3269())) == Platform.X86;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 3206, 3318);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10067_3249_3269()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 3249, 3269);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10067_3249_3277(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 3249, 3277);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Platform
                    f_10067_3249_3286(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.Platform;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 3249, 3286);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 3145, 3329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 3145, 3329);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool AnyReferencedAssembliesAreLinked
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 3412, 3513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3448, 3498);

                    return f_10067_3455_3486(this).Length > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 3412, 3513);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10067_3455_3486(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAssembliesToEmbedTypesFrom();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 3455, 3486);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 3341, 3524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 3341, 3524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool MightContainNoPiaLocalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 3536, 3719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3604, 3708);

                return f_10067_3611_3643() || (DynAbs.Tracing.TraceSender.Expression_False(10067, 3611, 3707) || f_10067_3664_3707());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 3536, 3719);

                bool
                f_10067_3611_3643()
                {
                    var return_v = AnyReferencedAssembliesAreLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 3611, 3643);
                    return return_v;
                }


                bool
                f_10067_3664_3707()
                {
                    var return_v = ContainsExplicitDefinitionOfNoPiaLocalTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 3664, 3707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 3536, 3719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 3536, 3719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<AssemblySymbol> GetAssembliesToEmbedTypesFrom()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 3731, 4695);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3827, 4558) || true) && (_lazyAssembliesToEmbedTypesFrom.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 3827, 4558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3906, 3936);

                    f_10067_3906_3935(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 3954, 4010);

                    var
                    buffer = f_10067_3967_4009()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4030, 4262);
                        foreach (AssemblySymbol asm in f_10067_4061_4096_I(f_10067_4061_4096(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 4030, 4262);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4138, 4243) || true) && (f_10067_4142_4154(asm))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 4138, 4243);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4204, 4220);

                                f_10067_4204_4219(buffer, asm);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 4138, 4243);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 4030, 4262);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10067, 1, 233);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10067, 1, 233);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4282, 4543);

                    f_10067_4282_4542(ref _lazyAssembliesToEmbedTypesFrom, f_10067_4420_4447(buffer), default(ImmutableArray<AssemblySymbol>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 3827, 4558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4574, 4631);

                f_10067_4574_4630(f_10067_4587_4629_M(!_lazyAssembliesToEmbedTypesFrom.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4645, 4684);

                return _lazyAssembliesToEmbedTypesFrom;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 3731, 4695);

                int
                f_10067_3906_3935(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesInitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 3906, 3935);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_3967_4009()
                {
                    var return_v = ArrayBuilder<AssemblySymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 3967, 4009);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_4061_4096(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4061, 4096);
                    return return_v;
                }


                bool
                f_10067_4142_4154(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 4142, 4154);
                    return return_v;
                }


                int
                f_10067_4204_4219(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4204, 4219);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_4061_4096_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4061, 4096);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_4420_4447(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4420, 4447);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_4282_4542(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4282, 4542);
                    return return_v;
                }


                bool
                f_10067_4587_4629_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 4587, 4629);
                    return return_v;
                }


                int
                f_10067_4574_4630(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4574, 4630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 3731, 4695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 3731, 4695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ContainsExplicitDefinitionOfNoPiaLocalTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 4789, 5309);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4825, 5096) || true) && (_lazyContainsExplicitDefinitionOfNoPiaLocalTypes == ThreeState.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 4825, 5096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 4941, 5077);

                        _lazyContainsExplicitDefinitionOfNoPiaLocalTypes = f_10067_4992_5076(f_10067_4992_5061(f_10067_5045_5060()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 4825, 5096);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5116, 5201);

                    f_10067_5116_5200(_lazyContainsExplicitDefinitionOfNoPiaLocalTypes != ThreeState.Unknown);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5219, 5294);

                    return _lazyContainsExplicitDefinitionOfNoPiaLocalTypes == ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 4789, 5309);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10067_5045_5060()
                    {
                        var return_v = GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 5045, 5060);
                        return return_v;
                    }


                    bool
                    f_10067_4992_5061(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    ns)
                    {
                        var return_v = NamespaceContainsExplicitDefinitionOfNoPiaLocalTypes(ns);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4992, 5061);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10067_4992_5076(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 4992, 5076);
                        return return_v;
                    }


                    int
                    f_10067_5116_5200(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 5116, 5200);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 4707, 5320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 4707, 5320);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool NamespaceContainsExplicitDefinitionOfNoPiaLocalTypes(NamespaceSymbol ns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10067, 5332, 6185);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5449, 6145);
                    foreach (Symbol s in f_10067_5470_5494(ns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 5449, 6145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5528, 6130);

                        switch (f_10067_5536_5542(s))
                        {

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 5528, 6130);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5636, 5809) || true) && (f_10067_5640_5712(s))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 5636, 5809);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5770, 5782);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 5636, 5809);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10067, 5837, 5843);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 5528, 6130);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 5528, 6130);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 5919, 6077) || true) && (f_10067_5923_5980(((NamedTypeSymbol)s)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 5919, 6077);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6038, 6050);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 5919, 6077);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10067, 6105, 6111);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 5528, 6130);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 5449, 6145);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10067, 1, 697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10067, 1, 697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6161, 6174);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10067, 5332, 6185);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10067_5470_5494(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 5470, 5494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10067_5536_5542(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 5536, 5542);
                    return return_v;
                }


                bool
                f_10067_5640_5712(Microsoft.CodeAnalysis.CSharp.Symbol
                ns)
                {
                    var return_v = NamespaceContainsExplicitDefinitionOfNoPiaLocalTypes((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)ns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 5640, 5712);
                    return return_v;
                }


                bool
                f_10067_5923_5980(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 5923, 5980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 5332, 6185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 5332, 6185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 6269, 6867);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6305, 6808) || true) && ((object)_globalNamespace == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 6305, 6808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6383, 6429);

                        var
                        diagnostics = f_10067_6401_6428()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6451, 6587);

                        var
                        globalNS = f_10067_6466_6586(this, this, f_10067_6530_6572(f_10067_6530_6550()), diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6609, 6660);

                        f_10067_6609_6659(f_10067_6622_6658(diagnostics));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6682, 6701);

                        f_10067_6682_6700(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6723, 6789);

                        f_10067_6723_6788(ref _globalNamespace, globalNS, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 6305, 6808);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6828, 6852);

                    return _globalNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 6269, 6867);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10067_6401_6428()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 6401, 6428);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10067_6530_6550()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 6530, 6550);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                    f_10067_6530_6572(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.MergedRootDeclaration;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 6530, 6572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                    f_10067_6466_6586(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    module, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    container, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                    mergedDeclaration, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol(module, (Microsoft.CodeAnalysis.CSharp.Symbol)container, mergedDeclaration, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 6466, 6586);
                        return return_v;
                    }


                    bool
                    f_10067_6622_6658(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.IsEmptyWithoutResolution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 6622, 6658);
                        return return_v;
                    }


                    int
                    f_10067_6609_6659(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 6609, 6659);
                        return 0;
                    }


                    int
                    f_10067_6682_6700(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 6682, 6700);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    f_10067_6723_6788(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 6723, 6788);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 6197, 6878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 6197, 6878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 6963, 6983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 6969, 6981);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 6963, 6983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 6890, 6994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 6890, 6994);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 7006, 7136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 7093, 7125);

                return _state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 7006, 7136);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 7006, 7136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 7006, 7136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = _state.NextIncompletePart;
                switch (incompletePart)
                {
                    case CompletionPart.Attributes:
                        GetAttributes();
                        break;

                    case CompletionPart.StartValidatingReferencedAssemblies:
                        {
                            DiagnosticBag diagnostics = null;

                            if (AnyReferencedAssembliesAreLinked)
                            {
                                diagnostics = DiagnosticBag.GetInstance();
                                ValidateLinkedAssemblies(diagnostics, cancellationToken);
                            }

                            if (_state.NotePartComplete(CompletionPart.StartValidatingReferencedAssemblies))
                            {
                                if (diagnostics != null)
                                {
                                    _assemblySymbol.DeclaringCompilation.DeclarationDiagnostics.AddRange(diagnostics);
                                }

                                _state.NotePartComplete(CompletionPart.FinishValidatingReferencedAssemblies);
                            }

                            if (diagnostics != null)
                            {
                                diagnostics.Free();
                            }
                        }
                        break;

                    case CompletionPart.FinishValidatingReferencedAssemblies:
                        // some other thread has started validating references (otherwise we would be in the case above) so
                        // we just wait for it to both finish and report the diagnostics.
                        Debug.Assert(_state.HasComplete(CompletionPart.StartValidatingReferencedAssemblies));
                        _state.SpinWaitComplete(CompletionPart.FinishValidatingReferencedAssemblies, cancellationToken);
                        break;

                    case CompletionPart.MembersCompleted:
                        this.GlobalNamespace.ForceComplete(locationOpt, cancellationToken);

                        if (this.GlobalNamespace.HasComplete(CompletionPart.MembersCompleted))
                        {
                            _state.NotePartComplete(CompletionPart.MembersCompleted);
                        }
                        else
                        {
                            Debug.Assert(locationOpt != null, "If no location was specified, then the namespace members should be completed");
                            return;
                        }

                        break;

                    case CompletionPart.None:
                        return;

                    default:
                        // any other values are completion parts intended for other kinds of symbols
                        _state.NotePartComplete(incompletePart);
                        break;
                }

                _state.SpinWaitComplete(incompletePart, cancellationToken);
            }
        }

        private void ValidateLinkedAssemblies(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 10557, 13526);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 10683, 13515);
                    foreach (AssemblySymbol a in f_10067_10712_10742_I(f_10067_10712_10742(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 10683, 13515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 10776, 10825);

                        cancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 10845, 13500) || true) && (f_10067_10849_10861_M(!a.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10067, 10849, 10875) && f_10067_10865_10875(a)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 10845, 13500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 10917, 10947);

                            bool
                            hasGuidAttribute = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 10969, 11038);

                            bool
                            hasImportedFromTypeLibOrPrimaryInteropAssemblyAttribute = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11062, 12576);
                                foreach (var attrData in f_10067_11087_11104_I(f_10067_11087_11104(a)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11062, 12576);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11154, 12355) || true) && (f_10067_11158_11223(attrData, a, AttributeDescription.GuidAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11154, 12355);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11281, 11299);

                                        string
                                        guidString
                                        = default(string);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11329, 11503) || true) && (f_10067_11333_11382(attrData, out guidString))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11329, 11503);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11448, 11472);

                                            hasGuidAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11329, 11503);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11154, 12355);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11154, 12355);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11561, 12355) || true) && (f_10067_11565_11645(attrData, a, AttributeDescription.ImportedFromTypeLibAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11561, 12355);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11703, 11914) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11703, 11914);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11820, 11883);

                                                hasImportedFromTypeLibOrPrimaryInteropAssemblyAttribute = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11703, 11914);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11561, 12355);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11561, 12355);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 11972, 12355) || true) && (f_10067_11976_12059(attrData, a, AttributeDescription.PrimaryInteropAssemblyAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 11972, 12355);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12117, 12328) || true) && (attrData.CommonConstructorArguments.Length == 2)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 12117, 12328);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12234, 12297);

                                                    hasImportedFromTypeLibOrPrimaryInteropAssemblyAttribute = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 12117, 12328);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11972, 12355);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11561, 12355);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11154, 12355);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12383, 12553) || true) && (hasGuidAttribute && (DynAbs.Tracing.TraceSender.Expression_True(10067, 12387, 12462) && hasImportedFromTypeLibOrPrimaryInteropAssemblyAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 12383, 12553);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10067, 12520, 12526);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 12383, 12553);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 11062, 12576);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10067, 1, 1515);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10067, 1, 1515);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12600, 12915) || true) && (!hasGuidAttribute)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 12600, 12915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12761, 12892);

                                f_10067_12761_12891(                        // ERRID_PIAHasNoAssemblyGuid1/ERR_NoPIAAssemblyMissingAttribute
                                                        diagnostics, ErrorCode.ERR_NoPIAAssemblyMissingAttribute, NoLocation.Singleton, a, AttributeDescription.GuidAttribute.FullName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 12600, 12915);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 12939, 13481) || true) && (!hasImportedFromTypeLibOrPrimaryInteropAssemblyAttribute)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 12939, 13481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 13144, 13458);

                                f_10067_13144_13457(                        // ERRID_PIAHasNoTypeLibAttribute1/ERR_NoPIAAssemblyMissingAttributes
                                                        diagnostics, ErrorCode.ERR_NoPIAAssemblyMissingAttributes, NoLocation.Singleton, a, AttributeDescription.ImportedFromTypeLibAttribute.FullName, AttributeDescription.PrimaryInteropAssemblyAttribute.FullName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 12939, 13481);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 10845, 13500);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 10683, 13515);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10067, 1, 2833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10067, 1, 2833);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 10557, 13526);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_10712_10742(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 10712, 10742);
                    return return_v;
                }


                bool
                f_10067_10849_10861_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 10849, 10861);
                    return return_v;
                }


                bool
                f_10067_10865_10875(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 10865, 10875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10067_11087_11104(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11087, 11104);
                    return return_v;
                }


                bool
                f_10067_11158_11223(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11158, 11223);
                    return return_v;
                }


                bool
                f_10067_11333_11382(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attrData, out string
                guidString)
                {
                    var return_v = attrData.TryGetGuidAttributeValue(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11333, 11382);
                    return return_v;
                }


                bool
                f_10067_11565_11645(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11565, 11645);
                    return return_v;
                }


                bool
                f_10067_11976_12059(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11976, 12059);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10067_11087_11104_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 11087, 11104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10067_12761_12891(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 12761, 12891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10067_13144_13457(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 13144, 13457);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10067_10712_10742_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 10712, 10742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 10557, 13526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 10557, 13526);
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 13613, 13995);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 13649, 13942) || true) && (_locations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 13649, 13942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 13715, 13923);

                        f_10067_13715_13922(ref _locations, f_10067_13825_13867(f_10067_13825_13845()).Declarations.SelectAsArray(d => (Location)d.Location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 13649, 13942);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 13962, 13980);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 13613, 13995);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10067_13825_13845()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 13825, 13845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                    f_10067_13825_13867(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.MergedRootDeclaration;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 13825, 13867);
                        return return_v;
                    }


                    bool
                    f_10067_13715_13922(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 13715, 13922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 13538, 14006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 13538, 14006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly string _name;

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 14202, 14266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 14238, 14251);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 14202, 14266);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 14150, 14277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 14150, 14277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 14353, 14427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 14389, 14412);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 14353, 14427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 14289, 14438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 14289, 14438);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 14524, 14598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 14560, 14583);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 14524, 14598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 14450, 14609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 14450, 14609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAssemblySymbol ContainingSourceAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 14700, 14774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 14736, 14759);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 14700, 14774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 14621, 14785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 14621, 14785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpCompilation DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15013, 15108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15049, 15093);

                    return f_10067_15056_15092(_assemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15013, 15108);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10067_15056_15092(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 15056, 15092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 14932, 15119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 14932, 15119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15203, 15280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15239, 15265);

                    return f_10067_15246_15264(_sources);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15203, 15280);

                    System.Collections.Generic.ICollection<string>
                    f_10067_15246_15264(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 15246, 15264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 15131, 15291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 15131, 15291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15380, 15462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15416, 15447);

                    return f_10067_15423_15446(_sources);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15380, 15462);

                    System.Collections.Generic.ICollection<string>
                    f_10067_15423_15446(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                    this_param)
                    {
                        var return_v = this_param.NamespaceNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 15423, 15446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 15303, 15473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 15303, 15473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15571, 15602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15577, 15600);

                    return _assemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15571, 15602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 15485, 15613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 15485, 15613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15715, 15755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15721, 15753);

                    return AttributeLocation.Module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15715, 15755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 15625, 15766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 15625, 15766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 15869, 16041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 15905, 16026);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10067, 15912, 15944) || ((f_10067_15912_15944(f_10067_15912_15930()) && DynAbs.Tracing.TraceSender.Conditional_F2(10067, 15947, 15969)) || DynAbs.Tracing.TraceSender.Conditional_F3(10067, 15972, 16025))) ? AttributeLocation.None : AttributeLocation.Assembly | AttributeLocation.Module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 15869, 16041);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10067_15912_15930()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 15912, 15930);
                        return return_v;
                    }


                    bool
                    f_10067_15912_15944(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsInteractive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 15912, 15944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 15778, 16052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 15778, 16052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 16378, 17037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16470, 16978) || true) && (_lazyCustomAttributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10067, 16474, 16544) || f_10067_16510_16544_M(!_lazyCustomAttributesBag.IsSealed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 16470, 16978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16578, 16676);

                    var
                    mergedAttributes = f_10067_16601_16675(((SourceAssemblySymbol)f_10067_16624_16647(this)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16694, 16963) || true) && (f_10067_16698_16789(this, f_10067_16724_16758(mergedAttributes), ref _lazyCustomAttributesBag))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 16694, 16963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16831, 16898);

                        var
                        completed = _state.NotePartComplete(CompletionPart.Attributes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16920, 16944);

                        f_10067_16920_16943(completed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 16694, 16963);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 16470, 16978);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 16994, 17026);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 16378, 17037);

                bool
                f_10067_16510_16544_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 16510, 16544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10067_16624_16647(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 16624, 16647);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10067_16601_16675(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 16601, 16675);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10067_16724_16758(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 16724, 16758);
                    return return_v;
                }


                bool
                f_10067_16698_16789(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 16698, 16789);
                    return return_v;
                }


                int
                f_10067_16920_16943(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 16920, 16943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 16378, 17037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 16378, 17037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 17470, 17622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 17569, 17611);

                return f_10067_17576_17610(f_10067_17576_17599(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 17470, 17622);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10067_17576_17599(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 17576, 17599);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10067_17576_17610(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 17576, 17610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 17470, 17622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 17470, 17622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ModuleWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 17911, 18346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18007, 18052);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18066, 18238) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10067, 18070, 18149) || f_10067_18095_18149_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 18066, 18238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18183, 18223);

                    attributesBag = f_10067_18199_18222(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 18066, 18238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18254, 18335);

                return (ModuleWellKnownAttributeData)f_10067_18291_18334(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 17911, 18346);

                bool
                f_10067_18095_18149_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 18095, 18149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10067_18199_18222(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18199, 18222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10067_18291_18334(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 18291, 18334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 17911, 18346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 17911, 18346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 18358, 20095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18536, 18595);

                f_10067_18536_18594((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18611, 18647);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18661, 18696);

                f_10067_18661_18695(f_10067_18674_18694_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18710, 18771);

                f_10067_18710_18770(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18787, 20084) || true) && (f_10067_18791_18870(attribute, this, AttributeDescription.DefaultCharSetAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 18787, 20084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 18904, 18992);

                    CharSet
                    charSet = f_10067_18922_18991(attribute, 0, SpecialType.System_Enum)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19010, 19585) || true) && (!f_10067_19015_19067(charSet))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 19010, 19585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19109, 19222);

                        CSharpSyntaxNode
                        attributeArgumentSyntax = f_10067_19152_19221(attribute, 0, arguments.AttributeSyntaxOpt)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19244, 19396);

                        f_10067_19244_19395(arguments.Diagnostics, ErrorCode.ERR_InvalidAttributeArgument, f_10067_19310_19342(attributeArgumentSyntax), f_10067_19344_19394(arguments.AttributeSyntaxOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 19010, 19585);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 19010, 19585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19478, 19566);

                        arguments.GetOrCreateData<ModuleWellKnownAttributeData>().DefaultCharacterSet = charSet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 19010, 19585);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 18787, 20084);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 18787, 20084);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19619, 20084) || true) && (f_10067_19623_19785(this, arguments, ReservedAttributes.NullableContextAttribute | ReservedAttributes.NullablePublicOnlyAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 19619, 20084);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 19619, 20084);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 19619, 20084);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19835, 20084) || true) && (f_10067_19839_19918(attribute, this, AttributeDescription.SkipLocalsInitAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 19835, 20084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 19952, 20069);

                            f_10067_19952_20068(f_10067_20032_20052(), ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 19835, 20084);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 19619, 20084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 18787, 20084);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 18358, 20095);

                int
                f_10067_18536_18594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18536, 18594);
                    return 0;
                }


                bool
                f_10067_18674_18694_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 18674, 18694);
                    return return_v;
                }


                int
                f_10067_18661_18695(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18661, 18695);
                    return 0;
                }


                int
                f_10067_18710_18770(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18710, 18770);
                    return 0;
                }


                bool
                f_10067_18791_18870(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18791, 18870);
                    return return_v;
                }


                System.Runtime.InteropServices.CharSet
                f_10067_18922_18991(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, int
                i, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetConstructorArgument<System.Runtime.InteropServices.CharSet>(i, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 18922, 18991);
                    return return_v;
                }


                bool
                f_10067_19015_19067(System.Runtime.InteropServices.CharSet
                value)
                {
                    var return_v = ModuleWellKnownAttributeData.IsValidCharSet(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19015, 19067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10067_19152_19221(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19152, 19221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10067_19310_19342(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 19310, 19342);
                    return return_v;
                }


                string
                f_10067_19344_19394(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19344, 19394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10067_19244_19395(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19244, 19395);
                    return return_v;
                }


                bool
                f_10067_19623_19785(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19623, 19785);
                    return return_v;
                }


                bool
                f_10067_19839_19918(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19839, 19918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10067_20032_20052()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 20032, 20052);
                    return return_v;
                }


                int
                f_10067_19952_20068(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeSkipLocalsInitAttribute<ModuleWellKnownAttributeData>(compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 19952, 20068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 18358, 20095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 18358, 20095);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 20107, 21441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20265, 20326);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10067, 20265, 20325);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 20265, 20325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20342, 20397);

                var
                compilation = f_10067_20360_20396(_assemblySymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20411, 20969) || true) && (f_10067_20415_20446(f_10067_20415_20434(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 20411, 20969);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20605, 20954) || true) && (!(f_10067_20611_20696(compilation, WellKnownType.System_Security_UnverifiableCodeAttribute) is MissingMetadataTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 20605, 20954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20768, 20935);

                        f_10067_20768_20934(ref attributes, f_10067_20808_20933(compilation, WellKnownMember.System_Security_UnverifiableCodeAttribute__ctor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 20605, 20954);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 20411, 20969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 20985, 21430) || true) && (f_10067_20989_21042(moduleBuilder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10067, 20985, 21430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 21076, 21285);

                    var
                    includesInternals = f_10067_21100_21284(f_10067_21144_21283(f_10067_21162_21216(compilation, SpecialType.System_Boolean), TypedConstantKind.Primitive, f_10067_21247_21282(_assemblySymbol)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 21303, 21415);

                    f_10067_21303_21414(ref attributes, f_10067_21343_21413(moduleBuilder, includesInternals));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10067, 20985, 21430);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 20107, 21441);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10067_20360_20396(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 20360, 20396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10067_20415_20434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 20415, 20434);
                    return return_v;
                }


                bool
                f_10067_20415_20446(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 20415, 20446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10067_20611_20696(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 20611, 20696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10067_20808_20933(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 20808, 20933);
                    return return_v;
                }


                int
                f_10067_20768_20934(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 20768, 20934);
                    return 0;
                }


                bool
                f_10067_20989_21042(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.ShouldEmitNullablePublicOnlyAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 20989, 21042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10067_21162_21216(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21162, 21216);
                    return return_v;
                }


                bool
                f_10067_21247_21282(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.InternalsAreVisible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 21247, 21282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10067_21144_21283(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21144, 21283);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10067_21100_21284(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21100, 21284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10067_21343_21413(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNullablePublicOnlyAttribute(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21343, 21413);
                    return return_v;
                }


                int
                f_10067_21303_21414(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21303, 21414);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 20107, 21441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 20107, 21441);
            }
        }

        internal override bool HasAssemblyCompilationRelaxationsAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 21543, 21846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 21579, 21736);

                    CommonAssemblyWellKnownAttributeData<NamedTypeSymbol>
                    decodedData = f_10067_21647_21735(((SourceAssemblySymbol)f_10067_21670_21693(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 21754, 21831);

                    return decodedData != null && (DynAbs.Tracing.TraceSender.Expression_True(10067, 21761, 21830) && f_10067_21784_21830(decodedData));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 21543, 21846);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10067_21670_21693(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 21670, 21693);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10067_21647_21735(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 21647, 21735);
                        return return_v;
                    }


                    bool
                    f_10067_21784_21830(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.HasCompilationRelaxationsAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 21784, 21830);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 21453, 21857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 21453, 21857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasAssemblyRuntimeCompatibilityAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 21957, 22258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 21993, 22150);

                    CommonAssemblyWellKnownAttributeData<NamedTypeSymbol>
                    decodedData = f_10067_22061_22149(((SourceAssemblySymbol)f_10067_22084_22107(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22168, 22243);

                    return decodedData != null && (DynAbs.Tracing.TraceSender.Expression_True(10067, 22175, 22242) && f_10067_22198_22242(decodedData));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 21957, 22258);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10067_22084_22107(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 22084, 22107);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10067_22061_22149(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 22061, 22149);
                        return return_v;
                    }


                    bool
                    f_10067_22198_22242(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeCompatibilityAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 22198, 22242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 21869, 22269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 21869, 22269);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet? DefaultMarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 22358, 22572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22394, 22440);

                    var
                    data = f_10067_22405_22439(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22458, 22557);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10067, 22465, 22512) || ((data != null && (DynAbs.Tracing.TraceSender.Expression_True(10067, 22465, 22512) && f_10067_22481_22512(data)) && DynAbs.Tracing.TraceSender.Conditional_F2(10067, 22515, 22539)) || DynAbs.Tracing.TraceSender.Conditional_F3(10067, 22542, 22556))) ? f_10067_22515_22539(data) : (CharSet?)null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 22358, 22572);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    f_10067_22405_22439(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 22405, 22439);
                        return return_v;
                    }


                    bool
                    f_10067_22481_22512(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasDefaultCharSetAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 22481, 22512);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10067_22515_22539(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.DefaultCharacterSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 22515, 22539);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 22281, 22583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 22281, 22583);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 22663, 22826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22699, 22745);

                    var
                    data = f_10067_22710_22744(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22763, 22811);

                    return f_10067_22770_22802_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(data, 10067, 22770, 22802)?.HasSkipLocalsInitAttribute) != true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 22663, 22826);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    f_10067_22710_22744(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 22710, 22744);
                        return return_v;
                    }


                    bool?
                    f_10067_22770_22802_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10067, 22770, 22802);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 22595, 22837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 22595, 22837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ModuleMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10067, 22894, 22901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10067, 22897, 22901);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10067, 22894, 22901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10067, 22894, 22901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 22894, 22901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10067, 824, 22909);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10067, 824, 22909);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10067, 824, 22909);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10067, 824, 22909);

        int
        f_10067_1899_1943(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10067, 1899, 1943);
            return 0;
        }

    }
}
