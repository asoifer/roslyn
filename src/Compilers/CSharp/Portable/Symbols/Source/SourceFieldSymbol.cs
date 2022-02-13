// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceFieldSymbol : FieldSymbolWithAttributesAndModifiers
    {
        protected readonly SourceMemberContainerTypeSymbol containingType;

        protected SourceFieldSymbol(SourceMemberContainerTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10219, 706, 915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 679, 693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 806, 851);

                f_10219_806_850((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 867, 904);

                this.containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10219, 706, 915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 706, 915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 706, 915);
            }
        }

        public abstract override string Name { get; }

        protected override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 1065, 1085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1071, 1083);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 1065, 1085);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 984, 1096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 984, 1096);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 1181, 1201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1187, 1199);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 1181, 1201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 1108, 1212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 1108, 1212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNew
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 1268, 1370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1304, 1355);

                    return (f_10219_1312_1321() & DeclarationModifiers.New) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 1268, 1370);

                    Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    f_10219_1312_1321()
                    {
                        var return_v = Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1312, 1321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 1224, 1381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 1224, 1381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void CheckAccessibility(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 1393, 1731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1478, 1581);

                var
                info = f_10219_1489_1580(f_10219_1522_1531(), this, isExplicitInterfaceImplementation: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1595, 1720) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 1595, 1720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1645, 1705);

                    f_10219_1645_1704(diagnostics, f_10219_1661_1703(info, f_10219_1684_1702(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 1595, 1720);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 1393, 1731);

                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10219_1522_1531()
                {
                    var return_v = Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1522, 1531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_1489_1580(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                symbol, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation: isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1489, 1580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_1684_1702(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1684, 1702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10219_1661_1703(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1661, 1703);
                    return return_v;
                }


                int
                f_10219_1645_1704(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1645, 1704);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 1393, 1731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 1393, 1731);
            }
        }

        protected void ReportModifiersDiagnostics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 1743, 2863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1836, 2603) || true) && (f_10219_1840_1863(f_10219_1840_1854()) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 1840, 1908) && f_10219_1867_1908(f_10219_1867_1893(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 1836, 2603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 1942, 2044);

                    f_10219_1942_2043(diagnostics, f_10219_1958_2021(containingType), f_10219_2023_2036(), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 1836, 2603);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 1836, 2603);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2078, 2603) || true) && (f_10219_2082_2092() && (DynAbs.Tracing.TraceSender.Expression_True(10219, 2082, 2106) && f_10219_2096_2106()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 2078, 2603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2140, 2212);

                        f_10219_2140_2211(diagnostics, ErrorCode.ERR_VolatileAndReadonly, f_10219_2191_2204(), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 2078, 2603);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 2078, 2603);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2246, 2603) || true) && (f_10219_2250_2273(containingType) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 2250, 2286) && f_10219_2277_2286_M(!IsStatic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 2246, 2603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2320, 2400);

                            f_10219_2320_2399(diagnostics, ErrorCode.ERR_InstanceMemberInStaticClass, f_10219_2379_2392(), this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 2246, 2603);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 2246, 2603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2434, 2603) || true) && (f_10219_2438_2447_M(!IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 2438, 2462) && f_10219_2451_2462_M(!IsReadOnly)) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 2438, 2491) && f_10219_2466_2491(containingType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 2434, 2603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 2525, 2588);

                                f_10219_2525_2587(diagnostics, ErrorCode.ERR_FieldsInRoStruct, f_10219_2573_2586());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 2434, 2603);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 2246, 2603);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 2078, 2603);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 1836, 2603);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 1743, 2863);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10219_1840_1854()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1840, 1854);
                    return return_v;
                }


                bool
                f_10219_1840_1863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1840, 1863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10219_1867_1893(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 1867, 1893);
                    return return_v;
                }


                bool
                f_10219_1867_1908(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1867, 1908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10219_1958_2021(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType)
                {
                    var return_v = AccessCheck.GetProtectedMemberInSealedTypeError((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1958, 2021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_2023_2036()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2023, 2036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_1942_2043(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 1942, 2043);
                    return return_v;
                }


                bool
                f_10219_2082_2092()
                {
                    var return_v = IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2082, 2092);
                    return return_v;
                }


                bool
                f_10219_2096_2106()
                {
                    var return_v = IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2096, 2106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_2191_2204()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2191, 2204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_2140_2211(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 2140, 2211);
                    return return_v;
                }


                bool
                f_10219_2250_2273(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2250, 2273);
                    return return_v;
                }


                bool
                f_10219_2277_2286_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2277, 2286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_2379_2392()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2379, 2392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_2320_2399(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 2320, 2399);
                    return return_v;
                }


                bool
                f_10219_2438_2447_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2438, 2447);
                    return return_v;
                }


                bool
                f_10219_2451_2462_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2451, 2462);
                    return return_v;
                }


                bool
                f_10219_2466_2491(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2466, 2491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_2573_2586()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 2573, 2586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_2525_2587(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 2525, 2587);
                    return return_v;
                }


                // TODO: Consider checking presence of core type System.Runtime.CompilerServices.IsVolatile
                // if there is a volatile modifier. Perhaps an appropriate error should be reported if the
                // type isn't available.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 1743, 2863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 1743, 2863);
            }
        }

        protected ImmutableArray<CustomModifier> RequiredCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 2964, 3425);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3000, 3410) || true) && (f_10219_3004_3015_M(!IsVolatile))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 3000, 3410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3057, 3101);

                        return ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 3000, 3410);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 3000, 3410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3183, 3391);

                        return f_10219_3190_3390(f_10219_3258_3389(f_10219_3294_3388(f_10219_3294_3317(this), SpecialType.System_Runtime_CompilerServices_IsVolatile)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 3000, 3410);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 2964, 3425);

                    bool
                    f_10219_3004_3015_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 3004, 3015);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10219_3294_3317(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 3294, 3317);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10219_3294_3388(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 3294, 3388);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10219_3258_3389(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateRequired(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 3258, 3389);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10219_3190_3390(Microsoft.CodeAnalysis.CustomModifier
                    item)
                    {
                        var return_v = ImmutableArray.Create<CustomModifier>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 3190, 3390);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 2875, 3436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 2875, 3436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 3519, 3592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3555, 3577);

                    return containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 3519, 3592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 3448, 3603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 3448, 3603);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 3686, 3764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3722, 3749);

                    return this.containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 3686, 3764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 3615, 3775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 3615, 3775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 3787, 4725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 3972, 4031);

                f_10219_3972_4030((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4047, 4083);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4097, 4132);

                f_10219_4097_4131(f_10219_4110_4130_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4146, 4207);

                f_10219_4146_4206(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4223, 4714) || true) && (f_10219_4227_4303(attribute, this, AttributeDescription.FixedBufferAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 4223, 4714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4479, 4588);

                    f_10219_4479_4587(                // error CS1716: Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute. Use the 'fixed' field modifier instead.
                                    arguments.Diagnostics, ErrorCode.ERR_DoNotUseFixedBufferAttr, f_10219_4544_4586(f_10219_4544_4577(arguments.AttributeSyntaxOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 4223, 4714);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 4223, 4714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4654, 4699);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DecodeWellKnownAttribute(ref arguments), 10219, 4654, 4698);
                    base.DecodeWellKnownAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4654, 4698);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 4223, 4714);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 3787, 4725);

                int
                f_10219_3972_4030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 3972, 4030);
                    return 0;
                }


                bool
                f_10219_4110_4130_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4110, 4130);
                    return return_v;
                }


                int
                f_10219_4097_4131(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4097, 4131);
                    return 0;
                }


                int
                f_10219_4146_4206(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4146, 4206);
                    return 0;
                }


                bool
                f_10219_4227_4303(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4227, 4303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10219_4544_4577(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4544, 4577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_4544_4586(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4544, 4586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_4479_4587(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4479, 4587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 3787, 4725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 3787, 4725);
            }
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 4737, 5424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4869, 4908);

                var
                compilation = f_10219_4887_4907()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4922, 4951);

                var
                location = f_10219_4937_4950()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 4967, 5143) || true) && (f_10219_4971_4999(f_10219_4971_4975()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 4967, 5143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5033, 5128);

                    f_10219_5033_5127(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 4967, 5143);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5159, 5413) || true) && (f_10219_5163_5209(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 5163, 5274) && f_10219_5230_5249().NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 5159, 5413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5308, 5398);

                    f_10219_5308_5397(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 5159, 5413);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 4737, 5424);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10219_4887_4907()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4887, 4907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10219_4937_4950()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4937, 4950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10219_4971_4975()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 4971, 4975);
                    return return_v;
                }


                bool
                f_10219_4971_4999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 4971, 4999);
                    return return_v;
                }


                int
                f_10219_5033_5127(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 5033, 5127);
                    return 0;
                }


                bool
                f_10219_5163_5209(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 5163, 5209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10219_5230_5249()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 5230, 5249);
                    return return_v;
                }


                int
                f_10219_5308_5397(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 5308, 5397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 4737, 5424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 4737, 5424);
            }
        }

        internal sealed override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 5512, 5625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5548, 5610);

                    return f_10219_5555_5564(this) == WellKnownMemberNames.EnumBackingFieldName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 5512, 5625);

                    string
                    f_10219_5555_5564(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 5555, 5564);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 5436, 5636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 5436, 5636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10219, 530, 5643);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10219, 530, 5643);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 530, 5643);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10219, 530, 5643);

        int
        f_10219_806_850(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 806, 850);
            return 0;
        }

    }
    internal abstract class SourceFieldSymbolWithSyntaxReference : SourceFieldSymbol
    {
        private readonly string _name;

        private readonly Location _location;

        private readonly SyntaxReference _syntaxReference;

        private string _lazyDocComment;

        private string _lazyExpandedDocComment;

        private ConstantValue _lazyConstantEarlyDecodingValue;

        private ConstantValue _lazyConstantValue;

        protected SourceFieldSymbolWithSyntaxReference(SourceMemberContainerTypeSymbol containingType, string name, SyntaxReference syntax, Location location)
        : base(f_10219_6366_6380_C(containingType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10219, 6195, 6636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5772, 5777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5814, 5823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5867, 5883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5911, 5926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 5952, 5975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6008, 6084);
                this._lazyConstantEarlyDecodingValue = f_10219_6042_6084(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6117, 6180);
                this._lazyConstantValue = f_10219_6138_6180(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6406, 6433);

                f_10219_6406_6432(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6447, 6476);

                f_10219_6447_6475(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6490, 6521);

                f_10219_6490_6520(location != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6537, 6550);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6564, 6590);

                _syntaxReference = syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6604, 6625);

                _location = location;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10219, 6195, 6636);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 6195, 6636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 6195, 6636);
            }
        }

        public SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 6701, 6787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6737, 6772);

                    return f_10219_6744_6771(_syntaxReference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 6701, 6787);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10219_6744_6771(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 6744, 6771);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 6648, 6798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 6648, 6798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CSharpSyntaxNode SyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 6869, 6974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 6905, 6959);

                    return (CSharpSyntaxNode)f_10219_6930_6958(_syntaxReference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 6869, 6974);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10219_6930_6958(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 6930, 6958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 6810, 6985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 6810, 6985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7056, 7120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 7092, 7105);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7056, 7120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 6997, 7131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 6997, 7131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7143, 7295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 7220, 7284);

                return f_10219_7227_7283(_location, f_10219_7257_7282(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7143, 7295);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10219_7257_7282(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 7257, 7282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10219_7227_7283(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 7227, 7283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 7143, 7295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 7143, 7295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7389, 7480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 7425, 7465);

                    return f_10219_7432_7464(_location);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7389, 7480);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10219_7432_7464(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 7432, 7464);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 7307, 7491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 7307, 7491);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override Location ErrorLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7575, 7643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 7611, 7628);

                    return _location;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7575, 7643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 7503, 7654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 7503, 7654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7771, 7886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 7807, 7871);

                    return f_10219_7814_7870(_syntaxReference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7771, 7886);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10219_7814_7870(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 7814, 7870);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 7666, 7897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 7666, 7897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 7909, 8356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8122, 8218);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10219, 8151, 8165) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10219, 8168, 8195)) || DynAbs.Tracing.TraceSender.Conditional_F3(10219, 8198, 8217))) ? ref _lazyExpandedDocComment : ref _lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8232, 8345);

                return f_10219_8239_8344(this, expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 7909, 8356);

                string
                f_10219_8239_8344(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                symbol, bool
                expandIncludes, ref string
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 8239, 8344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 7909, 8356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 7909, 8356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 8368, 10060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8524, 8596);

                var
                value = f_10219_8536_8595(this, earlyDecodingWellKnownAttributes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8610, 8727) || true) && (value != f_10219_8623_8665())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 8610, 8727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8699, 8712);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 8610, 8727);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 8743, 9143) || true) && (f_10219_8747_8766_M(!inProgress.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 8743, 9143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9029, 9060);

                    f_10219_9029_9059(                // Add this field as a dependency of the original field, and
                                                      // return Unset. The outer GetConstantValue caller will call
                                                      // this method again after evaluating any dependencies.
                                    inProgress, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9078, 9128);

                    return f_10219_9085_9127();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 8743, 9143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9195, 9271);

                var
                order = f_10219_9207_9270()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9285, 9352);

                f_10219_9285_9351(this, order, earlyDecodingWellKnownAttributes);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9410, 9889);
                    foreach (var info in f_10219_9431_9436_I(order))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 9410, 9889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9733, 9756);

                        var
                        field = info.Field
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9774, 9874);

                        f_10219_9774_9873(field, earlyDecodingWellKnownAttributes, startsCycle: info.StartsCycle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 9410, 9889);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10219, 1, 480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10219, 1, 480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9905, 9918);

                f_10219_9905_9917(
                            order);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 9982, 10049);

                return f_10219_9989_10048(this, earlyDecodingWellKnownAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 8368, 10060);

                Microsoft.CodeAnalysis.ConstantValue
                f_10219_8536_8595(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 8536, 8595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_8623_8665()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 8623, 8665);
                    return return_v;
                }


                bool
                f_10219_8747_8766_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 8747, 8766);
                    return return_v;
                }


                int
                f_10219_9029_9059(Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field)
                {
                    this_param.AddDependency(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9029, 9059);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_9085_9127()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 9085, 9127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                f_10219_9207_9270()
                {
                    var return_v = ArrayBuilder<ConstantEvaluationHelpers.FieldInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9207, 9270);
                    return return_v;
                }


                int
                f_10219_9285_9351(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                order, bool
                earlyDecodingWellKnownAttributes)
                {
                    field.OrderAllDependencies(order, earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9285, 9351);
                    return 0;
                }


                int
                f_10219_9774_9873(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes, bool
                startsCycle)
                {
                    this_param.BindConstantValueIfNecessary(earlyDecodingWellKnownAttributes, startsCycle: startsCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9774, 9873);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                f_10219_9431_9436_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9431, 9436);
                    return return_v;
                }


                int
                f_10219_9905_9917(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9905, 9917);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_9989_10048(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 9989, 10048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 8368, 10060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 8368, 10060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableHashSet<SourceFieldSymbolWithSyntaxReference> GetConstantValueDependencies(bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 10449, 12463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 10605, 10677);

                var
                value = f_10219_10617_10676(this, earlyDecodingWellKnownAttributes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 10691, 11065) || true) && (value != f_10219_10704_10746())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 10691, 11065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 10982, 11050);

                    return ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 10691, 11065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11081, 11149);

                ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>
                dependencies
                = default(ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11163, 11243);

                var
                builder = f_10219_11177_11242()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11257, 11303);

                var
                diagnostics = f_10219_11275_11302()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11317, 11399);

                value = f_10219_11325_11398(this, builder, earlyDecodingWellKnownAttributes, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11646, 12354) || true) && ((f_10219_11651_11664(builder) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 11650, 11706) && (value != null)) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 11650, 11739) && f_10219_11727_11739_M(!value.IsBad)) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 11650, 11813) && (value != f_10219_11770_11812())) && (DynAbs.Tracing.TraceSender.Expression_True(10219, 11650, 11869) && !f_10219_11835_11869(diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 11646, 12354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 11903, 12088);

                    f_10219_11903_12087(this, value, earlyDecodingWellKnownAttributes, diagnostics, startsCycle: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12106, 12182);

                    dependencies = ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 11646, 12354);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 11646, 12354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12248, 12339);

                    dependencies = f_10219_12263_12338(ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>.Empty, builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 11646, 12354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12370, 12389);

                f_10219_12370_12388(
                            diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12403, 12418);

                f_10219_12403_12417(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12432, 12452);

                return dependencies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 10449, 12463);

                Microsoft.CodeAnalysis.ConstantValue
                f_10219_10617_10676(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 10617, 10676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_10704_10746()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 10704, 10746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10219_11177_11242()
                {
                    var return_v = PooledHashSet<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 11177, 11242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10219_11275_11302()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 11275, 11302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_11325_11398(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                dependencies, bool
                earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeConstantValue((System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>)dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 11325, 11398);
                    return return_v;
                }


                int
                f_10219_11651_11664(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 11651, 11664);
                    return return_v;
                }


                bool
                f_10219_11727_11739_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 11727, 11739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_11770_11812()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 11770, 11812);
                    return return_v;
                }


                bool
                f_10219_11835_11869(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyResolvedErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 11835, 11869);
                    return return_v;
                }


                int
                f_10219_11903_12087(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value, bool
                earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                startsCycle)
                {
                    this_param.SetLazyConstantValue(value, earlyDecodingWellKnownAttributes, diagnostics, startsCycle: startsCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 11903, 12087);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10219_12263_12338(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                other)
                {
                    var return_v = this_param.Union((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12263, 12338);
                    return return_v;
                }


                int
                f_10219_12370_12388(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12370, 12388);
                    return 0;
                }


                int
                f_10219_12403_12417(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12403, 12417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 10449, 12463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 10449, 12463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BindConstantValueIfNecessary(bool earlyDecodingWellKnownAttributes, bool startsCycle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 12475, 13411);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12598, 12763) || true) && (f_10219_12602_12661(this, earlyDecodingWellKnownAttributes) != f_10219_12665_12707())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 12598, 12763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12741, 12748);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 12598, 12763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12779, 12859);

                var
                builder = f_10219_12793_12858()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12873, 12919);

                var
                diagnostics = f_10219_12891_12918()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12933, 13060) || true) && (startsCycle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 12933, 13060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 12982, 13045);

                    f_10219_12982_13044(diagnostics, ErrorCode.ERR_CircConstValue, _location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 12933, 13060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13076, 13162);

                var
                value = f_10219_13088_13161(this, builder, earlyDecodingWellKnownAttributes, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13176, 13338);

                f_10219_13176_13337(this, value, earlyDecodingWellKnownAttributes, diagnostics, startsCycle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13352, 13371);

                f_10219_13352_13370(diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13385, 13400);

                f_10219_13385_13399(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 12475, 13411);

                Microsoft.CodeAnalysis.ConstantValue
                f_10219_12602_12661(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12602, 12661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_12665_12707()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 12665, 12707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10219_12793_12858()
                {
                    var return_v = PooledHashSet<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12793, 12858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10219_12891_12918()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12891, 12918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10219_12982_13044(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 12982, 13044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_13088_13161(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                dependencies, bool
                earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeConstantValue((System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>)dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13088, 13161);
                    return return_v;
                }


                int
                f_10219_13176_13337(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value, bool
                earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                startsCycle)
                {
                    this_param.SetLazyConstantValue(value, earlyDecodingWellKnownAttributes, diagnostics, startsCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13176, 13337);
                    return 0;
                }


                int
                f_10219_13352_13370(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13352, 13370);
                    return 0;
                }


                int
                f_10219_13385_13399(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13385, 13399);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 12475, 13411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 12475, 13411);
            }
        }

        private ConstantValue GetLazyConstantValue(bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 13423, 13635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13529, 13624);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10219, 13536, 13568) || ((earlyDecodingWellKnownAttributes && DynAbs.Tracing.TraceSender.Conditional_F2(10219, 13571, 13602)) || DynAbs.Tracing.TraceSender.Conditional_F3(10219, 13605, 13623))) ? _lazyConstantEarlyDecodingValue : _lazyConstantValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 13423, 13635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 13423, 13635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 13423, 13635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetLazyConstantValue(
                    ConstantValue value,
                    bool earlyDecodingWellKnownAttributes,
                    DiagnosticBag diagnostics,
                    bool startsCycle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10219, 13647, 15167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13863, 13929);

                f_10219_13863_13928(value != f_10219_13885_13927());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 13943, 14146);

                f_10219_13943_14145((f_10219_13957_14011(this, earlyDecodingWellKnownAttributes) == f_10219_14015_14057()) || (DynAbs.Tracing.TraceSender.Expression_False(10219, 13956, 14144) || (f_10219_14080_14134(this, earlyDecodingWellKnownAttributes) == value)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14162, 15156) || true) && (earlyDecodingWellKnownAttributes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 14162, 15156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14232, 14348);

                    f_10219_14232_14347(ref _lazyConstantEarlyDecodingValue, value, f_10219_14304_14346());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 14162, 15156);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 14162, 15156);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14414, 15141) || true) && (f_10219_14418_14520(ref _lazyConstantValue, value, f_10219_14477_14519()) == f_10219_14524_14566())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10219, 14414, 15141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14771, 14815);

                        f_10219_14771_14814(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14919, 14966);

                        f_10219_14919_14965(f_10219_14919_14939(), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 14988, 15069);

                        var
                        wasSetThisThread = this.state.NotePartComplete(CompletionPart.ConstantValue)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10219, 15091, 15122);

                        f_10219_15091_15121(wasSetThisThread);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 14414, 15141);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10219, 14162, 15156);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10219, 13647, 15167);

                Microsoft.CodeAnalysis.ConstantValue
                f_10219_13885_13927()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 13885, 13927);
                    return return_v;
                }


                int
                f_10219_13863_13928(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13863, 13928);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_13957_14011(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13957, 14011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14015_14057()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 14015, 14057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14080_14134(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetLazyConstantValue(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 14080, 14134);
                    return return_v;
                }


                int
                f_10219_13943_14145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 13943, 14145);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14304_14346()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 14304, 14346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14232_14347(ref Microsoft.CodeAnalysis.ConstantValue
                location1, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.ConstantValue
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 14232, 14347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14477_14519()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 14477, 14519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14418_14520(ref Microsoft.CodeAnalysis.ConstantValue
                location1, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.ConstantValue
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 14418, 14520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10219_14524_14566()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 14524, 14566);
                    return return_v;
                }


                int
                f_10219_14771_14814(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 14771, 14814);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10219_14919_14939()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 14919, 14939);
                    return return_v;
                }


                int
                f_10219_14919_14965(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                symbol)
                {
                    this_param.SymbolDeclaredEvent((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 14919, 14965);
                    return 0;
                }


                int
                f_10219_15091_15121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 15091, 15121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10219, 13647, 15167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 13647, 15167);
            }
        }

        protected abstract ConstantValue MakeConstantValue(HashSet<SourceFieldSymbolWithSyntaxReference> dependencies, bool earlyDecodingWellKnownAttributes, DiagnosticBag diagnostics);

        static SourceFieldSymbolWithSyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10219, 5651, 15363);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10219, 5651, 15363);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10219, 5651, 15363);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10219, 5651, 15363);

        Microsoft.CodeAnalysis.ConstantValue
        f_10219_6042_6084()
        {
            var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 6042, 6084);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConstantValue
        f_10219_6138_6180()
        {
            var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10219, 6138, 6180);
            return return_v;
        }


        int
        f_10219_6406_6432(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 6406, 6432);
            return 0;
        }


        int
        f_10219_6447_6475(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 6447, 6475);
            return 0;
        }


        int
        f_10219_6490_6520(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10219, 6490, 6520);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10219_6366_6380_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10219, 6195, 6636);
            return return_v;
        }

    }
}
