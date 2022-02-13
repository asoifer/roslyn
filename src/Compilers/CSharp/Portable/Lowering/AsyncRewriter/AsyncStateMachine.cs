// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AsyncStateMachine : StateMachineTypeSymbol
    {
        private readonly TypeKind _typeKind;

        private readonly MethodSymbol _constructor;

        private readonly ImmutableArray<NamedTypeSymbol> _interfaces;

        internal readonly TypeSymbol IteratorElementType;

        public AsyncStateMachine(VariableSlotAllocator variableAllocatorOpt, TypeCompilationState compilationState, MethodSymbol asyncMethod, int asyncMethodOrdinal, TypeKind typeKind)
        : base(f_10450_1127_1147_C(variableAllocatorOpt), compilationState, asyncMethod, asyncMethodOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10450, 930, 3111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 697, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 747, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 870, 889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1224, 1245);

                _typeKind = typeKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1259, 1324);

                CSharpCompilation
                compilation = f_10450_1291_1323(asyncMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1338, 1399);

                var
                interfaces = f_10450_1355_1398()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1415, 1456);

                bool
                isIterator = f_10450_1433_1455(asyncMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1470, 2796) || true) && (isIterator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10450, 1470, 2796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1518, 1612);

                    var
                    elementType = f_10450_1536_1606(f_10450_1536_1543(), f_10450_1559_1605(asyncMethod)).Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1630, 1669);

                    this.IteratorElementType = elementType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1689, 1767);

                    bool
                    isEnumerable = f_10450_1709_1766(asyncMethod, compilation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1785, 2041) || true) && (isEnumerable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10450, 1785, 2041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 1893, 2022);

                        f_10450_1893_2021(                    // IAsyncEnumerable<TResult>
                                            interfaces, f_10450_1908_2020(f_10450_1908_1997(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T), elementType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10450, 1785, 2041);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2107, 2236);

                    f_10450_2107_2235(
                                    // IAsyncEnumerator<TResult>
                                    interfaces, f_10450_2122_2234(f_10450_2122_2211(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T), elementType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2299, 2475);

                    f_10450_2299_2474(
                                    // IValueTaskSource<bool>
                                    interfaces, f_10450_2314_2473(f_10450_2314_2407(compilation, WellKnownType.System_Threading_Tasks_Sources_IValueTaskSource_T), f_10450_2418_2472(compilation, SpecialType.System_Boolean)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2532, 2640);

                    f_10450_2532_2639(
                                    // IValueTaskSource
                                    interfaces, f_10450_2547_2638(compilation, WellKnownType.System_Threading_Tasks_Sources_IValueTaskSource));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2697, 2781);

                    f_10450_2697_2780(
                                    // IAsyncDisposable
                                    interfaces, f_10450_2712_2779(compilation, WellKnownType.System_IAsyncDisposable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10450, 1470, 2796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2812, 2923);

                f_10450_2812_2922(
                            interfaces, f_10450_2827_2921(compilation, WellKnownType.System_Runtime_CompilerServices_IAsyncStateMachine));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2937, 2983);

                _interfaces = f_10450_2951_2982(interfaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 2999, 3100);

                _constructor = (DynAbs.Tracing.TraceSender.Conditional_F1(10450, 3014, 3024) || ((isIterator && DynAbs.Tracing.TraceSender.Conditional_F2(10450, 3027, 3070)) || DynAbs.Tracing.TraceSender.Conditional_F3(10450, 3073, 3099))) ? (MethodSymbol)f_10450_3041_3070(this) : f_10450_3073_3099(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10450, 930, 3111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 930, 3111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 930, 3111);
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10450, 3181, 3206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 3187, 3204);

                    return _typeKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10450, 3181, 3206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 3123, 3217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 3123, 3217);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10450, 3296, 3324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 3302, 3322);

                    return _constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10450, 3296, 3324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 3229, 3335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 3229, 3335);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10450, 3379, 3387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 3382, 3387);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10450, 3379, 3387);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 3379, 3387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 3379, 3387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10450, 3455, 3463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 3458, 3463);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10450, 3455, 3463);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 3455, 3463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 3455, 3463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10450, 3476, 3652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10450, 3622, 3641);

                return _interfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10450, 3476, 3652);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10450, 3476, 3652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 3476, 3652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AsyncStateMachine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10450, 590, 3659);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10450, 590, 3659);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10450, 590, 3659);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10450, 590, 3659);

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10450_1291_1323(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10450, 1291, 1323);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10450_1355_1398()
        {
            var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1355, 1398);
            return return_v;
        }


        bool
        f_10450_1433_1455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsIterator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10450, 1433, 1455);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10450_1536_1543()
        {
            var return_v = TypeMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10450, 1536, 1543);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10450_1559_1605(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IteratorElementTypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10450, 1559, 1605);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10450_1536_1606(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        previous)
        {
            var return_v = this_param.SubstituteType(previous);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1536, 1606);
            return return_v;
        }


        bool
        f_10450_1709_1766(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = method.IsAsyncReturningIAsyncEnumerable(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1709, 1766);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_1908_1997(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1908, 1997);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_1908_2020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1908, 2020);
            return return_v;
        }


        int
        f_10450_1893_2021(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 1893, 2021);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2122_2211(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2122, 2211);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2122_2234(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2122, 2234);
            return return_v;
        }


        int
        f_10450_2107_2235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2107, 2235);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2314_2407(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2314, 2407);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2418_2472(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2418, 2472);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2314_2473(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2314, 2473);
            return return_v;
        }


        int
        f_10450_2299_2474(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2299, 2474);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2547_2638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2547, 2638);
            return return_v;
        }


        int
        f_10450_2532_2639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2532, 2639);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2712_2779(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2712, 2779);
            return return_v;
        }


        int
        f_10450_2697_2780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2697, 2780);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10450_2827_2921(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.WellKnownType
        type)
        {
            var return_v = this_param.GetWellKnownType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2827, 2921);
            return return_v;
        }


        int
        f_10450_2812_2922(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2812, 2922);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10450_2951_2982(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 2951, 2982);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.IteratorConstructor
        f_10450_3041_3070(Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
        container)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorConstructor((Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol)container);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 3041, 3070);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.AsyncConstructor
        f_10450_3073_3099(Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
        stateMachineType)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncConstructor(stateMachineType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10450, 3073, 3099);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        f_10450_1127_1147_C(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10450, 930, 3111);
            return return_v;
        }

    }
}
