// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalDataFlowPass<TLocalState, TLocalFunctionState>
    {
        internal readonly struct VariableIdentifier : IEquatable<VariableIdentifier>
        {

            public readonly Symbol Symbol;

            public readonly int ContainingSlot;

            public VariableIdentifier(Symbol symbol, int containingSlot = 0)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10891, 1088, 1854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1185, 1219);

                    f_10891_1185_1218(containingSlot >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1237, 1755);

                    f_10891_1237_1754(f_10891_1250_1261(symbol) switch
                    {
                        SymbolKind.Local when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1309, 1333) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1309, 1333))
    => true,
                        SymbolKind.Parameter when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1356, 1384) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1356, 1384))
    => true,
                        SymbolKind.Field when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1407, 1431) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1407, 1431))
    => true,
                        SymbolKind.Property when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1454, 1481) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1454, 1481))
    => true,
                        SymbolKind.Event when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1504, 1528) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1504, 1528))
    => true,
                        SymbolKind.ErrorType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1551, 1579) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1551, 1579))
    => true,
                        SymbolKind.Method when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1620, 1693) || true) && (symbol is MethodSymbol m && (DynAbs.Tracing.TraceSender.Expression_True(10891, 1625, 1693) && f_10891_1653_1665(m) == MethodKind.LocalFunction)) && (DynAbs.Tracing.TraceSender.Expression_True(10891, 1620, 1693) || true)
    => true,
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1724, 1734) && DynAbs.Tracing.TraceSender.Expression_True(10891, 1724, 1734))
    => false
                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1773, 1789);

                    Symbol = symbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1807, 1839);

                    ContainingSlot = containingSlot;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10891, 1088, 1854);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 1088, 1854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 1088, 1854);
                }
            }

            public bool Exists
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10891, 1921, 1959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 1927, 1957);

                        return (object)Symbol != null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10891, 1921, 1959);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 1870, 1974);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 1870, 1974);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10891, 1990, 2612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2056, 2077);

                    f_10891_2056_2076(Exists);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2097, 2129);

                    int
                    currentKey = ContainingSlot
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2360, 2399);

                    int?
                    thisIndex = f_10891_2377_2398(Symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2417, 2597);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10891, 2424, 2442) || ((f_10891_2424_2442(thisIndex) && DynAbs.Tracing.TraceSender.Conditional_F2(10891, 2466, 2521)) || DynAbs.Tracing.TraceSender.Conditional_F3(10891, 2545, 2596))) ? f_10891_2466_2521(f_10891_2479_2508(thisIndex), currentKey) : f_10891_2545_2596(f_10891_2558_2583(Symbol), currentKey);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10891, 1990, 2612);

                    int
                    f_10891_2056_2076(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2056, 2076);
                        return 0;
                    }


                    int?
                    f_10891_2377_2398(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.MemberIndexOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 2377, 2398);
                        return return_v;
                    }


                    bool
                    f_10891_2424_2442(int?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 2424, 2442);
                        return return_v;
                    }


                    int
                    f_10891_2479_2508(int?
                    this_param)
                    {
                        var return_v = this_param.GetValueOrDefault();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2479, 2508);
                        return return_v;
                    }


                    int
                    f_10891_2466_2521(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2466, 2521);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10891_2558_2583(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 2558, 2583);
                        return return_v;
                    }


                    int
                    f_10891_2545_2596(Microsoft.CodeAnalysis.CSharp.Symbol
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2545, 2596);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 1990, 2612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 1990, 2612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(VariableIdentifier other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10891, 2628, 3581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2705, 2726);

                    f_10891_2705_2725(Exists);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2744, 2771);

                    f_10891_2744_2770(other.Exists);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2791, 2907) || true) && (ContainingSlot != other.ContainingSlot)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10891, 2791, 2907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 2875, 2888);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10891, 2791, 2907);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3140, 3179);

                    int?
                    thisIndex = f_10891_3157_3178(Symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3197, 3243);

                    int?
                    otherIndex = f_10891_3215_3242(other.Symbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3261, 3362) || true) && (thisIndex != otherIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10891, 3261, 3362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3330, 3343);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10891, 3261, 3362);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3382, 3477) || true) && (f_10891_3386_3404(thisIndex))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10891, 3382, 3477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3446, 3458);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10891, 3382, 3477);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3497, 3566);

                    return f_10891_3504_3565(Symbol, other.Symbol, TypeCompareKind.AllIgnoreOptions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10891, 2628, 3581);

                    int
                    f_10891_2705_2725(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2705, 2725);
                        return 0;
                    }


                    int
                    f_10891_2744_2770(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 2744, 2770);
                        return 0;
                    }


                    int?
                    f_10891_3157_3178(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.MemberIndexOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 3157, 3178);
                        return return_v;
                    }


                    int?
                    f_10891_3215_3242(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.MemberIndexOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 3215, 3242);
                        return return_v;
                    }


                    bool
                    f_10891_3386_3404(int?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 3386, 3404);
                        return return_v;
                    }


                    bool
                    f_10891_3504_3565(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    other, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(other, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 3504, 3565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 2628, 3581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 2628, 3581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10891, 3597, 3722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3670, 3707);

                    throw f_10891_3676_3706();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10891, 3597, 3722);

                    System.Exception
                    f_10891_3676_3706()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 3676, 3706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 3597, 3722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 3597, 3722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [Obsolete]
            public static bool operator ==(VariableIdentifier left, VariableIdentifier right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10891, 3738, 3928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 3876, 3913);

                    throw f_10891_3882_3912();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10891, 3738, 3928);

                    System.Exception
                    f_10891_3882_3912()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 3882, 3912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 3738, 3928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 3738, 3928);
                }
            }

            [Obsolete]
            public static bool operator !=(VariableIdentifier left, VariableIdentifier right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10891, 3944, 4134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 4082, 4119);

                    throw f_10891_4088_4118();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10891, 3944, 4134);

                    System.Exception
                    f_10891_4088_4118()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 4088, 4118);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 3944, 4134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 3944, 4134);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10891, 4150, 4311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10891, 4216, 4296);

                    return $"ContainingSlot={ContainingSlot}, Symbol={f_10891_4266_4293(Symbol)}";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10891, 4150, 4311);

                    string
                    f_10891_4266_4293(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetDebuggerDisplay();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 4266, 4293);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10891, 4150, 4311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 4150, 4311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static VariableIdentifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10891, 462, 4322);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10891, 462, 4322);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 462, 4322);
            }

            static int
            f_10891_1185_1218(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 1185, 1218);
                return 0;
            }


            static Microsoft.CodeAnalysis.SymbolKind
            f_10891_1250_1261(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 1250, 1261);
                return return_v;
            }


            static Microsoft.CodeAnalysis.MethodKind
            f_10891_1653_1665(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.MethodKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10891, 1653, 1665);
                return return_v;
            }


            static int
            f_10891_1237_1754(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10891, 1237, 1754);
                return 0;
            }

        }

        static LocalDataFlowPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10891, 371, 4329);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10891, 371, 4329);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10891, 371, 4329);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10891, 371, 4329);
    }
}
