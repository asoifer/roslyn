// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class ModifierUtils
    {
        internal static DeclarationModifiers MakeAndCheckNontypeMemberModifiers(
                    SyntaxTokenList modifiers,
                    DeclarationModifiers defaultAccess,
                    DeclarationModifiers allowedModifiers,
                    Location errorLocation,
                    DiagnosticBag diagnostics,
                    out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 391, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 744, 803);

                var
                result = modifiers.ToDeclarationModifiers(diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 817, 926);

                result = f_10234_826_925(result, allowedModifiers, errorLocation, diagnostics, modifiers, out modifierErrors);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 942, 1073) || true) && ((result & DeclarationModifiers.AccessibilityMask) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 942, 1073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1034, 1058);

                    result |= defaultAccess;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 942, 1073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1089, 1103);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 391, 1114);

                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10234_826_925(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxTokenList
                modifierTokens, out bool
                modifierErrors)
                {
                    var return_v = CheckModifiers(modifiers, allowedModifiers, errorLocation, diagnostics, (Microsoft.CodeAnalysis.SyntaxTokenList?)modifierTokens, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 826, 925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 391, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 391, 1114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DeclarationModifiers CheckModifiers(
                    DeclarationModifiers modifiers,
                    DeclarationModifiers allowedModifiers,
                    Location errorLocation,
                    DiagnosticBag diagnostics,
                    SyntaxTokenList? modifierTokens,
                    out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 1126, 2841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1461, 1484);

                modifierErrors = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1498, 1566);

                DeclarationModifiers
                errorModifiers = modifiers & ~allowedModifiers
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1580, 1639);

                DeclarationModifiers
                result = modifiers & allowedModifiers
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1655, 2534) || true) && (errorModifiers != DeclarationModifiers.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 1655, 2534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1739, 1810);

                        DeclarationModifiers
                        oneError = errorModifiers & ~(errorModifiers - 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1828, 1880);

                        f_10234_1828_1879(oneError != DeclarationModifiers.None);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1898, 1942);

                        errorModifiers = errorModifiers & ~oneError;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 1962, 2477);

                        switch (oneError)
                        {

                            case DeclarationModifiers.Partial:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 1962, 2477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2168, 2231);

                                f_10234_2168_2230(errorLocation, diagnostics, modifierTokens);
                                DynAbs.Tracing.TraceSender.TraceBreak(10234, 2257, 2263);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 1962, 2477);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 1962, 2477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2321, 2426);

                                f_10234_2321_2425(diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10234_2381_2424(oneError));
                                DynAbs.Tracing.TraceSender.TraceBreak(10234, 2452, 2458);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 1962, 2477);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2497, 2519);

                        modifierErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 1655, 2534);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10234, 1655, 2534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10234, 1655, 2534);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2550, 2800) || true) && ((result & DeclarationModifiers.PrivateProtected) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 2550, 2800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2641, 2785);

                    modifierErrors |= !f_10234_2660_2784(f_10234_2692_2716(errorLocation), MessageID.IDS_FeaturePrivateProtected, diagnostics, errorLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 2550, 2800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 2816, 2830);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 1126, 2841);

                int
                f_10234_1828_1879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 1828, 1879);
                    return 0;
                }


                int
                f_10234_2168_2230(Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxTokenList?
                modifierTokens)
                {
                    ReportPartialError(errorLocation, diagnostics, modifierTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 2168, 2230);
                    return 0;
                }


                string
                f_10234_2381_2424(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifier)
                {
                    var return_v = ConvertSingleModifierToSyntaxText(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 2381, 2424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_2321_2425(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 2321, 2425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10234_2692_2716(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 2692, 2716);
                    return return_v;
                }


                bool
                f_10234_2660_2784(Microsoft.CodeAnalysis.SyntaxTree?
                tree, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.CheckFeatureAvailability(tree, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 2660, 2784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 1126, 2841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 1126, 2841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportPartialError(Location errorLocation, DiagnosticBag diagnostics, SyntaxTokenList? modifierTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 2853, 3529);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3071, 3439) || true) && (modifierTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 3071, 3439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3131, 3213);

                    var
                    partialToken = modifierTokens.Value.FirstOrDefault(SyntaxKind.PartialKeyword)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3231, 3424) || true) && (partialToken != default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 3231, 3424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3300, 3376);

                        f_10234_3300_3375(diagnostics, ErrorCode.ERR_PartialMisplaced, partialToken.GetLocation());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3398, 3405);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 3231, 3424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 3071, 3439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3455, 3518);

                f_10234_3455_3517(
                            diagnostics, ErrorCode.ERR_PartialMisplaced, errorLocation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 2853, 3529);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_3300_3375(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 3300, 3375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_3455_3517(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 3455, 3517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 2853, 3529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 2853, 3529);
            }
        }

        internal static void ReportDefaultInterfaceImplementationModifiers(
                    bool hasBody,
                    DeclarationModifiers modifiers,
                    DeclarationModifiers defaultInterfaceImplementationModifiers,
                    Location errorLocation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 3541, 5304);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3857, 5293) || true) && (!hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10234, 3861, 3931) && (modifiers & defaultInterfaceImplementationModifiers) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 3857, 5293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 3965, 4071);

                    LanguageVersion
                    availableVersion = f_10234_4000_4070(((CSharpParseOptions)f_10234_4021_4053(f_10234_4021_4045(errorLocation))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4089, 4186);

                    LanguageVersion
                    requiredVersion = f_10234_4123_4185(MessageID.IDS_DefaultInterfaceImplementation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4204, 5278) || true) && (availableVersion < requiredVersion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 4204, 5278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4284, 4374);

                        DeclarationModifiers
                        errorModifiers = modifiers & defaultInterfaceImplementationModifiers
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4396, 4477);

                        var
                        requiredVersionArgument = f_10234_4426_4476(requiredVersion)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4499, 4565);

                        var
                        availableVersionArgument = f_10234_4530_4564(availableVersion)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4587, 5259) || true) && (errorModifiers != DeclarationModifiers.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 4587, 5259);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4687, 4758);

                                DeclarationModifiers
                                oneError = errorModifiers & ~(errorModifiers - 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4784, 4836);

                                f_10234_4784_4835(oneError != DeclarationModifiers.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4862, 4906);

                                errorModifiers = errorModifiers & ~oneError;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 4932, 5236);

                                f_10234_4932_5235(diagnostics, ErrorCode.ERR_DefaultInterfaceImplementationModifier, errorLocation, f_10234_5058_5101(oneError), availableVersionArgument, requiredVersionArgument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 4587, 5259);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10234, 4587, 5259);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10234, 4587, 5259);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 4204, 5278);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 3857, 5293);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 3541, 5304);

                Microsoft.CodeAnalysis.SyntaxTree?
                f_10234_4021_4045(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 4021, 4045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10234_4021_4053(Microsoft.CodeAnalysis.SyntaxTree?
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 4021, 4053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10234_4000_4070(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 4000, 4070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10234_4123_4185(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 4123, 4185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10234_4426_4476(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 4426, 4476);
                    return return_v;
                }


                string
                f_10234_4530_4564(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 4530, 4564);
                    return return_v;
                }


                int
                f_10234_4784_4835(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 4784, 4835);
                    return 0;
                }


                string
                f_10234_5058_5101(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifier)
                {
                    var return_v = ConvertSingleModifierToSyntaxText(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 5058, 5101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_4932_5235(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 4932, 5235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 3541, 5304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 3541, 5304);
            }
        }

        internal static DeclarationModifiers AdjustModifiersForAnInterfaceMember(DeclarationModifiers mods, bool hasBody, bool isExplicitInterfaceImplementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 5316, 7052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 5494, 6592) || true) && (isExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 5494, 6592);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 5565, 5709) || true) && ((mods & DeclarationModifiers.Abstract) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 5565, 5709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 5654, 5690);

                        mods |= DeclarationModifiers.Sealed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 5565, 5709);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 5494, 6592);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 5494, 6592);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 5743, 6592) || true) && ((mods & (DeclarationModifiers.Static | DeclarationModifiers.Private | DeclarationModifiers.Partial | DeclarationModifiers.Virtual | DeclarationModifiers.Abstract)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 5743, 6592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 5949, 5998);

                        f_10234_5949_5997(!isExplicitInterfaceImplementation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6018, 6577) || true) && (hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10234, 6022, 6106) || (mods & (DeclarationModifiers.Extern | DeclarationModifiers.Sealed)) != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6018, 6577);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6148, 6438) || true) && ((mods & DeclarationModifiers.Sealed) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6148, 6438);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6243, 6280);

                                mods |= DeclarationModifiers.Virtual;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6148, 6438);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6148, 6438);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6378, 6415);

                                mods &= ~DeclarationModifiers.Sealed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6148, 6438);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6018, 6577);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6018, 6577);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6520, 6558);

                            mods |= DeclarationModifiers.Abstract;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6018, 6577);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 5743, 6592);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 5494, 6592);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6608, 7013) || true) && ((mods & DeclarationModifiers.AccessibilityMask) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6608, 7013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6698, 6998) || true) && ((mods & DeclarationModifiers.Partial) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10234, 6702, 6782) && !isExplicitInterfaceImplementation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6698, 6998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6824, 6860);

                        mods |= DeclarationModifiers.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6698, 6998);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 6698, 6998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 6942, 6979);

                        mods |= DeclarationModifiers.Private;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6698, 6998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 6608, 7013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7029, 7041);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 5316, 7052);

                int
                f_10234_5949_5997(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 5949, 5997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 5316, 7052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 5316, 7052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ConvertSingleModifierToSyntaxText(DeclarationModifiers modifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 7064, 10252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7175, 10241);

                switch (modifier)
                {

                    case DeclarationModifiers.Abstract:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7282, 7337);

                        return f_10234_7289_7336(SyntaxKind.AbstractKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Sealed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7410, 7463);

                        return f_10234_7417_7462(SyntaxKind.SealedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Static:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7536, 7589);

                        return f_10234_7543_7588(SyntaxKind.StaticKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.New:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7659, 7709);

                        return f_10234_7666_7708(SyntaxKind.NewKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7782, 7835);

                        return f_10234_7789_7834(SyntaxKind.PublicKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 7911, 7967);

                        return f_10234_7918_7966(SyntaxKind.ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8042, 8097);

                        return f_10234_8049_8096(SyntaxKind.InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.ProtectedInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8181, 8293);

                        return f_10234_8188_8236(SyntaxKind.ProtectedKeyword) + " " + f_10234_8245_8292(SyntaxKind.InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8367, 8421);

                        return f_10234_8374_8420(SyntaxKind.PrivateKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.PrivateProtected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8504, 8615);

                        return f_10234_8511_8557(SyntaxKind.PrivateKeyword) + " " + f_10234_8566_8614(SyntaxKind.ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.ReadOnly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8690, 8745);

                        return f_10234_8697_8744(SyntaxKind.ReadOnlyKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Const:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8817, 8869);

                        return f_10234_8824_8868(SyntaxKind.ConstKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Volatile:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 8944, 8999);

                        return f_10234_8951_8998(SyntaxKind.VolatileKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Extern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9072, 9125);

                        return f_10234_9079_9124(SyntaxKind.ExternKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Partial:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9199, 9253);

                        return f_10234_9206_9252(SyntaxKind.PartialKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Unsafe:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9326, 9379);

                        return f_10234_9333_9378(SyntaxKind.UnsafeKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Fixed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9451, 9503);

                        return f_10234_9458_9502(SyntaxKind.FixedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Virtual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9577, 9631);

                        return f_10234_9584_9630(SyntaxKind.VirtualKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Override:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9706, 9761);

                        return f_10234_9713_9760(SyntaxKind.OverrideKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Async:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9833, 9885);

                        return f_10234_9840_9884(SyntaxKind.AsyncKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 9955, 10005);

                        return f_10234_9962_10004(SyntaxKind.RefKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    case DeclarationModifiers.Data:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10076, 10127);

                        return f_10234_10083_10126(SyntaxKind.DataKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 7175, 10241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10175, 10226);

                        throw f_10234_10181_10225(modifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 7175, 10241);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 7064, 10252);

                string
                f_10234_7289_7336(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7289, 7336);
                    return return_v;
                }


                string
                f_10234_7417_7462(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7417, 7462);
                    return return_v;
                }


                string
                f_10234_7543_7588(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7543, 7588);
                    return return_v;
                }


                string
                f_10234_7666_7708(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7666, 7708);
                    return return_v;
                }


                string
                f_10234_7789_7834(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7789, 7834);
                    return return_v;
                }


                string
                f_10234_7918_7966(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 7918, 7966);
                    return return_v;
                }


                string
                f_10234_8049_8096(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8049, 8096);
                    return return_v;
                }


                string
                f_10234_8188_8236(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8188, 8236);
                    return return_v;
                }


                string
                f_10234_8245_8292(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8245, 8292);
                    return return_v;
                }


                string
                f_10234_8374_8420(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8374, 8420);
                    return return_v;
                }


                string
                f_10234_8511_8557(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8511, 8557);
                    return return_v;
                }


                string
                f_10234_8566_8614(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8566, 8614);
                    return return_v;
                }


                string
                f_10234_8697_8744(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8697, 8744);
                    return return_v;
                }


                string
                f_10234_8824_8868(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8824, 8868);
                    return return_v;
                }


                string
                f_10234_8951_8998(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 8951, 8998);
                    return return_v;
                }


                string
                f_10234_9079_9124(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9079, 9124);
                    return return_v;
                }


                string
                f_10234_9206_9252(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9206, 9252);
                    return return_v;
                }


                string
                f_10234_9333_9378(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9333, 9378);
                    return return_v;
                }


                string
                f_10234_9458_9502(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9458, 9502);
                    return return_v;
                }


                string
                f_10234_9584_9630(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9584, 9630);
                    return return_v;
                }


                string
                f_10234_9713_9760(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9713, 9760);
                    return return_v;
                }


                string
                f_10234_9840_9884(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9840, 9884);
                    return return_v;
                }


                string
                f_10234_9962_10004(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 9962, 10004);
                    return return_v;
                }


                string
                f_10234_10083_10126(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 10083, 10126);
                    return return_v;
                }


                System.Exception
                f_10234_10181_10225(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 10181, 10225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 7064, 10252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 7064, 10252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DeclarationModifiers ToDeclarationModifier(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 10264, 12622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10363, 12611);

                switch (kind)
                {

                    case SyntaxKind.AbstractKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10463, 10500);

                        return DeclarationModifiers.Abstract;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.AsyncKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10569, 10603);

                        return DeclarationModifiers.Async;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.SealedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10673, 10708);

                        return DeclarationModifiers.Sealed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.StaticKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10778, 10813);

                        return DeclarationModifiers.Static;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.NewKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10880, 10912);

                        return DeclarationModifiers.New;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.PublicKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 10982, 11017);

                        return DeclarationModifiers.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.ProtectedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11090, 11128);

                        return DeclarationModifiers.Protected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.InternalKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11200, 11237);

                        return DeclarationModifiers.Internal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.PrivateKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11308, 11344);

                        return DeclarationModifiers.Private;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.ExternKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11414, 11449);

                        return DeclarationModifiers.Extern;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.ReadOnlyKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11521, 11558);

                        return DeclarationModifiers.ReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.PartialKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11629, 11665);

                        return DeclarationModifiers.Partial;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.UnsafeKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11735, 11770);

                        return DeclarationModifiers.Unsafe;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.VirtualKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11841, 11877);

                        return DeclarationModifiers.Virtual;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.OverrideKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 11949, 11986);

                        return DeclarationModifiers.Override;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.ConstKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12055, 12089);

                        return DeclarationModifiers.Const;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.FixedKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12158, 12192);

                        return DeclarationModifiers.Fixed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.VolatileKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12264, 12301);

                        return DeclarationModifiers.Volatile;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.RefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12368, 12400);

                        return DeclarationModifiers.Ref;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    case SyntaxKind.DataKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12468, 12501);

                        return DeclarationModifiers.Data;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 10363, 12611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12549, 12596);

                        throw f_10234_12555_12595(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 10363, 12611);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 10264, 12622);

                System.Exception
                f_10234_12555_12595(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 12555, 12595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 10264, 12622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 10264, 12622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DeclarationModifiers ToDeclarationModifiers(
                    this SyntaxTokenList modifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 12634, 14206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12789, 12828);

                var
                result = DeclarationModifiers.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12842, 12871);

                bool
                seenNoDuplicates = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12885, 12927);

                bool
                seenNoAccessibilityDuplicates = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 12943, 13338);
                    foreach (var modifier in f_10234_12968_12977_I(modifiers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 12943, 13338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13011, 13087);

                        DeclarationModifiers
                        one = f_10234_13038_13086(modifier.ContextualKind())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13107, 13289);

                        f_10234_13107_13288(modifier, one, result, ref seenNoDuplicates, ref seenNoAccessibilityDuplicates, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13309, 13323);

                        result |= one;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 12943, 13338);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10234, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10234, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13354, 14165);

                switch (result & DeclarationModifiers.AccessibilityMask)
                {

                    case DeclarationModifiers.Protected | DeclarationModifiers.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 13354, 14165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13639, 13689);

                        result &= ~DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 13711, 13760);

                        result |= DeclarationModifiers.ProtectedInternal;
                        DynAbs.Tracing.TraceSender.TraceBreak(10234, 13782, 13788);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 13354, 14165);

                    case DeclarationModifiers.Private | DeclarationModifiers.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 13354, 14165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14002, 14052);

                        result &= ~DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14074, 14122);

                        result |= DeclarationModifiers.PrivateProtected;
                        DynAbs.Tracing.TraceSender.TraceBreak(10234, 14144, 14150);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 13354, 14165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14181, 14195);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 12634, 14206);

                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10234_13038_13086(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = ToDeclarationModifier(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 13038, 13086);
                    return return_v;
                }


                int
                f_10234_13107_13288(Microsoft.CodeAnalysis.SyntaxToken
                modifierToken, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifierKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allModifiers, ref bool
                seenNoDuplicates, ref bool
                seenNoAccessibilityDuplicates, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportDuplicateModifiers(modifierToken, modifierKind, allModifiers, ref seenNoDuplicates, ref seenNoAccessibilityDuplicates, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 13107, 13288);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10234_12968_12977_I(Microsoft.CodeAnalysis.SyntaxTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 12968, 12977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 12634, 14206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 12634, 14206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportDuplicateModifiers(
                    SyntaxToken modifierToken,
                    DeclarationModifiers modifierKind,
                    DeclarationModifiers allModifiers,
                    ref bool seenNoDuplicates,
                    ref bool seenNoAccessibilityDuplicates,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 14218, 14980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14557, 14969) || true) && ((allModifiers & modifierKind) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 14557, 14969);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14629, 14954) || true) && (seenNoDuplicates)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 14629, 14954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14691, 14888);

                        f_10234_14691_14887(diagnostics, ErrorCode.ERR_DuplicateModifier, modifierToken.GetLocation(), f_10234_14845_14886(modifierToken.Kind()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 14910, 14935);

                        seenNoDuplicates = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 14629, 14954);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 14557, 14969);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 14218, 14980);

                string
                f_10234_14845_14886(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 14845, 14886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_14691_14887(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 14691, 14887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 14218, 14980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 14218, 14980);
            }
        }

        internal static CSDiagnosticInfo CheckAccessibility(DeclarationModifiers modifiers, Symbol symbol, bool isExplicitInterfaceImplementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 14992, 16337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 15155, 15371) || true) && (!f_10234_15160_15191(modifiers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 15155, 15371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 15293, 15356);

                    return f_10234_15300_15355(ErrorCode.ERR_BadMemberProtection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 15155, 15371);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 15387, 16298) || true) && (!isExplicitInterfaceImplementation && (DynAbs.Tracing.TraceSender.Expression_True(10234, 15391, 15531) && (f_10234_15447_15458(symbol) != SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10234, 15447, 15530) || (modifiers & DeclarationModifiers.Partial) == 0))) && (DynAbs.Tracing.TraceSender.Expression_True(10234, 15391, 15598) && (modifiers & DeclarationModifiers.Static) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 15387, 16298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 15632, 16283);

                    switch (modifiers & DeclarationModifiers.AccessibilityMask)
                    {

                        case DeclarationModifiers.Protected:
                        case DeclarationModifiers.ProtectedInternal:
                        case DeclarationModifiers.PrivateProtected:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 15632, 16283);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 15927, 16232) || true) && (f_10234_15931_15965_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10234_15931_15952(symbol), 10234, 15931, 15965)?.IsInterface) == true && (DynAbs.Tracing.TraceSender.Expression_True(10234, 15931, 16049) && f_10234_15977_16049_M(!f_10234_15978_16003(symbol).RuntimeSupportsDefaultInterfaceImplementation)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 15927, 16232);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16107, 16205);

                                return f_10234_16114_16204(ErrorCode.ERR_RuntimeDoesNotSupportProtectedAccessForInterfaceMember);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 15927, 16232);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10234, 16258, 16264);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 15632, 16283);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 15387, 16298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16314, 16326);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 14992, 16337);

                bool
                f_10234_15160_15191(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers)
                {
                    var return_v = IsValidAccessibility(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 15160, 15191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_15300_15355(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 15300, 15355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10234_15447_15458(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 15447, 15458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10234_15931_15952(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 15931, 15952);
                    return return_v;
                }


                bool?
                f_10234_15931_15965_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 15931, 15965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10234_15978_16003(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 15978, 16003);
                    return return_v;
                }


                bool
                f_10234_15977_16049_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10234, 15977, 16049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10234_16114_16204(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10234, 16114, 16204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 14992, 16337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 14992, 16337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Accessibility EffectiveAccessibility(DeclarationModifiers modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 16483, 17738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16592, 17727);

                switch (modifiers & DeclarationModifiers.AccessibilityMask)
                {

                    case DeclarationModifiers.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16737, 16772);

                        return Accessibility.NotApplicable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16887, 16916);

                        return Accessibility.Private;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 16992, 17023);

                        return Accessibility.Protected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17098, 17128);

                        return Accessibility.Internal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17201, 17229);

                        return Accessibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.ProtectedInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17313, 17354);

                        return Accessibility.ProtectedOrInternal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    case DeclarationModifiers.PrivateProtected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17437, 17479);

                        return Accessibility.ProtectedAndInternal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 16592, 17727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17684, 17712);

                        return Accessibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 16592, 17727);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 16483, 17738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 16483, 17738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 16483, 17738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidAccessibility(DeclarationModifiers modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10234, 17750, 18584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 17848, 18573);

                switch (modifiers & DeclarationModifiers.AccessibilityMask)
                {

                    case DeclarationModifiers.None:
                    case DeclarationModifiers.Private:
                    case DeclarationModifiers.Protected:
                    case DeclarationModifiers.Internal:
                    case DeclarationModifiers.Public:
                    case DeclarationModifiers.ProtectedInternal:
                    case DeclarationModifiers.PrivateProtected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 17848, 18573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 18326, 18338);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 17848, 18573);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10234, 17848, 18573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10234, 18545, 18558);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10234, 17848, 18573);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10234, 17750, 18584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10234, 17750, 18584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 17750, 18584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModifierUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10234, 339, 18591);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10234, 339, 18591);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10234, 339, 18591);
        }

    }
}
