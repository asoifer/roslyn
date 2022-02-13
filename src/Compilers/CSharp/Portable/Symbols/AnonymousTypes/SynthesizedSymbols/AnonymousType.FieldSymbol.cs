// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed class AnonymousTypeFieldSymbol : FieldSymbol
        {
            private readonly PropertySymbol _property;

            public AnonymousTypeFieldSymbol(PropertySymbol property)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10424, 807, 989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 781, 790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 896, 935);

                    f_10424_896_934((object)property != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 953, 974);

                    _property = property;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10424, 807, 989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 807, 989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 807, 989);
                }
            }

            internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1005, 1180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1128, 1165);

                    return f_10424_1135_1164(_property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1005, 1180);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10424_1135_1164(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 1135, 1164);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1005, 1180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1005, 1180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1256, 1336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1262, 1334);

                        return f_10424_1269_1333(f_10424_1318_1332(_property));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1256, 1336);

                        string
                        f_10424_1318_1332(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 1318, 1332);
                            return return_v;
                        }


                        string
                        f_10424_1269_1333(string
                        propertyName)
                        {
                            var return_v = GeneratedNames.MakeAnonymousTypeBackingFieldName(propertyName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 1269, 1333);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1196, 1351);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1196, 1351);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override FlowAnalysisAnnotations FlowAnalysisAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1448, 1479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1451, 1479);
                        return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1448, 1479);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1448, 1479);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1448, 1479);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1566, 1587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1572, 1585);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1566, 1587);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1496, 1602);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1496, 1602);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1695, 1716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1701, 1714);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1695, 1716);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1618, 1731);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1618, 1731);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsNotSerialized
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1818, 1839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1824, 1837);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1818, 1839);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1747, 1854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1747, 1854);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override MarshalPseudoCustomAttributeData MarshallingInformation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 1976, 1996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 1982, 1994);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 1976, 1996);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 1870, 2011);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 1870, 2011);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override int? TypeLayoutOffset
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2099, 2119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2105, 2117);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2099, 2119);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2027, 2134);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2027, 2134);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Symbol AssociatedSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2222, 2302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2266, 2283);

                        return _property;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2222, 2302);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2150, 2317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2150, 2317);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2397, 2417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2403, 2415);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2397, 2417);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2333, 2432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2333, 2432);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsVolatile
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2512, 2533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2518, 2531);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2512, 2533);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2448, 2548);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2448, 2548);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsConst
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2625, 2646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2631, 2644);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2625, 2646);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2564, 2661);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2564, 2661);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2778, 2798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2784, 2796);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2778, 2798);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2677, 2813);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2677, 2813);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 2829, 3013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 2986, 2998);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 2829, 3013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 2829, 3013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 2829, 3013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3101, 3141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 3107, 3139);

                        return f_10424_3114_3138(_property);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3101, 3141);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10424_3114_3138(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 3114, 3138);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3029, 3156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3029, 3156);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3251, 3346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 3295, 3327);

                        return f_10424_3302_3326(_property);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3251, 3346);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10424_3302_3326(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 3302, 3326);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3172, 3361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3172, 3361);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3460, 3506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 3466, 3504);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3460, 3506);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3377, 3521);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3377, 3521);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3643, 3751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 3687, 3732);

                        return ImmutableArray<SyntaxReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3643, 3751);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3537, 3766);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3537, 3766);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3866, 3903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 3872, 3901);

                        return Accessibility.Private;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3866, 3903);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3782, 3918);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3782, 3918);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 3996, 4017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 4002, 4015);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 3996, 4017);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 3934, 4032);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 3934, 4032);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 4122, 4142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 4128, 4140);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 4122, 4142);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 4048, 4157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 4048, 4157);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10424, 4173, 4916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 4339, 4400);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10424, 4339, 4399);

                    base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 4339, 4399);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 4420, 4512);

                    AnonymousTypeManager
                    manager = ((AnonymousTypeTemplateSymbol)f_10424_4481_4502(this)).Manager
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10424, 4532, 4901);

                    f_10424_4532_4900(ref attributes, f_10424_4572_4899(f_10424_4572_4591(manager), WellKnownMember.System_Diagnostics_DebuggerBrowsableAttribute__ctor, f_10424_4727_4898(f_10424_4775_4897(f_10424_4793_4842(manager), TypedConstantKind.Enum, DebuggerBrowsableState.Never))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10424, 4173, 4916);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10424_4481_4502(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 4481, 4502);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10424_4572_4591(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 4572, 4591);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10424_4793_4842(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Diagnostics_DebuggerBrowsableState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10424, 4793, 4842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10424_4775_4897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, System.Diagnostics.DebuggerBrowsableState
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 4775, 4897);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10424_4727_4898(Microsoft.CodeAnalysis.TypedConstant
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 4727, 4898);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10424_4572_4899(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    arguments)
                    {
                        var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 4572, 4899);
                        return return_v;
                    }


                    int
                    f_10424_4532_4900(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 4532, 4900);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10424, 4173, 4916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 4173, 4916);
                }
            }

            static AnonymousTypeFieldSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10424, 665, 4927);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10424, 665, 4927);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10424, 665, 4927);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10424, 665, 4927);

            int
            f_10424_896_934(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10424, 896, 934);
                return 0;
            }

        }
    }
}
