// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal abstract class TypeSymbol : NamespaceOrTypeSymbol, ISymbol, ITypeSymbol
    {
        protected TypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10660, 468, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 628, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 565, 605);

                NullableAnnotation = nullableAnnotation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10660, 468, 616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 468, 616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 468, 616);
            }
        }

        protected CodeAnalysis.NullableAnnotation NullableAnnotation { get; }

        protected abstract ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation);

        internal abstract Symbols.TypeSymbol UnderlyingTypeSymbol { get; }

        CodeAnalysis.NullableAnnotation ITypeSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 968, 989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 971, 989);
                    return f_10660_971_989(); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 968, 989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 968, 989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 968, 989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol ITypeSymbol.WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 1002, 1492);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1125, 1415) || true) && (f_10660_1129_1147() == nullableAnnotation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 1125, 1415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1203, 1215);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 1125, 1415);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 1125, 1415);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1249, 1415) || true) && (nullableAnnotation == f_10660_1275_1321(f_10660_1275_1295()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 1249, 1415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1355, 1400);

                        return (ITypeSymbol)f_10660_1375_1399(f_10660_1375_1391());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 1249, 1415);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 1125, 1415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1431, 1481);

                return f_10660_1438_1480(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 1002, 1492);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_1129_1147()
                {
                    var return_v = NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1129, 1147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_1275_1295()
                {
                    var return_v = UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1275, 1295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_1275_1321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1275, 1321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10660_1375_1391()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1375, 1391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10660_1375_1399(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1375, 1399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10660_1438_1480(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = this_param.WithNullableAnnotation(nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 1438, 1480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 1002, 1492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 1002, 1492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISymbol.IsDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 1554, 1663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1590, 1648);

                    return (object)this == f_10660_1613_1647(((ISymbol)this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 1554, 1663);

                    Microsoft.CodeAnalysis.ISymbol
                    f_10660_1613_1647(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 1613, 1647);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 1504, 1674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 1504, 1674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.Equals(ISymbol other, CodeAnalysis.SymbolEqualityComparer equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 1686, 1868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 1799, 1857);

                return f_10660_1806_1856(this, other as TypeSymbol, equalityComparer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 1686, 1868);

                bool
                f_10660_1806_1856(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param, Microsoft.CodeAnalysis.ISymbol
                otherType, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol?)otherType, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 1806, 1856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 1686, 1868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 1686, 1868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool Equals(TypeSymbol otherType, CodeAnalysis.SymbolEqualityComparer equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 1880, 2927);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2002, 2194) || true) && (otherType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 2002, 2194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2057, 2070);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 2002, 2194);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 2002, 2194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2104, 2194) || true) && ((object)otherType == this)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 2104, 2194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2167, 2179);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 2104, 2194);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 2002, 2194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2210, 2257);

                var
                compareKind = f_10660_2228_2256(equalityComparer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2273, 2820) || true) && (f_10660_2277_2295() != f_10660_2299_2327(otherType) && (DynAbs.Tracing.TraceSender.Expression_True(10660, 2277, 2408) && (compareKind & TypeCompareKind.IgnoreNullableModifiersForReferenceTypes) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10660, 2277, 2660) && ((compareKind & TypeCompareKind.ObliviousNullableModifierMatchesAny) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10660, 2430, 2659) || (f_10660_2528_2546() != CodeAnalysis.NullableAnnotation.None && (DynAbs.Tracing.TraceSender.Expression_True(10660, 2528, 2658) && f_10660_2590_2618(otherType) != CodeAnalysis.NullableAnnotation.None))))) && (DynAbs.Tracing.TraceSender.Expression_True(10660, 2277, 2758) && !(f_10660_2683_2715(f_10660_2683_2703()) && (DynAbs.Tracing.TraceSender.Expression_True(10660, 2683, 2757) && !f_10660_2720_2757(f_10660_2720_2740())))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10660, 2273, 2820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2792, 2805);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10660, 2273, 2820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 2836, 2916);

                return f_10660_2843_2915(f_10660_2843_2863(), f_10660_2871_2901(otherType), compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 1880, 2927);

                Microsoft.CodeAnalysis.TypeCompareKind
                f_10660_2228_2256(Microsoft.CodeAnalysis.SymbolEqualityComparer
                this_param)
                {
                    var return_v = this_param.CompareKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2228, 2256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_2277_2295()
                {
                    var return_v = NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2277, 2295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_2299_2327(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2299, 2327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_2528_2546()
                {
                    var return_v = NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2528, 2546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10660_2590_2618(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2590, 2618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_2683_2703()
                {
                    var return_v = UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2683, 2703);
                    return return_v;
                }


                bool
                f_10660_2683_2715(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2683, 2715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_2720_2740()
                {
                    var return_v = UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2720, 2740);
                    return return_v;
                }


                bool
                f_10660_2720_2757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 2720, 2757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_2843_2863()
                {
                    var return_v = UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2843, 2863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_2871_2901(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 2871, 2901);
                    return return_v;
                }


                bool
                f_10660_2843_2915(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 2843, 2915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 1880, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 1880, 2927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ITypeSymbol ITypeSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 3006, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 3042, 3107);

                    return f_10660_3049_3106(f_10660_3049_3088(f_10660_3049_3069()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 3006, 3122);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_3049_3069()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3049, 3069);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_3049_3088(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3049, 3088);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10660_3049_3106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 3049, 3106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 2939, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 2939, 3133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol ITypeSymbol.BaseType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 3207, 3333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 3243, 3318);

                    return f_10660_3250_3317(f_10660_3250_3299(f_10660_3250_3270()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 3207, 3333);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_3250_3270()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3250, 3270);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10660_3250_3299(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3250, 3299);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10660_3250_3317(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 3250, 3317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 3145, 3344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 3145, 3344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<INamedTypeSymbol> ITypeSymbol.Interfaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 3436, 3567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 3472, 3552);

                    return f_10660_3479_3532(f_10660_3479_3499()).GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 3436, 3567);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_3479_3499()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3479, 3499);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10660_3479_3532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 3479, 3532);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 3356, 3578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 3356, 3578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<INamedTypeSymbol> ITypeSymbol.AllInterfaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 3673, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 3709, 3790);

                    return f_10660_3716_3736().AllInterfacesNoUseSiteDiagnostics.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 3673, 3805);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_3716_3736()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3716, 3736);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 3590, 3816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 3590, 3816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol ITypeSymbol.FindImplementationForInterfaceMember(ISymbol interfaceMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 3828, 4129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 3934, 4118);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10660, 3941, 3973) || ((interfaceMember is Symbol
                && DynAbs.Tracing.TraceSender.Conditional_F2(10660, 3993, 4093)) || DynAbs.Tracing.TraceSender.Conditional_F3(10660, 4113, 4117))) ? f_10660_3993_4093(f_10660_3993_4075(f_10660_3993_4013(), f_10660_4051_4074((Symbol)interfaceMember))) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 3828, 4129);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10660_3993_4013()
                {
                    var return_v = UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 3993, 4013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10660_4051_4074(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4051, 4074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10660_3993_4075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.FindImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 3993, 4075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10660_3993_4093(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 3993, 4093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 3828, 4129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 3828, 4129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ITypeSymbol.IsUnmanagedType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4174, 4232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4177, 4232);
                    return f_10660_4177_4232_M(!f_10660_4178_4198().IsManagedTypeNoUseSiteDiagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4174, 4232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4174, 4232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4174, 4232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4302, 4397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4338, 4382);

                    return f_10660_4345_4381(f_10660_4345_4365());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4302, 4397);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_4345_4365()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4345, 4365);
                        return return_v;
                    }


                    bool
                    f_10660_4345_4381(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReferenceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4345, 4381);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4245, 4408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4245, 4408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4473, 4564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4509, 4549);

                    return f_10660_4516_4548(f_10660_4516_4536());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4473, 4564);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_4516_4536()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4516, 4536);
                        return return_v;
                    }


                    bool
                    f_10660_4516_4548(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4516, 4548);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4420, 4575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4420, 4575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeKind ITypeSymbol.TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4641, 4729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4677, 4714);

                    return f_10660_4684_4713(f_10660_4684_4704());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4641, 4729);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10660_4684_4704()
                    {
                        var return_v = UnderlyingTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4684, 4704);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10660_4684_4713(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4684, 4713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4587, 4740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4587, 4740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsTupleType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4781, 4816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4784, 4816);
                    return f_10660_4784_4816(f_10660_4784_4804()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4781, 4816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4781, 4816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4781, 4816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsNativeIntegerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4866, 4909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 4869, 4909);
                    return f_10660_4869_4909(f_10660_4869_4889()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4866, 4909);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4866, 4909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4866, 4909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ITypeSymbol.ToDisplayString(CodeAnalysis.NullableFlowState topLevelNullability, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 4922, 5144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 5061, 5133);

                return f_10660_5068_5132(this, topLevelNullability, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 4922, 5144);

                string
                f_10660_5068_5132(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 5068, 5132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 4922, 5144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 4922, 5144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ITypeSymbol.ToDisplayParts(CodeAnalysis.NullableFlowState topLevelNullability, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 5156, 5403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 5321, 5392);

                return f_10660_5328_5391(this, topLevelNullability, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 5156, 5403);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10660_5328_5391(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayParts((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 5328, 5391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 5156, 5403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 5156, 5403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ITypeSymbol.ToMinimalDisplayString(SemanticModel semanticModel, CodeAnalysis.NullableFlowState topLevelNullability, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 5415, 5719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 5604, 5708);

                return f_10660_5611_5707(this, topLevelNullability, semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 5415, 5719);

                string
                f_10660_5611_5707(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayString((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 5611, 5707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 5415, 5719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 5415, 5719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ITypeSymbol.ToMinimalDisplayParts(SemanticModel semanticModel, CodeAnalysis.NullableFlowState topLevelNullability, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 5731, 6060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 5946, 6049);

                return f_10660_5953_6048(this, topLevelNullability, semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 5731, 6060);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10660_5953_6048(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                symbol, Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayParts((Microsoft.CodeAnalysis.ITypeSymbol)symbol, nullableFlowState, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10660, 5953, 6048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 5731, 6060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 5731, 6060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ITypeSymbol.IsAnonymousType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 6105, 6144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 6108, 6144);
                    return f_10660_6108_6144(f_10660_6108_6128()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 6105, 6144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 6105, 6144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 6105, 6144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        SpecialType ITypeSymbol.SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 6193, 6228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 6196, 6228);
                    return f_10660_6196_6228(f_10660_6196_6216()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 6193, 6228);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 6193, 6228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 6193, 6228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 6272, 6309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 6275, 6309);
                    return f_10660_6275_6309(f_10660_6275_6295()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 6272, 6309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 6272, 6309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 6272, 6309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 6350, 6384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 6353, 6384);
                    return f_10660_6353_6384(f_10660_6353_6373()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 6350, 6384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 6350, 6384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 6350, 6384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeSymbol.IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10660, 6423, 6455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10660, 6426, 6455);
                    return f_10660_6426_6455(f_10660_6426_6446()); DynAbs.Tracing.TraceSender.TraceExitMethod(10660, 6423, 6455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10660, 6423, 6455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 6423, 6455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static TypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10660, 371, 6463);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10660, 371, 6463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10660, 371, 6463);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10660, 371, 6463);

        Microsoft.CodeAnalysis.NullableAnnotation
        f_10660_971_989()
        {
            var return_v = NullableAnnotation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 971, 989);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_4178_4198()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4178, 4198);
            return return_v;
        }


        bool
        f_10660_4177_4232_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4177, 4232);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_4784_4804()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4784, 4804);
            return return_v;
        }


        bool
        f_10660_4784_4816(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4784, 4816);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_4869_4889()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4869, 4889);
            return return_v;
        }


        bool
        f_10660_4869_4909(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsNativeIntegerType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 4869, 4909);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_6108_6128()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6108, 6128);
            return return_v;
        }


        bool
        f_10660_6108_6144(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsAnonymousType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6108, 6144);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_6196_6216()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6196, 6216);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10660_6196_6228(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6196, 6228);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_6275_6295()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6275, 6295);
            return return_v;
        }


        bool
        f_10660_6275_6309(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsRefLikeType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6275, 6309);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_6353_6373()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6353, 6373);
            return return_v;
        }


        bool
        f_10660_6353_6384(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6353, 6384);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10660_6426_6446()
        {
            var return_v = UnderlyingTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6426, 6446);
            return return_v;
        }


        bool
        f_10660_6426_6455(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10660, 6426, 6455);
            return return_v;
        }

    }
}
