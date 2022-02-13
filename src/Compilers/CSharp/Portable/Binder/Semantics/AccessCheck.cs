// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class AccessCheck
    {
        public static bool IsSymbolAccessible(
                    Symbol symbol,
                    AssemblySymbol within,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 774, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 962, 990);

                bool
                failedThroughTypeCheck
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 1004, 1137);

                return f_10060_1011_1136(symbol, within, null, out failedThroughTypeCheck, f_10060_1084_1111(within), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 774, 1148);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10060_1084_1111(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 1084, 1111);
                    return return_v;
                }


                bool
                f_10060_1011_1136(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = IsSymbolAccessibleCore(symbol, (Microsoft.CodeAnalysis.CSharp.Symbol)within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 1011, 1136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 774, 1148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 774, 1148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSymbolAccessible(
                    Symbol symbol,
                    NamedTypeSymbol within,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    TypeSymbol throughTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 1346, 1778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 1582, 1610);

                bool
                failedThroughTypeCheck
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 1624, 1767);

                return f_10060_1631_1766(symbol, within, throughTypeOpt, out failedThroughTypeCheck, f_10060_1714_1741(within), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 1346, 1778);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10060_1714_1741(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 1714, 1741);
                    return return_v;
                }


                bool
                f_10060_1631_1766(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = IsSymbolAccessibleCore(symbol, (Microsoft.CodeAnalysis.CSharp.Symbol)within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 1631, 1766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 1346, 1778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 1346, 1778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSymbolAccessible(
                    Symbol symbol,
                    NamedTypeSymbol within,
                    TypeSymbol throughTypeOpt,
                    out bool failedThroughTypeCheck,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 2056, 2566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 2392, 2555);

                return f_10060_2399_2554(symbol, within, throughTypeOpt, out failedThroughTypeCheck, f_10060_2482_2509(within), ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 2056, 2566);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10060_2482_2509(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 2482, 2509);
                    return return_v;
                }


                bool
                f_10060_2399_2554(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore(symbol, (Microsoft.CodeAnalysis.CSharp.Symbol)within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 2399, 2554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 2056, 2566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 2056, 2566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsEffectivelyPublicOrInternal(Symbol symbol, out bool isInternal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 2790, 4367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 2901, 2932);

                f_10060_2901_2931(symbol is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 2948, 3467);

                switch (f_10060_2956_2967(symbol))
                {

                    case SymbolKind.NamedType:
                    case SymbolKind.Event:
                    case SymbolKind.Field:
                    case SymbolKind.Method:
                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 2948, 3467);
                        DynAbs.Tracing.TraceSender.TraceBreak(10060, 3213, 3219);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 2948, 3467);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 2948, 3467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3289, 3322);

                        symbol = f_10060_3298_3321(symbol);
                        DynAbs.Tracing.TraceSender.TraceBreak(10060, 3344, 3350);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 2948, 3467);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 2948, 3467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3398, 3452);

                        throw f_10060_3404_3451(f_10060_3439_3450(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 2948, 3467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3483, 3502);

                isInternal = false;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 3518, 4328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3553, 4223);

                            switch (f_10060_3561_3589(symbol))
                            {

                                case Accessibility.Public:
                                case Accessibility.Protected:
                                case Accessibility.ProtectedOrInternal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 3553, 4223);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10060, 3795, 3801);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 3553, 4223);

                                case Accessibility.Internal:
                                case Accessibility.ProtectedAndInternal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 3553, 4223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3939, 3957);

                                    isInternal = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10060, 3983, 3989);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 3553, 4223);

                                case Accessibility.Private:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 3553, 4223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 4064, 4077);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 3553, 4223);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 3553, 4223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 4133, 4204);

                                    throw f_10060_4139_4203(f_10060_4174_4202(symbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 3553, 4223);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 4243, 4274);

                            symbol = f_10060_4252_4273(symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 3518, 4328);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 3518, 4328) || true) && (symbol is object)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 3518, 4328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 3518, 4328);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 4344, 4356);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 2790, 4367);

                int
                f_10060_2901_2931(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 2901, 2931);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10060_2956_2967(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 2956, 2967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10060_3298_3321(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 3298, 3321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10060_3439_3450(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 3439, 3450);
                    return return_v;
                }


                System.Exception
                f_10060_3404_3451(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 3404, 3451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10060_3561_3589(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 3561, 3589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10060_4174_4202(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 4174, 4202);
                    return return_v;
                }


                System.Exception
                f_10060_4139_4203(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 4139, 4203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_4252_4273(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 4252, 4273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 2790, 4367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 2790, 4367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSymbolAccessibleCore(
                    Symbol symbol,
                    Symbol within,  // must be assembly or named type symbol
                    TypeSymbol throughTypeOpt,
                    out bool failedThroughTypeCheck,
                    CSharpCompilation compilation,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 5536, 9918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 5954, 5991);

                f_10060_5954_5990((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6005, 6042);

                f_10060_6005_6041((object)within != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6056, 6090);

                f_10060_6056_6089(f_10060_6069_6088(within));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6104, 6172);

                f_10060_6104_6171(within is NamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10060, 6117, 6170) || within is AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6188, 6219);

                failedThroughTypeCheck = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6235, 9907);

                switch (f_10060_6243_6254(symbol))
                {

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6336, 6504);

                        return f_10060_6343_6503(f_10060_6366_6403(((ArrayTypeSymbol)symbol)), within, null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6574, 6746);

                        return f_10060_6581_6745(f_10060_6604_6645(((PointerTypeSymbol)symbol)), within, null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6814, 6920);

                        return f_10060_6821_6919(symbol, within, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.Alias:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 6984, 7143);

                        return f_10060_6991_7142(f_10060_7014_7042(((AliasSymbol)symbol)), within, null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.Discard:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7209, 7388);

                        return f_10060_7216_7387(((DiscardSymbol)symbol).TypeWithAnnotations.Type, within, null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7466, 7514);

                        var
                        funcPtr = (FunctionPointerTypeSymbol)symbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7536, 7794) || true) && (!f_10060_7541_7708(f_10060_7564_7592(f_10060_7564_7581(funcPtr)), within, throughTypeOpt: null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 7536, 7794);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7758, 7771);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 7536, 7794);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7818, 8193);
                            foreach (var param in f_10060_7840_7868_I(f_10060_7840_7868(f_10060_7840_7857(funcPtr))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 7818, 8193);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 7918, 8170) || true) && (!f_10060_7923_8072(f_10060_7946_7956(param), within, throughTypeOpt: null, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 7918, 8170);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 8130, 8143);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 7918, 8170);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 7818, 8193);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 1, 376);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 1, 376);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 8217, 8229);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 8368, 8380);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.TypeParameter:
                    case SymbolKind.Parameter:
                    case SymbolKind.Local:
                    case SymbolKind.Label:
                    case SymbolKind.Namespace:
                    case SymbolKind.DynamicType:
                    case SymbolKind.Assembly:
                    case SymbolKind.NetModule:
                    case SymbolKind.RangeVariable:
                    case SymbolKind.Method when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 8820, 8886) || true) && (f_10060_8825_8858(((MethodSymbol)symbol)) == MethodKind.LocalFunction) && (DynAbs.Tracing.TraceSender.Expression_True(10060, 8820, 8886) || true)
:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 8992, 9004);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 9192, 9596) || true) && (!f_10060_9197_9230(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 9192, 9596);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 9551, 9573);

                            throughTypeOpt = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 9192, 9596);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 9620, 9788);

                        return f_10060_9627_9787(f_10060_9646_9667(symbol), f_10060_9669_9697(symbol), within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 6235, 9907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 9838, 9892);

                        throw f_10060_9844_9891(f_10060_9879_9890(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 6235, 9907);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 5536, 9918);

                int
                f_10060_5954_5990(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 5954, 5990);
                    return 0;
                }


                int
                f_10060_6005_6041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6005, 6041);
                    return 0;
                }


                bool
                f_10060_6069_6088(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 6069, 6088);
                    return return_v;
                }


                int
                f_10060_6056_6089(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6056, 6089);
                    return 0;
                }


                int
                f_10060_6104_6171(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6104, 6171);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10060_6243_6254(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 6243, 6254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_6366_6403(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 6366, 6403);
                    return return_v;
                }


                bool
                f_10060_6343_6503(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6343, 6503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_6604_6645(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 6604, 6645);
                    return return_v;
                }


                bool
                f_10060_6581_6745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6581, 6745);
                    return return_v;
                }


                bool
                f_10060_6821_6919(Microsoft.CodeAnalysis.CSharp.Symbol
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsNamedTypeAccessible((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, within, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6821, 6919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10060_7014_7042(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7014, 7042);
                    return return_v;
                }


                bool
                f_10060_6991_7142(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 6991, 7142);
                    return return_v;
                }


                bool
                f_10060_7216_7387(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 7216, 7387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10060_7564_7581(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7564, 7581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_7564_7592(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7564, 7592);
                    return return_v;
                }


                bool
                f_10060_7541_7708(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt: throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 7541, 7708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10060_7840_7857(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7840, 7857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10060_7840_7868(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7840, 7868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_7946_7956(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 7946, 7956);
                    return return_v;
                }


                bool
                f_10060_7923_8072(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt: throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 7923, 8072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10060_7840_7868_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 7840, 7868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10060_8825_8858(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 8825, 8858);
                    return return_v;
                }


                bool
                f_10060_9197_9230(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 9197, 9230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_9646_9667(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 9646, 9667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10060_9669_9697(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 9669, 9697);
                    return return_v;
                }


                bool
                f_10060_9627_9787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.Accessibility
                declaredAccessibility, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = IsMemberAccessible(containingType, declaredAccessibility, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 9627, 9787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10060_9879_9890(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 9879, 9890);
                    return return_v;
                }


                System.Exception
                f_10060_9844_9891(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 9844, 9891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 5536, 9918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 5536, 9918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNamedTypeAccessible(NamedTypeSymbol type, Symbol within, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 10138, 11686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10337, 10405);

                f_10060_10337_10404(within is NamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10060, 10350, 10403) || within is AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10419, 10454);

                f_10060_10419_10453((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10470, 10516);

                var
                compilation = f_10060_10488_10515(within)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10532, 10544);

                bool
                unused
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10558, 11295) || true) && (f_10060_10562_10580_M(!type.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 10558, 11295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10672, 10762);

                    var
                    typeArgs = f_10060_10687_10761(type, ref useSiteDiagnostics)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 10780, 11280);
                        foreach (var typeArg in f_10060_10804_10812_I(typeArgs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 10780, 11280);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 11002, 11261) || true) && (f_10060_11006_11023(typeArg.Type) != SymbolKind.TypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10060, 11006, 11175) && !f_10060_11056_11175(typeArg.Type, within, null, out unused, compilation, ref useSiteDiagnostics, basesBeingResolved)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 11002, 11261);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 11225, 11238);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 11002, 11261);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 10780, 11280);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 1, 501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 1, 501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 10558, 11295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 11311, 11352);

                var
                containingType = f_10060_11332_11351(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 11366, 11675);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10060, 11373, 11403) || (((object)containingType == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10060, 11423, 11509)) || DynAbs.Tracing.TraceSender.Conditional_F3(10060, 11529, 11674))) ? f_10060_11423_11509(f_10060_11449_11472(type), f_10060_11474_11500(type), within) : f_10060_11529_11674(containingType, f_10060_11564_11590(type), within, null, out unused, compilation, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 10138, 11686);

                int
                f_10060_10337_10404(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 10337, 10404);
                    return 0;
                }


                int
                f_10060_10419_10453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 10419, 10453);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10060_10488_10515(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 10488, 10515);
                    return return_v;
                }


                bool
                f_10060_10562_10580_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 10562, 10580);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10060_10687_10761(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentsWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 10687, 10761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10060_11006_11023(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 11006, 11023);
                    return return_v;
                }


                bool
                f_10060_11056_11175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsSymbolAccessibleCore((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 11056, 11175);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10060_10804_10812_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 10804, 10812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_11332_11351(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 11332, 11351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_11449_11472(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 11449, 11472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10060_11474_11500(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 11474, 11500);
                    return return_v;
                }


                bool
                f_10060_11423_11509(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.Accessibility
                declaredAccessibility, Microsoft.CodeAnalysis.CSharp.Symbol
                within)
                {
                    var return_v = IsNonNestedTypeAccessible(assembly, declaredAccessibility, within);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 11423, 11509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10060_11564_11590(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 11564, 11590);
                    return return_v;
                }


                bool
                f_10060_11529_11674(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.Accessibility
                declaredAccessibility, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsMemberAccessible(containingType, declaredAccessibility, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 11529, 11674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 10138, 11686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 10138, 11686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNonNestedTypeAccessible(
                    AssemblySymbol assembly,
                    Accessibility declaredAccessibility,
                    Symbol within)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 11930, 13538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12117, 12185);

                f_10060_12117_12184(within is NamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10060, 12130, 12183) || within is AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12199, 12238);

                f_10060_12199_12237((object)assembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12254, 13527);

                switch (declaredAccessibility)
                {

                    case Accessibility.NotApplicable:
                    case Accessibility.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 12254, 13527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12494, 12506);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 12254, 13527);

                    case Accessibility.Private:
                    case Accessibility.Protected:
                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 12254, 13527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12744, 12757);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 12254, 13527);

                    case Accessibility.Internal:
                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 12254, 13527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 12937, 12980);

                        var
                        withinType = within as NamedTypeSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 13002, 13107);

                        var
                        withinAssembly = (DynAbs.Tracing.TraceSender.Conditional_F1(10060, 13023, 13049) || (((object)withinType != null && DynAbs.Tracing.TraceSender.Conditional_F2(10060, 13052, 13081)) || DynAbs.Tracing.TraceSender.Conditional_F3(10060, 13084, 13106))) ? f_10060_13052_13081(withinType) : (AssemblySymbol)within
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 13300, 13398);

                        return (object)withinAssembly == (object)assembly || (DynAbs.Tracing.TraceSender.Expression_False(10060, 13307, 13397) || f_10060_13353_13397(withinAssembly, assembly));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 12254, 13527);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 12254, 13527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 13448, 13512);

                        throw f_10060_13454_13511(declaredAccessibility);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 12254, 13527);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 11930, 13538);

                int
                f_10060_12117_12184(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 12117, 12184);
                    return 0;
                }


                int
                f_10060_12199_12237(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 12199, 12237);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_13052_13081(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 13052, 13081);
                    return return_v;
                }


                bool
                f_10060_13353_13397(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 13353, 13397);
                    return return_v;
                }


                System.Exception
                f_10060_13454_13511(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 13454, 13511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 11930, 13538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 11930, 13538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMemberAccessible(
                    NamedTypeSymbol containingType,              // the symbol's containing type
                    Accessibility declaredAccessibility,
                    Symbol within,
                    TypeSymbol throughTypeOpt,
                    out bool failedThroughTypeCheck,
                    CSharpCompilation compilation,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 13763, 15411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14247, 14315);

                f_10060_14247_14314(within is NamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10060, 14260, 14313) || within is AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14329, 14374);

                f_10060_14329_14373((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14390, 14421);

                failedThroughTypeCheck = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14508, 14613) || true) && ((object)containingType == (object)within)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 14508, 14613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14586, 14598);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 14508, 14613);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14726, 14882) || true) && (!f_10060_14731_14820(containingType, within, ref useSiteDiagnostics, basesBeingResolved))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 14726, 14882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14854, 14867);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 14726, 14882);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 14954, 15064) || true) && (declaredAccessibility == Accessibility.Public)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 14954, 15064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 15037, 15049);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 14954, 15064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 15080, 15400);

                return f_10060_15087_15399(containingType, declaredAccessibility, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 13763, 15411);

                int
                f_10060_14247_14314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 14247, 14314);
                    return 0;
                }


                int
                f_10060_14329_14373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 14329, 14373);
                    return 0;
                }


                bool
                f_10060_14731_14820(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsNamedTypeAccessible(type, within, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 14731, 14820);
                    return return_v;
                }


                bool
                f_10060_15087_15399(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.Accessibility
                declaredAccessibility, Microsoft.CodeAnalysis.CSharp.Symbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsNonPublicMemberAccessible(containingType, declaredAccessibility, within, throughTypeOpt, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 15087, 15399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 13763, 15411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 13763, 15411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNonPublicMemberAccessible(
                    NamedTypeSymbol containingType,              // the symbol's containing type
                    Accessibility declaredAccessibility,
                    Symbol within,
                    TypeSymbol throughTypeOpt,
                    out bool failedThroughTypeCheck,
                    CSharpCompilation compilation,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 15423, 19272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 15916, 15947);

                failedThroughTypeCheck = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 15963, 16026);

                var
                originalContainingType = f_10060_15992_16025(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16040, 16083);

                var
                withinType = within as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16097, 16202);

                var
                withinAssembly = (DynAbs.Tracing.TraceSender.Conditional_F1(10060, 16118, 16144) || (((object)withinType != null && DynAbs.Tracing.TraceSender.Conditional_F2(10060, 16147, 16176)) || DynAbs.Tracing.TraceSender.Conditional_F3(10060, 16179, 16201))) ? f_10060_16147_16176(withinType) : (AssemblySymbol)within
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16218, 19261);

                switch (declaredAccessibility)
                {

                    case Accessibility.NotApplicable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16336, 16348);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    case Accessibility.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16801, 16936) || true) && (f_10060_16805_16828(containingType) == TypeKind.Submission)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16801, 16936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 16901, 16913);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16801, 16936);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 17038, 17137);

                        return (object)withinType != null && (DynAbs.Tracing.TraceSender.Expression_True(10060, 17045, 17136) && f_10060_17075_17136(withinType, originalContainingType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    case Accessibility.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 17376, 17453);

                        return f_10060_17383_17452(withinAssembly, f_10060_17418_17451(containingType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 17535, 17854) || true) && (!f_10060_17540_17609(withinAssembly, f_10060_17575_17608(containingType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 17535, 17854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 17818, 17831);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 17535, 17854);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 17976, 18148);

                        return f_10060_17983_18147(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 18229, 18557) || true) && (f_10060_18233_18302(withinAssembly, f_10060_18268_18301(containingType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 18229, 18557);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 18522, 18534);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 18229, 18557);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 18717, 18889);

                        return f_10060_18724_18888(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    case Accessibility.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 18960, 19132);

                        return f_10060_18967_19131(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 16218, 19261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 19182, 19246);

                        throw f_10060_19188_19245(declaredAccessibility);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 16218, 19261);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 15423, 19272);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_15992_16025(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 15992, 16025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_16147_16176(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 16147, 16176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10060_16805_16828(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 16805, 16828);
                    return return_v;
                }


                bool
                f_10060_17075_17136(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType)
                {
                    var return_v = IsPrivateSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)within, originalContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 17075, 17136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_17418_17451(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 17418, 17451);
                    return return_v;
                }


                bool
                f_10060_17383_17452(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 17383, 17452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_17575_17608(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 17575, 17608);
                    return return_v;
                }


                bool
                f_10060_17540_17609(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 17540, 17609);
                    return return_v;
                }


                bool
                f_10060_17983_18147(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                withinType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsProtectedSymbolAccessible(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 17983, 18147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10060_18268_18301(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 18268, 18301);
                    return return_v;
                }


                bool
                f_10060_18233_18302(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 18233, 18302);
                    return return_v;
                }


                bool
                f_10060_18724_18888(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                withinType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsProtectedSymbolAccessible(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 18724, 18888);
                    return return_v;
                }


                bool
                f_10060_18967_19131(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                withinType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType, out bool
                failedThroughTypeCheck, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = IsProtectedSymbolAccessible(withinType, throughTypeOpt, originalContainingType, out failedThroughTypeCheck, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 18967, 19131);
                    return return_v;
                }


                System.Exception
                f_10060_19188_19245(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 19188, 19245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 15423, 19272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 15423, 19272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsProtectedSymbolAccessible(
                    NamedTypeSymbol withinType,
                    TypeSymbol throughTypeOpt,
                    NamedTypeSymbol originalContainingType,
                    out bool failedThroughTypeCheck,
                    CSharpCompilation compilation,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 19489, 23307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 19908, 19939);

                failedThroughTypeCheck = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 20181, 20300) || true) && (f_10060_20185_20216(originalContainingType) == TypeKind.Submission)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 20181, 20300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 20273, 20285);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 20181, 20300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 20316, 20491) || true) && ((object)withinType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 20316, 20491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 20463, 20476);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 20316, 20491);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21159, 21296) || true) && (f_10060_21163_21235(withinType, originalContainingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 21159, 21296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21269, 21281);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 21159, 21296);
                }

                // Protected is really confusing.  Check out 3.5.3 of the language spec "protected access
                // for instance members" to see how it works.  I actually got the code for this from
                // LangCompiler::CheckAccessCore
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21578, 21622);

                    var
                    current = f_10060_21592_21621(withinType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21640, 21757);

                    var
                    originalThroughTypeOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10060, 21669, 21699) || (((object)throughTypeOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10060, 21702, 21706)) || DynAbs.Tracing.TraceSender.Conditional_F3(10060, 21709, 21756))) ? null : f_10060_21709_21742(throughTypeOpt) as TypeSymbol
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21775, 23252) || true) && ((object)current != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 21775, 23252);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21847, 21882);

                            f_10060_21847_21881(f_10060_21860_21880(current));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 21906, 23084) || true) && (f_10060_21910_22043(current, originalContainingType, compilation, ref useSiteDiagnostics, basesBeingResolved))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 21906, 23084);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 22632, 23061) || true) && ((object)originalThroughTypeOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10060, 22636, 22820) || f_10060_22707_22820(originalThroughTypeOpt, current, compilation, ref useSiteDiagnostics)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 22632, 23061);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 22878, 22890);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 22632, 23061);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 22632, 23061);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23004, 23034);

                                    failedThroughTypeCheck = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 22632, 23061);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 21906, 23084);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23200, 23233);

                            current = f_10060_23210_23232(current);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 21775, 23252);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 21775, 23252);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 21775, 23252);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23283, 23296);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 19489, 23307);

                Microsoft.CodeAnalysis.TypeKind
                f_10060_20185_20216(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 20185, 20216);
                    return return_v;
                }


                bool
                f_10060_21163_21235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                withinType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType)
                {
                    var return_v = IsNestedWithinOriginalContainingType(withinType, originalContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 21163, 21235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_21592_21621(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 21592, 21621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_21709_21742(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 21709, 21742);
                    return return_v;
                }


                bool
                f_10060_21860_21880(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 21860, 21880);
                    return return_v;
                }


                int
                f_10060_21847_21881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 21847, 21881);
                    return 0;
                }


                bool
                f_10060_21910_22043(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = type.InheritsFromOrImplementsIgnoringConstruction(baseType, compilation, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 21910, 22043);
                    return return_v;
                }


                bool
                f_10060_22707_22820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = type.InheritsFromOrImplementsIgnoringConstruction(baseType, compilation, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 22707, 22820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_23210_23232(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 23210, 23232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 19489, 23307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 19489, 23307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsPrivateSymbolAccessible(
                    Symbol within,
                    NamedTypeSymbol originalContainingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 23319, 24024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23471, 23539);

                f_10060_23471_23538(within is NamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10060, 23484, 23537) || within is AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23555, 23598);

                var
                withinType = within as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23612, 23785) || true) && ((object)withinType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 23612, 23785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23757, 23770);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 23612, 23785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 23933, 24013);

                return f_10060_23940_24012(withinType, originalContainingType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 23319, 24024);

                int
                f_10060_23471_23538(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 23471, 23538);
                    return 0;
                }


                bool
                f_10060_23940_24012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                withinType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalContainingType)
                {
                    var return_v = IsNestedWithinOriginalContainingType(withinType, originalContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 23940, 24012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 23319, 24024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 23319, 24024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNestedWithinOriginalContainingType(
                    NamedTypeSymbol withinType,
                    NamedTypeSymbol originalContainingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 24179, 25225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24355, 24396);

                f_10060_24355_24395((object)withinType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24410, 24463);

                f_10060_24410_24462((object)originalContainingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24477, 24527);

                f_10060_24477_24526(f_10060_24490_24525(originalContainingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24733, 24777);

                var
                current = f_10060_24747_24776(withinType)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24791, 25185) || true) && ((object)current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 24791, 25185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24855, 24890);

                        f_10060_24855_24889(f_10060_24868_24888(current));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24908, 25026) || true) && (current == (object)originalContainingType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 24908, 25026);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 24995, 25007);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 24908, 25026);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25137, 25170);

                        current = f_10060_25147_25169(current);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 24791, 25185);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 24791, 25185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 24791, 25185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25201, 25214);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 24179, 25225);

                int
                f_10060_24355_24395(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 24355, 24395);
                    return 0;
                }


                int
                f_10060_24410_24462(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 24410, 24462);
                    return 0;
                }


                bool
                f_10060_24490_24525(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 24490, 24525);
                    return return_v;
                }


                int
                f_10060_24477_24526(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 24477, 24526);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_24747_24776(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 24747, 24776);
                    return return_v;
                }


                bool
                f_10060_24868_24888(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 24868, 24888);
                    return return_v;
                }


                int
                f_10060_24855_24889(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 24855, 24889);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_25147_25169(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 25147, 25169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 24179, 25225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 24179, 25225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool InheritsFromOrImplementsIgnoringConstruction(
                    this TypeSymbol type,
                    NamedTypeSymbol baseType,
                    CSharpCompilation compilation,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 25436, 30273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25766, 25798);

                f_10060_25766_25797(f_10060_25779_25796(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25812, 25848);

                f_10060_25812_25847(f_10060_25825_25846(baseType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25864, 25921);

                PooledHashSet<NamedTypeSymbol>
                interfacesLookedAt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 25935, 25987);

                ArrayBuilder<NamedTypeSymbol>
                baseInterfaces = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26003, 26051);

                bool
                baseTypeIsInterface = f_10060_26030_26050(baseType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26065, 26282) || true) && (baseTypeIsInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 26065, 26282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26122, 26188);

                    interfacesLookedAt = f_10060_26143_26187();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26206, 26267);

                    baseInterfaces = f_10060_26223_26266();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 26065, 26282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26298, 26344);

                PooledHashSet<NamedTypeSymbol>
                visited = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26358, 26377);

                var
                current = type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26391, 26411);

                bool
                result = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26427, 27643) || true) && ((object)current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 26427, 27643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26491, 26526);

                        f_10060_26491_26525(f_10060_26504_26524(current));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26544, 26751) || true) && (baseTypeIsInterface == f_10060_26571_26596(current) && (DynAbs.Tracing.TraceSender.Expression_True(10060, 26548, 26648) && current == (object)baseType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 26544, 26751);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26690, 26704);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10060, 26726, 26732);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 26544, 26751);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26771, 26938) || true) && (baseTypeIsInterface)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 26771, 26938);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 26836, 26919);

                            f_10060_26836_26918(current, baseInterfaces, interfacesLookedAt, basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 26771, 26938);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27205, 27306);

                        var
                        next = f_10060_27216_27305(current, basesBeingResolved, compilation, ref visited)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27324, 27628) || true) && ((object)next == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 27324, 27628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27390, 27405);

                            current = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 27324, 27628);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 27324, 27628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27487, 27533);

                            current = (TypeSymbol)f_10060_27509_27532(next);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27555, 27609);

                            f_10060_27555_27608(current, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 27324, 27628);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 26427, 27643);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 26427, 27643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 26427, 27643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27659, 27675);

                f_10060_27667_27674(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(visited, 10060, 27659, 27674));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27691, 28709) || true) && (!result && (DynAbs.Tracing.TraceSender.Expression_True(10060, 27695, 27725) && baseTypeIsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 27691, 28709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27759, 27781);

                    f_10060_27759_27780(!result);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27801, 28429) || true) && (f_10060_27808_27828(baseInterfaces) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 27801, 28429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27875, 27926);

                            NamedTypeSymbol
                            currentBase = f_10060_27905_27925(baseInterfaces)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 27950, 28060) || true) && (f_10060_27954_27978_M(!currentBase.IsInterface))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 27950, 28060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28028, 28037);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 27950, 28060);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28084, 28123);

                            f_10060_28084_28122(f_10060_28097_28121(currentBase));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28145, 28299) || true) && (currentBase == (object)baseType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 28145, 28299);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28230, 28244);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10060, 28270, 28276);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 28145, 28299);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28323, 28410);

                            f_10060_28323_28409(currentBase, baseInterfaces, interfacesLookedAt, basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 27801, 28429);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 27801, 28429);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 27801, 28429);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28449, 28694) || true) && (!result)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 28449, 28694);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28502, 28675);
                            foreach (var candidate in f_10060_28528_28546_I(interfacesLookedAt))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 28502, 28675);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28596, 28652);

                                f_10060_28596_28651(candidate, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 28502, 28675);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 1, 174);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 1, 174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 28449, 28694);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 27691, 28709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28725, 28752);

                f_10060_28744_28751(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(interfacesLookedAt, 10060, 28725, 28751));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28766, 28789);

                f_10060_28781_28788(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(baseInterfaces, 10060, 28766, 28788));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 28803, 28817);

                return result;

                static void getBaseInterfaces(TypeSymbol derived, ArrayBuilder<NamedTypeSymbol> baseInterfaces, PooledHashSet<NamedTypeSymbol> interfacesLookedAt, ConsList<TypeSymbol> basesBeingResolved)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 28833, 30262);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29053, 29200) || true) && (basesBeingResolved != null && (DynAbs.Tracing.TraceSender.Expression_True(10060, 29057, 29132) && f_10060_29087_29132(basesBeingResolved, derived)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 29053, 29200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29174, 29181);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 29053, 29200);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29220, 29271);

                        ImmutableArray<NamedTypeSymbol>
                        declaredInterfaces
                        = default(ImmutableArray<NamedTypeSymbol>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29291, 29898);

                        switch (derived)
                        {

                            case TypeParameterSymbol typeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 29291, 29898);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29413, 29491);

                                declaredInterfaces = f_10060_29434_29490(typeParameter);
                                DynAbs.Tracing.TraceSender.TraceBreak(10060, 29517, 29523);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 29291, 29898);

                            case NamedTypeSymbol namedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 29291, 29898);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29604, 29677);

                                declaredInterfaces = f_10060_29625_29676(namedType, basesBeingResolved);
                                DynAbs.Tracing.TraceSender.TraceBreak(10060, 29703, 29709);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 29291, 29898);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 29291, 29898);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29767, 29847);

                                declaredInterfaces = f_10060_29788_29846(derived, basesBeingResolved);
                                DynAbs.Tracing.TraceSender.TraceBreak(10060, 29873, 29879);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 29291, 29898);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 29918, 30247);
                            foreach (var @interface in f_10060_29945_29963_I(declaredInterfaces))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 29918, 30247);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30005, 30064);

                                NamedTypeSymbol
                                definition = f_10060_30034_30063(@interface)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30086, 30228) || true) && (f_10060_30090_30124(interfacesLookedAt, definition))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 30086, 30228);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30174, 30205);

                                    f_10060_30174_30204(baseInterfaces, definition);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 30086, 30228);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 29918, 30247);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10060, 1, 330);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10060, 1, 330);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 28833, 30262);

                        bool
                        f_10060_29087_29132(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        element)
                        {
                            var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(element);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 29087, 29132);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10060_29434_29490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.AllEffectiveInterfacesNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 29434, 29490);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10060_29625_29676(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                        basesBeingResolved)
                        {
                            var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 29625, 29676);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10060_29788_29846(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                        basesBeingResolved)
                        {
                            var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 29788, 29846);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10060_30034_30063(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 30034, 30063);
                            return return_v;
                        }


                        bool
                        f_10060_30090_30124(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 30090, 30124);
                            return return_v;
                        }


                        int
                        f_10060_30174_30204(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 30174, 30204);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10060_29945_29963_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 29945, 29963);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 28833, 30262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 28833, 30262);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 25436, 30273);

                bool
                f_10060_25779_25796(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 25779, 25796);
                    return return_v;
                }


                int
                f_10060_25766_25797(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 25766, 25797);
                    return 0;
                }


                bool
                f_10060_25825_25846(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 25825, 25846);
                    return return_v;
                }


                int
                f_10060_25812_25847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 25812, 25847);
                    return 0;
                }


                bool
                f_10060_26030_26050(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 26030, 26050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10060_26143_26187()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 26143, 26187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10060_26223_26266()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 26223, 26266);
                    return return_v;
                }


                bool
                f_10060_26504_26524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 26504, 26524);
                    return return_v;
                }


                int
                f_10060_26491_26525(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 26491, 26525);
                    return 0;
                }


                bool
                f_10060_26571_26596(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 26571, 26596);
                    return return_v;
                }


                int
                f_10060_26836_26918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derived, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                baseInterfaces, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                interfacesLookedAt, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    getBaseInterfaces(derived, baseInterfaces, interfacesLookedAt, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 26836, 26918);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_27216_27305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                visited)
                {
                    var return_v = type.GetNextBaseTypeNoUseSiteDiagnostics(basesBeingResolved, compilation, ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 27216, 27305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10060_27509_27532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 27509, 27532);
                    return return_v;
                }


                int
                f_10060_27555_27608(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 27555, 27608);
                    return 0;
                }


                int
                f_10060_27667_27674(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 27667, 27674);
                    return 0;
                }


                int
                f_10060_27759_27780(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 27759, 27780);
                    return 0;
                }


                int
                f_10060_27808_27828(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 27808, 27828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10060_27905_27925(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 27905, 27925);
                    return return_v;
                }


                bool
                f_10060_27954_27978_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 27954, 27978);
                    return return_v;
                }


                bool
                f_10060_28097_28121(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 28097, 28121);
                    return return_v;
                }


                int
                f_10060_28084_28122(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28084, 28122);
                    return 0;
                }


                int
                f_10060_28323_28409(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                derived, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                baseInterfaces, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                interfacesLookedAt, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    getBaseInterfaces((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)derived, baseInterfaces, interfacesLookedAt, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28323, 28409);
                    return 0;
                }


                int
                f_10060_28596_28651(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28596, 28651);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                f_10060_28528_28546_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28528, 28546);
                    return return_v;
                }


                int
                f_10060_28744_28751(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28744, 28751);
                    return 0;
                }


                int
                f_10060_28781_28788(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 28781, 28788);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 25436, 30273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 25436, 30273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasInternalAccessTo(this AssemblySymbol fromAssembly, AssemblySymbol toAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 30586, 31193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30712, 30809) || true) && (f_10060_30716_30748(fromAssembly, toAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 30712, 30809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30782, 30794);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 30712, 30809);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30825, 30948) || true) && (f_10060_30829_30887(fromAssembly, toAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 30825, 30948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 30921, 30933);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 30825, 30948);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 31034, 31153) || true) && (f_10060_31038_31064(fromAssembly) && (DynAbs.Tracing.TraceSender.Expression_True(10060, 31038, 31092) && f_10060_31068_31092(toAssembly)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10060, 31034, 31153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 31126, 31138);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10060, 31034, 31153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 31169, 31182);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 30586, 31193);

                bool
                f_10060_30716_30748(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 30716, 30748);
                    return return_v;
                }


                bool
                f_10060_30829_30887(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                other)
                {
                    var return_v = this_param.AreInternalsVisibleToThisAssembly(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10060, 30829, 30887);
                    return return_v;
                }


                bool
                f_10060_31038_31064(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 31038, 31064);
                    return return_v;
                }


                bool
                f_10060_31068_31092(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 31068, 31092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 30586, 31193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 30586, 31193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorCode GetProtectedMemberInSealedTypeError(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10060, 31205, 31452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10060, 31323, 31441);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10060, 31330, 31372) || ((f_10060_31330_31353(containingType) == TypeKind.Struct && DynAbs.Tracing.TraceSender.Conditional_F2(10060, 31375, 31406)) || DynAbs.Tracing.TraceSender.Conditional_F3(10060, 31409, 31440))) ? ErrorCode.ERR_ProtectedInStruct : ErrorCode.WRN_ProtectedInSealed;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10060, 31205, 31452);

                Microsoft.CodeAnalysis.TypeKind
                f_10060_31330_31353(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10060, 31330, 31353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10060, 31205, 31452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 31205, 31452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AccessCheck()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10060, 600, 31459);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10060, 600, 31459);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10060, 600, 31459);
        }

    }
}
