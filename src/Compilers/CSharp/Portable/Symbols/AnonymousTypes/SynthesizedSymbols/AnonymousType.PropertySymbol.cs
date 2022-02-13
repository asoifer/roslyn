// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        internal sealed class AnonymousTypePropertySymbol : PropertySymbol
        {
            private readonly NamedTypeSymbol _containingType;

            private readonly TypeWithAnnotations _typeWithAnnotations;

            private readonly string _name;

            private readonly int _index;

            private readonly ImmutableArray<Location> _locations;

            private readonly AnonymousTypePropertyGetAccessorSymbol _getMethod;

            private readonly FieldSymbol _backingField;

            internal AnonymousTypePropertySymbol(AnonymousTypeTemplateSymbol container, AnonymousTypeField field, TypeWithAnnotations fieldTypeWithAnnotations, int index) : this(f_10427_1307_1316_C(container), field, fieldTypeWithAnnotations, index, ImmutableArray<Location>.Empty, includeBackingField: true)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10427, 1124, 1446);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10427, 1124, 1446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 1124, 1446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 1124, 1446);
                }
            }

            internal AnonymousTypePropertySymbol(AnonymousTypePublicSymbol container, AnonymousTypeField field, int index) : this(f_10427_1597_1606_C(container), field, field.TypeWithAnnotations, index, f_10427_1649_1696(field.Location), includeBackingField: false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10427, 1462, 1755);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10427, 1462, 1755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 1462, 1755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 1462, 1755);
                }
            }

            private AnonymousTypePropertySymbol(
                            NamedTypeSymbol container,
                            AnonymousTypeField field,
                            TypeWithAnnotations fieldTypeWithAnnotations,
                            int index,
                            ImmutableArray<Location> locations,
                            bool includeBackingField)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10427, 1771, 2787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 729, 744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 855, 860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 896, 902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 1040, 1050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 1094, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2114, 2154);

                    f_10427_2114_2153((object)container != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2172, 2208);

                    f_10427_2172_2207((object)field != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2226, 2273);

                    f_10427_2226_2272(fieldTypeWithAnnotations.HasType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2291, 2316);

                    f_10427_2291_2315(index >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2334, 2369);

                    f_10427_2334_2368(f_10427_2347_2367_M(!locations.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2389, 2417);

                    _containingType = container;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2435, 2483);

                    _typeWithAnnotations = fieldTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2501, 2520);

                    _name = field.Name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2538, 2553);

                    _index = index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2571, 2594);

                    _locations = locations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2612, 2674);

                    _getMethod = f_10427_2625_2673(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2692, 2772);

                    _backingField = (DynAbs.Tracing.TraceSender.Conditional_F1(10427, 2708, 2727) || ((includeBackingField && DynAbs.Tracing.TraceSender.Conditional_F2(10427, 2730, 2764)) || DynAbs.Tracing.TraceSender.Conditional_F3(10427, 2767, 2771))) ? f_10427_2730_2764(this) : null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10427, 1771, 2787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 1771, 2787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 1771, 2787);
                }
            }

            internal override int? MemberIndexOpt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 2841, 2850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2844, 2850);
                        return _index; DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 2841, 2850);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 2841, 2850);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 2841, 2850);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 2931, 2959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 2937, 2957);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 2931, 2959);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 2867, 2974);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 2867, 2974);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeWithAnnotations TypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3078, 3114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3084, 3112);

                        return _typeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3078, 3114);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 2990, 3129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 2990, 3129);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3205, 3226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3211, 3224);

                        return _name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3205, 3226);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3145, 3241);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3145, 3241);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3327, 3348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3333, 3346);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3327, 3348);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3257, 3363);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3257, 3363);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3453, 3474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3459, 3472);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3453, 3474);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3379, 3489);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3379, 3489);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3588, 3614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3594, 3612);

                        return _locations;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3588, 3614);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3505, 3629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3505, 3629);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 3751, 3910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 3795, 3891);

                        return f_10427_3802_3890(f_10427_3875_3889(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 3751, 3910);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10427_3875_3889(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 3875, 3889);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                        f_10427_3802_3890(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        locations)
                        {
                            var return_v = GetDeclaringSyntaxReferenceHelper<AnonymousObjectMemberDeclaratorSyntax>(locations);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 3802, 3890);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3645, 3925);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3645, 3925);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4003, 4024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4009, 4022);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4003, 4024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 3941, 4039);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 3941, 4039);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4119, 4140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4125, 4138);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4119, 4140);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4055, 4155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4055, 4155);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4234, 4255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4240, 4253);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4234, 4255);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4171, 4270);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4171, 4270);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsIndexer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4349, 4370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4355, 4368);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4349, 4370);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4286, 4385);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4286, 4385);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4463, 4484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4469, 4482);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4463, 4484);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4401, 4499);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4401, 4499);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4579, 4600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4585, 4598);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4579, 4600);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4515, 4615);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4515, 4615);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override ObsoleteAttributeData ObsoleteAttributeData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4732, 4752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4738, 4750);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4732, 4752);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4631, 4767);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4631, 4767);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<ParameterSymbol> Parameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 4874, 4927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 4880, 4925);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 4874, 4927);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4783, 4942);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4783, 4942);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override MethodSymbol SetMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5029, 5049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5035, 5047);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5029, 5049);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 4958, 5064);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 4958, 5064);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5178, 5230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5184, 5228);

                        return ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5178, 5230);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5080, 5245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5080, 5245);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5361, 5416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5367, 5414);

                        return Microsoft.Cci.CallingConvention.HasThis;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5361, 5416);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5261, 5431);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5261, 5431);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5559, 5611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5565, 5609);

                        return ImmutableArray<PropertySymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5559, 5611);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5447, 5626);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5447, 5626);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5714, 5745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5720, 5743);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5714, 5745);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5642, 5760);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5642, 5760);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 5855, 5941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 5899, 5922);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 5855, 5941);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5776, 5956);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5776, 5956);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6056, 6092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6062, 6090);

                        return Accessibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6056, 6092);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 5972, 6107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 5972, 6107);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6202, 6223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6208, 6221);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6202, 6223);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 6123, 6238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 6123, 6238);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6316, 6337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6322, 6335);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6316, 6337);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 6254, 6352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 6254, 6352);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override MethodSymbol GetMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6439, 6465);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6445, 6463);

                        return _getMethod;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6439, 6465);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 6368, 6480);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 6368, 6480);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public FieldSymbol BackingField
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6560, 6589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6566, 6587);

                        return _backingField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6560, 6589);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 6496, 6604);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 6496, 6604);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(Symbol obj, TypeCompareKind compareKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 6620, 7428);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6721, 6936) || true) && (obj == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10427, 6721, 6936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6778, 6791);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10427, 6721, 6936);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10427, 6721, 6936);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6833, 6936) || true) && (f_10427_6837_6863(this, obj))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10427, 6833, 6936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6905, 6917);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10427, 6833, 6936);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10427, 6721, 6936);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 6956, 7003);

                    var
                    other = obj as AnonymousTypePropertySymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 7021, 7120) || true) && ((object)other == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10427, 7021, 7120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 7088, 7101);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10427, 7021, 7120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 7269, 7413);

                    return ((object)other != null) && (DynAbs.Tracing.TraceSender.Expression_True(10427, 7276, 7326) && f_10427_7303_7313(other) == f_10427_7317_7326(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10427, 7276, 7412) && f_10427_7351_7412(f_10427_7351_7371(other), f_10427_7379_7398(this), compareKind));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 6620, 7428);

                    bool
                    f_10427_6837_6863(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 6837, 6863);
                        return return_v;
                    }


                    string
                    f_10427_7303_7313(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7303, 7313);
                        return return_v;
                    }


                    string
                    f_10427_7317_7326(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7317, 7326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10427_7351_7371(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7351, 7371);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10427_7379_7398(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7379, 7398);
                        return return_v;
                    }


                    bool
                    f_10427_7351_7412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 7351, 7412);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 6620, 7428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 6620, 7428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10427, 7444, 7605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10427, 7510, 7590);

                    return f_10427_7517_7589(f_10427_7530_7563(f_10427_7530_7549(this)), f_10427_7565_7588(f_10427_7565_7574(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10427, 7444, 7605);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10427_7530_7549(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7530, 7549);
                        return return_v;
                    }


                    int
                    f_10427_7530_7563(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 7530, 7563);
                        return return_v;
                    }


                    string
                    f_10427_7565_7574(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 7565, 7574);
                        return return_v;
                    }


                    int
                    f_10427_7565_7588(string
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 7565, 7588);
                        return return_v;
                    }


                    int
                    f_10427_7517_7589(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 7517, 7589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10427, 7444, 7605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 7444, 7605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AnonymousTypePropertySymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10427, 605, 7616);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10427, 605, 7616);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10427, 605, 7616);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10427, 605, 7616);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10427_1307_1316_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10427, 1124, 1446);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
            f_10427_1649_1696(Microsoft.CodeAnalysis.Location
            item)
            {
                var return_v = ImmutableArray.Create<Location>(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 1649, 1696);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10427_1597_1606_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10427, 1462, 1755);
                return return_v;
            }


            int
            f_10427_2114_2153(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2114, 2153);
                return 0;
            }


            int
            f_10427_2172_2207(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2172, 2207);
                return 0;
            }


            int
            f_10427_2226_2272(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2226, 2272);
                return 0;
            }


            int
            f_10427_2291_2315(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2291, 2315);
                return 0;
            }


            bool
            f_10427_2347_2367_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10427, 2347, 2367);
                return return_v;
            }


            int
            f_10427_2334_2368(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2334, 2368);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertyGetAccessorSymbol
            f_10427_2625_2673(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            property)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertyGetAccessorSymbol(property);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2625, 2673);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeFieldSymbol
            f_10427_2730_2764(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            property)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10427, 2730, 2764);
                return return_v;
            }

        }
    }
}
