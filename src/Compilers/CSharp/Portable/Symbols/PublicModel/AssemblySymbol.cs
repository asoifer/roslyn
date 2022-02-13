// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal abstract class AssemblySymbol : Symbol, IAssemblySymbol
    {
        internal abstract Symbols.AssemblySymbol UnderlyingAssemblySymbol { get; }

        INamespaceSymbol IAssemblySymbol.GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 853, 970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 889, 955);

                    return f_10636_896_954(f_10636_896_936(f_10636_896_920()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 853, 970);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10636_896_920()
                    {
                        var return_v = UnderlyingAssemblySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 896, 920);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10636_896_936(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 896, 936);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol?
                    f_10636_896_954(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 896, 954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 780, 981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 780, 981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<IModuleSymbol> IAssemblySymbol.Modules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1068, 1273);

                    var listYield = new List<IModuleSymbol>();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1104, 1258);
                        foreach (var module in f_10636_1127_1159_I(f_10636_1127_1159(f_10636_1127_1151())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 1104, 1258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1201, 1239);

                            listYield.Add(f_10636_1214_1238(module));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 1104, 1258);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10636, 1, 155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10636, 1, 155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1068, 1273);

                    return listYield;

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10636_1127_1151()
                    {
                        var return_v = UnderlyingAssemblySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1127, 1151);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10636_1127_1159(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1127, 1159);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IModuleSymbol?
                    f_10636_1214_1238(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 1214, 1238);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10636_1127_1159_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 1127, 1159);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 993, 1284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 993, 1284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IAssemblySymbol.IsInteractive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1331, 1372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1334, 1372);
                    return f_10636_1334_1372(f_10636_1334_1358()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1331, 1372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1331, 1372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1331, 1372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AssemblyIdentity IAssemblySymbol.Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1427, 1463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1430, 1463);
                    return f_10636_1430_1463(f_10636_1430_1454()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1427, 1463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1427, 1463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1427, 1463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ICollection<string> IAssemblySymbol.TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1522, 1559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1525, 1559);
                    return f_10636_1525_1559(f_10636_1525_1549()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1522, 1559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1522, 1559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1522, 1559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ICollection<string> IAssemblySymbol.NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1623, 1665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1626, 1665);
                    return f_10636_1626_1665(f_10636_1626_1650()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1623, 1665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1623, 1665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1623, 1665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IAssemblySymbol.MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1728, 1784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1731, 1784);
                    return f_10636_1731_1784(f_10636_1731_1755()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1728, 1784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1728, 1784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1728, 1784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AssemblyMetadata IAssemblySymbol.GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1844, 1885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 1847, 1885);
                return f_10636_1847_1885(f_10636_1847_1871()); DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1844, 1885);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1844, 1885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1844, 1885);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
            f_10636_1847_1871()
            {
                var return_v = UnderlyingAssemblySymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1847, 1871);
                return return_v;
            }


            Microsoft.CodeAnalysis.AssemblyMetadata
            f_10636_1847_1885(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
            this_param)
            {
                var return_v = this_param.GetMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 1847, 1885);
                return return_v;
            }

        }

        INamedTypeSymbol IAssemblySymbol.ResolveForwardedType(string fullyQualifiedMetadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 1898, 2121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2011, 2110);

                return f_10636_2018_2109(f_10636_2018_2091(f_10636_2018_2042(), fullyQualifiedMetadataName));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 1898, 2121);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10636_2018_2042()
                {
                    var return_v = UnderlyingAssemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 2018, 2042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10636_2018_2091(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.ResolveForwardedType(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2018, 2091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10636_2018_2109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2018, 2109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 1898, 2121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 1898, 2121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<INamedTypeSymbol> IAssemblySymbol.GetForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 2133, 2446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2226, 2435);

                return f_10636_2233_2434(f_10636_2233_2420(f_10636_2233_2321(f_10636_2233_2288(f_10636_2233_2257()), t => t.GetPublicSymbol()), t => t.ToDisplayString(SymbolDisplayFormat.QualifiedNameArityFormat)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 2133, 2446);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10636_2233_2257()
                {
                    var return_v = UnderlyingAssemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 2233, 2257);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10636_2233_2288(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAllTopLevelForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2233, 2288);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_10636_2233_2321(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.INamedTypeSymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.INamedTypeSymbol>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2233, 2321);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_10636_2233_2420(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.INamedTypeSymbol, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.INamedTypeSymbol, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2233, 2420);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_10636_2233_2434(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.INamedTypeSymbol>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.INamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2233, 2434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 2133, 2446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 2133, 2446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IAssemblySymbol.GivesAccessTo(IAssemblySymbol assemblyWantingAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 2458, 3894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2556, 2656) || true) && (f_10636_2560_2595(this, assemblyWantingAccess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 2556, 2656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2629, 2641);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 2556, 2656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2672, 2770);

                var
                myKeys = f_10636_2685_2769(f_10636_2685_2709(), f_10636_2742_2768(assemblyWantingAccess))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 2786, 3854) || true) && (f_10636_2790_2802(myKeys))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 2786, 3854);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3162, 3274) || true) && (f_10636_3166_3201(assemblyWantingAccess))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 3162, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3243, 3255);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 3162, 3274);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3294, 3356);

                    AssemblyIdentity
                    identity = f_10636_3322_3355(f_10636_3322_3346())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3376, 3839);
                        foreach (var key in f_10636_3396_3402_I(myKeys))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 3376, 3839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3444, 3543);

                            IVTConclusion
                            conclusion = identity.PerformIVTCheck(f_10636_3496_3536(f_10636_3496_3526(assemblyWantingAccess)), key)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3565, 3629);

                            f_10636_3565_3628(conclusion != IVTConclusion.NoRelationshipClaimed);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3651, 3820) || true) && (conclusion == IVTConclusion.Match || (DynAbs.Tracing.TraceSender.Expression_False(10636, 3655, 3735) || conclusion == IVTConclusion.OneSignedOneNot))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10636, 3651, 3820);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3785, 3797);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 3651, 3820);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 3376, 3839);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10636, 1, 464);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10636, 1, 464);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10636, 2786, 3854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 3870, 3883);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 2458, 3894);

                bool
                f_10636_2560_2595(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AssemblySymbol
                objA, Microsoft.CodeAnalysis.IAssemblySymbol
                objB)
                {
                    var return_v = Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2560, 2595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10636_2685_2709()
                {
                    var return_v = UnderlyingAssemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 2685, 2709);
                    return return_v;
                }


                string
                f_10636_2742_2768(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 2742, 2768);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10636_2685_2769(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2685, 2769);
                    return return_v;
                }


                bool
                f_10636_2790_2802(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                source)
                {
                    var return_v = source.Any<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 2790, 2802);
                    return return_v;
                }


                bool
                f_10636_3166_3201(Microsoft.CodeAnalysis.IAssemblySymbol
                assembly)
                {
                    var return_v = assembly.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 3166, 3201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10636_3322_3346()
                {
                    var return_v = UnderlyingAssemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 3322, 3346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10636_3322_3355(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 3322, 3355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10636_3496_3526(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 3496, 3526);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10636_3496_3536(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 3496, 3536);
                    return return_v;
                }


                int
                f_10636_3565_3628(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 3565, 3628);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10636_3396_3402_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 3396, 3402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 2458, 3894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 2458, 3894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamedTypeSymbol IAssemblySymbol.GetTypeByMetadataName(string metadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 3906, 4103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 4006, 4092);

                return f_10636_4013_4091(f_10636_4013_4073(f_10636_4013_4037(), metadataName));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 3906, 4103);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10636_4013_4037()
                {
                    var return_v = UnderlyingAssemblySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 4013, 4037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10636_4013_4073(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 4013, 4073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10636_4013_4091(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 4013, 4091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 3906, 4103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 3906, 4103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 4150, 4267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 4228, 4256);

                f_10636_4228_4255(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 4150, 4267);

                int
                f_10636_4228_4255(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AssemblySymbol
                symbol)
                {
                    this_param.VisitAssembly((Microsoft.CodeAnalysis.IAssemblySymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 4228, 4255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 4150, 4267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 4150, 4267);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10636, 4279, 4424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10636, 4378, 4413);

                return f_10636_4385_4412<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10636, 4279, 4424);

                TResult?
                f_10636_4385_4412<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.VisitAssembly((Microsoft.CodeAnalysis.IAssemblySymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10636, 4385, 4412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10636, 4279, 4424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 4279, 4424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10636, 613, 4453);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10636, 613, 4453);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 613, 4453);
        }


        static AssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10636, 613, 4453);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10636, 613, 4453);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10636, 613, 4453);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10636, 613, 4453);

        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10636_1334_1358()
        {
            var return_v = UnderlyingAssemblySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1334, 1358);
            return return_v;
        }


        bool
        f_10636_1334_1372(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.IsInteractive;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1334, 1372);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10636_1430_1454()
        {
            var return_v = UnderlyingAssemblySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1430, 1454);
            return return_v;
        }


        Microsoft.CodeAnalysis.AssemblyIdentity
        f_10636_1430_1463(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1430, 1463);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10636_1525_1549()
        {
            var return_v = UnderlyingAssemblySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1525, 1549);
            return return_v;
        }


        System.Collections.Generic.ICollection<string>
        f_10636_1525_1559(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1525, 1559);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10636_1626_1650()
        {
            var return_v = UnderlyingAssemblySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1626, 1650);
            return return_v;
        }


        System.Collections.Generic.ICollection<string>
        f_10636_1626_1665(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.NamespaceNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1626, 1665);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10636_1731_1755()
        {
            var return_v = UnderlyingAssemblySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1731, 1755);
            return return_v;
        }


        bool
        f_10636_1731_1784(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.MightContainExtensionMethods;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10636, 1731, 1784);
            return return_v;
        }

    }
}
