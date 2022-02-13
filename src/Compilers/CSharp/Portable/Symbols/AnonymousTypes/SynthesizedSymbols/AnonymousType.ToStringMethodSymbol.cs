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
        private sealed partial class AnonymousTypeToStringMethodSymbol : SynthesizedMethodBase
        {
            internal AnonymousTypeToStringMethodSymbol(NamedTypeSymbol container)
            : base(f_10430_986_995_C(container), WellKnownMemberNames.ObjectToString)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10430, 892, 1063);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10430, 892, 1063);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 892, 1063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 892, 1063);
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1149, 1184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1155, 1182);

                        return MethodKind.Ordinary;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1149, 1184);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1079, 1199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1079, 1199);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1280, 1301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1286, 1299);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1280, 1301);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1215, 1316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1215, 1316);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1396, 1424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1402, 1422);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1396, 1424);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1332, 1439);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1332, 1439);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1549, 1652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1555, 1650);

                        return TypeWithAnnotations.Create(f_10430_1589_1615(f_10430_1589_1601(this)), NullableAnnotation.NotAnnotated);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1549, 1652);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        f_10430_1589_1601(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Manager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10430, 1589, 1601);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10430_1589_1615(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.System_String;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10430, 1589, 1615);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1455, 1667);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1455, 1667);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1774, 1827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1780, 1825);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1774, 1827);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1683, 1842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1683, 1842);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1922, 1942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 1928, 1940);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1922, 1942);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1858, 1957);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1858, 1957);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 1973, 2131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 2104, 2116);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 1973, 2131);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 1973, 2131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 1973, 2131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10430, 2218, 2294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10430, 2262, 2275);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10430, 2218, 2294);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10430, 2147, 2309);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 2147, 2309);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AnonymousTypeToStringMethodSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10430, 781, 2320);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10430, 781, 2320);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10430, 781, 2320);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10430, 781, 2320);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10430_986_995_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10430, 892, 1063);
                return return_v;
            }

        }
    }
}
