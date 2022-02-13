// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Collections;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class SourceNamedTypeSymbol
    {
        private Tuple<NamedTypeSymbol, ImmutableArray<NamedTypeSymbol>> _lazyDeclaredBases;

        private NamedTypeSymbol _lazyBaseType;

        private ImmutableArray<NamedTypeSymbol> _lazyInterfaces;

        internal sealed override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 1465, 2464);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 1501, 2408) || true) && (f_10075_1505_1570(_lazyBaseType, ErrorTypeSymbol.UnknownResultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 1501, 2408);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 1755, 1916) || true) && ((object)f_10075_1767_1781() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 1755, 1916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 1839, 1893);

                            var
                            tmp = f_10075_1849_1892(f_10075_1849_1863())
                            ;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 1755, 1916);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 1940, 1986);

                        var
                        diagnostics = f_10075_1958_1985()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2008, 2064);

                        var
                        acyclicBase = f_10075_2026_2063(this, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2086, 2348) || true) && (f_10075_2090_2236(f_10075_2106_2200(ref _lazyBaseType, acyclicBase, ErrorTypeSymbol.UnknownResultType), ErrorTypeSymbol.UnknownResultType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 2086, 2348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2286, 2325);

                            f_10075_2286_2324(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 2086, 2348);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2370, 2389);

                        f_10075_2370_2388(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 1501, 2408);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2428, 2449);

                    return _lazyBaseType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 1465, 2464);

                    bool
                    f_10075_1505_1570(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 1505, 1570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10075_1767_1781()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 1767, 1781);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10075_1849_1863()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 1849, 1863);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10075_1849_1892(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 1849, 1892);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10075_1958_1985()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 1958, 1985);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10075_2026_2063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.MakeAcyclicBaseType(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2026, 2063);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10075_2106_2200(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2106, 2200);
                        return return_v;
                    }


                    bool
                    f_10075_2090_2236(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2090, 2236);
                        return return_v;
                    }


                    int
                    f_10075_2286_2324(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.AddDeclarationDiagnostics(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2286, 2324);
                        return 0;
                    }


                    int
                    f_10075_2370_2388(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2370, 2388);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 1371, 2475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 1371, 2475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 2721, 3664);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2874, 3614) || true) && (_lazyInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 2874, 3614);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 2937, 3138) || true) && (basesBeingResolved != null && (DynAbs.Tracing.TraceSender.Expression_True(10075, 2941, 3032) && f_10075_2971_3032(basesBeingResolved, f_10075_3008_3031(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 2937, 3138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3074, 3119);

                        return ImmutableArray<NamedTypeSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 2937, 3138);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3158, 3204);

                    var
                    diagnostics = f_10075_3176_3203()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3222, 3301);

                    var
                    acyclicInterfaces = f_10075_3246_3300(this, basesBeingResolved, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3319, 3562) || true) && (f_10075_3323_3452(ref _lazyInterfaces, acyclicInterfaces, default(ImmutableArray<NamedTypeSymbol>)).IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 3319, 3562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3504, 3543);

                        f_10075_3504_3542(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 3319, 3562);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3580, 3599);

                    f_10075_3580_3598(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 2874, 3614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3630, 3653);

                return _lazyInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 2721, 3664);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_3008_3031(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 3008, 3031);
                    return return_v;
                }


                bool
                f_10075_2971_3032(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 2971, 3032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10075_3176_3203()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 3176, 3203);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_3246_3300(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeAcyclicInterfaces(basesBeingResolved, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 3246, 3300);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_3323_3452(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 3323, 3452);
                    return return_v;
                }


                int
                f_10075_3504_3542(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 3504, 3542);
                    return 0;
                }


                int
                f_10075_3580_3598(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 3580, 3598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 2721, 3664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 2721, 3664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void CheckBase(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 3676, 6376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3761, 3811);

                var
                localBase = f_10075_3777_3810(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3827, 3950) || true) && ((object)localBase == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 3827, 3950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3928, 3935);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 3827, 3950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 3966, 3995);

                Location
                baseLocation = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4009, 4069);

                bool
                baseContainsErrorTypes = f_10075_4039_4068(localBase)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4085, 4309) || true) && (!baseContainsErrorTypes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 4085, 4309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4146, 4190);

                    baseLocation = f_10075_4161_4189(this, localBase);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4208, 4294);

                    f_10075_4208_4293(!f_10075_4222_4240(this) || (DynAbs.Tracing.TraceSender.Expression_False(10075, 4221, 4268) || f_10075_4244_4268(localBase)) || (DynAbs.Tracing.TraceSender.Expression_False(10075, 4221, 4292) || baseLocation != null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 4085, 4309);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4433, 4765) || true) && (f_10075_4437_4455(this) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 4437, 4482) && !baseContainsErrorTypes) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 4437, 4538) && f_10075_4486_4538(f_10075_4486_4511(this), localBase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 4433, 4765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4665, 4750);

                    f_10075_4665_4749(                // A generic type cannot derive from '{0}' because it is an attribute class
                                    diagnostics, ErrorCode.ERR_GenericDerivingFromAttribute, baseLocation, localBase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 4433, 4765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4861, 4926);

                var
                singleDeclaration = f_10075_4885_4925(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 4940, 5310) || true) && (singleDeclaration != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 4940, 5310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5003, 5055);

                    var
                    corLibrary = f_10075_5020_5054(f_10075_5020_5043(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5073, 5123);

                    var
                    conversions = f_10075_5091_5122(corLibrary)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5141, 5187);

                    var
                    location = f_10075_5156_5186(singleDeclaration)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5207, 5295);

                    f_10075_5207_5294(
                                    localBase, f_10075_5237_5257(), conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 4940, 5310);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5396, 6365) || true) && (f_10075_5400_5418(this) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 5400, 5447) && !f_10075_5423_5447(localBase)) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 5400, 5474) && !baseContainsErrorTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 5396, 6365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5508, 5558);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5578, 6280) || true) && (f_10075_5582_5598(declaration) == DeclarationKind.Record)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 5578, 6280);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5666, 6015) || true) && (f_10075_5670_5748(localBase, ref useSiteDiagnostics) is null || (DynAbs.Tracing.TraceSender.Expression_False(10075, 5670, 5883) || f_10075_5785_5875(localBase, f_10075_5854_5874()) is null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 5666, 6015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 5933, 5992);

                            f_10075_5933_5991(diagnostics, ErrorCode.ERR_BadRecordBase, baseLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 5666, 6015);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 5578, 6280);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 5578, 6280);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6057, 6280) || true) && (f_10075_6061_6139(localBase, ref useSiteDiagnostics) is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 6057, 6280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6191, 6261);

                            f_10075_6191_6260(diagnostics, ErrorCode.ERR_BadInheritanceFromRecord, baseLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 6057, 6280);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 5578, 6280);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6300, 6350);

                    f_10075_6300_6349(
                                    diagnostics, baseLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 5396, 6365);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 3676, 6376);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_3777_3810(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 3777, 3810);
                    return return_v;
                }


                bool
                f_10075_4039_4068(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.ContainsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4039, 4068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_4161_4189(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseSym)
                {
                    var return_v = this_param.FindBaseRefSyntax(baseSym);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4161, 4189);
                    return return_v;
                }


                bool
                f_10075_4222_4240(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4222, 4240);
                    return return_v;
                }


                bool
                f_10075_4244_4268(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4244, 4268);
                    return return_v;
                }


                int
                f_10075_4208_4293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4208, 4293);
                    return 0;
                }


                bool
                f_10075_4437_4455(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 4437, 4455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_4486_4511(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 4486, 4511);
                    return return_v;
                }


                bool
                f_10075_4486_4538(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4486, 4538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_4665_4749(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4665, 4749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10075_4885_4925(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.FirstDeclarationWithExplicitBases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 4885, 4925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_5020_5043(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5020, 5043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_5020_5054(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5020, 5054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10075_5091_5122(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5091, 5122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_5156_5186(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5156, 5186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_5237_5257()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5237, 5257);
                    return return_v;
                }


                int
                f_10075_5207_5294(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, (Microsoft.CodeAnalysis.Location)location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5207, 5294);
                    return 0;
                }


                bool
                f_10075_5400_5418(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5400, 5418);
                    return return_v;
                }


                bool
                f_10075_5423_5447(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5423, 5447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10075_5582_5598(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5582, 5598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10075_5670_5748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = SynthesizedRecordClone.FindValidCloneMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5670, 5748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_5854_5874()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 5854, 5874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10075_5785_5875(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = SynthesizedRecordPrintMembers.FindValidPrintMembersMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5785, 5875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_5933_5991(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 5933, 5991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10075_6061_6139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = SynthesizedRecordClone.FindValidCloneMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 6061, 6139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_6191_6260(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 6191, 6260);
                    return return_v;
                }


                bool
                f_10075_6300_6349(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 6300, 6349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 3676, 6376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 3676, 6376);
            }
        }

        protected override void CheckInterfaces(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 6388, 9766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6794, 6869);

                var
                interfaces = f_10075_6811_6868(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6885, 7001) || true) && (f_10075_6889_6907(interfaces))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 6885, 7001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 6979, 6986);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 6885, 7001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7097, 7162);

                var
                singleDeclaration = f_10075_7121_7161(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7176, 9755) || true) && (singleDeclaration != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 7176, 9755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7239, 7291);

                    var
                    corLibrary = f_10075_7256_7290(f_10075_7256_7279(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7309, 7359);

                    var
                    conversions = f_10075_7327_7358(corLibrary)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7377, 7423);

                    var
                    location = f_10075_7392_7422(singleDeclaration)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7443, 9740);
                        foreach (var pair in f_10075_7464_7474_I(interfaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 7443, 9740);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7516, 7592);

                            MultiDictionary<NamedTypeSymbol, NamedTypeSymbol>.ValueSet
                            set = pair.Value
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7616, 7808);
                                foreach (var @interface in f_10075_7643_7646_I(set))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 7616, 7808);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7696, 7785);

                                    f_10075_7696_7784(@interface, f_10075_7727_7747(), conversions, location, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 7616, 7808);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 193);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 193);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7832, 9721) || true) && (set.Count > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 7832, 9721);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7899, 7932);

                                NamedTypeSymbol
                                other = pair.Key
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 7958, 9698);
                                    foreach (var @interface in f_10075_7985_7988_I(set))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 7958, 9698);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8046, 8183) || true) && ((object)other == @interface)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 8046, 8183);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8143, 8152);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 8046, 8183);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8363, 8439);

                                        f_10075_8363_8438(!f_10075_8377_8437(other, @interface, TypeCompareKind.ConsiderEverything));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8469, 8552);

                                        f_10075_8469_8551(f_10075_8482_8550(other, @interface, TypeCompareKind.CLRSignatureCompareOptions));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8584, 9671) || true) && (f_10075_8588_8670(other, @interface, TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 8584, 9671);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8736, 9038) || true) && (!f_10075_8741_8818(other, @interface, TypeCompareKind.ObliviousNullableModifierMatchesAny))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 8736, 9038);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 8892, 9003);

                                                f_10075_8892_9002(diagnostics, ErrorCode.WRN_DuplicateInterfaceWithNullabilityMismatchInBaseList, location, @interface, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 8736, 9038);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 8584, 9671);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 8584, 9671);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 9104, 9671) || true) && (f_10075_9108_9225(other, @interface, TypeCompareKind.IgnoreTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 9104, 9671);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 9291, 9400);

                                                f_10075_9291_9399(diagnostics, ErrorCode.ERR_DuplicateInterfaceWithTupleNamesInBaseList, location, @interface, other, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 9104, 9671);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 9104, 9671);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 9530, 9640);

                                                f_10075_9530_9639(diagnostics, ErrorCode.ERR_DuplicateInterfaceWithDifferencesInBaseList, location, @interface, other, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 9104, 9671);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 8584, 9671);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 7958, 9698);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 1741);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 1741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 7832, 9721);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 7443, 9740);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 2298);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 2298);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 7176, 9755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 6388, 9766);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_6811_6868(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 6811, 6868);
                    return return_v;
                }


                bool
                f_10075_6889_6907(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 6889, 6907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10075_7121_7161(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.FirstDeclarationWithExplicitBases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7121, 7161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_7256_7279(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 7256, 7279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_7256_7290(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 7256, 7290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10075_7327_7358(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7327, 7358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_7392_7422(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 7392, 7422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_7727_7747()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 7727, 7747);
                    return return_v;
                }


                int
                f_10075_7696_7784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, (Microsoft.CodeAnalysis.Location)location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7696, 7784);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                f_10075_7643_7646_I(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7643, 7646);
                    return return_v;
                }


                bool
                f_10075_8377_8437(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8377, 8437);
                    return return_v;
                }


                int
                f_10075_8363_8438(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8363, 8438);
                    return 0;
                }


                bool
                f_10075_8482_8550(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8482, 8550);
                    return return_v;
                }


                int
                f_10075_8469_8551(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8469, 8551);
                    return 0;
                }


                bool
                f_10075_8588_8670(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8588, 8670);
                    return return_v;
                }


                bool
                f_10075_8741_8818(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8741, 8818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_8892_9002(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 8892, 9002);
                    return return_v;
                }


                bool
                f_10075_9108_9225(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 9108, 9225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_9291_9399(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 9291, 9399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_9530_9639(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 9530, 9639);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                f_10075_7985_7988_I(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7985, 7988);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_7464_7474_I(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 7464, 7474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 6388, 9766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 6388, 9766);
            }
        }

        private SourceLocation FindBaseRefSyntax(NamedTypeSymbol baseSym)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 9921, 11128);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10011, 11089);
                    foreach (var decl in f_10075_10032_10061_I(f_10075_10032_10061(this.declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 10011, 11089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10095, 10139);

                        BaseListSyntax
                        bases = f_10075_10118_10138(decl)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10157, 11074) || true) && (bases != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 10157, 11074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10216, 10276);

                            var
                            baseBinder = f_10075_10233_10275(f_10075_10233_10258(this), bases)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10412, 10527);

                            baseBinder = f_10075_10425_10526(baseBinder, BinderFlags.SuppressConstraintChecks, this);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10551, 11055);
                                foreach (var baseTypeSyntax in f_10075_10582_10593_I(f_10075_10582_10593(bases)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 10551, 11055);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10643, 10671);

                                    var
                                    b = f_10075_10651_10670(baseTypeSyntax)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10697, 10739);

                                    var
                                    tmpDiag = f_10075_10711_10738()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10765, 10819);

                                    var
                                    curBaseSym = f_10075_10782_10813(baseBinder, b, tmpDiag).Type
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10845, 10860);

                                    f_10075_10845_10859(tmpDiag);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10888, 11032) || true) && (f_10075_10892_10918(baseSym, curBaseSym))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 10888, 11032);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 10976, 11005);

                                        return f_10075_10983_11004(b);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 10888, 11032);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 10551, 11055);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 505);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 505);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 10157, 11074);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 10011, 11089);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 1079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 1079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11105, 11117);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 9921, 11128);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_10032_10061(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 10032, 10061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                f_10075_10118_10138(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                decl)
                {
                    var return_v = GetBaseListOpt(decl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10118, 10138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_10233_10258(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 10233, 10258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10075_10233_10275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10233, 10275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10075_10425_10526(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10425, 10526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10075_10582_10593(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 10582, 10593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10075_10651_10670(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 10651, 10670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10075_10711_10738()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10711, 10738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10075_10782_10813(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10782, 10813);
                    return return_v;
                }


                int
                f_10075_10845_10859(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10845, 10859);
                    return 0;
                }


                bool
                f_10075_10892_10918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10892, 10918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_10983_11004(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10983, 11004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10075_10582_10593_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10582, 10593);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_10032_10061_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 10032, 10061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 9921, 11128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 9921, 11128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SingleTypeDeclaration FirstDeclarationWithExplicitBases()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 11314, 11722);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11404, 11683);
                    foreach (var singleDeclaration in f_10075_11438_11467_I(f_10075_11438_11467(this.declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 11404, 11683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11501, 11547);

                        var
                        bases = f_10075_11513_11546(singleDeclaration)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11565, 11668) || true) && (bases != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 11565, 11668);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11624, 11649);

                            return singleDeclaration;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 11565, 11668);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 11404, 11683);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11699, 11711);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 11314, 11722);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_11438_11467(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 11438, 11467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                f_10075_11513_11546(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                decl)
                {
                    var return_v = GetBaseListOpt(decl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 11513, 11546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_11438_11467_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 11438, 11467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 11314, 11722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 11314, 11722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Tuple<NamedTypeSymbol, ImmutableArray<NamedTypeSymbol>> GetDeclaredBases(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 11734, 12350);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11881, 12297) || true) && (f_10075_11885_11926(_lazyDeclaredBases, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 11881, 12297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 11960, 12006);

                    var
                    diagnostics = f_10075_11978_12005()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12024, 12245) || true) && (f_10075_12028_12137(ref _lazyDeclaredBases, f_10075_12080_12130(this, basesBeingResolved, diagnostics), null) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 12024, 12245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12187, 12226);

                        f_10075_12187_12225(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 12024, 12245);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12263, 12282);

                    f_10075_12263_12281(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 11881, 12297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12313, 12339);

                return _lazyDeclaredBases;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 11734, 12350);

                bool
                f_10075_11885_11926(System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 11885, 11926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10075_11978_12005()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 11978, 12005);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_12080_12130(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeDeclaredBases(basesBeingResolved, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12080, 12130);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                f_10075_12028_12137(ref System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                location1, System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                value, System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12028, 12137);
                    return return_v;
                }


                int
                f_10075_12187_12225(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12187, 12225);
                    return 0;
                }


                int
                f_10075_12263_12281(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12263, 12281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 11734, 12350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 11734, 12350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 12362, 12542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12481, 12531);

                return f_10075_12488_12530(f_10075_12488_12524(this, basesBeingResolved));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 12362, 12542);

                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_12488_12524(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBases(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12488, 12524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_12488_12530(System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 12488, 12530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 12362, 12542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 12362, 12542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 12554, 12752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12691, 12741);

                return f_10075_12698_12740(f_10075_12698_12734(this, basesBeingResolved));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 12554, 12752);

                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_12698_12734(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBases(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 12698, 12734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_12698_12740(System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 12698, 12740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 12554, 12752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 12554, 12752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<NamedTypeSymbol, ImmutableArray<NamedTypeSymbol>> MakeDeclaredBases(ConsList<TypeSymbol> basesBeingResolved, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 12764, 17920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 12938, 13189) || true) && (f_10075_12942_12955(this) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 12938, 13189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13062, 13174);

                    return f_10075_13069_13173(null, ImmutableArray<NamedTypeSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 12938, 13189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13205, 13241);

                var
                reportedPartialConflict = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13255, 13362);

                f_10075_13255_13361(basesBeingResolved == null || (DynAbs.Tracing.TraceSender.Expression_False(10075, 13268, 13360) || !f_10075_13299_13360(basesBeingResolved, f_10075_13336_13359(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13376, 13456);

                var
                newBasesBeingResolved = f_10075_13404_13455(basesBeingResolved, f_10075_13431_13454(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13470, 13535);

                var
                baseInterfaces = f_10075_13491_13534()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13551, 13583);

                NamedTypeSymbol
                baseType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13597, 13636);

                SourceLocation
                baseTypeLocation = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13652, 13775);

                var
                interfaceLocations = f_10075_13677_13774()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13791, 15819);
                    foreach (var decl in f_10075_13812_13841_I(f_10075_13812_13841(this.declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 13791, 15819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 13875, 14000);

                        Tuple<NamedTypeSymbol, ImmutableArray<NamedTypeSymbol>>
                        one = f_10075_13937_13999(this, newBasesBeingResolved, decl, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14018, 14052) || true) && ((object)one == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14018, 14052);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14043, 14052);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14018, 14052);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14072, 14097);

                        var
                        partBase = f_10075_14087_14096(one)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14115, 14146);

                        var
                        partInterfaces = f_10075_14136_14145(one)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14164, 15487) || true) && (!reportedPartialConflict)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14164, 15487);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14234, 15468) || true) && ((object)baseType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14234, 15468);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14312, 14332);

                                baseType = partBase;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14358, 14395);

                                baseTypeLocation = f_10075_14377_14394(decl);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14234, 15468);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14234, 15468);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14445, 15468) || true) && (f_10075_14449_14466(baseType) == TypeKind.Error && (DynAbs.Tracing.TraceSender.Expression_True(10075, 14449, 14512) && (object)partBase != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14445, 15468);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14681, 14727);

                                    partInterfaces = partInterfaces.Add(baseType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14753, 14773);

                                    baseType = partBase;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14799, 14836);

                                    baseTypeLocation = f_10075_14818_14835(decl);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14445, 15468);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14445, 15468);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 14886, 15468) || true) && ((object)partBase != null && (DynAbs.Tracing.TraceSender.Expression_True(10075, 14890, 14993) && !f_10075_14919_14993(partBase, baseType, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 14890, 15032) && f_10075_14997_15014(partBase) != TypeKind.Error))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 14886, 15468);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15133, 15216);

                                        var
                                        info = f_10075_15144_15215(diagnostics, ErrorCode.ERR_PartialMultipleBases, f_10075_15196_15205()[0], this)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15242, 15325);

                                        baseType = f_10075_15253_15324(baseType, LookupResultKind.Ambiguous, info);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15351, 15388);

                                        baseTypeLocation = f_10075_15370_15387(decl);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15414, 15445);

                                        reportedPartialConflict = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14886, 15468);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14445, 15468);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14234, 15468);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 14164, 15487);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15507, 15804);
                            foreach (var t in f_10075_15525_15539_I(partInterfaces))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 15507, 15804);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15581, 15785) || true) && (!f_10075_15586_15619(interfaceLocations, t))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 15581, 15785);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15669, 15691);

                                    f_10075_15669_15690(baseInterfaces, t);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15717, 15762);

                                    f_10075_15717_15761(interfaceLocations, t, f_10075_15743_15760(decl));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 15581, 15785);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 15507, 15804);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 298);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 298);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 13791, 15819);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 2029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 2029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15835, 15885);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15901, 16350) || true) && (f_10075_15905_15921(declaration) == DeclarationKind.Record)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 15901, 16350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 15981, 16081);

                    var
                    type = f_10075_15992_16080(f_10075_15992_16064(f_10075_15992_16012(), WellKnownType.System_IEquatable_T), this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16099, 16335) || true) && (f_10075_16103_16172(baseInterfaces, type, SymbolEqualityComparer.AllIgnoreOptions) < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 16099, 16335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16218, 16243);

                        f_10075_16218_16242(baseInterfaces, type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16265, 16316);

                        f_10075_16265_16315(type, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 16099, 16335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 15901, 16350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16366, 17062) || true) && ((object)baseType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 16366, 17062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16428, 16467);

                    f_10075_16428_16466(baseTypeLocation != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16485, 16717) || true) && (f_10075_16489_16506(baseType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 16485, 16717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16617, 16698);

                        f_10075_16617_16697(                    // '{1}': cannot derive from static class '{0}'
                                            diagnostics, ErrorCode.ERR_StaticBaseClass, baseTypeLocation, baseType, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 16485, 16717);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16737, 17047) || true) && (!f_10075_16742_16800(this, baseType, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 16737, 17047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 16947, 17028);

                        f_10075_16947_17027(                    // Inconsistent accessibility: base class '{1}' is less accessible than class '{0}'
                                            diagnostics, ErrorCode.ERR_BadVisBaseClass, baseTypeLocation, this, baseType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 16737, 17047);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 16366, 17062);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17078, 17137);

                var
                baseInterfacesRO = f_10075_17101_17136(baseInterfaces)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17151, 17690) || true) && (f_10075_17155_17176() != Accessibility.Private && (DynAbs.Tracing.TraceSender.Expression_True(10075, 17155, 17216) && f_10075_17205_17216()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 17151, 17690);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17250, 17675);
                        foreach (var i in f_10075_17268_17284_I(baseInterfacesRO))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 17250, 17675);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17326, 17656) || true) && (!f_10075_17331_17383(i, this, ref useSiteDiagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 17326, 17656);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17550, 17633);

                                f_10075_17550_17632(                        // Inconsistent accessibility: base interface '{1}' is less accessible than interface '{0}'
                                                        diagnostics, ErrorCode.ERR_BadVisBaseInterface, f_10075_17601_17622(interfaceLocations, i), this, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 17326, 17656);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 17250, 17675);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 426);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 17151, 17690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17706, 17732);

                f_10075_17706_17731(
                            interfaceLocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17748, 17798);

                f_10075_17748_17797(
                            diagnostics, f_10075_17764_17773()[0], useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 17814, 17909);

                return f_10075_17821_17908(baseType, baseInterfacesRO);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 12764, 17920);

                Microsoft.CodeAnalysis.TypeKind
                f_10075_12942_12955(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 12942, 12955);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_13069_13173(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                item2)
                {
                    var return_v = new System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13069, 13173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_13336_13359(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 13336, 13359);
                    return return_v;
                }


                bool
                f_10075_13299_13360(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13299, 13360);
                    return return_v;
                }


                int
                f_10075_13255_13361(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13255, 13361);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_13431_13454(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 13431, 13454);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10075_13404_13455(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13404, 13455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_13491_13534()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13491, 13534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.SourceLocation>
                f_10075_13677_13774()
                {
                    var return_v = SpecializedSymbolCollections.GetPooledSymbolDictionaryInstance<NamedTypeSymbol, SourceLocation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13677, 13774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_13812_13841(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 13812, 13841);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_13937_13999(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                newBasesBeingResolved, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                decl, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeOneDeclaredBases(newBasesBeingResolved, decl, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13937, 13999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_14087_14096(System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14087, 14096);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_14136_14145(System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14136, 14145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_14377_14394(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14377, 14394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_14449_14466(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14449, 14466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_14818_14835(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14818, 14835);
                    return return_v;
                }


                bool
                f_10075_14919_14993(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 14919, 14993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_14997_15014(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 14997, 15014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_15196_15205()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 15196, 15205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_15144_15215(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15144, 15215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10075_15253_15324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15253, 15324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_15370_15387(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 15370, 15387);
                    return return_v;
                }


                bool
                f_10075_15586_15619(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.SourceLocation>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15586, 15619);
                    return return_v;
                }


                int
                f_10075_15669_15690(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15669, 15690);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_15743_15760(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 15743, 15760);
                    return return_v;
                }


                int
                f_10075_15717_15761(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.SourceLocation>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.CodeAnalysis.SourceLocation
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15717, 15761);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_15525_15539_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15525, 15539);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10075_13812_13841_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 13812, 13841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10075_15905_15921(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 15905, 15921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_15992_16012()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 15992, 16012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_15992_16064(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15992, 16064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_15992_16080(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 15992, 16080);
                    return return_v;
                }


                int
                f_10075_16103_16172(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                equalityComparer)
                {
                    var return_v = this_param.IndexOf(item, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16103, 16172);
                    return return_v;
                }


                int
                f_10075_16218_16242(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16218, 16242);
                    return 0;
                }


                int
                f_10075_16265_16315(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16265, 16315);
                    return 0;
                }


                int
                f_10075_16428_16466(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16428, 16466);
                    return 0;
                }


                bool
                f_10075_16489_16506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 16489, 16506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_16617_16697(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16617, 16697);
                    return return_v;
                }


                bool
                f_10075_16742_16800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = symbol.IsNoMoreVisibleThan((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16742, 16800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_16947_17027(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 16947, 17027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_17101_17136(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17101, 17136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10075_17155_17176()
                {
                    var return_v = DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 17155, 17176);
                    return return_v;
                }


                bool
                f_10075_17205_17216()
                {
                    var return_v = IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 17205, 17216);
                    return return_v;
                }


                bool
                f_10075_17331_17383(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                sym, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = type.IsAtLeastAsVisibleAs((Microsoft.CodeAnalysis.CSharp.Symbol)sym, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17331, 17383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_17601_17622(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.SourceLocation>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 17601, 17622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_17550_17632(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17550, 17632);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_17268_17284_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17268, 17284);
                    return return_v;
                }


                int
                f_10075_17706_17731(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.SourceLocation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17706, 17731);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_17764_17773()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 17764, 17773);
                    return return_v;
                }


                bool
                f_10075_17748_17797(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17748, 17797);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_17821_17908(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                item1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                item2)
                {
                    var return_v = new System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 17821, 17908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 12764, 17920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 12764, 17920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BaseListSyntax GetBaseListOpt(SingleTypeDeclaration decl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10075, 17932, 18277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18029, 18238) || true) && (f_10075_18033_18057(decl))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 18029, 18238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18091, 18173);

                    var
                    typeDeclaration = (BaseTypeDeclarationSyntax)f_10075_18140_18172(f_10075_18140_18160(decl))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18191, 18223);

                    return f_10075_18198_18222(typeDeclaration);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 18029, 18238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18254, 18266);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10075, 17932, 18277);

                bool
                f_10075_18033_18057(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.HasBaseDeclarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 18033, 18057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10075_18140_18160(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 18140, 18160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10075_18140_18172(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 18140, 18172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
                f_10075_18198_18222(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.BaseList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 18198, 18222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 17932, 18277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 17932, 18277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<NamedTypeSymbol, ImmutableArray<NamedTypeSymbol>> MakeOneDeclaredBases(ConsList<TypeSymbol> newBasesBeingResolved, SingleTypeDeclaration decl, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 18408, 28133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18616, 18660);

                BaseListSyntax
                bases = f_10075_18639_18659(decl)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18674, 18752) || true) && (bases == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 18674, 18752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18725, 18737);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 18674, 18752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18768, 18801);

                NamedTypeSymbol
                localBase = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18815, 18881);

                var
                localInterfaces = f_10075_18837_18880()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 18895, 18955);

                var
                baseBinder = f_10075_18912_18954(f_10075_18912_18937(this), bases)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19223, 19338);

                baseBinder = f_10075_19236_19337(baseBinder, BinderFlags.SuppressConstraintChecks, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19354, 19365);

                int
                i = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19379, 27687);
                    foreach (var baseTypeSyntax in f_10075_19410_19421_I(f_10075_19410_19421(bases)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 19379, 27687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19455, 19459);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19477, 19514);

                        var
                        typeSyntax = f_10075_19494_19513(baseTypeSyntax)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19532, 19754) || true) && (f_10075_19536_19553(typeSyntax) != SyntaxKind.PredefinedType && (DynAbs.Tracing.TraceSender.Expression_True(10075, 19536, 19624) && !f_10075_19587_19624(f_10075_19606_19623(typeSyntax))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 19532, 19754);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19666, 19735);

                            f_10075_19666_19734(diagnostics, ErrorCode.ERR_BadBaseType, f_10075_19709_19733(typeSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 19532, 19754);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19774, 19820);

                        var
                        location = f_10075_19789_19819(typeSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19840, 19860);

                        TypeSymbol
                        baseType
                        = default(TypeSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19880, 24061) || true) && (i == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10075, 19884, 19920) && f_10075_19894_19902() == TypeKind.Class))
                        ) // allow class in the first position

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 19880, 24061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 19999, 20083);

                            baseType = f_10075_20010_20077(baseBinder, typeSyntax, diagnostics, newBasesBeingResolved).Type;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 20107, 20158);

                            SpecialType
                            baseSpecialType = f_10075_20137_20157(baseType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 20180, 21452) || true) && (f_10075_20184_20221(baseSpecialType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 20180, 21452);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 20372, 21429) || true) && (f_10075_20376_20392(this) == SpecialType.System_Enum && (DynAbs.Tracing.TraceSender.Expression_True(10075, 20376, 20470) && baseSpecialType == SpecialType.System_ValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10075, 20376, 20609) || f_10075_20503_20519(this) == SpecialType.System_MulticastDelegate && (DynAbs.Tracing.TraceSender.Expression_True(10075, 20503, 20609) && baseSpecialType == SpecialType.System_Delegate)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 20372, 21429);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 20372, 21429);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 20372, 21429);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 20735, 21429) || true) && (baseSpecialType == SpecialType.System_Array && (DynAbs.Tracing.TraceSender.Expression_True(10075, 20739, 20847) && f_10075_20786_20820(f_10075_20786_20809(this)) == f_10075_20824_20847(this)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 20735, 21429);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 20735, 21429);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 20735, 21429);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21280, 21363);

                                        f_10075_21280_21362(                            // '{0}' cannot derive from special class '{1}'
                                                                    diagnostics, ErrorCode.ERR_DeriveFromEnumOrValueType, location, this, baseType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21393, 21402);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 20735, 21429);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 20372, 21429);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 20180, 21452);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21476, 21758) || true) && (f_10075_21480_21497(baseType) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 21480, 21515) && f_10075_21501_21515_M(!this.IsStatic)))
                            ) // Give precedence to ERR_StaticDerivedFromNonObject

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 21476, 21758);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21618, 21700);

                                f_10075_21618_21699(diagnostics, ErrorCode.ERR_CantDeriveFromSealedType, location, this, baseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21726, 21735);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 21476, 21758);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 21782, 21832);

                            bool
                            baseTypeIsErrorWithoutInterfaceGuess = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22302, 22822) || true) && (f_10075_22306_22323(baseType) == TypeKind.Error)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 22302, 22822);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22391, 22435);

                                baseTypeIsErrorWithoutInterfaceGuess = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22463, 22524);

                                TypeKind
                                guessTypeKind = f_10075_22488_22523(baseType)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22550, 22799) || true) && (guessTypeKind == TypeKind.Interface)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 22550, 22799);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22727, 22772);

                                    baseTypeIsErrorWithoutInterfaceGuess = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 22550, 22799);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 22302, 22822);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 22846, 23876) || true) && ((f_10075_22851_22868(baseType) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10075, 22851, 22954) || f_10075_22916_22933(baseType) == TypeKind.Delegate) || (DynAbs.Tracing.TraceSender.Expression_False(10075, 22851, 23020) || f_10075_22984_23001(baseType) == TypeKind.Struct) || (DynAbs.Tracing.TraceSender.Expression_False(10075, 22851, 23086) || baseTypeIsErrorWithoutInterfaceGuess)) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 22850, 23143) && ((object)localBase == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 22846, 23876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23193, 23231);

                                localBase = (NamedTypeSymbol)baseType;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23257, 23297);

                                f_10075_23257_23296((object)localBase != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23323, 23818) || true) && (f_10075_23327_23340(this) && (DynAbs.Tracing.TraceSender.Expression_True(10075, 23327, 23394) && f_10075_23344_23365(localBase) != SpecialType.System_Object))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 23323, 23818);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23574, 23670);

                                    var
                                    info = f_10075_23585_23669(diagnostics, ErrorCode.ERR_StaticDerivedFromNonObject, location, this, localBase)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23700, 23791);

                                    localBase = f_10075_23712_23790(localBase, LookupResultKind.NotReferencable, info);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 23323, 23818);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23844, 23853);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 22846, 23876);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 19880, 24061);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 19880, 24061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 23958, 24042);

                            baseType = f_10075_23969_24036(baseBinder, typeSyntax, diagnostics, newBasesBeingResolved).Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 19880, 24061);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24081, 27672);

                        switch (f_10075_24089_24106(baseType))
                        {

                            case TypeKind.Interface:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24198, 25014);
                                    foreach (var t in f_10075_24216_24231_I(localInterfaces))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24198, 25014);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24289, 24987) || true) && (f_10075_24293_24347(t, baseType, TypeCompareKind.ConsiderEverything))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24289, 24987);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24413, 24493);

                                            f_10075_24413_24492(diagnostics, ErrorCode.ERR_DuplicateInterfaceInBaseList, location, baseType);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24289, 24987);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24289, 24987);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24559, 24987) || true) && (f_10075_24563_24634(t, baseType, TypeCompareKind.ObliviousNullableModifierMatchesAny))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24559, 24987);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 24847, 24956);

                                                f_10075_24847_24955(                                // duplicates with ?/! differences are reported later, we report local differences between oblivious and ?/! here
                                                                                diagnostics, ErrorCode.WRN_DuplicateInterfaceWithNullabilityMismatchInBaseList, location, baseType, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24559, 24987);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24289, 24987);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24198, 25014);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 817);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 817);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25042, 25308) || true) && (f_10075_25046_25059(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 25042, 25308);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25199, 25281);

                                    f_10075_25199_25280(                            // '{0}': static classes cannot implement interfaces
                                                                diagnostics, ErrorCode.ERR_StaticClassInterfaceImpl, location, this, baseType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 25042, 25308);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25336, 25602) || true) && (f_10075_25340_25358(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 25336, 25602);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25495, 25575);

                                    f_10075_25495_25574(                            // '{0}': ref structs cannot implement interfaces
                                                                diagnostics, ErrorCode.ERR_RefStructInterfaceImpl, location, this, baseType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 25336, 25602);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25630, 25831) || true) && (f_10075_25634_25660(baseType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 25630, 25831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25718, 25804);

                                    f_10075_25718_25803(diagnostics, ErrorCode.ERR_DeriveFromConstructedDynamic, location, this, baseType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 25630, 25831);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25859, 25906);

                                f_10075_25859_25905(
                                                        localInterfaces, baseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 25932, 25941);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            case TypeKind.Class:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26011, 26702) || true) && (f_10075_26015_26023() == TypeKind.Class)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 26011, 26702);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26099, 26675) || true) && ((object)localBase == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 26099, 26675);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26194, 26232);

                                        localBase = (NamedTypeSymbol)baseType;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26266, 26338);

                                        f_10075_26266_26337(diagnostics, ErrorCode.ERR_BaseClassMustBeFirst, location, baseType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26372, 26381);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 26099, 26675);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 26099, 26675);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26511, 26601);

                                        f_10075_26511_26600(diagnostics, ErrorCode.ERR_NoMultipleInheritance, location, this, localBase, baseType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26635, 26644);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 26099, 26675);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 26011, 26702);
                                }

                                goto default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            case TypeKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26819, 26889);

                                f_10075_26819_26888(diagnostics, ErrorCode.ERR_DerivingFromATyVar, location, baseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 26915, 26924);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            case TypeKind.Error:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27092, 27139);

                                f_10075_27092_27138(                        // put the error type in the interface list so we don't lose track of it
                                                        localInterfaces, baseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27165, 27174);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            case TypeKind.Dynamic:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27246, 27311);

                                f_10075_27246_27310(diagnostics, ErrorCode.ERR_DeriveFromDynamic, location, this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27337, 27346);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            case TypeKind.Submission:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27421, 27481);

                                throw f_10075_27427_27480(f_10075_27462_27479(baseType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 24081, 27672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27539, 27618);

                                f_10075_27539_27617(diagnostics, ErrorCode.ERR_NonInterfaceInInterfaceList, location, baseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27644, 27653);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 24081, 27672);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 19379, 27687);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 8309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 8309);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27703, 27990) || true) && (f_10075_27707_27723(this) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10075, 27707, 27813) && ((object)localBase != null || (DynAbs.Tracing.TraceSender.Expression_False(10075, 27757, 27812) || f_10075_27786_27807(localInterfaces) != 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 27703, 27990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27847, 27880);

                    var
                    name = f_10075_27858_27879(f_10075_27866_27878(bases))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 27898, 27975);

                    f_10075_27898_27974(diagnostics, ErrorCode.ERR_ObjectCantHaveBases, f_10075_27949_27973(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 27703, 27990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28006, 28122);

                return f_10075_28013_28121(localBase, f_10075_28084_28120(localInterfaces));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 18408, 28133);

                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                f_10075_18639_18659(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                decl)
                {
                    var return_v = GetBaseListOpt(decl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 18639, 18659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_18837_18880()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 18837, 18880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_18912_18937(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 18912, 18937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10075_18912_18954(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 18912, 18954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10075_19236_19337(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19236, 19337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10075_19410_19421(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 19410, 19421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10075_19494_19513(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 19494, 19513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10075_19536_19553(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19536, 19553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10075_19606_19623(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19606, 19623);
                    return return_v;
                }


                bool
                f_10075_19587_19624(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsName(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19587, 19624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10075_19709_19733(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19709, 19733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_19666_19734(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19666, 19734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_19789_19819(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19789, 19819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_19894_19902()
                {
                    var return_v = TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 19894, 19902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10075_20010_20077(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 20010, 20077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_20137_20157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20137, 20157);
                    return return_v;
                }


                bool
                f_10075_20184_20221(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = IsRestrictedBaseType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 20184, 20221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_20376_20392(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20376, 20392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_20503_20519(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20503, 20519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_20786_20809(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20786, 20809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_20786_20820(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20786, 20820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10075_20824_20847(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 20824, 20847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_21280_21362(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 21280, 21362);
                    return return_v;
                }


                bool
                f_10075_21480_21497(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 21480, 21497);
                    return return_v;
                }


                bool
                f_10075_21501_21515_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 21501, 21515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_21618_21699(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 21618, 21699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_22306_22323(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 22306, 22323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_22488_22523(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNonErrorTypeKindGuess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 22488, 22523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_22851_22868(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 22851, 22868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_22916_22933(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 22916, 22933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_22984_23001(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 22984, 23001);
                    return return_v;
                }


                int
                f_10075_23257_23296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 23257, 23296);
                    return 0;
                }


                bool
                f_10075_23327_23340(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 23327, 23340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_23344_23365(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 23344, 23365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_23585_23669(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 23585, 23669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10075_23712_23790(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 23712, 23790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10075_23969_24036(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 23969, 24036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_24089_24106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 24089, 24106);
                    return return_v;
                }


                bool
                f_10075_24293_24347(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 24293, 24347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_24413_24492(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 24413, 24492);
                    return return_v;
                }


                bool
                f_10075_24563_24634(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 24563, 24634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_24847_24955(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 24847, 24955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_24216_24231_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 24216, 24231);
                    return return_v;
                }


                bool
                f_10075_25046_25059(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 25046, 25059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_25199_25280(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 25199, 25280);
                    return return_v;
                }


                bool
                f_10075_25340_25358(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 25340, 25358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_25495_25574(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 25495, 25574);
                    return return_v;
                }


                bool
                f_10075_25634_25660(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 25634, 25660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_25718_25803(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 25718, 25803);
                    return return_v;
                }


                int
                f_10075_25859_25905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 25859, 25905);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_26015_26023()
                {
                    var return_v = TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 26015, 26023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_26266_26337(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 26266, 26337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_26511_26600(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 26511, 26600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_26819_26888(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 26819, 26888);
                    return return_v;
                }


                int
                f_10075_27092_27138(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27092, 27138);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_27246_27310(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27246, 27310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10075_27462_27479(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 27462, 27479);
                    return return_v;
                }


                System.Exception
                f_10075_27427_27480(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27427, 27480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_27539_27617(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27539, 27617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10075_19410_19421_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 19410, 19421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_27707_27723(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 27707, 27723);
                    return return_v;
                }


                int
                f_10075_27786_27807(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 27786, 27807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10075_27866_27878(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 27866, 27878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10075_27858_27879(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = GetName(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27858, 27879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_27949_27973(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27949, 27973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_27898_27974(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 27898, 27974);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_28084_28120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 28084, 28120);
                    return return_v;
                }


                System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10075_28013_28121(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                item1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                item2)
                {
                    var return_v = new System.Tuple<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 28013, 28121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 18408, 28133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 18408, 28133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsRestrictedBaseType(SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10075, 28272, 28744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28362, 28704);

                switch (specialType)
                {

                    case SpecialType.System_Array:
                    case SpecialType.System_Enum:
                    case SpecialType.System_Delegate:
                    case SpecialType.System_MulticastDelegate:
                    case SpecialType.System_ValueType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 28362, 28704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28677, 28689);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 28362, 28704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28720, 28733);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10075, 28272, 28744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 28272, 28744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 28272, 28744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> MakeAcyclicInterfaces(ConsList<TypeSymbol> basesBeingResolved, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 28756, 31014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28910, 28939);

                var
                typeKind = f_10075_28925_28938(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 28955, 29199) || true) && (typeKind == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 28955, 29199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29018, 29121);

                    f_10075_29018_29120(f_10075_29031_29078(this, basesBeingResolved: null).IsEmpty, "Computation skipped for enums");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29139, 29184);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 28955, 29199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29215, 29302);

                var
                declaredInterfaces = f_10075_29240_29301(this, basesBeingResolved: basesBeingResolved)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29316, 29368);

                bool
                isInterface = (typeKind == TypeKind.Interface)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29384, 29488);

                ArrayBuilder<NamedTypeSymbol>
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10075, 29423, 29434) || ((isInterface && DynAbs.Tracing.TraceSender.Conditional_F2(10075, 29437, 29480)) || DynAbs.Tracing.TraceSender.Conditional_F3(10075, 29483, 29487))) ? f_10075_29437_29480() : null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29502, 30917);
                    foreach (var t in f_10075_29520_29538_I(declaredInterfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 29502, 30917);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29572, 30113) || true) && (isInterface)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 29572, 30113);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29629, 30094) || true) && (f_10075_29633_29685(depends: t, on: this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 29629, 30094);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29735, 29924);

                                f_10075_29735_29923(result, f_10075_29746_29922(t, LookupResultKind.NotReferencable, f_10075_29840_29921(diagnostics, ErrorCode.ERR_CycleInInterfaceInheritance, f_10075_29899_29908()[0], this, t)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 29950, 29959);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 29629, 30094);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 29629, 30094);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30057, 30071);

                                f_10075_30057_30070(result, t);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 29629, 30094);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 29572, 30113);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30133, 30183);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30203, 30732) || true) && (f_10075_30207_30229(t) != f_10075_30233_30258(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 30203, 30732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30300, 30348);

                            f_10075_30300_30347(t, ref useSiteDiagnostics);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30372, 30713);
                                foreach (var @interface in f_10075_30399_30434_I(f_10075_30399_30434(t)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 30372, 30713);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30484, 30690) || true) && (f_10075_30488_30519(@interface) != f_10075_30523_30548(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 30484, 30690);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30606, 30663);

                                        f_10075_30606_30662(@interface, ref useSiteDiagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 30484, 30690);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 30372, 30713);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 342);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 342);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 30203, 30732);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30752, 30902) || true) && (!f_10075_30757_30791(useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 30752, 30902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30833, 30883);

                            f_10075_30833_30882(diagnostics, f_10075_30849_30858()[0], useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 30752, 30902);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 29502, 30917);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 1, 1416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 1, 1416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 30933, 31003);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10075, 30940, 30951) || ((isInterface && DynAbs.Tracing.TraceSender.Conditional_F2(10075, 30954, 30981)) || DynAbs.Tracing.TraceSender.Conditional_F3(10075, 30984, 31002))) ? f_10075_30954_30981(result) : declaredInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 28756, 31014);

                Microsoft.CodeAnalysis.TypeKind
                f_10075_28925_28938(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 28925, 28938);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_29031_29078(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29031, 29078);
                    return return_v;
                }


                int
                f_10075_29018_29120(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29018, 29120);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_29240_29301(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29240, 29301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_29437_29480()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29437, 29480);
                    return return_v;
                }


                bool
                f_10075_29633_29685(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                depends, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                on)
                {
                    var return_v = BaseTypeAnalysis.TypeDependsOn(depends: depends, on: (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)on);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29633, 29685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_29899_29908()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 29899, 29908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_29840_29921(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29840, 29921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10075_29746_29922(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29746, 29922);
                    return return_v;
                }


                int
                f_10075_29735_29923(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29735, 29923);
                    return 0;
                }


                int
                f_10075_30057_30070(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30057, 30070);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_30207_30229(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30207, 30229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_30233_30258(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30233, 30258);
                    return return_v;
                }


                int
                f_10075_30300_30347(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30300, 30347);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_30399_30434(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30399, 30434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_30488_30519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30488, 30519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_30523_30548(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30523, 30548);
                    return return_v;
                }


                int
                f_10075_30606_30662(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30606, 30662);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_30399_30434_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30399, 30434);
                    return return_v;
                }


                bool
                f_10075_30757_30791(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30757, 30791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_30849_30858()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 30849, 30858);
                    return return_v;
                }


                bool
                f_10075_30833_30882(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30833, 30882);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_29520_29538_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 29520, 29538);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10075_30954_30981(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 30954, 30981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 28756, 31014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 28756, 31014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol MakeAcyclicBaseType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10075, 31026, 33810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31121, 31150);

                var
                typeKind = f_10075_31136_31149(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31164, 31208);

                var
                compilation = f_10075_31182_31207(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31222, 31251);

                NamedTypeSymbol
                declaredBase
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31265, 31664) || true) && (typeKind == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31265, 31664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31328, 31437);

                    f_10075_31328_31436((object)f_10075_31349_31394(this, basesBeingResolved: null) == null, "Computation skipped for enums");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31455, 31522);

                    declaredBase = f_10075_31470_31521(compilation, SpecialType.System_Enum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31265, 31664);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31265, 31664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31588, 31649);

                    declaredBase = f_10075_31603_31648(this, basesBeingResolved: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31265, 31664);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31680, 32716) || true) && ((object)declaredBase == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31680, 32716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31746, 32701);

                    switch (typeKind)
                    {

                        case TypeKind.Class:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31746, 32701);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31852, 31998) || true) && (f_10075_31856_31872(this) == SpecialType.System_Object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31852, 31998);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 31959, 31971);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31852, 31998);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32026, 32095);

                            declaredBase = f_10075_32041_32094(compilation, SpecialType.System_Object);
                            DynAbs.Tracing.TraceSender.TraceBreak(10075, 32121, 32127);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31746, 32701);

                        case TypeKind.Struct:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31746, 32701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32198, 32270);

                            declaredBase = f_10075_32213_32269(compilation, SpecialType.System_ValueType);
                            DynAbs.Tracing.TraceSender.TraceBreak(10075, 32296, 32302);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31746, 32701);

                        case TypeKind.Interface:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31746, 32701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32376, 32388);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31746, 32701);

                        case TypeKind.Delegate:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31746, 32701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32461, 32541);

                            declaredBase = f_10075_32476_32540(compilation, SpecialType.System_MulticastDelegate);
                            DynAbs.Tracing.TraceSender.TraceBreak(10075, 32567, 32573);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31746, 32701);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 31746, 32701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32631, 32682);

                            throw f_10075_32637_32681(typeKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31746, 32701);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 31680, 32716);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32732, 33018) || true) && (f_10075_32736_32786(declaredBase, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 32732, 33018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 32820, 33003);

                    return f_10075_32827_33002(declaredBase, LookupResultKind.NotReferencable, f_10075_32924_33001(diagnostics, ErrorCode.ERR_CircularBase, f_10075_32968_32977()[0], declaredBase, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 32732, 33018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33034, 33076);

                f_10075_33034_33075(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33092, 33142);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33156, 33195);

                NamedTypeSymbol
                current = declaredBase
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 33211, 33574);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33246, 33374) || true) && (f_10075_33250_33278(current) == f_10075_33282_33307(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 33246, 33374);
                                DynAbs.Tracing.TraceSender.TraceBreak(10075, 33349, 33355);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 33246, 33374);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33394, 33448);

                            f_10075_33394_33447(
                                            current, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33466, 33513);

                            current = f_10075_33476_33512(current);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 33211, 33574);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33211, 33574) || true) && ((object)current != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10075, 33211, 33574);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10075, 33211, 33574);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33590, 33763) || true) && (!f_10075_33595_33629(useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10075, 33590, 33763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33663, 33748);

                    f_10075_33663_33747(diagnostics, f_10075_33679_33710(this, declaredBase) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SourceLocation>(10075, 33679, 33726) ?? f_10075_33714_33723()[0]), useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10075, 33590, 33763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10075, 33779, 33799);

                return declaredBase;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10075, 31026, 33810);

                Microsoft.CodeAnalysis.TypeKind
                f_10075_31136_31149(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 31136, 31149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_31182_31207(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 31182, 31207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_31349_31394(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 31349, 31394);
                    return return_v;
                }


                int
                f_10075_31328_31436(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 31328, 31436);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_31470_31521(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 31470, 31521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_31603_31648(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 31603, 31648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10075_31856_31872(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 31856, 31872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_32041_32094(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32041, 32094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_32213_32269(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32213, 32269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_32476_32540(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32476, 32540);
                    return return_v;
                }


                System.Exception
                f_10075_32637_32681(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32637, 32681);
                    return return_v;
                }


                bool
                f_10075_32736_32786(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                depends, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                on)
                {
                    var return_v = BaseTypeAnalysis.TypeDependsOn(depends, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)on);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32736, 32786);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_32968_32977()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 32968, 32977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10075_32924_33001(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32924, 33001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10075_32827_33002(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 32827, 33002);
                    return return_v;
                }


                int
                f_10075_33034_33075(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    this_param.SetKnownToHaveNoDeclaredBaseCycles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 33034, 33075);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_33250_33278(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 33250, 33278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10075_33282_33307(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 33282, 33307);
                    return return_v;
                }


                int
                f_10075_33394_33447(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 33394, 33447);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10075_33476_33512(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 33476, 33512);
                    return return_v;
                }


                bool
                f_10075_33595_33629(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 33595, 33629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10075_33679_33710(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseSym)
                {
                    var return_v = this_param.FindBaseRefSyntax(baseSym);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 33679, 33710);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10075_33714_33723()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10075, 33714, 33723);
                    return return_v;
                }


                bool
                f_10075_33663_33747(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10075, 33663, 33747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10075, 31026, 33810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10075, 31026, 33810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
