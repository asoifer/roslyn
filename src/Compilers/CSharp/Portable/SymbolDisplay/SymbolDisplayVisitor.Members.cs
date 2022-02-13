// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SymbolDisplayVisitor
    {
        private const string
        IL_KEYWORD_MODOPT = "modopt"
        ;

        private const string
        IL_KEYWORD_MODREQ = "modreq"
        ;

        private void VisitFieldType(IFieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 708, 833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 781, 822);

                f_10956_781_821(f_10956_781_792(symbol), f_10956_800_820(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 708, 833);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_781_792(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 781, 792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_800_820(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 800, 820);
                    return return_v;
                }


                int
                f_10956_781_821(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 781, 821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 708, 833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 708, 833);
            }
        }

        public override void VisitField(IFieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 845, 2836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 922, 957);

                f_10956_922_956(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 971, 1008);

                f_10956_971_1007(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1022, 1058);

                f_10956_1022_1057(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1074, 1415) || true) && (f_10956_1078_1153(f_10956_1078_1098(format), SymbolDisplayMemberOptions.IncludeType) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 1078, 1199) && this.isFirstSymbolVisited) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 1078, 1241) && !f_10956_1221_1241(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1074, 1415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1275, 1298);

                    f_10956_1275_1297(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1316, 1327);

                    f_10956_1316_1326(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1347, 1400);

                    f_10956_1347_1399(this, f_10956_1376_1398(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1074, 1415);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1431, 1734) || true) && (f_10956_1435_1520(f_10956_1435_1455(format), SymbolDisplayMemberOptions.IncludeContainingType) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 1435, 1580) && f_10956_1541_1580(this, f_10956_1558_1579(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1431, 1734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1614, 1665);

                    f_10956_1614_1664(f_10956_1614_1635(symbol), f_10956_1643_1663(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1683, 1719);

                    f_10956_1683_1718(this, SyntaxKind.DotToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1431, 1734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1750, 2244) || true) && (f_10956_1754_1784(f_10956_1754_1775(symbol)) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1750, 2244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1835, 1918);

                    f_10956_1835_1917(builder, f_10956_1847_1916(this, SymbolDisplayPartKind.EnumMemberName, symbol, f_10956_1904_1915(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1750, 2244);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1750, 2244);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 1952, 2244) || true) && (f_10956_1956_1970(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1952, 2244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2004, 2085);

                        f_10956_2004_2084(builder, f_10956_2016_2083(this, SymbolDisplayPartKind.ConstantName, symbol, f_10956_2071_2082(symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1952, 2244);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 1952, 2244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2151, 2229);

                        f_10956_2151_2228(builder, f_10956_2163_2227(this, SymbolDisplayPartKind.FieldName, symbol, f_10956_2215_2226(symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1952, 2244);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 1750, 2244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2260, 2825) || true) && (this.isFirstSymbolVisited && (DynAbs.Tracing.TraceSender.Expression_True(10956, 2264, 2394) && f_10956_2310_2394(f_10956_2310_2330(format), SymbolDisplayMemberOptions.IncludeConstantValue)) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 2264, 2429) && f_10956_2415_2429(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 2264, 2473) && f_10956_2450_2473(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 2264, 2543) && f_10956_2494_2543(f_10956_2509_2520(symbol), f_10956_2522_2542(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 2260, 2825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2577, 2588);

                    f_10956_2577_2587(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2606, 2645);

                    f_10956_2606_2644(this, SyntaxKind.EqualsToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2663, 2674);

                    f_10956_2663_2673(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2694, 2810);

                    f_10956_2694_2809(this, f_10956_2711_2722(symbol), f_10956_2724_2744(symbol), preferNumericValueOrExpandedFlagsForEnum: f_10956_2788_2808(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 2260, 2825);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 845, 2836);

                int
                f_10956_922_956(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.AddAccessibilityIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 922, 956);
                    return 0;
                }


                int
                f_10956_971_1007(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.AddMemberModifiersIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 971, 1007);
                    return 0;
                }


                int
                f_10956_1022_1057(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.AddFieldModifiersIfRequired(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1022, 1057);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_1078_1098(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1078, 1098);
                    return return_v;
                }


                bool
                f_10956_1078_1153(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1078, 1153);
                    return return_v;
                }


                bool
                f_10956_1221_1241(Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    var return_v = IsEnumMember((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1221, 1241);
                    return return_v;
                }


                int
                f_10956_1275_1297(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.VisitFieldType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1275, 1297);
                    return 0;
                }


                int
                f_10956_1316_1326(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1316, 1326);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_1376_1398(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1376, 1398);
                    return return_v;
                }


                int
                f_10956_1347_1399(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1347, 1399);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_1435_1455(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1435, 1455);
                    return return_v;
                }


                bool
                f_10956_1435_1520(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1435, 1520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_1558_1579(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1558, 1579);
                    return return_v;
                }


                bool
                f_10956_1541_1580(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType)
                {
                    var return_v = this_param.IncludeNamedType(namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1541, 1580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_1614_1635(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1614, 1635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_1643_1663(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1643, 1663);
                    return return_v;
                }


                int
                f_10956_1614_1664(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1614, 1664);
                    return 0;
                }


                int
                f_10956_1683_1718(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1683, 1718);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_1754_1775(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1754, 1775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10956_1754_1784(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1754, 1784);
                    return return_v;
                }


                string
                f_10956_1904_1915(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1904, 1915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_1847_1916(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IFieldSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1847, 1916);
                    return return_v;
                }


                int
                f_10956_1835_1917(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 1835, 1917);
                    return 0;
                }


                bool
                f_10956_1956_1970(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 1956, 1970);
                    return return_v;
                }


                string
                f_10956_2071_2082(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2071, 2082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_2016_2083(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IFieldSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2016, 2083);
                    return return_v;
                }


                int
                f_10956_2004_2084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2004, 2084);
                    return 0;
                }


                string
                f_10956_2215_2226(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2215, 2226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_2163_2227(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IFieldSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2163, 2227);
                    return return_v;
                }


                int
                f_10956_2151_2228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2151, 2228);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_2310_2330(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2310, 2330);
                    return return_v;
                }


                bool
                f_10956_2310_2394(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2310, 2394);
                    return return_v;
                }


                bool
                f_10956_2415_2429(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2415, 2429);
                    return return_v;
                }


                bool
                f_10956_2450_2473(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2450, 2473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_2509_2520(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2509, 2520);
                    return return_v;
                }


                object
                f_10956_2522_2542(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2522, 2542);
                    return return_v;
                }


                bool
                f_10956_2494_2543(Microsoft.CodeAnalysis.ITypeSymbol
                type, object
                value)
                {
                    var return_v = CanAddConstant(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2494, 2543);
                    return return_v;
                }


                int
                f_10956_2577_2587(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2577, 2587);
                    return 0;
                }


                int
                f_10956_2606_2644(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2606, 2644);
                    return 0;
                }


                int
                f_10956_2663_2673(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2663, 2673);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_2711_2722(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2711, 2722);
                    return return_v;
                }


                object
                f_10956_2724_2744(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2724, 2744);
                    return return_v;
                }


                bool
                f_10956_2788_2808(Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    var return_v = IsEnumMember((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2788, 2808);
                    return return_v;
                }


                int
                f_10956_2694_2809(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type, object
                constantValue, bool
                preferNumericValueOrExpandedFlagsForEnum)
                {
                    this_param.AddConstantValue(type, constantValue, preferNumericValueOrExpandedFlagsForEnum: preferNumericValueOrExpandedFlagsForEnum);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 2694, 2809);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 845, 2836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 845, 2836);
            }
        }

        private static bool ShouldPropertyDisplayReadOnly(IPropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10956, 2848, 3674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 2948, 3057) || true) && (f_10956_2952_2987_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10956_2952_2975(property), 10956, 2952, 2987)?.IsReadOnly) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 2948, 3057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3029, 3042);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 2948, 3057);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3207, 3242);

                var
                getMethod = f_10956_3223_3241(property)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3256, 3394) || true) && (getMethod is object && (DynAbs.Tracing.TraceSender.Expression_True(10956, 3260, 3332) && !f_10956_3284_3332(getMethod, property)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 3256, 3394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3366, 3379);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 3256, 3394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3410, 3445);

                var
                setMethod = f_10956_3426_3444(property)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3459, 3597) || true) && (setMethod is object && (DynAbs.Tracing.TraceSender.Expression_True(10956, 3463, 3535) && !f_10956_3487_3535(setMethod, property)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 3459, 3597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3569, 3582);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 3459, 3597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3613, 3663);

                return getMethod is object || (DynAbs.Tracing.TraceSender.Expression_False(10956, 3620, 3662) || setMethod is object);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10956, 2848, 3674);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_2952_2975(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2952, 2975);
                    return return_v;
                }


                bool?
                f_10956_2952_2987_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 2952, 2987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_3223_3241(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 3223, 3241);
                    return return_v;
                }


                bool
                f_10956_3284_3332(Microsoft.CodeAnalysis.IMethodSymbol
                method, Microsoft.CodeAnalysis.IPropertySymbol
                propertyOpt)
                {
                    var return_v = ShouldMethodDisplayReadOnly(method, propertyOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 3284, 3332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_3426_3444(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 3426, 3444);
                    return return_v;
                }


                bool
                f_10956_3487_3535(Microsoft.CodeAnalysis.IMethodSymbol
                method, Microsoft.CodeAnalysis.IPropertySymbol
                propertyOpt)
                {
                    var return_v = ShouldMethodDisplayReadOnly(method, propertyOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 3487, 3535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 2848, 3674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 2848, 3674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ShouldMethodDisplayReadOnly(IMethodSymbol method, IPropertySymbol propertyOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10956, 3686, 4715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3816, 3923) || true) && (f_10956_3820_3853_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10956_3820_3841(method), 10956, 3820, 3853)?.IsReadOnly) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 3816, 3923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3895, 3908);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 3816, 3923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 3962, 4014);

                var
                a1 = method as Symbols.PublicModel.MethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4028, 4115);

                var
                a2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10956, 4037, 4047) || ((a1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10956, 4050, 4107)) || DynAbs.Tracing.TraceSender.Conditional_F3(10956, 4110, 4114))) ? f_10956_4050_4075(a1) as SourcePropertyAccessorSymbol : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4129, 4188);

                var
                a3 = propertyOpt as Symbols.PublicModel.PropertySymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4202, 4279);

                var
                a4 = (DynAbs.Tracing.TraceSender.Conditional_F1(10956, 4211, 4221) || ((a3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10956, 4224, 4271)) || DynAbs.Tracing.TraceSender.Conditional_F3(10956, 4274, 4278))) ? f_10956_4224_4243(a3) as SourcePropertySymbolBase : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4293, 4675) || true) && (a2 is not null && (DynAbs.Tracing.TraceSender.Expression_True(10956, 4297, 4329) && a4 is not null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 4293, 4675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4435, 4493);

                    return f_10956_4442_4466(a2) || (DynAbs.Tracing.TraceSender.Expression_False(10956, 4442, 4492) || f_10956_4470_4492(a4));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 4293, 4675);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 4293, 4675);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4527, 4675) || true) && (method is Symbols.PublicModel.MethodSymbol m)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 4527, 4675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4609, 4660);

                        return f_10956_4616_4659(f_10956_4616_4640(m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 4527, 4675);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 4293, 4675);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4691, 4704);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10956, 3686, 4715);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_3820_3841(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 3820, 3841);
                    return return_v;
                }


                bool?
                f_10956_3820_3853_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 3820, 3853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10956_4050_4075(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4050, 4075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10956_4224_4243(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PropertySymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4224, 4243);
                    return return_v;
                }


                bool
                f_10956_4442_4466(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4442, 4466);
                    return return_v;
                }


                bool
                f_10956_4470_4492(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.HasReadOnlyModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4470, 4492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10956_4616_4640(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4616, 4640);
                    return return_v;
                }


                bool
                f_10956_4616_4659(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 4616, 4659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 3686, 4715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 3686, 4715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitProperty(IPropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 4727, 6631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4810, 4845);

                f_10956_4810_4844(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4859, 4896);

                f_10956_4859_4895(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4912, 5026) || true) && (f_10956_4916_4953(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 4912, 5026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 4987, 5011);

                    f_10956_4987_5010(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 4912, 5026);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5042, 5658) || true) && (f_10956_5046_5121(f_10956_5046_5066(format), SymbolDisplayMemberOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 5042, 5658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5155, 5400) || true) && (f_10956_5159_5178(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 5155, 5400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5220, 5239);

                        f_10956_5220_5238(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 5155, 5400);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 5155, 5400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5281, 5400) || true) && (f_10956_5285_5312(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 5281, 5400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5354, 5381);

                            f_10956_5354_5380(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 5281, 5400);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 5155, 5400);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5420, 5476);

                    f_10956_5420_5475(this, f_10956_5449_5474(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5496, 5537);

                    f_10956_5496_5536(f_10956_5496_5507(symbol), f_10956_5515_5535(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5555, 5566);

                    f_10956_5555_5565(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5586, 5643);

                    f_10956_5586_5642(this, f_10956_5615_5641(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 5042, 5658);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5674, 5977) || true) && (f_10956_5678_5763(f_10956_5678_5698(format), SymbolDisplayMemberOptions.IncludeContainingType) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 5678, 5823) && f_10956_5784_5823(this, f_10956_5801_5822(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 5674, 5977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5857, 5908);

                    f_10956_5857_5907(f_10956_5857_5878(symbol), f_10956_5886_5906(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5926, 5962);

                    f_10956_5926_5961(this, SyntaxKind.DotToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 5674, 5977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 5993, 6030);

                f_10956_5993_6029(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6046, 6620) || true) && (f_10956_6050_6070(format) == SymbolDisplayPropertyStyle.ShowReadWriteDescriptor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 6046, 6620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6158, 6169);

                    f_10956_6158_6168(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6187, 6229);

                    f_10956_6187_6228(this, SyntaxKind.OpenBraceToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6249, 6310);

                    f_10956_6249_6309(this, symbol, f_10956_6269_6285(symbol), SyntaxKind.GetKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6328, 6434);

                    var
                    keywordForSetAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10956, 6356, 6384) || ((f_10956_6356_6384(f_10956_6367_6383(symbol)) && DynAbs.Tracing.TraceSender.Conditional_F2(10956, 6387, 6409)) || DynAbs.Tracing.TraceSender.Conditional_F3(10956, 6412, 6433))) ? SyntaxKind.InitKeyword : SyntaxKind.SetKeyword
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6452, 6513);

                    f_10956_6452_6512(this, symbol, f_10956_6472_6488(symbol), keywordForSetAccessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6533, 6544);

                    f_10956_6533_6543(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6562, 6605);

                    f_10956_6562_6604(this, SyntaxKind.CloseBraceToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 6046, 6620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 4727, 6631);

                int
                f_10956_4810_4844(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    this_param.AddAccessibilityIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 4810, 4844);
                    return 0;
                }


                int
                f_10956_4859_4895(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    this_param.AddMemberModifiersIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 4859, 4895);
                    return 0;
                }


                bool
                f_10956_4916_4953(Microsoft.CodeAnalysis.IPropertySymbol
                property)
                {
                    var return_v = ShouldPropertyDisplayReadOnly(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 4916, 4953);
                    return return_v;
                }


                int
                f_10956_4987_5010(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddReadOnlyIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 4987, 5010);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_5046_5066(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5046, 5066);
                    return return_v;
                }


                bool
                f_10956_5046_5121(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5046, 5121);
                    return return_v;
                }


                bool
                f_10956_5159_5178(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5159, 5178);
                    return return_v;
                }


                int
                f_10956_5220_5238(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddRefIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5220, 5238);
                    return 0;
                }


                bool
                f_10956_5285_5312(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5285, 5312);
                    return return_v;
                }


                int
                f_10956_5354_5380(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddRefReadonlyIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5354, 5380);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_5449_5474(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5449, 5474);
                    return return_v;
                }


                int
                f_10956_5420_5475(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5420, 5475);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_5496_5507(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5496, 5507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_5515_5535(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5515, 5535);
                    return return_v;
                }


                int
                f_10956_5496_5536(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5496, 5536);
                    return 0;
                }


                int
                f_10956_5555_5565(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5555, 5565);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_5615_5641(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5615, 5641);
                    return return_v;
                }


                int
                f_10956_5586_5642(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5586, 5642);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_5678_5698(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5678, 5698);
                    return return_v;
                }


                bool
                f_10956_5678_5763(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5678, 5763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_5801_5822(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5801, 5822);
                    return return_v;
                }


                bool
                f_10956_5784_5823(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType)
                {
                    var return_v = this_param.IncludeNamedType(namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5784, 5823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_5857_5878(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5857, 5878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_5886_5906(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 5886, 5906);
                    return return_v;
                }


                int
                f_10956_5857_5907(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5857, 5907);
                    return 0;
                }


                int
                f_10956_5926_5961(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5926, 5961);
                    return 0;
                }


                int
                f_10956_5993_6029(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    this_param.AddPropertyNameAndParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 5993, 6029);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
                f_10956_6050_6070(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.PropertyStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6050, 6070);
                    return return_v;
                }


                int
                f_10956_6158_6168(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6158, 6168);
                    return 0;
                }


                int
                f_10956_6187_6228(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6187, 6228);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_6269_6285(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6269, 6285);
                    return return_v;
                }


                int
                f_10956_6249_6309(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                property, Microsoft.CodeAnalysis.IMethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keyword)
                {
                    this_param.AddAccessor(property, method, keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6249, 6309);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_6367_6383(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6367, 6383);
                    return return_v;
                }


                bool
                f_10956_6356_6384(Microsoft.CodeAnalysis.IMethodSymbol?
                symbol)
                {
                    var return_v = IsInitOnly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6356, 6384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_6472_6488(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6472, 6488);
                    return return_v;
                }


                int
                f_10956_6452_6512(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                property, Microsoft.CodeAnalysis.IMethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keyword)
                {
                    this_param.AddAccessor(property, method, keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6452, 6512);
                    return 0;
                }


                int
                f_10956_6533_6543(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6533, 6543);
                    return 0;
                }


                int
                f_10956_6562_6604(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6562, 6604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 4727, 6631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 4727, 6631);
            }
        }

        private static bool IsInitOnly(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10956, 6643, 6765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6720, 6754);

                return f_10956_6727_6745_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 10956, 6727, 6745)?.IsInitOnly) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10956, 6643, 6765);

                bool?
                f_10956_6727_6745_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6727, 6745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 6643, 6765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 6643, 6765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddPropertyNameAndParameters(IPropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 6777, 8075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6867, 6941);

                bool
                getMemberNameWithoutInterfaceName = f_10956_6908_6936(f_10956_6908_6919(symbol), '.') > 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 6957, 7115) || true) && (getMemberNameWithoutInterfaceName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 6957, 7115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7028, 7100);

                    f_10956_7028_7099(this, f_10956_7059_7098(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 6957, 7115);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7131, 7659) || true) && (f_10956_7135_7151(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 7131, 7659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7185, 7220);

                    f_10956_7185_7219(this, SyntaxKind.ThisKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 7131, 7659);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 7131, 7659);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7254, 7659) || true) && (getMemberNameWithoutInterfaceName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 7254, 7659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7325, 7492);

                        f_10956_7325_7491(this.builder, f_10956_7342_7490(this, SymbolDisplayPartKind.PropertyName, symbol, f_10956_7418_7489(f_10956_7477_7488(symbol))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 7254, 7659);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 7254, 7659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7558, 7644);

                        f_10956_7558_7643(this.builder, f_10956_7575_7642(this, SymbolDisplayPartKind.PropertyName, symbol, f_10956_7630_7641(symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 7254, 7659);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 7131, 7659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7675, 8064) || true) && (f_10956_7679_7765(f_10956_7679_7704(this.format), SymbolDisplayMemberOptions.IncludeParameters) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 7679, 7792) && symbol.Parameters.Any()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 7675, 8064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7826, 7870);

                    f_10956_7826_7869(this, SyntaxKind.OpenBracketToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 7888, 7986);

                    f_10956_7888_7985(this, hasThisParameter: false, isVarargs: false, parameters: f_10956_7967_7984(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8004, 8049);

                    f_10956_8004_8048(this, SyntaxKind.CloseBracketToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 7675, 8064);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 6777, 8075);

                string
                f_10956_6908_6919(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 6908, 6919);
                    return return_v;
                }


                int
                f_10956_6908_6936(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 6908, 6936);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_10956_7059_7098(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7059, 7098);
                    return return_v;
                }


                int
                f_10956_7028_7099(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                implementedMembers)
                {
                    this_param.AddExplicitInterfaceIfRequired<Microsoft.CodeAnalysis.IPropertySymbol>(implementedMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7028, 7099);
                    return 0;
                }


                bool
                f_10956_7135_7151(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7135, 7151);
                    return return_v;
                }


                int
                f_10956_7185_7219(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7185, 7219);
                    return 0;
                }


                string
                f_10956_7477_7488(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7477, 7488);
                    return return_v;
                }


                string
                f_10956_7418_7489(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7418, 7489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_7342_7490(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IPropertySymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7342, 7490);
                    return return_v;
                }


                int
                f_10956_7325_7491(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7325, 7491);
                    return 0;
                }


                string
                f_10956_7630_7641(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7630, 7641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_7575_7642(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IPropertySymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7575, 7642);
                    return return_v;
                }


                int
                f_10956_7558_7643(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7558, 7643);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_7679_7704(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7679, 7704);
                    return return_v;
                }


                bool
                f_10956_7679_7765(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7679, 7765);
                    return return_v;
                }


                int
                f_10956_7826_7869(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7826, 7869);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_10956_7967_7984(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 7967, 7984);
                    return return_v;
                }


                int
                f_10956_7888_7985(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, bool
                hasThisParameter, bool
                isVarargs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                parameters)
                {
                    this_param.AddParametersIfRequired(hasThisParameter: hasThisParameter, isVarargs: isVarargs, parameters: parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 7888, 7985);
                    return 0;
                }


                int
                f_10956_8004_8048(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8004, 8048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 6777, 8075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 6777, 8075);
            }
        }

        public override void VisitEvent(IEventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 8087, 9266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8164, 8199);

                f_10956_8164_8198(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8213, 8250);

                f_10956_8213_8249(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8266, 8321);

                var
                accessor = f_10956_8281_8297(symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.IMethodSymbol?>(10956, 8281, 8320) ?? f_10956_8301_8320(symbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8335, 8471) || true) && (accessor is object && (DynAbs.Tracing.TraceSender.Expression_True(10956, 8339, 8398) && f_10956_8361_8398(accessor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 8335, 8471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8432, 8456);

                    f_10956_8432_8455(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 8335, 8471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8487, 8685) || true) && (f_10956_8491_8571(f_10956_8491_8509(format), SymbolDisplayKindOptions.IncludeMemberKeyword))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 8487, 8685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8605, 8641);

                    f_10956_8605_8640(this, SyntaxKind.EventKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8659, 8670);

                    f_10956_8659_8669(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 8487, 8685);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8701, 8899) || true) && (f_10956_8705_8780(f_10956_8705_8725(format), SymbolDisplayMemberOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 8701, 8899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8814, 8855);

                    f_10956_8814_8854(f_10956_8814_8825(symbol), f_10956_8833_8853(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8873, 8884);

                    f_10956_8873_8883(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 8701, 8899);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 8915, 9218) || true) && (f_10956_8919_9004(f_10956_8919_8939(format), SymbolDisplayMemberOptions.IncludeContainingType) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 8919, 9064) && f_10956_9025_9064(this, f_10956_9042_9063(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 8915, 9218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9098, 9149);

                    f_10956_9098_9148(f_10956_9098_9119(symbol), f_10956_9127_9147(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9167, 9203);

                    f_10956_9167_9202(this, SyntaxKind.DotToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 8915, 9218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9234, 9255);

                f_10956_9234_9254(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 8087, 9266);

                int
                f_10956_8164_8198(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IEventSymbol
                symbol)
                {
                    this_param.AddAccessibilityIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8164, 8198);
                    return 0;
                }


                int
                f_10956_8213_8249(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IEventSymbol
                symbol)
                {
                    this_param.AddMemberModifiersIfRequired((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8213, 8249);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_8281_8297(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8281, 8297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10956_8301_8320(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8301, 8320);
                    return return_v;
                }


                bool
                f_10956_8361_8398(Microsoft.CodeAnalysis.IMethodSymbol
                method)
                {
                    var return_v = ShouldMethodDisplayReadOnly(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8361, 8398);
                    return return_v;
                }


                int
                f_10956_8432_8455(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddReadOnlyIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8432, 8455);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_10956_8491_8509(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8491, 8509);
                    return return_v;
                }


                bool
                f_10956_8491_8571(Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8491, 8571);
                    return return_v;
                }


                int
                f_10956_8605_8640(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8605, 8640);
                    return 0;
                }


                int
                f_10956_8659_8669(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8659, 8669);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_8705_8725(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8705, 8725);
                    return return_v;
                }


                bool
                f_10956_8705_8780(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8705, 8780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_8814_8825(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8814, 8825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_8833_8853(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8833, 8853);
                    return return_v;
                }


                int
                f_10956_8814_8854(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8814, 8854);
                    return 0;
                }


                int
                f_10956_8873_8883(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8873, 8883);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_8919_8939(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 8919, 8939);
                    return return_v;
                }


                bool
                f_10956_8919_9004(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 8919, 9004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_9042_9063(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9042, 9063);
                    return return_v;
                }


                bool
                f_10956_9025_9064(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType)
                {
                    var return_v = this_param.IncludeNamedType(namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9025, 9064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_9098_9119(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9098, 9119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_9127_9147(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9127, 9147);
                    return return_v;
                }


                int
                f_10956_9098_9148(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9098, 9148);
                    return 0;
                }


                int
                f_10956_9167_9202(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9167, 9202);
                    return 0;
                }


                int
                f_10956_9234_9254(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IEventSymbol
                symbol)
                {
                    this_param.AddEventName(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9234, 9254);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 8087, 9266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 8087, 9266);
            }
        }

        private void AddEventName(IEventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 9278, 9850);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9349, 9839) || true) && (f_10956_9353_9381(f_10956_9353_9364(symbol), '.') > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 9349, 9839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9419, 9491);

                    f_10956_9419_9490(this, f_10956_9450_9489(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9511, 9675);

                    f_10956_9511_9674(
                                    this.builder, f_10956_9528_9673(this, SymbolDisplayPartKind.EventName, symbol, f_10956_9601_9672(f_10956_9660_9671(symbol))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 9349, 9839);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 9349, 9839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 9741, 9824);

                    f_10956_9741_9823(this.builder, f_10956_9758_9822(this, SymbolDisplayPartKind.EventName, symbol, f_10956_9810_9821(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 9349, 9839);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 9278, 9850);

                string
                f_10956_9353_9364(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9353, 9364);
                    return return_v;
                }


                int
                f_10956_9353_9381(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9353, 9381);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IEventSymbol>
                f_10956_9450_9489(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9450, 9489);
                    return return_v;
                }


                int
                f_10956_9419_9490(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IEventSymbol>
                implementedMembers)
                {
                    this_param.AddExplicitInterfaceIfRequired<Microsoft.CodeAnalysis.IEventSymbol>(implementedMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9419, 9490);
                    return 0;
                }


                string
                f_10956_9660_9671(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9660, 9671);
                    return return_v;
                }


                string
                f_10956_9601_9672(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9601, 9672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_9528_9673(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IEventSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9528, 9673);
                    return return_v;
                }


                int
                f_10956_9511_9674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9511, 9674);
                    return 0;
                }


                string
                f_10956_9810_9821(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 9810, 9821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_9758_9822(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IEventSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9758, 9822);
                    return return_v;
                }


                int
                f_10956_9741_9823(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 9741, 9823);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 9278, 9850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 9278, 9850);
            }
        }

        public override void VisitMethod(IMethodSymbol symbol)
        {
            if (symbol.MethodKind == MethodKind.AnonymousFunction)
            {
                // TODO(cyrusn): Why is this a literal?  Why don't we give the appropriate signature
                // of the method as asked?
                builder.Add(CreatePart(SymbolDisplayPartKind.NumericLiteral, symbol, "lambda expression"));
                return;
            }
            // LAFHIS
            else if ((symbol is Symbols.PublicModel.MethodSymbol) && ((Symbols.PublicModel.MethodSymbol)symbol).UnderlyingMethodSymbol is SynthesizedGlobalMethodSymbol) // It would be nice to handle VB symbols too, but it's not worth the effort.
            {
                // Represents a compiler generated synthesized method symbol with a null containing
                // type.

                // TODO(cyrusn); Why is this a literal?
                builder.Add(CreatePart(SymbolDisplayPartKind.NumericLiteral, symbol, symbol.Name));
                return;
            }
            else if (symbol.MethodKind == MethodKind.FunctionPointerSignature)
            {
                visitFunctionPointerSignature(symbol);
                return;
            }

            if (symbol.IsExtensionMethod && format.ExtensionMethodStyle != SymbolDisplayExtensionMethodStyle.Default)
            {
                if (symbol.MethodKind == MethodKind.ReducedExtension && format.ExtensionMethodStyle == SymbolDisplayExtensionMethodStyle.StaticMethod)
                {
                    symbol = symbol.GetConstructedReducedFrom();
                }
                else if (symbol.MethodKind != MethodKind.ReducedExtension && format.ExtensionMethodStyle == SymbolDisplayExtensionMethodStyle.InstanceMethod)
                {
                    // If we cannot reduce this to an instance form then display in the static form
                    symbol = symbol.ReduceExtensionMethod(symbol.Parameters.First().Type) ?? symbol;
                }
            }

            // Method members always have a type unless (1) this is a lambda method symbol, which we
            // have dealt with already, or (2) this is an error method symbol. If we have an error method
            // symbol then we do not know its accessibility, modifiers, etc, all of which require knowing
            // the containing type, so we'll skip them.

            if ((object)symbol.ContainingType != null || (symbol.ContainingSymbol is ITypeSymbol))
            {
                AddAccessibilityIfRequired(symbol);
                AddMemberModifiersIfRequired(symbol);

                if (ShouldMethodDisplayReadOnly(symbol))
                {
                    AddReadOnlyIfRequired();
                }

                if (format.MemberOptions.IncludesOption(SymbolDisplayMemberOptions.IncludeType))
                {
                    switch (symbol.MethodKind)
                    {
                        case MethodKind.Constructor:
                        case MethodKind.StaticConstructor:
                            break;
                        case MethodKind.Destructor:
                        case MethodKind.Conversion:
                            // If we're using the metadata format, then include the return type.
                            // Otherwise we eschew it since it is redundant in a conversion
                            // signature.
                            if (format.CompilerInternalOptions.IncludesOption(SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames))
                            {
                                goto default;
                            }

                            break;
                        default:
                            // The display code is called by the debugger; if a developer is debugging Roslyn and attempts
                            // to visualize a symbol *during its construction*, the parameters and return type might
                            // still be null.

                            if (symbol.ReturnsByRef)
                            {
                                AddRefIfRequired();
                            }
                            else if (symbol.ReturnsByRefReadonly)
                            {
                                AddRefReadonlyIfRequired();
                            }

                            AddCustomModifiersIfRequired(symbol.RefCustomModifiers);

                            if (symbol.ReturnsVoid)
                            {
                                AddKeyword(SyntaxKind.VoidKeyword);
                            }
                            else if (symbol.ReturnType != null)
                            {
                                AddReturnType(symbol);
                            }

                            AddSpace();
                            AddCustomModifiersIfRequired(symbol.ReturnTypeCustomModifiers);
                            break;
                    }
                }

                if (format.MemberOptions.IncludesOption(SymbolDisplayMemberOptions.IncludeContainingType))
                {
                    ITypeSymbol containingType;
                    bool includeType;

                    if (symbol.MethodKind == MethodKind.LocalFunction)
                    {
                        includeType = false;
                        containingType = null;
                    }
                    else if (symbol.MethodKind == MethodKind.ReducedExtension)
                    {
                        containingType = symbol.ReceiverType;
                        includeType = true;
                        Debug.Assert(containingType != null);
                    }
                    else
                    {
                        containingType = symbol.ContainingType;

                        if ((object)containingType != null)
                        {
                            includeType = IncludeNamedType(symbol.ContainingType);
                        }
                        else
                        {
                            containingType = (ITypeSymbol)symbol.ContainingSymbol;
                            includeType = true;
                        }
                    }

                    if (includeType)
                    {
                        containingType.Accept(this.NotFirstVisitor);
                        AddPunctuation(SyntaxKind.DotToken);
                    }
                }
            }

            bool isAccessor = false;
            switch (symbol.MethodKind)
            {
                case MethodKind.Ordinary:
                case MethodKind.DelegateInvoke:
                case MethodKind.LocalFunction:
                    {
                        //containing type will be the delegate type, name will be Invoke
                        builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol, symbol.Name));
                        break;
                    }
                case MethodKind.ReducedExtension:
                    {
                        // Note: Extension methods invoked off of their static class will be tagged as methods.
                        //       This behavior matches the semantic classification done in NameSyntaxClassifier.
                        builder.Add(CreatePart(SymbolDisplayPartKind.ExtensionMethodName, symbol, symbol.Name));
                        break;
                    }
                case MethodKind.PropertyGet:
                case MethodKind.PropertySet:
                    {
                        isAccessor = true;
                        var associatedProperty = (IPropertySymbol)symbol.AssociatedSymbol;
                        if (associatedProperty == null)
                        {
                            goto case MethodKind.Ordinary;
                        }
                        AddPropertyNameAndParameters(associatedProperty);
                        AddPunctuation(SyntaxKind.DotToken);
                        AddKeyword(symbol.MethodKind == MethodKind.PropertyGet ? SyntaxKind.GetKeyword :
                            IsInitOnly(symbol) ? SyntaxKind.InitKeyword : SyntaxKind.SetKeyword);
                        break;
                    }
                case MethodKind.EventAdd:
                case MethodKind.EventRemove:
                    {
                        isAccessor = true;
                        var associatedEvent = (IEventSymbol)symbol.AssociatedSymbol;
                        if (associatedEvent == null)
                        {
                            goto case MethodKind.Ordinary;
                        }
                        AddEventName(associatedEvent);
                        AddPunctuation(SyntaxKind.DotToken);
                        AddKeyword(symbol.MethodKind == MethodKind.EventAdd ? SyntaxKind.AddKeyword : SyntaxKind.RemoveKeyword);
                        break;
                    }
                case MethodKind.Constructor:
                case MethodKind.StaticConstructor:
                    {
                        // Note: we are using the metadata name also in the case that
                        // symbol.containingType is null (which should never be the case here) or is an
                        //       anonymous type (which 'does not have a name').
                        var name = format.CompilerInternalOptions.IncludesOption(SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames) || symbol.ContainingType == null || symbol.ContainingType.IsAnonymousType
                            ? symbol.Name
                            : symbol.ContainingType.Name;

                        var partKind = GetPartKindForConstructorOrDestructor(symbol);

                        builder.Add(CreatePart(partKind, symbol, name));
                        break;
                    }
                case MethodKind.Destructor:
                    {
                        var partKind = GetPartKindForConstructorOrDestructor(symbol);

                        // Note: we are using the metadata name also in the case that symbol.containingType is null, which should never be the case here.
                        if (format.CompilerInternalOptions.IncludesOption(SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames) || symbol.ContainingType == null)
                        {
                            builder.Add(CreatePart(partKind, symbol, symbol.Name));
                        }
                        else
                        {
                            AddPunctuation(SyntaxKind.TildeToken);
                            builder.Add(CreatePart(partKind, symbol, symbol.ContainingType.Name));
                        }
                        break;
                    }
                case MethodKind.ExplicitInterfaceImplementation:
                    {
                        AddExplicitInterfaceIfRequired(symbol.ExplicitInterfaceImplementations);
                        builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol,
                            ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(symbol.Name)));
                        break;
                    }
                case MethodKind.UserDefinedOperator:
                case MethodKind.BuiltinOperator:
                    {
                        if (format.CompilerInternalOptions.IncludesOption(SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames))
                        {
                            builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol, symbol.MetadataName));
                        }
                        else
                        {
                            AddKeyword(SyntaxKind.OperatorKeyword);
                            AddSpace();
                            if (symbol.MetadataName == WellKnownMemberNames.TrueOperatorName)
                            {
                                AddKeyword(SyntaxKind.TrueKeyword);
                            }
                            else if (symbol.MetadataName == WellKnownMemberNames.FalseOperatorName)
                            {
                                AddKeyword(SyntaxKind.FalseKeyword);
                            }
                            else
                            {
                                builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol,
                                    SyntaxFacts.GetText(SyntaxFacts.GetOperatorKind(symbol.MetadataName))));
                            }
                        }
                        break;
                    }
                case MethodKind.Conversion:
                    {
                        if (format.CompilerInternalOptions.IncludesOption(SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames))
                        {
                            builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol, symbol.MetadataName));
                        }
                        else
                        {
                            // "System.IntPtr.explicit operator System.IntPtr(int)"

                            if (symbol.MetadataName == WellKnownMemberNames.ExplicitConversionName)
                            {
                                AddKeyword(SyntaxKind.ExplicitKeyword);
                            }
                            else if (symbol.MetadataName == WellKnownMemberNames.ImplicitConversionName)
                            {
                                AddKeyword(SyntaxKind.ImplicitKeyword);
                            }
                            else
                            {
                                builder.Add(CreatePart(SymbolDisplayPartKind.MethodName, symbol,
                                    SyntaxFacts.GetText(SyntaxFacts.GetOperatorKind(symbol.MetadataName))));
                            }

                            AddSpace();
                            AddKeyword(SyntaxKind.OperatorKeyword);
                            AddSpace();
                            AddReturnType(symbol);
                        }
                        break;
                    }
                default:
                    throw ExceptionUtilities.UnexpectedValue(symbol.MethodKind);
            }

            if (!isAccessor)
            {
                AddTypeArguments(symbol, default(ImmutableArray<ImmutableArray<CustomModifier>>));
                AddParameters(symbol);
                AddTypeParameterConstraints(symbol);
            }

            void visitFunctionPointerSignature(IMethodSymbol symbol)
            {
                AddKeyword(SyntaxKind.DelegateKeyword);
                AddPunctuation(SyntaxKind.AsteriskToken);

                if (symbol.CallingConvention != SignatureCallingConvention.Default)
                {
                    AddSpace();
                    AddKeyword(SyntaxKind.UnmanagedKeyword);

                    var conventionTypes = symbol.UnmanagedCallingConventionTypes;

                    if (symbol.CallingConvention != SignatureCallingConvention.Unmanaged || !conventionTypes.IsEmpty)
                    {
                        AddPunctuation(SyntaxKind.OpenBracketToken);

                        switch (symbol.CallingConvention)
                        {
                            case SignatureCallingConvention.CDecl:
                                builder.Add(CreatePart(SymbolDisplayPartKind.ClassName, symbol, "Cdecl"));
                                break;
                            case SignatureCallingConvention.StdCall:
                                builder.Add(CreatePart(SymbolDisplayPartKind.ClassName, symbol, "Stdcall"));
                                break;
                            case SignatureCallingConvention.ThisCall:
                                builder.Add(CreatePart(SymbolDisplayPartKind.ClassName, symbol, "Thiscall"));
                                break;
                            case SignatureCallingConvention.FastCall:
                                builder.Add(CreatePart(SymbolDisplayPartKind.ClassName, symbol, "Fastcall"));
                                break;

                            case SignatureCallingConvention.Unmanaged:
                                Debug.Assert(!conventionTypes.IsDefaultOrEmpty);
                                bool isFirst = true;
                                foreach (var conventionType in conventionTypes)
                                {
                                    if (!isFirst)
                                    {
                                        AddPunctuation(SyntaxKind.CommaToken);
                                        AddSpace();
                                    }

                                    isFirst = false;
                                    Debug.Assert(conventionType.Name.StartsWith("CallConv"));
                                    const int CallConvLength = 8;
                                    builder.Add(CreatePart(SymbolDisplayPartKind.ClassName, conventionType, conventionType.Name[CallConvLength..]));
                                }

                                break;
                        }

                        AddPunctuation(SyntaxKind.CloseBracketToken);
                    }
                }

                AddPunctuation(SyntaxKind.LessThanToken);

                foreach (var param in symbol.Parameters)
                {
                    param.Accept(this.NotFirstVisitor);
                    AddPunctuation(SyntaxKind.CommaToken);
                    AddSpace();
                }

                if (symbol.ReturnsByRef)
                {
                    AddRefIfRequired();
                }
                else if (symbol.ReturnsByRefReadonly)
                {
                    AddRefReadonlyIfRequired();
                }

                AddCustomModifiersIfRequired(symbol.RefCustomModifiers);

                symbol.ReturnType.Accept(this.NotFirstVisitor);

                AddCustomModifiersIfRequired(symbol.ReturnTypeCustomModifiers, leadingSpace: true, trailingSpace: false);

                AddPunctuation(SyntaxKind.GreaterThanToken);
            }
        }

        private static SymbolDisplayPartKind GetPartKindForConstructorOrDestructor(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10956, 28528, 28988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 28797, 28919) || true) && (f_10956_28801_28822(symbol) is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 28797, 28919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 28864, 28904);

                    return SymbolDisplayPartKind.MethodName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 28797, 28919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 28935, 28977);

                return f_10956_28942_28976(f_10956_28954_28975(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10956, 28528, 28988);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10956_28801_28822(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 28801, 28822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_28954_28975(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 28954, 28975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPartKind
                f_10956_28942_28976(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = GetPartKind(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 28942, 28976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 28528, 28988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 28528, 28988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddReturnType(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 29000, 29131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29073, 29120);

                f_10956_29073_29119(f_10956_29073_29090(symbol), f_10956_29098_29118(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 29000, 29131);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_29073_29090(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29073, 29090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_29098_29118(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29098, 29118);
                    return return_v;
                }


                int
                f_10956_29073_29119(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29073, 29119);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 29000, 29131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 29000, 29131);
            }
        }

        private void AddTypeParameterConstraints(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 29143, 29434);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29230, 29423) || true) && (f_10956_29234_29324(f_10956_29234_29256(format), SymbolDisplayGenericsOptions.IncludeTypeConstraints))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 29230, 29423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29358, 29408);

                    f_10956_29358_29407(this, f_10956_29386_29406(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 29230, 29423);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 29143, 29434);

                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_10956_29234_29256(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29234, 29256);
                    return return_v;
                }


                bool
                f_10956_29234_29324(Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29234, 29324);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10956_29386_29406(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29386, 29406);
                    return return_v;
                }


                int
                f_10956_29358_29407(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                typeArguments)
                {
                    this_param.AddTypeParameterConstraints(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29358, 29407);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 29143, 29434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 29143, 29434);
            }
        }

        private void AddParameters(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 29446, 30028);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29519, 30017) || true) && (f_10956_29523_29604(f_10956_29523_29543(format), SymbolDisplayMemberOptions.IncludeParameters))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 29519, 30017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29638, 29680);

                    f_10956_29638_29679(this, SyntaxKind.OpenParenToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29698, 29941);

                    f_10956_29698_29940(this, hasThisParameter: f_10956_29762_29786(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 29762, 29838) && f_10956_29790_29807(symbol) != MethodKind.ReducedExtension), isVarargs: f_10956_29872_29887(symbol), parameters: f_10956_29922_29939(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 29959, 30002);

                    f_10956_29959_30001(this, SyntaxKind.CloseParenToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 29519, 30017);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 29446, 30028);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_29523_29543(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29523, 29543);
                    return return_v;
                }


                bool
                f_10956_29523_29604(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29523, 29604);
                    return return_v;
                }


                int
                f_10956_29638_29679(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29638, 29679);
                    return 0;
                }


                bool
                f_10956_29762_29786(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29762, 29786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10956_29790_29807(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29790, 29807);
                    return return_v;
                }


                bool
                f_10956_29872_29887(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29872, 29887);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_10956_29922_29939(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 29922, 29939);
                    return return_v;
                }


                int
                f_10956_29698_29940(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, bool
                hasThisParameter, bool
                isVarargs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                parameters)
                {
                    this_param.AddParametersIfRequired(hasThisParameter: hasThisParameter, isVarargs: isVarargs, parameters: parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29698, 29940);
                    return 0;
                }


                int
                f_10956_29959_30001(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 29959, 30001);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 29446, 30028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 29446, 30028);
            }
        }

        public override void VisitParameter(IParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 30040, 32904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 30593, 30693);

                var
                includeType = f_10956_30611_30692(f_10956_30611_30634(format), SymbolDisplayParameterOptions.IncludeType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 30707, 30937);

                var
                includeName = f_10956_30725_30806(f_10956_30725_30748(format), SymbolDisplayParameterOptions.IncludeName) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 30725, 30936) && !(f_10956_30843_30866(symbol) is IMethodSymbol { MethodKind: MethodKind.FunctionPointerSignature }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 30951, 31067);

                var
                includeBrackets = f_10956_30973_31066(f_10956_30973_30996(format), SymbolDisplayParameterOptions.IncludeOptionalBrackets)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31083, 31216) || true) && (includeBrackets && (DynAbs.Tracing.TraceSender.Expression_True(10956, 31087, 31123) && f_10956_31106_31123(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 31083, 31216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31157, 31201);

                    f_10956_31157_31200(this, SyntaxKind.OpenBracketToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 31083, 31216);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31232, 31895) || true) && (includeType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 31232, 31895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31281, 31327);

                    f_10956_31281_31326(this, f_10956_31311_31325(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31345, 31443);

                    f_10956_31345_31442(this, f_10956_31374_31399(symbol), leadingSpace: false, trailingSpace: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31463, 31706) || true) && (f_10956_31467_31482(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 31467, 31575) && f_10956_31486_31575(f_10956_31486_31509(format), SymbolDisplayParameterOptions.IncludeParamsRefOut)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 31463, 31706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31617, 31654);

                        f_10956_31617_31653(this, SyntaxKind.ParamsKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31676, 31687);

                        f_10956_31676_31686(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 31463, 31706);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31726, 31767);

                    f_10956_31726_31766(f_10956_31726_31737(symbol), f_10956_31745_31765(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31785, 31880);

                    f_10956_31785_31879(this, f_10956_31814_31836(symbol), leadingSpace: true, trailingSpace: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 31232, 31895);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31911, 32001) || true) && (includeName && (DynAbs.Tracing.TraceSender.Expression_True(10956, 31915, 31941) && includeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 31911, 32001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 31975, 31986);

                    f_10956_31975_31985(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 31911, 32001);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32017, 32743) || true) && (includeName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 32017, 32743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32066, 32161);

                    var
                    kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10956, 32077, 32090) || ((f_10956_32077_32090(symbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10956, 32093, 32122)) || DynAbs.Tracing.TraceSender.Conditional_F3(10956, 32125, 32160))) ? SymbolDisplayPartKind.Keyword : SymbolDisplayPartKind.ParameterName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32179, 32230);

                    f_10956_32179_32229(builder, f_10956_32191_32228(this, kind, symbol, f_10956_32216_32227(symbol)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32250, 32728) || true) && (f_10956_32254_32343(f_10956_32254_32277(format), SymbolDisplayParameterOptions.IncludeDefaultValue) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 32254, 32398) && f_10956_32368_32398(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 32254, 32479) && f_10956_32423_32479(f_10956_32438_32449(symbol), f_10956_32451_32478(symbol))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 32250, 32728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32521, 32532);

                        f_10956_32521_32531(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32554, 32593);

                        f_10956_32554_32592(this, SyntaxKind.EqualsToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32615, 32626);

                        f_10956_32615_32625(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32650, 32709);

                        f_10956_32650_32708(this, f_10956_32667_32678(symbol), f_10956_32680_32707(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 32250, 32728);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 32017, 32743);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32759, 32893) || true) && (includeBrackets && (DynAbs.Tracing.TraceSender.Expression_True(10956, 32763, 32799) && f_10956_32782_32799(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 32759, 32893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 32833, 32878);

                    f_10956_32833_32877(this, SyntaxKind.CloseBracketToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 32759, 32893);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 30040, 32904);

                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_30611_30634(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 30611, 30634);
                    return return_v;
                }


                bool
                f_10956_30611_30692(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 30611, 30692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_30725_30748(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 30725, 30748);
                    return return_v;
                }


                bool
                f_10956_30725_30806(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 30725, 30806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10956_30843_30866(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 30843, 30866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_30973_30996(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 30973, 30996);
                    return return_v;
                }


                bool
                f_10956_30973_31066(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 30973, 31066);
                    return return_v;
                }


                bool
                f_10956_31106_31123(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31106, 31123);
                    return return_v;
                }


                int
                f_10956_31157_31200(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31157, 31200);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10956_31311_31325(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31311, 31325);
                    return return_v;
                }


                int
                f_10956_31281_31326(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    this_param.AddParameterRefKindIfRequired(refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31281, 31326);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_31374_31399(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31374, 31399);
                    return return_v;
                }


                int
                f_10956_31345_31442(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace, bool
                trailingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace, trailingSpace: trailingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31345, 31442);
                    return 0;
                }


                bool
                f_10956_31467_31482(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31467, 31482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_31486_31509(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31486, 31509);
                    return return_v;
                }


                bool
                f_10956_31486_31575(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31486, 31575);
                    return return_v;
                }


                int
                f_10956_31617_31653(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31617, 31653);
                    return 0;
                }


                int
                f_10956_31676_31686(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31676, 31686);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_31726_31737(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31726, 31737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_31745_31765(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31745, 31765);
                    return return_v;
                }


                int
                f_10956_31726_31766(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31726, 31766);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_31814_31836(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 31814, 31836);
                    return return_v;
                }


                int
                f_10956_31785_31879(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace, bool
                trailingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace, trailingSpace: trailingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31785, 31879);
                    return 0;
                }


                int
                f_10956_31975_31985(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 31975, 31985);
                    return 0;
                }


                bool
                f_10956_32077_32090(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32077, 32090);
                    return return_v;
                }


                string
                f_10956_32216_32227(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32216, 32227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_32191_32228(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IParameterSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32191, 32228);
                    return return_v;
                }


                int
                f_10956_32179_32229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32179, 32229);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_32254_32277(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32254, 32277);
                    return return_v;
                }


                bool
                f_10956_32254_32343(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32254, 32343);
                    return return_v;
                }


                bool
                f_10956_32368_32398(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasExplicitDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32368, 32398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_32438_32449(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32438, 32449);
                    return return_v;
                }


                object?
                f_10956_32451_32478(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32451, 32478);
                    return return_v;
                }


                bool
                f_10956_32423_32479(Microsoft.CodeAnalysis.ITypeSymbol
                type, object?
                value)
                {
                    var return_v = CanAddConstant(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32423, 32479);
                    return return_v;
                }


                int
                f_10956_32521_32531(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32521, 32531);
                    return 0;
                }


                int
                f_10956_32554_32592(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32554, 32592);
                    return 0;
                }


                int
                f_10956_32615_32625(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32615, 32625);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10956_32667_32678(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32667, 32678);
                    return return_v;
                }


                object?
                f_10956_32680_32707(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32680, 32707);
                    return return_v;
                }


                int
                f_10956_32650_32708(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type, object?
                constantValue)
                {
                    this_param.AddConstantValue(type, constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32650, 32708);
                    return 0;
                }


                bool
                f_10956_32782_32799(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 32782, 32799);
                    return return_v;
                }


                int
                f_10956_32833_32877(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 32833, 32877);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 30040, 32904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 30040, 32904);
            }
        }

        private static bool CanAddConstant(ITypeSymbol type, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10956, 32916, 33311);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33007, 33102) || true) && (f_10956_33011_33024(type) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33007, 33102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33075, 33087);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33007, 33102);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33118, 33196) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33118, 33196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33169, 33181);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33118, 33196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33212, 33300);

                return f_10956_33219_33260(f_10956_33219_33248(f_10956_33219_33234(value))) || (DynAbs.Tracing.TraceSender.Expression_False(10956, 33219, 33279) || value is string) || (DynAbs.Tracing.TraceSender.Expression_False(10956, 33219, 33299) || value is decimal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10956, 32916, 33311);

                Microsoft.CodeAnalysis.TypeKind
                f_10956_33011_33024(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33011, 33024);
                    return return_v;
                }


                System.Type
                f_10956_33219_33234(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33219, 33234);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10956_33219_33248(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33219, 33248);
                    return return_v;
                }


                bool
                f_10956_33219_33260(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33219, 33260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 32916, 33311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 32916, 33311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddFieldModifiersIfRequired(IFieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 33323, 34124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33409, 34113) || true) && (f_10956_33413_33493(f_10956_33413_33433(format), SymbolDisplayMemberOptions.IncludeModifiers) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 33413, 33535) && !f_10956_33515_33535(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33409, 34113);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33569, 33717) || true) && (f_10956_33573_33587(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33569, 33717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33629, 33665);

                        f_10956_33629_33664(this, SyntaxKind.ConstKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33687, 33698);

                        f_10956_33687_33697(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33569, 33717);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33737, 33891) || true) && (f_10956_33741_33758(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33737, 33891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33800, 33839);

                        f_10956_33800_33838(this, SyntaxKind.ReadOnlyKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33861, 33872);

                        f_10956_33861_33871(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33737, 33891);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33911, 34065) || true) && (f_10956_33915_33932(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 33911, 34065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 33974, 34013);

                        f_10956_33974_34012(this, SyntaxKind.VolatileKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34035, 34046);

                        f_10956_34035_34045(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33911, 34065);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 33409, 34113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 33323, 34124);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_33413_33433(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33413, 33433);
                    return return_v;
                }


                bool
                f_10956_33413_33493(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33413, 33493);
                    return return_v;
                }


                bool
                f_10956_33515_33535(Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    var return_v = IsEnumMember((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33515, 33535);
                    return return_v;
                }


                bool
                f_10956_33573_33587(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33573, 33587);
                    return return_v;
                }


                int
                f_10956_33629_33664(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33629, 33664);
                    return 0;
                }


                int
                f_10956_33687_33697(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33687, 33697);
                    return 0;
                }


                bool
                f_10956_33741_33758(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33741, 33758);
                    return return_v;
                }


                int
                f_10956_33800_33838(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33800, 33838);
                    return 0;
                }


                int
                f_10956_33861_33871(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33861, 33871);
                    return 0;
                }


                bool
                f_10956_33915_33932(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 33915, 33932);
                    return return_v;
                }


                int
                f_10956_33974_34012(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 33974, 34012);
                    return 0;
                }


                int
                f_10956_34035_34045(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34035, 34045);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 33323, 34124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 33323, 34124);
            }
        }

        private void AddMemberModifiersIfRequired(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 34136, 35931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34218, 34274);

                INamedTypeSymbol
                containingType = f_10956_34252_34273(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34412, 34493);

                f_10956_34412_34492(containingType != null || (DynAbs.Tracing.TraceSender.Expression_False(10956, 34425, 34491) || (f_10956_34452_34475(symbol) is ITypeSymbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34509, 35920) || true) && (f_10956_34513_34593(f_10956_34513_34533(format), SymbolDisplayMemberOptions.IncludeModifiers) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 34513, 34760) && (containingType == null || (DynAbs.Tracing.TraceSender.Expression_False(10956, 34615, 34759) || (f_10956_34660_34683(containingType) != TypeKind.Interface && (DynAbs.Tracing.TraceSender.Expression_True(10956, 34660, 34730) && !f_10956_34710_34730(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 34660, 34758) && !f_10956_34735_34758(symbol)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 34509, 35920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34794, 34865);

                    var
                    isConst = symbol is IFieldSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10956, 34808, 34864) && f_10956_34834_34864(((IFieldSymbol)symbol)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34883, 35045) || true) && (f_10956_34887_34902(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 34887, 34914) && !isConst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 34883, 35045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 34956, 34993);

                        f_10956_34956_34992(this, SyntaxKind.StaticKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35015, 35026);

                        f_10956_35015_35025(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 34883, 35045);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35065, 35219) || true) && (f_10956_35069_35086(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 35065, 35219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35128, 35167);

                        f_10956_35128_35166(this, SyntaxKind.OverrideKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35189, 35200);

                        f_10956_35189_35199(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 35065, 35219);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35239, 35393) || true) && (f_10956_35243_35260(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 35239, 35393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35302, 35341);

                        f_10956_35302_35340(this, SyntaxKind.AbstractKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35363, 35374);

                        f_10956_35363_35373(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 35239, 35393);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35413, 35563) || true) && (f_10956_35417_35432(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 35413, 35563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35474, 35511);

                        f_10956_35474_35510(this, SyntaxKind.SealedKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35533, 35544);

                        f_10956_35533_35543(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 35413, 35563);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35583, 35733) || true) && (f_10956_35587_35602(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 35583, 35733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35644, 35681);

                        f_10956_35644_35680(this, SyntaxKind.ExternKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35703, 35714);

                        f_10956_35703_35713(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 35583, 35733);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35753, 35905) || true) && (f_10956_35757_35773(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 35753, 35905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35815, 35853);

                        f_10956_35815_35852(this, SyntaxKind.VirtualKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 35875, 35886);

                        f_10956_35875_35885(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 35753, 35905);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 34509, 35920);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 34136, 35931);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_34252_34273(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34252, 34273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10956_34452_34475(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34452, 34475);
                    return return_v;
                }


                int
                f_10956_34412_34492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34412, 34492);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_34513_34533(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34513, 34533);
                    return return_v;
                }


                bool
                f_10956_34513_34593(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34513, 34593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10956_34660_34683(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34660, 34683);
                    return return_v;
                }


                bool
                f_10956_34710_34730(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = IsEnumMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34710, 34730);
                    return return_v;
                }


                bool
                f_10956_34735_34758(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = IsLocalFunction(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34735, 34758);
                    return return_v;
                }


                bool
                f_10956_34834_34864(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34834, 34864);
                    return return_v;
                }


                bool
                f_10956_34887_34902(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 34887, 34902);
                    return return_v;
                }


                int
                f_10956_34956_34992(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 34956, 34992);
                    return 0;
                }


                int
                f_10956_35015_35025(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35015, 35025);
                    return 0;
                }


                bool
                f_10956_35069_35086(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 35069, 35086);
                    return return_v;
                }


                int
                f_10956_35128_35166(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35128, 35166);
                    return 0;
                }


                int
                f_10956_35189_35199(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35189, 35199);
                    return 0;
                }


                bool
                f_10956_35243_35260(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 35243, 35260);
                    return return_v;
                }


                int
                f_10956_35302_35340(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35302, 35340);
                    return 0;
                }


                int
                f_10956_35363_35373(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35363, 35373);
                    return 0;
                }


                bool
                f_10956_35417_35432(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 35417, 35432);
                    return return_v;
                }


                int
                f_10956_35474_35510(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35474, 35510);
                    return 0;
                }


                int
                f_10956_35533_35543(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35533, 35543);
                    return 0;
                }


                bool
                f_10956_35587_35602(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 35587, 35602);
                    return return_v;
                }


                int
                f_10956_35644_35680(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35644, 35680);
                    return 0;
                }


                int
                f_10956_35703_35713(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35703, 35713);
                    return 0;
                }


                bool
                f_10956_35757_35773(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 35757, 35773);
                    return return_v;
                }


                int
                f_10956_35815_35852(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35815, 35852);
                    return 0;
                }


                int
                f_10956_35875_35885(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 35875, 35885);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 34136, 35931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 34136, 35931);
            }
        }

        private void AddParametersIfRequired(bool hasThisParameter, bool isVarargs, ImmutableArray<IParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 35943, 37585);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36088, 36209) || true) && (f_10956_36092_36115(format) == SymbolDisplayParameterOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36088, 36209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36187, 36194);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36088, 36209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36225, 36242);

                var
                first = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36501, 37296) || true) && (f_10956_36505_36526_M(!parameters.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36501, 37296);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36560, 37281);
                        foreach (var param in f_10956_36582_36592_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36560, 37281);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36634, 37167) || true) && (!first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36634, 37167);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36694, 36732);

                                f_10956_36694_36731(this, SyntaxKind.CommaToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36758, 36769);

                                f_10956_36758_36768(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36634, 37167);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36634, 37167);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36819, 37167) || true) && (hasThisParameter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36819, 37167);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 36889, 37144) || true) && (f_10956_36893_36983(f_10956_36893_36916(format), SymbolDisplayParameterOptions.IncludeExtensionThis))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 36889, 37144);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37041, 37076);

                                        f_10956_37041_37075(this, SyntaxKind.ThisKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37106, 37117);

                                        f_10956_37106_37116(this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36889, 37144);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36819, 37167);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36634, 37167);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37191, 37205);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37227, 37262);

                            f_10956_37227_37261(param, f_10956_37240_37260(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36560, 37281);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10956, 1, 722);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10956, 1, 722);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 36501, 37296);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37312, 37574) || true) && (isVarargs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 37312, 37574);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37359, 37501) || true) && (!first)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 37359, 37501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37411, 37449);

                        f_10956_37411_37448(this, SyntaxKind.CommaToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37471, 37482);

                        f_10956_37471_37481(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 37359, 37501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37521, 37559);

                    f_10956_37521_37558(this, SyntaxKind.ArgListKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 37312, 37574);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 35943, 37585);

                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_36092_36115(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 36092, 36115);
                    return return_v;
                }


                bool
                f_10956_36505_36526_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 36505, 36526);
                    return return_v;
                }


                int
                f_10956_36694_36731(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 36694, 36731);
                    return 0;
                }


                int
                f_10956_36758_36768(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 36758, 36768);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_36893_36916(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 36893, 36916);
                    return return_v;
                }


                bool
                f_10956_36893_36983(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 36893, 36983);
                    return return_v;
                }


                int
                f_10956_37041_37075(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37041, 37075);
                    return 0;
                }


                int
                f_10956_37106_37116(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37106, 37116);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_37240_37260(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 37240, 37260);
                    return return_v;
                }


                int
                f_10956_37227_37261(Microsoft.CodeAnalysis.IParameterSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37227, 37261);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_10956_36582_36592_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 36582, 36592);
                    return return_v;
                }


                int
                f_10956_37411_37448(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37411, 37448);
                    return 0;
                }


                int
                f_10956_37471_37481(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37471, 37481);
                    return 0;
                }


                int
                f_10956_37521_37558(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37521, 37558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 35943, 37585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 35943, 37585);
            }
        }

        private void AddAccessor(IPropertySymbol property, IMethodSymbol method, SyntaxKind keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 37597, 38271);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37714, 38260) || true) && (method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 37714, 38260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37766, 37777);

                    f_10956_37766_37776(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37795, 37947) || true) && (f_10956_37799_37827(method) != f_10956_37831_37861(property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 37795, 37947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37903, 37928);

                        f_10956_37903_37927(this, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 37795, 37947);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 37967, 38145) || true) && (!f_10956_37972_38011(property) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 37971, 38060) && f_10956_38015_38060(method, property)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 37967, 38145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38102, 38126);

                        f_10956_38102_38125(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 37967, 38145);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38165, 38185);

                    f_10956_38165_38184(this, keyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38203, 38245);

                    f_10956_38203_38244(this, SyntaxKind.SemicolonToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 37714, 38260);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 37597, 38271);

                int
                f_10956_37766_37776(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37766, 37776);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10956_37799_37827(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 37799, 37827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10956_37831_37861(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 37831, 37861);
                    return return_v;
                }


                int
                f_10956_37903_37927(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    this_param.AddAccessibility((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37903, 37927);
                    return 0;
                }


                bool
                f_10956_37972_38011(Microsoft.CodeAnalysis.IPropertySymbol
                property)
                {
                    var return_v = ShouldPropertyDisplayReadOnly(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 37972, 38011);
                    return return_v;
                }


                bool
                f_10956_38015_38060(Microsoft.CodeAnalysis.IMethodSymbol
                method, Microsoft.CodeAnalysis.IPropertySymbol
                propertyOpt)
                {
                    var return_v = ShouldMethodDisplayReadOnly(method, propertyOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38015, 38060);
                    return return_v;
                }


                int
                f_10956_38102_38125(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddReadOnlyIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38102, 38125);
                    return 0;
                }


                int
                f_10956_38165_38184(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38165, 38184);
                    return 0;
                }


                int
                f_10956_38203_38244(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38203, 38244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 37597, 38271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 37597, 38271);
            }
        }

        private void AddExplicitInterfaceIfRequired<T>(ImmutableArray<T> implementedMembers) where T : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 38283, 39006);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38410, 38995) || true) && (f_10956_38414_38502<T>(f_10956_38414_38434<T>(format), SymbolDisplayMemberOptions.IncludeExplicitInterface) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 38414, 38533) && f_10956_38506_38533_M(!implementedMembers.IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 38410, 38995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38567, 38613);

                    var
                    implementedMember = implementedMembers[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38631, 38686);

                    f_10956_38631_38685<T>(f_10956_38644_38676<T>(implementedMember) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38706, 38773);

                    INamedTypeSymbol
                    containingType = f_10956_38740_38772<T>(implementedMember)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38791, 38980) || true) && (containingType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 38791, 38980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38859, 38903);

                        f_10956_38859_38902<T>(containingType, f_10956_38881_38901<T>(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 38925, 38961);

                        f_10956_38925_38960<T>(this, SyntaxKind.DotToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 38791, 38980);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 38410, 38995);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 38283, 39006);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_38414_38434<T>(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param) where T : ISymbol

                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 38414, 38434);
                    return return_v;
                }


                bool
                f_10956_38414_38502<T>(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag) where T : ISymbol

                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38414, 38502);
                    return return_v;
                }


                bool
                f_10956_38506_38533_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 38506, 38533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_38644_38676<T>(T
                this_param) where T : ISymbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 38644, 38676);
                    return return_v;
                }


                int
                f_10956_38631_38685<T>(bool
                condition) where T : ISymbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38631, 38685);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_38740_38772<T>(T
                this_param) where T : ISymbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 38740, 38772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_38881_38901<T>(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param) where T : ISymbol

                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 38881, 38901);
                    return return_v;
                }


                int
                f_10956_38859_38902<T>(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor) where T : ISymbol

                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38859, 38902);
                    return 0;
                }


                int
                f_10956_38925_38960<T>(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind) where T : ISymbol

                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 38925, 38960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 38283, 39006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 38283, 39006);
            }
        }

        private void AddCustomModifiersIfRequired(ImmutableArray<CustomModifier> customModifiers, bool leadingSpace = false, bool trailingSpace = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 39018, 40163);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39186, 40152) || true) && (f_10956_39190_39301(f_10956_39190_39225(this.format), SymbolDisplayCompilerInternalOptions.IncludeCustomModifiers) && (DynAbs.Tracing.TraceSender.Expression_True(10956, 39190, 39329) && f_10956_39305_39329_M(!customModifiers.IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 39186, 40152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39363, 39381);

                    bool
                    first = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39399, 40030);
                        foreach (CustomModifier customModifier in f_10956_39441_39456_I(customModifiers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 39399, 40030);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39498, 39608) || true) && (!first || (DynAbs.Tracing.TraceSender.Expression_False(10956, 39502, 39524) || leadingSpace))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 39498, 39608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39574, 39585);

                                f_10956_39574_39584(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 39498, 39608);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39630, 39644);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39668, 39807);

                            f_10956_39668_39806(
                                                this.builder, f_10956_39685_39805(this, InternalSymbolDisplayPartKind.Other, null, (DynAbs.Tracing.TraceSender.Conditional_F1(10956, 39739, 39764) || ((f_10956_39739_39764(customModifier) && DynAbs.Tracing.TraceSender.Conditional_F2(10956, 39767, 39784)) || DynAbs.Tracing.TraceSender.Conditional_F3(10956, 39787, 39804))) ? IL_KEYWORD_MODOPT : IL_KEYWORD_MODREQ));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39829, 39871);

                            f_10956_39829_39870(this, SyntaxKind.OpenParenToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39893, 39946);

                            f_10956_39893_39945(f_10956_39893_39916(customModifier), f_10956_39924_39944(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 39968, 40011);

                            f_10956_39968_40010(this, SyntaxKind.CloseParenToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 39399, 40030);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10956, 1, 632);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10956, 1, 632);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40048, 40137) || true) && (trailingSpace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 40048, 40137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40107, 40118);

                        f_10956_40107_40117(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 40048, 40137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 39186, 40152);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 39018, 40163);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10956_39190_39225(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 39190, 39225);
                    return return_v;
                }


                bool
                f_10956_39190_39301(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39190, 39301);
                    return return_v;
                }


                bool
                f_10956_39305_39329_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 39305, 39329);
                    return return_v;
                }


                int
                f_10956_39574_39584(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39574, 39584);
                    return 0;
                }


                bool
                f_10956_39739_39764(Microsoft.CodeAnalysis.CustomModifier
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 39739, 39764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10956_39685_39805(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39685, 39805);
                    return return_v;
                }


                int
                f_10956_39668_39806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39668, 39806);
                    return 0;
                }


                int
                f_10956_39829_39870(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39829, 39870);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10956_39893_39916(Microsoft.CodeAnalysis.CustomModifier
                this_param)
                {
                    var return_v = this_param.Modifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 39893, 39916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10956_39924_39944(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 39924, 39944);
                    return return_v;
                }


                int
                f_10956_39893_39945(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39893, 39945);
                    return 0;
                }


                int
                f_10956_39968_40010(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39968, 40010);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10956_39441_39456_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 39441, 39456);
                    return return_v;
                }


                int
                f_10956_40107_40117(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40107, 40117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 39018, 40163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 39018, 40163);
            }
        }

        private void AddRefIfRequired()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 40175, 40432);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40231, 40421) || true) && (f_10956_40235_40309(f_10956_40235_40255(format), SymbolDisplayMemberOptions.IncludeRef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 40231, 40421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40343, 40377);

                    f_10956_40343_40376(this, SyntaxKind.RefKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40395, 40406);

                    f_10956_40395_40405(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 40231, 40421);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 40175, 40432);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_40235_40255(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 40235, 40255);
                    return return_v;
                }


                bool
                f_10956_40235_40309(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40235, 40309);
                    return return_v;
                }


                int
                f_10956_40343_40376(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40343, 40376);
                    return 0;
                }


                int
                f_10956_40395_40405(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40395, 40405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 40175, 40432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 40175, 40432);
            }
        }

        private void AddRefReadonlyIfRequired()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 40444, 40795);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40508, 40784) || true) && (f_10956_40512_40586(f_10956_40512_40532(format), SymbolDisplayMemberOptions.IncludeRef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 40508, 40784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40620, 40654);

                    f_10956_40620_40653(this, SyntaxKind.RefKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40672, 40683);

                    f_10956_40672_40682(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40701, 40740);

                    f_10956_40701_40739(this, SyntaxKind.ReadOnlyKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 40758, 40769);

                    f_10956_40758_40768(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 40508, 40784);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 40444, 40795);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_40512_40532(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 40512, 40532);
                    return return_v;
                }


                bool
                f_10956_40512_40586(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40512, 40586);
                    return return_v;
                }


                int
                f_10956_40620_40653(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40620, 40653);
                    return 0;
                }


                int
                f_10956_40672_40682(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40672, 40682);
                    return 0;
                }


                int
                f_10956_40701_40739(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40701, 40739);
                    return 0;
                }


                int
                f_10956_40758_40768(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 40758, 40768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 40444, 40795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 40444, 40795);
            }
        }

        private void AddReadOnlyIfRequired()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 40807, 41231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41025, 41220) || true) && (f_10956_41029_41103(f_10956_41029_41049(format), SymbolDisplayMemberOptions.IncludeRef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 41025, 41220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41137, 41176);

                    f_10956_41137_41175(this, SyntaxKind.ReadOnlyKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41194, 41205);

                    f_10956_41194_41204(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 41025, 41220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 40807, 41231);

                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10956_41029_41049(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 41029, 41049);
                    return return_v;
                }


                bool
                f_10956_41029_41103(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41029, 41103);
                    return return_v;
                }


                int
                f_10956_41137_41175(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41137, 41175);
                    return 0;
                }


                int
                f_10956_41194_41204(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41194, 41204);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 40807, 41231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 40807, 41231);
            }
        }

        private void AddParameterRefKindIfRequired(RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10956, 41243, 42036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41327, 42025) || true) && (f_10956_41331_41420(f_10956_41331_41354(format), SymbolDisplayParameterOptions.IncludeParamsRefOut))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 41327, 42025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41454, 42010);

                    switch (refKind)
                    {

                        case RefKind.Out:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 41454, 42010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41554, 41588);

                            f_10956_41554_41587(this, SyntaxKind.OutKeyword);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41614, 41625);

                            f_10956_41614_41624(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(10956, 41651, 41657);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 41454, 42010);

                        case RefKind.Ref:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 41454, 42010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41722, 41756);

                            f_10956_41722_41755(this, SyntaxKind.RefKeyword);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41782, 41793);

                            f_10956_41782_41792(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(10956, 41819, 41825);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 41454, 42010);

                        case RefKind.In:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10956, 41454, 42010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41889, 41922);

                            f_10956_41889_41921(this, SyntaxKind.InKeyword);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 41948, 41959);

                            f_10956_41948_41958(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(10956, 41985, 41991);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 41454, 42010);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10956, 41327, 42025);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10956, 41243, 42036);

                Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                f_10956_41331_41354(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.ParameterOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10956, 41331, 41354);
                    return return_v;
                }


                bool
                f_10956_41331_41420(Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41331, 41420);
                    return return_v;
                }


                int
                f_10956_41554_41587(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41554, 41587);
                    return 0;
                }


                int
                f_10956_41614_41624(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41614, 41624);
                    return 0;
                }


                int
                f_10956_41722_41755(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41722, 41755);
                    return 0;
                }


                int
                f_10956_41782_41792(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41782, 41792);
                    return 0;
                }


                int
                f_10956_41889_41921(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41889, 41921);
                    return 0;
                }


                int
                f_10956_41948_41958(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10956, 41948, 41958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10956, 41243, 42036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10956, 41243, 42036);
            }
        }
    }
}
