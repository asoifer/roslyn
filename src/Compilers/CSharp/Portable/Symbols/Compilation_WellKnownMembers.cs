// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class CSharpCompilation
    {
        internal readonly WellKnownMembersSignatureComparer WellKnownMemberSignatureComparer;

        private NamedTypeSymbol?[]? _lazyWellKnownTypes;

        private Symbol?[]? _lazyWellKnownTypeMembers;

        private bool _usesNullableAttributes;

        private int _needsGeneratedAttributes;

        private bool _needsGeneratedAttributes_IsFrozen;

        internal EmbeddableAttributes GetNeedsGeneratedAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 1777, 1983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 1861, 1903);

                _needsGeneratedAttributes_IsFrozen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 1917, 1972);

                return (EmbeddableAttributes)_needsGeneratedAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 1777, 1983);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 1777, 1983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 1777, 1983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetNeedsGeneratedAttributes(EmbeddableAttributes attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 1995, 2245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2093, 2143);

                f_10091_2093_2142(!_needsGeneratedAttributes_IsFrozen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2157, 2234);

                f_10091_2157_2233(ref _needsGeneratedAttributes, attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 1995, 2245);

                int
                f_10091_2093_2142(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 2093, 2142);
                    return 0;
                }


                bool
                f_10091_2157_2233(ref int
                flags, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                toSet)
                {
                    var return_v = ThreadSafeFlagOperations.Set(ref flags, (int)toSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 2157, 2233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 1995, 2245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 1995, 2245);
            }
        }

        internal bool GetUsesNullableAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 2257, 2421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2323, 2365);

                _needsGeneratedAttributes_IsFrozen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2379, 2410);

                return _usesNullableAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 2257, 2421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 2257, 2421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 2257, 2421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetUsesNullableAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 2433, 2604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2498, 2548);

                f_10091_2498_2547(!_needsGeneratedAttributes_IsFrozen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 2562, 2593);

                _usesNullableAttributes = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 2433, 2604);

                int
                f_10091_2498_2547(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 2498, 2547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 2433, 2604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 2433, 2604);
            }
        }

        internal Symbol? GetWellKnownTypeMember(WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 3017, 4843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3105, 3165);

                f_10091_3105_3164(member >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10091, 3118, 3163) && member < WellKnownMember.Count));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3257, 3298) || true) && (f_10091_3261_3284(this, member))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 3257, 3298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3286, 3298);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 3257, 3298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3314, 4770) || true) && (_lazyWellKnownTypeMembers == null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 3318, 3445) || f_10091_3355_3445(_lazyWellKnownTypeMembers[(int)member], ErrorTypeSymbol.UnknownResultType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 3314, 4770);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3479, 3963) || true) && (_lazyWellKnownTypeMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 3479, 3963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3558, 3624);

                        var
                        wellKnownTypeMembers = new Symbol[(int)WellKnownMember.Count]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3657, 3662);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3648, 3833) || true) && (i < f_10091_3668_3695(wellKnownTypeMembers))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3697, 3700)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 3648, 3833))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 3648, 3833);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3750, 3810);

                                wellKnownTypeMembers[i] = ErrorTypeSymbol.UnknownResultType;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10091, 1, 186);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10091, 1, 186);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3857, 3944);

                        f_10091_3857_3943(ref _lazyWellKnownTypeMembers, wellKnownTypeMembers, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 3479, 3963);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 3983, 4052);

                    MemberDescriptor
                    descriptor = f_10091_4013_4051(member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4070, 4366);

                    NamedTypeSymbol
                    type = (DynAbs.Tracing.TraceSender.Conditional_F1(10091, 4093, 4145) || ((descriptor.DeclaringTypeId <= (int)SpecialType.Count
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10091, 4193, 4253)) || DynAbs.Tracing.TraceSender.Conditional_F3(10091, 4301, 4365))) ? f_10091_4193_4253(this, descriptor.DeclaringTypeId) : f_10091_4301_4365(this, descriptor.DeclaringTypeId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4384, 4406);

                    Symbol?
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4426, 4620) || true) && (!f_10091_4431_4449(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 4426, 4620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4491, 4601);

                        result = f_10091_4500_4600(type, descriptor, WellKnownMemberSignatureComparer, accessWithinOpt: f_10091_4586_4599(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 4426, 4620);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4640, 4755);

                    f_10091_4640_4754(ref _lazyWellKnownTypeMembers[(int)member], result, ErrorTypeSymbol.UnknownResultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 3314, 4770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 4786, 4832);

                return _lazyWellKnownTypeMembers[(int)member];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 3017, 4843);

                int
                f_10091_3105_3164(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 3105, 3164);
                    return 0;
                }


                bool
                f_10091_3261_3284(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.IsMemberMissing(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 3261, 3284);
                    return return_v;
                }


                bool
                f_10091_3355_3445(Microsoft.CodeAnalysis.CSharp.Symbol?
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 3355, 3445);
                    return return_v;
                }


                int
                f_10091_3668_3695(Microsoft.CodeAnalysis.CSharp.Symbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 3668, 3695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?[]?
                f_10091_3857_3943(ref Microsoft.CodeAnalysis.CSharp.Symbol?[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbol?[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 3857, 3943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10091_4013_4051(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4013, 4051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_4193_4253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, short
                specialType)
                {
                    var return_v = this_param.GetSpecialType((Microsoft.CodeAnalysis.SpecialType)specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4193, 4253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_4301_4365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, short
                type)
                {
                    var return_v = this_param.GetWellKnownType((Microsoft.CodeAnalysis.WellKnownType)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4301, 4365);
                    return return_v;
                }


                bool
                f_10091_4431_4449(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4431, 4449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_4586_4599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 4586, 4599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_4500_4600(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaringType, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                descriptor, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.WellKnownMembersSignatureComparer
                comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                accessWithinOpt)
                {
                    var return_v = GetRuntimeMember(declaringType, descriptor, (Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>)comparer, accessWithinOpt: accessWithinOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4500, 4600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_4640_4754(ref Microsoft.CodeAnalysis.CSharp.Symbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 4640, 4754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 3017, 4843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 3017, 4843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetWellKnownType(WellKnownType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 5295, 8872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5381, 5410);

                f_10091_5381_5409(f_10091_5394_5408(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5426, 5552);

                bool
                ignoreCorLibraryDuplicatedTypes = f_10091_5465_5551(f_10091_5465_5497(f_10091_5465_5477(this)), BinderFlags.IgnoreCorLibraryDuplicatedTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5568, 5617);

                int
                index = (int)type - (int)WellKnownType.First
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5631, 8810) || true) && (_lazyWellKnownTypes == null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 5635, 5700) || _lazyWellKnownTypes[index] is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 5631, 8810);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5734, 5933) || true) && (_lazyWellKnownTypes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 5734, 5933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5807, 5914);

                        f_10091_5807_5913(ref _lazyWellKnownTypes, new NamedTypeSymbol[(int)WellKnownTypes.Count], null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 5734, 5933);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 5953, 5992);

                    string
                    mdName = f_10091_5969_5991(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6010, 6053);

                    var
                    warnings = f_10091_6025_6052()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6071, 6095);

                    NamedTypeSymbol?
                    result
                    = default(NamedTypeSymbol?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6113, 6166);

                    (AssemblySymbol, AssemblySymbol)
                    conflicts = default
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6186, 6899) || true) && (f_10091_6190_6209(this, type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 6186, 6899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6251, 6265);

                        result = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 6186, 6899);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 6186, 6899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6458, 6548);

                        DiagnosticBag?
                        legacyWarnings = (DynAbs.Tracing.TraceSender.Conditional_F1(10091, 6490, 6529) || (((type <= WellKnownType.CSharp7Sentinel) && DynAbs.Tracing.TraceSender.Conditional_F2(10091, 6532, 6540)) || DynAbs.Tracing.TraceSender.Conditional_F3(10091, 6543, 6547))) ? warnings : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6570, 6880);

                        result = f_10091_6579_6879(f_10091_6579_6592(this), mdName, includeReferences: true, useCLSCompliantNameArityEncoding: true, isWellKnownType: true, conflicts: out conflicts, warnings: legacyWarnings, ignoreCorLibraryDuplicatedTypes: ignoreCorLibraryDuplicatedTypes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 6186, 6899);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 6919, 8240) || true) && (result is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 6919, 8240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7070, 7179);

                        MetadataTypeName
                        emittedName = MetadataTypeName.FromFullName(mdName, useCLSCompliantNameArityEncoding: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7201, 8221) || true) && (f_10091_7205_7228(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 7201, 8221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7278, 7305);

                            CSDiagnosticInfo
                            errorInfo
                            = default(CSDiagnosticInfo);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7331, 7867) || true) && (conflicts.Item1 is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 7331, 7867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7416, 7454);

                                f_10091_7416_7453(conflicts.Item2 is null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7484, 7587);

                                errorInfo = f_10091_7496_7586(ErrorCode.ERR_PredefinedValueTupleTypeNotFound, emittedName.FullName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 7331, 7867);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 7331, 7867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7701, 7840);

                                errorInfo = f_10091_7713_7839(ErrorCode.ERR_PredefinedValueTupleTypeAmbiguous3, emittedName.FullName, conflicts.Item1, conflicts.Item2);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 7331, 7867);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 7895, 8003);

                            result = f_10091_7904_8002(f_10091_7943_7964(f_10091_7943_7956(this))[0], ref emittedName, type, errorInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 7201, 8221);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 7201, 8221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8101, 8198);

                            result = f_10091_8110_8197(f_10091_8149_8170(f_10091_8149_8162(this))[0], ref emittedName, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 7201, 8221);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 6919, 8240);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8260, 8759) || true) && (f_10091_8264_8337(ref _lazyWellKnownTypes[index], result, null) is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 8260, 8759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8389, 8613);

                        f_10091_8389_8612(f_10091_8428_8518(result, _lazyWellKnownTypes[index], TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 8428, 8589) || (f_10091_8523_8564(_lazyWellKnownTypes[index]!) && (DynAbs.Tracing.TraceSender.Expression_True(10091, 8523, 8588) && f_10091_8568_8588(result)))
                        ));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 8260, 8759);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 8260, 8759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8695, 8740);

                        f_10091_8695_8739(f_10091_8695_8720(), warnings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 8260, 8759);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8779, 8795);

                    f_10091_8779_8794(
                                    warnings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 5631, 8810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8826, 8861);

                return _lazyWellKnownTypes[index]!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 5295, 8872);

                bool
                f_10091_5394_5408(Microsoft.CodeAnalysis.WellKnownType
                typeId)
                {
                    var return_v = typeId.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 5394, 5408);
                    return return_v;
                }


                int
                f_10091_5381_5409(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 5381, 5409);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10091_5465_5477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 5465, 5477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10091_5465_5497(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.TopLevelBinderFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 5465, 5497);
                    return return_v;
                }


                bool
                f_10091_5465_5551(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 5465, 5551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?[]?
                f_10091_5807_5913(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 5807, 5913);
                    return return_v;
                }


                string
                f_10091_5969_5991(Microsoft.CodeAnalysis.WellKnownType
                id)
                {
                    var return_v = id.GetMetadataName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 5969, 5991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10091_6025_6052()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 6025, 6052);
                    return return_v;
                }


                bool
                f_10091_6190_6209(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.IsTypeMissing(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 6190, 6209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_6579_6592(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 6579, 6592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_6579_6879(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                metadataName, bool
                includeReferences, bool
                useCLSCompliantNameArityEncoding, bool
                isWellKnownType, out (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)
                conflicts, Microsoft.CodeAnalysis.DiagnosticBag
                warnings, bool
                ignoreCorLibraryDuplicatedTypes)
                {
                    var return_v = this_param.GetTypeByMetadataName(metadataName, 
                        includeReferences,
                        isWellKnownType,
                        out conflicts,
                        useCLSCompliantNameArityEncoding,
                        warnings, 
                        ignoreCorLibraryDuplicatedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 6579, 6879);
                    return return_v;
                }


                bool
                f_10091_7205_7228(Microsoft.CodeAnalysis.WellKnownType
                typeId)
                {
                    var return_v = typeId.IsValueTupleType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 7205, 7228);
                    return return_v;
                }


                int
                f_10091_7416_7453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 7416, 7453);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10091_7496_7586(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 7496, 7586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10091_7713_7839(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 7713, 7839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_7943_7956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 7943, 7956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10091_7943_7964(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 7943, 7964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10091_7904_8002(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.WellKnownType
                wellKnownType, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, wellKnownType, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 7904, 8002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_8149_8162(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 8149, 8162);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10091_8149_8170(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 8149, 8170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10091_8110_8197(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.WellKnownType
                wellKnownType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, wellKnownType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8110, 8197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10091_8264_8337(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8264, 8337);
                    return return_v;
                }


                bool
                f_10091_8428_8518(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8428, 8518);
                    return return_v;
                }


                bool
                f_10091_8523_8564(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8523, 8564);
                    return return_v;
                }


                bool
                f_10091_8568_8588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8568, 8588);
                    return return_v;
                }


                int
                f_10091_8389_8612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8389, 8612);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10091_8695_8720()
                {
                    var return_v = AdditionalCodegenWarnings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 8695, 8720);
                    return return_v;
                }


                int
                f_10091_8695_8739(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8695, 8739);
                    return 0;
                }


                int
                f_10091_8779_8794(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 8779, 8794);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 5295, 8872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 5295, 8872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAttributeType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 8884, 9135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 8955, 9006);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 9020, 9124);

                return f_10091_9027_9123(this, type, WellKnownType.System_Attribute, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 8884, 9135);

                bool
                f_10091_9027_9123(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.WellKnownType
                wellKnownType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsEqualOrDerivedFromWellKnownClass(type, wellKnownType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9027, 9123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 8884, 9135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 8884, 9135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsAttributeType(ITypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 9147, 9307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 9228, 9296);

                return f_10091_9235_9295(this, f_10091_9251_9294(type, nameof(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 9147, 9307);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10091_9251_9294(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9251, 9294);
                    return return_v;
                }


                bool
                f_10091_9235_9295(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9235, 9295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 9147, 9307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 9147, 9307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsExceptionType(TypeSymbol type, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 9319, 9554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 9439, 9543);

                return f_10091_9446_9542(this, type, WellKnownType.System_Exception, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 9319, 9554);

                bool
                f_10091_9446_9542(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.WellKnownType
                wellKnownType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsEqualOrDerivedFromWellKnownClass(type, wellKnownType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9446, 9542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 9319, 9554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 9319, 9554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsReadOnlySpanType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 9566, 9793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 9640, 9782);

                return f_10091_9647_9781(f_10091_9665_9688(type), f_10091_9690_9743(this, WellKnownType.System_ReadOnlySpan_T), TypeCompareKind.ConsiderEverything2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 9566, 9793);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10091_9665_9688(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 9665, 9688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_9690_9743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9690, 9743);
                    return return_v;
                }


                bool
                f_10091_9647_9781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9647, 9781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 9566, 9793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 9566, 9793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsEqualOrDerivedFromWellKnownClass(TypeSymbol type, WellKnownType wellKnownType, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 9805, 10521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 9973, 10112);

                f_10091_9973_10111(wellKnownType == WellKnownType.System_Attribute || (DynAbs.Tracing.TraceSender.Expression_False(10091, 9986, 10110) || wellKnownType == WellKnownType.System_Exception));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10128, 10262) || true) && (f_10091_10132_10141(type) != SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10091, 10132, 10200) || f_10091_10169_10182(type) != TypeKind.Class))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 10128, 10262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10234, 10247);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 10128, 10262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10278, 10323);

                var
                wkType = f_10091_10291_10322(this, wellKnownType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10337, 10510);

                return f_10091_10344_10399(type, wkType, TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 10344, 10509) || f_10091_10403_10509(type, wkType, TypeCompareKind.ConsiderEverything, useSiteDiagnostics: ref useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 9805, 10521);

                int
                f_10091_9973_10111(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 9973, 10111);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10091_10132_10141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 10132, 10141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10091_10169_10182(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 10169, 10182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_10291_10322(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10291, 10322);
                    return return_v;
                }


                bool
                f_10091_10344_10399(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10344, 10399);
                    return return_v;
                }


                bool
                f_10091_10403_10509(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10403, 10509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 9805, 10521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 9805, 10521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsSystemTypeReference(ITypeSymbolInternal type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 10533, 10764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10628, 10753);

                return f_10091_10635_10752(type, f_10091_10671_10714(this, WellKnownType.System_Type), TypeCompareKind.ConsiderEverything2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 10533, 10764);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_10671_10714(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10671, 10714);
                    return return_v;
                }


                bool
                f_10091_10635_10752(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10635, 10752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 10533, 10764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 10533, 10764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ISymbolInternal? CommonGetWellKnownTypeMember(WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 10776, 10937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 10888, 10926);

                return f_10091_10895_10925(this, member);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 10776, 10937);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_10895_10925(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 10895, 10925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 10776, 10937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 10776, 10937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ITypeSymbolInternal CommonGetWellKnownType(WellKnownType wellknownType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 10949, 11113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11063, 11102);

                return f_10091_11070_11101(this, wellknownType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 10949, 11113);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_11070_11101(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 11070, 11101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 10949, 11113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 10949, 11113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol? GetRuntimeMember(NamedTypeSymbol declaringType, in MemberDescriptor descriptor, SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol> comparer, AssemblySymbol accessWithinOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 11125, 11538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11385, 11441);

                var
                members = f_10091_11399_11440(declaringType, descriptor.Name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11455, 11527);

                return f_10091_11462_11526(members, descriptor, comparer, accessWithinOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 11125, 11538);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10091_11399_11440(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 11399, 11440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_11462_11526(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                descriptor, Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                accessWithinOpt)
                {
                    var return_v = GetRuntimeMember(members, descriptor, comparer, accessWithinOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 11462, 11526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 11125, 11538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 11125, 11538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol? GetRuntimeMember(ImmutableArray<Symbol> members, in MemberDescriptor descriptor, SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol> comparer, AssemblySymbol? accessWithinOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 11550, 16312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11812, 11840);

                SymbolKind
                targetSymbolKind
                = default(SymbolKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11854, 11904);

                MethodKind
                targetMethodKind = MethodKind.Ordinary
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11918, 11979);

                bool
                isStatic = (descriptor.Flags & MemberFlags.Static) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 11995, 12017);

                Symbol?
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12031, 13130);

                switch (descriptor.Flags & MemberFlags.KindMask)
                {

                    case MemberFlags.Constructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12163, 12200);

                        targetSymbolKind = SymbolKind.Method;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12222, 12264);

                        targetMethodKind = MethodKind.Constructor;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12359, 12383);

                        f_10091_12359_12382(!isStatic);
                        DynAbs.Tracing.TraceSender.TraceBreak(10091, 12405, 12411);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);

                    case MemberFlags.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12477, 12514);

                        targetSymbolKind = SymbolKind.Method;
                        DynAbs.Tracing.TraceSender.TraceBreak(10091, 12536, 12542);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);

                    case MemberFlags.PropertyGet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12613, 12650);

                        targetSymbolKind = SymbolKind.Method;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12672, 12714);

                        targetMethodKind = MethodKind.PropertyGet;
                        DynAbs.Tracing.TraceSender.TraceBreak(10091, 12736, 12742);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);

                    case MemberFlags.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12807, 12843);

                        targetSymbolKind = SymbolKind.Field;
                        DynAbs.Tracing.TraceSender.TraceBreak(10091, 12865, 12871);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);

                    case MemberFlags.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 12939, 12978);

                        targetSymbolKind = SymbolKind.Property;
                        DynAbs.Tracing.TraceSender.TraceBreak(10091, 13000, 13006);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 12031, 13130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13056, 13115);

                        throw f_10091_13062_13114(descriptor.Flags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 12031, 13130);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13146, 16271);
                    foreach (var member in f_10091_13169_13176_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13146, 16271);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13210, 13320) || true) && (!f_10091_13215_13250(f_10091_13215_13226(member), descriptor.Name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13210, 13320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13292, 13301);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13210, 13320);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13340, 13641) || true) && (f_10091_13344_13355(member) != targetSymbolKind || (DynAbs.Tracing.TraceSender.Expression_False(10091, 13344, 13406) || f_10091_13379_13394(member) != isStatic) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 13344, 13571) || !(f_10091_13433_13461(member) == Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10091, 13433, 13570) || (accessWithinOpt is object && (DynAbs.Tracing.TraceSender.Expression_True(10091, 13490, 13569) && f_10091_13519_13569(member, accessWithinOpt)))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13340, 13641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13613, 13622);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13340, 13641);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13661, 16047);

                        switch (targetSymbolKind)
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13661, 16047);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13807, 13850);

                                    MethodSymbol
                                    method = (MethodSymbol)member
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 13880, 13922);

                                    MethodKind
                                    methodKind = f_10091_13904_13921(method)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14120, 14337) || true) && (methodKind == MethodKind.Conversion || (DynAbs.Tracing.TraceSender.Expression_False(10091, 14124, 14207) || methodKind == MethodKind.UserDefinedOperator))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 14120, 14337);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14273, 14306);

                                        methodKind = MethodKind.Ordinary;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 14120, 14337);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14369, 14693) || true) && (f_10091_14373_14385(method) != descriptor.Arity || (DynAbs.Tracing.TraceSender.Expression_False(10091, 14373, 14439) || methodKind != targetMethodKind) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 14373, 14587) || ((descriptor.Flags & MemberFlags.Virtual) != 0) != (f_10091_14528_14544(method) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 14528, 14565) || f_10091_14548_14565(method)) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 14528, 14586) || f_10091_14569_14586(method)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 14369, 14693);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14653, 14662);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 14369, 14693);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14725, 14895) || true) && (!f_10091_14730_14789(comparer, method, descriptor.Signature))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 14725, 14895);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 14855, 14864);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 14725, 14895);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10091, 14950, 14956);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13661, 16047);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13661, 16047);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15062, 15111);

                                    PropertySymbol
                                    property = (PropertySymbol)member
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15141, 15368) || true) && (((descriptor.Flags & MemberFlags.Virtual) != 0) != (f_10091_15197_15215(property) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 15197, 15238) || f_10091_15219_15238(property)) || (DynAbs.Tracing.TraceSender.Expression_False(10091, 15197, 15261) || f_10091_15242_15261(property))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 15141, 15368);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15328, 15337);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 15141, 15368);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15400, 15574) || true) && (!f_10091_15405_15468(comparer, property, descriptor.Signature))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 15400, 15574);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15534, 15543);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 15400, 15574);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10091, 15629, 15635);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13661, 16047);

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13661, 16047);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15707, 15877) || true) && (!f_10091_15712_15783(comparer, member, descriptor.Signature))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 15707, 15877);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15841, 15850);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 15707, 15877);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10091, 15905, 15911);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13661, 16047);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 13661, 16047);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 15969, 16028);

                                throw f_10091_15975_16027(targetSymbolKind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13661, 16047);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 16097, 16220) || true) && (result is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 16097, 16220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 16159, 16173);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 16195, 16201);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 16097, 16220);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 16240, 16256);

                        result = member;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 13146, 16271);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10091, 1, 3126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10091, 1, 3126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 16287, 16301);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 11550, 16312);

                int
                f_10091_12359_12382(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 12359, 12382);
                    return 0;
                }


                System.Exception
                f_10091_13062_13114(Microsoft.CodeAnalysis.RuntimeMembers.MemberFlags
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 13062, 13114);
                    return return_v;
                }


                string
                f_10091_13215_13226(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 13215, 13226);
                    return return_v;
                }


                bool
                f_10091_13215_13250(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 13215, 13250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10091_13344_13355(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 13344, 13355);
                    return return_v;
                }


                bool
                f_10091_13379_13394(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 13379, 13394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10091_13433_13461(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 13433, 13461);
                    return return_v;
                }


                bool
                f_10091_13519_13569(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within)
                {
                    var return_v = Symbol.IsSymbolAccessible(symbol, within);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 13519, 13569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10091_13904_13921(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 13904, 13921);
                    return return_v;
                }


                int
                f_10091_14373_14385(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 14373, 14385);
                    return return_v;
                }


                bool
                f_10091_14528_14544(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 14528, 14544);
                    return return_v;
                }


                bool
                f_10091_14548_14565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 14548, 14565);
                    return return_v;
                }


                bool
                f_10091_14569_14586(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 14569, 14586);
                    return return_v;
                }


                bool
                f_10091_14730_14789(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<byte>
                signature)
                {
                    var return_v = this_param.MatchMethodSignature(method, signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 14730, 14789);
                    return return_v;
                }


                bool
                f_10091_15197_15215(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 15197, 15215);
                    return return_v;
                }


                bool
                f_10091_15219_15238(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 15219, 15238);
                    return return_v;
                }


                bool
                f_10091_15242_15261(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 15242, 15261);
                    return return_v;
                }


                bool
                f_10091_15405_15468(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, System.Collections.Immutable.ImmutableArray<byte>
                signature)
                {
                    var return_v = this_param.MatchPropertySignature(property, signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 15405, 15468);
                    return return_v;
                }


                bool
                f_10091_15712_15783(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field, System.Collections.Immutable.ImmutableArray<byte>
                signature)
                {
                    var return_v = this_param.MatchFieldSignature((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field, signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 15712, 15783);
                    return return_v;
                }


                System.Exception
                f_10091_15975_16027(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 15975, 16027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10091_13169_13176_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 13169, 13176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 11550, 16312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 11550, 16312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? TrySynthesizeAttribute(
                    WellKnownMember constructor,
                    ImmutableArray<TypedConstant> arguments = default,
                    ImmutableArray<KeyValuePair<WellKnownMember, TypedConstant>> namedArguments = default,
                    bool isOptionalUse = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 17407, 19783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 17737, 17767);

                DiagnosticInfo
                diagnosticInfo
                = default(DiagnosticInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 17781, 17899);

                var
                ctorSymbol = (MethodSymbol)f_10091_17812_17898(this, constructor, out diagnosticInfo, isOptional: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 17915, 18227) || true) && ((object)ctorSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 17915, 18227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18090, 18182);

                    f_10091_18090_18181(isOptionalUse || (DynAbs.Tracing.TraceSender.Expression_False(10091, 18103, 18180) || f_10091_18120_18180(constructor)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18200, 18212);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 17915, 18227);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18243, 18363) || true) && (arguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18243, 18363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18300, 18348);

                    arguments = ImmutableArray<TypedConstant>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18243, 18363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18379, 18452);

                ImmutableArray<KeyValuePair<string, TypedConstant>>
                namedStringArguments
                = default(ImmutableArray<KeyValuePair<string, TypedConstant>>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18466, 19675) || true) && (namedArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18466, 19675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18528, 18609);

                    namedStringArguments = ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18466, 19675);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18466, 19675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18675, 18766);

                    var
                    builder = f_10091_18689_18765(namedArguments.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18784, 19590);
                        foreach (var arg in f_10091_18804_18818_I(namedArguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18784, 19590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18860, 18965);

                            var
                            wellKnownMember = f_10091_18882_18964(this, arg.Key, out diagnosticInfo, isOptional: true)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 18987, 19571) || true) && (wellKnownMember == null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 18991, 19052) || wellKnownMember is ErrorTypeSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18987, 19571);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19221, 19296);

                                f_10091_19221_19295(f_10091_19234_19294(constructor));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19322, 19334);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18987, 19571);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 18987, 19571);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19432, 19548);

                                f_10091_19432_19547(builder, f_10091_19444_19546(f_10091_19514_19534(wellKnownMember), arg.Value));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18987, 19571);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18784, 19590);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10091, 1, 807);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10091, 1, 807);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19608, 19660);

                    namedStringArguments = f_10091_19631_19659(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 18466, 19675);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19691, 19772);

                return f_10091_19698_19771(ctorSymbol, arguments, namedStringArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 17407, 19783);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10091_17812_17898(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo, bool
                isOptional)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, out diagnosticInfo, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 17812, 17898);
                    return return_v;
                }


                bool
                f_10091_18120_18180(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 18120, 18180);
                    return return_v;
                }


                int
                f_10091_18090_18181(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 18090, 18181);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10091_18689_18765(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 18689, 18765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10091_18882_18964(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo, bool
                isOptional)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, out diagnosticInfo, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 18882, 18964);
                    return return_v;
                }


                bool
                f_10091_19234_19294(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19234, 19294);
                    return return_v;
                }


                int
                f_10091_19221_19295(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19221, 19295);
                    return 0;
                }


                string
                f_10091_19514_19534(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 19514, 19534);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                f_10091_19444_19546(string
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19444, 19546);
                    return return_v;
                }


                int
                f_10091_19432_19547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19432, 19547);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                f_10091_18804_18818_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 18804, 18818);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10091_19631_19659(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19631, 19659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10091_19698_19771(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19698, 19771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 17407, 19783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 17407, 19783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? TrySynthesizeAttribute(
                    SpecialMember constructor,
                    bool isOptionalUse = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 19795, 20432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 19959, 20029);

                var
                ctorSymbol = (MethodSymbol)f_10091_19990_20028(this, constructor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20045, 20182) || true) && ((object)ctorSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 20045, 20182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20109, 20137);

                    f_10091_20109_20136(isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20155, 20167);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 20045, 20182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20198, 20421);

                return f_10091_20205_20420(ctorSymbol, arguments: ImmutableArray<TypedConstant>.Empty, namedArguments: ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 19795, 20432);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10091_19990_20028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 19990, 20028);
                    return return_v;
                }


                int
                f_10091_20109_20136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20109, 20136);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10091_20205_20420(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments: arguments, namedArguments: namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20205, 20420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 19795, 20432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 19795, 20432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeDecimalConstantAttribute(decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 20444, 21651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20553, 20569);

                bool
                isNegative
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20583, 20594);

                byte
                scale
                = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20608, 20628);

                uint
                low
                = default(uint),
                mid
                = default(uint),
                high
                = default(uint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20642, 20711);

                f_10091_20642_20710(value, out isNegative, out scale, out low, out mid, out high);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20725, 20782);

                var
                systemByte = f_10091_20742_20781(this, SpecialType.System_Byte)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20796, 20838);

                f_10091_20796_20837(f_10091_20809_20836_M(!systemByte.HasUseSiteError));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20854, 20915);

                var
                systemUnit32 = f_10091_20873_20914(this, SpecialType.System_UInt32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20929, 20973);

                f_10091_20929_20972(f_10091_20942_20971_M(!systemUnit32.HasUseSiteError));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 20989, 21640);

                return f_10091_20996_21639(this, WellKnownMember.System_Runtime_CompilerServices_DecimalConstantAttribute__ctor, f_10091_21134_21638(f_10091_21178_21243(systemByte, TypedConstantKind.Primitive, scale), f_10091_21266_21354(systemByte, TypedConstantKind.Primitive, (byte)((DynAbs.Tracing.TraceSender.Conditional_F1(10091, 21332, 21342) || ((isNegative && DynAbs.Tracing.TraceSender.Conditional_F2(10091, 21345, 21348)) || DynAbs.Tracing.TraceSender.Conditional_F3(10091, 21351, 21352))) ? 128 : 0)), f_10091_21377_21443(systemUnit32, TypedConstantKind.Primitive, high), f_10091_21466_21531(systemUnit32, TypedConstantKind.Primitive, mid), f_10091_21554_21619(systemUnit32, TypedConstantKind.Primitive, low)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 20444, 21651);

                int
                f_10091_20642_20710(decimal
                value, out bool
                isNegative, out byte
                scale, out uint
                low, out uint
                mid, out uint
                high)
                {
                    value.GetBits(out isNegative, out scale, out low, out mid, out high);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20642, 20710);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_20742_20781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20742, 20781);
                    return return_v;
                }


                bool
                f_10091_20809_20836_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 20809, 20836);
                    return return_v;
                }


                int
                f_10091_20796_20837(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20796, 20837);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_20873_20914(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20873, 20914);
                    return return_v;
                }


                bool
                f_10091_20942_20971_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 20942, 20971);
                    return return_v;
                }


                int
                f_10091_20929_20972(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20929, 20972);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_21178_21243(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, byte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21178, 21243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_21266_21354(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, byte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21266, 21354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_21377_21443(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, uint
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21377, 21443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_21466_21531(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, uint
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21466, 21531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_21554_21619(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, uint
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21554, 21619);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_21134_21638(params Microsoft.CodeAnalysis.TypedConstant[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21134, 21638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_20996_21639(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 20996, 21639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 20444, 21651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 20444, 21651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeDebuggerBrowsableNeverAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 21663, 22273);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 21766, 21883) || true) && (f_10091_21770_21795(f_10091_21770_21777()) != OptimizationLevel.Debug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 21766, 21883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 21856, 21868);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 21766, 21883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 21899, 22262);

                return f_10091_21906_22261(this, WellKnownMember.System_Diagnostics_DebuggerBrowsableAttribute__ctor, f_10091_22018_22260(f_10091_22040_22259(f_10091_22083_22156(this, WellKnownType.System_Diagnostics_DebuggerBrowsableState), TypedConstantKind.Enum, DebuggerBrowsableState.Never)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 21663, 22273);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10091_21770_21777()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 21770, 21777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10091_21770_21795(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 21770, 21795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_22083_22156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22083, 22156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_22040_22259(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, System.Diagnostics.DebuggerBrowsableState
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22040, 22259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_22018_22260(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22018, 22260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_21906_22261(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 21906, 22261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 21663, 22273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 21663, 22273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeDebuggerStepThroughAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 22285, 22630);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 22385, 22502) || true) && (f_10091_22389_22414(f_10091_22389_22396()) != OptimizationLevel.Debug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 22385, 22502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 22475, 22487);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 22385, 22502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 22518, 22619);

                return f_10091_22525_22618(this, WellKnownMember.System_Diagnostics_DebuggerStepThroughAttribute__ctor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 22285, 22630);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10091_22389_22396()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 22389, 22396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10091_22389_22414(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 22389, 22414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_22525_22618(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22525, 22618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 22285, 22630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 22285, 22630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureEmbeddableAttributeExists(EmbeddableAttributes attribute, DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 22642, 23334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 22814, 22886);

                f_10091_22814_22885(!modifyCompilation || (DynAbs.Tracing.TraceSender.Expression_False(10091, 22827, 22884) || !_needsGeneratedAttributes_IsFrozen));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 22902, 23081) || true) && (f_10091_22906_22972(this, attribute, diagnostics, location) && (DynAbs.Tracing.TraceSender.Expression_True(10091, 22906, 22993) && modifyCompilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 22902, 23081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 23027, 23066);

                    f_10091_23027_23065(this, attribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 22902, 23081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 23097, 23323) || true) && ((attribute & (EmbeddableAttributes.NullableAttribute | EmbeddableAttributes.NullableContextAttribute)) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10091, 23101, 23246) && modifyCompilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 23097, 23323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 23280, 23308);

                    f_10091_23280_23307(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 23097, 23323);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 22642, 23334);

                int
                f_10091_22814_22885(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22814, 22885);
                    return 0;
                }


                bool
                f_10091_22906_22972(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(attribute, diagnosticsOpt, locationOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 22906, 22972);
                    return return_v;
                }


                int
                f_10091_23027_23065(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attributes)
                {
                    this_param.SetNeedsGeneratedAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 23027, 23065);
                    return 0;
                }


                int
                f_10091_23280_23307(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    this_param.SetUsesNullableAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 23280, 23307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 22642, 23334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 22642, 23334);
            }
        }

        internal void EnsureIsReadOnlyAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 23346, 23614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 23487, 23603);

                f_10091_23487_23602(this, EmbeddableAttributes.IsReadOnlyAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 23346, 23614);

                int
                f_10091_23487_23602(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 23487, 23602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 23346, 23614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 23346, 23614);
            }
        }

        internal void EnsureIsByRefLikeAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 23626, 23896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 23768, 23885);

                f_10091_23768_23884(this, EmbeddableAttributes.IsByRefLikeAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 23626, 23896);

                int
                f_10091_23768_23884(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 23768, 23884);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 23626, 23896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 23626, 23896);
            }
        }

        internal void EnsureIsUnmanagedAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 23908, 24178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 24050, 24167);

                f_10091_24050_24166(this, EmbeddableAttributes.IsUnmanagedAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 23908, 24178);

                int
                f_10091_24050_24166(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 24050, 24166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 23908, 24178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 23908, 24178);
            }
        }

        internal void EnsureNullableAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 24190, 24454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 24329, 24443);

                f_10091_24329_24442(this, EmbeddableAttributes.NullableAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 24190, 24454);

                int
                f_10091_24329_24442(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 24329, 24442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 24190, 24454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 24190, 24454);
            }
        }

        internal void EnsureNullableContextAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 24466, 24744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 24612, 24733);

                f_10091_24612_24732(this, EmbeddableAttributes.NullableContextAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 24466, 24744);

                int
                f_10091_24612_24732(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 24612, 24732);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 24466, 24744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 24466, 24744);
            }
        }

        internal void EnsureNativeIntegerAttributeExists(DiagnosticBag? diagnostics, Location location, bool modifyCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 24756, 25030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 24900, 25019);

                f_10091_24900_25018(this, EmbeddableAttributes.NativeIntegerAttribute, diagnostics, location, modifyCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 24756, 25030);

                int
                f_10091_24900_25018(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute, diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 24900, 25018);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 24756, 25030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 24756, 25030);
            }
        }

        internal bool CheckIfAttributeShouldBeEmbedded(EmbeddableAttributes attribute, DiagnosticBag? diagnosticsOpt, Location locationOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 25042, 28688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 25198, 28677);

                switch (attribute)
                {

                    case EmbeddableAttributes.IsReadOnlyAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 25317, 25629);

                        return f_10091_25324_25628(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_IsReadOnlyAttribute, WellKnownMember.System_Runtime_CompilerServices_IsReadOnlyAttribute__ctor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.IsByRefLikeAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 25718, 26032);

                        return f_10091_25725_26031(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_IsByRefLikeAttribute, WellKnownMember.System_Runtime_CompilerServices_IsByRefLikeAttribute__ctor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.IsUnmanagedAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 26121, 26435);

                        return f_10091_26128_26434(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_IsUnmanagedAttribute, WellKnownMember.System_Runtime_CompilerServices_IsUnmanagedAttribute__ctor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.NullableAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 26646, 27070);

                        return f_10091_26653_27069(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_NullableAttribute, WellKnownMember.System_Runtime_CompilerServices_NullableAttribute__ctorByte, WellKnownMember.System_Runtime_CompilerServices_NullableAttribute__ctorTransformFlags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.NullableContextAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 27163, 27485);

                        return f_10091_27170_27484(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_NullableContextAttribute, WellKnownMember.System_Runtime_CompilerServices_NullableContextAttribute__ctor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.NullablePublicOnlyAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 27581, 27909);

                        return f_10091_27588_27908(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_NullablePublicOnlyAttribute, WellKnownMember.System_Runtime_CompilerServices_NullablePublicOnlyAttribute__ctor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    case EmbeddableAttributes.NativeIntegerAttribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 28125, 28560);

                        return f_10091_28132_28559(this, diagnosticsOpt, locationOpt, WellKnownType.System_Runtime_CompilerServices_NativeIntegerAttribute, WellKnownMember.System_Runtime_CompilerServices_NativeIntegerAttribute__ctor, WellKnownMember.System_Runtime_CompilerServices_NativeIntegerAttribute__ctorTransformFlags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 25198, 28677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 28610, 28662);

                        throw f_10091_28616_28661(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 25198, 28677);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 25042, 28688);

                bool
                f_10091_25324_25628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 25324, 25628);
                    return return_v;
                }


                bool
                f_10091_25725_26031(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 25725, 26031);
                    return return_v;
                }


                bool
                f_10091_26128_26434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 26128, 26434);
                    return return_v;
                }


                bool
                f_10091_26653_27069(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor, Microsoft.CodeAnalysis.WellKnownMember
                secondAttributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor, (Microsoft.CodeAnalysis.WellKnownMember?)secondAttributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 26653, 27069);
                    return return_v;
                }


                bool
                f_10091_27170_27484(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 27170, 27484);
                    return return_v;
                }


                bool
                f_10091_27588_27908(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 27588, 27908);
                    return return_v;
                }


                bool
                f_10091_28132_28559(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt, Microsoft.CodeAnalysis.WellKnownType
                attributeType, Microsoft.CodeAnalysis.WellKnownMember
                attributeCtor, Microsoft.CodeAnalysis.WellKnownMember
                secondAttributeCtor)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(diagnosticsOpt, locationOpt, attributeType, attributeCtor, (Microsoft.CodeAnalysis.WellKnownMember?)secondAttributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 28132, 28559);
                    return return_v;
                }


                System.Exception
                f_10091_28616_28661(Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 28616, 28661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 25042, 28688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 25042, 28688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckIfAttributeShouldBeEmbedded(DiagnosticBag? diagnosticsOpt, Location? locationOpt, WellKnownType attributeType, WellKnownMember attributeCtor, WellKnownMember? secondAttributeCtor = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 28700, 30094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 28929, 28988);

                var
                userDefinedAttribute = f_10091_28956_28987(this, attributeType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29004, 30054) || true) && (userDefinedAttribute is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29004, 30054);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29091, 29548) || true) && (f_10091_29095_29113(f_10091_29095_29102()) == OutputKind.NetModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29091, 29548);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29179, 29435) || true) && (diagnosticsOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29179, 29435);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29255, 29358);

                            var
                            errorReported = f_10091_29275_29357(userDefinedAttribute, diagnosticsOpt, locationOpt)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29384, 29412);

                            f_10091_29384_29411(errorReported);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29179, 29435);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29091, 29548);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29091, 29548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29517, 29529);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29091, 29548);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29004, 30054);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29004, 30054);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29582, 30054) || true) && (diagnosticsOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29582, 30054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29726, 29819);

                        var
                        member = f_10091_29739_29818(this, attributeCtor, diagnosticsOpt, locationOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29837, 30039) || true) && (member != null && (DynAbs.Tracing.TraceSender.Expression_True(10091, 29841, 29886) && secondAttributeCtor != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 29837, 30039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 29928, 30020);

                            f_10091_29928_30019(this, f_10091_29964_29989(secondAttributeCtor), diagnosticsOpt, locationOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29837, 30039);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29582, 30054);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 29004, 30054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30070, 30083);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 28700, 30094);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_28956_28987(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 28956, 28987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10091_29095_29102()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 29095, 29102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10091_29095_29113(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 29095, 29113);
                    return return_v;
                }


                bool
                f_10091_29275_29357(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 29275, 29357);
                    return return_v;
                }


                int
                f_10091_29384_29411(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 29384, 29411);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10091_29739_29818(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 29739, 29818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownMember
                f_10091_29964_29989(Microsoft.CodeAnalysis.WellKnownMember?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 29964, 29989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10091_29928_30019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 29928, 30019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 28700, 30094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 28700, 30094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeDebuggableAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 30106, 34681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30197, 30301);

                TypeSymbol
                debuggableAttribute = f_10091_30230_30300(this, WellKnownType.System_Diagnostics_DebuggableAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30315, 30412);

                f_10091_30315_30411((object)debuggableAttribute != null, "GetWellKnownType unexpectedly returned null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30426, 30539) || true) && (debuggableAttribute is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 30426, 30539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30512, 30524);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 30426, 30539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30555, 30674);

                TypeSymbol
                debuggingModesType = f_10091_30587_30673(this, WellKnownType.System_Diagnostics_DebuggableAttribute__DebuggingModes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30688, 30790);

                f_10091_30688_30789((object)debuggingModesType != null, "GetWellKnownType unexpectedly returned null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30804, 30916) || true) && (debuggingModesType is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 30804, 30916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 30889, 30901);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 30804, 30916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 31626, 31804);

                var
                ignoreSymbolStoreDebuggingMode = (FieldSymbol?)f_10091_31677_31803(this, WellKnownMember.System_Diagnostics_DebuggableAttribute_DebuggingModes__IgnoreSymbolStoreSequencePoints)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 31818, 31973) || true) && (ignoreSymbolStoreDebuggingMode is null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 31822, 31912) || f_10091_31864_31912_M(!ignoreSymbolStoreDebuggingMode.HasConstantValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 31818, 31973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 31946, 31958);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 31818, 31973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 31989, 32139);

                int
                constantVal = f_10091_32007_32138(f_10091_32007_32127(ignoreSymbolStoreDebuggingMode, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 32638, 33759) || true) && (f_10091_32642_32668(_options) == OptimizationLevel.Debug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 32638, 33759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 32729, 32873);

                    var
                    defaultDebuggingMode = (FieldSymbol?)f_10091_32770_32872(this, WellKnownMember.System_Diagnostics_DebuggableAttribute_DebuggingModes__Default)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 32891, 33038) || true) && (defaultDebuggingMode is null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 32895, 32965) || f_10091_32927_32965_M(!defaultDebuggingMode.HasConstantValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 32891, 33038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33007, 33019);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 32891, 33038);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33058, 33228);

                    var
                    disableOptimizationsDebuggingMode = (FieldSymbol?)f_10091_33112_33227(this, WellKnownMember.System_Diagnostics_DebuggableAttribute_DebuggingModes__DisableOptimizations)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33246, 33419) || true) && (disableOptimizationsDebuggingMode is null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 33250, 33346) || f_10091_33295_33346_M(!disableOptimizationsDebuggingMode.HasConstantValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 33246, 33419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33388, 33400);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 33246, 33419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33439, 33576);

                    constantVal |= f_10091_33454_33575(f_10091_33454_33564(defaultDebuggingMode, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33594, 33744);

                    constantVal |= f_10091_33609_33743(f_10091_33609_33732(disableOptimizationsDebuggingMode, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 32638, 33759);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33775, 34346) || true) && (f_10091_33779_33809(_options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 33775, 34346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 33843, 34003);

                    var
                    enableEncDebuggingMode = (FieldSymbol?)f_10091_33886_34002(this, WellKnownMember.System_Diagnostics_DebuggableAttribute_DebuggingModes__EnableEditAndContinue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 34021, 34172) || true) && (enableEncDebuggingMode is null || (DynAbs.Tracing.TraceSender.Expression_False(10091, 34025, 34099) || f_10091_34059_34099_M(!enableEncDebuggingMode.HasConstantValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 34021, 34172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 34141, 34153);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 34021, 34172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 34192, 34331);

                    constantVal |= f_10091_34207_34330(f_10091_34207_34319(enableEncDebuggingMode, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 33775, 34346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 34362, 34466);

                var
                typedConstantDebugMode = f_10091_34391_34465(debuggingModesType, TypedConstantKind.Enum, constantVal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 34482, 34670);

                return f_10091_34489_34669(this, WellKnownMember.System_Diagnostics_DebuggableAttribute__ctorDebuggingModes, f_10091_34623_34668(typedConstantDebugMode));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 30106, 34681);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_30230_30300(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 30230, 30300);
                    return return_v;
                }


                int
                f_10091_30315_30411(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 30315, 30411);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_30587_30673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 30587, 30673);
                    return return_v;
                }


                int
                f_10091_30688_30789(bool
                b, string
                message)
                {
                    RoslynDebug.Assert(b, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 30688, 30789);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_31677_31803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 31677, 31803);
                    return return_v;
                }


                bool
                f_10091_31864_31912_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 31864, 31912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10091_32007_32127(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 32007, 32127);
                    return return_v;
                }


                int
                f_10091_32007_32138(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 32007, 32138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10091_32642_32668(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 32642, 32668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_32770_32872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 32770, 32872);
                    return return_v;
                }


                bool
                f_10091_32927_32965_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 32927, 32965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_33112_33227(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 33112, 33227);
                    return return_v;
                }


                bool
                f_10091_33295_33346_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 33295, 33346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10091_33454_33564(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 33454, 33564);
                    return return_v;
                }


                int
                f_10091_33454_33575(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 33454, 33575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10091_33609_33732(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 33609, 33732);
                    return return_v;
                }


                int
                f_10091_33609_33743(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 33609, 33743);
                    return return_v;
                }


                bool
                f_10091_33779_33809(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.EnableEditAndContinue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 33779, 33809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10091_33886_34002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 33886, 34002);
                    return return_v;
                }


                bool
                f_10091_34059_34099_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 34059, 34099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10091_34207_34319(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 34207, 34319);
                    return return_v;
                }


                int
                f_10091_34207_34330(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 34207, 34330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_34391_34465(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 34391, 34465);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_34623_34668(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 34623, 34668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_34489_34669(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 34489, 34669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 30106, 34681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 30106, 34681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeDynamicAttribute(TypeSymbol type, int customModifiersCount, RefKind refKindOpt = RefKind.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 35103, 36329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35267, 35308);

                f_10091_35267_35307((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35322, 35359);

                f_10091_35322_35358(f_10091_35335_35357(type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35375, 36318) || true) && (f_10091_35379_35395(type) && (DynAbs.Tracing.TraceSender.Expression_True(10091, 35379, 35425) && refKindOpt == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10091, 35379, 35454) && customModifiersCount == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 35375, 36318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35488, 35590);

                    return f_10091_35495_35589(this, WellKnownMember.System_Runtime_CompilerServices_DynamicAttribute__ctor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 35375, 36318);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 35375, 36318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35656, 35729);

                    NamedTypeSymbol
                    booleanType = f_10091_35686_35728(this, SpecialType.System_Boolean)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35747, 35795);

                    f_10091_35747_35794((object)booleanType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35813, 35919);

                    var
                    transformFlags = f_10091_35834_35918(type, refKindOpt, customModifiersCount, booleanType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 35937, 36056);

                    var
                    boolArray = f_10091_35953_36055(f_10091_35983_36013(booleanType), TypeWithAnnotations.Create(booleanType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36074, 36158);

                    var
                    arguments = f_10091_36090_36157(f_10091_36112_36156(boolArray, transformFlags))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36176, 36303);

                    return f_10091_36183_36302(this, WellKnownMember.System_Runtime_CompilerServices_DynamicAttribute__ctorTransformFlags, arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 35375, 36318);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 35103, 36329);

                int
                f_10091_35267_35307(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35267, 35307);
                    return 0;
                }


                bool
                f_10091_35335_35357(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35335, 35357);
                    return return_v;
                }


                int
                f_10091_35322_35358(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35322, 35358);
                    return 0;
                }


                bool
                f_10091_35379_35395(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35379, 35395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_35495_35589(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35495, 35589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_35686_35728(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35686, 35728);
                    return return_v;
                }


                int
                f_10091_35747_35794(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35747, 35794);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_35834_35918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.RefKind
                refKind, int
                customModifiersCount, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                booleanType)
                {
                    var return_v = DynamicTransformsEncoder.Encode(type, refKind, customModifiersCount, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)booleanType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35834, 35918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_35983_36013(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 35983, 36013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10091_35953_36055(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 35953, 36055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_36112_36156(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36112, 36156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_36090_36157(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36090, 36157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_36183_36302(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36183, 36302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 35103, 36329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 35103, 36329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeTupleNamesAttribute(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 36341, 37220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36447, 36488);

                f_10091_36447_36487((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36502, 36537);

                f_10091_36502_36536(f_10091_36515_36535(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36553, 36612);

                var
                stringType = f_10091_36570_36611(this, SpecialType.System_String)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36626, 36673);

                f_10091_36626_36672((object)stringType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36687, 36742);

                var
                names = f_10091_36699_36741(type, stringType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36758, 36842);

                f_10091_36758_36841(f_10091_36771_36787_M(!names.IsDefault), "should not need the attribute when no tuple names");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36858, 36977);

                var
                stringArray = f_10091_36876_36976(f_10091_36906_36935(stringType), TypeWithAnnotations.Create(stringType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 36991, 37063);

                var
                args = f_10091_37002_37062(f_10091_37024_37061(stringArray, names))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 37077, 37209);

                return f_10091_37084_37208(this, WellKnownMember.System_Runtime_CompilerServices_TupleElementNamesAttribute__ctorTransformNames, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 36341, 37220);

                int
                f_10091_36447_36487(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36447, 36487);
                    return 0;
                }


                bool
                f_10091_36515_36535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTuple();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36515, 36535);
                    return return_v;
                }


                int
                f_10091_36502_36536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36502, 36536);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_36570_36611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36570, 36611);
                    return return_v;
                }


                int
                f_10091_36626_36672(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36626, 36672);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_36699_36741(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stringType)
                {
                    var return_v = TupleNamesEncoder.Encode(type, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)stringType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36699, 36741);
                    return return_v;
                }


                bool
                f_10091_36771_36787_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 36771, 36787);
                    return return_v;
                }


                int
                f_10091_36758_36841(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36758, 36841);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10091_36906_36935(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 36906, 36935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10091_36876_36976(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 36876, 36976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_37024_37061(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37024, 37061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_37002_37062(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37002, 37062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_37084_37208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37084, 37208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 36341, 37220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 36341, 37220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData? SynthesizeAttributeUsageAttribute(AttributeTargets targets, bool allowMultiple, bool inherited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 37232, 38278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 37387, 37470);

                var
                attributeTargetsType = f_10091_37414_37469(this, WellKnownType.System_AttributeTargets)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 37484, 37542);

                var
                boolType = f_10091_37499_37541(this, SpecialType.System_Boolean)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 37556, 37686);

                var
                arguments = f_10091_37572_37685(f_10091_37612_37684(attributeTargetsType, TypedConstantKind.Enum, targets))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 37700, 38142);

                var
                namedArguments = f_10091_37721_38141(f_10091_37761_37945(WellKnownMember.System_AttributeUsageAttribute__AllowMultiple, f_10091_37873_37944(boolType, TypedConstantKind.Primitive, allowMultiple)), f_10091_37964_38140(WellKnownMember.System_AttributeUsageAttribute__Inherited, f_10091_38072_38139(boolType, TypedConstantKind.Primitive, inherited)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38156, 38267);

                return f_10091_38163_38266(this, WellKnownMember.System_AttributeUsageAttribute__ctor, arguments, namedArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 37232, 38278);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_37414_37469(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37414, 37469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10091_37499_37541(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37499, 37541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_37612_37684(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, System.AttributeTargets
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37612, 37684);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10091_37572_37685(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37572, 37685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_37873_37944(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37873, 37944);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                f_10091_37761_37945(Microsoft.CodeAnalysis.WellKnownMember
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37761, 37945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10091_38072_38139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38072, 38139);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                f_10091_37964_38140(Microsoft.CodeAnalysis.WellKnownMember
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37964, 38140);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                f_10091_37721_38141(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                item1, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 37721, 38141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10091_38163_38266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38163, 38266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 37232, 38278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 37232, 38278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal static class TupleNamesEncoder
        {
            public static ImmutableArray<string?> Encode(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 38354, 38753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38448, 38503);

                    var
                    namesBuilder = f_10091_38467_38502()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38523, 38677) || true) && (!f_10091_38528_38559(type, namesBuilder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 38523, 38677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38601, 38621);

                        f_10091_38601_38620(namesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38643, 38658);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 38523, 38677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38697, 38738);

                    return f_10091_38704_38737(namesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 38354, 38753);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    f_10091_38467_38502()
                    {
                        var return_v = ArrayBuilder<string?>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38467, 38502);
                        return return_v;
                    }


                    bool
                    f_10091_38528_38559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    namesBuilder)
                    {
                        var return_v = TryGetNames(type, namesBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38528, 38559);
                        return return_v;
                    }


                    int
                    f_10091_38601_38620(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38601, 38620);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<string?>
                    f_10091_38704_38737(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38704, 38737);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 38354, 38753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 38354, 38753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static ImmutableArray<TypedConstant> Encode(TypeSymbol type, TypeSymbol stringType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 38769, 39389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38892, 38947);

                    var
                    namesBuilder = f_10091_38911_38946()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 38967, 39121) || true) && (!f_10091_38972_39003(type, namesBuilder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 38967, 39121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39045, 39065);

                        f_10091_39045_39064(namesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39087, 39102);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 38967, 39121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39141, 39305);

                    var
                    names = f_10091_39153_39304(namesBuilder, (name, constantType) =>
                                        new TypedConstant(constantType, TypedConstantKind.Primitive, name), stringType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39323, 39343);

                    f_10091_39323_39342(namesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39361, 39374);

                    return names;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 38769, 39389);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    f_10091_38911_38946()
                    {
                        var return_v = ArrayBuilder<string?>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38911, 38946);
                        return return_v;
                    }


                    bool
                    f_10091_38972_39003(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    namesBuilder)
                    {
                        var return_v = TryGetNames(type, namesBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 38972, 39003);
                        return return_v;
                    }


                    int
                    f_10091_39045_39064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 39045, 39064);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10091_39153_39304(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    items, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.TypedConstant>
                    map, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    arg)
                    {
                        var return_v = items.SelectAsArray<string?, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.TypedConstant>(map, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 39153, 39304);
                        return return_v;
                    }


                    int
                    f_10091_39323_39342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 39323, 39342);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 38769, 39389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 38769, 39389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static bool TryGetNames(TypeSymbol type, ArrayBuilder<string?> namesBuilder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 39405, 39678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39523, 39599);

                    f_10091_39523_39598(type, (t, builder, _ignore) => AddNames(t, builder), namesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39617, 39663);

                    return f_10091_39624_39662(namesBuilder, name => name != null);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 39405, 39678);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10091_39523_39598(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>, bool, bool>
                    predicate, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    arg)
                    {
                        var return_v = type.VisitType<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>>(predicate, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 39523, 39598);
                        return return_v;
                    }


                    bool
                    f_10091_39624_39662(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    builder, System.Func<string, bool>
                    predicate)
                    {
                        var return_v = builder.Any<string?>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 39624, 39662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 39405, 39678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 39405, 39678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool AddNames(TypeSymbol type, ArrayBuilder<string?> namesBuilder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 39694, 40735);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39808, 40638) || true) && (f_10091_39812_39828(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 39808, 40638);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 39870, 40619) || true) && (type.TupleElementNames.IsDefaultOrEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 39870, 40619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 40379, 40452);

                            f_10091_40379_40451(                        // If none of the tuple elements have names, put
                                                                        // null placeholders in.
                                                                        // TODO(https://github.com/dotnet/roslyn/issues/12347):
                                                                        // A possible optimization could be to emit an empty attribute
                                                                        // if all the names are missing, but that has to be true
                                                                        // recursively.
                                                    namesBuilder, null, type.TupleElementTypesWithAnnotations.Length);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 39870, 40619);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 39870, 40619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 40550, 40596);

                            f_10091_40550_40595(namesBuilder, f_10091_40572_40594(type));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 39870, 40619);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 39808, 40638);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 40707, 40720);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 39694, 40735);

                    bool
                    f_10091_39812_39828(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 39812, 39828);
                        return return_v;
                    }


                    int
                    f_10091_40379_40451(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param, string?
                    item, int
                    count)
                    {
                        this_param.AddMany(item, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 40379, 40451);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<string>
                    f_10091_40572_40594(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TupleElementNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 40572, 40594);
                        return return_v;
                    }


                    int
                    f_10091_40550_40595(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                    this_param, System.Collections.Immutable.ImmutableArray<string>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 40550, 40595);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 39694, 40735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 39694, 40735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TupleNamesEncoder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10091, 38290, 40746);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10091, 38290, 40746);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 38290, 40746);
            }

        }
        internal static class DynamicTransformsEncoder
        {
            internal static ImmutableArray<TypedConstant> Encode(TypeSymbol type, RefKind refKind, int customModifiersCount, TypeSymbol booleanType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 40958, 41646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41127, 41179);

                    var
                    flagsBuilder = f_10091_41146_41178()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41197, 41285);

                    f_10091_41197_41284(type, customModifiersCount, refKind, flagsBuilder, addCustomModifierFlags: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41303, 41336);

                    f_10091_41303_41335(f_10091_41316_41334(flagsBuilder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41354, 41396);

                    f_10091_41354_41395(f_10091_41367_41394(flagsBuilder, true));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41416, 41561);

                    var
                    result = f_10091_41429_41560(flagsBuilder, (flag, constantType) => new TypedConstant(constantType, TypedConstantKind.Primitive, flag), booleanType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41579, 41599);

                    f_10091_41579_41598(flagsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41617, 41631);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 40958, 41646);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    f_10091_41146_41178()
                    {
                        var return_v = ArrayBuilder<bool>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41146, 41178);
                        return return_v;
                    }


                    int
                    f_10091_41197_41284(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, int
                    customModifiersCount, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder, bool
                    addCustomModifierFlags)
                    {
                        Encode(type, customModifiersCount, refKind, transformFlagsBuilder, addCustomModifierFlags: addCustomModifierFlags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41197, 41284);
                        return 0;
                    }


                    bool
                    f_10091_41316_41334(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param)
                    {
                        var return_v = this_param.Any();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41316, 41334);
                        return return_v;
                    }


                    int
                    f_10091_41303_41335(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41303, 41335);
                        return 0;
                    }


                    bool
                    f_10091_41367_41394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41367, 41394);
                        return return_v;
                    }


                    int
                    f_10091_41354_41395(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41354, 41395);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10091_41429_41560(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    items, System.Func<bool, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.TypedConstant>
                    map, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    arg)
                    {
                        var return_v = items.SelectAsArray<bool, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.TypedConstant>(map, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41429, 41560);
                        return return_v;
                    }


                    int
                    f_10091_41579_41598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41579, 41598);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 40958, 41646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 40958, 41646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static ImmutableArray<bool> Encode(TypeSymbol type, RefKind refKind, int customModifiersCount)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 41662, 42015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41798, 41845);

                    var
                    builder = f_10091_41812_41844()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41863, 41946);

                    f_10091_41863_41945(type, customModifiersCount, refKind, builder, addCustomModifierFlags: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 41964, 42000);

                    return f_10091_41971_41999(builder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 41662, 42015);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    f_10091_41812_41844()
                    {
                        var return_v = ArrayBuilder<bool>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41812, 41844);
                        return return_v;
                    }


                    int
                    f_10091_41863_41945(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, int
                    customModifiersCount, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder, bool
                    addCustomModifierFlags)
                    {
                        Encode(type, customModifiersCount, refKind, transformFlagsBuilder, addCustomModifierFlags: addCustomModifierFlags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41863, 41945);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<bool>
                    f_10091_41971_41999(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 41971, 41999);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 41662, 42015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 41662, 42015);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static ImmutableArray<bool> EncodeWithoutCustomModifierFlags(TypeSymbol type, RefKind refKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 42031, 42367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42167, 42214);

                    var
                    builder = f_10091_42181_42213()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42232, 42298);

                    f_10091_42232_42297(type, -1, refKind, builder, addCustomModifierFlags: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42316, 42352);

                    return f_10091_42323_42351(builder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 42031, 42367);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    f_10091_42181_42213()
                    {
                        var return_v = ArrayBuilder<bool>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42181, 42213);
                        return return_v;
                    }


                    int
                    f_10091_42232_42297(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, int
                    customModifiersCount, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder, bool
                    addCustomModifierFlags)
                    {
                        Encode(type, customModifiersCount, refKind, transformFlagsBuilder, addCustomModifierFlags: addCustomModifierFlags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42232, 42297);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<bool>
                    f_10091_42323_42351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42323, 42351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 42031, 42367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 42031, 42367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static void Encode(TypeSymbol type, int customModifiersCount, RefKind refKind, ArrayBuilder<bool> transformFlagsBuilder, bool addCustomModifierFlags)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 42383, 43564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42574, 42617);

                    f_10091_42574_42616(!f_10091_42588_42615(transformFlagsBuilder));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42637, 42869) || true) && (refKind != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 42637, 42869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42817, 42850);

                        f_10091_42817_42849(                    // Native compiler encodes an extra transform flag, always false, for ref/out parameters.
                                            transformFlagsBuilder, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 42637, 42869);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 42889, 43549) || true) && (addCustomModifierFlags)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 42889, 43549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 43070, 43137);

                        f_10091_43070_43136(customModifiersCount, transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 43159, 43303);

                        f_10091_43159_43302(type, (typeSymbol, builder, isNested) => AddFlags(typeSymbol, builder, isNested, addCustomModifierFlags: true), transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 42889, 43549);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 42889, 43549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 43385, 43530);

                        f_10091_43385_43529(type, (typeSymbol, builder, isNested) => AddFlags(typeSymbol, builder, isNested, addCustomModifierFlags: false), transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 42889, 43549);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 42383, 43564);

                    bool
                    f_10091_42588_42615(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param)
                    {
                        var return_v = this_param.Any();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42588, 42615);
                        return return_v;
                    }


                    int
                    f_10091_42574_42616(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42574, 42616);
                        return 0;
                    }


                    int
                    f_10091_42817_42849(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 42817, 42849);
                        return 0;
                    }


                    int
                    f_10091_43070_43136(int
                    customModifiersCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder)
                    {
                        HandleCustomModifiers(customModifiersCount, transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 43070, 43136);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10091_43159_43302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool, bool>
                    predicate, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    arg)
                    {
                        var return_v = type.VisitType<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>>(predicate, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 43159, 43302);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10091_43385_43529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool, bool>
                    predicate, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    arg)
                    {
                        var return_v = type.VisitType<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>>(predicate, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 43385, 43529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 42383, 43564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 42383, 43564);
                }
            }

            private static bool AddFlags(TypeSymbol type, ArrayBuilder<bool> transformFlagsBuilder, bool isNestedNamedType, bool addCustomModifierFlags)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 43580, 48310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 43845, 46364);

                    switch (f_10091_43853_43866(type))
                    {

                        case TypeKind.Dynamic:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 43845, 46364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 43956, 43988);

                            f_10091_43956_43987(transformFlagsBuilder, true);
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 44014, 44020);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 43845, 46364);

                        case TypeKind.Array:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 43845, 46364);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44090, 44321) || true) && (addCustomModifierFlags)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 44090, 44321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44174, 44294);

                                f_10091_44174_44293(((ArrayTypeSymbol)type).ElementTypeWithAnnotations.CustomModifiers.Length, transformFlagsBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 44090, 44321);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44349, 44382);

                            f_10091_44349_44381(
                                                    transformFlagsBuilder, false);
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 44408, 44414);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 43845, 46364);

                        case TypeKind.Pointer:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 43845, 46364);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44486, 44721) || true) && (addCustomModifierFlags)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 44486, 44721);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44570, 44694);

                                f_10091_44570_44693(((PointerTypeSymbol)type).PointedAtTypeWithAnnotations.CustomModifiers.Length, transformFlagsBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 44486, 44721);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44749, 44782);

                            f_10091_44749_44781(
                                                    transformFlagsBuilder, false);
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 44808, 44814);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 43845, 46364);

                        case TypeKind.FunctionPointer:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 43845, 46364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44894, 44927);

                            f_10091_44894_44926(!isNestedNamedType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 44953, 45059);

                            f_10091_44953_45058(type, transformFlagsBuilder, addCustomModifierFlags);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 45508, 45520);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 43845, 46364);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 43845, 46364);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 46173, 46313) || true) && (!isNestedNamedType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 46173, 46313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 46253, 46286);

                                f_10091_46253_46285(transformFlagsBuilder, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 46173, 46313);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 46339, 46345);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 43845, 46364);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 46427, 46440);

                    return false;

                    static void handleFunctionPointerType(FunctionPointerTypeSymbol funcPtr, ArrayBuilder<bool> transformFlagsBuilder, bool addCustomModifierFlags)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 46460, 48295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 46644, 46925);

                            Func<TypeSymbol, (ArrayBuilder<bool>, bool), bool, bool>
                            visitor =
                                                    (TypeSymbol type, (ArrayBuilder<bool> builder, bool addCustomModifierFlags) param, bool isNestedNamedType) => AddFlags(type, param.builder, isNestedNamedType, param.addCustomModifierFlags)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47019, 47052);

                            f_10091_47019_47051(
                                                // The function pointer type itself gets a false
                                                transformFlagsBuilder, false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47076, 47104);

                            var
                            sig = f_10091_47086_47103(funcPtr)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47126, 47201);

                            f_10091_47126_47200(f_10091_47133_47144(sig), f_10091_47146_47168(sig), f_10091_47170_47199(sig));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47225, 47409);
                                foreach (var param in f_10091_47247_47261_I(f_10091_47247_47261(sig)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 47225, 47409);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47311, 47386);

                                    f_10091_47311_47385(f_10091_47318_47331(param), f_10091_47333_47357(param), f_10091_47359_47384(param));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 47225, 47409);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10091, 1, 185);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10091, 1, 185);
                            }
                            void handle(RefKind refKind, ImmutableArray<CustomModifier> customModifiers, TypeWithAnnotations twa)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 47433, 48276);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47583, 47763) || true) && (addCustomModifierFlags)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 47583, 47763);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47667, 47736);

                                        f_10091_47667_47735(customModifiers.Length, transformFlagsBuilder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 47583, 47763);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47791, 47936) || true) && (refKind != RefKind.None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 47791, 47936);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47876, 47909);

                                        f_10091_47876_47908(transformFlagsBuilder, false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 47791, 47936);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 47964, 48148) || true) && (addCustomModifierFlags)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 47964, 48148);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 48048, 48121);

                                        f_10091_48048_48120(twa.CustomModifiers.Length, transformFlagsBuilder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 47964, 48148);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 48176, 48253);

                                    f_10091_48176_48252(
                                                            twa.Type, visitor, (transformFlagsBuilder, addCustomModifierFlags));
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 47433, 48276);

                                    int
                                    f_10091_47667_47735(int
                                    customModifiersCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                                    transformFlagsBuilder)
                                    {
                                        HandleCustomModifiers(customModifiersCount, transformFlagsBuilder);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47667, 47735);
                                        return 0;
                                    }


                                    int
                                    f_10091_47876_47908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                                    this_param, bool
                                    item)
                                    {
                                        this_param.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47876, 47908);
                                        return 0;
                                    }


                                    int
                                    f_10091_48048_48120(int
                                    customModifiersCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                                    transformFlagsBuilder)
                                    {
                                        HandleCustomModifiers(customModifiersCount, transformFlagsBuilder);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 48048, 48120);
                                        return 0;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                                    f_10091_48176_48252(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                    type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, (Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool), bool, bool>
                                    predicate, (Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool> transformFlagsBuilder, bool addCustomModifierFlags)
                                    arg)
                                    {
                                        var return_v = type.VisitType<(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool)>(predicate, ((Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool))arg);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 48176, 48252);
                                        return return_v;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 47433, 48276);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 47433, 48276);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 46460, 48295);

                            int
                            f_10091_47019_47051(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                            this_param, bool
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47019, 47051);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                            f_10091_47086_47103(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.Signature;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47086, 47103);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.RefKind
                            f_10091_47133_47144(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                            this_param)
                            {
                                var return_v = this_param.RefKind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47133, 47144);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                            f_10091_47146_47168(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                            this_param)
                            {
                                var return_v = this_param.RefCustomModifiers;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47146, 47168);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                            f_10091_47170_47199(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                            this_param)
                            {
                                var return_v = this_param.ReturnTypeWithAnnotations;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47170, 47199);
                                return return_v;
                            }


                            int
                            f_10091_47126_47200(Microsoft.CodeAnalysis.RefKind
                            refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                            customModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                            twa)
                            {
                                handle(refKind, customModifiers, twa);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47126, 47200);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                            f_10091_47247_47261(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                            this_param)
                            {
                                var return_v = this_param.Parameters;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47247, 47261);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.RefKind
                            f_10091_47318_47331(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                            this_param)
                            {
                                var return_v = this_param.RefKind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47318, 47331);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                            f_10091_47333_47357(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                            this_param)
                            {
                                var return_v = this_param.RefCustomModifiers;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47333, 47357);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                            f_10091_47359_47384(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                            this_param)
                            {
                                var return_v = this_param.TypeWithAnnotations;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 47359, 47384);
                                return return_v;
                            }


                            int
                            f_10091_47311_47385(Microsoft.CodeAnalysis.RefKind
                            refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                            customModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                            twa)
                            {
                                handle(refKind, customModifiers, twa);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47311, 47385);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                            f_10091_47247_47261_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 47247, 47261);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 46460, 48295);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 46460, 48295);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 43580, 48310);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10091_43853_43866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 43853, 43866);
                        return return_v;
                    }


                    int
                    f_10091_43956_43987(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 43956, 43987);
                        return 0;
                    }


                    int
                    f_10091_44174_44293(int
                    customModifiersCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder)
                    {
                        HandleCustomModifiers(customModifiersCount, transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44174, 44293);
                        return 0;
                    }


                    int
                    f_10091_44349_44381(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44349, 44381);
                        return 0;
                    }


                    int
                    f_10091_44570_44693(int
                    customModifiersCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder)
                    {
                        HandleCustomModifiers(customModifiersCount, transformFlagsBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44570, 44693);
                        return 0;
                    }


                    int
                    f_10091_44749_44781(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44749, 44781);
                        return 0;
                    }


                    int
                    f_10091_44894_44926(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44894, 44926);
                        return 0;
                    }


                    int
                    f_10091_44953_45058(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    funcPtr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    transformFlagsBuilder, bool
                    addCustomModifierFlags)
                    {
                        handleFunctionPointerType((Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)funcPtr, transformFlagsBuilder, addCustomModifierFlags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 44953, 45058);
                        return 0;
                    }


                    int
                    f_10091_46253_46285(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 46253, 46285);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 43580, 48310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 43580, 48310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void HandleCustomModifiers(int customModifiersCount, ArrayBuilder<bool> transformFlagsBuilder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 48326, 48652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 48578, 48637);

                    f_10091_48578_48636(                // Native compiler encodes an extra transforms flag, always false, for each custom modifier.
                                    transformFlagsBuilder, false, customModifiersCount);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 48326, 48652);

                    int
                    f_10091_48578_48636(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item, int
                    count)
                    {
                        this_param.AddMany(item, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 48578, 48636);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 48326, 48652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 48326, 48652);
                }
            }

            static DynamicTransformsEncoder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10091, 40887, 48663);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10091, 40887, 48663);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 40887, 48663);
            }

        }
        internal static class NativeIntegerTransformsEncoder
        {
            internal static void Encode(ArrayBuilder<bool> builder, TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 48752, 48962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 48857, 48947);

                    f_10091_48857_48946(type, (typeSymbol, builder, isNested) => AddFlags(typeSymbol, builder), builder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 48752, 48962);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10091_48857_48946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>, bool, bool>
                    predicate, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    arg)
                    {
                        var return_v = type.VisitType<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>>(predicate, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 48857, 48946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 48752, 48962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 48752, 48962);
                }
            }

            private static bool AddFlags(TypeSymbol type, ArrayBuilder<bool> builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10091, 48978, 49439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 49084, 49350);

                    switch (f_10091_49092_49108(type))
                    {

                        case SpecialType.System_IntPtr:
                        case SpecialType.System_UIntPtr:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 49084, 49350);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 49261, 49299);

                            f_10091_49261_49298(builder, f_10091_49273_49297(type));
                            DynAbs.Tracing.TraceSender.TraceBreak(10091, 49325, 49331);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 49084, 49350);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 49411, 49424);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10091, 48978, 49439);

                    Microsoft.CodeAnalysis.SpecialType
                    f_10091_49092_49108(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 49092, 49108);
                        return return_v;
                    }


                    bool
                    f_10091_49273_49297(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNativeIntegerType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 49273, 49297);
                        return return_v;
                    }


                    int
                    f_10091_49261_49298(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                    this_param, bool
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 49261, 49298);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 48978, 49439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 48978, 49439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NativeIntegerTransformsEncoder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10091, 48675, 49450);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10091, 48675, 49450);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 48675, 49450);
            }

        }
        internal class SpecialMembersSignatureComparer : SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
        {
            public static readonly SpecialMembersSignatureComparer Instance;

            protected SpecialMembersSignatureComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10091, 49792, 49865);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10091, 49792, 49865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 49792, 49865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 49792, 49865);
                }
            }

            protected override TypeSymbol? GetMDArrayElementType(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 49881, 50325);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 49983, 50093) || true) && (f_10091_49987_49996(type) != SymbolKind.ArrayType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 49983, 50093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50062, 50074);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 49983, 50093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50111, 50157);

                    ArrayTypeSymbol
                    array = (ArrayTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50175, 50267) || true) && (f_10091_50179_50194(array))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 50175, 50267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50236, 50248);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 50175, 50267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50285, 50310);

                    return f_10091_50292_50309(array);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 49881, 50325);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_49987_49996(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 49987, 49996);
                        return return_v;
                    }


                    bool
                    f_10091_50179_50194(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50179, 50194);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_50292_50309(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50292, 50309);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 49881, 50325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 49881, 50325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol GetFieldType(FieldSymbol field)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 50341, 50468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50435, 50453);

                    return f_10091_50442_50452(field);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 50341, 50468);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_50442_50452(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50442, 50452);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 50341, 50468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 50341, 50468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol GetPropertyType(PropertySymbol property)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 50484, 50623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50587, 50608);

                    return f_10091_50594_50607(property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 50484, 50623);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_50594_50607(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50594, 50607);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 50484, 50623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 50484, 50623);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol? GetGenericTypeArgument(TypeSymbol type, int argumentIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 50639, 51304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50761, 50871) || true) && (f_10091_50765_50774(type) != SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 50761, 50871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50840, 50852);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 50761, 50871);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50889, 50935);

                    NamedTypeSymbol
                    named = (NamedTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 50953, 51058) || true) && (f_10091_50957_50968(named) <= argumentIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 50953, 51058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51027, 51039);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 50953, 51058);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51076, 51189) || true) && ((object)f_10091_51088_51108(named) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 51076, 51189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51158, 51170);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 51076, 51189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51207, 51289);

                    return f_10091_51214_51268(named)[argumentIndex].Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 50639, 51304);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_50765_50774(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50765, 50774);
                        return return_v;
                    }


                    int
                    f_10091_50957_50968(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 50957, 50968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10091_51088_51108(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51088, 51108);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10091_51214_51268(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51214, 51268);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 50639, 51304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 50639, 51304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol? GetGenericTypeDefinition(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 51320, 51923);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51425, 51535) || true) && (f_10091_51429_51438(type) != SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 51425, 51535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51504, 51516);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 51425, 51535);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51553, 51599);

                    NamedTypeSymbol
                    named = (NamedTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51617, 51730) || true) && ((object)f_10091_51629_51649(named) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 51617, 51730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51699, 51711);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 51617, 51730);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51748, 51841) || true) && (f_10091_51752_51763(named) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 51748, 51841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51810, 51822);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 51748, 51841);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 51859, 51908);

                    return (NamedTypeSymbol)f_10091_51883_51907(named);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 51320, 51923);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_51429_51438(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51429, 51438);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10091_51629_51649(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51629, 51649);
                        return return_v;
                    }


                    int
                    f_10091_51752_51763(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51752, 51763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10091_51883_51907(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 51883, 51907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 51320, 51923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 51320, 51923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override ImmutableArray<ParameterSymbol> GetParameters(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 51939, 52097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52057, 52082);

                    return f_10091_52064_52081(method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 51939, 52097);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10091_52064_52081(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52064, 52081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 51939, 52097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 51939, 52097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override ImmutableArray<ParameterSymbol> GetParameters(PropertySymbol property)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 52113, 52277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52235, 52262);

                    return f_10091_52242_52261(property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 52113, 52277);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10091_52242_52261(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52242, 52261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 52113, 52277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 52113, 52277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol GetParamType(ParameterSymbol parameter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 52293, 52432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52395, 52417);

                    return f_10091_52402_52416(parameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 52293, 52432);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_52402_52416(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52402, 52416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 52293, 52432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 52293, 52432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol? GetPointedToType(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 52448, 52652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52545, 52637);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10091, 52552, 52587) || ((f_10091_52552_52561(type) == SymbolKind.PointerType && DynAbs.Tracing.TraceSender.Conditional_F2(10091, 52590, 52629)) || DynAbs.Tracing.TraceSender.Conditional_F3(10091, 52632, 52636))) ? f_10091_52590_52629(((PointerTypeSymbol)type)) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 52448, 52652);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_52552_52561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52552, 52561);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_52590_52629(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52590, 52629);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 52448, 52652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 52448, 52652);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol GetReturnType(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 52668, 52805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52765, 52790);

                    return f_10091_52772_52789(method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 52668, 52805);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_52772_52789(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52772, 52789);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 52668, 52805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 52668, 52805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override TypeSymbol? GetSZArrayElementType(TypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 52821, 53266);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 52923, 53033) || true) && (f_10091_52927_52936(type) != SymbolKind.ArrayType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 52923, 53033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53002, 53014);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 52923, 53033);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53051, 53097);

                    ArrayTypeSymbol
                    array = (ArrayTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53115, 53208) || true) && (f_10091_53119_53135_M(!array.IsSZArray))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 53115, 53208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53177, 53189);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 53115, 53208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53226, 53251);

                    return f_10091_53233_53250(array);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 52821, 53266);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_52927_52936(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 52927, 52936);
                        return return_v;
                    }


                    bool
                    f_10091_53119_53135_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53119, 53135);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_53233_53250(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53233, 53250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 52821, 53266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 52821, 53266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsByRefParam(ParameterSymbol parameter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 53282, 53434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53378, 53419);

                    return f_10091_53385_53402(parameter) != RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 53282, 53434);

                    Microsoft.CodeAnalysis.RefKind
                    f_10091_53385_53402(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53385, 53402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 53282, 53434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 53282, 53434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsByRefMethod(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 53450, 53594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53541, 53579);

                    return f_10091_53548_53562(method) != RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 53450, 53594);

                    Microsoft.CodeAnalysis.RefKind
                    f_10091_53548_53562(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53548, 53562);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 53450, 53594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 53450, 53594);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsByRefProperty(PropertySymbol property)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 53610, 53762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53707, 53747);

                    return f_10091_53714_53730(property) != RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 53610, 53762);

                    Microsoft.CodeAnalysis.RefKind
                    f_10091_53714_53730(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53714, 53730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 53610, 53762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 53610, 53762);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsGenericMethodTypeParam(TypeSymbol type, int paramPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 53778, 54311);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53895, 54010) || true) && (f_10091_53899_53908(type) != SymbolKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 53895, 54010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 53978, 53991);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 53895, 54010);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54028, 54086);

                    TypeParameterSymbol
                    typeParam = (TypeParameterSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54104, 54234) || true) && (f_10091_54108_54139(f_10091_54108_54134(typeParam)) != SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 54104, 54234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54202, 54215);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 54104, 54234);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54252, 54296);

                    return (f_10091_54260_54277(typeParam) == paramPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 53778, 54311);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_53899_53908(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 53899, 53908);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10091_54108_54134(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54108, 54134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_54108_54139(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54108, 54139);
                        return return_v;
                    }


                    int
                    f_10091_54260_54277(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54260, 54277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 53778, 54311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 53778, 54311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool IsGenericTypeParam(TypeSymbol type, int paramPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 54327, 54857);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54438, 54553) || true) && (f_10091_54442_54451(type) != SymbolKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 54438, 54553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54521, 54534);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 54438, 54553);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54571, 54629);

                    TypeParameterSymbol
                    typeParam = (TypeParameterSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54647, 54780) || true) && (f_10091_54651_54682(f_10091_54651_54677(typeParam)) != SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 54647, 54780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54748, 54761);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 54647, 54780);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54798, 54842);

                    return (f_10091_54806_54823(typeParam) == paramPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 54327, 54857);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_54442_54451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54442, 54451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10091_54651_54677(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54651, 54677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_54651_54682(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54651, 54682);
                        return return_v;
                    }


                    int
                    f_10091_54806_54823(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54806, 54823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 54327, 54857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 54327, 54857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool MatchArrayRank(TypeSymbol type, int countOfDimensions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 54873, 55235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 54984, 55095) || true) && (f_10091_54988_54997(type) != SymbolKind.ArrayType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 54984, 55095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55063, 55076);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 54984, 55095);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55115, 55161);

                    ArrayTypeSymbol
                    array = (ArrayTypeSymbol)type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55179, 55220);

                    return (f_10091_55187_55197(array) == countOfDimensions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 54873, 55235);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10091_54988_54997(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 54988, 54997);
                        return return_v;
                    }


                    int
                    f_10091_55187_55197(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 55187, 55197);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 54873, 55235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 54873, 55235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool MatchTypeToTypeId(TypeSymbol type, int typeId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 55251, 55749);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55354, 55701) || true) && ((int)f_10091_55363_55398(f_10091_55363_55386(type)) == typeId)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 55354, 55701);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55450, 55556) || true) && (f_10091_55454_55471(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 55450, 55556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55521, 55533);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 55450, 55556);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55580, 55682);

                        return f_10091_55587_55681(type, f_10091_55599_55622(type), TypeCompareKind.IgnoreNullableModifiersForReferenceTypes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 55354, 55701);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55721, 55734);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 55251, 55749);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_55363_55386(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 55363, 55386);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10091_55363_55398(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 55363, 55398);
                        return return_v;
                    }


                    bool
                    f_10091_55454_55471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 55454, 55471);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10091_55599_55622(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10091, 55599, 55622);
                        return return_v;
                    }


                    bool
                    f_10091_55587_55681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 55587, 55681);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 55251, 55749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 55251, 55749);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SpecialMembersSignatureComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10091, 49462, 55760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 49703, 49751);
                Instance = f_10091_49714_49751(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10091, 49462, 55760);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 49462, 55760);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10091, 49462, 55760);

            static Microsoft.CodeAnalysis.CSharp.CSharpCompilation.SpecialMembersSignatureComparer
            f_10091_49714_49751()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilation.SpecialMembersSignatureComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 49714, 49751);
                return return_v;
            }

        }
        internal sealed class WellKnownMembersSignatureComparer : SpecialMembersSignatureComparer
        {
            private readonly CSharpCompilation _compilation;

            public WellKnownMembersSignatureComparer(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10091, 55950, 56096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 55921, 55933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 56054, 56081);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10091, 55950, 56096);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 55950, 56096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 55950, 56096);
                }
            }

            protected override bool MatchTypeToTypeId(TypeSymbol type, int typeId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10091, 56112, 56577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 56215, 56265);

                    WellKnownType
                    wellKnownId = (WellKnownType)typeId
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 56283, 56498) || true) && (f_10091_56287_56316(wellKnownId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10091, 56283, 56498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 56358, 56479);

                        return f_10091_56365_56478(type, f_10091_56377_56419(_compilation, wellKnownId), TypeCompareKind.IgnoreNullableModifiersForReferenceTypes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10091, 56283, 56498);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10091, 56518, 56562);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.MatchTypeToTypeId(type, typeId), 10091, 56525, 56561);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10091, 56112, 56577);

                    bool
                    f_10091_56287_56316(Microsoft.CodeAnalysis.WellKnownType
                    typeId)
                    {
                        var return_v = typeId.IsWellKnownType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 56287, 56316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10091_56377_56419(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 56377, 56419);
                        return return_v;
                    }


                    bool
                    f_10091_56365_56478(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10091, 56365, 56478);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10091, 56112, 56577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 56112, 56577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WellKnownMembersSignatureComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10091, 55772, 56588);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10091, 55772, 56588);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10091, 55772, 56588);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10091, 55772, 56588);
        }
    }
}
