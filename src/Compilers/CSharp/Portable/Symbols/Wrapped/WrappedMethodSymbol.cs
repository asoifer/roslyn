// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedMethodSymbol : MethodSymbol
    {
        public WrappedMethodSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10385, 845, 895);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10385, 845, 895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 845, 895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 845, 895);
            }
        }

        public abstract MethodSymbol UnderlyingMethod
        {
            get;
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1058, 1142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1094, 1127);

                    return f_10385_1101_1126(f_10385_1101_1117());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1058, 1142);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1101_1117()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1101, 1117);
                        return return_v;
                    }


                    bool
                    f_10385_1101_1126(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1101, 1126);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1004, 1153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1004, 1153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1226, 1317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1262, 1302);

                    return f_10385_1269_1301(f_10385_1269_1285());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1226, 1317);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1269_1285()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1269, 1285);
                        return return_v;
                    }


                    bool
                    f_10385_1269_1301(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1269, 1301);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1165, 1328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1165, 1328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1390, 1471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1426, 1456);

                    return f_10385_1433_1455(f_10385_1433_1449());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1390, 1471);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1433_1449()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1433, 1449);
                        return return_v;
                    }


                    int
                    f_10385_1433_1455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1433, 1455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1340, 1482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1340, 1482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1550, 1633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1586, 1618);

                    return f_10385_1593_1617(f_10385_1593_1609());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1550, 1633);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1593_1609()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1593, 1609);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10385_1593_1617(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1593, 1617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1494, 1644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1494, 1644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1717, 1764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1723, 1762);

                    return f_10385_1730_1761(f_10385_1730_1746());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1717, 1764);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1730_1746()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1730, 1746);
                        return return_v;
                    }


                    int
                    f_10385_1730_1761(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1730, 1761);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1656, 1775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1656, 1775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 1850, 1943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 1886, 1928);

                    return f_10385_1893_1927(f_10385_1893_1909());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 1850, 1943);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_1893_1909()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1893, 1909);
                        return return_v;
                    }


                    bool
                    f_10385_1893_1927(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtensionMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 1893, 1927);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1787, 1954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1787, 1954);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2034, 2132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 2070, 2117);

                    return f_10385_2077_2116(f_10385_2077_2093());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2034, 2132);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_2077_2093()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2077, 2093);
                        return return_v;
                    }


                    bool
                    f_10385_2077_2116(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HidesBaseMethodsByName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2077, 2116);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 1966, 2143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 1966, 2143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2216, 2307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 2252, 2292);

                    return f_10385_2259_2291(f_10385_2259_2275());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2216, 2307);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_2259_2275()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2259, 2275);
                        return return_v;
                    }


                    bool
                    f_10385_2259_2291(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2259, 2291);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 2155, 2318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 2155, 2318);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2405, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 2441, 2475);

                    return f_10385_2448_2474(f_10385_2448_2464());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2405, 2490);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_2448_2464()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2448, 2464);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10385_2448_2474(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2448, 2474);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 2330, 2501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 2330, 2501);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2611, 2712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 2647, 2697);

                    return f_10385_2654_2696(f_10385_2654_2670());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2611, 2712);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_2654_2670()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2654, 2670);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10385_2654_2696(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2654, 2696);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 2513, 2723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 2513, 2723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2811, 2908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 2847, 2893);

                    return f_10385_2854_2892(f_10385_2854_2870());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2811, 2908);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_2854_2870()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2854, 2870);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10385_2854_2892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 2854, 2892);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 2735, 2919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 2735, 2919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 2985, 3069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3021, 3054);

                    return f_10385_3028_3053(f_10385_3028_3044());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 2985, 3069);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3028_3044()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3028, 3044);
                        return return_v;
                    }


                    bool
                    f_10385_3028_3053(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3028, 3053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 2931, 3080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 2931, 3080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool RequiresInstanceReceiver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3162, 3262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3198, 3247);

                    return f_10385_3205_3246(f_10385_3205_3221());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3162, 3262);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3205_3221()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3205, 3221);
                        return return_v;
                    }


                    bool
                    f_10385_3205_3246(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RequiresInstanceReceiver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3205, 3246);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3092, 3273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3092, 3273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3340, 3425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3376, 3410);

                    return f_10385_3383_3409(f_10385_3383_3399());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3340, 3425);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3383_3399()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3383, 3399);
                        return return_v;
                    }


                    bool
                    f_10385_3383_3409(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3383, 3409);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3285, 3436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3285, 3436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3501, 3584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3537, 3569);

                    return f_10385_3544_3568(f_10385_3544_3560());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3501, 3584);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3544_3560()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3544, 3560);
                        return return_v;
                    }


                    bool
                    f_10385_3544_3568(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAsync;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3544, 3568);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3448, 3595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3448, 3595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3663, 3749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3699, 3734);

                    return f_10385_3706_3733(f_10385_3706_3722());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3663, 3749);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3706_3722()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3706, 3722);
                        return return_v;
                    }


                    bool
                    f_10385_3706_3733(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3706, 3733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3607, 3760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3607, 3760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3828, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 3864, 3899);

                    return f_10385_3871_3898(f_10385_3871_3887());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3828, 3914);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_3871_3887()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3871, 3887);
                        return return_v;
                    }


                    bool
                    f_10385_3871_3898(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 3871, 3898);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3772, 3925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3772, 3925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 3991, 4075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4027, 4060);

                    return f_10385_4034_4059(f_10385_4034_4050());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 3991, 4075);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_4034_4050()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4034, 4050);
                        return return_v;
                    }


                    bool
                    f_10385_4034_4059(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4034, 4059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 3937, 4086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 3937, 4086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 4152, 4236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4188, 4221);

                    return f_10385_4195_4220(f_10385_4195_4211());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 4152, 4236);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_4195_4211()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4195, 4211);
                        return return_v;
                    }


                    bool
                    f_10385_4195_4220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4195, 4220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 4098, 4247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 4098, 4247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 4325, 4421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4361, 4406);

                    return f_10385_4368_4405(f_10385_4368_4384());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 4325, 4421);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_4368_4384()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4368, 4384);
                        return return_v;
                    }


                    bool
                    f_10385_4368_4405(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4368, 4405);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 4259, 4432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 4259, 4432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 4444, 4651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4560, 4640);

                return f_10385_4567_4639(f_10385_4567_4583(), ignoreInterfaceImplementationChanges);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 4444, 4651);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_4567_4583()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4567, 4583);
                    return return_v;
                }


                bool
                f_10385_4567_4639(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 4567, 4639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 4444, 4651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 4444, 4651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 4726, 4817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4762, 4802);

                    return f_10385_4769_4801(f_10385_4769_4785());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 4726, 4817);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_4769_4785()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4769, 4785);
                        return return_v;
                    }


                    bool
                    f_10385_4769_4801(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataFinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4769, 4801);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 4663, 4828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 4663, 4828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 4840, 5047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 4956, 5036);

                return f_10385_4963_5035(f_10385_4963_4979(), ignoreInterfaceImplementationChanges);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 4840, 5047);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_4963_4979()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 4963, 4979);
                    return return_v;
                }


                bool
                f_10385_4963_5035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataNewSlot(ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 4963, 5035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 4840, 5047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 4840, 5047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5129, 5227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 5165, 5212);

                    return f_10385_5172_5211(f_10385_5172_5188());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5129, 5227);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_5172_5188()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5172, 5188);
                        return return_v;
                    }


                    bool
                    f_10385_5172_5211(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RequiresSecurityObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5172, 5211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5059, 5238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5059, 5238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5250, 5377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 5323, 5366);

                return f_10385_5330_5365(f_10385_5330_5346());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5250, 5377);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_5330_5346()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5330, 5346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DllImportData?
                f_10385_5330_5365(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetDllImportData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 5330, 5365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5250, 5377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5250, 5377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5498, 5607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 5534, 5592);

                    return f_10385_5541_5591(f_10385_5541_5557());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5498, 5607);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_5541_5557()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5541, 5557);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10385_5541_5591(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5541, 5591);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5389, 5618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5389, 5618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5700, 5755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 5706, 5753);

                    return f_10385_5713_5752(f_10385_5713_5729());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5700, 5755);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_5713_5729()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5713, 5729);
                        return return_v;
                    }


                    bool
                    f_10385_5713_5752(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5713, 5752);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5630, 5766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5630, 5766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5778, 5950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 5890, 5939);

                return f_10385_5897_5938(f_10385_5897_5913());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5778, 5950);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_5897_5913()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 5897, 5913);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10385_5897_5938(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSecurityInformation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 5897, 5938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5778, 5950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5778, 5950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 5962, 6124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 6058, 6113);

                return f_10385_6065_6112(f_10385_6065_6081());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 5962, 6124);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_6065_6081()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6065, 6081);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10385_6065_6112(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAppliedConditionalSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 6065, 6112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 5962, 6124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 5962, 6124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 6222, 6319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 6258, 6304);

                    return f_10385_6265_6303(f_10385_6265_6281());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 6222, 6319);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_6265_6281()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6265, 6281);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10385_6265_6303(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6265, 6303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 6136, 6330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 6136, 6330);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 6394, 6474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 6430, 6459);

                    return f_10385_6437_6458(f_10385_6437_6453());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 6394, 6474);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_6437_6453()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6437, 6453);
                        return return_v;
                    }


                    string
                    f_10385_6437_6458(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6437, 6458);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 6342, 6485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 6342, 6485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 6559, 6649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 6595, 6634);

                    return f_10385_6602_6633(f_10385_6602_6618());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 6559, 6649);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_6602_6618()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6602, 6618);
                        return return_v;
                    }


                    bool
                    f_10385_6602_6633(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6602, 6633);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 6497, 6660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 6497, 6660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 6672, 6993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 6878, 6982);

                return f_10385_6885_6981(f_10385_6885_6901(), preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 6672, 6993);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10385_6885_6901()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 6885, 6901);
                    return return_v;
                }


                string
                f_10385_6885_6981(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10385, 6885, 6981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 6672, 6993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 6672, 6993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 7111, 7211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 7147, 7196);

                    return f_10385_7154_7195(f_10385_7154_7170());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 7111, 7211);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_7154_7170()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7154, 7170);
                        return return_v;
                    }


                    System.Reflection.MethodImplAttributes
                    f_10385_7154_7195(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ImplementationAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7154, 7195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7005, 7222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7005, 7222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 7296, 7382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 7332, 7367);

                    return f_10385_7339_7366(f_10385_7339_7355());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 7296, 7382);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_7339_7355()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7339, 7355);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10385_7339_7366(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7339, 7366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7234, 7393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7234, 7393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Microsoft.Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 7497, 7590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 7533, 7575);

                    return f_10385_7540_7574(f_10385_7540_7556());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 7497, 7590);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_7540_7556()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7540, 7556);
                        return return_v;
                    }


                    Microsoft.Cci.CallingConvention
                    f_10385_7540_7574(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7540, 7574);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7405, 7601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7405, 7601);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 7686, 7787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 7722, 7772);

                    return f_10385_7729_7771(f_10385_7729_7745());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 7686, 7787);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_7729_7745()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7729, 7745);
                        return return_v;
                    }


                    bool
                    f_10385_7729_7771(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAccessCheckedOnOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7729, 7771);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7613, 7798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7613, 7798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 7868, 7954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 7904, 7939);

                    return f_10385_7911_7938(f_10385_7911_7927());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 7868, 7954);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_7911_7927()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7911, 7927);
                        return return_v;
                    }


                    bool
                    f_10385_7911_7938(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 7911, 7938);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7810, 7965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7810, 7965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8046, 8143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8082, 8128);

                    return f_10385_8089_8127(f_10385_8089_8105());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8046, 8143);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_8089_8105()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8089, 8105);
                        return return_v;
                    }


                    bool
                    f_10385_8089_8127(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8089, 8127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 7977, 8154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 7977, 8154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8206, 8237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8209, 8237);
                    return f_10385_8209_8237(f_10385_8209_8225()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8206, 8237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8206, 8237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8206, 8237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8331, 8384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8334, 8384);
                    return f_10385_8334_8384(f_10385_8334_8350()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8331, 8384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8331, 8384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8331, 8384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8477, 8528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8480, 8528);
                    return f_10385_8480_8528(f_10385_8480_8496()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8477, 8528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8477, 8528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8477, 8528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8612, 8655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8615, 8655);
                    return f_10385_8615_8655(f_10385_8615_8631()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8612, 8655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8612, 8655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8612, 8655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8731, 8765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8734, 8765);
                    return f_10385_8734_8765(f_10385_8734_8750()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8731, 8765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8731, 8765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8731, 8765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8849, 8891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8852, 8891);
                    return f_10385_8852_8891(f_10385_8852_8868()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8849, 8891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8849, 8891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8849, 8891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 8976, 9019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 8979, 9019);
                    return f_10385_8979_9019(f_10385_8979_8995()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 8976, 9019);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 8976, 9019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 8976, 9019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 9113, 9222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 9149, 9207);

                    return f_10385_9156_9206(f_10385_9156_9172());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 9113, 9222);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_9156_9172()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9156, 9172);
                        return return_v;
                    }


                    bool
                    f_10385_9156_9206(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9156, 9206);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 9032, 9233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 9032, 9233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 9341, 9449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 9377, 9434);

                    return f_10385_9384_9433(f_10385_9384_9400());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 9341, 9449);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_9384_9400()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9384, 9400);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10385_9384_9433(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9384, 9433);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 9245, 9460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 9245, 9460);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 9537, 9630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 9573, 9615);

                    return f_10385_9580_9614(f_10385_9580_9596());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 9537, 9630);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10385_9580_9596()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9580, 9596);
                        return return_v;
                    }


                    bool
                    f_10385_9580_9614(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GenerateDebugInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9580, 9614);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 9472, 9641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 9472, 9641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 9695, 9733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 9698, 9733);
                    return f_10385_9698_9733(f_10385_9698_9714()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 9695, 9733);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 9695, 9733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 9695, 9733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10385, 9780, 9810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10385, 9783, 9810);
                    return f_10385_9783_9810(f_10385_9783_9799()); DynAbs.Tracing.TraceSender.TraceExitMethod(10385, 9780, 9810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10385, 9780, 9810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 9780, 9810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WrappedMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10385, 770, 9818);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10385, 770, 9818);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10385, 770, 9818);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10385, 770, 9818);

        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8209_8225()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8209, 8225);
            return return_v;
        }


        bool
        f_10385_8209_8237(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnsVoid;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8209, 8237);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8334_8350()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8334, 8350);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10385_8334_8384(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8334, 8384);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8480_8496()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8480, 8496);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>
        f_10385_8480_8528(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnNotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8480, 8528);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8615_8631()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8615, 8631);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10385_8615_8655(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.FlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8615, 8655);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8734_8750()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8734, 8750);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>
        f_10385_8734_8765(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.NotNullMembers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8734, 8765);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8852_8868()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8852, 8868);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>
        f_10385_8852_8891(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.NotNullWhenTrueMembers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8852, 8891);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_8979_8995()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8979, 8995);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>
        f_10385_8979_9019(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.NotNullWhenFalseMembers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 8979, 9019);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_9698_9714()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9698, 9714);
            return return_v;
        }


        bool
        f_10385_9698_9733(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsDeclaredReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9698, 9733);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10385_9783_9799()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9783, 9799);
            return return_v;
        }


        bool
        f_10385_9783_9810(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsInitOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10385, 9783, 9810);
            return return_v;
        }

    }
}
