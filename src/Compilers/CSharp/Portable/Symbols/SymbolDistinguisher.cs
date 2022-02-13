// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SymbolDistinguisher
    {
        private readonly CSharpCompilation _compilation;

        private readonly Symbol _symbol0;

        private readonly Symbol _symbol1;

        private ImmutableArray<string> _lazyDescriptions;

        public SymbolDistinguisher(CSharpCompilation compilation, Symbol symbol0, Symbol symbol1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10164, 1302, 1647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1130, 1142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1177, 1185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1220, 1228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1416, 1449);

                f_10164_1416_1448(symbol0 != symbol1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1463, 1488);

                f_10164_1463_1487(symbol0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1502, 1527);

                f_10164_1502_1526(symbol1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1543, 1570);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1584, 1603);

                _symbol0 = symbol0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1617, 1636);

                _symbol1 = symbol1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10164, 1302, 1647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 1302, 1647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 1302, 1647);
            }
        }

        public IFormattable First
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 1709, 1749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1715, 1747);

                    return f_10164_1722_1746(this, 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 1709, 1749);

                    Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    f_10164_1722_1746(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                    distinguisher, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description(distinguisher, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 1722, 1746);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 1659, 1760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 1659, 1760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IFormattable Second
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 1823, 1863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1829, 1861);

                    return f_10164_1836_1860(this, 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 1823, 1863);

                    Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    f_10164_1836_1860(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                    distinguisher, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description(distinguisher, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 1836, 1860);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 1772, 1874);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 1772, 1874);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG")]
        private static void CheckSymbolKind(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10164, 1886, 3308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 1993, 3297);

                switch (f_10164_2001_2012(symbol))
                {

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                    case SymbolKind.Event:
                    case SymbolKind.Field:
                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 1993, 3297);
                        DynAbs.Tracing.TraceSender.TraceBreak(10164, 2350, 2356);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 1993, 3297);

                    case SymbolKind.ArrayType:
                    case SymbolKind.PointerType:
                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 1993, 3297);
                        DynAbs.Tracing.TraceSender.TraceBreak(10164, 2545, 2551);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 1993, 3297);

                    case SymbolKind.DynamicType: // Can't sensibly append location, but it should never be ambiguous.
                    case SymbolKind.FunctionPointerType: // Can't sensibly append location
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 1993, 3297);
                        DynAbs.Tracing.TraceSender.TraceBreak(10164, 2827, 2833);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 1993, 3297);

                    case SymbolKind.Namespace:
                    case SymbolKind.Alias:
                    case SymbolKind.Assembly:
                    case SymbolKind.NetModule:
                    case SymbolKind.Label:
                    case SymbolKind.Local:
                    case SymbolKind.RangeVariable:
                    case SymbolKind.Preprocessing:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 1993, 3297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3228, 3282);

                        throw f_10164_3234_3281(f_10164_3269_3280(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 1993, 3297);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10164, 1886, 3308);

                Microsoft.CodeAnalysis.SymbolKind
                f_10164_2001_2012(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 2001, 2012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10164_3269_3280(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 3269, 3280);
                    return return_v;
                }


                System.Exception
                f_10164_3234_3281(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3234, 3281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 1886, 3308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 1886, 3308);
            }
        }

        private void MakeDescriptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 3320, 5800);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3376, 3417) || true) && (f_10164_3380_3408_M(!_lazyDescriptions.IsDefault))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 3376, 3417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3410, 3417);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 3376, 3417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3433, 3482);

                string
                description0 = f_10164_3455_3481(_symbol0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3496, 3545);

                string
                description1 = f_10164_3518_3544(_symbol1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3561, 5599) || true) && (description0 == description1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 3561, 5599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3627, 3676);

                    Symbol
                    unwrappedSymbol0 = f_10164_3653_3675(_symbol0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3694, 3743);

                    Symbol
                    unwrappedSymbol1 = f_10164_3720_3742(_symbol1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3763, 3832);

                    string
                    location0 = f_10164_3782_3831(_compilation, unwrappedSymbol0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 3850, 3919);

                    string
                    location1 = f_10164_3869_3918(_compilation, unwrappedSymbol1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 4100, 5173) || true) && (location0 == location1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 4100, 5173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 4168, 4230);

                        var
                        containingAssembly0 = f_10164_4194_4229(unwrappedSymbol0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 4252, 4314);

                        var
                        containingAssembly1 = f_10164_4278_4313(unwrappedSymbol1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 4408, 5154) || true) && ((object)containingAssembly0 != null && (DynAbs.Tracing.TraceSender.Expression_True(10164, 4412, 4486) && (object)containingAssembly1 != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 4408, 5154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5001, 5053);

                            location0 = f_10164_5013_5052(f_10164_5013_5041(containingAssembly0));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5079, 5131);

                            location1 = f_10164_5091_5130(f_10164_5091_5119(containingAssembly1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 4408, 5154);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 4100, 5173);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5193, 5584) || true) && (location0 != location1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5193, 5584);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5261, 5402) || true) && (location0 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5261, 5402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5332, 5379);

                            description0 = $"{description0} [{location0}]";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5261, 5402);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5424, 5565) || true) && (location1 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5424, 5565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5495, 5542);

                            description1 = $"{description1} [{location1}]";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5424, 5565);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5193, 5584);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 3561, 5599);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5615, 5656) || true) && (f_10164_5619_5647_M(!_lazyDescriptions.IsDefault))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5615, 5656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5649, 5656);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5615, 5656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5672, 5789);

                f_10164_5672_5788(ref _lazyDescriptions, f_10164_5738_5787(description0, description1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 3320, 5800);

                bool
                f_10164_3380_3408_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 3380, 3408);
                    return return_v;
                }


                string
                f_10164_3455_3481(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3455, 3481);
                    return return_v;
                }


                string
                f_10164_3518_3544(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3518, 3544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10164_3653_3675(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3653, 3675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10164_3720_3742(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3720, 3742);
                    return return_v;
                }


                string
                f_10164_3782_3831(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                unwrappedSymbol)
                {
                    var return_v = GetLocationString(compilation, unwrappedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3782, 3831);
                    return return_v;
                }


                string
                f_10164_3869_3918(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                unwrappedSymbol)
                {
                    var return_v = GetLocationString(compilation, unwrappedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 3869, 3918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10164_4194_4229(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 4194, 4229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10164_4278_4313(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 4278, 4313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10164_5013_5041(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 5013, 5041);
                    return return_v;
                }


                string
                f_10164_5013_5052(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 5013, 5052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10164_5091_5119(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 5091, 5119);
                    return return_v;
                }


                string
                f_10164_5091_5130(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 5091, 5130);
                    return return_v;
                }


                bool
                f_10164_5619_5647_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 5619, 5647);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10164_5738_5787(string
                item1, string
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 5738, 5787);
                    return return_v;
                }


                bool
                f_10164_5672_5788(ref System.Collections.Immutable.ImmutableArray<string>
                location, System.Collections.Immutable.ImmutableArray<string>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 5672, 5788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 3320, 5800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 3320, 5800);
            }
        }

        private static Symbol UnwrapSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10164, 5812, 6552);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5886, 6541) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5886, 6541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 5931, 6526);

                        switch (f_10164_5939_5950(symbol))
                        {

                            case SymbolKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5931, 6526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6044, 6084);

                                symbol = f_10164_6053_6083(((ParameterSymbol)symbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6110, 6119);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5931, 6526);

                            case SymbolKind.PointerType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5931, 6526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6195, 6246);

                                symbol = f_10164_6204_6245(((PointerTypeSymbol)symbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6272, 6281);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5931, 6526);

                            case SymbolKind.ArrayType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5931, 6526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6355, 6402);

                                symbol = f_10164_6364_6401(((ArrayTypeSymbol)symbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6428, 6437);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5931, 6526);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 5931, 6526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6493, 6507);

                                return symbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5931, 6526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 5886, 6541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10164, 5886, 6541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10164, 5886, 6541);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10164, 5812, 6552);

                Microsoft.CodeAnalysis.SymbolKind
                f_10164_5939_5950(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 5939, 5950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10164_6053_6083(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 6053, 6083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10164_6204_6245(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 6204, 6245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10164_6364_6401(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 6364, 6401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 5812, 6552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 5812, 6552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetLocationString(CSharpCompilation compilation, Symbol unwrappedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10164, 6564, 8358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6683, 6754);

                f_10164_6683_6753((object)unwrappedSymbol == f_10164_6723_6752(unwrappedSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6770, 6863);

                ImmutableArray<SyntaxReference>
                syntaxReferences = f_10164_6821_6862(unwrappedSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6877, 7349) || true) && (syntaxReferences.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 6877, 7349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 6942, 6984);

                    var
                    tree = f_10164_6953_6983(syntaxReferences[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7002, 7038);

                    var
                    span = f_10164_7013_7037(syntaxReferences[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7056, 7172);

                    string
                    path = f_10164_7070_7171(tree, span, (DynAbs.Tracing.TraceSender.Conditional_F1(10164, 7096, 7117) || (((compilation != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10164, 7120, 7163)) || DynAbs.Tracing.TraceSender.Conditional_F3(10164, 7166, 7170))) ? f_10164_7120_7163(f_10164_7120_7139(compilation)) : null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7190, 7334) || true) && (!f_10164_7195_7221(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 7190, 7334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7263, 7315);

                        return $"{path}({f_10164_7280_7311(tree, span)})";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 7190, 7334);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 6877, 7349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7365, 7436);

                AssemblySymbol
                containingAssembly = f_10164_7401_7435(unwrappedSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7450, 8138) || true) && ((object)containingAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 7450, 8138);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7522, 8057) || true) && (compilation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 7522, 8057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7587, 7719);

                        PortableExecutableReference
                        metadataReference = f_10164_7635_7687(compilation, containingAssembly) as PortableExecutableReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7741, 8038) || true) && (metadataReference != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 7741, 8038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7820, 7861);

                            string
                            path = f_10164_7834_7860(metadataReference)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7887, 8015) || true) && (!f_10164_7892_7918(path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 7887, 8015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 7976, 7988);

                                return path;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 7887, 8015);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 7741, 8038);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 7522, 8057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8077, 8123);

                    return f_10164_8084_8122(f_10164_8084_8111(containingAssembly));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 7450, 8138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8154, 8321);

                f_10164_8154_8320(f_10164_8167_8187(unwrappedSymbol) == SymbolKind.DynamicType || (DynAbs.Tracing.TraceSender.Expression_False(10164, 8167, 8261) || f_10164_8217_8237(unwrappedSymbol) == SymbolKind.ErrorType) || (DynAbs.Tracing.TraceSender.Expression_False(10164, 8167, 8319) || f_10164_8265_8285(unwrappedSymbol) == SymbolKind.FunctionPointerType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8335, 8347);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10164, 6564, 8358);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10164_6723_6752(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 6723, 6752);
                    return return_v;
                }


                int
                f_10164_6683_6753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 6683, 6753);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10164_6821_6862(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 6821, 6862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10164_6953_6983(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 6953, 6983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10164_7013_7037(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 7013, 7037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10164_7120_7139(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 7120, 7139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_10164_7120_7163(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 7120, 7163);
                    return return_v;
                }


                string
                f_10164_7070_7171(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.SourceReferenceResolver?
                resolver)
                {
                    var return_v = this_param.GetDisplayPath(span, resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 7070, 7171);
                    return return_v;
                }


                bool
                f_10164_7195_7221(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 7195, 7221);
                    return return_v;
                }


                int
                f_10164_7280_7311(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetDisplayLineNumber(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 7280, 7311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10164_7401_7435(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 7401, 7435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference?
                f_10164_7635_7687(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assemblySymbol)
                {
                    var return_v = this_param.GetMetadataReference(assemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 7635, 7687);
                    return return_v;
                }


                string?
                f_10164_7834_7860(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 7834, 7860);
                    return return_v;
                }


                bool
                f_10164_7892_7918(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 7892, 7918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10164_8084_8111(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 8084, 8111);
                    return return_v;
                }


                string
                f_10164_8084_8122(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 8084, 8122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10164_8167_8187(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 8167, 8187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10164_8217_8237(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 8217, 8237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10164_8265_8285(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10164, 8265, 8285);
                    return return_v;
                }


                int
                f_10164_8154_8320(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 8154, 8320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 6564, 8358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 6564, 8358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDescription(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 8370, 8511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8435, 8454);

                f_10164_8435_8453(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8468, 8500);

                return _lazyDescriptions[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 8370, 8511);

                int
                f_10164_8435_8453(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    this_param.MakeDescriptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 8435, 8453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 8370, 8511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 8370, 8511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class Description : IFormattable
        {
            private readonly SymbolDistinguisher _distinguisher;

            private readonly int _index;

            public Description(SymbolDistinguisher distinguisher, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10164, 8705, 8881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8632, 8646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8682, 8688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8802, 8833);

                    _distinguisher = distinguisher;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8851, 8866);

                    _index = index;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10164, 8705, 8881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 8705, 8881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 8705, 8881);
                }
            }

            private Symbol GetSymbol()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 8897, 9044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 8956, 9029);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10164, 8963, 8976) || (((_index == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10164, 8979, 9002)) || DynAbs.Tracing.TraceSender.Conditional_F3(10164, 9005, 9028))) ? _distinguisher._symbol0 : _distinguisher._symbol1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 8897, 9044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 8897, 9044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 8897, 9044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 9060, 9363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9132, 9163);

                    var
                    other = obj as Description
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9181, 9348);

                    return other != null && (DynAbs.Tracing.TraceSender.Expression_True(10164, 9188, 9290) && _distinguisher._compilation == other._distinguisher._compilation) && (DynAbs.Tracing.TraceSender.Expression_True(10164, 9188, 9347) && f_10164_9315_9326(this) == f_10164_9330_9347(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 9060, 9363);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10164_9315_9326(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    this_param)
                    {
                        var return_v = this_param.GetSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9315, 9326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10164_9330_9347(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    this_param)
                    {
                        var return_v = this_param.GetSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9330, 9347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 9060, 9363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 9060, 9363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 9379, 9754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9445, 9484);

                    int
                    result = f_10164_9458_9483(f_10164_9458_9469(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9502, 9548);

                    var
                    compilation = _distinguisher._compilation
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9566, 9707) || true) && (compilation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10164, 9566, 9707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9631, 9688);

                        result = f_10164_9640_9687(result, f_10164_9661_9686(compilation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10164, 9566, 9707);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9725, 9739);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 9379, 9754);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10164_9458_9469(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    this_param)
                    {
                        var return_v = this_param.GetSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9458, 9469);
                        return return_v;
                    }


                    int
                    f_10164_9458_9483(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9458, 9483);
                        return return_v;
                    }


                    int
                    f_10164_9661_9686(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9661, 9686);
                        return return_v;
                    }


                    int
                    f_10164_9640_9687(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9640, 9687);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 9379, 9754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 9379, 9754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 9770, 9896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 9836, 9881);

                    return f_10164_9843_9880(_distinguisher, _index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 9770, 9896);

                    string
                    f_10164_9843_9880(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetDescription(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 9843, 9880);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 9770, 9896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 9770, 9896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string IFormattable.ToString(string format, IFormatProvider formatProvider)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10164, 9912, 10053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10164, 10020, 10038);

                    return f_10164_10027_10037(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10164, 9912, 10053);

                    string
                    f_10164_10027_10037(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher.Description
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 10027, 10037);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10164, 9912, 10053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 9912, 10053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Description()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10164, 8523, 10064);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10164, 8523, 10064);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 8523, 10064);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10164, 8523, 10064);
        }

        static SymbolDistinguisher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10164, 1037, 10071);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10164, 1037, 10071);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10164, 1037, 10071);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10164, 1037, 10071);

        int
        f_10164_1416_1448(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 1416, 1448);
            return 0;
        }


        int
        f_10164_1463_1487(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            CheckSymbolKind(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 1463, 1487);
            return 0;
        }


        int
        f_10164_1502_1526(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            CheckSymbolKind(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10164, 1502, 1526);
            return 0;
        }

    }
}
