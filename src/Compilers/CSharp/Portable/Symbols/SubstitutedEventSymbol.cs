// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SubstitutedEventSymbol : WrappedEventSymbol
    {
        private readonly SubstitutedNamedTypeSymbol _containingType;

        private TypeWithAnnotations.Boxed? _lazyType;

        internal SubstitutedEventSymbol(SubstitutedNamedTypeSymbol containingType, EventSymbol originalDefinition)
        : base(f_10156_693_711_C(originalDefinition))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10156, 566, 841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 481, 496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 544, 553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 3206, 3236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 737, 783);

                f_10156_737_782(f_10156_750_781(originalDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 797, 830);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10156, 566, 841);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 566, 841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 566, 841);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 933, 1316);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 969, 1258) || true) && (_lazyType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10156, 969, 1258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1032, 1131);

                        var
                        type = f_10156_1043_1130(f_10156_1043_1075(_containingType), f_10156_1091_1129(f_10156_1091_1109()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1153, 1239);

                        f_10156_1153_1238(ref _lazyType, f_10156_1196_1231(type), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10156, 969, 1258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1278, 1301);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 933, 1316);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10156_1043_1075(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSubstitution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1043, 1075);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_1091_1109()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1091, 1109);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10156_1091_1129(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1091, 1129);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10156_1043_1130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 1043, 1130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10156_1196_1231(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 1196, 1231);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10156_1153_1238(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 1153, 1238);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 853, 1327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 853, 1327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 1403, 1477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1439, 1462);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 1403, 1477);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 1339, 1488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 1339, 1488);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override EventSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 1571, 1646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1607, 1631);

                    return _underlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 1571, 1646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 1500, 1657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 1500, 1657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 1669, 1814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1761, 1803);

                return f_10156_1768_1802(f_10156_1768_1786());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 1669, 1814);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10156_1768_1786()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1768, 1786);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10156_1768_1802(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 1768, 1802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 1669, 1814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 1669, 1814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MethodSymbol? AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 1890, 2117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 1926, 1989);

                    MethodSymbol?
                    originalAddMethod = f_10156_1960_1988(f_10156_1960_1978())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2007, 2102);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10156, 2014, 2048) || (((object?)originalAddMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10156, 2051, 2055)) || DynAbs.Tracing.TraceSender.Conditional_F3(10156, 2058, 2101))) ? null : f_10156_2058_2101(originalAddMethod, _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 1890, 2117);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_1960_1978()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1960, 1978);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10156_1960_1988(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 1960, 1988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10156_2058_2101(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 2058, 2101);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 1826, 2128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 1826, 2128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 2207, 2446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2243, 2312);

                    MethodSymbol?
                    originalRemoveMethod = f_10156_2280_2311(f_10156_2280_2298())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2330, 2431);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10156, 2337, 2374) || (((object?)originalRemoveMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10156, 2377, 2381)) || DynAbs.Tracing.TraceSender.Conditional_F3(10156, 2384, 2430))) ? null : f_10156_2384_2430(originalRemoveMethod, _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 2207, 2446);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_2280_2298()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2280, 2298);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10156_2280_2311(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2280, 2311);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10156_2384_2430(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 2384, 2430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 2140, 2457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 2140, 2457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FieldSymbol? AssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 2540, 2790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2576, 2650);

                    FieldSymbol?
                    originalAssociatedField = f_10156_2615_2649(f_10156_2615_2633())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2668, 2775);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10156, 2675, 2715) || (((object?)originalAssociatedField == null && DynAbs.Tracing.TraceSender.Conditional_F2(10156, 2718, 2722)) || DynAbs.Tracing.TraceSender.Conditional_F3(10156, 2725, 2774))) ? null : f_10156_2725_2774(originalAssociatedField, _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 2540, 2790);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_2615_2633()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2615, 2633);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                    f_10156_2615_2649(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2615, 2649);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10156_2725_2774(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 2725, 2774);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 2469, 2801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 2469, 2801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 2894, 2962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 2900, 2960);

                    return f_10156_2907_2959(f_10156_2907_2925());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 2894, 2962);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_2907_2925()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2907, 2925);
                        return return_v;
                    }


                    bool
                    f_10156_2907_2959(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 2907, 2959);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 2813, 2973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 2813, 2973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<EventSymbol> _lazyExplicitInterfaceImplementations;

        private OverriddenOrHiddenMembersResult? _lazyOverriddenOrHiddenMembers;

        public override ImmutableArray<EventSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 3350, 3937);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 3386, 3859) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10156, 3386, 3859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 3479, 3840);

                        f_10156_3479_3839(ref _lazyExplicitInterfaceImplementations, f_10156_3621_3775(f_10156_3689_3740(f_10156_3689_3707()), f_10156_3742_3774(_containingType)), default(ImmutableArray<EventSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10156, 3386, 3859);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 3877, 3922);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 3350, 3937);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_3689_3707()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 3689, 3707);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10156_3689_3740(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 3689, 3740);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10156_3742_3774(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSubstitution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 3742, 3774);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10156_3621_3775(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    unsubstitutedExplicitInterfaceImplementations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    map)
                    {
                        var return_v = ExplicitInterfaceHelpers.SubstituteExplicitInterfaceImplementations(unsubstitutedExplicitInterfaceImplementations, map);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 3621, 3775);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10156_3479_3839(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 3479, 3839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 3249, 3948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 3249, 3948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 4031, 4089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 4037, 4087);

                    return f_10156_4044_4086(f_10156_4044_4062());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 4031, 4089);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_4044_4062()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 4044, 4062);
                        return return_v;
                    }


                    bool
                    f_10156_4044_4086(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.MustCallMethodsDirectly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 4044, 4086);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 3960, 4100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 3960, 4100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 4212, 4530);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 4248, 4459) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10156, 4248, 4459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 4332, 4440);

                        f_10156_4332_4439(ref _lazyOverriddenOrHiddenMembers, f_10156_4396_4432(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10156, 4248, 4459);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 4477, 4515);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 4212, 4530);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10156_4396_4432(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedEventSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 4396, 4432);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10156_4332_4439(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 4332, 4439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 4112, 4541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 4112, 4541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsWindowsRuntimeEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10156, 4620, 5112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10156, 5049, 5097);

                    return f_10156_5056_5096(f_10156_5056_5074());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10156, 4620, 5112);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10156_5056_5074()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 5056, 5074);
                        return return_v;
                    }


                    bool
                    f_10156_5056_5096(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsWindowsRuntimeEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 5056, 5096);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10156, 4553, 5123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 4553, 5123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SubstitutedEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10156, 355, 5130);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10156, 355, 5130);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10156, 355, 5130);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10156, 355, 5130);

        bool
        f_10156_750_781(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10156, 750, 781);
            return return_v;
        }


        int
        f_10156_737_782(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10156, 737, 782);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        f_10156_693_711_C(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10156, 566, 841);
            return return_v;
        }

    }
}
