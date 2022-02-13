// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class IteratorConstructor : SynthesizedInstanceConstructor, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly ImmutableArray<ParameterSymbol> _parameters;

        internal IteratorConstructor(StateMachineTypeSymbol container)
        : base(f_10465_919_928_C(container))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10465, 836, 1280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 954, 1040);

                var
                intType = f_10465_968_1039(f_10465_968_998(container), SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1054, 1269);

                _parameters = f_10465_1068_1268(f_10465_1125_1267(this, TypeWithAnnotations.Create(intType), 0, RefKind.None, f_10465_1219_1266()));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10465, 836, 1280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 836, 1280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 836, 1280);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10465, 1292, 1738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1450, 1511);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10465, 1450, 1510);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1450, 1510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1527, 1571);

                var
                compilation = f_10465_1545_1570(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1585, 1727);

                f_10465_1585_1726(ref attributes, f_10465_1625_1725(compilation, WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10465, 1292, 1738);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10465_1545_1570(Microsoft.CodeAnalysis.CSharp.IteratorConstructor
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10465, 1545, 1570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10465_1625_1725(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1625, 1725);
                    return return_v;
                }


                int
                f_10465_1585_1726(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1585, 1726);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 1292, 1738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 1292, 1738);
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10465, 1833, 1860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1839, 1858);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10465, 1833, 1860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 1750, 1871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 1750, 1871);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10465, 1959, 1995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 1965, 1993);

                    return Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10465, 1959, 1995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 1883, 2006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 1883, 2006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10465, 2114, 2204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 2120, 2202);

                    return f_10465_2127_2201(((ISynthesizedMethodBodyImplementationSymbol)f_10465_2172_2193(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10465, 2114, 2204);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10465_2172_2193(Microsoft.CodeAnalysis.CSharp.IteratorConstructor
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10465, 2172, 2193);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                    f_10465_2127_2201(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10465, 2127, 2201);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 2018, 2215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 2018, 2215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10465, 2323, 2344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10465, 2329, 2342);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10465, 2323, 2344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10465, 2227, 2355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 2227, 2355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static IteratorConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10465, 628, 2362);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10465, 628, 2362);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10465, 628, 2362);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10465, 628, 2362);

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10465_968_998(Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10465, 968, 998);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10465_968_1039(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 968, 1039);
            return return_v;
        }


        string
        f_10465_1219_1266()
        {
            var return_v = GeneratedNames.MakeStateMachineStateFieldName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1219, 1266);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10465_1125_1267(Microsoft.CodeAnalysis.CSharp.IteratorConstructor
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, int
        ordinal, Microsoft.CodeAnalysis.RefKind
        refKind, string
        name)
        {
            var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1125, 1267);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10465_1068_1268(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        item)
        {
            var return_v = ImmutableArray.Create<ParameterSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10465, 1068, 1268);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10465_919_928_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10465, 836, 1280);
            return return_v;
        }

    }
}
