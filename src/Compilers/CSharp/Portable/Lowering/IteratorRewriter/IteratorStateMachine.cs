// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class IteratorStateMachine : StateMachineTypeSymbol
    {
        private readonly MethodSymbol _constructor;

        private readonly ImmutableArray<NamedTypeSymbol> _interfaces;

        internal readonly TypeWithAnnotations ElementType;

        public IteratorStateMachine(VariableSlotAllocator slotAllocatorOpt, TypeCompilationState compilationState, MethodSymbol iteratorMethod, int iteratorMethodOrdinal, bool isEnumerable, TypeWithAnnotations elementType)
        : base(f_10471_1097_1113_C(slotAllocatorOpt), compilationState, iteratorMethod, iteratorMethodOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10471, 862, 2135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 704, 716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1196, 1251);

                this.ElementType = f_10471_1215_1250(f_10471_1215_1222(), elementType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1267, 1328);

                var
                interfaces = f_10471_1284_1327()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1342, 1651) || true) && (isEnumerable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10471, 1342, 1651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1392, 1524);

                    f_10471_1392_1523(interfaces, f_10471_1407_1522(f_10471_1407_1494(f_10471_1407_1425(), SpecialType.System_Collections_Generic_IEnumerable_T), ElementType.Type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1542, 1636);

                    f_10471_1542_1635(interfaces, f_10471_1557_1634(f_10471_1557_1575(), SpecialType.System_Collections_IEnumerable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10471, 1342, 1651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1667, 1799);

                f_10471_1667_1798(
                            interfaces, f_10471_1682_1797(f_10471_1682_1769(f_10471_1682_1700(), SpecialType.System_Collections_Generic_IEnumerator_T), ElementType.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1813, 1895);

                f_10471_1813_1894(interfaces, f_10471_1828_1893(f_10471_1828_1846(), SpecialType.System_IDisposable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 1909, 2003);

                f_10471_1909_2002(interfaces, f_10471_1924_2001(f_10471_1924_1942(), SpecialType.System_Collections_IEnumerator));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2017, 2063);

                _interfaces = f_10471_2031_2062(interfaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2079, 2124);

                _constructor = f_10471_2094_2123(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10471, 862, 2135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 862, 2135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 862, 2135);
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2205, 2235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2211, 2233);

                    return TypeKind.Class;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2205, 2235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2147, 2246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2147, 2246);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2325, 2353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2331, 2351);

                    return _constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2325, 2353);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2258, 2364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2258, 2364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2376, 2552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2522, 2541);

                return _interfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2376, 2552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2376, 2552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2376, 2552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2627, 2690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2630, 2690);
                    return f_10471_2630_2690(f_10471_2630_2648(), SpecialType.System_Object); DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2627, 2690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2627, 2690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2627, 2690);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2735, 2743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2738, 2743);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2735, 2743);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2735, 2743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2735, 2743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10471, 2811, 2819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10471, 2814, 2819);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10471, 2811, 2819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10471, 2811, 2819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 2811, 2819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IteratorStateMachine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10471, 590, 2827);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10471, 590, 2827);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10471, 590, 2827);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10471, 590, 2827);

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10471_1215_1222()
        {
            var return_v = TypeMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1215, 1222);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10471_1215_1250(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        previous)
        {
            var return_v = this_param.SubstituteType(previous);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1215, 1250);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10471_1284_1327()
        {
            var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1284, 1327);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_1407_1425()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1407, 1425);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1407_1494(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1407, 1494);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1407_1522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1407, 1522);
            return return_v;
        }


        int
        f_10471_1392_1523(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1392, 1523);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_1557_1575()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1557, 1575);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1557_1634(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1557, 1634);
            return return_v;
        }


        int
        f_10471_1542_1635(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1542, 1635);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_1682_1700()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1682, 1700);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1682_1769(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1682, 1769);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1682_1797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1682, 1797);
            return return_v;
        }


        int
        f_10471_1667_1798(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1667, 1798);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_1828_1846()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1828, 1846);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1828_1893(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1828, 1893);
            return return_v;
        }


        int
        f_10471_1813_1894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1813, 1894);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_1924_1942()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 1924, 1942);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_1924_2001(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1924, 2001);
            return return_v;
        }


        int
        f_10471_1909_2002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 1909, 2002);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10471_2031_2062(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 2031, 2062);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.IteratorConstructor
        f_10471_2094_2123(Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
        container)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorConstructor((Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol)container);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 2094, 2123);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        f_10471_1097_1113_C(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10471, 862, 2135);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10471_2630_2648()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10471, 2630, 2648);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10471_2630_2690(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10471, 2630, 2690);
            return return_v;
        }

    }
}
