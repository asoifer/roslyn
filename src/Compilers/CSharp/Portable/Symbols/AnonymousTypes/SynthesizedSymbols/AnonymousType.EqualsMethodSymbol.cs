// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed partial class AnonymousTypeEqualsMethodSymbol : SynthesizedMethodBase
        {
            private readonly ImmutableArray<ParameterSymbol> _parameters;

            internal AnonymousTypeEqualsMethodSymbol(NamedTypeSymbol container)
            : base(f_10423_790_799_C(container), WellKnownMemberNames.ObjectEquals)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10423, 698, 1081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 868, 1066);

                    _parameters = f_10423_882_1065(f_10423_943_1064(this, TypeWithAnnotations.Create(f_10423_1010_1036(f_10423_1010_1022(this))), 0, RefKind.None, "value"));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10423, 698, 1081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 698, 1081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 698, 1081);
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1167, 1202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1173, 1200);

                        return MethodKind.Ordinary;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1167, 1202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1097, 1217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1097, 1217);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1298, 1319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1304, 1317);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1298, 1319);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1233, 1334);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1233, 1334);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1414, 1442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1420, 1440);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1414, 1442);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1350, 1457);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1350, 1457);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1567, 1638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1573, 1636);

                        return TypeWithAnnotations.Create(f_10423_1607_1634(f_10423_1607_1619(this)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1567, 1638);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        f_10423_1607_1619(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Manager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10423, 1607, 1619);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10423_1607_1634(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.System_Boolean;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10423, 1607, 1634);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1473, 1653);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1473, 1653);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1760, 1787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1766, 1785);

                        return _parameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1760, 1787);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1669, 1802);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1669, 1802);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1882, 1902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 1888, 1900);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1882, 1902);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1818, 1917);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1818, 1917);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 1933, 2091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 2064, 2076);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 1933, 2091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 1933, 2091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 1933, 2091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10423, 2178, 2254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10423, 2222, 2235);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10423, 2178, 2254);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10423, 2107, 2269);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 2107, 2269);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AnonymousTypeEqualsMethodSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10423, 512, 2280);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10423, 512, 2280);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10423, 512, 2280);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10423, 512, 2280);

            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
            f_10423_1010_1022(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
            this_param)
            {
                var return_v = this_param.Manager;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10423, 1010, 1022);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10423_1010_1036(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
            this_param)
            {
                var return_v = this_param.System_Object;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10423, 1010, 1036);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10423_943_1064(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10423, 943, 1064);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10423_882_1065(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item)
            {
                var return_v = ImmutableArray.Create<ParameterSymbol>(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10423, 882, 1065);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10423_790_799_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10423, 698, 1081);
                return return_v;
            }

        }
    }
}
