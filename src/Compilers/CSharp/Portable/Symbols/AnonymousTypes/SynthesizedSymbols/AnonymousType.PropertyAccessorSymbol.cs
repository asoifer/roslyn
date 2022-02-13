// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed partial class AnonymousTypePropertyGetAccessorSymbol : SynthesizedMethodBase
        {
            private readonly AnonymousTypePropertySymbol _property;

            internal AnonymousTypePropertyGetAccessorSymbol(AnonymousTypePropertySymbol property)
            : base(f_10426_978_1001_C(f_10426_978_1001(property)), f_10426_1003_1101(f_10426_1048_1061(property), getNotSet: true, isWinMdOutput: false))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10426, 775, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 749, 758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1135, 1156);

                    _property = property;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10426, 775, 1171);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 775, 1171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 775, 1171);
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1257, 1295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1263, 1293);

                        return MethodKind.PropertyGet;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1257, 1295);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1187, 1310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1187, 1310);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool ReturnsVoid
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1391, 1412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1397, 1410);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1391, 1412);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1326, 1427);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1326, 1427);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1507, 1535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1513, 1533);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1507, 1535);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1443, 1550);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1443, 1550);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeWithAnnotations ReturnTypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1660, 1705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1666, 1703);

                        return f_10426_1673_1702(_property);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1660, 1705);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10426_1673_1702(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10426, 1673, 1702);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1566, 1720);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1566, 1720);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1827, 1880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1833, 1878);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1827, 1880);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1736, 1895);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1736, 1895);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 1983, 2008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 1989, 2006);

                        return _property;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 1983, 2008);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 1911, 2023);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 1911, 2023);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 2122, 2318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 2272, 2299);

                        return f_10426_2279_2298(_property);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 2122, 2318);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10426_2279_2298(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10426, 2279, 2298);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 2039, 2333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 2039, 2333);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 2413, 2434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 2419, 2432);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 2413, 2434);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 2349, 2449);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 2349, 2449);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 2465, 2624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 2596, 2609);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 2465, 2624);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 2465, 2624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 2465, 2624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 2711, 2787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10426, 2755, 2768);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 2711, 2787);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 2640, 2802);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 2640, 2802);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10426, 2818, 3130);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10426, 2818, 3130);
                    // Do not call base.AddSynthesizedAttributes.
                    // Dev11 does not emit DebuggerHiddenAttribute in property accessors
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10426, 2818, 3130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10426, 2818, 3130);
                }
            }

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10426_978_1001(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            this_param)
            {
                var return_v = this_param.ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10426, 978, 1001);
                return return_v;
            }


            static string
            f_10426_1048_1061(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10426, 1048, 1061);
                return return_v;
            }


            static string
            f_10426_1003_1101(string
            propertyName, bool
            getNotSet, bool
            isWinMdOutput)
            {
                var return_v = SourcePropertyAccessorSymbol.GetAccessorName(propertyName, getNotSet: getNotSet, isWinMdOutput: isWinMdOutput);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10426, 1003, 1101);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10426_978_1001_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10426, 775, 1171);
                return return_v;
            }

        }
    }
}
