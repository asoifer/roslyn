// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed partial class AnonymousTypeGetHashCodeMethodSymbol : SynthesizedMethodBase
        {
            internal AnonymousTypeGetHashCodeMethodSymbol(NamedTypeSymbol container)
            : base(f_10425_995_1004_C(container), WellKnownMemberNames.ObjectGetHashCode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10425, 898, 1075);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10425, 898, 1075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 898, 1075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 898, 1075);
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1161, 1196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1167, 1194);

                        return MethodKind.Ordinary;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1161, 1196);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1091, 1211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1091, 1211);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1292, 1313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1298, 1311);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1292, 1313);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1227, 1328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1227, 1328);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1408, 1436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1414, 1434);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1408, 1436);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1344, 1451);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1344, 1451);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1561, 1630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1567, 1628);

                        return TypeWithAnnotations.Create(f_10425_1601_1626(f_10425_1601_1613(this)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1561, 1630);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        f_10425_1601_1613(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Manager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10425, 1601, 1613);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10425_1601_1626(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.System_Int32;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10425, 1601, 1626);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1467, 1645);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1467, 1645);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1752, 1805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1758, 1803);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1752, 1805);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1661, 1820);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1661, 1820);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1900, 1920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 1906, 1918);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1900, 1920);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1836, 1935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1836, 1935);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 1951, 2109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 2082, 2094);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 1951, 2109);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 1951, 2109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 1951, 2109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10425, 2196, 2272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10425, 2240, 2253);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10425, 2196, 2272);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10425, 2125, 2287);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 2125, 2287);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AnonymousTypeGetHashCodeMethodSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10425, 784, 2298);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10425, 784, 2298);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10425, 784, 2298);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10425, 784, 2298);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10425_995_1004_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10425, 898, 1075);
                return return_v;
            }

        }
    }
}
