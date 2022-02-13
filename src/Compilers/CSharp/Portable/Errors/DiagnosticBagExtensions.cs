// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class DiagnosticBagExtensions
    {
        internal static CSDiagnosticInfo Add(this DiagnosticBag diagnostics, ErrorCode code, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 669, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 797, 835);

                var
                info = f_10048_808_834(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 849, 893);

                var
                diag = f_10048_860_892(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 907, 929);

                f_10048_907_928(diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 943, 955);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 669, 966);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10048_808_834(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 808, 834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10048_860_892(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 860, 892);
                    return return_v;
                }


                int
                f_10048_907_928(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 907, 928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 669, 966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 669, 966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSDiagnosticInfo Add(this DiagnosticBag diagnostics, ErrorCode code, Location location, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 1275, 1600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1425, 1469);

                var
                info = f_10048_1436_1468(code, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1483, 1527);

                var
                diag = f_10048_1494_1526(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1541, 1563);

                f_10048_1541_1562(diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1577, 1589);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 1275, 1600);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10048_1436_1468(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1436, 1468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10048_1494_1526(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1494, 1526);
                    return return_v;
                }


                int
                f_10048_1541_1562(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1541, 1562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 1275, 1600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 1275, 1600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSDiagnosticInfo Add(this DiagnosticBag diagnostics, ErrorCode code, Location location, ImmutableArray<Symbol> symbols, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 1612, 2010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1794, 1879);

                var
                info = f_10048_1805_1878(code, args, symbols, ImmutableArray<Location>.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1893, 1937);

                var
                diag = f_10048_1904_1936(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1951, 1973);

                f_10048_1951_1972(diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 1987, 1999);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 1612, 2010);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10048_1805_1878(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1805, 1878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10048_1904_1936(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1904, 1936);
                    return return_v;
                }


                int
                f_10048_1951_1972(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 1951, 1972);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 1612, 2010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 1612, 2010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void Add(this DiagnosticBag diagnostics, DiagnosticInfo info, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 2022, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 2143, 2187);

                var
                diag = f_10048_2154_2186(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 2201, 2223);

                f_10048_2201_2222(diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 2022, 2234);

                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10048_2154_2186(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 2154, 2186);
                    return return_v;
                }


                int
                f_10048_2201_2222(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 2201, 2222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 2022, 2234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 2022, 2234);
            }
        }

        internal static bool Add(
                    this DiagnosticBag diagnostics,
                    SyntaxNode node,
                    HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 2407, 2697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 2589, 2686);

                return !f_10048_2597_2631(useSiteDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10048, 2596, 2685) && f_10048_2635_2685(diagnostics, f_10048_2651_2664(node), useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 2407, 2697);

                bool
                f_10048_2597_2631(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 2597, 2631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10048_2651_2664(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10048, 2651, 2664);
                    return return_v;
                }


                bool
                f_10048_2635_2685(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 2635, 2685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 2407, 2697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 2407, 2697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Add(
                    this DiagnosticBag diagnostics,
                    SyntaxToken token,
                    HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 2870, 3168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3054, 3157);

                return !f_10048_3062_3096(useSiteDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10048, 3061, 3156) && f_10048_3100_3156(diagnostics, token.GetLocation(), useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 2870, 3168);

                bool
                f_10048_3062_3096(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3062, 3096);
                    return return_v;
                }


                bool
                f_10048_3100_3156(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3100, 3156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 2870, 3168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 2870, 3168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Add(
                    this DiagnosticBag diagnostics,
                    Location location,
                    HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10048, 3180, 3847);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3364, 3464) || true) && (f_10048_3368_3402(useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10048, 3364, 3464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3436, 3449);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10048, 3364, 3464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3480, 3504);

                bool
                haveErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3520, 3802);
                    foreach (var info in f_10048_3541_3559_I(useSiteDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10048, 3520, 3802);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3593, 3717) || true) && (f_10048_3597_3610(info) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10048, 3593, 3717);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3680, 3698);

                            haveErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10048, 3593, 3717);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3737, 3787);

                        f_10048_3737_3786(
                                        diagnostics, f_10048_3753_3785(info, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10048, 3520, 3802);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10048, 1, 283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10048, 1, 283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10048, 3818, 3836);

                return haveErrors;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10048, 3180, 3847);

                bool
                f_10048_3368_3402(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3368, 3402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10048_3597_3610(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10048, 3597, 3610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10048_3753_3785(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3753, 3785);
                    return return_v;
                }


                int
                f_10048_3737_3786(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3737, 3786);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10048_3541_3559_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10048, 3541, 3559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10048, 3180, 3847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 3180, 3847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticBagExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10048, 351, 3854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10048, 351, 3854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10048, 351, 3854);
        }

    }
}
