// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedDelegateSymbol : SynthesizedContainer
    {
        private readonly NamespaceOrTypeSymbol _containingSymbol;

        private readonly MethodSymbol _constructor;

        private readonly MethodSymbol _invoke;

        public SynthesizedDelegateSymbol(
                    NamespaceOrTypeSymbol containingSymbol,
                    string name,
                    TypeSymbol objectType,
                    TypeSymbol intPtrType,
                    TypeSymbol voidReturnTypeOpt,
                    int parameterCount,
                    BitVector byRefParameters)
        : base(f_10667_1156_1160_C(name), parameterCount, returnsVoid: (object)voidReturnTypeOpt != null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10667, 835, 1464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 704, 721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 762, 774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 815, 822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1250, 1287);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1301, 1370);

                _constructor = f_10667_1316_1369(this, objectType, intPtrType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1384, 1453);

                _invoke = f_10667_1394_1452(this, byRefParameters, voidReturnTypeOpt);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10667, 835, 1464);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 835, 1464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 835, 1464);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 1540, 1573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1546, 1571);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 1540, 1573);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 1476, 1584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 1476, 1584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 1654, 1687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1660, 1685);

                    return TypeKind.Delegate;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 1654, 1687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 1596, 1698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 1596, 1698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodSymbol Constructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 1777, 1805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1783, 1803);

                    return _constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 1777, 1805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 1710, 1816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 1710, 1816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 1900, 1957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 1906, 1955);

                    return new[] { f_10667_1921_1938(_constructor), f_10667_1940_1952(_invoke) };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 1900, 1957);

                    string
                    f_10667_1921_1938(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 1921, 1938);
                        return return_v;
                    }


                    string
                    f_10667_1940_1952(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 1940, 1952);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 1828, 1968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 1828, 1968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 1980, 2127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2056, 2116);

                return f_10667_2063_2115(_constructor, _invoke);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 1980, 2127);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10667_2063_2115(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbol)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 2063, 2115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 1980, 2127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 1980, 2127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 2139, 2466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2226, 2455);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(10667, 2250, 2277) || (((name == f_10667_2259_2276(_constructor)) && DynAbs.Tracing.TraceSender.Conditional_F2(10667, 2280, 2323)) || DynAbs.Tracing.TraceSender.Conditional_F3(10667, 2343, 2454))) ? f_10667_2280_2323(_constructor) : (DynAbs.Tracing.TraceSender.Conditional_F1(10667, 2343, 2365) || (((name == f_10667_2352_2364(_invoke)) && DynAbs.Tracing.TraceSender.Conditional_F2(10667, 2368, 2406)) || DynAbs.Tracing.TraceSender.Conditional_F3(10667, 2426, 2454))) ? f_10667_2368_2406(_invoke) : ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 2139, 2466);

                string
                f_10667_2259_2276(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 2259, 2276);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10667_2280_2323(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 2280, 2323);
                    return return_v;
                }


                string
                f_10667_2352_2364(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 2352, 2364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10667_2368_2406(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 2368, 2406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 2139, 2466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 2139, 2466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 2554, 2592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2560, 2590);

                    return Accessibility.Internal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 2554, 2592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 2478, 2603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 2478, 2603);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 2669, 2689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2675, 2687);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 2669, 2689);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 2615, 2700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 2615, 2700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 2788, 2862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2791, 2862);
                    return f_10667_2791_2862(f_10667_2791_2809(), SpecialType.System_MulticastDelegate); DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 2788, 2862);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 2788, 2862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 2788, 2862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 2943, 2988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 2949, 2986);

                    throw f_10667_2955_2985();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 2943, 2988);

                    System.Exception
                    f_10667_2955_2985()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 2955, 2985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 2875, 2999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 2875, 2999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 3043, 3051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 3046, 3051);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 3043, 3051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 3043, 3051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3043, 3051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 3119, 3127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 3122, 3127);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 3119, 3127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 3119, 3127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3119, 3127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class DelegateConstructor : SynthesizedInstanceConstructor
        {
            private readonly ImmutableArray<ParameterSymbol> _parameters;

            public DelegateConstructor(NamedTypeSymbol containingType, TypeSymbol objectType, TypeSymbol intPtrType)
            : base(f_10667_3444_3458_C(containingType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10667, 3315, 3817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 3492, 3802);

                    _parameters = f_10667_3506_3801(f_10667_3566_3672(this, TypeWithAnnotations.Create(objectType), 0, RefKind.None, "object"), f_10667_3694_3800(this, TypeWithAnnotations.Create(intPtrType), 1, RefKind.None, "method"));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10667, 3315, 3817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 3315, 3817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3315, 3817);
                }
            }

            public override ImmutableArray<ParameterSymbol> Parameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 3924, 3951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 3930, 3949);

                        return _parameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 3924, 3951);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 3833, 3966);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3833, 3966);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DelegateConstructor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10667, 3140, 3977);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10667, 3140, 3977);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3140, 3977);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10667, 3140, 3977);

            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10667_3566_3672(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.DelegateConstructor
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 3566, 3672);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10667_3694_3800(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.DelegateConstructor
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 3694, 3800);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10667_3506_3801(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item1, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item2)
            {
                var return_v = ImmutableArray.Create<ParameterSymbol>(item1, item2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 3506, 3801);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10667_3444_3458_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10667, 3315, 3817);
                return return_v;
            }

        }
        private sealed class InvokeMethod : SynthesizedInstanceMethodSymbol
        {
            private readonly ImmutableArray<ParameterSymbol> _parameters;

            private readonly TypeSymbol _containingType;

            private readonly TypeSymbol _returnType;

            internal InvokeMethod(SynthesizedDelegateSymbol containingType, BitVector byRefParameters, TypeSymbol voidReturnTypeOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10667, 4270, 5403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4184, 4199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4242, 4253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4423, 4470);

                    var
                    typeParams = f_10667_4440_4469(containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4490, 4523);

                    _containingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4684, 4737);

                    _returnType = voidReturnTypeOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(10667, 4698, 4736) ?? typeParams.Last());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4757, 4859);

                    var
                    parameters = new ParameterSymbol[typeParams.Length - ((DynAbs.Tracing.TraceSender.Conditional_F1(10667, 4815, 4848) || (((object)voidReturnTypeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10667, 4851, 4852)) || DynAbs.Tracing.TraceSender.Conditional_F3(10667, 4855, 4856))) ? 0 : 1)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4886, 4891);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4877, 5323) || true) && (i < f_10667_4897_4914(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 4916, 4919)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10667, 4877, 5323))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10667, 4877, 5323);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5080, 5169);

                            var
                            refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10667, 5094, 5139) || ((f_10667_5094_5117_M(!byRefParameters.IsNull) && (DynAbs.Tracing.TraceSender.Expression_True(10667, 5094, 5139) && byRefParameters[i]) && DynAbs.Tracing.TraceSender.Conditional_F2(10667, 5142, 5153)) || DynAbs.Tracing.TraceSender.Conditional_F3(10667, 5156, 5168))) ? RefKind.Ref : RefKind.None
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5193, 5304);

                            parameters[i] = f_10667_5209_5303(this, TypeWithAnnotations.Create(typeParams[i]), i, refKind);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10667, 1, 447);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10667, 1, 447);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5343, 5388);

                    _parameters = f_10667_5357_5387(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10667, 4270, 5403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 4270, 5403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 4270, 5403);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 5479, 5534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5485, 5532);

                        return WellKnownMemberNames.DelegateInvokeName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 5479, 5534);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 5419, 5549);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 5419, 5549);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 5565, 5716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5689, 5701);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 5565, 5716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 5565, 5716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 5565, 5716);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 5732, 5883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 5856, 5868);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 5732, 5883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 5732, 5883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 5732, 5883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 5970, 6046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6014, 6027);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 5970, 6046);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 5899, 6061);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 5899, 6061);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6147, 6188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6153, 6186);

                        return MethodKind.DelegateInvoke;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6147, 6188);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6077, 6203);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6077, 6203);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Arity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6277, 6294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6283, 6292);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6277, 6294);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6219, 6309);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6219, 6309);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsExtensionMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6396, 6417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6402, 6415);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6396, 6417);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6325, 6432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6325, 6432);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6518, 6539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6524, 6537);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6518, 6539);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6448, 6554);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6448, 6554);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override System.Reflection.MethodImplAttributes ImplementationAttributes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6684, 6746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6690, 6744);

                        return System.Reflection.MethodImplAttributes.Runtime;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6684, 6746);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6570, 6761);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6570, 6761);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool HasDeclarativeSecurity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6855, 6876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6861, 6874);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6855, 6876);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6777, 6891);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6777, 6891);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override DllImportData GetDllImportData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 6907, 7015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 6988, 7000);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 6907, 7015);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 6907, 7015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 6907, 7015);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7031, 7203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7151, 7188);

                    throw f_10667_7157_7187();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7031, 7203);

                    System.Exception
                    f_10667_7157_7187()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 7157, 7187);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7031, 7203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7031, 7203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7336, 7356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7342, 7354);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7336, 7356);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7219, 7371);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7219, 7371);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool RequiresSecurityObject
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7465, 7486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7471, 7484);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7465, 7486);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7387, 7501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7387, 7501);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HidesBaseMethodsByName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7593, 7614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7599, 7612);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7593, 7614);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7517, 7629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7517, 7629);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsVararg
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7707, 7728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7713, 7726);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7707, 7728);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7645, 7743);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7645, 7743);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7824, 7864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7830, 7862);

                        return f_10667_7837_7861(_returnType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7824, 7864);

                        bool
                        f_10667_7837_7861(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsVoidType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 7837, 7861);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7759, 7879);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7759, 7879);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsAsync
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 7956, 7977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 7962, 7975);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 7956, 7977);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 7895, 7992);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 7895, 7992);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8072, 8100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8078, 8098);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8072, 8100);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8008, 8115);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8008, 8115);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8225, 8280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8231, 8278);

                        return TypeWithAnnotations.Create(_returnType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8225, 8280);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8131, 8295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8131, 8295);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8385, 8416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8388, 8416);
                        return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8385, 8416);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8385, 8416);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8385, 8416);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8506, 8539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8509, 8539);
                        return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8506, 8539);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8506, 8539);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8506, 8539);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8669, 8726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8675, 8724);

                        return ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8669, 8726);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8556, 8741);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8556, 8741);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<TypeParameterSymbol> TypeParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 8856, 8913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 8862, 8911);

                        return ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 8856, 8913);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8757, 8928);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8757, 8928);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9035, 9062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9041, 9060);

                        return _parameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9035, 9062);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 8944, 9077);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 8944, 9077);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9203, 9253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9209, 9251);

                        return ImmutableArray<MethodSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9203, 9253);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9093, 9268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9093, 9268);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9382, 9434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9388, 9432);

                        return ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9382, 9434);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9284, 9449);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9284, 9449);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9537, 9557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9543, 9555);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9537, 9557);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9465, 9572);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9465, 9572);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<string> GetAppliedConditionalSymbols()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9588, 9743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9692, 9728);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9588, 9743);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9588, 9743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9588, 9743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Microsoft.Cci.CallingConvention CallingConvention
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 9859, 9914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 9865, 9912);

                        return Microsoft.Cci.CallingConvention.HasThis;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 9859, 9914);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9759, 9929);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9759, 9929);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool GenerateDebugInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10018, 10039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10024, 10037);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10018, 10039);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 9945, 10054);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 9945, 10054);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10142, 10173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10148, 10171);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10142, 10173);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10070, 10188);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10070, 10188);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10287, 10333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10293, 10331);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10287, 10333);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10204, 10348);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10204, 10348);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10448, 10711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10664, 10692);

                        return Accessibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10448, 10711);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10364, 10726);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10364, 10726);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10804, 10825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10810, 10823);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10804, 10825);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10742, 10840);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10742, 10840);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 10919, 10939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 10925, 10937);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 10919, 10939);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10856, 10954);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10856, 10954);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 11034, 11055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 11040, 11053);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 11034, 11055);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 10970, 11070);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 10970, 11070);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 11150, 11171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 11156, 11169);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 11150, 11171);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 11086, 11186);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 11086, 11186);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 11264, 11285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 11270, 11283);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 11264, 11285);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 11202, 11300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 11202, 11300);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10667, 11378, 11399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10667, 11384, 11397);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10667, 11378, 11399);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10667, 11316, 11414);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 11316, 11414);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static InvokeMethod()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10667, 3989, 11425);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10667, 3989, 11425);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 3989, 11425);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10667, 3989, 11425);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            f_10667_4440_4469(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
            this_param)
            {
                var return_v = this_param.TypeParameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 4440, 4469);
                return return_v;
            }


            int
            f_10667_4897_4914(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 4897, 4914);
                return return_v;
            }


            bool
            f_10667_5094_5117_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 5094, 5117);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10667_5209_5303(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.InvokeMethod
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 5209, 5303);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10667_5357_5387(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
            items)
            {
                var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 5357, 5387);
                return return_v;
            }

        }

        static SynthesizedDelegateSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10667, 578, 11432);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10667, 578, 11432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10667, 578, 11432);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10667, 578, 11432);

        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.DelegateConstructor
        f_10667_1316_1369(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        objectType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        intPtrType)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.DelegateConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, objectType, intPtrType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 1316, 1369);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.InvokeMethod
        f_10667_1394_1452(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
        containingType, Microsoft.CodeAnalysis.BitVector
        byRefParameters, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        voidReturnTypeOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol.InvokeMethod(containingType, byRefParameters, voidReturnTypeOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 1394, 1452);
            return return_v;
        }


        static string
        f_10667_1156_1160_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10667, 835, 1464);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10667_2791_2809()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10667, 2791, 2809);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10667_2791_2862(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10667, 2791, 2862);
            return return_v;
        }

    }
}
