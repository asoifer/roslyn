// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Symbol
    {
        public virtual ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 886, 1280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 977, 1025);

                f_10055_977_1024(!(this is IAttributeTargetSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 1220, 1269);

                return ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 886, 1280);

                int
                f_10055_977_1024(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 977, 1024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 886, 1280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 886, 1280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual AttributeTargets GetAttributeTarget()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 1596, 4061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 1675, 4025);

                switch (f_10055_1683_1692(this))
                {

                    case SymbolKind.Assembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 1773, 1806);

                        return AttributeTargets.Assembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 1870, 1900);

                        return AttributeTargets.Field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 1965, 1997);

                        var
                        method = (MethodSymbol)this
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2019, 2368);

                        switch (f_10055_2027_2044(method))
                        {

                            case MethodKind.Constructor:
                            case MethodKind.StaticConstructor:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2019, 2368);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2212, 2248);

                                return AttributeTargets.Constructor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2019, 2368);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2019, 2368);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2314, 2345);

                                return AttributeTargets.Method;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2019, 2368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2436, 2474);

                        var
                        namedType = (NamedTypeSymbol)this
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2496, 3474);

                        switch (f_10055_2504_2522(namedType))
                        {

                            case TypeKind.Class:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2622, 2652);

                                return AttributeTargets.Class;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.Delegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2733, 2766);

                                return AttributeTargets.Delegate;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.Enum:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2843, 2872);

                                return AttributeTargets.Enum;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.Interface:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 2954, 2988);

                                return AttributeTargets.Interface;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.Struct:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3067, 3098);

                                return AttributeTargets.Struct;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3184, 3225);

                                return AttributeTargets.GenericParameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);

                            case TypeKind.Submission:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 2496, 3474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3390, 3451);

                                throw f_10055_3396_3450(f_10055_3431_3449(namedType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 2496, 3474);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10055, 3496, 3502);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.NetModule:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3570, 3601);

                        return AttributeTargets.Module;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3669, 3703);

                        return AttributeTargets.Parameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3770, 3803);

                        return AttributeTargets.Property;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3867, 3897);

                        return AttributeTargets.Event;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 1675, 4025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 3969, 4010);

                        return AttributeTargets.GenericParameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 1675, 4025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 4041, 4050);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 1596, 4061);

                Microsoft.CodeAnalysis.SymbolKind
                f_10055_1683_1692(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 1683, 1692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10055_2027_2044(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 2027, 2044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10055_2504_2522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 2504, 2522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10055_3431_3449(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 3431, 3449);
                    return return_v;
                }


                System.Exception
                f_10055_3396_3450(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 3396, 3450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 1596, 4061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 1596, 4061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void EarlyDecodeWellKnownAttributeType(NamedTypeSymbol attributeType, AttributeSyntax attributeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 4635, 4776);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 4635, 4776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 4635, 4776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 4635, 4776);
            }
        }

        internal virtual void PostEarlyDecodeWellKnownAttributeTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 5057, 5141);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 5057, 5141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 5057, 5141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 5057, 5141);
            }
        }

        internal virtual CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 5740, 5992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 5969, 5981);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 5740, 5992);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 5740, 5992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 5740, 5992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(
                    ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments,
                    out CSharpAttributeData attributeData,
                    out ObsoleteAttributeData obsoleteData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10055, 6004, 7842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6361, 6396);

                var
                type = arguments.AttributeType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6410, 6449);

                var
                syntax = arguments.AttributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6465, 6492);

                ObsoleteAttributeKind
                kind
                = default(ObsoleteAttributeKind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6506, 7273) || true) && (f_10055_6510_6606(type, syntax, AttributeDescription.ObsoleteAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6506, 7273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6640, 6678);

                    kind = ObsoleteAttributeKind.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6506, 7273);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6506, 7273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6712, 7273) || true) && (f_10055_6716_6814(type, syntax, AttributeDescription.DeprecatedAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6712, 7273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6848, 6888);

                        kind = ObsoleteAttributeKind.Deprecated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6712, 7273);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6712, 7273);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 6922, 7273) || true) && (f_10055_6926_7026(type, syntax, AttributeDescription.ExperimentalAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6922, 7273);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7060, 7102);

                            kind = ObsoleteAttributeKind.Experimental;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6922, 7273);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 6922, 7273);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7168, 7188);

                            obsoleteData = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7206, 7227);

                            attributeData = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7245, 7258);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6922, 7273);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6712, 7273);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 6506, 7273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7289, 7312);

                bool
                hasAnyDiagnostics
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7326, 7409);

                attributeData = f_10055_7342_7408(arguments.Binder, syntax, type, out hasAnyDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7423, 7805) || true) && (f_10055_7427_7451_M(!attributeData.HasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 7423, 7805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7485, 7544);

                    obsoleteData = f_10055_7500_7543(attributeData, kind);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7562, 7665) || true) && (hasAnyDiagnostics)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 7562, 7665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7625, 7646);

                        attributeData = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 7562, 7665);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 7423, 7805);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 7423, 7805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7731, 7751);

                    obsoleteData = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7769, 7790);

                    attributeData = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 7423, 7805);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 7819, 7831);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10055, 6004, 7842);

                bool
                f_10055_6510_6606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 6510, 6606);
                    return return_v;
                }


                bool
                f_10055_6716_6814(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 6716, 6814);
                    return return_v;
                }


                bool
                f_10055_6926_7026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 6926, 7026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10055_7342_7408(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 7342, 7408);
                    return return_v;
                }


                bool
                f_10055_7427_7451_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 7427, 7451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10055_7500_7543(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.ObsoleteAttributeKind
                kind)
                {
                    var return_v = this_param.DecodeObsoleteAttribute(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 7500, 7543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 6004, 7842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 6004, 7842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 8701, 8875);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 8701, 8875);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 8701, 8875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 8701, 8875);
            }
        }

        internal virtual void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 10366, 10642);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 10366, 10642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 10366, 10642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 10366, 10642);
            }
        }

        internal bool LoadAndValidateAttributes(
                    OneOrMany<SyntaxList<AttributeListSyntax>> attributesSyntaxLists,
                    ref CustomAttributesBag<CSharpAttributeData> lazyCustomAttributesBag,
                    AttributeLocation symbolPart = AttributeLocation.None,
                    bool earlyDecodingOnly = false,
                    Binder binderOpt = null,
                    Func<AttributeSyntax, bool> attributeMatchesOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 14224, 19630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 14671, 14717);

                var
                diagnostics = f_10055_14689_14716()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 14731, 14775);

                var
                compilation = f_10055_14749_14774(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 14791, 14822);

                ImmutableArray<Binder>
                binders
                = default(ImmutableArray<Binder>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 14836, 15018);

                ImmutableArray<AttributeSyntax>
                attributesToBind = f_10055_14887_15017(this, attributesSyntaxLists, symbolPart, diagnostics, compilation, attributeMatchesOpt, binderOpt, out binders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15032, 15074);

                f_10055_15032_15073(f_10055_15045_15072_M(!attributesToBind.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15090, 15142);

                ImmutableArray<CSharpAttributeData>
                boundAttributes
                = default(ImmutableArray<CSharpAttributeData>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15156, 15202);

                WellKnownAttributeData
                wellKnownAttributeData
                = default(WellKnownAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15218, 18713) || true) && (attributesToBind.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 15218, 18713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15278, 15311);

                    f_10055_15278_15310(f_10055_15291_15309_M(!binders.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15329, 15385);

                    f_10055_15329_15384(binders.Length == attributesToBind.Length);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15510, 15717) || true) && (lazyCustomAttributesBag == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 15510, 15717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15587, 15698);

                        f_10055_15587_15697(ref lazyCustomAttributesBag, f_10055_15644_15690(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 15510, 15717);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15810, 15861);

                    int
                    totalAttributesCount = attributesToBind.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15879, 15949);

                    var
                    attributeTypesBuilder = new NamedTypeSymbol[totalAttributesCount]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 15969, 16064);

                    f_10055_15969_16063(binders, attributesToBind, this, attributeTypesBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16082, 16178);

                    ImmutableArray<NamedTypeSymbol>
                    boundAttributeTypes = f_10055_16136_16177(attributeTypesBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16198, 16277);

                    f_10055_16198_16276(
                                    this, boundAttributeTypes, attributesToBind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16295, 16341);

                    f_10055_16295_16340(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16434, 16504);

                    var
                    attributesBuilder = new CSharpAttributeData[totalAttributesCount]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16594, 16749);

                    EarlyWellKnownAttributeData
                    earlyData = f_10055_16634_16748(this, binders, boundAttributeTypes, attributesToBind, symbolPart, attributesBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 16767, 16851);

                    f_10055_16767_16850(!f_10055_16781_16849(attributesBuilder, (attr) => attr != null && attr.HasErrors));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17027, 17100);

                    f_10055_17027_17099(
                                    // Store data decoded from early bound well-known attributes.
                                    // TODO: what if this succeeds on another thread, not ours?
                                    lazyCustomAttributesBag, earlyData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17120, 17273) || true) && (earlyDecodingOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 17120, 17273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17183, 17202);

                        f_10055_17183_17201(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17241, 17254);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 17120, 17273);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17330, 17431);

                    f_10055_17330_17430(binders, attributesToBind, boundAttributeTypes, attributesBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17449, 17505);

                    boundAttributes = f_10055_17467_17504(attributesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17582, 17641);

                    f_10055_17582_17640(!boundAttributes.Any((attr) => attr == null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 17750, 17900);

                    wellKnownAttributeData = f_10055_17775_17899(this, binders, attributesToBind, boundAttributes, diagnostics, symbolPart);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18084, 18165);

                    f_10055_18084_18164(
                                    // Store data decoded from remaining well-known attributes.
                                    // TODO: what if this succeeds on another thread but not this thread?
                                    lazyCustomAttributesBag, wellKnownAttributeData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 15218, 18713);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 15218, 18713);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18199, 18713) || true) && (earlyDecodingOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 18199, 18713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18254, 18273);

                        f_10055_18254_18272(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18308, 18321);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 18199, 18713);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 18199, 18713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18387, 18447);

                        boundAttributes = ImmutableArray<CSharpAttributeData>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18465, 18495);

                        wellKnownAttributeData = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18513, 18634);

                        f_10055_18513_18633(ref lazyCustomAttributesBag, f_10055_18570_18626(), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18652, 18698);

                        f_10055_18652_18697(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 18199, 18713);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 15218, 18713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18729, 18848);

                f_10055_18729_18847(
                            this, boundAttributes, attributesToBind, diagnostics, symbolPart, wellKnownAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18911, 18957);

                bool
                lazyAttributesStoredOnThisThread = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 18971, 19469) || true) && (f_10055_18975_19029(lazyCustomAttributesBag, boundAttributes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 18971, 19469);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19063, 19268) || true) && (attributeMatchesOpt is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 19063, 19268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19136, 19188);

                        f_10055_19136_19187(this, boundAttributes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19210, 19249);

                        f_10055_19210_19248(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 19063, 19268);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19286, 19326);

                    lazyAttributesStoredOnThisThread = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19344, 19454) || true) && (f_10055_19348_19379(lazyCustomAttributesBag))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 19344, 19454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19381, 19454);

                        lazyCustomAttributesBag = CustomAttributesBag<CSharpAttributeData>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 19344, 19454);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 18971, 19469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19485, 19532);

                f_10055_19485_19531(f_10055_19498_19530(lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19546, 19565);

                f_10055_19546_19564(diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19579, 19619);

                return lazyAttributesStoredOnThisThread;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 14224, 19630);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10055_14689_14716()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 14689, 14716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10055_14749_14774(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 14749, 14774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10055_14887_15017(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributeDeclarationSyntaxLists, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, bool>?
                attributeMatchesOpt, Microsoft.CodeAnalysis.CSharp.Binder?
                rootBinderOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                binders)
                {
                    var return_v = this_param.GetAttributesToBind(attributeDeclarationSyntaxLists, symbolPart, diagnostics, compilation, attributeMatchesOpt, rootBinderOpt, out binders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 14887, 15017);
                    return return_v;
                }


                bool
                f_10055_15045_15072_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 15045, 15072);
                    return return_v;
                }


                int
                f_10055_15032_15073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15032, 15073);
                    return 0;
                }


                bool
                f_10055_15291_15309_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 15291, 15309);
                    return return_v;
                }


                int
                f_10055_15278_15310(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15278, 15310);
                    return 0;
                }


                int
                f_10055_15329_15384(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15329, 15384);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_15644_15690()
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15644, 15690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                f_10055_15587_15697(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15587, 15697);
                    return return_v;
                }


                int
                f_10055_15969_16063(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                binders, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                attributesToBind, Microsoft.CodeAnalysis.CSharp.Symbol
                ownerSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                boundAttributeTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    Binder.BindAttributeTypes(binders, attributesToBind, ownerSymbol, boundAttributeTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 15969, 16063);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10055_16136_16177(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16136, 16177);
                    return return_v;
                }


                int
                f_10055_16198_16276(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                attributeTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                attributeSyntaxList)
                {
                    this_param.EarlyDecodeWellKnownAttributeTypes(attributeTypes, attributeSyntaxList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16198, 16276);
                    return 0;
                }


                int
                f_10055_16295_16340(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.PostEarlyDecodeWellKnownAttributeTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16295, 16340);
                    return 0;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10055_16634_16748(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                binders, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                boundAttributeTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                attributesToBind, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[]
                boundAttributesBuilder)
                {
                    var return_v = this_param.EarlyDecodeWellKnownAttributes(binders, boundAttributeTypes, attributesToBind, symbolPart, boundAttributesBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16634, 16748);
                    return return_v;
                }


                bool
                f_10055_16781_16849(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[]
                sequence, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, bool>
                predicate)
                {
                    var return_v = sequence.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16781, 16849);
                    return return_v;
                }


                int
                f_10055_16767_16850(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 16767, 16850);
                    return 0;
                }


                bool
                f_10055_17027_17099(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                data)
                {
                    var return_v = this_param.SetEarlyDecodedWellKnownAttributeData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17027, 17099);
                    return return_v;
                }


                int
                f_10055_17183_17201(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17183, 17201);
                    return 0;
                }


                int
                f_10055_17330_17430(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                binders, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                attributesToBind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                boundAttributeTypes, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[]
                attributesBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    Binder.GetAttributes(binders, attributesToBind, boundAttributeTypes, attributesBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17330, 17430);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_17467_17504(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17467, 17504);
                    return return_v;
                }


                int
                f_10055_17582_17640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17582, 17640);
                    return 0;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10055_17775_17899(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                binders, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                attributeSyntaxList, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                boundAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart)
                {
                    var return_v = this_param.ValidateAttributeUsageAndDecodeWellKnownAttributes(binders, attributeSyntaxList, boundAttributes, diagnostics, symbolPart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 17775, 17899);
                    return return_v;
                }


                bool
                f_10055_18084_18164(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.WellKnownAttributeData
                data)
                {
                    var return_v = this_param.SetDecodedWellKnownAttributeData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18084, 18164);
                    return return_v;
                }


                int
                f_10055_18254_18272(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18254, 18272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_18570_18626()
                {
                    var return_v = CustomAttributesBag<CSharpAttributeData>.WithEmptyData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18570, 18626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_18513_18633(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18513, 18633);
                    return return_v;
                }


                int
                f_10055_18652_18697(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.PostEarlyDecodeWellKnownAttributeTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18652, 18697);
                    return 0;
                }


                int
                f_10055_18729_18847(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                boundAttributes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                allAttributeSyntaxNodes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.WellKnownAttributeData?
                decodedData)
                {
                    this_param.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18729, 18847);
                    return 0;
                }


                bool
                f_10055_18975_19029(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                newCustomAttributes)
                {
                    var return_v = this_param.SetAttributes(newCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 18975, 19029);
                    return return_v;
                }


                int
                f_10055_19136_19187(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                boundAttributes)
                {
                    this_param.RecordPresenceOfBadAttributes(boundAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19136, 19187);
                    return 0;
                }


                int
                f_10055_19210_19248(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19210, 19248);
                    return 0;
                }


                bool
                f_10055_19348_19379(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 19348, 19379);
                    return return_v;
                }


                bool
                f_10055_19498_19530(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 19498, 19530);
                    return return_v;
                }


                int
                f_10055_19485_19531(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19485, 19531);
                    return 0;
                }


                int
                f_10055_19546_19564(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19546, 19564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 14224, 19630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 14224, 19630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RecordPresenceOfBadAttributes(ImmutableArray<CSharpAttributeData> boundAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 19642, 20190);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19762, 20179);
                    foreach (var attribute in f_10055_19788_19803_I(boundAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 19762, 20179);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19837, 20164) || true) && (f_10055_19841_19860(attribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 19837, 20164);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19902, 19960);

                            CSharpCompilation
                            compilation = f_10055_19934_19959(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 19982, 20016);

                            f_10055_19982_20015(compilation != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 20038, 20117);

                            f_10055_20038_20116(((SourceModuleSymbol)f_10055_20059_20083(compilation)));
                            DynAbs.Tracing.TraceSender.TraceBreak(10055, 20139, 20145);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 19837, 20164);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 19762, 20179);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 418);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 19642, 20190);

                bool
                f_10055_19841_19860(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 19841, 19860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10055_19934_19959(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 19934, 19959);
                    return return_v;
                }


                int
                f_10055_19982_20015(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19982, 20015);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10055_20059_20083(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 20059, 20083);
                    return return_v;
                }


                int
                f_10055_20038_20116(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    this_param.RecordPresenceOfBadAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 20038, 20116);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_19788_19803_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 19788, 19803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 19642, 20190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 19642, 20190);
            }
        }

        private ImmutableArray<AttributeSyntax> GetAttributesToBind(
                    OneOrMany<SyntaxList<AttributeListSyntax>> attributeDeclarationSyntaxLists,
                    AttributeLocation symbolPart,
                    DiagnosticBag diagnostics,
                    CSharpCompilation compilation,
                    Func<AttributeSyntax, bool> attributeMatchesOpt,
                    Binder rootBinderOpt,
                    out ImmutableArray<Binder> binders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 20744, 24694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21191, 21242);

                var
                attributeTarget = (IAttributeTargetSymbol)this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21258, 21309);

                ArrayBuilder<AttributeSyntax>
                syntaxBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21323, 21366);

                ArrayBuilder<Binder>
                bindersBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21380, 21410);

                int
                attributesToBindCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21435, 21448);

                    for (int
        listIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21426, 24319) || true) && (listIndex < attributeDeclarationSyntaxLists.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21501, 21512)
        , listIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 21426, 24319))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 21426, 24319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21546, 21626);

                        var
                        attributeDeclarationSyntaxList = attributeDeclarationSyntaxLists[listIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21644, 24304) || true) && (attributeDeclarationSyntaxList.Any())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 21644, 24304);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21726, 21764);

                            int
                            prevCount = attributesToBindCount
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 21786, 23407);
                                foreach (var attributeDeclarationSyntax in f_10055_21829_21859_I(attributeDeclarationSyntaxList))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 21786, 23407);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22041, 23384) || true) && (f_10055_22045_22142(attributeTarget, symbolPart, f_10055_22095_22128(attributeDeclarationSyntax), diagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 22041, 23384);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22200, 22452) || true) && (syntaxBuilder == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 22200, 22452);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22291, 22343);

                                            syntaxBuilder = f_10055_22307_22342();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22377, 22421);

                                            bindersBuilder = f_10055_22394_22420();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 22200, 22452);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22484, 22545);

                                        var
                                        attributesToBind = f_10055_22507_22544(attributeDeclarationSyntax)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22575, 23357) || true) && (attributeMatchesOpt is null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 22575, 23357);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22672, 22713);

                                            f_10055_22672_22712(syntaxBuilder, attributesToBind);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22747, 22795);

                                            attributesToBindCount += attributesToBind.Count;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 22575, 23357);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 22575, 23357);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 22925, 23326);
                                                foreach (var attribute in f_10055_22951_22967_I(attributesToBind))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 22925, 23326);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23041, 23291) || true) && (f_10055_23045_23075(attributeMatchesOpt, attribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 23041, 23291);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23157, 23186);

                                                        f_10055_23157_23185(syntaxBuilder, attribute);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23228, 23252);

                                                        attributesToBindCount++;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 23041, 23291);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 22925, 23326);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 402);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 402);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 22575, 23357);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 22041, 23384);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 21786, 23407);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 1622);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 1622);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23431, 24285) || true) && (attributesToBindCount != prevCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 23431, 24285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23519, 23577);

                                f_10055_23519_23576(attributeDeclarationSyntaxList.Node != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23603, 23640);

                                f_10055_23603_23639(bindersBuilder != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23668, 23732);

                                var
                                syntaxTree = f_10055_23685_23731(attributeDeclarationSyntaxList.Node)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23758, 23876);

                                var
                                binder = rootBinderOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10055, 23771, 23875) ?? f_10055_23788_23875(f_10055_23788_23828(compilation, syntaxTree), attributeDeclarationSyntaxList.Node))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23904, 23957);

                                binder = f_10055_23913_23956(binder, this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 23983, 24064);

                                f_10055_23983_24063(f_10055_23996_24023_M(!binder.InAttributeArgument), "Possible cycle in attribute binding");
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24101, 24106);

                                    for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24092, 24262) || true) && (i < attributesToBindCount - prevCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24147, 24150)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 24092, 24262))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 24092, 24262);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24208, 24235);

                                        f_10055_24208_24234(bindersBuilder, binder);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 171);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 171);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 23431, 24285);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 21644, 24304);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 2894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 2894);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24335, 24683) || true) && (syntaxBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 24335, 24683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24394, 24440);

                    binders = f_10055_24404_24439(bindersBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24458, 24500);

                    return f_10055_24465_24499(syntaxBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 24335, 24683);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 24335, 24683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24566, 24605);

                    binders = ImmutableArray<Binder>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24623, 24668);

                    return ImmutableArray<AttributeSyntax>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 24335, 24683);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 20744, 24694);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax?
                f_10055_22095_22128(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 22095, 22128);
                    return return_v;
                }


                bool
                f_10055_22045_22142(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                attributeTarget, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax?
                targetOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = MatchAttributeTarget(attributeTarget, symbolPart, targetOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 22045, 22142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10055_22307_22342()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 22307, 22342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>
                f_10055_22394_22420()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 22394, 22420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10055_22507_22544(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 22507, 22544);
                    return return_v;
                }


                int
                f_10055_22672_22712(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                this_param, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 22672, 22712);
                    return 0;
                }


                bool
                f_10055_23045_23075(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23045, 23075);
                    return return_v;
                }


                int
                f_10055_23157_23185(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23157, 23185);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10055_22951_22967_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 22951, 22967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10055_21829_21859_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 21829, 21859);
                    return return_v;
                }


                int
                f_10055_23519_23576(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23519, 23576);
                    return 0;
                }


                int
                f_10055_23603_23639(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23603, 23639);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10055_23685_23731(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 23685, 23731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10055_23788_23828(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23788, 23828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10055_23788_23875(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23788, 23875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder
                f_10055_23913_23956(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder(enclosing, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23913, 23956);
                    return return_v;
                }


                bool
                f_10055_23996_24023_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 23996, 24023);
                    return return_v;
                }


                int
                f_10055_23983_24063(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 23983, 24063);
                    return 0;
                }


                int
                f_10055_24208_24234(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 24208, 24234);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Binder>
                f_10055_24404_24439(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>?
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 24404, 24439);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                f_10055_24465_24499(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 24465, 24499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 20744, 24694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 20744, 24694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MatchAttributeTarget(IAttributeTargetSymbol attributeTarget, AttributeLocation symbolPart, AttributeTargetSpecifierSyntax targetOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10055, 24706, 27902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 24910, 24983);

                IAttributeTargetSymbol
                attributesOwner = f_10055_24951_24982(attributeTarget)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25185, 25290);

                bool
                isOwner = symbolPart == AttributeLocation.None && (DynAbs.Tracing.TraceSender.Expression_True(10055, 25200, 25289) && f_10055_25240_25289(attributesOwner, attributeTarget))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25306, 25499) || true) && (targetOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 25306, 25499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25469, 25484);

                    return isOwner;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 25306, 25499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25515, 25592);

                AttributeLocation
                allowedTargets = f_10055_25550_25591(attributesOwner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25608, 25676);

                AttributeLocation
                explicitTarget = f_10055_25643_25675(targetOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25690, 26237) || true) && (explicitTarget == AttributeLocation.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 25690, 26237);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25822, 26189) || true) && (isOwner)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 25822, 26189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 25987, 26170);

                        f_10055_25987_26169(                    //NOTE: ValueText so that we accept targets like "@return", to match dev10 (DevDiv #2591).
                                            diagnostics, ErrorCode.WRN_InvalidAttributeLocation, targetOpt.Identifier.GetLocation(), targetOpt.Identifier.ValueText, f_10055_26136_26168(allowedTargets));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 25822, 26189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26209, 26222);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 25690, 26237);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26253, 27618) || true) && ((explicitTarget & allowedTargets) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26253, 27618);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26382, 27570) || true) && (isOwner)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26382, 27570);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26435, 27551) || true) && (allowedTargets == AttributeLocation.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26435, 27551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26529, 27233);

                            switch (f_10055_26537_26577(attributeTarget))
                            {

                                case AttributeLocation.Assembly:
                                case AttributeLocation.Module:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26529, 27233);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 26851, 26945);

                                    f_10055_26851_26944(                                // global attributes are disallowed in interactive code:
                                                                    diagnostics, ErrorCode.ERR_GlobalAttributesNotAllowed, targetOpt.Identifier.GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceBreak(10055, 26979, 26985);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26529, 27233);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26529, 27233);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27123, 27206);

                                    throw f_10055_27129_27205(f_10055_27164_27204(attributeTarget));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26529, 27233);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26435, 27551);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 26435, 27551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27331, 27528);

                            f_10055_27331_27527(diagnostics, ErrorCode.WRN_AttributeLocationOnBadDeclaration, targetOpt.Identifier.GetLocation(), targetOpt.Identifier.ToString(), f_10055_27494_27526(allowedTargets));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26435, 27551);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26382, 27570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27590, 27603);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 26253, 27618);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27634, 27891) || true) && (symbolPart == AttributeLocation.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 27634, 27891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27708, 27774);

                    return explicitTarget == f_10055_27733_27773(attributeTarget);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 27634, 27891);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 27634, 27891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 27840, 27876);

                    return explicitTarget == symbolPart;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 27634, 27891);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10055, 24706, 27902);

                Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                f_10055_24951_24982(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                this_param)
                {
                    var return_v = this_param.AttributesOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 24951, 24982);
                    return return_v;
                }


                bool
                f_10055_25240_25289(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 25240, 25289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10055_25550_25591(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                this_param)
                {
                    var return_v = this_param.AllowedAttributeLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 25550, 25591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10055_25643_25675(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.GetAttributeLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 25643, 25675);
                    return return_v;
                }


                string
                f_10055_26136_26168(Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                locations)
                {
                    var return_v = locations.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 26136, 26168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_25987_26169(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 25987, 26169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10055_26537_26577(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                this_param)
                {
                    var return_v = this_param.DefaultAttributeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 26537, 26577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_26851_26944(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 26851, 26944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10055_27164_27204(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                this_param)
                {
                    var return_v = this_param.DefaultAttributeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 27164, 27204);
                    return return_v;
                }


                System.Exception
                f_10055_27129_27205(Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 27129, 27205);
                    return return_v;
                }


                string
                f_10055_27494_27526(Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                locations)
                {
                    var return_v = locations.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 27494, 27526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_27331_27527(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 27331, 27527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10055_27733_27773(Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
                this_param)
                {
                    var return_v = this_param.DefaultAttributeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 27733, 27773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 24706, 27902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 24706, 27902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EarlyWellKnownAttributeData EarlyDecodeWellKnownAttributes(
                    ImmutableArray<Binder> binders,
                    ImmutableArray<NamedTypeSymbol> boundAttributeTypes,
                    ImmutableArray<AttributeSyntax> attributesToBind,
                    AttributeLocation symbolPart,
                    CSharpAttributeData[] boundAttributesBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 28502, 30536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 28871, 28911);

                f_10055_28871_28910(boundAttributeTypes.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 28925, 28962);

                f_10055_28925_28961(attributesToBind.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 28976, 29004);

                f_10055_28976_29003(binders.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29018, 29063);

                f_10055_29018_29062(boundAttributesBuilder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29077, 29148);

                f_10055_29077_29147(!f_10055_29091_29146(boundAttributesBuilder, (attr) => attr != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29164, 29228);

                var
                earlyBinder = f_10055_29182_29227(binders[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29242, 29387);

                var
                arguments = f_10055_29258_29386()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29401, 29435);

                arguments.SymbolPart = symbolPart;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29460, 29465);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29451, 30446) || true) && (i < boundAttributeTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29499, 29502)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 29451, 30446))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 29451, 30446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29536, 29596);

                        NamedTypeSymbol
                        boundAttributeType = boundAttributeTypes[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29614, 30431) || true) && (!f_10055_29619_29651(boundAttributeType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 29614, 30431);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29693, 29860) || true) && (binders[i] != f_10055_29711_29727(earlyBinder))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 29693, 29860);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29777, 29837);

                                earlyBinder = f_10055_29791_29836(binders[i]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 29693, 29860);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29884, 29915);

                            arguments.Binder = earlyBinder;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 29937, 29982);

                            arguments.AttributeType = boundAttributeType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30004, 30052);

                            arguments.AttributeSyntax = attributesToBind[i];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30138, 30233);

                            CSharpAttributeData
                            earlyBoundAttributeOpt = f_10055_30183_30232(this, ref arguments)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30255, 30337);

                            f_10055_30255_30336(earlyBoundAttributeOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10055, 30268, 30335) || f_10055_30302_30335_M(!earlyBoundAttributeOpt.HasErrors)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30361, 30412);

                            boundAttributesBuilder[i] = earlyBoundAttributeOpt;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 29614, 30431);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30462, 30525);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10055, 30469, 30493) || ((arguments.HasDecodedData && DynAbs.Tracing.TraceSender.Conditional_F2(10055, 30496, 30517)) || DynAbs.Tracing.TraceSender.Conditional_F3(10055, 30520, 30524))) ? arguments.DecodedData : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 28502, 30536);

                int
                f_10055_28871_28910(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 28871, 28910);
                    return 0;
                }


                int
                f_10055_28925_28961(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 28925, 28961);
                    return 0;
                }


                int
                f_10055_28976_29003(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 28976, 29003);
                    return 0;
                }


                int
                f_10055_29018_29062(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29018, 29062);
                    return 0;
                }


                bool
                f_10055_29091_29146(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData[]
                sequence, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, bool>
                predicate)
                {
                    var return_v = sequence.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29091, 29146);
                    return return_v;
                }


                int
                f_10055_29077_29147(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29077, 29147);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                f_10055_29182_29227(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder(enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29182, 29227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                f_10055_29258_29386()
                {
                    var return_v = new Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29258, 29386);
                    return return_v;
                }


                bool
                f_10055_29619_29651(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29619, 29651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10055_29711_29727(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 29711, 29727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                f_10055_29791_29836(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder(enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 29791, 29836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10055_30183_30232(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    var return_v = this_param.EarlyDecodeWellKnownAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 30183, 30232);
                    return return_v;
                }


                bool
                f_10055_30302_30335_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 30302, 30335);
                    return return_v;
                }


                int
                f_10055_30255_30336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 30255, 30336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 28502, 30536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 28502, 30536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EarlyDecodeWellKnownAttributeTypes(ImmutableArray<NamedTypeSymbol> attributeTypes, ImmutableArray<AttributeSyntax> attributeSyntaxList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 30548, 31161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30721, 30761);

                f_10055_30721_30760(attributeSyntaxList.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30775, 30810);

                f_10055_30775_30809(attributeTypes.Any());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30835, 30840);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30826, 31150) || true) && (i < attributeTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30869, 30872)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 30826, 31150))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 30826, 31150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30906, 30944);

                        var
                        attributeType = attributeTypes[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 30964, 31135) || true) && (!f_10055_30969_30996(attributeType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 30964, 31135);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 31038, 31116);

                            f_10055_31038_31115(this, attributeType, attributeSyntaxList[i]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 30964, 31135);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 30548, 31161);

                int
                f_10055_30721_30760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 30721, 30760);
                    return 0;
                }


                int
                f_10055_30775_30809(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 30775, 30809);
                    return 0;
                }


                bool
                f_10055_30969_30996(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 30969, 30996);
                    return return_v;
                }


                int
                f_10055_31038_31115(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    this_param.EarlyDecodeWellKnownAttributeType(attributeType, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 31038, 31115);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 30548, 31161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 30548, 31161);
            }
        }

        private WellKnownAttributeData ValidateAttributeUsageAndDecodeWellKnownAttributes(
                    ImmutableArray<Binder> binders,
                    ImmutableArray<AttributeSyntax> attributeSyntaxList,
                    ImmutableArray<CSharpAttributeData> boundAttributes,
                    DiagnosticBag diagnostics,
                    AttributeLocation symbolPart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 31677, 33737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32044, 32072);

                f_10055_32044_32071(binders.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32086, 32126);

                f_10055_32086_32125(attributeSyntaxList.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32140, 32176);

                f_10055_32140_32175(boundAttributes.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32190, 32245);

                f_10055_32190_32244(binders.Length == boundAttributes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32259, 32326);

                f_10055_32259_32325(attributeSyntaxList.Length == boundAttributes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32342, 32392);

                int
                totalAttributesCount = boundAttributes.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32406, 32485);

                HashSet<NamedTypeSymbol>
                uniqueAttributeTypes = f_10055_32454_32484()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32499, 32612);

                var
                arguments = f_10055_32515_32611()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32626, 32662);

                arguments.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32676, 32725);

                arguments.AttributesCount = totalAttributesCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32739, 32773);

                arguments.SymbolPart = symbolPart;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32798, 32803);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32789, 33647) || true) && (i < totalAttributesCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32831, 32834)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 32789, 33647))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 32789, 33647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32868, 32924);

                        CSharpAttributeData
                        boundAttribute = boundAttributes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 32942, 32999);

                        AttributeSyntax
                        attributeSyntax = attributeSyntaxList[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33017, 33044);

                        Binder
                        binder = binders[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33199, 33632) || true) && (f_10055_33203_33228_M(!boundAttribute.HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10055, 33203, 33354) && f_10055_33232_33354(this, boundAttribute, attributeSyntax, f_10055_33288_33306(binder), symbolPart, diagnostics, uniqueAttributeTypes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 33199, 33632);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33396, 33433);

                            arguments.Attribute = boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33455, 33502);

                            arguments.AttributeSyntaxOpt = attributeSyntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33524, 33544);

                            arguments.Index = i;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33568, 33613);

                            f_10055_33568_33612(
                                                this, ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 33199, 33632);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10055, 1, 859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10055, 1, 859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 33663, 33726);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10055, 33670, 33694) || ((arguments.HasDecodedData && DynAbs.Tracing.TraceSender.Conditional_F2(10055, 33697, 33718)) || DynAbs.Tracing.TraceSender.Conditional_F3(10055, 33721, 33725))) ? arguments.DecodedData : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 31677, 33737);

                int
                f_10055_32044_32071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32044, 32071);
                    return 0;
                }


                int
                f_10055_32086_32125(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32086, 32125);
                    return 0;
                }


                int
                f_10055_32140_32175(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32140, 32175);
                    return 0;
                }


                int
                f_10055_32190_32244(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32190, 32244);
                    return 0;
                }


                int
                f_10055_32259_32325(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32259, 32325);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10055_32454_32484()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32454, 32484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                f_10055_32515_32611()
                {
                    var return_v = new Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 32515, 32611);
                    return return_v;
                }


                bool
                f_10055_33203_33228_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 33203, 33228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10055_33288_33306(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 33288, 33306);
                    return return_v;
                }


                bool
                f_10055_33232_33354(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                symbolPart, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                uniqueAttributeTypes)
                {
                    var return_v = this_param.ValidateAttributeUsage(attribute, node, compilation, symbolPart, diagnostics, uniqueAttributeTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 33232, 33354);
                    return return_v;
                }


                int
                f_10055_33568_33612(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeWellKnownAttribute(ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 33568, 33612);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 31677, 33737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 31677, 33737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ValidateAttributeUsage(
                    CSharpAttributeData attribute,
                    AttributeSyntax node,
                    CSharpCompilation compilation,
                    AttributeLocation symbolPart,
                    DiagnosticBag diagnostics,
                    HashSet<NamedTypeSymbol> uniqueAttributeTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 34333, 36839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 34660, 34695);

                f_10055_34660_34694(f_10055_34673_34693_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 34711, 34768);

                NamedTypeSymbol
                attributeType = f_10055_34743_34767(attribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 34782, 34860);

                AttributeUsageInfo
                attributeUsageInfo = f_10055_34822_34859(attributeType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 34969, 35228) || true) && (!f_10055_34974_35013(uniqueAttributeTypes, attributeType) && (DynAbs.Tracing.TraceSender.Expression_True(10055, 34973, 35050) && f_10055_35017_35050_M(!attributeUsageInfo.AllowMultiple)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 34969, 35228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35084, 35182);

                    f_10055_35084_35181(diagnostics, ErrorCode.ERR_DuplicateAttribute, f_10055_35134_35152(f_10055_35134_35143(node)), f_10055_35154_35180(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35200, 35213);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 34969, 35228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35327, 35360);

                AttributeTargets
                attributeTarget
                = default(AttributeTargets);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35374, 35730) || true) && (symbolPart == AttributeLocation.Return)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 35374, 35730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35495, 35540);

                    f_10055_35495_35539(f_10055_35508_35517(this) == SymbolKind.Method);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35558, 35605);

                    attributeTarget = AttributeTargets.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 35374, 35730);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 35374, 35730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35671, 35715);

                    attributeTarget = f_10055_35689_35714(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 35374, 35730);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35746, 36076) || true) && ((attributeTarget & attributeUsageInfo.ValidTargets) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 35746, 36076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 35875, 36030);

                    f_10055_35875_36029(                // generate error
                                    diagnostics, ErrorCode.ERR_AttributeOnBadSymbolType, f_10055_35931_35949(f_10055_35931_35940(node)), f_10055_35951_35977(node), attributeUsageInfo.GetValidTargetsErrorArgument());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36048, 36061);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 35746, 36076);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36092, 36800) || true) && (f_10055_36096_36138(attribute, compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 36092, 36800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36172, 36785);

                    switch (f_10055_36180_36189(this))
                    {

                        case SymbolKind.Assembly:
                        case SymbolKind.NamedType:
                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 36172, 36785);
                            DynAbs.Tracing.TraceSender.TraceBreak(10055, 36375, 36381);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 36172, 36785);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 36172, 36785);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36617, 36727);

                            f_10055_36617_36726(                        // CS7070: Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.
                                                    diagnostics, ErrorCode.ERR_SecurityAttributeInvalidTarget, f_10055_36679_36697(f_10055_36679_36688(node)), f_10055_36699_36725(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36753, 36766);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 36172, 36785);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 36092, 36800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 36816, 36828);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 34333, 36839);

                bool
                f_10055_34673_34693_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 34673, 34693);
                    return return_v;
                }


                int
                f_10055_34660_34694(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 34660, 34694);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10055_34743_34767(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 34743, 34767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10055_34822_34859(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 34822, 34859);
                    return return_v;
                }


                bool
                f_10055_34974_35013(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 34974, 35013);
                    return return_v;
                }


                bool
                f_10055_35017_35050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35017, 35050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10055_35134_35143(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35134, 35143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10055_35134_35152(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35134, 35152);
                    return return_v;
                }


                string
                f_10055_35154_35180(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35154, 35180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_35084_35181(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35084, 35181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10055_35508_35517(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35508, 35517);
                    return return_v;
                }


                int
                f_10055_35495_35539(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35495, 35539);
                    return 0;
                }


                System.AttributeTargets
                f_10055_35689_35714(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributeTarget();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35689, 35714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10055_35931_35940(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35931, 35940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10055_35931_35949(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 35931, 35949);
                    return return_v;
                }


                string
                f_10055_35951_35977(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35951, 35977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_35875_36029(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 35875, 36029);
                    return return_v;
                }


                bool
                f_10055_36096_36138(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 36096, 36138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10055_36180_36189(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 36180, 36189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10055_36679_36688(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 36679, 36688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10055_36679_36697(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 36679, 36697);
                    return return_v;
                }


                string
                f_10055_36699_36725(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 36699, 36725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10055_36617_36726(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 36617, 36726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 34333, 36839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 34333, 36839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ForceCompleteObsoleteAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10055, 36991, 37302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 37062, 37176) || true) && (f_10055_37066_37084(this) == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10055, 37062, 37176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 37140, 37161);

                    f_10055_37140_37160(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10055, 37062, 37176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10055, 37190, 37291);

                f_10055_37190_37290(f_10055_37203_37221(this) != ThreeState.Unknown, "ObsoleteState should be true or false now.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(10055, 36991, 37302);

                Microsoft.CodeAnalysis.ThreeState
                f_10055_37066_37084(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ObsoleteState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 37066, 37084);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10055_37140_37160(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 37140, 37160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10055_37203_37221(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ObsoleteState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10055, 37203, 37221);
                    return return_v;
                }


                int
                f_10055_37190_37290(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10055, 37190, 37290);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10055, 36991, 37302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10055, 36991, 37302);
            }
        }
    }
}
